namespace DocMag.Forms {
    partial class GridCustomer {
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.Grid = new Common.Grid();
            this.CostomerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostomerCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostomerBuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostomerKaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostomerNo,
            this.CostomerName,
            this.CostomerCompanyName,
            this.CostomerBuName,
            this.CostomerKaName});
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.Name = "Grid";
            this.Grid.RowTemplate.Height = 21;
            this.Grid.Size = new System.Drawing.Size(558, 385);
            this.Grid.TabIndex = 1;
            // 
            // CostomerNo
            // 
            this.CostomerNo.DataPropertyName = "customer_no";
            this.CostomerNo.HeaderText = "顧客№";
            this.CostomerNo.Name = "CostomerNo";
            // 
            // CostomerName
            // 
            this.CostomerName.DataPropertyName = "customer_name";
            this.CostomerName.HeaderText = "顧客名";
            this.CostomerName.Name = "CostomerName";
            // 
            // CostomerCompanyName
            // 
            this.CostomerCompanyName.DataPropertyName = "customer_company_name";
            this.CostomerCompanyName.HeaderText = "顧客会社";
            this.CostomerCompanyName.Name = "CostomerCompanyName";
            // 
            // CostomerBuName
            // 
            this.CostomerBuName.DataPropertyName = "customer_bu_name";
            this.CostomerBuName.HeaderText = "顧客部署";
            this.CostomerBuName.Name = "CostomerBuName";
            // 
            // CostomerKaName
            // 
            this.CostomerKaName.DataPropertyName = "customer_ka_name";
            this.CostomerKaName.HeaderText = "顧客部課";
            this.CostomerKaName.Name = "CostomerKaName";
            // 
            // GridCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Name = "GridCustomer";
            this.Size = new System.Drawing.Size(558, 385);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn CostomerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostomerCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostomerBuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostomerKaName;
        public Common.Grid Grid;
    }
}
