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
    public partial class cleardatabase : Form
    {
        public cleardatabase()
        {
            InitializeComponent();
        }
        
        private void sitting_Load(object sender, EventArgs e)
        {
            LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");

            var items = new[] {
                new { Text = "الفواتير", Value = "Bills" },
                new { Text = "العملاء", Value = "Clients" },
                new { Text = "الدفعات المالية للعملاء", Value = "Clients_Payments" },
                new { Text = "المصانع", Value = "Factories" },
                new { Text = "الدفعات المالية للمصانع", Value = "Factories_Payments" },
                new { Text = "السائقين", Value = "Drivers" },
                new { Text = "المنتجات", Value = "Products" },
                new { Text = "أنواع المنتجات", Value = "Products_Types" },
                new { Text = "السجل", Value = "system_log" },
                new { Text = "المستخدمين", Value = "users" }
            };
            PaymentClientList.DataSource = null;
            PaymentClientList.DataSource = items;
            PaymentClientList.DisplayMember = "Text";
            PaymentClientList.ValueMember = "Value";
        }
        

        private void clearall_btn_Click(object sender, EventArgs e)
        {
            try
            {
                

                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");

                SqlConnection cn = new SqlConnection(Properties.Settings.Default.MediatorConnectionString);

                SqlCommand DeleteQuery = new SqlCommand("delete from "+ PaymentClientList.SelectedValue + "; DBCC CHECKIDENT ('" + PaymentClientList.SelectedValue + "', RESEED, 0);", cn);
                
                cn.Open();


                DeleteQuery.ExecuteNonQuery();

                cn.Close();

                MessageBox.Show("تم تصفية السجل الخالص ب"+ PaymentClientList.Text + " بنجاح", "تصفية قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
                MessageBox.Show("حدث خطأ", "حدث خطأ فى تصفية قاعدة البيانات حاول مرة أخرى", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



       


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                this.Hide();/*this.Dispose();*/
                //login ob = new login();
                //ob.Show();
            }
            catch (Exception )
            {
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
    }
}

