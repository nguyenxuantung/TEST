namespace QuanLyKinhDoanhDienThoai
{
    partial class frmCustomer_update
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer_update));
            this.tctCustomer = new System.Windows.Forms.TabControl();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.txtTotalCustomer = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txtCustomerAdress = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLIKINHDOANHDIENTHOAIDataSet = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSet();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.menuStrip11 = new System.Windows.Forms.MenuStrip();
            this.tmsiCustomer_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiCustomer_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiCustomer_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tblCustomerTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblCustomerTableAdapter();
            this.tctCustomer.SuspendLayout();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).BeginInit();
            this.menuStrip11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctCustomer
            // 
            this.tctCustomer.Controls.Add(this.tabPage11);
            this.tctCustomer.Location = new System.Drawing.Point(0, 0);
            this.tctCustomer.Name = "tctCustomer";
            this.tctCustomer.SelectedIndex = 0;
            this.tctCustomer.Size = new System.Drawing.Size(889, 651);
            this.tctCustomer.TabIndex = 1;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.txtTotalCustomer);
            this.tabPage11.Controls.Add(this.label43);
            this.tabPage11.Controls.Add(this.label47);
            this.tabPage11.Controls.Add(this.txtCustomerAdress);
            this.tabPage11.Controls.Add(this.label48);
            this.tabPage11.Controls.Add(this.txtCustomerPhone);
            this.tabPage11.Controls.Add(this.dgvCustomer);
            this.tabPage11.Controls.Add(this.label51);
            this.tabPage11.Controls.Add(this.label52);
            this.tabPage11.Controls.Add(this.txtCustomerName);
            this.tabPage11.Controls.Add(this.txtCustomerId);
            this.tabPage11.Controls.Add(this.menuStrip11);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(881, 625);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Khách hàng";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // txtTotalCustomer
            // 
            this.txtTotalCustomer.Location = new System.Drawing.Point(56, 599);
            this.txtTotalCustomer.Name = "txtTotalCustomer";
            this.txtTotalCustomer.Size = new System.Drawing.Size(180, 20);
            this.txtTotalCustomer.TabIndex = 22;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(18, 602);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(35, 13);
            this.label43.TabIndex = 21;
            this.label43.Text = "Tổng:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(528, 118);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(43, 13);
            this.label47.TabIndex = 18;
            this.label47.Text = "Địa chỉ:";
            // 
            // txtCustomerAdress
            // 
            this.txtCustomerAdress.Location = new System.Drawing.Point(624, 115);
            this.txtCustomerAdress.Name = "txtCustomerAdress";
            this.txtCustomerAdress.Size = new System.Drawing.Size(227, 20);
            this.txtCustomerAdress.TabIndex = 3;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(528, 154);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(73, 13);
            this.label48.TabIndex = 16;
            this.label48.Text = "Số điện thoại:";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(624, 151);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(227, 20);
            this.txtCustomerPhone.TabIndex = 4;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgvCustomer.DataSource = this.tblCustomerBindingSource;
            this.dgvCustomer.Location = new System.Drawing.Point(20, 40);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(480, 553);
            this.dgvCustomer.TabIndex = 10;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            this.dgvCustomer.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCustomer_RowPostPaint);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Mã KH";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 130;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // qUANLIKINHDOANHDIENTHOAIDataSet
            // 
            this.qUANLIKINHDOANHDIENTHOAIDataSet.DataSetName = "QUANLIKINHDOANHDIENTHOAIDataSet";
            this.qUANLIKINHDOANHDIENTHOAIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(529, 44);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(85, 13);
            this.label51.TabIndex = 6;
            this.label51.Text = "Mã khách hàng:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(528, 82);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(57, 13);
            this.label52.TabIndex = 7;
            this.label52.Text = "Họ và tên:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(624, 80);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(227, 20);
            this.txtCustomerName.TabIndex = 2;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(624, 41);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(227, 20);
            this.txtCustomerId.TabIndex = 1;
            // 
            // menuStrip11
            // 
            this.menuStrip11.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip11.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsiCustomer_New,
            this.tmsiCustomer_Save,
            this.tmsiCustomer_Delete});
            this.menuStrip11.Location = new System.Drawing.Point(3, 3);
            this.menuStrip11.Name = "menuStrip11";
            this.menuStrip11.Size = new System.Drawing.Size(875, 24);
            this.menuStrip11.TabIndex = 9;
            this.menuStrip11.Text = "menuStrip11";
            // 
            // tmsiCustomer_New
            // 
            this.tmsiCustomer_New.Image = ((System.Drawing.Image)(resources.GetObject("tmsiCustomer_New.Image")));
            this.tmsiCustomer_New.Name = "tmsiCustomer_New";
            this.tmsiCustomer_New.Size = new System.Drawing.Size(90, 20);
            this.tmsiCustomer_New.Text = "Thêm mới";
            this.tmsiCustomer_New.Click += new System.EventHandler(this.tmsiCustomer_New_Click);
            // 
            // tmsiCustomer_Save
            // 
            this.tmsiCustomer_Save.Image = ((System.Drawing.Image)(resources.GetObject("tmsiCustomer_Save.Image")));
            this.tmsiCustomer_Save.Name = "tmsiCustomer_Save";
            this.tmsiCustomer_Save.Size = new System.Drawing.Size(55, 20);
            this.tmsiCustomer_Save.Text = "Lưu";
            this.tmsiCustomer_Save.Click += new System.EventHandler(this.tmsiCustomer_Save_Click);
            // 
            // tmsiCustomer_Delete
            // 
            this.tmsiCustomer_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tmsiCustomer_Delete.Image")));
            this.tmsiCustomer_Delete.Name = "tmsiCustomer_Delete";
            this.tmsiCustomer_Delete.Size = new System.Drawing.Size(55, 20);
            this.tmsiCustomer_Delete.Text = "Xóa";
            this.tmsiCustomer_Delete.Click += new System.EventHandler(this.tmsiCustomer_Delete_Click);
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // frmCustomer_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 650);
            this.Controls.Add(this.tctCustomer);
            this.Name = "frmCustomer_update";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_update_Load);
            this.tctCustomer.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).EndInit();
            this.menuStrip11.ResumeLayout(false);
            this.menuStrip11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctCustomer;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TextBox txtTotalCustomer;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtCustomerAdress;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.MenuStrip menuStrip11;
        private System.Windows.Forms.ToolStripMenuItem tmsiCustomer_New;
        private System.Windows.Forms.ToolStripMenuItem tmsiCustomer_Save;
        private System.Windows.Forms.ToolStripMenuItem tmsiCustomer_Delete;
        private QUANLIKINHDOANHDIENTHOAIDataSet qUANLIKINHDOANHDIENTHOAIDataSet;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}