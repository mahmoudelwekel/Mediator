using Microsoft.Reporting.WinForms;
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
using System.Reflection;

namespace Mediator
{
    public partial class statistics : Form
    {
        public statistics()
        {
            InitializeComponent();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
           
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");



                //var items = new[] {
                //    new { Text = "واردات", Value = Convert.ToInt16( "1") },
                //    new { Text = "مصروفات", Value = Convert.ToInt16( "-1") }
                //    };



                //PaymentOperatorlist.DataSource = items;
                //PaymentOperatorlist.DisplayMember = "Text";
                //PaymentOperatorlist.ValueMember = "Value";

              
                //ClientsOperatorList.DataSource = items;
                //ClientsOperatorList.DisplayMember = "Text";
                //ClientsOperatorList.ValueMember = "Value";

                
                //paymenttypeoperatorDataGridViewTextBoxColumn.DataSource = items;
                //paymenttypeoperatorDataGridViewTextBoxColumn.DisplayMember = "Text";
                //paymenttypeoperatorDataGridViewTextBoxColumn.ValueMember = "Value";

                //paymenttypeoperatorDataGridViewTextBoxColumn1.DataSource = items;
                //paymenttypeoperatorDataGridViewTextBoxColumn1.DisplayMember = "Text";
                //paymenttypeoperatorDataGridViewTextBoxColumn1.ValueMember = "Value";

                this.clientsTableAdapter.Fill(this.MediatorDataSet.Clients);
                this.usersTableAdapter.Fill(this.MediatorDataSet.users);

                
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }




        private void BillsSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BackgroundWorker gBgwDownload = new BackgroundWorker(); /* added this line will fix problem */
                gBgwDownload.DoWork += (object ss, DoWorkEventArgs ee) =>
                {
                    LoginInfo.loading = true;
                    FormWait f = new FormWait();
                    f.ShowDialog();
                };

                gBgwDownload.RunWorkerAsync();

                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                int?
                project = int.Parse( PaymentProjectsList.SelectedValue.ToString()),
                user = int.Parse(PaymentUserList.SelectedValue.ToString()),
                client = int.Parse(PaymentClientList.SelectedValue.ToString()),
                
                paytype = int.Parse(PaymentTypelist.SelectedValue.ToString())
                ;

                short? type = Int16.Parse(PaymentOperatorlist.SelectedValue.ToString());

                
                if (!PaymentProjectsCK.Checked) { project = null; };
                if (!PaymentUserCk.Checked) { user = null; };
                if (!PaymentClientCk.Checked) { client = null; };
                if (!PaymentOperatorck.Checked) { type = null; };
                if (!PaymentTypeCk.Checked) { paytype = null; };


                //this.paymentViewTableAdapter.Filter(this.MediatorDataSet.PaymentView, user, client, project, paytype, type, null, null);
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
                LoginInfo.loading = false;
        }
        private void BillsPrintBillsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                if (BillsBillsGv.Rows.Count != 0)
                {
                    //toPDF(BillsBillsGv);
                }
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
                LoginInfo.loading = false;
        }



        private void BillContentSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BackgroundWorker gBgwDownload = new BackgroundWorker(); /* added this line will fix problem */
                gBgwDownload.DoWork += (object ss, DoWorkEventArgs ee) =>
                {
                    LoginInfo.loading = true;
                    FormWait f = new FormWait();
                    f.ShowDialog();
                };

                gBgwDownload.RunWorkerAsync();

                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                int?
                project = int.Parse(ProjectsProjectsList.SelectedValue.ToString());
                //user = int.Parse(ProjectsUserList.SelectedValue.ToString()),
                //client = int.Parse(ProjectsClientsList.SelectedValue.ToString()),

                //paytype = int.Parse(ProjectsPaymentTypeList.SelectedValue.ToString())
                //;

                //short? paymentoperatore = Int16.Parse(ProjectsOperatorList.SelectedValue.ToString());

                //DateTime
                //    from = Convert.ToDateTime(ProjectsFromTxt.Text),
                //    to = Convert.ToDateTime(ProjectsToTxt.Text);

                if (!ProjectsProjectsCk.Checked) { project = null; };
                //if (!ProjectsUserCk.Checked) { user = null; };
                //if (!ProjectsClientCk.Checked) { client = null; };
                //if (!ProjectsOperatorCk.Checked) { paymentoperatore = null; };
                //if (!ProjectsPaymentTypeck.Checked) { paytype = null; };


                //this.projectsViewTableAdapter.Filter(this.MediatorDataSet.ProjectsView, null, null, project, null, null, null, null);
                

            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
                LoginInfo.loading = false;
        }
        private void BillContentPrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                

                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                
                if (BillContentBillContentGv.Rows.Count != 0)
                {
                    //toPDF(BillContentBillContentGv);
                }
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
                LoginInfo.loading = false;
        }



        private void ClientsSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BackgroundWorker gBgwDownload = new BackgroundWorker(); /* added this line will fix problem */
                gBgwDownload.DoWork += (object ss, DoWorkEventArgs ee) =>
                {
                    LoginInfo.loading = true;
                    FormWait f = new FormWait();
                    f.ShowDialog();
                };

                gBgwDownload.RunWorkerAsync();

                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                int?
                project = int.Parse(ClientsProjectList.SelectedValue.ToString()),
                //user = int.Parse(ClientsUserList.SelectedValue.ToString()),
                client = int.Parse(ClientsClientsList.SelectedValue.ToString()),

                paytype = int.Parse(ClientsPaymentTypeList.SelectedValue.ToString())
                ;

                short? paymentoperatore = Int16.Parse(ClientsOperatorList.SelectedValue.ToString());

                //DateTime
                //    from = Convert.ToDateTime(ClientsFromTxt.Text),
                //    to = Convert.ToDateTime(ClientsToTxt.Text);

                if (!ClientsProjectCk.Checked) { project = null; };
                //if (!ClientsUserCk.Checked) { user = null; };
                if (!ClientsClientsCk.Checked) { client = null; };
                if (!ClientsOperatorCk.Checked) { paymentoperatore = null; };
                if (!ClientsPaymentTypeCk.Checked) { paytype = null; };


                //this.clientsViewTableAdapter.Filter(this.MediatorDataSet.ClientsView, null, client, project, paytype, paymentoperatore, null, null);

            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
                LoginInfo.loading = false;
        }
        private void ClientsPrintBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");



                if (ClientsStatisticsGv.Rows.Count != 0)
                {
                    //toPDF(ClientsStatisticsGv);
                }
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
                LoginInfo.loading = false;
        }



        private void log_search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                BackgroundWorker gBgwDownload = new BackgroundWorker(); /* added this line will fix problem */
                gBgwDownload.DoWork += (object ss, DoWorkEventArgs ee) =>
                {
                    LoginInfo.loading = true;
                    FormWait f = new FormWait();
                    f.ShowDialog();
                };

                gBgwDownload.RunWorkerAsync();

                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");

                DateTime
               from = Convert.ToDateTime(log_from.Text),
               to = Convert.ToDateTime(log_to.Text);

                int? user = null;
                if (log_user_ck.Checked) { user = (int)log_user_list.SelectedValue; }

                this.system_logTableAdapter.Search(this.MediatorDataSet.system_log, from, to, user);
            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.ToString());
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
            LoginInfo.loading = false;
        }


        //void toPDF( DataGridView dataGridView1)
        //{
        //    try
        //    {
        //        int ColumnsCount = 0;
        //        foreach (DataGridViewColumn column in dataGridView1.Columns)
        //        {
        //            if (column.Visible == true)
        //            {
        //                ColumnsCount++;
        //            }
        //        }
        //        //Creating iTextSharp Table from the DataTable data
        //        PdfPTable pdfTable = new PdfPTable(ColumnsCount);
        //        pdfTable.DefaultCell.Padding = 5;

        //        pdfTable.WidthPercentage = 100;
        //        pdfTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
        //        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
        //        pdfTable.DefaultCell.BorderWidth = 1;

        //        var ArialFontFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");
        //        BaseFont bfArialUniCode = BaseFont.CreateFont(ArialFontFile, BaseFont.IDENTITY_H, true);
        //        iTextSharp.text.Font font = new iTextSharp.text.Font(bfArialUniCode, 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);


        //        //Adding Header row
        //        foreach (DataGridViewColumn column in dataGridView1.Columns)
        //        {
        //            if (column.Visible == true)
        //            {
        //                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
        //                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
        //                cell.Padding = 5;
        //                pdfTable.AddCell(cell);
        //            }
        //        }

        //        //Adding DataRow
        //        foreach (DataGridViewRow row in dataGridView1.Rows)
        //        {
        //            foreach (DataGridViewCell cell in row.Cells)
        //            {
        //                if (dataGridView1.Columns[cell.ColumnIndex].Visible == true)
        //                {
        //                    pdfTable.AddCell(new Phrase(cell.FormattedValue.ToString(), font));
        //                }
        //            }
        //        }

        //        //Exporting to PDF

        //        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        //        {

        //            string folderPath = folderBrowserDialog1.SelectedPath;
        //            if (!Directory.Exists(folderPath))
        //            {
        //                Directory.CreateDirectory(folderPath);
        //            }
        //            using (FileStream stream = new FileStream(folderPath + "\\" + dataGridView1.Tag + DateTime.Now.ToString(" yyyy-MM-dd HH.mm.ss") + ".pdf", FileMode.Create))
        //            {
        //                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
        //                PdfWriter.GetInstance(pdfDoc, stream);
        //                pdfDoc.Open();
        //                pdfDoc.Add(pdfTable);
        //                pdfDoc.Close();
        //                stream.Close();
        //            }
        //        }
        //    }
        //    catch (Exception errortext)
        //    {
        //        LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
        //    }
        //}









        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");

                
                this.clientsTableAdapter.Fill(this.MediatorDataSet.Clients);
                this.usersTableAdapter.Fill(this.MediatorDataSet.users);

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
        private void statistics_MouseDown(object sender, MouseEventArgs e)
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
