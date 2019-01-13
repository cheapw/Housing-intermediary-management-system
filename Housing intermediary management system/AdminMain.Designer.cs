namespace Housing_intermediary_management_system
{
    partial class AdminMain
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearchAllHouse = new System.Windows.Forms.Button();
            this.btnSearchAllRenter = new System.Windows.Forms.Button();
            this.btnSearchAllTenant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearchTenant = new System.Windows.Forms.Button();
            this.txtboxTenantId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTenantInfo = new System.Windows.Forms.DataGridView();
            this.tenantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSearchRenter = new System.Windows.Forms.Button();
            this.txtboxRenterId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRenterInfo = new System.Windows.Forms.DataGridView();
            this.renterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renterTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSearchHouse = new System.Windows.Forms.Button();
            this.txtboxHouseId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvHouseInfo = new System.Windows.Forms.DataGridView();
            this.houseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseTenantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseRenterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offerPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenantInfo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenterInfo)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSearchAllHouse);
            this.tabPage1.Controls.Add(this.btnSearchAllRenter);
            this.tabPage1.Controls.Add(this.btnSearchAllTenant);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主界面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSearchAllHouse
            // 
            this.btnSearchAllHouse.AutoSize = true;
            this.btnSearchAllHouse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchAllHouse.Font = new System.Drawing.Font("宋体", 20F);
            this.btnSearchAllHouse.Location = new System.Drawing.Point(292, 252);
            this.btnSearchAllHouse.Name = "btnSearchAllHouse";
            this.btnSearchAllHouse.Size = new System.Drawing.Size(184, 37);
            this.btnSearchAllHouse.TabIndex = 2;
            this.btnSearchAllHouse.Text = "查询房源信息";
            this.btnSearchAllHouse.UseVisualStyleBackColor = true;
            this.btnSearchAllHouse.Click += new System.EventHandler(this.btnSearchAllHouse_Click);
            // 
            // btnSearchAllRenter
            // 
            this.btnSearchAllRenter.AutoSize = true;
            this.btnSearchAllRenter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchAllRenter.Font = new System.Drawing.Font("宋体", 20F);
            this.btnSearchAllRenter.Location = new System.Drawing.Point(419, 161);
            this.btnSearchAllRenter.Name = "btnSearchAllRenter";
            this.btnSearchAllRenter.Size = new System.Drawing.Size(238, 37);
            this.btnSearchAllRenter.TabIndex = 2;
            this.btnSearchAllRenter.Text = "查询所有租客信息";
            this.btnSearchAllRenter.UseVisualStyleBackColor = true;
            this.btnSearchAllRenter.Click += new System.EventHandler(this.btnSearchAllRenter_Click);
            // 
            // btnSearchAllTenant
            // 
            this.btnSearchAllTenant.AutoSize = true;
            this.btnSearchAllTenant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchAllTenant.Font = new System.Drawing.Font("宋体", 20F);
            this.btnSearchAllTenant.Location = new System.Drawing.Point(111, 161);
            this.btnSearchAllTenant.Name = "btnSearchAllTenant";
            this.btnSearchAllTenant.Size = new System.Drawing.Size(238, 37);
            this.btnSearchAllTenant.TabIndex = 2;
            this.btnSearchAllTenant.Text = "查询所有房主信息";
            this.btnSearchAllTenant.UseVisualStyleBackColor = true;
            this.btnSearchAllTenant.Click += new System.EventHandler(this.btnSearchAllTenant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21F);
            this.label1.Location = new System.Drawing.Point(224, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "房屋中介系统管理员窗口";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSearchTenant);
            this.tabPage2.Controls.Add(this.txtboxTenantId);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvTenantInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "房主信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearchTenant
            // 
            this.btnSearchTenant.Location = new System.Drawing.Point(529, 19);
            this.btnSearchTenant.Name = "btnSearchTenant";
            this.btnSearchTenant.Size = new System.Drawing.Size(103, 23);
            this.btnSearchTenant.TabIndex = 4;
            this.btnSearchTenant.Text = "查询";
            this.btnSearchTenant.UseVisualStyleBackColor = true;
            this.btnSearchTenant.Click += new System.EventHandler(this.btnSearchTenant_Click);
            // 
            // txtboxTenantId
            // 
            this.txtboxTenantId.Location = new System.Drawing.Point(346, 20);
            this.txtboxTenantId.Name = "txtboxTenantId";
            this.txtboxTenantId.Size = new System.Drawing.Size(141, 21);
            this.txtboxTenantId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(205, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "请输入房主编号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(33, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "单个房主信息查询：";
            // 
            // dgvTenantInfo
            // 
            this.dgvTenantInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTenantInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenantId,
            this.tenantAccount,
            this.tenantName,
            this.tenantTelephone});
            this.dgvTenantInfo.Location = new System.Drawing.Point(22, 53);
            this.dgvTenantInfo.Name = "dgvTenantInfo";
            this.dgvTenantInfo.RowTemplate.Height = 23;
            this.dgvTenantInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTenantInfo.Size = new System.Drawing.Size(724, 329);
            this.dgvTenantInfo.TabIndex = 0;
            // 
            // tenantId
            // 
            this.tenantId.DataPropertyName = "Tid";
            this.tenantId.HeaderText = "编号";
            this.tenantId.Name = "tenantId";
            this.tenantId.Width = 130;
            // 
            // tenantAccount
            // 
            this.tenantAccount.DataPropertyName = "Taccount";
            this.tenantAccount.HeaderText = "账号";
            this.tenantAccount.Name = "tenantAccount";
            this.tenantAccount.Width = 150;
            // 
            // tenantName
            // 
            this.tenantName.DataPropertyName = "Tname";
            this.tenantName.HeaderText = "昵称";
            this.tenantName.Name = "tenantName";
            this.tenantName.Width = 150;
            // 
            // tenantTelephone
            // 
            this.tenantTelephone.DataPropertyName = "telephone";
            this.tenantTelephone.HeaderText = "联系电话";
            this.tenantTelephone.Name = "tenantTelephone";
            this.tenantTelephone.Width = 180;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSearchRenter);
            this.tabPage3.Controls.Add(this.txtboxRenterId);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dgvRenterInfo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "租客信息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSearchRenter
            // 
            this.btnSearchRenter.Location = new System.Drawing.Point(529, 19);
            this.btnSearchRenter.Name = "btnSearchRenter";
            this.btnSearchRenter.Size = new System.Drawing.Size(103, 23);
            this.btnSearchRenter.TabIndex = 9;
            this.btnSearchRenter.Text = "查询";
            this.btnSearchRenter.UseVisualStyleBackColor = true;
            this.btnSearchRenter.Click += new System.EventHandler(this.btnSearchRenter_Click);
            // 
            // txtboxRenterId
            // 
            this.txtboxRenterId.Location = new System.Drawing.Point(346, 20);
            this.txtboxRenterId.Name = "txtboxRenterId";
            this.txtboxRenterId.Size = new System.Drawing.Size(141, 21);
            this.txtboxRenterId.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(205, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "请输入租客编号:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(33, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "单个租客信息查询：";
            // 
            // dgvRenterInfo
            // 
            this.dgvRenterInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenterInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.renterId,
            this.renterAccount,
            this.renterName,
            this.renterTelephone});
            this.dgvRenterInfo.Location = new System.Drawing.Point(22, 53);
            this.dgvRenterInfo.Name = "dgvRenterInfo";
            this.dgvRenterInfo.RowTemplate.Height = 23;
            this.dgvRenterInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRenterInfo.Size = new System.Drawing.Size(724, 329);
            this.dgvRenterInfo.TabIndex = 5;
            // 
            // renterId
            // 
            this.renterId.DataPropertyName = "Rid";
            this.renterId.HeaderText = "编号";
            this.renterId.Name = "renterId";
            this.renterId.Width = 130;
            // 
            // renterAccount
            // 
            this.renterAccount.DataPropertyName = "Raccount";
            this.renterAccount.HeaderText = "账号";
            this.renterAccount.Name = "renterAccount";
            this.renterAccount.Width = 150;
            // 
            // renterName
            // 
            this.renterName.DataPropertyName = "Rname";
            this.renterName.HeaderText = "昵称";
            this.renterName.Name = "renterName";
            this.renterName.Width = 150;
            // 
            // renterTelephone
            // 
            this.renterTelephone.DataPropertyName = "telephone";
            this.renterTelephone.HeaderText = "联系电话";
            this.renterTelephone.Name = "renterTelephone";
            this.renterTelephone.Width = 180;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnSearchHouse);
            this.tabPage4.Controls.Add(this.txtboxHouseId);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.dgvHouseInfo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "房源信息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnSearchHouse
            // 
            this.btnSearchHouse.Location = new System.Drawing.Point(529, 19);
            this.btnSearchHouse.Name = "btnSearchHouse";
            this.btnSearchHouse.Size = new System.Drawing.Size(103, 23);
            this.btnSearchHouse.TabIndex = 9;
            this.btnSearchHouse.Text = "查询";
            this.btnSearchHouse.UseVisualStyleBackColor = true;
            this.btnSearchHouse.Click += new System.EventHandler(this.btnSearchHouse_Click);
            // 
            // txtboxHouseId
            // 
            this.txtboxHouseId.Location = new System.Drawing.Point(346, 20);
            this.txtboxHouseId.Name = "txtboxHouseId";
            this.txtboxHouseId.Size = new System.Drawing.Size(141, 21);
            this.txtboxHouseId.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(205, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "请输入房源编号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(33, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "单个房源信息查询：";
            // 
            // dgvHouseInfo
            // 
            this.dgvHouseInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouseInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.houseId,
            this.housePrice,
            this.houseArea,
            this.houseState,
            this.address,
            this.houseTenantId,
            this.houseRenterId,
            this.offerPrice});
            this.dgvHouseInfo.Location = new System.Drawing.Point(22, 53);
            this.dgvHouseInfo.Name = "dgvHouseInfo";
            this.dgvHouseInfo.RowTemplate.Height = 23;
            this.dgvHouseInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouseInfo.Size = new System.Drawing.Size(724, 329);
            this.dgvHouseInfo.TabIndex = 5;
            // 
            // houseId
            // 
            this.houseId.DataPropertyName = "HouseId";
            this.houseId.HeaderText = "房屋编号";
            this.houseId.Name = "houseId";
            // 
            // housePrice
            // 
            this.housePrice.DataPropertyName = "HousePrice";
            this.housePrice.HeaderText = "价格";
            this.housePrice.Name = "housePrice";
            // 
            // houseArea
            // 
            this.houseArea.DataPropertyName = "HouseArea";
            this.houseArea.HeaderText = "面积";
            this.houseArea.Name = "houseArea";
            // 
            // houseState
            // 
            this.houseState.DataPropertyName = "HouseState";
            this.houseState.HeaderText = "房屋状态";
            this.houseState.Name = "houseState";
            // 
            // address
            // 
            this.address.DataPropertyName = "Address";
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            // 
            // houseTenantId
            // 
            this.houseTenantId.DataPropertyName = "TenantId";
            this.houseTenantId.HeaderText = "房主编号";
            this.houseTenantId.Name = "houseTenantId";
            // 
            // houseRenterId
            // 
            this.houseRenterId.DataPropertyName = "RenterId";
            this.houseRenterId.HeaderText = "租客编号";
            this.houseRenterId.Name = "houseRenterId";
            // 
            // offerPrice
            // 
            this.offerPrice.DataPropertyName = "OfferPrice";
            this.offerPrice.HeaderText = "报价";
            this.offerPrice.Name = "offerPrice";
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMain_FormClosed);
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTenantInfo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenterInfo)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouseInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSearchAllHouse;
        private System.Windows.Forms.Button btnSearchAllRenter;
        private System.Windows.Forms.Button btnSearchAllTenant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTenantInfo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchTenant;
        private System.Windows.Forms.TextBox txtboxTenantId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchRenter;
        private System.Windows.Forms.TextBox txtboxRenterId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRenterInfo;
        private System.Windows.Forms.Button btnSearchHouse;
        private System.Windows.Forms.TextBox txtboxHouseId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvHouseInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn renterTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseState;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseTenantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseRenterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn offerPrice;
    }
}