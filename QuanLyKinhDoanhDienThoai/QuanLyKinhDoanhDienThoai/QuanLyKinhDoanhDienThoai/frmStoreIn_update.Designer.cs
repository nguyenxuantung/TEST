namespace QuanLyKinhDoanhDienThoai
{
    partial class frmStoreIn_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreIn_update));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtStoreIn_Total = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStoreInId = new System.Windows.Forms.TextBox();
            this.dtpStoreInDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProvidersId = new System.Windows.Forms.ComboBox();
            this.tblProvidersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLIKINHDOANHDIENTHOAIDataSet = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSet();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvStoreIn = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvidersId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providersIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStoreInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.tsmiStoreInNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStoreInSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStoreInDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtStoreInDetail_Total = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.cmbProductId = new System.Windows.Forms.ComboBox();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbStoreId = new System.Windows.Forms.ComboBox();
            this.txtStoreDetail_ParceNumber = new System.Windows.Forms.TextBox();
            this.txtStoreDetail_Price = new System.Windows.Forms.TextBox();
            this.txtStoreDetail_Quantity = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dgvStoreDetail = new System.Windows.Forms.DataGridView();
            this.storeInIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacelNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStoreInDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.tsmiStoreDetailNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStoreDetailSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStoreDetailDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tblStoreInTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblStoreInTableAdapter();
            this.tblProvidersTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblProvidersTableAdapter();
            this.tblStoreInDetailTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblStoreInDetailTableAdapter();
            this.tblProductTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblProductTableAdapter();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProvidersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStoreInBindingSource)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStoreInDetailBindingSource)).BeginInit();
            this.menuStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(869, 654);
            this.tabControl2.TabIndex = 1;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtStoreIn_Total);
            this.tabPage3.Controls.Add(this.label56);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.txtStoreInId);
            this.tabPage3.Controls.Add(this.dtpStoreInDate);
            this.tabPage3.Controls.Add(this.cmbProvidersId);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.dgvStoreIn);
            this.tabPage3.Controls.Add(this.menuStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(861, 628);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Nhập kho";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtStoreIn_Total
            // 
            this.txtStoreIn_Total.Location = new System.Drawing.Point(54, 600);
            this.txtStoreIn_Total.Name = "txtStoreIn_Total";
            this.txtStoreIn_Total.Size = new System.Drawing.Size(180, 20);
            this.txtStoreIn_Total.TabIndex = 25;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(16, 603);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(35, 13);
            this.label56.TabIndex = 24;
            this.label56.Text = "Tổng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(434, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Mã nhập :";
            // 
            // txtStoreInId
            // 
            this.txtStoreInId.Location = new System.Drawing.Point(530, 49);
            this.txtStoreInId.Name = "txtStoreInId";
            this.txtStoreInId.Size = new System.Drawing.Size(228, 20);
            this.txtStoreInId.TabIndex = 1;
            // 
            // dtpStoreInDate
            // 
            this.dtpStoreInDate.Location = new System.Drawing.Point(530, 139);
            this.dtpStoreInDate.Name = "dtpStoreInDate";
            this.dtpStoreInDate.Size = new System.Drawing.Size(228, 20);
            this.dtpStoreInDate.TabIndex = 3;
            // 
            // cmbProvidersId
            // 
            this.cmbProvidersId.DataSource = this.tblProvidersBindingSource;
            this.cmbProvidersId.DisplayMember = "Name";
            this.cmbProvidersId.FormattingEnabled = true;
            this.cmbProvidersId.Location = new System.Drawing.Point(530, 94);
            this.cmbProvidersId.Name = "cmbProvidersId";
            this.cmbProvidersId.Size = new System.Drawing.Size(228, 21);
            this.cmbProvidersId.TabIndex = 2;
            this.cmbProvidersId.ValueMember = "Id";
            // 
            // tblProvidersBindingSource
            // 
            this.tblProvidersBindingSource.DataMember = "tblProviders";
            this.tblProvidersBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // qUANLIKINHDOANHDIENTHOAIDataSet
            // 
            this.qUANLIKINHDOANHDIENTHOAIDataSet.DataSetName = "QUANLIKINHDOANHDIENTHOAIDataSet";
            this.qUANLIKINHDOANHDIENTHOAIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(432, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Mã nhà cung cấp :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(433, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Ngày nhập :";
            // 
            // dgvStoreIn
            // 
            this.dgvStoreIn.AllowUserToAddRows = false;
            this.dgvStoreIn.AllowUserToDeleteRows = false;
            this.dgvStoreIn.AutoGenerateColumns = false;
            this.dgvStoreIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoreIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProvidersId,
            this.DateIn,
            this.idDataGridViewTextBoxColumn,
            this.providersIdDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn});
            this.dgvStoreIn.DataSource = this.tblStoreInBindingSource;
            this.dgvStoreIn.Location = new System.Drawing.Point(20, 40);
            this.dgvStoreIn.Name = "dgvStoreIn";
            this.dgvStoreIn.ReadOnly = true;
            this.dgvStoreIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreIn.Size = new System.Drawing.Size(338, 554);
            this.dgvStoreIn.TabIndex = 11;
            this.dgvStoreIn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreIn_CellClick);
            this.dgvStoreIn.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStoreIn_RowPostPaint);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Mã nhập";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // ProvidersId
            // 
            this.ProvidersId.DataPropertyName = "ProvidersId";
            this.ProvidersId.HeaderText = "Nhà cung cấp";
            this.ProvidersId.Name = "ProvidersId";
            this.ProvidersId.ReadOnly = true;
            this.ProvidersId.Width = 120;
            // 
            // DateIn
            // 
            this.DateIn.DataPropertyName = "DateIn";
            this.DateIn.HeaderText = "Ngày nhập";
            this.DateIn.Name = "DateIn";
            this.DateIn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // providersIdDataGridViewTextBoxColumn
            // 
            this.providersIdDataGridViewTextBoxColumn.DataPropertyName = "ProvidersId";
            this.providersIdDataGridViewTextBoxColumn.HeaderText = "ProvidersId";
            this.providersIdDataGridViewTextBoxColumn.Name = "providersIdDataGridViewTextBoxColumn";
            this.providersIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblStoreInBindingSource
            // 
            this.tblStoreInBindingSource.DataMember = "tblStoreIn";
            this.tblStoreInBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStoreInNew,
            this.tsmiStoreInSave,
            this.tsmiStoreInDelete});
            this.menuStrip3.Location = new System.Drawing.Point(3, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(855, 24);
            this.menuStrip3.TabIndex = 10;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // tsmiStoreInNew
            // 
            this.tsmiStoreInNew.Image = ((System.Drawing.Image)(resources.GetObject("tsmiStoreInNew.Image")));
            this.tsmiStoreInNew.Name = "tsmiStoreInNew";
            this.tsmiStoreInNew.Size = new System.Drawing.Size(90, 20);
            this.tsmiStoreInNew.Text = "Thêm mới";
            this.tsmiStoreInNew.Click += new System.EventHandler(this.tsmiStoreInNew_Click);
            // 
            // tsmiStoreInSave
            // 
            this.tsmiStoreInSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiStoreInSave.Image")));
            this.tsmiStoreInSave.Name = "tsmiStoreInSave";
            this.tsmiStoreInSave.Size = new System.Drawing.Size(55, 20);
            this.tsmiStoreInSave.Text = "Lưu";
            this.tsmiStoreInSave.Click += new System.EventHandler(this.tsmiStoreInSave_Click);
            // 
            // tsmiStoreInDelete
            // 
            this.tsmiStoreInDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiStoreInDelete.Image")));
            this.tsmiStoreInDelete.Name = "tsmiStoreInDelete";
            this.tsmiStoreInDelete.Size = new System.Drawing.Size(55, 20);
            this.tsmiStoreInDelete.Text = "Xóa";
            this.tsmiStoreInDelete.Click += new System.EventHandler(this.tsmiStoreInDelete_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtStoreInDetail_Total);
            this.tabPage5.Controls.Add(this.label57);
            this.tabPage5.Controls.Add(this.cmbProductId);
            this.tabPage5.Controls.Add(this.cmbStoreId);
            this.tabPage5.Controls.Add(this.txtStoreDetail_ParceNumber);
            this.tabPage5.Controls.Add(this.txtStoreDetail_Price);
            this.tabPage5.Controls.Add(this.txtStoreDetail_Quantity);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.dgvStoreDetail);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.menuStrip5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(861, 628);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Chi tiết nhập";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtStoreInDetail_Total
            // 
            this.txtStoreInDetail_Total.Location = new System.Drawing.Point(56, 601);
            this.txtStoreInDetail_Total.Name = "txtStoreInDetail_Total";
            this.txtStoreInDetail_Total.Size = new System.Drawing.Size(180, 20);
            this.txtStoreInDetail_Total.TabIndex = 22;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(18, 604);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(35, 13);
            this.label57.TabIndex = 21;
            this.label57.Text = "Tổng:";
            // 
            // cmbProductId
            // 
            this.cmbProductId.DataSource = this.tblProductBindingSource;
            this.cmbProductId.DisplayMember = "Name";
            this.cmbProductId.FormattingEnabled = true;
            this.cmbProductId.Location = new System.Drawing.Point(588, 76);
            this.cmbProductId.Name = "cmbProductId";
            this.cmbProductId.Size = new System.Drawing.Size(228, 21);
            this.cmbProductId.TabIndex = 2;
            this.cmbProductId.ValueMember = "Id";
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // cmbStoreId
            // 
            this.cmbStoreId.DataSource = this.tblStoreInBindingSource;
            this.cmbStoreId.DisplayMember = "Id";
            this.cmbStoreId.FormattingEnabled = true;
            this.cmbStoreId.Location = new System.Drawing.Point(588, 41);
            this.cmbStoreId.Name = "cmbStoreId";
            this.cmbStoreId.Size = new System.Drawing.Size(228, 21);
            this.cmbStoreId.TabIndex = 1;
            this.cmbStoreId.ValueMember = "Id";
            // 
            // txtStoreDetail_ParceNumber
            // 
            this.txtStoreDetail_ParceNumber.Location = new System.Drawing.Point(588, 109);
            this.txtStoreDetail_ParceNumber.Name = "txtStoreDetail_ParceNumber";
            this.txtStoreDetail_ParceNumber.Size = new System.Drawing.Size(228, 20);
            this.txtStoreDetail_ParceNumber.TabIndex = 3;
            // 
            // txtStoreDetail_Price
            // 
            this.txtStoreDetail_Price.Location = new System.Drawing.Point(588, 180);
            this.txtStoreDetail_Price.Name = "txtStoreDetail_Price";
            this.txtStoreDetail_Price.Size = new System.Drawing.Size(228, 20);
            this.txtStoreDetail_Price.TabIndex = 5;
            // 
            // txtStoreDetail_Quantity
            // 
            this.txtStoreDetail_Quantity.Location = new System.Drawing.Point(588, 144);
            this.txtStoreDetail_Quantity.Name = "txtStoreDetail_Quantity";
            this.txtStoreDetail_Quantity.Size = new System.Drawing.Size(228, 20);
            this.txtStoreDetail_Quantity.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(516, 183);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Giá nhập :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(516, 147);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "Số lượng :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(516, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Số lô:";
            // 
            // dgvStoreDetail
            // 
            this.dgvStoreDetail.AllowUserToAddRows = false;
            this.dgvStoreDetail.AllowUserToDeleteRows = false;
            this.dgvStoreDetail.AutoGenerateColumns = false;
            this.dgvStoreDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoreDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.storeInIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.pacelNumberDataGridViewTextBoxColumn,
            this.quantityInDataGridViewTextBoxColumn,
            this.priceInDataGridViewTextBoxColumn});
            this.dgvStoreDetail.DataSource = this.tblStoreInDetailBindingSource;
            this.dgvStoreDetail.Location = new System.Drawing.Point(20, 40);
            this.dgvStoreDetail.Name = "dgvStoreDetail";
            this.dgvStoreDetail.ReadOnly = true;
            this.dgvStoreDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStoreDetail.Size = new System.Drawing.Size(460, 555);
            this.dgvStoreDetail.TabIndex = 10;
            this.dgvStoreDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreDetail_CellClick);
            // 
            // storeInIdDataGridViewTextBoxColumn
            // 
            this.storeInIdDataGridViewTextBoxColumn.DataPropertyName = "StoreInId";
            this.storeInIdDataGridViewTextBoxColumn.HeaderText = "Mã nhập";
            this.storeInIdDataGridViewTextBoxColumn.Name = "storeInIdDataGridViewTextBoxColumn";
            this.storeInIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeInIdDataGridViewTextBoxColumn.Width = 90;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Mã SP";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // pacelNumberDataGridViewTextBoxColumn
            // 
            this.pacelNumberDataGridViewTextBoxColumn.DataPropertyName = "PacelNumber";
            this.pacelNumberDataGridViewTextBoxColumn.HeaderText = "Số lô";
            this.pacelNumberDataGridViewTextBoxColumn.Name = "pacelNumberDataGridViewTextBoxColumn";
            this.pacelNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.pacelNumberDataGridViewTextBoxColumn.Width = 70;
            // 
            // quantityInDataGridViewTextBoxColumn
            // 
            this.quantityInDataGridViewTextBoxColumn.DataPropertyName = "QuantityIn";
            this.quantityInDataGridViewTextBoxColumn.HeaderText = "Số lượng nhập";
            this.quantityInDataGridViewTextBoxColumn.Name = "quantityInDataGridViewTextBoxColumn";
            this.quantityInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceInDataGridViewTextBoxColumn
            // 
            this.priceInDataGridViewTextBoxColumn.DataPropertyName = "PriceIn";
            this.priceInDataGridViewTextBoxColumn.HeaderText = "Giá nhập";
            this.priceInDataGridViewTextBoxColumn.Name = "priceInDataGridViewTextBoxColumn";
            this.priceInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblStoreInDetailBindingSource
            // 
            this.tblStoreInDetailBindingSource.DataMember = "tblStoreInDetail";
            this.tblStoreInDetailBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(516, 41);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Mã nhập:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(516, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Sản phẩm:";
            // 
            // menuStrip5
            // 
            this.menuStrip5.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStoreDetailNew,
            this.tsmiStoreDetailSave,
            this.tsmiStoreDetailDelete});
            this.menuStrip5.Location = new System.Drawing.Point(3, 3);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(855, 24);
            this.menuStrip5.TabIndex = 9;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // tsmiStoreDetailNew
            // 
            this.tsmiStoreDetailNew.Image = ((System.Drawing.Image)(resources.GetObject("tsmiStoreDetailNew.Image")));
            this.tsmiStoreDetailNew.Name = "tsmiStoreDetailNew";
            this.tsmiStoreDetailNew.Size = new System.Drawing.Size(90, 20);
            this.tsmiStoreDetailNew.Text = "Thêm mới";
            this.tsmiStoreDetailNew.Click += new System.EventHandler(this.tsmiStoreDetailNew_Click);
            // 
            // tsmiStoreDetailSave
            // 
            this.tsmiStoreDetailSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmiStoreDetailSave.Image")));
            this.tsmiStoreDetailSave.Name = "tsmiStoreDetailSave";
            this.tsmiStoreDetailSave.Size = new System.Drawing.Size(55, 20);
            this.tsmiStoreDetailSave.Text = "Lưu";
            this.tsmiStoreDetailSave.Click += new System.EventHandler(this.tsmiStoreDetailSave_Click);
            // 
            // tsmiStoreDetailDelete
            // 
            this.tsmiStoreDetailDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiStoreDetailDelete.Image")));
            this.tsmiStoreDetailDelete.Name = "tsmiStoreDetailDelete";
            this.tsmiStoreDetailDelete.Size = new System.Drawing.Size(55, 20);
            this.tsmiStoreDetailDelete.Text = "Xóa";
            this.tsmiStoreDetailDelete.Click += new System.EventHandler(this.tsmiStoreDetailDelete_Click);
            // 
            // tblStoreInTableAdapter
            // 
            this.tblStoreInTableAdapter.ClearBeforeFill = true;
            // 
            // tblProvidersTableAdapter
            // 
            this.tblProvidersTableAdapter.ClearBeforeFill = true;
            // 
            // tblStoreInDetailTableAdapter
            // 
            this.tblStoreInDetailTableAdapter.ClearBeforeFill = true;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // frmStoreIn_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 650);
            this.Controls.Add(this.tabControl2);
            this.Name = "frmStoreIn_update";
            this.Text = "frmStoreIn";
            this.Load += new System.EventHandler(this.frmStoreIn_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProvidersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStoreInBindingSource)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStoreInDetailBindingSource)).EndInit();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtStoreIn_Total;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStoreInId;
        private System.Windows.Forms.DateTimePicker dtpStoreInDate;
        private System.Windows.Forms.ComboBox cmbProvidersId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvStoreIn;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem tsmiStoreInNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiStoreInSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiStoreInDelete;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtStoreInDetail_Total;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ComboBox cmbProductId;
        private System.Windows.Forms.ComboBox cmbStoreId;
        private System.Windows.Forms.TextBox txtStoreDetail_ParceNumber;
        private System.Windows.Forms.TextBox txtStoreDetail_Price;
        private System.Windows.Forms.TextBox txtStoreDetail_Quantity;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvStoreDetail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem tsmiStoreDetailNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiStoreDetailSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiStoreDetailDelete;
        private QUANLIKINHDOANHDIENTHOAIDataSet qUANLIKINHDOANHDIENTHOAIDataSet;
        private System.Windows.Forms.BindingSource tblStoreInBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblStoreInTableAdapter tblStoreInTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvidersId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIn;
        private System.Windows.Forms.BindingSource tblProvidersBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblProvidersTableAdapter tblProvidersTableAdapter;
        private System.Windows.Forms.BindingSource tblStoreInDetailBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblStoreInDetailTableAdapter tblStoreInDetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeInIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacelNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceInDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providersIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
    }
}