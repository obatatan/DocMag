using DocMag.DBAccesor;
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

namespace DocMag.Forms {
    public partial class CustomerMaintenance : Form {
        DocMagDbAccesor docMagDb = new DocMagDbAccesor();

        public CustomerMaintenance() {
            InitializeComponent();

            this.Load += (s, e) => {
                UpdateDisplay();
            };
        }

        private void UpdateDisplay() {
            var dt = docMagDb.GetDataTable(new DocMagDataSet().mst_customer);

            // 表示更新
            this.CostomerGrid.DataSource = dt;
        }
    }
}
