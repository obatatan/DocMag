using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocMag.DataSet;
using DocMag.DBAccesor;

namespace DocMag.Forms.Master {
    public partial class MstCustomer : FormBase, IForm {
        public string ScreenName { get { return "顧客マスタ"; } }

        DocMagDbAccesor docMagDbAccesor = new DocMagDbAccesor();
        private GridCustomer _grid = new GridCustomer();
        private GridCustomer Grid { get { return _grid; } set { value = _grid; } }

        public MstCustomer() {
            InitializeComponent();

            _grid.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(Grid);
            UpdateDisplay();

            //this.btnUpdate
        }

        private void UpdateDisplay() {
            var dt = docMagDbAccesor.GetDataTable(new DocMagDataSet().mst_customer);

            // 表示更新
            this._grid.Grid.DataSource = dt;
        }

        protected override bool UpdateLogic() {
            var dt = this._grid.Grid.DataSource;
            docMagDbAccesor.ExecuteDuplicateInsert((IListSource)dt);
            return true;
        }
    }
}
