namespace Mediator
{
    partial class cleardatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cleardatabase));
            this.label1 = new System.Windows.Forms.Label();
            this.clearall_btn = new System.Windows.Forms.Button();
            this.PaymentClientList = new System.Windows.Forms.ComboBox();
            this.adressLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LimeGreen;
            this.label1.Font = new System.Drawing.Font("Cairo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 56);
            this.label1.TabIndex = 136;
            this.label1.Text = "تصفية قاعدة البيانات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearall_btn
            // 
            this.clearall_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearall_btn.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearall_btn.Location = new System.Drawing.Point(20, 127);
            this.clearall_btn.Name = "clearall_btn";
            this.clearall_btn.Size = new System.Drawing.Size(414, 41);
            this.clearall_btn.TabIndex = 12;
            this.clearall_btn.Text = "تصفية";
            this.clearall_btn.Click += new System.EventHandler(this.clearall_btn_Click);
            // 
            // PaymentClientList
            // 
            this.PaymentClientList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaymentClientList.DisplayMember = "client_name";
            this.PaymentClientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentClientList.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentClientList.FormattingEnabled = true;
            this.PaymentClientList.Location = new System.Drawing.Point(141, 89);
            this.PaymentClientList.Name = "PaymentClientList";
            this.PaymentClientList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PaymentClientList.Size = new System.Drawing.Size(293, 32);
            this.PaymentClientList.TabIndex = 8672;
            this.PaymentClientList.ValueMember = "client_id";
            // 
            // adressLabel
            // 
            this.adressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adressLabel.Location = new System.Drawing.Point(23, 92);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(112, 26);
            this.adressLabel.TabIndex = 8673;
            this.adressLabel.Text = "أختر أسم الجدول";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Mediator.Properties.Resources.close_green;
            this.pictureBox3.Location = new System.Drawing.Point(401, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8671;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // cleardatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 177);
            this.ControlBox = false;
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.PaymentClientList);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.clearall_btn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cairo", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cleardatabase";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تصفية قاعدة البيانات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.sitting_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cleardatabase_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button clearall_btn;
        private System.Windows.Forms.ComboBox PaymentClientList;
        private System.Windows.Forms.Label adressLabel;
    }
}