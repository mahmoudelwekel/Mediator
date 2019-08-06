namespace Mediator
{
    partial class bills
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
            System.Windows.Forms.Label bill_factory_idLabel;
            System.Windows.Forms.Label bill_product_idLabel;
            System.Windows.Forms.Label bill_product_type_idLabel;
            System.Windows.Forms.Label bill_product_quantityLabel;
            System.Windows.Forms.Label bill_datetimeLabel;
            System.Windows.Forms.Label bill_costLabel;
            System.Windows.Forms.Label bill_handlers_costLabel;
            System.Windows.Forms.Label bill_client_idLabel;
            System.Windows.Forms.Label bill_driver_idLabel;
            System.Windows.Forms.Label bill_commentLabel;
            System.Windows.Forms.Label bill_client_profitLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.clientsViewDataGridView = new System.Windows.Forms.DataGridView();
            this.billidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billfactoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.factoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MediatorDataSet = new Mediator.MediatorDataSet();
            this.billproductidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billproducttypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productsTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billproductquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billdatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billhandlerscostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billclientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billuseridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billdriveridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billcommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billclientprofitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.RefreshBtn = new System.Windows.Forms.PictureBox();
            this.bill_factory_idComboBox = new System.Windows.Forms.ComboBox();
            this.bill_product_idComboBox = new System.Windows.Forms.ComboBox();
            this.bill_product_type_idComboBox = new System.Windows.Forms.ComboBox();
            this.bill_product_quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bill_datetimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bill_costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bill_handlers_costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bill_client_idComboBox = new System.Windows.Forms.ComboBox();
            this.bill_driver_idComboBox = new System.Windows.Forms.ComboBox();
            this.bill_commentTextBox = new System.Windows.Forms.TextBox();
            this.billsTableAdapter = new Mediator.MediatorDataSetTableAdapters.BillsTableAdapter();
            this.bill_client_profitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.factoriesTableAdapter = new Mediator.MediatorDataSetTableAdapters.FactoriesTableAdapter();
            this.productsTableAdapter = new Mediator.MediatorDataSetTableAdapters.ProductsTableAdapter();
            this.products_TypesTableAdapter = new Mediator.MediatorDataSetTableAdapters.Products_TypesTableAdapter();
            this.clientsTableAdapter = new Mediator.MediatorDataSetTableAdapters.ClientsTableAdapter();
            this.usersTableAdapter = new Mediator.MediatorDataSetTableAdapters.usersTableAdapter();
            this.driversTableAdapter = new Mediator.MediatorDataSetTableAdapters.DriversTableAdapter();
            bill_factory_idLabel = new System.Windows.Forms.Label();
            bill_product_idLabel = new System.Windows.Forms.Label();
            bill_product_type_idLabel = new System.Windows.Forms.Label();
            bill_product_quantityLabel = new System.Windows.Forms.Label();
            bill_datetimeLabel = new System.Windows.Forms.Label();
            bill_costLabel = new System.Windows.Forms.Label();
            bill_handlers_costLabel = new System.Windows.Forms.Label();
            bill_client_idLabel = new System.Windows.Forms.Label();
            bill_driver_idLabel = new System.Windows.Forms.Label();
            bill_commentLabel = new System.Windows.Forms.Label();
            bill_client_profitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_product_quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_handlers_costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_client_profitNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_factory_idLabel
            // 
            bill_factory_idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_factory_idLabel.AutoSize = true;
            bill_factory_idLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_factory_idLabel.Location = new System.Drawing.Point(1200, 95);
            bill_factory_idLabel.Name = "bill_factory_idLabel";
            bill_factory_idLabel.Size = new System.Drawing.Size(58, 26);
            bill_factory_idLabel.TabIndex = 17;
            bill_factory_idLabel.Text = "المصنع";
            // 
            // bill_product_idLabel
            // 
            bill_product_idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_product_idLabel.AutoSize = true;
            bill_product_idLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_product_idLabel.Location = new System.Drawing.Point(938, 95);
            bill_product_idLabel.Name = "bill_product_idLabel";
            bill_product_idLabel.Size = new System.Drawing.Size(52, 26);
            bill_product_idLabel.TabIndex = 19;
            bill_product_idLabel.Text = "المنتج";
            // 
            // bill_product_type_idLabel
            // 
            bill_product_type_idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_product_type_idLabel.AutoSize = true;
            bill_product_type_idLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_product_type_idLabel.Location = new System.Drawing.Point(661, 95);
            bill_product_type_idLabel.Name = "bill_product_type_idLabel";
            bill_product_type_idLabel.Size = new System.Drawing.Size(44, 26);
            bill_product_type_idLabel.TabIndex = 22;
            bill_product_type_idLabel.Text = "النوع";
            // 
            // bill_product_quantityLabel
            // 
            bill_product_quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_product_quantityLabel.AutoSize = true;
            bill_product_quantityLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_product_quantityLabel.Location = new System.Drawing.Point(1200, 133);
            bill_product_quantityLabel.Name = "bill_product_quantityLabel";
            bill_product_quantityLabel.Size = new System.Drawing.Size(56, 26);
            bill_product_quantityLabel.TabIndex = 16;
            bill_product_quantityLabel.Text = "الكمية";
            // 
            // bill_datetimeLabel
            // 
            bill_datetimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_datetimeLabel.AutoSize = true;
            bill_datetimeLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_datetimeLabel.Location = new System.Drawing.Point(431, 95);
            bill_datetimeLabel.Name = "bill_datetimeLabel";
            bill_datetimeLabel.Size = new System.Drawing.Size(50, 26);
            bill_datetimeLabel.TabIndex = 23;
            bill_datetimeLabel.Text = "التاريخ";
            // 
            // bill_costLabel
            // 
            bill_costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_costLabel.AutoSize = true;
            bill_costLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_costLabel.Location = new System.Drawing.Point(938, 133);
            bill_costLabel.Name = "bill_costLabel";
            bill_costLabel.Size = new System.Drawing.Size(60, 26);
            bill_costLabel.TabIndex = 20;
            bill_costLabel.Text = "التكلفة";
            // 
            // bill_handlers_costLabel
            // 
            bill_handlers_costLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_handlers_costLabel.AutoSize = true;
            bill_handlers_costLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_handlers_costLabel.Location = new System.Drawing.Point(661, 133);
            bill_handlers_costLabel.Name = "bill_handlers_costLabel";
            bill_handlers_costLabel.Size = new System.Drawing.Size(72, 26);
            bill_handlers_costLabel.TabIndex = 21;
            bill_handlers_costLabel.Text = "المناولون";
            // 
            // bill_client_idLabel
            // 
            bill_client_idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_client_idLabel.AutoSize = true;
            bill_client_idLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_client_idLabel.Location = new System.Drawing.Point(431, 133);
            bill_client_idLabel.Name = "bill_client_idLabel";
            bill_client_idLabel.Size = new System.Drawing.Size(56, 26);
            bill_client_idLabel.TabIndex = 24;
            bill_client_idLabel.Text = "العميل";
            // 
            // bill_driver_idLabel
            // 
            bill_driver_idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_driver_idLabel.AutoSize = true;
            bill_driver_idLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_driver_idLabel.Location = new System.Drawing.Point(184, 95);
            bill_driver_idLabel.Name = "bill_driver_idLabel";
            bill_driver_idLabel.Size = new System.Drawing.Size(56, 26);
            bill_driver_idLabel.TabIndex = 26;
            bill_driver_idLabel.Text = "السائق";
            // 
            // bill_commentLabel
            // 
            bill_commentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_commentLabel.AutoSize = true;
            bill_commentLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_commentLabel.Location = new System.Drawing.Point(1200, 171);
            bill_commentLabel.Name = "bill_commentLabel";
            bill_commentLabel.Size = new System.Drawing.Size(61, 26);
            bill_commentLabel.TabIndex = 15;
            bill_commentLabel.Text = "التعليق";
            // 
            // bill_client_profitLabel
            // 
            bill_client_profitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bill_client_profitLabel.AutoSize = true;
            bill_client_profitLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bill_client_profitLabel.Location = new System.Drawing.Point(184, 133);
            bill_client_profitLabel.Name = "bill_client_profitLabel";
            bill_client_profitLabel.Size = new System.Drawing.Size(56, 26);
            bill_client_profitLabel.TabIndex = 25;
            bill_client_profitLabel.Text = "الفوائد";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(878, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 56);
            this.label1.TabIndex = 18;
            this.label1.Text = "الفواتير";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientsViewDataGridView
            // 
            this.clientsViewDataGridView.AllowUserToAddRows = false;
            this.clientsViewDataGridView.AllowUserToDeleteRows = false;
            this.clientsViewDataGridView.AllowUserToResizeColumns = false;
            this.clientsViewDataGridView.AllowUserToResizeRows = false;
            this.clientsViewDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientsViewDataGridView.AutoGenerateColumns = false;
            this.clientsViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billidDataGridViewTextBoxColumn,
            this.billfactoryidDataGridViewTextBoxColumn,
            this.billproductidDataGridViewTextBoxColumn,
            this.billproducttypeidDataGridViewTextBoxColumn,
            this.billproductquantityDataGridViewTextBoxColumn,
            this.billdatetimeDataGridViewTextBoxColumn,
            this.billcostDataGridViewTextBoxColumn,
            this.billhandlerscostDataGridViewTextBoxColumn,
            this.billclientidDataGridViewTextBoxColumn,
            this.billuseridDataGridViewTextBoxColumn,
            this.billdriveridDataGridViewTextBoxColumn,
            this.billcommentDataGridViewTextBoxColumn,
            this.billclientprofitDataGridViewTextBoxColumn});
            this.clientsViewDataGridView.DataSource = this.billsBindingSource;
            this.clientsViewDataGridView.Location = new System.Drawing.Point(12, 252);
            this.clientsViewDataGridView.MultiSelect = false;
            this.clientsViewDataGridView.Name = "clientsViewDataGridView";
            this.clientsViewDataGridView.ReadOnly = true;
            this.clientsViewDataGridView.RowHeadersVisible = false;
            this.clientsViewDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsViewDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.clientsViewDataGridView.RowTemplate.Height = 30;
            this.clientsViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsViewDataGridView.Size = new System.Drawing.Size(1241, 309);
            this.clientsViewDataGridView.TabIndex = 14;
            // 
            // billidDataGridViewTextBoxColumn
            // 
            this.billidDataGridViewTextBoxColumn.DataPropertyName = "bill_id";
            this.billidDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.billidDataGridViewTextBoxColumn.Name = "billidDataGridViewTextBoxColumn";
            this.billidDataGridViewTextBoxColumn.ReadOnly = true;
            this.billidDataGridViewTextBoxColumn.Visible = false;
            // 
            // billfactoryidDataGridViewTextBoxColumn
            // 
            this.billfactoryidDataGridViewTextBoxColumn.DataPropertyName = "bill_factory_id";
            this.billfactoryidDataGridViewTextBoxColumn.DataSource = this.factoriesBindingSource;
            this.billfactoryidDataGridViewTextBoxColumn.DisplayMember = "factory_name";
            this.billfactoryidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.billfactoryidDataGridViewTextBoxColumn.HeaderText = "المصنع";
            this.billfactoryidDataGridViewTextBoxColumn.Name = "billfactoryidDataGridViewTextBoxColumn";
            this.billfactoryidDataGridViewTextBoxColumn.ReadOnly = true;
            this.billfactoryidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.billfactoryidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.billfactoryidDataGridViewTextBoxColumn.ValueMember = "factory_id";
            // 
            // factoriesBindingSource
            // 
            this.factoriesBindingSource.DataMember = "Factories";
            this.factoriesBindingSource.DataSource = this.MediatorDataSet;
            // 
            // MediatorDataSet
            // 
            this.MediatorDataSet.DataSetName = "MediatorDataSet";
            this.MediatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billproductidDataGridViewTextBoxColumn
            // 
            this.billproductidDataGridViewTextBoxColumn.DataPropertyName = "bill_product_id";
            this.billproductidDataGridViewTextBoxColumn.DataSource = this.productsBindingSource;
            this.billproductidDataGridViewTextBoxColumn.DisplayMember = "product_name";
            this.billproductidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.billproductidDataGridViewTextBoxColumn.HeaderText = "المنتج";
            this.billproductidDataGridViewTextBoxColumn.Name = "billproductidDataGridViewTextBoxColumn";
            this.billproductidDataGridViewTextBoxColumn.ReadOnly = true;
            this.billproductidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.billproductidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.billproductidDataGridViewTextBoxColumn.ValueMember = "product_id";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.MediatorDataSet;
            // 
            // billproducttypeidDataGridViewTextBoxColumn
            // 
            this.billproducttypeidDataGridViewTextBoxColumn.DataPropertyName = "bill_product_type_id";
            this.billproducttypeidDataGridViewTextBoxColumn.DataSource = this.productsTypesBindingSource;
            this.billproducttypeidDataGridViewTextBoxColumn.DisplayMember = "product_type_name";
            this.billproducttypeidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.billproducttypeidDataGridViewTextBoxColumn.HeaderText = "النوع";
            this.billproducttypeidDataGridViewTextBoxColumn.Name = "billproducttypeidDataGridViewTextBoxColumn";
            this.billproducttypeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.billproducttypeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.billproducttypeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.billproducttypeidDataGridViewTextBoxColumn.ValueMember = "product_type_id";
            // 
            // productsTypesBindingSource
            // 
            this.productsTypesBindingSource.DataMember = "Products_Types";
            this.productsTypesBindingSource.DataSource = this.MediatorDataSet;
            // 
            // billproductquantityDataGridViewTextBoxColumn
            // 
            this.billproductquantityDataGridViewTextBoxColumn.DataPropertyName = "bill_product_quantity";
            this.billproductquantityDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.billproductquantityDataGridViewTextBoxColumn.Name = "billproductquantityDataGridViewTextBoxColumn";
            this.billproductquantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billdatetimeDataGridViewTextBoxColumn
            // 
            this.billdatetimeDataGridViewTextBoxColumn.DataPropertyName = "bill_datetime";
            this.billdatetimeDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.billdatetimeDataGridViewTextBoxColumn.Name = "billdatetimeDataGridViewTextBoxColumn";
            this.billdatetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billcostDataGridViewTextBoxColumn
            // 
            this.billcostDataGridViewTextBoxColumn.DataPropertyName = "bill_cost";
            this.billcostDataGridViewTextBoxColumn.HeaderText = "التكلفة";
            this.billcostDataGridViewTextBoxColumn.Name = "billcostDataGridViewTextBoxColumn";
            this.billcostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billhandlerscostDataGridViewTextBoxColumn
            // 
            this.billhandlerscostDataGridViewTextBoxColumn.DataPropertyName = "bill_handlers_cost";
            this.billhandlerscostDataGridViewTextBoxColumn.HeaderText = "المناولون";
            this.billhandlerscostDataGridViewTextBoxColumn.Name = "billhandlerscostDataGridViewTextBoxColumn";
            this.billhandlerscostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billclientidDataGridViewTextBoxColumn
            // 
            this.billclientidDataGridViewTextBoxColumn.DataPropertyName = "bill_client_id";
            this.billclientidDataGridViewTextBoxColumn.DataSource = this.clientsBindingSource;
            this.billclientidDataGridViewTextBoxColumn.DisplayMember = "client_name";
            this.billclientidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.billclientidDataGridViewTextBoxColumn.HeaderText = "العميل";
            this.billclientidDataGridViewTextBoxColumn.Name = "billclientidDataGridViewTextBoxColumn";
            this.billclientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.billclientidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.billclientidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.billclientidDataGridViewTextBoxColumn.ValueMember = "client_id";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.MediatorDataSet;
            // 
            // billuseridDataGridViewTextBoxColumn
            // 
            this.billuseridDataGridViewTextBoxColumn.DataPropertyName = "bill_user_id";
            this.billuseridDataGridViewTextBoxColumn.DataSource = this.usersBindingSource;
            this.billuseridDataGridViewTextBoxColumn.DisplayMember = "user_name";
            this.billuseridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.billuseridDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.billuseridDataGridViewTextBoxColumn.Name = "billuseridDataGridViewTextBoxColumn";
            this.billuseridDataGridViewTextBoxColumn.ReadOnly = true;
            this.billuseridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.billuseridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.billuseridDataGridViewTextBoxColumn.ValueMember = "user_id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.MediatorDataSet;
            // 
            // billdriveridDataGridViewTextBoxColumn
            // 
            this.billdriveridDataGridViewTextBoxColumn.DataPropertyName = "bill_driver_id";
            this.billdriveridDataGridViewTextBoxColumn.DataSource = this.driversBindingSource;
            this.billdriveridDataGridViewTextBoxColumn.DisplayMember = "driver_name";
            this.billdriveridDataGridViewTextBoxColumn.HeaderText = "السائق";
            this.billdriveridDataGridViewTextBoxColumn.Name = "billdriveridDataGridViewTextBoxColumn";
            this.billdriveridDataGridViewTextBoxColumn.ReadOnly = true;
            this.billdriveridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.billdriveridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.billdriveridDataGridViewTextBoxColumn.ValueMember = "driver_id";
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.MediatorDataSet;
            // 
            // billcommentDataGridViewTextBoxColumn
            // 
            this.billcommentDataGridViewTextBoxColumn.DataPropertyName = "bill_comment";
            this.billcommentDataGridViewTextBoxColumn.HeaderText = "التعليق";
            this.billcommentDataGridViewTextBoxColumn.Name = "billcommentDataGridViewTextBoxColumn";
            this.billcommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billclientprofitDataGridViewTextBoxColumn
            // 
            this.billclientprofitDataGridViewTextBoxColumn.DataPropertyName = "bill_client_profit";
            this.billclientprofitDataGridViewTextBoxColumn.HeaderText = "الفوائد";
            this.billclientprofitDataGridViewTextBoxColumn.Name = "billclientprofitDataGridViewTextBoxColumn";
            this.billclientprofitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billsBindingSource
            // 
            this.billsBindingSource.DataMember = "Bills";
            this.billsBindingSource.DataSource = this.MediatorDataSet;
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(848, 206);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(170, 40);
            this.delete_btn.TabIndex = 12;
            this.delete_btn.Text = "حذف";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(1024, 206);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(170, 40);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "أضافة";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(12, 206);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(170, 40);
            this.edit_btn.TabIndex = 13;
            this.edit_btn.Text = "تعديل";
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = global::Mediator.Properties.Resources.back;
            this.BackBtn.Location = new System.Drawing.Point(766, 17);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(50, 50);
            this.BackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackBtn.TabIndex = 59;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.back_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.Image = global::Mediator.Properties.Resources.refresh;
            this.RefreshBtn.Location = new System.Drawing.Point(822, 17);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(50, 50);
            this.RefreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshBtn.TabIndex = 58;
            this.RefreshBtn.TabStop = false;
            this.RefreshBtn.Click += new System.EventHandler(this.refresh_Click);
            // 
            // bill_factory_idComboBox
            // 
            this.bill_factory_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_factory_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billsBindingSource, "bill_factory_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_factory_idComboBox.DataSource = this.factoriesBindingSource;
            this.bill_factory_idComboBox.DisplayMember = "factory_name";
            this.bill_factory_idComboBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_factory_idComboBox.FormattingEnabled = true;
            this.bill_factory_idComboBox.Location = new System.Drawing.Point(1004, 92);
            this.bill_factory_idComboBox.Name = "bill_factory_idComboBox";
            this.bill_factory_idComboBox.Size = new System.Drawing.Size(190, 32);
            this.bill_factory_idComboBox.TabIndex = 0;
            this.bill_factory_idComboBox.ValueMember = "factory_id";
            // 
            // bill_product_idComboBox
            // 
            this.bill_product_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_product_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billsBindingSource, "bill_product_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_product_idComboBox.DataSource = this.productsBindingSource;
            this.bill_product_idComboBox.DisplayMember = "product_name";
            this.bill_product_idComboBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_product_idComboBox.FormattingEnabled = true;
            this.bill_product_idComboBox.Location = new System.Drawing.Point(737, 92);
            this.bill_product_idComboBox.Name = "bill_product_idComboBox";
            this.bill_product_idComboBox.Size = new System.Drawing.Size(195, 32);
            this.bill_product_idComboBox.TabIndex = 1;
            this.bill_product_idComboBox.ValueMember = "product_id";
            // 
            // bill_product_type_idComboBox
            // 
            this.bill_product_type_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_product_type_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billsBindingSource, "bill_product_type_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_product_type_idComboBox.DataSource = this.productsTypesBindingSource;
            this.bill_product_type_idComboBox.DisplayMember = "product_type_name";
            this.bill_product_type_idComboBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_product_type_idComboBox.FormattingEnabled = true;
            this.bill_product_type_idComboBox.Location = new System.Drawing.Point(487, 92);
            this.bill_product_type_idComboBox.Name = "bill_product_type_idComboBox";
            this.bill_product_type_idComboBox.Size = new System.Drawing.Size(168, 32);
            this.bill_product_type_idComboBox.TabIndex = 2;
            this.bill_product_type_idComboBox.ValueMember = "product_type_id";
            // 
            // bill_product_quantityNumericUpDown
            // 
            this.bill_product_quantityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_product_quantityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billsBindingSource, "bill_product_quantity", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_product_quantityNumericUpDown.DecimalPlaces = 2;
            this.bill_product_quantityNumericUpDown.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_product_quantityNumericUpDown.Location = new System.Drawing.Point(1004, 130);
            this.bill_product_quantityNumericUpDown.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.bill_product_quantityNumericUpDown.Name = "bill_product_quantityNumericUpDown";
            this.bill_product_quantityNumericUpDown.Size = new System.Drawing.Size(190, 32);
            this.bill_product_quantityNumericUpDown.TabIndex = 5;
            // 
            // bill_datetimeDateTimePicker
            // 
            this.bill_datetimeDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_datetimeDateTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.bill_datetimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billsBindingSource, "bill_datetime", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_datetimeDateTimePicker.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_datetimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bill_datetimeDateTimePicker.Location = new System.Drawing.Point(256, 92);
            this.bill_datetimeDateTimePicker.Name = "bill_datetimeDateTimePicker";
            this.bill_datetimeDateTimePicker.Size = new System.Drawing.Size(169, 32);
            this.bill_datetimeDateTimePicker.TabIndex = 3;
            // 
            // bill_costNumericUpDown
            // 
            this.bill_costNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_costNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billsBindingSource, "bill_cost", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_costNumericUpDown.DecimalPlaces = 2;
            this.bill_costNumericUpDown.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_costNumericUpDown.Location = new System.Drawing.Point(735, 130);
            this.bill_costNumericUpDown.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.bill_costNumericUpDown.Name = "bill_costNumericUpDown";
            this.bill_costNumericUpDown.Size = new System.Drawing.Size(197, 32);
            this.bill_costNumericUpDown.TabIndex = 6;
            // 
            // bill_handlers_costNumericUpDown
            // 
            this.bill_handlers_costNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_handlers_costNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.billsBindingSource, "bill_handlers_cost", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_handlers_costNumericUpDown.DecimalPlaces = 2;
            this.bill_handlers_costNumericUpDown.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_handlers_costNumericUpDown.Location = new System.Drawing.Point(487, 130);
            this.bill_handlers_costNumericUpDown.Maximum = new decimal(new int[] {
            -159383553,
            46653770,
            5421,
            0});
            this.bill_handlers_costNumericUpDown.Name = "bill_handlers_costNumericUpDown";
            this.bill_handlers_costNumericUpDown.Size = new System.Drawing.Size(168, 32);
            this.bill_handlers_costNumericUpDown.TabIndex = 7;
            // 
            // bill_client_idComboBox
            // 
            this.bill_client_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_client_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billsBindingSource, "bill_client_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_client_idComboBox.DataSource = this.clientsBindingSource;
            this.bill_client_idComboBox.DisplayMember = "client_name";
            this.bill_client_idComboBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_client_idComboBox.FormattingEnabled = true;
            this.bill_client_idComboBox.Location = new System.Drawing.Point(256, 130);
            this.bill_client_idComboBox.Name = "bill_client_idComboBox";
            this.bill_client_idComboBox.Size = new System.Drawing.Size(169, 32);
            this.bill_client_idComboBox.TabIndex = 8;
            this.bill_client_idComboBox.ValueMember = "client_id";
            // 
            // bill_driver_idComboBox
            // 
            this.bill_driver_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_driver_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billsBindingSource, "bill_driver_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_driver_idComboBox.DataSource = this.driversBindingSource;
            this.bill_driver_idComboBox.DisplayMember = "driver_name";
            this.bill_driver_idComboBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_driver_idComboBox.FormattingEnabled = true;
            this.bill_driver_idComboBox.Location = new System.Drawing.Point(12, 92);
            this.bill_driver_idComboBox.Name = "bill_driver_idComboBox";
            this.bill_driver_idComboBox.Size = new System.Drawing.Size(166, 32);
            this.bill_driver_idComboBox.TabIndex = 4;
            this.bill_driver_idComboBox.ValueMember = "driver_id";
            // 
            // bill_commentTextBox
            // 
            this.bill_commentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.billsBindingSource, "bill_comment", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_commentTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_commentTextBox.Location = new System.Drawing.Point(12, 168);
            this.bill_commentTextBox.Name = "bill_commentTextBox";
            this.bill_commentTextBox.Size = new System.Drawing.Size(1182, 32);
            this.bill_commentTextBox.TabIndex = 10;
            // 
            // billsTableAdapter
            // 
            this.billsTableAdapter.ClearBeforeFill = true;
            // 
            // bill_client_profitNumericUpDown
            // 
            this.bill_client_profitNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bill_client_profitNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "client_profit", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bill_client_profitNumericUpDown.DecimalPlaces = 2;
            this.bill_client_profitNumericUpDown.Enabled = false;
            this.bill_client_profitNumericUpDown.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill_client_profitNumericUpDown.Location = new System.Drawing.Point(12, 130);
            this.bill_client_profitNumericUpDown.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.bill_client_profitNumericUpDown.Name = "bill_client_profitNumericUpDown";
            this.bill_client_profitNumericUpDown.ReadOnly = true;
            this.bill_client_profitNumericUpDown.Size = new System.Drawing.Size(166, 32);
            this.bill_client_profitNumericUpDown.TabIndex = 9;
            // 
            // factoriesTableAdapter
            // 
            this.factoriesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // products_TypesTableAdapter
            // 
            this.products_TypesTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // bills
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 573);
            this.Controls.Add(bill_client_profitLabel);
            this.Controls.Add(this.bill_client_profitNumericUpDown);
            this.Controls.Add(bill_factory_idLabel);
            this.Controls.Add(this.bill_factory_idComboBox);
            this.Controls.Add(bill_product_idLabel);
            this.Controls.Add(this.bill_product_idComboBox);
            this.Controls.Add(bill_product_type_idLabel);
            this.Controls.Add(this.bill_product_type_idComboBox);
            this.Controls.Add(bill_product_quantityLabel);
            this.Controls.Add(this.bill_product_quantityNumericUpDown);
            this.Controls.Add(bill_datetimeLabel);
            this.Controls.Add(this.bill_datetimeDateTimePicker);
            this.Controls.Add(bill_costLabel);
            this.Controls.Add(this.bill_costNumericUpDown);
            this.Controls.Add(bill_handlers_costLabel);
            this.Controls.Add(this.bill_handlers_costNumericUpDown);
            this.Controls.Add(bill_client_idLabel);
            this.Controls.Add(this.bill_client_idComboBox);
            this.Controls.Add(bill_driver_idLabel);
            this.Controls.Add(this.bill_driver_idComboBox);
            this.Controls.Add(bill_commentLabel);
            this.Controls.Add(this.bill_commentTextBox);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.clientsViewDataGridView);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "bills";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الفواتير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.clients_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clients_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_product_quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_handlers_costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_client_profitNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.PictureBox RefreshBtn;
        private System.Windows.Forms.DataGridView clientsViewDataGridView;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button edit_btn;
        private MediatorDataSet MediatorDataSet;
        private System.Windows.Forms.BindingSource billsBindingSource;
        private MediatorDataSetTableAdapters.BillsTableAdapter billsTableAdapter;
        private System.Windows.Forms.ComboBox bill_factory_idComboBox;
        private System.Windows.Forms.ComboBox bill_product_idComboBox;
        private System.Windows.Forms.ComboBox bill_product_type_idComboBox;
        private System.Windows.Forms.NumericUpDown bill_product_quantityNumericUpDown;
        private System.Windows.Forms.DateTimePicker bill_datetimeDateTimePicker;
        private System.Windows.Forms.NumericUpDown bill_costNumericUpDown;
        private System.Windows.Forms.NumericUpDown bill_handlers_costNumericUpDown;
        private System.Windows.Forms.ComboBox bill_client_idComboBox;
        private System.Windows.Forms.ComboBox bill_driver_idComboBox;
        private System.Windows.Forms.TextBox bill_commentTextBox;
        private System.Windows.Forms.NumericUpDown bill_client_profitNumericUpDown;
        private System.Windows.Forms.BindingSource factoriesBindingSource;
        private MediatorDataSetTableAdapters.FactoriesTableAdapter factoriesTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MediatorDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsTypesBindingSource;
        private MediatorDataSetTableAdapters.Products_TypesTableAdapter products_TypesTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private MediatorDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MediatorDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private MediatorDataSetTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn billfactoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn billproductidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn billproducttypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billproductquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billdatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billhandlerscostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn billclientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn billuseridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn billdriveridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billcommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billclientprofitDataGridViewTextBoxColumn;
    }
}

