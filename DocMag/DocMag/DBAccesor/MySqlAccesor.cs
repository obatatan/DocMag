﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocMag.DBAccesor {
    public class MySqlAccesor : AbstDbAccesor<MySqlConnection, MySqlDataAdapter, MySqlCommand> {
        public override string ConnectionStr { get { throw new NotImplementedException(); } }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MySqlAccesor() {
            Connect();
        }

        /// <summary>
        /// デストラクタ
        /// </summary>
        ~MySqlAccesor() {
            Close();
            Con.Dispose();
        }

        /// <summary>
        /// DDからDataTable形式でデータを取得
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public DataTable GetDataTable(IListSource dataTable) {
            DataTable dt = (DataTable)dataTable;
            MySqlDataAdapter da = new MySqlDataAdapter(
                $@"SELECT * FROM {dt.TableName}"
                , (MySqlConnection)Con
                );

            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            da.Fill(dt);
            return SelectDataTable($@"SELECT * FROM {dt.TableName}", dataTable);
        }

        ///<para>データをインサートします。</para>
        /// <para>指定したキーでデータが存在する場合、キー以外をアップデートする。</para>
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns>影響のあった行数(エラーの場合は-1を返却)</returns>
        public virtual int ExecuteDuplicateInsert(IListSource dataTable) {
            if (Status() != ConnectionState.Open)
                if (Connect())
                    return -1;

            DataTable dt = (DataTable)dataTable;

            #region クエリ
            string query = $@"INSERT INTO
       {dt.TableName} ({CreateColumnsString(dataTable)})
   VALUES
       {CreateValuesString(dataTable)}
   ON DUPLICATE KEY UPDATE
        {CreateDuplicateUpdateString(dataTable)};";
            #endregion

            return InsertOrUpdateOrDelete(query);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        protected virtual string CreateValuesString(IListSource dataTable) {
            DataTable dt = (DataTable)dataTable;
            var rowStrList = new List<string>();
            foreach (var row in dt.Rows) {
                var colStrList = new List<string>();
                foreach (var col in dt.Columns) {
                    if (((DataColumn)col).DataType == typeof(String)) {
                        colStrList.Add($"'{((DataRow)row)[((DataColumn)col).ColumnName].ToString()}'");
                    } else {
                        colStrList.Add(((DataRow)row)[((DataColumn)col).ColumnName].ToString());
                    }
                }
                rowStrList.Add($"({string.Join(",", colStrList)})");
            }
            return string.Join(",", rowStrList);
        }

        protected virtual string CreateColumnsString(IListSource dataTable) {
            DataTable dt = (DataTable)dataTable;
            var colNameList = new List<string>();
            foreach(var col in dt.Columns) {
                colNameList.Add(((DataColumn)col).ColumnName);
            }
            return string.Join(",", colNameList);
        }

        protected virtual string CreateDuplicateUpdateString(IListSource dataTable) {
            DataTable dt = (DataTable)dataTable;
            var colNameList = new List<string>();
            foreach (var col in dt.Columns) {
                if (((UniqueConstraint)dt.Constraints[0]).Columns.Contains((DataColumn)col))
                    continue;

                var colName = ((DataColumn)col).ColumnName;
                colNameList.Add($"{colName} = VALUES({colName})");
            }
            return string.Join(",", colNameList);
        }
    }
}
