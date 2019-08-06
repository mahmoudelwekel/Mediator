using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mediator
{
    public partial class license : Form
    {
        public license()
        {
            InitializeComponent();
        }
        
        private void sitting_Load(object sender, EventArgs e)
        {
            try
            {
                

                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                macTxt.Text = new Encrypt().GenerateEncryptionKey();

            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }
        

        private void clearall_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ActivationKey.Text) && !string.IsNullOrWhiteSpace(ActivationKey.Text))
                {

                    CheckActivation.ActivateProducts(ActivationKey.Text);

                    if (CheckActivation.IsActivated())
                    {
                        MessageBox.Show("تم تفعيل البرنامج بنجاح", "تفعيل البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login login = new login();
                        login.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("أدخل كود التفعيل أولاً");
                }

            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
                MessageBox.Show("حدث خطأ فى تفعيل البرنامج حاول مرة أخرى", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



       


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[أغلاق النظام]");
                Application.Exit();
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
                MessageBox.Show("حدث خطأ", "حدث خطأ فى تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cleardatabase_MouseDown(object sender, MouseEventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.facebook.com/UPTOP.EG");
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckActivation.IsExists())
                {

                    Encrypt Encrypt = new Encrypt();

                    DateTime week = DateTime.Now.AddDays(10);

                    string trailcode = Encrypt.Encryption(week.ToString(), Encrypt.GenerateEncryptionKey());

                    CheckActivation.ActivateProducts(trailcode);

                    if (CheckActivation.IsActivated())
                    {
                        MessageBox.Show("تم تفعيل النسخة التجريبية للبرنامج لمدة 10 أيام", "تفعيل البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login login = new login();
                        login.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("تم إنتهاء صلاحية النسخة التجريبية", "تفعيل البرنامج", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
                MessageBox.Show("حدث خطأ فى تفعيل البرنامج حاول مرة أخرى", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

