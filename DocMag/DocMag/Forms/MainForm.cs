using DocMag.Forms.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocMag.Forms {
    public partial class MainForm : Form {
        List<IForm> formList = new List<IForm> {
            new MstCustomer()
        };

        public MainForm() {
            InitializeComponent();

            this.Load += (s, e) => {
                foreach(var form in formList) {
                    var btn = new Button();
                    btn.Text = form.ScreenName;
                    btn.Dock = DockStyle.Top;
                    btn.Click += (s2, e2) => {
                        var control = (Control)form;
                        control.Dock = DockStyle.Fill;
                        this.pnlMain.Controls.Add(control);
                    };
                    this.pnlBtn.Controls.Add(btn);
                }
            };

        }
    }
}
