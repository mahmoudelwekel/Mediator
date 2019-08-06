namespace Mediator
{
    partial class sitting
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.logoLabel = new System.Windows.Forms.Label();
            this.backup_pathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sittingsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.sittingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MediatorDataSet = new Mediator.MediatorDataSet();
            this.sittingsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.logoTextBox = new System.Windows.Forms.TextBox();
            this.backup_pathTextBox = new System.Windows.Forms.TextBox();
            this.chooselogoBtn = new System.Windows.Forms.Button();
            this.BackupBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sittingsTableAdapter = new Mediator.MediatorDataSetTableAdapters.sittingsTableAdapter();
            this.tableAdapterManager = new Mediator.MediatorDataSetTableAdapters.TableAdapterManager();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sittingsBindingNavigator)).BeginInit();
            this.sittingsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sittingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(787, 141);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(83, 26);
            this.nameLabel.TabIndex = 62;
            this.nameLabel.Text = "أسم المكان";
            // 
            // aboutLabel
            // 
            this.aboutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.Location = new System.Drawing.Point(787, 179);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(75, 26);
            this.aboutLabel.TabIndex = 64;
            this.aboutLabel.Text = "عن المكان";
            // 
            // logoLabel
            // 
            this.logoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(787, 217);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(87, 26);
            this.logoLabel.TabIndex = 66;
            this.logoLabel.Text = "شعار المكان";
            // 
            // backup_pathLabel
            // 
            this.backup_pathLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backup_pathLabel.AutoSize = true;
            this.backup_pathLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backup_pathLabel.Location = new System.Drawing.Point(787, 255);
            this.backup_pathLabel.Name = "backup_pathLabel";
            this.backup_pathLabel.Size = new System.Drawing.Size(112, 26);
            this.backup_pathLabel.TabIndex = 68;
            this.backup_pathLabel.Text = "النسخ الأحتياطى";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(510, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "الأعدادات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sittingsBindingNavigator
            // 
            this.sittingsBindingNavigator.AddNewItem = null;
            this.sittingsBindingNavigator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sittingsBindingNavigator.AutoSize = false;
            this.sittingsBindingNavigator.BindingSource = this.sittingsBindingSource;
            this.sittingsBindingNavigator.CountItem = null;
            this.sittingsBindingNavigator.DeleteItem = null;
            this.sittingsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.sittingsBindingNavigator.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.sittingsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sittingsBindingNavigatorSaveItem});
            this.sittingsBindingNavigator.Location = new System.Drawing.Point(9, 99);
            this.sittingsBindingNavigator.MoveFirstItem = null;
            this.sittingsBindingNavigator.MoveLastItem = null;
            this.sittingsBindingNavigator.MoveNextItem = null;
            this.sittingsBindingNavigator.MovePreviousItem = null;
            this.sittingsBindingNavigator.Name = "sittingsBindingNavigator";
            this.sittingsBindingNavigator.PositionItem = null;
            this.sittingsBindingNavigator.Size = new System.Drawing.Size(882, 36);
            this.sittingsBindingNavigator.TabIndex = 60;
            this.sittingsBindingNavigator.Text = "bindingNavigator1";
            // 
            // sittingsBindingSource
            // 
            this.sittingsBindingSource.DataMember = "sittings";
            this.sittingsBindingSource.DataSource = this.MediatorDataSet;
            // 
            // MediatorDataSet
            // 
            this.MediatorDataSet.DataSetName = "MediatorDataSet";
            this.MediatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sittingsBindingNavigatorSaveItem
            // 
            this.sittingsBindingNavigatorSaveItem.Name = "sittingsBindingNavigatorSaveItem";
            this.sittingsBindingNavigatorSaveItem.Size = new System.Drawing.Size(99, 33);
            this.sittingsBindingNavigatorSaveItem.Text = "حفظ التغيرات";
            this.sittingsBindingNavigatorSaveItem.Click += new System.EventHandler(this.sittingsBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sittingsBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(288, 17);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 28);
            this.idTextBox.TabIndex = 61;
            this.idTextBox.Visible = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sittingsBindingSource, "name", true));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(-58, 138);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(839, 32);
            this.nameTextBox.TabIndex = 63;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aboutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sittingsBindingSource, "about", true));
            this.aboutTextBox.Enabled = false;
            this.aboutTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextBox.Location = new System.Drawing.Point(-58, 176);
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(839, 32);
            this.aboutTextBox.TabIndex = 65;
            // 
            // logoTextBox
            // 
            this.logoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sittingsBindingSource, "logo", true));
            this.logoTextBox.Enabled = false;
            this.logoTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoTextBox.Location = new System.Drawing.Point(-58, 214);
            this.logoTextBox.Name = "logoTextBox";
            this.logoTextBox.Size = new System.Drawing.Size(751, 32);
            this.logoTextBox.TabIndex = 67;
            // 
            // backup_pathTextBox
            // 
            this.backup_pathTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backup_pathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sittingsBindingSource, "backup_path", true));
            this.backup_pathTextBox.Enabled = false;
            this.backup_pathTextBox.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backup_pathTextBox.Location = new System.Drawing.Point(-58, 252);
            this.backup_pathTextBox.Name = "backup_pathTextBox";
            this.backup_pathTextBox.Size = new System.Drawing.Size(751, 32);
            this.backup_pathTextBox.TabIndex = 69;
            // 
            // chooselogoBtn
            // 
            this.chooselogoBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooselogoBtn.Enabled = false;
            this.chooselogoBtn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooselogoBtn.Location = new System.Drawing.Point(699, 214);
            this.chooselogoBtn.Name = "chooselogoBtn";
            this.chooselogoBtn.Size = new System.Drawing.Size(82, 32);
            this.chooselogoBtn.TabIndex = 90;
            this.chooselogoBtn.Text = "أختر";
            this.chooselogoBtn.UseVisualStyleBackColor = true;
            this.chooselogoBtn.Click += new System.EventHandler(this.chooselogoBtn_Click);
            // 
            // BackupBtn
            // 
            this.BackupBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackupBtn.Enabled = false;
            this.BackupBtn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupBtn.Location = new System.Drawing.Point(699, 252);
            this.BackupBtn.Name = "BackupBtn";
            this.BackupBtn.Size = new System.Drawing.Size(82, 32);
            this.BackupBtn.TabIndex = 90;
            this.BackupBtn.Text = "أختر";
            this.BackupBtn.UseVisualStyleBackColor = true;
            this.BackupBtn.Click += new System.EventHandler(this.BackupBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sittingsTableAdapter
            // 
            this.sittingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BillsTableAdapter = null;
            this.tableAdapterManager.Clients_PaymentsTableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.DriversTableAdapter = null;
            this.tableAdapterManager.Factories_PaymentsTableAdapter = null;
            this.tableAdapterManager.FactoriesTableAdapter = null;
            this.tableAdapterManager.Products_TypesTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.sittingsTableAdapter = this.sittingsTableAdapter;
            this.tableAdapterManager.system_logTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Mediator.MediatorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.users_privilageTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Mediator.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(398, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Mediator.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(454, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // sitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 296);
            this.Controls.Add(this.BackupBtn);
            this.Controls.Add(this.chooselogoBtn);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.logoTextBox);
            this.Controls.Add(this.backup_pathLabel);
            this.Controls.Add(this.backup_pathTextBox);
            this.Controls.Add(this.sittingsBindingNavigator);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "sitting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الأعدادات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sitting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sitting_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sitting_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.sittingsBindingNavigator)).EndInit();
            this.sittingsBindingNavigator.ResumeLayout(false);
            this.sittingsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sittingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MediatorDataSet MediatorDataSet;
        private System.Windows.Forms.BindingSource sittingsBindingSource;
        private MediatorDataSetTableAdapters.sittingsTableAdapter sittingsTableAdapter;
        private System.Windows.Forms.BindingNavigator sittingsBindingNavigator;
        private System.Windows.Forms.ToolStripButton sittingsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.TextBox logoTextBox;
        private System.Windows.Forms.TextBox backup_pathTextBox;
        private System.Windows.Forms.Button chooselogoBtn;
        private System.Windows.Forms.Button BackupBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label backup_pathLabel;
        private MediatorDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

