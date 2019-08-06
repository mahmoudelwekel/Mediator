using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace Mediator
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }

        private void users_Load(object sender, EventArgs e)
        {
            
            try
            {


                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    printer_nameComboBox.Items.Add(printer);
                }

                clearall();

                userViewDataGridView.SelectionChanged += userViewDataGridView_SelectionChanged;
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }


        private void clearall()
        {
            try
            {
                this.usersTableAdapter.Fill(this.MediatorDataSet.users);

                usernameTextBox.Clear();
                passwordTextBox.Clear();
                nameTextBox.Clear();
                phoneTextBox.Clear();
                national_idTextBox.Clear();

                activeCheckBox.Checked = false;

                productsCheckBox.Checked = false;
                products_typesCheckBox.Checked = false;
                billsCheckBox.Checked = false;
                driversCheckBox.Checked = false;
                factoriesCheckBox.Checked = false;
                clientsCheckBox.Checked = false;
                statisticsCheckBox.Checked = false;
                sittingsCheckBox.Checked = false;
                usersCheckBox.Checked = false;
                clients_paymentsCheckBox.Checked = false;
                factories_paymentsCheckBox.Checked = false;


                userViewDataGridView.ClearSelection();
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void AddUsrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");

                if (usernameTextBox.Text != "" && usernameTextBox.Text != string.Empty && usernameTextBox.Text != null )
                {


                string username = usernameTextBox.Text,
                 password = passwordTextBox.Text,
                 name = nameTextBox.Text,
                 phone = phoneTextBox.Text,
                 nationalID = national_idTextBox.Text,
                 printer = printer_nameComboBox.Text;

                    bool active = activeCheckBox.Checked,
                     clients = clientsCheckBox.Checked,
                     users = usersCheckBox.Checked,
                     sittings = sittingsCheckBox.Checked,
                     statistics = statisticsCheckBox.Checked,
                     bills = billsCheckBox.Checked,
                     drivers = driversCheckBox.Checked,
                     factories = factoriesCheckBox.Checked,
                     products = productsCheckBox.Checked,
                     products_types = products_typesCheckBox.Checked,
                     clients_payments = clients_paymentsCheckBox.Checked,
                     factories_payments = factories_paymentsCheckBox.Checked;

                int id = int.Parse(this.usersTableAdapter.InsertReturnId(name, username, password, printer, nationalID, phone, active).ToString());
                this.users_privilageTableAdapter.Insert(id, clients,users,sittings,statistics,bills,drivers,factories,products,products_types,clients_payments,factories_payments);
                MessageBox.Show("تم الأضافة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearall();
                }
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void updateUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginInfo.log("[" + this.Text + " " + this.Name + "] [" + (sender as dynamic).Text + " " + (sender as dynamic).Name + "] [" + new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name + "]");
                if (usernameTextBox.Text != "" && usernameTextBox.Text != string.Empty && usernameTextBox.Text != null)
                {

                    DataGridViewRow product = null;
                    if (userViewDataGridView.SelectedRows.Count != 0)
                    {
                        product = userViewDataGridView.SelectedRows[0];
                    }
                    else
                    {
                        return;
                    }

                    if (product != null)
                    {
                        int id = int.Parse(product.Cells[0].Value.ToString());

                        string username = usernameTextBox.Text,
                         password = passwordTextBox.Text,
                         name = nameTextBox.Text,
                         phone = phoneTextBox.Text,
                         nationalID = national_idTextBox.Text,
                         printer = printer_nameComboBox.Text;

                        bool active = activeCheckBox.Checked,
                     clients = clientsCheckBox.Checked,
                     users = usersCheckBox.Checked,
                     sittings = sittingsCheckBox.Checked,
                     statistics = statisticsCheckBox.Checked,
                     bills = billsCheckBox.Checked,
                     drivers = driversCheckBox.Checked,
                     factories = factoriesCheckBox.Checked,
                     products = productsCheckBox.Checked,
                     products_types = products_typesCheckBox.Checked,
                     clients_payments = clients_paymentsCheckBox.Checked,
                     factories_payments = factories_paymentsCheckBox.Checked;

                        this.usersTableAdapter.Update(name, username, password, printer, nationalID, phone, active, id);
                        this.users_privilageTableAdapter.Update(id, clients, users, sittings, statistics, bills, drivers, factories, products, products_types, clients_payments, factories_payments);

                        MessageBox.Show("تم التعديل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    clearall();
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
                    if (userViewDataGridView.SelectedRows.Count != 0)
                    {
                        product = userViewDataGridView.SelectedRows[0];
                    }
                    else { return; }

                    if (product != null)
                    {
                        int id = int.Parse(product.Cells[0].Value.ToString());
                        this.users_privilageTableAdapter.Delete(id);
                        this.usersTableAdapter.Delete(id);
                        MessageBox.Show("تم الحذف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                clearall();
            }
            catch (Exception errortext)
            {
                MessageBox.Show(errortext.Message, "حدث خطأ حاول مرة اخرى", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }

        private void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.Search(this.MediatorDataSet.users, Search_textBox.Text);
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
                clearall();
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

        private void users_MouseDown(object sender, MouseEventArgs e)
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

        private void userViewDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow product = null;
                if (userViewDataGridView.SelectedRows.Count != 0)
                {
                    product = userViewDataGridView.SelectedRows[0];
                }
                else { return; }

                if (product != null)
                {
                    int id = int.Parse(product.Cells[0].Value.ToString());
                    this.users_privilageTableAdapter.FillBy(this.MediatorDataSet.users_privilage, id);
                }
            }
            catch (Exception errortext)
            {
                LoginInfo.log(" حدث خطأ فى " + this.Text + " " + this.Name.ToString() + " " + errortext.ToString());
            }
        }
    }
}
