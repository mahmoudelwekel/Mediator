namespace Mediator
{
    partial class clients
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
            System.Windows.Forms.Label client_nameLabel;
            System.Windows.Forms.Label client_profitLabel;
            System.Windows.Forms.Label client_phoneLabel;
            System.Windows.Forms.Label client_detailsLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.clientsViewDataGridView = new System.Windows.Forms.DataGridView();
            this.clientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientprofitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientdetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MediatorDataSet = new Mediator.MediatorDataSet();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.client_nameTextBox = new System.Windows.Forms.TextBox();
            this.client_profitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.client_phoneTextBox = new System.Windows.Forms.TextBox();
            this.client_detailsTextBox = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.RefreshBtn = new System.Windows.Forms.PictureBox();
            this.ClientsTableAdapter = new Mediator.MediatorDataSetTableAdapters.ClientsTableAdapter();
            client_nameLabel = new System.Windows.Forms.Label();
            client_profitLabel = new System.Windows.Forms.Label();
            client_phoneLabel = new System.Windows.Forms.Label();
            client_detailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_profitNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // client_nameLabel
            // 
            client_nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            client_nameLabel.AutoSize = true;
            client_nameLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            client_nameLabel.Location = new System.Drawing.Point(832, 85);
            client_nameLabel.Name = "client_nameLabel";
            client_nameLabel.Size = new System.Drawing.Size(47, 26);
            client_nameLabel.TabIndex = 10;
            client_nameLabel.Text = "الأسم";
            // 
            // client_profitLabel
            // 
            client_profitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            client_profitLabel.AutoSize = true;
            client_profitLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            client_profitLabel.Location = new System.Drawing.Point(832, 123);
            client_profitLabel.Name = "client_profitLabel";
            client_profitLabel.Size = new System.Drawing.Size(56, 26);
            client_profitLabel.TabIndex = 9;
            client_profitLabel.Text = "الفوائد";
            // 
            // client_phoneLabel
            // 
            client_phoneLabel.AutoSize = true;
            client_phoneLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            client_phoneLabel.Location = new System.Drawing.Point(390, 85);
            client_phoneLabel.Name = "client_phoneLabel";
            client_phoneLabel.Size = new System.Drawing.Size(57, 26);
            client_phoneLabel.TabIndex = 12;
            client_phoneLabel.Text = "الهاتف";
            // 
            // client_detailsLabel
            // 
            client_detailsLabel.AutoSize = true;
            client_detailsLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            client_detailsLabel.Location = new System.Drawing.Point(390, 123);
            client_detailsLabel.Name = "client_detailsLabel";
            client_detailsLabel.Size = new System.Drawing.Size(68, 26);
            client_detailsLabel.TabIndex = 11;
            client_detailsLabel.Text = "التفاصيل";
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
            this.label1.TabIndex = 14;
            this.label1.Text = "العملاء";
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
            this.clientidDataGridViewTextBoxColumn,
            this.clientnameDataGridViewTextBoxColumn,
            this.clientprofitDataGridViewTextBoxColumn,
            this.clientphoneDataGridViewTextBoxColumn,
            this.clientdetailsDataGridViewTextBoxColumn});
            this.clientsViewDataGridView.DataSource = this.clientsBindingSource;
            this.clientsViewDataGridView.Location = new System.Drawing.Point(12, 199);
            this.clientsViewDataGridView.MultiSelect = false;
            this.clientsViewDataGridView.Name = "clientsViewDataGridView";
            this.clientsViewDataGridView.ReadOnly = true;
            this.clientsViewDataGridView.RowHeadersVisible = false;
            this.clientsViewDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsViewDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.clientsViewDataGridView.RowTemplate.Height = 30;
            this.clientsViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsViewDataGridView.Size = new System.Drawing.Size(871, 289);
            this.clientsViewDataGridView.TabIndex = 13;
            // 
            // clientidDataGridViewTextBoxColumn
            // 
            this.clientidDataGridViewTextBoxColumn.DataPropertyName = "client_id";
            this.clientidDataGridViewTextBoxColumn.HeaderText = "client_id";
            this.clientidDataGridViewTextBoxColumn.Name = "clientidDataGridViewTextBoxColumn";
            this.clientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientidDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientnameDataGridViewTextBoxColumn
            // 
            this.clientnameDataGridViewTextBoxColumn.DataPropertyName = "client_name";
            this.clientnameDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.clientnameDataGridViewTextBoxColumn.Name = "clientnameDataGridViewTextBoxColumn";
            this.clientnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientprofitDataGridViewTextBoxColumn
            // 
            this.clientprofitDataGridViewTextBoxColumn.DataPropertyName = "client_profit";
            this.clientprofitDataGridViewTextBoxColumn.HeaderText = "الفوائد";
            this.clientprofitDataGridViewTextBoxColumn.Name = "clientprofitDataGridViewTextBoxColumn";
            this.clientprofitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientphoneDataGridViewTextBoxColumn
            // 
            this.clientphoneDataGridViewTextBoxColumn.DataPropertyName = "client_phone";
            this.clientphoneDataGridViewTextBoxColumn.HeaderText = "الهاتف";
            this.clientphoneDataGridViewTextBoxColumn.Name = "clientphoneDataGridViewTextBoxColumn";
            this.clientphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientdetailsDataGridViewTextBoxColumn
            // 
            this.clientdetailsDataGridViewTextBoxColumn.DataPropertyName = "client_details";
            this.clientdetailsDataGridViewTextBoxColumn.HeaderText = "التفاصيل";
            this.clientdetailsDataGridViewTextBoxColumn.Name = "clientdetailsDataGridViewTextBoxColumn";
            this.clientdetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.MediatorDataSet;
            // 
            // MediatorDataSet
            // 
            this.MediatorDataSet.DataSetName = "MediatorDataSet";
            this.MediatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(12, 158);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(120, 35);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "حذف";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(264, 158);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 35);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "أضافة";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(138, 158);
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
            this.Search_textBox.Location = new System.Drawing.Point(464, 159);
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
            this.label2.Location = new System.Drawing.Point(832, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "بحث";
            // 
            // client_nameTextBox
            // 
            this.client_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.client_nameTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_nameTextBox.Location = new System.Drawing.Point(464, 82);
            this.client_nameTextBox.Name = "client_nameTextBox";
            this.client_nameTextBox.Size = new System.Drawing.Size(362, 32);
            this.client_nameTextBox.TabIndex = 0;
            // 
            // client_profitNumericUpDown
            // 
            this.client_profitNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_profitNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "client_profit", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.client_profitNumericUpDown.DecimalPlaces = 2;
            this.client_profitNumericUpDown.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_profitNumericUpDown.Location = new System.Drawing.Point(464, 120);
            this.client_profitNumericUpDown.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.client_profitNumericUpDown.Name = "client_profitNumericUpDown";
            this.client_profitNumericUpDown.Size = new System.Drawing.Size(362, 32);
            this.client_profitNumericUpDown.TabIndex = 2;
            // 
            // client_phoneTextBox
            // 
            this.client_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_phone", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.client_phoneTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_phoneTextBox.Location = new System.Drawing.Point(12, 82);
            this.client_phoneTextBox.Name = "client_phoneTextBox";
            this.client_phoneTextBox.Size = new System.Drawing.Size(372, 32);
            this.client_phoneTextBox.TabIndex = 1;
            // 
            // client_detailsTextBox
            // 
            this.client_detailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "client_details", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.client_detailsTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client_detailsTextBox.Location = new System.Drawing.Point(12, 120);
            this.client_detailsTextBox.Name = "client_detailsTextBox";
            this.client_detailsTextBox.Size = new System.Drawing.Size(372, 32);
            this.client_detailsTextBox.TabIndex = 3;
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
            // ClientsTableAdapter
            // 
            this.ClientsTableAdapter.ClearBeforeFill = true;
            // 
            // clients
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(client_nameLabel);
            this.Controls.Add(this.client_nameTextBox);
            this.Controls.Add(client_profitLabel);
            this.Controls.Add(this.client_profitNumericUpDown);
            this.Controls.Add(client_phoneLabel);
            this.Controls.Add(this.client_phoneTextBox);
            this.Controls.Add(client_detailsLabel);
            this.Controls.Add(this.client_detailsTextBox);
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
            this.Name = "clients";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.clients_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clients_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_profitNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).EndInit();
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
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private MediatorDataSetTableAdapters.ClientsTableAdapter ClientsTableAdapter;
        private System.Windows.Forms.TextBox client_nameTextBox;
        private System.Windows.Forms.NumericUpDown client_profitNumericUpDown;
        private System.Windows.Forms.TextBox client_phoneTextBox;
        private System.Windows.Forms.TextBox client_detailsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientprofitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientdetailsDataGridViewTextBoxColumn;
    }
}

