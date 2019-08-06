namespace Mediator
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.daydatelbl = new System.Windows.Forms.Label();
            this.usersprivilageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MediatorDataSet = new Mediator.MediatorDataSet();
            this.users_privilegesTableAdapter = new Mediator.MediatorDataSetTableAdapters.users_privilageTableAdapter();
            this.users = new System.Windows.Forms.Button();
            this.clients_payments = new System.Windows.Forms.Button();
            this.clients = new System.Windows.Forms.Button();
            this.products_types = new System.Windows.Forms.Button();
            this.statistics = new System.Windows.Forms.Button();
            this.bills = new System.Windows.Forms.Button();
            this.factories_payments = new System.Windows.Forms.Button();
            this.factories = new System.Windows.Forms.Button();
            this.drivers = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.sittings = new System.Windows.Forms.Button();
            this.notificationBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usersprivilegesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usersprivilageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivilegesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(728, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = "لوحة التحكم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // daydatelbl
            // 
            this.daydatelbl.AutoSize = true;
            this.daydatelbl.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daydatelbl.Location = new System.Drawing.Point(240, 37);
            this.daydatelbl.Name = "daydatelbl";
            this.daydatelbl.Size = new System.Drawing.Size(0, 26);
            this.daydatelbl.TabIndex = 11;
            // 
            // usersprivilageBindingSource
            // 
            this.usersprivilageBindingSource.DataMember = "users_privilage";
            this.usersprivilageBindingSource.DataSource = this.MediatorDataSet;
            // 
            // MediatorDataSet
            // 
            this.MediatorDataSet.DataSetName = "MediatorDataSet";
            this.MediatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // users_privilegesTableAdapter
            // 
            this.users_privilegesTableAdapter.ClearBeforeFill = true;
            // 
            // users
            // 
            this.users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.users.BackgroundImage = global::Mediator.Properties.Resources.المستخدمين;
            this.users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.users.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "users", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.users.Enabled = false;
            this.users.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.Location = new System.Drawing.Point(515, 285);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(156, 196);
            this.users.TabIndex = 6;
            this.users.Text = "المستخدمين";
            this.users.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click_1);
            // 
            // clients_payments
            // 
            this.clients_payments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clients_payments.BackgroundImage = global::Mediator.Properties.Resources.payment_type;
            this.clients_payments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clients_payments.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "clients_payments", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.clients_payments.Enabled = false;
            this.clients_payments.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clients_payments.Location = new System.Drawing.Point(298, 301);
            this.clients_payments.Name = "clients_payments";
            this.clients_payments.Size = new System.Drawing.Size(187, 160);
            this.clients_payments.TabIndex = 2;
            this.clients_payments.Text = "دفعات العملاء";
            this.clients_payments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clients_payments.UseVisualStyleBackColor = true;
            this.clients_payments.Click += new System.EventHandler(this.clients_payments_Click);
            // 
            // clients
            // 
            this.clients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clients.BackgroundImage = global::Mediator.Properties.Resources.العملاء;
            this.clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clients.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "clients", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.clients.Enabled = false;
            this.clients.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clients.Location = new System.Drawing.Point(298, 137);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(187, 158);
            this.clients.TabIndex = 1;
            this.clients.Text = "العملاء";
            this.clients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.clients.UseVisualStyleBackColor = true;
            this.clients.Click += new System.EventHandler(this.clients_Click_1);
            // 
            // products_types
            // 
            this.products_types.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.products_types.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("products_types.BackgroundImage")));
            this.products_types.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.products_types.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "products_types", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.products_types.Enabled = false;
            this.products_types.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_types.Location = new System.Drawing.Point(515, 487);
            this.products_types.Name = "products_types";
            this.products_types.Size = new System.Drawing.Size(220, 159);
            this.products_types.TabIndex = 9;
            this.products_types.Text = "أنواع المنتجات";
            this.products_types.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.products_types.UseVisualStyleBackColor = true;
            this.products_types.Click += new System.EventHandler(this.products_types_Click);
            // 
            // statistics
            // 
            this.statistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.statistics.BackgroundImage = global::Mediator.Properties.Resources.التقارير;
            this.statistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.statistics.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "statistics", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.statistics.Enabled = false;
            this.statistics.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics.Location = new System.Drawing.Point(515, 137);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(473, 142);
            this.statistics.TabIndex = 5;
            this.statistics.Text = "الأحصائيات";
            this.statistics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.statistics.UseVisualStyleBackColor = true;
            this.statistics.Click += new System.EventHandler(this.statistics_Click_1);
            // 
            // bills
            // 
            this.bills.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bills.BackgroundImage = global::Mediator.Properties.Resources._02__2_;
            this.bills.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bills.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "bills", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.bills.Enabled = false;
            this.bills.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bills.Location = new System.Drawing.Point(12, 137);
            this.bills.Name = "bills";
            this.bills.Size = new System.Drawing.Size(280, 324);
            this.bills.TabIndex = 0;
            this.bills.Text = "الفواتير";
            this.bills.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bills.UseVisualStyleBackColor = true;
            this.bills.Click += new System.EventHandler(this.bills_Click);
            // 
            // factories_payments
            // 
            this.factories_payments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factories_payments.BackgroundImage = global::Mediator.Properties.Resources.payment;
            this.factories_payments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.factories_payments.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "factories_payments", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.factories_payments.Enabled = false;
            this.factories_payments.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factories_payments.Location = new System.Drawing.Point(12, 467);
            this.factories_payments.Name = "factories_payments";
            this.factories_payments.Size = new System.Drawing.Size(211, 179);
            this.factories_payments.TabIndex = 3;
            this.factories_payments.Text = "دفعات المصانع";
            this.factories_payments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.factories_payments.UseVisualStyleBackColor = true;
            this.factories_payments.Click += new System.EventHandler(this.factories_payments_Click);
            // 
            // factories
            // 
            this.factories.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.factories.BackgroundImage = global::Mediator.Properties.Resources.projects;
            this.factories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.factories.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "factories", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.factories.Enabled = false;
            this.factories.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factories.Location = new System.Drawing.Point(229, 467);
            this.factories.Name = "factories";
            this.factories.Size = new System.Drawing.Size(256, 179);
            this.factories.TabIndex = 4;
            this.factories.Text = "المصانع";
            this.factories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.factories.UseVisualStyleBackColor = true;
            this.factories.Click += new System.EventHandler(this.factories_Click);
            // 
            // drivers
            // 
            this.drivers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drivers.BackgroundImage = global::Mediator.Properties.Resources.drivers;
            this.drivers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.drivers.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "drivers", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.drivers.Enabled = false;
            this.drivers.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivers.Location = new System.Drawing.Point(677, 285);
            this.drivers.Name = "drivers";
            this.drivers.Size = new System.Drawing.Size(146, 196);
            this.drivers.TabIndex = 7;
            this.drivers.Text = "السائقين";
            this.drivers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.drivers.UseVisualStyleBackColor = true;
            this.drivers.Click += new System.EventHandler(this.drivers_Click);
            // 
            // products
            // 
            this.products.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.products.BackgroundImage = global::Mediator.Properties.Resources._08;
            this.products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.products.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "products", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.products.Enabled = false;
            this.products.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.Location = new System.Drawing.Point(741, 487);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(247, 159);
            this.products.TabIndex = 10;
            this.products.Text = "المنتجات";
            this.products.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.products.UseVisualStyleBackColor = true;
            this.products.Click += new System.EventHandler(this.products_Click);
            // 
            // sittings
            // 
            this.sittings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sittings.BackgroundImage = global::Mediator.Properties.Resources._12;
            this.sittings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sittings.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.usersprivilageBindingSource, "sittings", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.sittings.Enabled = false;
            this.sittings.Font = new System.Drawing.Font("Cairo", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sittings.Location = new System.Drawing.Point(829, 285);
            this.sittings.Name = "sittings";
            this.sittings.Size = new System.Drawing.Size(159, 196);
            this.sittings.TabIndex = 8;
            this.sittings.Text = "الأعدادات";
            this.sittings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sittings.UseVisualStyleBackColor = true;
            this.sittings.Click += new System.EventHandler(this.sittings_Click_1);
            // 
            // notificationBtn
            // 
            this.notificationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationBtn.Enabled = false;
            this.notificationBtn.Image = global::Mediator.Properties.Resources._13;
            this.notificationBtn.Location = new System.Drawing.Point(164, 12);
            this.notificationBtn.Name = "notificationBtn";
            this.notificationBtn.Size = new System.Drawing.Size(70, 77);
            this.notificationBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notificationBtn.TabIndex = 64;
            this.notificationBtn.TabStop = false;
            this.notificationBtn.Visible = false;
            this.notificationBtn.Click += new System.EventHandler(this.notificationBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(0, 0);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Mediator.Properties.Resources.بيانات_الشركة;
            this.pictureBox2.Location = new System.Drawing.Point(88, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.info_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Mediator.Properties.Resources._19;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.logout_Click);
            // 
            // usersprivilegesBindingSource
            // 
            this.usersprivilegesBindingSource.DataMember = "users_privilage";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 658);
            this.Controls.Add(this.drivers);
            this.Controls.Add(this.factories);
            this.Controls.Add(this.factories_payments);
            this.Controls.Add(this.products);
            this.Controls.Add(this.products_types);
            this.Controls.Add(this.sittings);
            this.Controls.Add(this.bills);
            this.Controls.Add(this.clients);
            this.Controls.Add(this.statistics);
            this.Controls.Add(this.clients_payments);
            this.Controls.Add(this.users);
            this.Controls.Add(this.daydatelbl);
            this.Controls.Add(this.notificationBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة التحكم";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.home_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.home_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.usersprivilageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersprivilegesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox notificationBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label daydatelbl;
        private System.Windows.Forms.BindingSource usersprivilegesBindingSource;
        private MediatorDataSet MediatorDataSet;
        private MediatorDataSetTableAdapters.users_privilageTableAdapter users_privilegesTableAdapter;
        private System.Windows.Forms.BindingSource usersprivilageBindingSource;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Button clients_payments;
        private System.Windows.Forms.Button clients;
        private System.Windows.Forms.Button products_types;
        private System.Windows.Forms.Button sittings;
        private System.Windows.Forms.Button statistics;
        private System.Windows.Forms.Button bills;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button factories_payments;
        private System.Windows.Forms.Button factories;
        private System.Windows.Forms.Button drivers;
    }
}

