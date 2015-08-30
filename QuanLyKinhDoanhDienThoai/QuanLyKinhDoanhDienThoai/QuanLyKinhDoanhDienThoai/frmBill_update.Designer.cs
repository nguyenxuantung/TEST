namespace QuanLyKinhDoanhDienThoai
{
    partial class frmBill_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBill_update));
            this.tctBill = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kindBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personnelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLIKINHDOANHDIENTHOAIDataSet = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSet();
            this.txtBill_Total = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.cmbBill_Status = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.dtpBill_Date = new System.Windows.Forms.DateTimePicker();
            this.label38 = new System.Windows.Forms.Label();
            this.cmbKindBill_Id = new System.Windows.Forms.ComboBox();
            this.tblKindBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label28 = new System.Windows.Forms.Label();
            this.cmbCustomer_Id = new System.Windows.Forms.ComboBox();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.cmbPersonnel_Id = new System.Windows.Forms.ComboBox();
            this.tblPersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtBill_Id = new System.Windows.Forms.TextBox();
            this.menuStrip7 = new System.Windows.Forms.MenuStrip();
            this.tsmiBill_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBill_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBIll_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.txtBillDetail_Total = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.cmbBillDetail_ParcelNumber = new System.Windows.Forms.ComboBox();
            this.tblStoreInDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBillDetail_Quantity = new System.Windows.Forms.TextBox();
            this.cmbBillDetail_ProductId = new System.Windows.Forms.ComboBox();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbBill_Id = new System.Windows.Forms.ComboBox();
            this.tblBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.BillId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacelNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblBillDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip8 = new System.Windows.Forms.MenuStrip();
            this.tsmiBillDetail_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBillDetail_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBillDetail_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.txtKindBill_Total = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.dgvKindBill = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtKindBill_Name = new System.Windows.Forms.TextBox();
            this.txtKindBill_Id = new System.Windows.Forms.TextBox();
            this.menuStrip9 = new System.Windows.Forms.MenuStrip();
            this.tsmiKindBill_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKindBill_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKindBill_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tblCustomerTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblCustomerTableAdapter();
            this.tblPersonnelTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblPersonnelTableAdapter();
            this.tblKindBillTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblKindBillTableAdapter();
            this.tblBillTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblBillTableAdapter();
            this.tblBillDetailTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblBillDetailTableAdapter();
            this.tblProductTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblProductTableAdapter();
            this.tblStoreInDetailTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblStoreInDetailTableAdapter();
            this.billTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.billTableAdapter();
            this.tctBill.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKindBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelBindingSource)).BeginInit();
            this.menuStrip7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStoreInDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBillDetailBindingSource)).BeginInit();
            this.menuStrip8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKindBill)).BeginInit();
            this.menuStrip9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctBill
            // 
            this.tctBill.Controls.Add(this.tabPage7);
            this.tctBill.Controls.Add(this.tabPage8);
            this.tctBill.Controls.Add(this.tabPage9);
            this.tctBill.Location = new System.Drawing.Point(0, 0);
            this.tctBill.Name = "tctBill";
            this.tctBill.SelectedIndex = 0;
            this.tctBill.Size = new System.Drawing.Size(878, 656);
            this.tctBill.TabIndex = 1;
            this.tctBill.SelectedIndexChanged += new System.EventHandler(this.tctBill_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dgvBill);
            this.tabPage7.Controls.Add(this.txtBill_Total);
            this.tabPage7.Controls.Add(this.label58);
            this.tabPage7.Controls.Add(this.cmbBill_Status);
            this.tabPage7.Controls.Add(this.label39);
            this.tabPage7.Controls.Add(this.dtpBill_Date);
            this.tabPage7.Controls.Add(this.label38);
            this.tabPage7.Controls.Add(this.cmbKindBill_Id);
            this.tabPage7.Controls.Add(this.label28);
            this.tabPage7.Controls.Add(this.cmbCustomer_Id);
            this.tabPage7.Controls.Add(this.label27);
            this.tabPage7.Controls.Add(this.cmbPersonnel_Id);
            this.tabPage7.Controls.Add(this.label29);
            this.tabPage7.Controls.Add(this.label30);
            this.tabPage7.Controls.Add(this.txtBill_Id);
            this.tabPage7.Controls.Add(this.menuStrip7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(870, 630);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Đơn hàng";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dgvBill
            // 
            this.dgvBill.AutoGenerateColumns = false;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.kindBillDataGridViewTextBoxColumn,
            this.personnelDataGridViewTextBoxColumn});
            this.dgvBill.DataSource = this.billBindingSource;
            this.dgvBill.Location = new System.Drawing.Point(20, 40);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.Size = new System.Drawing.Size(502, 558);
            this.dgvBill.TabIndex = 27;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // kindBillDataGridViewTextBoxColumn
            // 
            this.kindBillDataGridViewTextBoxColumn.DataPropertyName = "KindBill";
            this.kindBillDataGridViewTextBoxColumn.HeaderText = "KindBill";
            this.kindBillDataGridViewTextBoxColumn.Name = "kindBillDataGridViewTextBoxColumn";
            // 
            // personnelDataGridViewTextBoxColumn
            // 
            this.personnelDataGridViewTextBoxColumn.DataPropertyName = "Personnel";
            this.personnelDataGridViewTextBoxColumn.HeaderText = "Personnel";
            this.personnelDataGridViewTextBoxColumn.Name = "personnelDataGridViewTextBoxColumn";
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "bill";
            this.billBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // qUANLIKINHDOANHDIENTHOAIDataSet
            // 
            this.qUANLIKINHDOANHDIENTHOAIDataSet.DataSetName = "QUANLIKINHDOANHDIENTHOAIDataSet";
            this.qUANLIKINHDOANHDIENTHOAIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBill_Total
            // 
            this.txtBill_Total.Location = new System.Drawing.Point(55, 604);
            this.txtBill_Total.Name = "txtBill_Total";
            this.txtBill_Total.Size = new System.Drawing.Size(180, 20);
            this.txtBill_Total.TabIndex = 26;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(17, 607);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(35, 13);
            this.label58.TabIndex = 25;
            this.label58.Text = "Tổng:";
            // 
            // cmbBill_Status
            // 
            this.cmbBill_Status.FormattingEnabled = true;
            this.cmbBill_Status.Location = new System.Drawing.Point(627, 259);
            this.cmbBill_Status.Name = "cmbBill_Status";
            this.cmbBill_Status.Size = new System.Drawing.Size(211, 21);
            this.cmbBill_Status.TabIndex = 24;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(532, 263);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 13);
            this.label39.TabIndex = 23;
            this.label39.Text = "Trạng thái:";
            // 
            // dtpBill_Date
            // 
            this.dtpBill_Date.Location = new System.Drawing.Point(627, 218);
            this.dtpBill_Date.Name = "dtpBill_Date";
            this.dtpBill_Date.Size = new System.Drawing.Size(211, 20);
            this.dtpBill_Date.TabIndex = 22;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(532, 221);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(35, 13);
            this.label38.TabIndex = 21;
            this.label38.Text = "Ngày:";
            // 
            // cmbKindBill_Id
            // 
            this.cmbKindBill_Id.DataSource = this.tblKindBillBindingSource;
            this.cmbKindBill_Id.DisplayMember = "Name";
            this.cmbKindBill_Id.FormattingEnabled = true;
            this.cmbKindBill_Id.Location = new System.Drawing.Point(627, 175);
            this.cmbKindBill_Id.Name = "cmbKindBill_Id";
            this.cmbKindBill_Id.Size = new System.Drawing.Size(211, 21);
            this.cmbKindBill_Id.TabIndex = 20;
            this.cmbKindBill_Id.ValueMember = "Id";
            // 
            // tblKindBillBindingSource
            // 
            this.tblKindBillBindingSource.DataMember = "tblKindBill";
            this.tblKindBillBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(532, 179);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(73, 13);
            this.label28.TabIndex = 19;
            this.label28.Text = "Loại hóa đơn:";
            // 
            // cmbCustomer_Id
            // 
            this.cmbCustomer_Id.DataSource = this.tblCustomerBindingSource;
            this.cmbCustomer_Id.DisplayMember = "Name";
            this.cmbCustomer_Id.FormattingEnabled = true;
            this.cmbCustomer_Id.Location = new System.Drawing.Point(627, 91);
            this.cmbCustomer_Id.Name = "cmbCustomer_Id";
            this.cmbCustomer_Id.Size = new System.Drawing.Size(211, 21);
            this.cmbCustomer_Id.TabIndex = 18;
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
            this.label27.Location = new System.Drawing.Point(532, 95);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 13);
            this.label27.TabIndex = 17;
            this.label27.Text = "Khách hàng:";
            // 
            // cmbPersonnel_Id
            // 
            this.cmbPersonnel_Id.DataSource = this.tblPersonnelBindingSource;
            this.cmbPersonnel_Id.DisplayMember = "Name";
            this.cmbPersonnel_Id.FormattingEnabled = true;
            this.cmbPersonnel_Id.Location = new System.Drawing.Point(627, 133);
            this.cmbPersonnel_Id.Name = "cmbPersonnel_Id";
            this.cmbPersonnel_Id.Size = new System.Drawing.Size(211, 21);
            this.cmbPersonnel_Id.TabIndex = 16;
            this.cmbPersonnel_Id.ValueMember = "Id";
            // 
            // tblPersonnelBindingSource
            // 
            this.tblPersonnelBindingSource.DataMember = "tblPersonnel";
            this.tblPersonnelBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(532, 137);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 13);
            this.label29.TabIndex = 15;
            this.label29.Text = "Nhân viên:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(532, 52);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(68, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "Mã hóa đơn:";
            // 
            // txtBill_Id
            // 
            this.txtBill_Id.Location = new System.Drawing.Point(627, 49);
            this.txtBill_Id.Name = "txtBill_Id";
            this.txtBill_Id.Size = new System.Drawing.Size(211, 20);
            this.txtBill_Id.TabIndex = 1;
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
            this.menuStrip7.TabIndex = 10;
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
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.txtBillDetail_Total);
            this.tabPage8.Controls.Add(this.label59);
            this.tabPage8.Controls.Add(this.cmbBillDetail_ParcelNumber);
            this.tabPage8.Controls.Add(this.txtBillDetail_Quantity);
            this.tabPage8.Controls.Add(this.cmbBillDetail_ProductId);
            this.tabPage8.Controls.Add(this.cmbBill_Id);
            this.tabPage8.Controls.Add(this.label32);
            this.tabPage8.Controls.Add(this.label33);
            this.tabPage8.Controls.Add(this.label34);
            this.tabPage8.Controls.Add(this.label35);
            this.tabPage8.Controls.Add(this.dgvBillDetail);
            this.tabPage8.Controls.Add(this.menuStrip8);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(870, 630);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Chi tiết  đơn hàng";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // txtBillDetail_Total
            // 
            this.txtBillDetail_Total.Location = new System.Drawing.Point(55, 604);
            this.txtBillDetail_Total.Name = "txtBillDetail_Total";
            this.txtBillDetail_Total.Size = new System.Drawing.Size(180, 20);
            this.txtBillDetail_Total.TabIndex = 28;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(17, 607);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(35, 13);
            this.label59.TabIndex = 27;
            this.label59.Text = "Tổng:";
            // 
            // cmbBillDetail_ParcelNumber
            // 
            this.cmbBillDetail_ParcelNumber.DataSource = this.tblStoreInDetailBindingSource;
            this.cmbBillDetail_ParcelNumber.DisplayMember = "PacelNumber";
            this.cmbBillDetail_ParcelNumber.FormattingEnabled = true;
            this.cmbBillDetail_ParcelNumber.Location = new System.Drawing.Point(620, 127);
            this.cmbBillDetail_ParcelNumber.Name = "cmbBillDetail_ParcelNumber";
            this.cmbBillDetail_ParcelNumber.Size = new System.Drawing.Size(200, 21);
            this.cmbBillDetail_ParcelNumber.TabIndex = 16;
            this.cmbBillDetail_ParcelNumber.ValueMember = "PacelNumber";
            // 
            // tblStoreInDetailBindingSource
            // 
            this.tblStoreInDetailBindingSource.DataMember = "tblStoreInDetail";
            this.tblStoreInDetailBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // txtBillDetail_Quantity
            // 
            this.txtBillDetail_Quantity.Location = new System.Drawing.Point(620, 169);
            this.txtBillDetail_Quantity.Name = "txtBillDetail_Quantity";
            this.txtBillDetail_Quantity.Size = new System.Drawing.Size(200, 20);
            this.txtBillDetail_Quantity.TabIndex = 3;
            // 
            // cmbBillDetail_ProductId
            // 
            this.cmbBillDetail_ProductId.DataSource = this.tblProductBindingSource;
            this.cmbBillDetail_ProductId.DisplayMember = "Name";
            this.cmbBillDetail_ProductId.FormattingEnabled = true;
            this.cmbBillDetail_ProductId.Location = new System.Drawing.Point(620, 83);
            this.cmbBillDetail_ProductId.Name = "cmbBillDetail_ProductId";
            this.cmbBillDetail_ProductId.Size = new System.Drawing.Size(200, 21);
            this.cmbBillDetail_ProductId.TabIndex = 2;
            this.cmbBillDetail_ProductId.ValueMember = "Id";
            this.cmbBillDetail_ProductId.SelectedValueChanged += new System.EventHandler(this.cmbBillDetail_ProductId_SelectedValueChanged);
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // cmbBill_Id
            // 
            this.cmbBill_Id.DataSource = this.tblBillBindingSource;
            this.cmbBill_Id.DisplayMember = "Id";
            this.cmbBill_Id.FormattingEnabled = true;
            this.cmbBill_Id.Location = new System.Drawing.Point(620, 43);
            this.cmbBill_Id.Name = "cmbBill_Id";
            this.cmbBill_Id.Size = new System.Drawing.Size(200, 21);
            this.cmbBill_Id.TabIndex = 1;
            this.cmbBill_Id.ValueMember = "Id";
            // 
            // tblBillBindingSource
            // 
            this.tblBillBindingSource.DataMember = "tblBill";
            this.tblBillBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(523, 172);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(52, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Số lượng:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(526, 127);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(34, 13);
            this.label33.TabIndex = 15;
            this.label33.Text = "Số lô:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(523, 86);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(58, 13);
            this.label34.TabIndex = 14;
            this.label34.Text = "Sản phẩm:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(523, 46);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(74, 13);
            this.label35.TabIndex = 13;
            this.label35.Text = "Mã đơn hàng:";
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.AllowUserToAddRows = false;
            this.dgvBillDetail.AllowUserToDeleteRows = false;
            this.dgvBillDetail.AutoGenerateColumns = false;
            this.dgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillId,
            this.ProductId,
            this.PacelNumber,
            this.Quantity,
            this.billIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.pacelNumberDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dgvBillDetail.DataSource = this.tblBillDetailBindingSource;
            this.dgvBillDetail.Location = new System.Drawing.Point(20, 40);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.ReadOnly = true;
            this.dgvBillDetail.Size = new System.Drawing.Size(441, 560);
            this.dgvBillDetail.TabIndex = 12;
            this.dgvBillDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillDetail_CellClick);
            this.dgvBillDetail.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBillDetail_RowPostPaint);
            // 
            // BillId
            // 
            this.BillId.DataPropertyName = "BillId";
            this.BillId.HeaderText = "Đơn hàng";
            this.BillId.Name = "BillId";
            this.BillId.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Mã SP";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
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
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "BillId";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacelNumberDataGridViewTextBoxColumn
            // 
            this.pacelNumberDataGridViewTextBoxColumn.DataPropertyName = "PacelNumber";
            this.pacelNumberDataGridViewTextBoxColumn.HeaderText = "PacelNumber";
            this.pacelNumberDataGridViewTextBoxColumn.Name = "pacelNumberDataGridViewTextBoxColumn";
            this.pacelNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblBillDetailBindingSource
            // 
            this.tblBillDetailBindingSource.DataMember = "tblBillDetail";
            this.tblBillDetailBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // menuStrip8
            // 
            this.menuStrip8.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBillDetail_New,
            this.tsmiBillDetail_Save,
            this.tsmiBillDetail_Delete});
            this.menuStrip8.Location = new System.Drawing.Point(0, 0);
            this.menuStrip8.Name = "menuStrip8";
            this.menuStrip8.Size = new System.Drawing.Size(870, 24);
            this.menuStrip8.TabIndex = 11;
            this.menuStrip8.Text = "menuStrip8";
            // 
            // tsmiBillDetail_New
            // 
            this.tsmiBillDetail_New.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBillDetail_New.Image")));
            this.tsmiBillDetail_New.Name = "tsmiBillDetail_New";
            this.tsmiBillDetail_New.Size = new System.Drawing.Size(90, 20);
            this.tsmiBillDetail_New.Text = "Thêm mới";
            this.tsmiBillDetail_New.Click += new System.EventHandler(this.tsmiBillDetail_New_Click);
            // 
            // tsmiBillDetail_Save
            // 
            this.tsmiBillDetail_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBillDetail_Save.Image")));
            this.tsmiBillDetail_Save.Name = "tsmiBillDetail_Save";
            this.tsmiBillDetail_Save.Size = new System.Drawing.Size(55, 20);
            this.tsmiBillDetail_Save.Text = "Lưu";
            this.tsmiBillDetail_Save.Click += new System.EventHandler(this.tsmiBillDetail_Save_Click);
            // 
            // tsmiBillDetail_Delete
            // 
            this.tsmiBillDetail_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBillDetail_Delete.Image")));
            this.tsmiBillDetail_Delete.Name = "tsmiBillDetail_Delete";
            this.tsmiBillDetail_Delete.Size = new System.Drawing.Size(55, 20);
            this.tsmiBillDetail_Delete.Text = "Xóa";
            this.tsmiBillDetail_Delete.Click += new System.EventHandler(this.tsmiBillDetail_Delete_Click);
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.txtKindBill_Total);
            this.tabPage9.Controls.Add(this.label60);
            this.tabPage9.Controls.Add(this.dgvKindBill);
            this.tabPage9.Controls.Add(this.label36);
            this.tabPage9.Controls.Add(this.label37);
            this.tabPage9.Controls.Add(this.txtKindBill_Name);
            this.tabPage9.Controls.Add(this.txtKindBill_Id);
            this.tabPage9.Controls.Add(this.menuStrip9);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(870, 630);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Loại đơn hàng";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // txtKindBill_Total
            // 
            this.txtKindBill_Total.Location = new System.Drawing.Point(56, 604);
            this.txtKindBill_Total.Name = "txtKindBill_Total";
            this.txtKindBill_Total.Size = new System.Drawing.Size(180, 20);
            this.txtKindBill_Total.TabIndex = 28;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(18, 607);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(35, 13);
            this.label60.TabIndex = 27;
            this.label60.Text = "Tổng:";
            // 
            // dgvKindBill
            // 
            this.dgvKindBill.AllowUserToAddRows = false;
            this.dgvKindBill.AllowUserToDeleteRows = false;
            this.dgvKindBill.AutoGenerateColumns = false;
            this.dgvKindBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKindBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn});
            this.dgvKindBill.DataSource = this.tblKindBillBindingSource;
            this.dgvKindBill.Location = new System.Drawing.Point(20, 40);
            this.dgvKindBill.Name = "dgvKindBill";
            this.dgvKindBill.ReadOnly = true;
            this.dgvKindBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKindBill.Size = new System.Drawing.Size(332, 557);
            this.dgvKindBill.TabIndex = 10;
            this.dgvKindBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKindBill_CellClick);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên loại đơn hàng";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 220;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(445, 44);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(47, 13);
            this.label36.TabIndex = 6;
            this.label36.Text = "Mã loại: ";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(445, 82);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(48, 13);
            this.label37.TabIndex = 7;
            this.label37.Text = "Tên loại:";
            // 
            // txtKindBill_Name
            // 
            this.txtKindBill_Name.Location = new System.Drawing.Point(519, 80);
            this.txtKindBill_Name.Name = "txtKindBill_Name";
            this.txtKindBill_Name.Size = new System.Drawing.Size(253, 20);
            this.txtKindBill_Name.TabIndex = 2;
            // 
            // txtKindBill_Id
            // 
            this.txtKindBill_Id.Location = new System.Drawing.Point(519, 41);
            this.txtKindBill_Id.Name = "txtKindBill_Id";
            this.txtKindBill_Id.Size = new System.Drawing.Size(253, 20);
            this.txtKindBill_Id.TabIndex = 1;
            // 
            // menuStrip9
            // 
            this.menuStrip9.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip9.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKindBill_New,
            this.tsmiKindBill_Save,
            this.tsmiKindBill_Delete});
            this.menuStrip9.Location = new System.Drawing.Point(3, 3);
            this.menuStrip9.Name = "menuStrip9";
            this.menuStrip9.Size = new System.Drawing.Size(864, 24);
            this.menuStrip9.TabIndex = 9;
            this.menuStrip9.Text = "menuStrip9";
            // 
            // tsmiKindBill_New
            // 
            this.tsmiKindBill_New.Image = ((System.Drawing.Image)(resources.GetObject("tsmiKindBill_New.Image")));
            this.tsmiKindBill_New.Name = "tsmiKindBill_New";
            this.tsmiKindBill_New.Size = new System.Drawing.Size(90, 20);
            this.tsmiKindBill_New.Text = "Thêm mới";
            this.tsmiKindBill_New.Click += new System.EventHandler(this.tsmiKindBill_New_Click);
            // 
            // tsmiKindBill_Save
            // 
            this.tsmiKindBill_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsmiKindBill_Save.Image")));
            this.tsmiKindBill_Save.Name = "tsmiKindBill_Save";
            this.tsmiKindBill_Save.Size = new System.Drawing.Size(55, 20);
            this.tsmiKindBill_Save.Text = "Lưu";
            this.tsmiKindBill_Save.Click += new System.EventHandler(this.tsmiKindBill_Save_Click);
            // 
            // tsmiKindBill_Delete
            // 
            this.tsmiKindBill_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiKindBill_Delete.Image")));
            this.tsmiKindBill_Delete.Name = "tsmiKindBill_Delete";
            this.tsmiKindBill_Delete.Size = new System.Drawing.Size(55, 20);
            this.tsmiKindBill_Delete.Text = "Xóa";
            this.tsmiKindBill_Delete.Click += new System.EventHandler(this.tsmiKindBill_Delete_Click);
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
            // tblBillTableAdapter
            // 
            this.tblBillTableAdapter.ClearBeforeFill = true;
            // 
            // tblBillDetailTableAdapter
            // 
            this.tblBillDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // tblStoreInDetailTableAdapter
            // 
            this.tblStoreInDetailTableAdapter.ClearBeforeFill = true;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // frmBill_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 651);
            this.Controls.Add(this.tctBill);
            this.Name = "frmBill_update";
            this.Text = "frmProduct_update";
            this.Load += new System.EventHandler(this.frmProduct_update_Load);
            this.tctBill.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKindBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelBindingSource)).EndInit();
            this.menuStrip7.ResumeLayout(false);
            this.menuStrip7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStoreInDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblBillDetailBindingSource)).EndInit();
            this.menuStrip8.ResumeLayout(false);
            this.menuStrip8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKindBill)).EndInit();
            this.menuStrip9.ResumeLayout(false);
            this.menuStrip9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctBill;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox txtBill_Total;
        private System.Windows.Forms.Label label58;
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
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox txtBillDetail_Total;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.ComboBox cmbBillDetail_ParcelNumber;
        private System.Windows.Forms.TextBox txtBillDetail_Quantity;
        private System.Windows.Forms.ComboBox cmbBillDetail_ProductId;
        private System.Windows.Forms.ComboBox cmbBill_Id;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DataGridView dgvBillDetail;
        private System.Windows.Forms.MenuStrip menuStrip8;
        private System.Windows.Forms.ToolStripMenuItem tsmiBillDetail_New;
        private System.Windows.Forms.ToolStripMenuItem tsmiBillDetail_Save;
        private System.Windows.Forms.ToolStripMenuItem tsmiBillDetail_Delete;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox txtKindBill_Total;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.DataGridView dgvKindBill;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtKindBill_Name;
        private System.Windows.Forms.TextBox txtKindBill_Id;
        private System.Windows.Forms.MenuStrip menuStrip9;
        private System.Windows.Forms.ToolStripMenuItem tsmiKindBill_New;
        private System.Windows.Forms.ToolStripMenuItem tsmiKindBill_Save;
        private System.Windows.Forms.ToolStripMenuItem tsmiKindBill_Delete;
        private QUANLIKINHDOANHDIENTHOAIDataSet qUANLIKINHDOANHDIENTHOAIDataSet;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.BindingSource tblPersonnelBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblPersonnelTableAdapter tblPersonnelTableAdapter;
        private System.Windows.Forms.BindingSource tblKindBillBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblKindBillTableAdapter tblKindBillTableAdapter;
        private System.Windows.Forms.BindingSource tblBillBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblBillTableAdapter tblBillTableAdapter;
        private System.Windows.Forms.BindingSource tblBillDetailBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblBillDetailTableAdapter tblBillDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacelNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.BindingSource tblStoreInDetailBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblStoreInDetailTableAdapter tblStoreInDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource billBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.billTableAdapter billTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personnelDataGridViewTextBoxColumn;
    }
}