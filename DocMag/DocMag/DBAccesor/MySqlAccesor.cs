using MySql.Data.MySqlClient;
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
    public class MySqlAccesor : AbstDbAccesor {
        public override string ConnectionStr { get { throw new NotImplementedException(); } }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MySqlAccesor() {
            Con = new MySqlConnection(ConnectionStr);
            Connect();
        }

        /// <summary>
        /// デストラクタ
        /// </summary>
        ~MySqlAccesor() {
            Close();
            Con.Dispose();
        }

        public DataTable GetDataTable(IListSource dataTable) {
            DataTable dt = (DataTable)dataTable;
            MySqlDataAdapter da = new MySqlDataAdapter(
                $@"SELECT * FROM {dt.TableName}"
                , (MySqlConnection)Con
                );

            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            da.Fill(dt);
            return dt;
        }

        public bool ExecuteDuplicateInsert(IListSource dataTable) {
            DataTable dt = (DataTable)dataTable;
            string query = $@"INSERT INTO
       {dt.TableName} ({CreateColumnsString(dataTable)})
   VALUES
       {CreateValuesString(dataTable)}
   ON DUPLICATE KEY UPDATE
        {CreateDuplicateUpdateString(dataTable)};";

            return true;
        }

        private string CreateValuesString(IListSource dataTable) {
            DataTable dt = (DataTable)dataTable;
            var rowStrList = new List<string>();
            foreach (var row in dt.Rows) {
                foreach (var col in dt.Columns) {
                    string column = ((DataRow)row)[((DataColumn)col).ColumnName].ToString();
                }
            }
            var colNameList = new List<string>();
            foreach (var col in dt.Columns) {
                if (((UniqueConstraint)dt.Constraints[0]).Columns.Contains((DataColumn)col)) {
                    continue;
                }
                colNameList.Add(((DataColumn)col).ColumnName);
            }
            return string.Join(",", colNameList);
        }

        private string CreateColumnsString(IListSource dataTable) {
            DataTable dt = (DataTable)dataTable;
            var colNameList = new List<string>();
            foreach(var col in dt.Columns) {
                //if (((UniqueConstraint)dt.Constraints[0]).Columns.Contains((DataColumn)col)) {
                //    continue;
                //}
                colNameList.Add(((DataColumn)col).ColumnName);
            }
            return string.Join(",", colNameList);
        }

        private string CreateDuplicateUpdateString(IListSource dataTable) {
            DataTable dt = (DataTable)dataTable;
            foreach (var row in dt.Rows) {
                foreach (var col in dt.Columns) {
                    string column = ((DataRow)row)[((DataColumn)col).ColumnName].ToString();
                }
            }
            var colNameList = new List<string>();
            foreach (var col in dt.Columns) {
                if (((UniqueConstraint)dt.Constraints[0]).Columns.Contains((DataColumn)col)) {
                    continue;
                }
                colNameList.Add(((DataColumn)col).ColumnName);
            }
            return string.Join(",", colNameList);
        }
    }
}
