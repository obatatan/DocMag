namespace DocMag.Forms {
    partial class CustomerMaintenance {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CostomerKaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostomerBuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostomerCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostomerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostomerGrid = new Common.Grid();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CostomerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(318, 51);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 100);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CostomerGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 135);
            this.panel2.TabIndex = 3;
            // 
            // CostomerKaName
            // 
            this.CostomerKaName.DataPropertyName = "customer_ka_name";
            this.CostomerKaName.HeaderText = "顧客部課";
            this.CostomerKaName.Name = "CostomerKaName";
            // 
            // CostomerBuName
            // 
            this.CostomerBuName.DataPropertyName = "customer_bu_name";
            this.CostomerBuName.HeaderText = "顧客部署";
            this.CostomerBuName.Name = "CostomerBuName";
            // 
            // CostomerCompanyName
            // 
            this.CostomerCompanyName.DataPropertyName = "customer_company_name";
            this.CostomerCompanyName.HeaderText = "顧客会社";
            this.CostomerCompanyName.Name = "CostomerCompanyName";
            // 
            // CostomerName
            // 
            this.CostomerName.DataPropertyName = "customer_name";
            this.CostomerName.HeaderText = "顧客名";
            this.CostomerName.Name = "CostomerName";
            // 
            // CostomerNo
            // 
            this.CostomerNo.DataPropertyName = "customer_no";
            this.CostomerNo.HeaderText = "顧客№";
            this.CostomerNo.Name = "CostomerNo";
            // 
            // CostomerGrid
            // 
            this.CostomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CostomerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostomerNo,
            this.CostomerName,
            this.CostomerCompanyName,
            this.CostomerBuName,
            this.CostomerKaName});
            this.CostomerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CostomerGrid.Location = new System.Drawing.Point(0, 0);
            this.CostomerGrid.Name = "CostomerGrid";
            this.CostomerGrid.RowTemplate.Height = 21;
            this.CostomerGrid.Size = new System.Drawing.Size(588, 135);
            this.CostomerGrid.TabIndex = 0;
            // 
            // CustomerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 335);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerMaintenance";
            this.Text = "顧客メンテナンス";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CostomerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private Common.Grid CostomerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostomerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostomerCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostomerBuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostomerKaName;
    }
}

