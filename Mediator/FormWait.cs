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
    public partial class FormWait : Form
    {
        //public Action worker { get; set; }
        public FormWait(/*Action worker*/)
        {
            InitializeComponent();

            //if (worker==null)
            //    throw new ArgumentNullException { };
            //worker = worker;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (LoginInfo.loading==false)
            {
                this.Close();
            }
        }
        //protected override void OnLoad(EventArgs e)
        //{
        //    base.OnLoad(e);
        //    Task.Factory.StartNew(worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        //}
    }
}
