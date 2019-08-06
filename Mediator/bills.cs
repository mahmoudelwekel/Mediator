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
    public partial class bills : Form
    {
        public bills()
        {
            InitializeComponent();
        }

        void clear_all()
        {
            try
            {
                this.driversTableAdapter.Fill(this.MediatorDataSet.Drivers);
                this.usersTableAdapter.Fill(this.MediatorDataSet.users);
                this.clientsTableAdapter.Fill(this.MediatorDataSet.Clients);
                this.products_TypesTableAdapter.Fill(this.MediatorDataSet.Products_Types);
                this.productsTableAdapter.Fill(this.MediatorDataSet.Products);
                this.factoriesTableAdapter.Fill(this.MediatorDataSet.Factories);
                this.billsTableAdapter.Fill(this.MediatorDataSet.Bills);

                bill_client_idComboBox.ResetText();
                bill_client_profitNumericUpDown.ResetText();
                bill_commentTextBox.ResetText();
                bill_costNumericUpDown.ResetText();
                bill_datetimeDateTimePicker.ResetText();
                bill_driver_idComboBox.ResetText();
                bill_factory_idComboBox.ResetText();
                bill_handlers_costNumericUpDown.ResetText();
                bill_product_idComboBox.ResetText();
                bill_product_quantityNumericUpDown.ResetText();
                bill_product_type_idComboBox.ResetText();


                clientsViewDataGridView.ClearSelection();

            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void clients_Load(object sender, EventArgs e)
        {
           try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");

                clear_all();
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }


        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");

                if (bill_costNumericUpDown.Value != 0 && bill_product_quantityNumericUpDown.Value != 0)
                {

                    this.billsTableAdapter.Insert((int)bill_factory_idComboBox.SelectedValue, (int)bill_product_idComboBox.SelectedValue, (int)bill_product_type_idComboBox.SelectedValue, bill_product_quantityNumericUpDown.Value, bill_datetimeDateTimePicker.Value, bill_costNumericUpDown.Value, bill_handlers_costNumericUpDown.Value, bill_client_profitNumericUpDown.Value, (int)bill_client_idComboBox.SelectedValue, int.Parse(LoginInfo.id), (int)bill_driver_idComboBox.SelectedValue, bill_commentTextBox.Text);
                    MessageBox.Show("تم الأضافة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear_all();
                }

            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.Message, "حدث خطأ حاول مرة اخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                if (bill_costNumericUpDown.Value != 0 && bill_product_quantityNumericUpDown.Value != 0)
                {
                    DialogResult result = MessageBox.Show("هل أنت متأكد ؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {


                        DataGridViewRow product = null;
                        if (clientsViewDataGridView.SelectedRows.Count != 0)
                        {
                            product = clientsViewDataGridView.SelectedRows[0];
                        }
                        else { return; }

                        if (product != null)
                        {
                            int id = int.Parse(product.Cells[0].Value.ToString());

                            this.billsTableAdapter.Update((int)bill_factory_idComboBox.SelectedValue, (int)bill_product_idComboBox.SelectedValue, (int)bill_product_type_idComboBox.SelectedValue, bill_product_quantityNumericUpDown.Value, bill_datetimeDateTimePicker.Value, bill_costNumericUpDown.Value, bill_handlers_costNumericUpDown.Value, bill_client_profitNumericUpDown.Value, (int)bill_client_idComboBox.SelectedValue, int.Parse(LoginInfo.id), (int)bill_driver_idComboBox.SelectedValue, bill_commentTextBox.Text, id);

                            MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    clear_all();
                }
            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.Message, "حدث خطأ حاول مرة اخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                DialogResult result = MessageBox.Show("هل أنت متأكد ؟", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow product = null;
                    if (clientsViewDataGridView.SelectedRows.Count != 0)
                    {
                        product = clientsViewDataGridView.SelectedRows[0];
                    }
                    else { return; }

                    if (product != null)
                    {
                        int id = int.Parse(product.Cells[0].Value.ToString());
                        this.billsTableAdapter.Delete(id);
                        MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                clear_all();
            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.Message, "حدث خطأ حاول مرة اخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

















        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");

                clear_all();
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void back_Click(object sender, EventArgs e)
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
        
        private void clients_MouseDown(object sender, MouseEventArgs e)
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
