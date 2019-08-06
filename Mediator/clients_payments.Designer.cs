namespace Mediator
{
    partial class clients_payments
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
            System.Windows.Forms.Label payment_detailsLabel;
            System.Windows.Forms.Label payment_dateLabel;
            System.Windows.Forms.Label payment_amountLabel;
            System.Windows.Forms.Label payment_client_idLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.clientsViewDataGridView = new System.Windows.Forms.DataGridView();
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentuseridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MediatorDataSet = new Mediator.MediatorDataSet();
            this.paymentclientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.RefreshBtn = new System.Windows.Forms.PictureBox();
            this.clients_PaymentsTableAdapter = new Mediator.MediatorDataSetTableAdapters.Clients_PaymentsTableAdapter();
            this.payment_detailsTextBox = new System.Windows.Forms.TextBox();
            this.payment_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payment_amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.payment_client_idComboBox = new System.Windows.Forms.ComboBox();
            this.clientsTableAdapter = new Mediator.MediatorDataSetTableAdapters.ClientsTableAdapter();
            this.usersTableAdapter = new Mediator.MediatorDataSetTableAdapters.usersTableAdapter();
            payment_detailsLabel = new System.Windows.Forms.Label();
            payment_dateLabel = new System.Windows.Forms.Label();
            payment_amountLabel = new System.Windows.Forms.Label();
            payment_client_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsPaymentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // payment_detailsLabel
            // 
            payment_detailsLabel.AutoSize = true;
            payment_detailsLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_detailsLabel.Location = new System.Drawing.Point(390, 120);
            payment_detailsLabel.Name = "payment_detailsLabel";
            payment_detailsLabel.Size = new System.Drawing.Size(68, 26);
            payment_detailsLabel.TabIndex = 13;
            payment_detailsLabel.Text = "التفاصيل";
            // 
            // payment_dateLabel
            // 
            payment_dateLabel.AutoSize = true;
            payment_dateLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_dateLabel.Location = new System.Drawing.Point(390, 82);
            payment_dateLabel.Name = "payment_dateLabel";
            payment_dateLabel.Size = new System.Drawing.Size(50, 26);
            payment_dateLabel.TabIndex = 14;
            payment_dateLabel.Text = "التاريخ";
            // 
            // payment_amountLabel
            // 
            payment_amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            payment_amountLabel.AutoSize = true;
            payment_amountLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_amountLabel.Location = new System.Drawing.Point(832, 120);
            payment_amountLabel.Name = "payment_amountLabel";
            payment_amountLabel.Size = new System.Drawing.Size(51, 26);
            payment_amountLabel.TabIndex = 11;
            payment_amountLabel.Text = "المبلغ";
            // 
            // payment_client_idLabel
            // 
            payment_client_idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            payment_client_idLabel.AutoSize = true;
            payment_client_idLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            payment_client_idLabel.Location = new System.Drawing.Point(832, 82);
            payment_client_idLabel.Name = "payment_client_idLabel";
            payment_client_idLabel.Size = new System.Drawing.Size(56, 26);
            payment_client_idLabel.TabIndex = 10;
            payment_client_idLabel.Text = "العميل";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(508, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 56);
            this.label1.TabIndex = 9;
            this.label1.Text = "دفعات العملاء";
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
            this.paymentidDataGridViewTextBoxColumn,
            this.paymentuseridDataGridViewTextBoxColumn,
            this.paymentclientidDataGridViewTextBoxColumn,
            this.paymentamountDataGridViewTextBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn,
            this.paymentdetailsDataGridViewTextBoxColumn});
            this.clientsViewDataGridView.DataSource = this.clientsPaymentsBindingSource;
            this.clientsViewDataGridView.Location = new System.Drawing.Point(12, 196);
            this.clientsViewDataGridView.MultiSelect = false;
            this.clientsViewDataGridView.Name = "clientsViewDataGridView";
            this.clientsViewDataGridView.ReadOnly = true;
            this.clientsViewDataGridView.RowHeadersVisible = false;
            this.clientsViewDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsViewDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.clientsViewDataGridView.RowTemplate.Height = 30;
            this.clientsViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsViewDataGridView.Size = new System.Drawing.Size(871, 292);
            this.clientsViewDataGridView.TabIndex = 8;
            // 
            // paymentidDataGridViewTextBoxColumn
            // 
            this.paymentidDataGridViewTextBoxColumn.DataPropertyName = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.HeaderText = "payment_id";
            this.paymentidDataGridViewTextBoxColumn.Name = "paymentidDataGridViewTextBoxColumn";
            this.paymentidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentidDataGridViewTextBoxColumn.Visible = false;
            // 
            // paymentuseridDataGridViewTextBoxColumn
            // 
            this.paymentuseridDataGridViewTextBoxColumn.DataPropertyName = "payment_user_id";
            this.paymentuseridDataGridViewTextBoxColumn.DataSource = this.usersBindingSource;
            this.paymentuseridDataGridViewTextBoxColumn.DisplayMember = "user_name";
            this.paymentuseridDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.paymentuseridDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.paymentuseridDataGridViewTextBoxColumn.Name = "paymentuseridDataGridViewTextBoxColumn";
            this.paymentuseridDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentuseridDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentuseridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.paymentuseridDataGridViewTextBoxColumn.ValueMember = "user_id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.MediatorDataSet;
            // 
            // MediatorDataSet
            // 
            this.MediatorDataSet.DataSetName = "MediatorDataSet";
            this.MediatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentclientidDataGridViewTextBoxColumn
            // 
            this.paymentclientidDataGridViewTextBoxColumn.DataPropertyName = "payment_client_id";
            this.paymentclientidDataGridViewTextBoxColumn.DataSource = this.clientsBindingSource;
            this.paymentclientidDataGridViewTextBoxColumn.DisplayMember = "client_name";
            this.paymentclientidDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.paymentclientidDataGridViewTextBoxColumn.HeaderText = "العميل";
            this.paymentclientidDataGridViewTextBoxColumn.Name = "paymentclientidDataGridViewTextBoxColumn";
            this.paymentclientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentclientidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentclientidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.paymentclientidDataGridViewTextBoxColumn.ValueMember = "client_id";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.MediatorDataSet;
            // 
            // paymentamountDataGridViewTextBoxColumn
            // 
            this.paymentamountDataGridViewTextBoxColumn.DataPropertyName = "payment_amount";
            this.paymentamountDataGridViewTextBoxColumn.HeaderText = "المبلغ";
            this.paymentamountDataGridViewTextBoxColumn.Name = "paymentamountDataGridViewTextBoxColumn";
            this.paymentamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            this.paymentdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentdetailsDataGridViewTextBoxColumn
            // 
            this.paymentdetailsDataGridViewTextBoxColumn.DataPropertyName = "payment_details";
            this.paymentdetailsDataGridViewTextBoxColumn.HeaderText = "التفاصيل";
            this.paymentdetailsDataGridViewTextBoxColumn.Name = "paymentdetailsDataGridViewTextBoxColumn";
            this.paymentdetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsPaymentsBindingSource
            // 
            this.clientsPaymentsBindingSource.DataMember = "Clients_Payments";
            this.clientsPaymentsBindingSource.DataSource = this.MediatorDataSet;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(12, 155);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(120, 35);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "حذف";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(264, 155);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 35);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "أضافة";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(138, 155);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(120, 35);
            this.edit_btn.TabIndex = 6;
            this.edit_btn.Text = "تعديل";
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_textBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_textBox.Location = new System.Drawing.Point(464, 156);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(362, 32);
            this.Search_textBox.TabIndex = 4;
            this.Search_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(832, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "بحث";
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Image = global::Mediator.Properties.Resources.back;
            this.BackBtn.Location = new System.Drawing.Point(396, 17);
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
            this.RefreshBtn.Location = new System.Drawing.Point(452, 17);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(50, 50);
            this.RefreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshBtn.TabIndex = 58;
            this.RefreshBtn.TabStop = false;
            this.RefreshBtn.Click += new System.EventHandler(this.refresh_Click);
            // 
            // clients_PaymentsTableAdapter
            // 
            this.clients_PaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // payment_detailsTextBox
            // 
            this.payment_detailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsPaymentsBindingSource, "payment_details", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_detailsTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_detailsTextBox.Location = new System.Drawing.Point(12, 117);
            this.payment_detailsTextBox.Name = "payment_detailsTextBox";
            this.payment_detailsTextBox.Size = new System.Drawing.Size(372, 32);
            this.payment_detailsTextBox.TabIndex = 3;
            // 
            // payment_dateDateTimePicker
            // 
            this.payment_dateDateTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.payment_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsPaymentsBindingSource, "payment_date", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_dateDateTimePicker.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.payment_dateDateTimePicker.Location = new System.Drawing.Point(12, 79);
            this.payment_dateDateTimePicker.Name = "payment_dateDateTimePicker";
            this.payment_dateDateTimePicker.Size = new System.Drawing.Size(372, 32);
            this.payment_dateDateTimePicker.TabIndex = 1;
            // 
            // payment_amountNumericUpDown
            // 
            this.payment_amountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payment_amountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsPaymentsBindingSource, "payment_amount", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_amountNumericUpDown.DecimalPlaces = 2;
            this.payment_amountNumericUpDown.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_amountNumericUpDown.Location = new System.Drawing.Point(464, 117);
            this.payment_amountNumericUpDown.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.payment_amountNumericUpDown.Name = "payment_amountNumericUpDown";
            this.payment_amountNumericUpDown.Size = new System.Drawing.Size(362, 32);
            this.payment_amountNumericUpDown.TabIndex = 2;
            // 
            // payment_client_idComboBox
            // 
            this.payment_client_idComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payment_client_idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientsPaymentsBindingSource, "payment_client_id", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.payment_client_idComboBox.DataSource = this.clientsBindingSource;
            this.payment_client_idComboBox.DisplayMember = "client_name";
            this.payment_client_idComboBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment_client_idComboBox.FormattingEnabled = true;
            this.payment_client_idComboBox.Location = new System.Drawing.Point(464, 79);
            this.payment_client_idComboBox.Name = "payment_client_idComboBox";
            this.payment_client_idComboBox.Size = new System.Drawing.Size(362, 32);
            this.payment_client_idComboBox.TabIndex = 0;
            this.payment_client_idComboBox.ValueMember = "client_id";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // clients_payments
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(payment_client_idLabel);
            this.Controls.Add(this.payment_client_idComboBox);
            this.Controls.Add(payment_amountLabel);
            this.Controls.Add(this.payment_amountNumericUpDown);
            this.Controls.Add(payment_dateLabel);
            this.Controls.Add(this.payment_dateDateTimePicker);
            this.Controls.Add(payment_detailsLabel);
            this.Controls.Add(this.payment_detailsTextBox);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.clientsViewDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "clients_payments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفعات العملاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.clients_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clients_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsPaymentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_amountNumericUpDown)).EndInit();
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
        private System.Windows.Forms.TextBox Search_textBox;
        private System.Windows.Forms.Label label2;
        private MediatorDataSet MediatorDataSet;
        private System.Windows.Forms.BindingSource clientsPaymentsBindingSource;
        private MediatorDataSetTableAdapters.Clients_PaymentsTableAdapter clients_PaymentsTableAdapter;
        private System.Windows.Forms.TextBox payment_detailsTextBox;
        private System.Windows.Forms.DateTimePicker payment_dateDateTimePicker;
        private System.Windows.Forms.NumericUpDown payment_amountNumericUpDown;
        private System.Windows.Forms.ComboBox payment_client_idComboBox;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private MediatorDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MediatorDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn paymentuseridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn paymentclientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdetailsDataGridViewTextBoxColumn;
    }
}

