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
    public partial class home : Form
    {
        public home()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");

                this.users_privilegesTableAdapter.FillBy(this.MediatorDataSet.users_privilage, int.Parse(LoginInfo.id));

                daydatelbl.Text =  DateTime.Now.ToString();


                BackgroundWorker gBgwDownload = new BackgroundWorker(); /* added this line will fix problem */
                gBgwDownload.DoWork += (object ss, DoWorkEventArgs ee) =>
                {
                    LoginInfo.Backup_database();
                };
                gBgwDownload.RunWorkerAsync();
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void fillmenue()
        {
            try
            {
                //contextMenuStrip1.Items.Clear();



                //foreach (DataRow content in this.projectsViewTableAdapter.GetFilter(null, null, null, null, null, null, null))
                //{
                //    var Products = new System.Windows.Forms.ToolStripMenuItem()
                //    {
                //        Name = content[0].ToString(),
                //        Text = content[1].ToString()
                //    };
                //    decimal project_amount = decimal.Parse(content[2].ToString());
                //    decimal income = decimal.Parse(content[3].ToString());
                //    decimal outcome = decimal.Parse(content[5].ToString());


                //    var item2 = new System.Windows.Forms.ToolStripMenuItem()
                //    {
                //        Text = "نسبة الواردات من تكلفة المشروع : " + String.Format("{0:0.00}",((income / project_amount) * 100) ) + "%"
                //    };
                //    Products.DropDownItems.Add(item2);
                //    var s1 = new System.Windows.Forms.ToolStripSeparator();
                //    Products.DropDownItems.Add(s1);

                //    var item3 = new System.Windows.Forms.ToolStripMenuItem()
                //    {
                //        Text = "نسبة المصروفات من تكلفة المشروع : " + String.Format("{0:0.00}", ((outcome / project_amount) * 100)) + "%"
                //    };
                //    Products.DropDownItems.Add(item3);
                //    var s2 = new System.Windows.Forms.ToolStripSeparator();
                //    Products.DropDownItems.Add(s2);


                //    var item4 = new System.Windows.Forms.ToolStripMenuItem()
                //    {
                //        Text = "نسبة المصروفات من الواردات : " + String.Format("{0:0.00}", ((outcome / income) * 100)) + "%"
                //    };
                //    Products.DropDownItems.Add(item4);
                //    var s3 = new System.Windows.Forms.ToolStripSeparator();
                //    Products.DropDownItems.Add(s3);
                //    Products.RightToLeft = RightToLeft.Yes;

                //    contextMenuStrip1.Items.Add(Products);
                //    var s4 = new System.Windows.Forms.ToolStripSeparator();
                //    contextMenuStrip1.Items.Add(s4);


                //}
                
            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.ToString());
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }


        }

        private void notificationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                fillmenue();
                contextMenuStrip1.Show(notificationBtn.Location.X, notificationBtn.Location.Y+77);
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                if (pictureBox3.Width == 0)
                {
                    pictureBox3.Width = this.Width;
                    pictureBox3.Height = this.Height - 110;
                }
                else
                {
                    pictureBox3.Width = 0;
                    pictureBox3.Height = 0;
                }
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                login ll = new login();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }
        

    

















        private void home_MouseDown(object sender, MouseEventArgs e)
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

        private void salesbill_MouseHover(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = System.Drawing.SystemColors.ControlLightLight;
        }

        private void salesbill_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).BackColor = System.Drawing.SystemColors.ButtonFace;
        }



        private void drivers_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                Drivers ll = new Drivers();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }

        }

        private void factories_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                Factories ll = new Factories();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }

        }

        private void sittings_Click_1(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                sitting ll = new sitting();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }

        }

        private void bills_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                bills ll = new bills();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }

        }

        private void clients_Click_1(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                clients ll = new clients();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }

        }

        private void statistics_Click_1(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                statistics ll = new statistics();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }

        }

        private void clients_payments_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                clients_payments ll = new clients_payments();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }

        }

        private void users_Click_1(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                users ll = new users();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void products_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                Product ll = new Product();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void products_types_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                Product_Type ll = new Product_Type();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void factories_payments_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                factories_payments ll = new factories_payments();
                ll.Show();
                this.Hide();/*this.Dispose();*/
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }
    }
}
