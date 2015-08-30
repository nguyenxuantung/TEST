namespace QuanLyKinhDoanhDienThoai
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbParceNumber = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBill_Total = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.menuStrip7 = new System.Windows.Forms.MenuStrip();
            this.tsmiBill_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBill_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBIll_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbBill_Status = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.dtpBill_Date = new System.Windows.Forms.DateTimePicker();
            this.label38 = new System.Windows.Forms.Label();
            this.cmbKindBill_Id = new System.Windows.Forms.ComboBox();
            this.tblKindBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLIKINHDOANHDIENTHOAIDataSet = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSet();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbCustomer_Id = new System.Windows.Forms.ComboBox();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.cmbPersonnel_Id = new System.Windows.Forms.ComboBox();
            this.tblPersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtBill_Id = new System.Windows.Forms.TextBox();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvKindBill = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtKindBill_Name = new System.Windows.Forms.TextBox();
            this.txtKindBill_Id = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.billTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.billTableAdapter();
            this.tblCustomerTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblCustomerTableAdapter();
            this.tblPersonnelTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblPersonnelTableAdapter();
            this.tblKindBillTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblKindBillTableAdapter();
            this.txtKindBill_Total = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personnel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KindBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKindBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKindBill)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(878, 656);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbParceNumber);
            this.tabPage1.Controls.Add(this.txtQuantity);
            this.tabPage1.Controls.Add(this.cmbProduct);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtBill_Total);
            this.tabPage1.Controls.Add(this.label58);
            this.tabPage1.Controls.Add(this.menuStrip7);
            this.tabPage1.Controls.Add(this.cmbBill_Status);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.dtpBill_Date);
            this.tabPage1.Controls.Add(this.label38);
            this.tabPage1.Controls.Add(this.cmbKindBill_Id);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.cmbCustomer_Id);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.cmbPersonnel_Id);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.txtBill_Id);
            this.tabPage1.Controls.Add(this.dgvBill);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 630);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đơn hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbParceNumber
            // 
            this.cmbParceNumber.DisplayMember = "PacelNumber";
            this.cmbParceNumber.FormattingEnabled = true;
            this.cmbParceNumber.Location = new System.Drawing.Point(657, 247);
            this.cmbParceNumber.Name = "cmbParceNumber";
            this.cmbParceNumber.Size = new System.Drawing.Size(188, 21);
            this.cmbParceNumber.TabIndex = 45;
            this.cmbParceNumber.ValueMember = "PacelNumber";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(657, 289);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(188, 20);
            this.txtQuantity.TabIndex = 41;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DisplayMember = "Name";
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(657, 206);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(188, 21);
            this.cmbProduct.TabIndex = 40;
            this.cmbProduct.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Số lô:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Sản phẩm:";
            // 
            // txtBill_Total
            // 
            this.txtBill_Total.Location = new System.Drawing.Point(59, 597);
            this.txtBill_Total.Name = "txtBill_Total";
            this.txtBill_Total.Size = new System.Drawing.Size(230, 20);
            this.txtBill_Total.TabIndex = 39;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(21, 600);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(35, 13);
            this.label58.TabIndex = 38;
            this.label58.Text = "Tổng:";
            // 
            // menuStrip7
            // 
            this.menuStrip7.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBill_New,
            this.tsmiBill_Save,
            this.tsmiBIll_Delete});
            this.menuStrip7.Location = new System.Drawing.Point(3, 3);
            this.menuStrip7.Name = "menuStrip7";
            this.menuStrip7.Size = new System.Drawing.Size(864, 24);
            this.menuStrip7.TabIndex = 37;
            this.menuStrip7.Text = "menuStrip7";
            // 
            // tsmiBill_New
            // 
            this.tsmiBill_New.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBill_New.Image")));
            this.tsmiBill_New.Name = "tsmiBill_New";
            this.tsmiBill_New.Size = new System.Drawing.Size(90, 20);
            this.tsmiBill_New.Text = "Thêm mới";
            this.tsmiBill_New.Click += new System.EventHandler(this.tsmiBill_New_Click);
            // 
            // tsmiBill_Save
            // 
            this.tsmiBill_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBill_Save.Image")));
            this.tsmiBill_Save.Name = "tsmiBill_Save";
            this.tsmiBill_Save.Size = new System.Drawing.Size(55, 20);
            this.tsmiBill_Save.Text = "Lưu";
            this.tsmiBill_Save.Click += new System.EventHandler(this.tsmiBill_Save_Click);
            // 
            // tsmiBIll_Delete
            // 
            this.tsmiBIll_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBIll_Delete.Image")));
            this.tsmiBIll_Delete.Name = "tsmiBIll_Delete";
            this.tsmiBIll_Delete.Size = new System.Drawing.Size(55, 20);
            this.tsmiBIll_Delete.Text = "Xóa";
            this.tsmiBIll_Delete.Click += new System.EventHandler(this.tsmiBIll_Delete_Click);
            // 
            // cmbBill_Status
            // 
            this.cmbBill_Status.FormattingEnabled = true;
            this.cmbBill_Status.Location = new System.Drawing.Point(657, 371);
            this.cmbBill_Status.Name = "cmbBill_Status";
            this.cmbBill_Status.Size = new System.Drawing.Size(188, 21);
            this.cmbBill_Status.TabIndex = 36;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(562, 375);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 13);
            this.label39.TabIndex = 35;
            this.label39.Text = "Trạng thái:";
            // 
            // dtpBill_Date
            // 
            this.dtpBill_Date.Location = new System.Drawing.Point(657, 330);
            this.dtpBill_Date.Name = "dtpBill_Date";
            this.dtpBill_Date.Size = new System.Drawing.Size(188, 20);
            this.dtpBill_Date.TabIndex = 34;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(562, 333);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 13);
            this.label38.TabIndex = 33;
            this.label38.Text = "Ngày:";
            // 
            // cmbKindBill_Id
            // 
            this.cmbKindBill_Id.DataSource = this.tblKindBillBindingSource;
            this.cmbKindBill_Id.DisplayMember = "Name";
            this.cmbKindBill_Id.FormattingEnabled = true;
            this.cmbKindBill_Id.Location = new System.Drawing.Point(657, 165);
            this.cmbKindBill_Id.Name = "cmbKindBill_Id";
            this.cmbKindBill_Id.Size = new System.Drawing.Size(188, 21);
            this.cmbKindBill_Id.TabIndex = 32;
            this.cmbKindBill_Id.ValueMember = "Id";
            // 
            // tblKindBillBindingSource
            // 
            this.tblKindBillBindingSource.DataMember = "tblKindBill";
            this.tblKindBillBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // qUANLIKINHDOANHDIENTHOAIDataSet
            // 
            this.qUANLIKINHDOANHDIENTHOAIDataSet.DataSetName = "QUANLIKINHDOANHDIENTHOAIDataSet";
            this.qUANLIKINHDOANHDIENTHOAIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(562, 169);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(73, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "Loại hóa đơn:";
            // 
            // cmbCustomer_Id
            // 
            this.cmbCustomer_Id.DataSource = this.tblCustomerBindingSource;
            this.cmbCustomer_Id.DisplayMember = "Name";
            this.cmbCustomer_Id.FormattingEnabled = true;
            this.cmbCustomer_Id.Location = new System.Drawing.Point(657, 81);
            this.cmbCustomer_Id.Name = "cmbCustomer_Id";
            this.cmbCustomer_Id.Size = new System.Drawing.Size(188, 21);
            this.cmbCustomer_Id.TabIndex = 30;
            this.cmbCustomer_Id.ValueMember = "Id";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(562, 85);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 13);
            this.label27.TabIndex = 29;
            this.label27.Text = "Khách hàng:";
            // 
            // cmbPersonnel_Id
            // 
            this.cmbPersonnel_Id.DataSource = this.tblPersonnelBindingSource;
            this.cmbPersonnel_Id.DisplayMember = "Name";
            this.cmbPersonnel_Id.FormattingEnabled = true;
            this.cmbPersonnel_Id.Location = new System.Drawing.Point(657, 123);
            this.cmbPersonnel_Id.Name = "cmbPersonnel_Id";
            this.cmbPersonnel_Id.Size = new System.Drawing.Size(188, 21);
            this.cmbPersonnel_Id.TabIndex = 28;
            this.cmbPersonnel_Id.ValueMember = "Id";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(562, 127);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 13);
            this.label29.TabIndex = 27;
            this.label29.Text = "Nhân viên:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(562, 42);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 13);
            this.label30.TabIndex = 26;
            this.label30.Text = "Mã hóa đơn:";
            // 
            // txtBill_Id
            // 
            this.txtBill_Id.Location = new System.Drawing.Point(657, 39);
            this.txtBill_Id.Name = "txtBill_Id";
            this.txtBill_Id.Size = new System.Drawing.Size(188, 20);
            this.txtBill_Id.TabIndex = 25;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AutoGenerateColumns = false;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Product,
            this.PacelNumber,
            this.Quantity,
            this.Status,
            this.Date,
            this.Personnel,
            this.KindBill});
            this.dgvBill.DataSource = this.billBindingSource;
            this.dgvBill.Location = new System.Drawing.Point(20, 40);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.Size = new System.Drawing.Size(517, 551);
            this.dgvBill.TabIndex = 0;
            this.dgvBill.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBill_RowPostPaint);
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "bill";
            this.billBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtKindBill_Total);
            this.tabPage2.Controls.Add(this.dgvKindBill);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.txtKindBill_Name);
            this.tabPage2.Controls.Add(this.txtKindBill_Id);
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại đơn hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvKindBill
            // 
            this.dgvKindBill.AllowUserToAddRows = false;
            this.dgvKindBill.AllowUserToDeleteRows = false;
            this.dgvKindBill.AutoGenerateColumns = false;
            this.dgvKindBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKindBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dgvKindBill.DataSource = this.tblKindBillBindingSource;
            this.dgvKindBill.Location = new System.Drawing.Point(20, 44);
            this.dgvKindBill.Name = "dgvKindBill";
            this.dgvKindBill.ReadOnly = true;
            this.dgvKindBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKindBill.Size = new System.Drawing.Size(384, 557);
            this.dgvKindBill.TabIndex = 16;
            this.dgvKindBill.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvKindBill_RowPostPaint);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Mã";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên loại đơn hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 270;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(482, 47);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(47, 13);
            this.label36.TabIndex = 14;
            this.label36.Text = "Mã loại: ";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(482, 85);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(48, 13);
            this.label37.TabIndex = 15;
            this.label37.Text = "Tên loại:";
            // 
            // txtKindBill_Name
            // 
            this.txtKindBill_Name.Location = new System.Drawing.Point(556, 83);
            this.txtKindBill_Name.Name = "txtKindBill_Name";
            this.txtKindBill_Name.Size = new System.Drawing.Size(253, 20);
            this.txtKindBill_Name.TabIndex = 13;
            // 
            // txtKindBill_Id
            // 
            this.txtKindBill_Id.Location = new System.Drawing.Point(556, 44);
            this.txtKindBill_Id.Name = "txtKindBill_Id";
            this.txtKindBill_Id.Size = new System.Drawing.Size(253, 20);
            this.txtKindBill_Id.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
            this.toolStripMenuItem1.Text = "Thêm mới";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.tsmiKindBill_New_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem2.Text = "Lưu";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.tsmiKindBill_Save_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem3.Text = "Xóa";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.tsmiKindBill_Delete_Click);
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tblPersonnelTableAdapter
            // 
            this.tblPersonnelTableAdapter.ClearBeforeFill = true;
            // 
            // tblKindBillTableAdapter
            // 
            this.tblKindBillTableAdapter.ClearBeforeFill = true;
            // 
            // txtKindBill_Total
            // 
            this.txtKindBill_Total.Location = new System.Drawing.Point(30, 604);
            this.txtKindBill_Total.Name = "txtKindBill_Total";
            this.txtKindBill_Total.Size = new System.Drawing.Size(253, 20);
            this.txtKindBill_Total.TabIndex = 17;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Mã";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 60;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Khách hàng";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Sản phẩm";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // PacelNumber
            // 
            this.PacelNumber.DataPropertyName = "PacelNumber";
            this.PacelNumber.HeaderText = "Số lô";
            this.PacelNumber.Name = "PacelNumber";
            this.PacelNumber.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày bán";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Personnel
            // 
            this.Personnel.DataPropertyName = "Personnel";
            this.Personnel.HeaderText = "Nhân viên";
            this.Personnel.Name = "Personnel";
            this.Personnel.ReadOnly = true;
            // 
            // KindBill
            // 
            this.KindBill.DataPropertyName = "KindBill";
            this.KindBill.HeaderText = "Loại hóa đơn";
            this.KindBill.Name = "KindBill";
            this.KindBill.ReadOnly = true;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 651);
            this.Controls.Add(this.tabControl1);
            this.Name.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip7.ResumeLayout(false);
            this.menuStrip7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKindBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKindBill)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.TabPage tabPage2;
        private QUANLIKINHDOANHDIENTHOAIDataSet qUANLIKINHDOANHDIENTHOAIDataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.billTableAdapter billTableAdapter;
        private System.Windows.Forms.ComboBox cmbBill_Status;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DateTimePicker dtpBill_Date;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cmbKindBill_Id;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbCustomer_Id;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmbPersonnel_Id;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtBill_Id;
        private System.Windows.Forms.MenuStrip menuStrip7;
        private System.Windows.Forms.ToolStripMenuItem tsmiBill_New;
        private System.Windows.Forms.ToolStripMenuItem tsmiBill_Save;
        private System.Windows.Forms.ToolStripMenuItem tsmiBIll_Delete;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.BindingSource tblPersonnelBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblPersonnelTableAdapter tblPersonnelTableAdapter;
        private System.Windows.Forms.BindingSource tblKindBillBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblKindBillTableAdapter tblKindBillTableAdapter;
        private System.Windows.Forms.TextBox txtBill_Total;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ComboBox cmbParceNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvKindBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtKindBill_Name;
        private System.Windows.Forms.TextBox txtKindBill_Id;
        private System.Windows.Forms.TextBox txtKindBill_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personnel;
        private System.Windows.Forms.DataGridViewTextBoxColumn KindBill;
    }
}