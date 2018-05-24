using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DocMag.DBAccesor {
    public abstract class AbstDbAccesor<C, A, M> : IDbAccesor 
        where C : DbConnection, new()
        where A : DbDataAdapter, new()
        where M : DbCommand, new()
        {

        public abstract string ConnectionStr { get; }

        public Dictionary<string, string> ParameterDic { get; set; } = new Dictionary<string, string>();

        public DbConnection Con { get; set; }

        public bool Connect() {
            try {
                if (Con == null) {
                    Con = new C();
                    Con.ConnectionString = ConnectionStr;
                }
                if (Status() != ConnectionState.Open) Con.Open();
            } catch {
                return false;
            }
            return true;
        }

        public bool Close() {
            try {

                Con.Close();
            } catch {
                return false;
            }
            return true;
        }

        public ConnectionState Status() {
            if (Con == null) return ConnectionState.Closed; 
            return Con.State;
        }

        /// <summary>
        /// SELECTを実行。実行結果はDataTable型で返却
        /// </summary>
        /// <param name="query"></param>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public virtual DataTable SelectDataTable(string query, IListSource dataTable = null) {
            if (Con == null || Status() == ConnectionState.Closed) Connect();

            if (dataTable == null) dataTable = new DataTable();
            DataTable dt = (DataTable)dataTable;

            var cmd = new M() { CommandText = query, Connection = Con };
            var da = new A() { SelectCommand = cmd };

            da.Fill(dt);
            return dt;
        }

        /// <summary>
        /// SELECTを実行。実行結果はDataReader型で返却
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public virtual IEnumerable<DbDataReader> SelectDataReader(string query) {
            return null;
        }

        /// <summary>
        /// INSERT、UPDATE、DELETEを実行
        /// </summary>
        /// <param name="query"></param>
        /// <returns>影響のあった行数</returns>
        public virtual int InsertOrUpdateOrDelete(string query) {
            var transaction = Con.BeginTransaction(IsolationLevel.ReadCommitted);

            int ret = 0;
            try {
                var cmd = new M();

                cmd.CommandText = query;
                cmd.Connection = Con;
                cmd.Transaction = transaction;
                SetParameters(cmd);
                ret = cmd.ExecuteNonQuery();

                transaction.Commit();

            } catch (System.Exception) {
                transaction.Rollback();
                return -1;
            }
            return ret;
        }

        /// <summary>
        /// SQLパラメータを追加
        /// (「@」や「:」は不要)
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        protected virtual void AddParameters(string key, string value) {
            ParameterDic.Add(key, value);
        }

        private DbCommand SetParameters(DbCommand cmd) {
            foreach (var dic in ParameterDic) {
                cmd.Parameters.Add(new SqlParameter($"@{dic.Key}", dic.Value));
            }
            return cmd;
        }
    }
}
