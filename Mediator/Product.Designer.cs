﻿namespace Mediator
{
    partial class Product
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
            System.Windows.Forms.Label product_nameLabel;
            System.Windows.Forms.Label product_detailsLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.clientsViewDataGridView = new System.Windows.Forms.DataGridView();
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productdetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MediatorDataSet = new Mediator.MediatorDataSet();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.RefreshBtn = new System.Windows.Forms.PictureBox();
            this.product_nameTextBox = new System.Windows.Forms.TextBox();
            this.product_detailsTextBox = new System.Windows.Forms.TextBox();
            this.productsTableAdapter = new Mediator.MediatorDataSetTableAdapters.ProductsTableAdapter();
            product_nameLabel = new System.Windows.Forms.Label();
            product_detailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // product_nameLabel
            // 
            product_nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            product_nameLabel.AutoSize = true;
            product_nameLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_nameLabel.Location = new System.Drawing.Point(832, 83);
            product_nameLabel.Name = "product_nameLabel";
            product_nameLabel.Size = new System.Drawing.Size(47, 26);
            product_nameLabel.TabIndex = 8;
            product_nameLabel.Text = "الأسم";
            // 
            // product_detailsLabel
            // 
            product_detailsLabel.AutoSize = true;
            product_detailsLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_detailsLabel.Location = new System.Drawing.Point(390, 83);
            product_detailsLabel.Name = "product_detailsLabel";
            product_detailsLabel.Size = new System.Drawing.Size(68, 26);
            product_detailsLabel.TabIndex = 10;
            product_detailsLabel.Text = "التفاصيل";
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
            this.label1.Text = "المنتجات";
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
            this.productidDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.productdetailsDataGridViewTextBoxColumn});
            this.clientsViewDataGridView.DataSource = this.productsBindingSource;
            this.clientsViewDataGridView.Location = new System.Drawing.Point(12, 159);
            this.clientsViewDataGridView.MultiSelect = false;
            this.clientsViewDataGridView.Name = "clientsViewDataGridView";
            this.clientsViewDataGridView.ReadOnly = true;
            this.clientsViewDataGridView.RowHeadersVisible = false;
            this.clientsViewDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsViewDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LimeGreen;
            this.clientsViewDataGridView.RowTemplate.Height = 30;
            this.clientsViewDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsViewDataGridView.Size = new System.Drawing.Size(871, 329);
            this.clientsViewDataGridView.TabIndex = 6;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.ReadOnly = true;
            this.productidDataGridViewTextBoxColumn.Visible = false;
            // 
            // productnameDataGridViewTextBoxColumn
            // 
            this.productnameDataGridViewTextBoxColumn.DataPropertyName = "product_name";
            this.productnameDataGridViewTextBoxColumn.HeaderText = "الأسم";
            this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
            this.productnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productdetailsDataGridViewTextBoxColumn
            // 
            this.productdetailsDataGridViewTextBoxColumn.DataPropertyName = "product_details";
            this.productdetailsDataGridViewTextBoxColumn.HeaderText = "التفاصيل";
            this.productdetailsDataGridViewTextBoxColumn.Name = "productdetailsDataGridViewTextBoxColumn";
            this.productdetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.MediatorDataSet;
            // 
            // MediatorDataSet
            // 
            this.MediatorDataSet.DataSetName = "MediatorDataSet";
            this.MediatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(12, 118);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(120, 35);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "حذف";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(264, 118);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(120, 35);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "أضافة";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_btn.Location = new System.Drawing.Point(138, 118);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(120, 35);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.Text = "تعديل";
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_textBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_textBox.Location = new System.Drawing.Point(464, 118);
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(362, 32);
            this.Search_textBox.TabIndex = 5;
            this.Search_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(832, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 26);
            this.label2.TabIndex = 7;
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
            // product_nameTextBox
            // 
            this.product_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.product_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.product_nameTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_nameTextBox.Location = new System.Drawing.Point(464, 80);
            this.product_nameTextBox.Name = "product_nameTextBox";
            this.product_nameTextBox.Size = new System.Drawing.Size(362, 32);
            this.product_nameTextBox.TabIndex = 0;
            // 
            // product_detailsTextBox
            // 
            this.product_detailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "product_details", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.product_detailsTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_detailsTextBox.Location = new System.Drawing.Point(12, 80);
            this.product_detailsTextBox.Name = "product_detailsTextBox";
            this.product_detailsTextBox.Size = new System.Drawing.Size(372, 32);
            this.product_detailsTextBox.TabIndex = 1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // Product
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(product_nameLabel);
            this.Controls.Add(this.product_nameTextBox);
            this.Controls.Add(product_detailsLabel);
            this.Controls.Add(this.product_detailsTextBox);
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
            this.Name = "Product";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المنتجات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.clients_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clients_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.clientsViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).EndInit();
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
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MediatorDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productdetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox product_nameTextBox;
        private System.Windows.Forms.TextBox product_detailsTextBox;
    }
}

