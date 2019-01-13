namespace Housing_intermediary_management_system
{
    partial class RenterMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RenterPage = new System.Windows.Forms.TabPage();
            this.dgvHouseInfo = new System.Windows.Forms.DataGridView();
            this.houseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtboxAreaTo = new System.Windows.Forms.TextBox();
            this.txtboxAreaFrom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxPriceTo = new System.Windows.Forms.TextBox();
            this.txtboxPriceFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTransactionStatus = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myOfferPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosueStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.RenterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RenterPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // RenterPage
            // 
            this.RenterPage.Controls.Add(this.dgvHouseInfo);
            this.RenterPage.Controls.Add(this.btnQuery);
            this.RenterPage.Controls.Add(this.btnSearch);
            this.RenterPage.Controls.Add(this.label9);
            this.RenterPage.Controls.Add(this.txtboxAddress);
            this.RenterPage.Controls.Add(this.label6);
            this.RenterPage.Controls.Add(this.label7);
            this.RenterPage.Controls.Add(this.txtboxAreaTo);
            this.RenterPage.Controls.Add(this.txtboxAreaFrom);
            this.RenterPage.Controls.Add(this.label8);
            this.RenterPage.Controls.Add(this.label5);
            this.RenterPage.Controls.Add(this.label4);
            this.RenterPage.Controls.Add(this.txtboxPriceTo);
            this.RenterPage.Controls.Add(this.txtboxPriceFrom);
            this.RenterPage.Controls.Add(this.label3);
            this.RenterPage.Controls.Add(this.label2);
            this.RenterPage.Controls.Add(this.label1);
            this.RenterPage.Location = new System.Drawing.Point(4, 22);
            this.RenterPage.Name = "RenterPage";
            this.RenterPage.Padding = new System.Windows.Forms.Padding(3);
            this.RenterPage.Size = new System.Drawing.Size(768, 442);
            this.RenterPage.TabIndex = 0;
            this.RenterPage.Text = "租客界面";
            this.RenterPage.UseVisualStyleBackColor = true;
            // 
            // dgvHouseInfo
            // 
            this.dgvHouseInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouseInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.houseId,
            this.housePrice,
            this.houseArea,
            this.address,
            this.tenantName,
            this.telephone,
            this.offer});
            this.dgvHouseInfo.Location = new System.Drawing.Point(20, 178);
            this.dgvHouseInfo.Name = "dgvHouseInfo";
            this.dgvHouseInfo.RowTemplate.Height = 23;
            this.dgvHouseInfo.Size = new System.Drawing.Size(729, 258);
            this.dgvHouseInfo.TabIndex = 15;
            this.dgvHouseInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHouseInfo_CellContentClick);
            // 
            // houseId
            // 
            this.houseId.DataPropertyName = "HouseId";
            this.houseId.HeaderText = "房屋编号";
            this.houseId.Name = "houseId";
            this.houseId.ReadOnly = true;
            // 
            // housePrice
            // 
            this.housePrice.DataPropertyName = "HousePrice";
            this.housePrice.HeaderText = "房屋价格";
            this.housePrice.Name = "housePrice";
            this.housePrice.ReadOnly = true;
            // 
            // houseArea
            // 
            this.houseArea.DataPropertyName = "HouseArea";
            this.houseArea.HeaderText = "房屋面积";
            this.houseArea.Name = "houseArea";
            this.houseArea.ReadOnly = true;
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.FillWeight = 200F;
            this.address.HeaderText = "房屋地址";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // tenantName
            // 
            this.tenantName.DataPropertyName = "TenantName";
            this.tenantName.HeaderText = "出租人";
            this.tenantName.Name = "tenantName";
            this.tenantName.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.DataPropertyName = "Telephone";
            this.telephone.HeaderText = "联系电话";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            // 
            // offer
            // 
            this.offer.DataPropertyName = "Offer";
            this.offer.HeaderText = "报价";
            this.offer.Name = "offer";
            this.offer.Text = "报价";
            // 
            // btnQuery
            // 
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuery.Font = new System.Drawing.Font("宋体", 15F);
            this.btnQuery.Location = new System.Drawing.Point(578, 109);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(158, 50);
            this.btnQuery.TabIndex = 14;
            this.btnQuery.Text = "查询成交情况";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("宋体", 15F);
            this.btnSearch.Location = new System.Drawing.Point(404, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 50);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "查询空闲房源";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "期望地址：";
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(110, 138);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(229, 21);
            this.txtboxAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 116);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "平米";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 117);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "—";
            // 
            // txtboxAreaTo
            // 
            this.txtboxAreaTo.Location = new System.Drawing.Point(239, 111);
            this.txtboxAreaTo.Name = "txtboxAreaTo";
            this.txtboxAreaTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtboxAreaTo.Size = new System.Drawing.Size(100, 21);
            this.txtboxAreaTo.TabIndex = 7;
            // 
            // txtboxAreaFrom
            // 
            this.txtboxAreaFrom.Location = new System.Drawing.Point(110, 111);
            this.txtboxAreaFrom.Name = "txtboxAreaFrom";
            this.txtboxAreaFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtboxAreaFrom.Size = new System.Drawing.Size(100, 21);
            this.txtboxAreaFrom.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 116);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "房屋面积：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "元/月";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "—";
            // 
            // txtboxPriceTo
            // 
            this.txtboxPriceTo.Location = new System.Drawing.Point(239, 84);
            this.txtboxPriceTo.Name = "txtboxPriceTo";
            this.txtboxPriceTo.Size = new System.Drawing.Size(100, 21);
            this.txtboxPriceTo.TabIndex = 3;
            // 
            // txtboxPriceFrom
            // 
            this.txtboxPriceFrom.Location = new System.Drawing.Point(110, 84);
            this.txtboxPriceFrom.Name = "txtboxPriceFrom";
            this.txtboxPriceFrom.Size = new System.Drawing.Size(100, 21);
            this.txtboxPriceFrom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "价格区间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(470, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "房源信息，一查便知！";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21F);
            this.label1.Location = new System.Drawing.Point(131, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用房屋中介系统！";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTransactionStatus);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "成交情况界面";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTransactionStatus
            // 
            this.dgvTransactionStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.myOfferPrice,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.hosueStatus});
            this.dgvTransactionStatus.Location = new System.Drawing.Point(19, 64);
            this.dgvTransactionStatus.Name = "dgvTransactionStatus";
            this.dgvTransactionStatus.RowTemplate.Height = 23;
            this.dgvTransactionStatus.Size = new System.Drawing.Size(729, 360);
            this.dgvTransactionStatus.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HouseId";
            this.dataGridViewTextBoxColumn1.HeaderText = "房屋编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 78;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HousePrice";
            this.dataGridViewTextBoxColumn2.HeaderText = "房屋价格";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // myOfferPrice
            // 
            this.myOfferPrice.DataPropertyName = "MyOfferPrice";
            this.myOfferPrice.HeaderText = "我的报价";
            this.myOfferPrice.Name = "myOfferPrice";
            this.myOfferPrice.ReadOnly = true;
            this.myOfferPrice.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HouseArea";
            this.dataGridViewTextBoxColumn3.HeaderText = "房屋面积";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.FillWeight = 200F;
            this.dataGridViewTextBoxColumn4.HeaderText = "房屋地址";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenantName";
            this.dataGridViewTextBoxColumn5.HeaderText = "出租人";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Telephone";
            this.dataGridViewTextBoxColumn6.HeaderText = "联系电话";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // hosueStatus
            // 
            this.hosueStatus.DataPropertyName = "HouseStatus";
            this.hosueStatus.HeaderText = "房屋状态";
            this.hosueStatus.Name = "hosueStatus";
            this.hosueStatus.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 16F);
            this.label10.Location = new System.Drawing.Point(45, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "成交情况：";
            // 
            // RenterMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.tabControl1);
            this.Name = "RenterMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "租客页面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RenterMain_FormClosed);
            this.Load += new System.EventHandler(this.RenterMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.RenterPage.ResumeLayout(false);
            this.RenterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RenterPage;
        private System.Windows.Forms.DataGridView dgvHouseInfo;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtboxAreaTo;
        private System.Windows.Forms.TextBox txtboxAreaFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxPriceTo;
        private System.Windows.Forms.TextBox txtboxPriceFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewButtonColumn offer;
        private System.Windows.Forms.DataGridView dgvTransactionStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn myOfferPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn hosueStatus;
    }
}