namespace Housing_intermediary_management_system
{
    partial class TenantMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.renterIntentPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHouseInfo = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.houseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.houseIdInterested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePriceInterested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterNameInterested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneInterested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agree = new System.Windows.Forms.DataGridViewButtonColumn();
            this.reject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.renterIntentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainPage);
            this.tabControl.Controls.Add(this.renterIntentPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 468);
            this.tabControl.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.dgvHouseInfo);
            this.mainPage.Controls.Add(this.label2);
            this.mainPage.Controls.Add(this.btnQuery);
            this.mainPage.Controls.Add(this.btnRelease);
            this.mainPage.Controls.Add(this.label1);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(768, 442);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "主界面";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // renterIntentPage
            // 
            this.renterIntentPage.Controls.Add(this.label3);
            this.renterIntentPage.Controls.Add(this.dataGridView1);
            this.renterIntentPage.Location = new System.Drawing.Point(4, 22);
            this.renterIntentPage.Name = "renterIntentPage";
            this.renterIntentPage.Padding = new System.Windows.Forms.Padding(3);
            this.renterIntentPage.Size = new System.Drawing.Size(768, 442);
            this.renterIntentPage.TabIndex = 1;
            this.renterIntentPage.Text = "租客意向界面";
            this.renterIntentPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F);
            this.label1.Location = new System.Drawing.Point(78, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎房主大大！";
            // 
            // btnRelease
            // 
            this.btnRelease.AutoSize = true;
            this.btnRelease.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRelease.Location = new System.Drawing.Point(455, 42);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(119, 30);
            this.btnRelease.TabIndex = 1;
            this.btnRelease.Text = "发布新房源";
            this.btnRelease.UseVisualStyleBackColor = true;
            // 
            // btnQuery
            // 
            this.btnQuery.AutoSize = true;
            this.btnQuery.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(580, 42);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(159, 30);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "查询租客意向";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(31, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "我发布的房源信息：";
            // 
            // dgvHouseInfo
            // 
            this.dgvHouseInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouseInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.houseId,
            this.housePrice,
            this.houseArea,
            this.address,
            this.houseState,
            this.renterName,
            this.telephone});
            this.dgvHouseInfo.Location = new System.Drawing.Point(34, 166);
            this.dgvHouseInfo.Margin = new System.Windows.Forms.Padding(30, 12, 30, 30);
            this.dgvHouseInfo.Name = "dgvHouseInfo";
            this.dgvHouseInfo.RowTemplate.Height = 23;
            this.dgvHouseInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouseInfo.Size = new System.Drawing.Size(705, 253);
            this.dgvHouseInfo.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.houseIdInterested,
            this.housePriceInterested,
            this.offerPrice,
            this.renterNameInterested,
            this.PhoneInterested,
            this.agree,
            this.reject});
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(759, 391);
            this.dataGridView1.TabIndex = 0;
            // 
            // houseId
            // 
            this.houseId.HeaderText = "房屋编号";
            this.houseId.Name = "houseId";
            this.houseId.ReadOnly = true;
            // 
            // housePrice
            // 
            this.housePrice.HeaderText = "月租金";
            this.housePrice.Name = "housePrice";
            this.housePrice.ReadOnly = true;
            // 
            // houseArea
            // 
            this.houseArea.HeaderText = "房屋面积";
            this.houseArea.Name = "houseArea";
            this.houseArea.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "房屋地址";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // houseState
            // 
            this.houseState.HeaderText = "房屋状态";
            this.houseState.Name = "houseState";
            this.houseState.ReadOnly = true;
            // 
            // renterName
            // 
            this.renterName.HeaderText = "租客名称";
            this.renterName.Name = "renterName";
            this.renterName.ReadOnly = true;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "联系电话";
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(682, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "以下是租客意向列表及报价，您可以点击按钮同意出租或者拒绝，亦或者直接通过电话号码联系对方！";
            // 
            // houseIdInterested
            // 
            this.houseIdInterested.HeaderText = "房屋编号";
            this.houseIdInterested.Name = "houseIdInterested";
            this.houseIdInterested.ReadOnly = true;
            // 
            // housePriceInterested
            // 
            this.housePriceInterested.HeaderText = "房屋价格";
            this.housePriceInterested.Name = "housePriceInterested";
            this.housePriceInterested.ReadOnly = true;
            // 
            // offerPrice
            // 
            this.offerPrice.HeaderText = "对方出价";
            this.offerPrice.Name = "offerPrice";
            this.offerPrice.ReadOnly = true;
            // 
            // renterNameInterested
            // 
            this.renterNameInterested.HeaderText = "租客名称";
            this.renterNameInterested.Name = "renterNameInterested";
            this.renterNameInterested.ReadOnly = true;
            // 
            // PhoneInterested
            // 
            this.PhoneInterested.HeaderText = "联系电话";
            this.PhoneInterested.Name = "PhoneInterested";
            this.PhoneInterested.ReadOnly = true;
            // 
            // agree
            // 
            this.agree.HeaderText = "同意出租";
            this.agree.Name = "agree";
            // 
            // reject
            // 
            this.reject.HeaderText = "拒绝出租";
            this.reject.Name = "reject";
            // 
            // TenantMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.tabControl);
            this.Name = "TenantMain";
            this.Text = "出租者主界面";
            this.tabControl.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.renterIntentPage.ResumeLayout(false);
            this.renterIntentPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage renterIntentPage;
        private System.Windows.Forms.DataGridView dgvHouseInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseState;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseIdInterested;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePriceInterested;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterNameInterested;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneInterested;
        private System.Windows.Forms.DataGridViewButtonColumn agree;
        private System.Windows.Forms.DataGridViewButtonColumn reject;
    }
}