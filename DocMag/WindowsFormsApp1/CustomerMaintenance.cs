using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSet;

namespace WindowsFormsApp1 {
    public partial class CustomerMaintenance : Form {
        public CustomerMaintenance() {
            InitializeComponent();

            using (MySqlConnection con = new MySqlConnection(
             "server=localhost;database=docmag;user=root;password=Password")) {
                //"userid=root;password=Password;database=docmag;Host=localhost")) {
                con.Open();
                //データを格納するDataTableを作成
                var ds = new DocMagDataSet();
                //DataTable dt = new DataTable();
                DataTable dt = ds.mst_customer;
                //var ss = ds.MstCustomer.customer_bu_nameColumn.ColumnName;

                //Select文を作成
                string Select_SQL = "select * from mst_customer  ";

                //SQL文と接続情報を指定し、MySQLコマンドを作成
                MySqlDataAdapter da = new MySqlDataAdapter(Select_SQL, con);

                //DataAdapterを指定し、自動的に更新コマンドを生成するコマンドビルダーを作成
                MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                //データ取得
                da.Fill(dt);

                //foreach (DataRow row in dt.Rows) {
                //    var a = row[ds.MstCustomer.customer_bu_nameColumn.ColumnName];
                //    row["customer_ka_name"] = "aaaaaaaaaaaaa";
                //    var b = row["customer_ka_name"];
                //}

                //データ表示
                this.CostomerGrid.DataSource = dt;
            }
        }

        private void BtnUpdate_Clike(object sender, EventArgs e) {

        }
    }
}
