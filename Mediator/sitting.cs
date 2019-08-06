using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Mediator
{
    public partial class sitting : Form
    {
        public sitting()
        {
            InitializeComponent();
        }

        private void sittingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                this.Validate();
                this.sittingsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.MediatorDataSet);

                MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void sitting_Load(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                // TODO: This line of code loads data into the 'MediatorDataSet.sittings' table. You can move, or remove it, as needed.
                this.sittingsTableAdapter.Fill(this.MediatorDataSet.sittings);
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void chooselogoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Images Files|*.JPG;*.JPEG;*.JPE;*.GIF;*.PNG";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    logoTextBox.Text = "file:" + openFileDialog1.FileName;
                }
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    backup_pathTextBox.Text = folderBrowserDialog1.SelectedPath + "\\Mediator-Database-Backup.BAK";
                }
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                // TODO: This line of code loads data into the 'MediatorDataSet.sittings' table. You can move, or remove it, as needed.
                this.sittingsTableAdapter.Fill(this.MediatorDataSet.sittings);
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                home home = new home();
                home.Show();
                this.Hide(); /*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void sitting_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (e.Clicks == 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Maximized;
                    }
                }

                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void sitting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Shift && e.KeyCode == Keys.Home)
            {
                if (nameTextBox.Enabled == true)
                {
                    nameTextBox.Enabled = false;
                    aboutTextBox.Enabled = false;
                    chooselogoBtn.Enabled = false;
                    BackupBtn.Enabled = false;
                }
                else
                {
                    nameTextBox.Enabled = true;
                    aboutTextBox.Enabled = true;
                    chooselogoBtn.Enabled = true;
                    BackupBtn.Enabled = true;
                }
            }
            if (e.Alt && e.Shift && e.KeyCode == Keys.End)
            {
                cleardatabase home = new cleardatabase();
                home.ShowDialog();
            }

        }


    }
}
