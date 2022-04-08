using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using Homework05;

namespace Homework08
{
    public partial class FormDetailAdd : Form
    {
        public OrderDetails NewDetail;

        public FormDetailAdd()
        {
            InitializeComponent();
        }

        private void bnt_ensure_Click(object sender, EventArgs e)
        {
            try
            {
                NewDetail = new OrderDetails(tbox_name.Text, Convert.ToInt32(tbox_number.Text),
                    Convert.ToInt32(tbox_cost.Text));
                Close();
            }
            catch (Exception err)
            {
                tbox_name.Text = err.Message;
            }
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}