using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using Homework05;

namespace Homework08
{
    public partial class FormDetailAdd : Form
    {
        private List<OrderDetails> _orderDetailsList;

        public FormDetailAdd(List<OrderDetails> orderDetailsList)
        {
            InitializeComponent();
            _orderDetailsList = orderDetailsList;
        }

        private void bnt_ensure_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetails newDetail = new OrderDetails(tbox_name.Text, Convert.ToInt32(tbox_number.Text),
                    Convert.ToInt32(tbox_cost.Text));
                _orderDetailsList.Add(newDetail);
                DialogResult = DialogResult.OK;
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