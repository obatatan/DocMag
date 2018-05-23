using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocMag.Forms {
    public partial class FormBase : UserControl, IFormBase {
        public FormBase() {
            InitializeComponent();

            this.btnUpdate.Click += (s, e) => {
                if (UpdateLogic())
                    MessageBox.Show("更新しました。");
                else
                    MessageBox.Show("更新に失敗しました。");
            };
        }

        protected virtual bool UpdateLogic() {
            throw new NotImplementedException("[未実装]UpdateLogic");
        }
    }
}
