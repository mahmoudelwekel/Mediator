using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    public partial class login : Form
    {


        public login()
        {

            InitializeComponent();


            this.BringToFront();
            this.Activate();
            this.ActiveControl = usernametxt;

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                DataTable user = this.usersTableAdapter.GetCheckLogin(usernametxt.Text, passwordtxt.Text);

                if (user.Rows.Count == 1)
                {

                    LoginInfo.id = user.Rows[0]["user_id"].ToString();
                    LoginInfo.name = user.Rows[0]["user_name"].ToString();
                    LoginInfo.username = user.Rows[0]["user_username"].ToString();
                    LoginInfo.printer = user.Rows[0]["user_printer"].ToString();

                    //if (user.Rows[0]["user_current_date"].ToString() == null || user.Rows[0]["user_current_date"].ToString() == "")
                    //{
                    //    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    //    this.usersTableAdapter.UpdateUser_Current_Date(date, int.Parse(user.Rows[0]["user_id_pk"].ToString()));
                    //    LoginInfo.currentdate = date;
                    //}
                    //else
                    //{
                    //    LoginInfo.currentdate = DateTime.Parse(user.Rows[0]["user_current_date"].ToString()).ToString("yyyy-MM-dd");
                    //}

                    LoginInfo.log("[تم تسجيل الدخول بنجاح]" + LoginInfo.id);

                    //c.log("تسجيل دخول");

                    home home = new home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("بيانات الدخول غير صحيحة حاول مرة اخرى", "تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
                MessageBox.Show( "حدث خطأ فى تسجيل الدخول" + Environment.NewLine + Properties.Settings.Default.MediatorConnectionString + Environment.NewLine+ errortext.Message, "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
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

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
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

        private void login_Load(object sender, EventArgs e)
        {


            //Encrypt Encrypt = new Encrypt();


            ////string EncryptionKey = ;
            ////MessageBox.Show(EncryptionKey);

            //string Encrypted = Encrypt.Encryption("4-7-2019", Encrypt.GenerateEncryptionKey());
            //usernametxt.Text = Encrypted;
            //MessageBox.Show(Encrypted);
            //MessageBox.Show(Encrypted.Length.ToString());


            //string Decrypted = Encrypt.Decryption(Encrypted, Encrypt.GenerateEncryptionKey());
            //MessageBox.Show(Decrypted);



        }
    }
}
