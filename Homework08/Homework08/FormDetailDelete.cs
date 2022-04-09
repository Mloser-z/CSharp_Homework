using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Homework05;

namespace Homework08
{
    public partial class FormDetailDelete : Form
    {
        private List<OrderDetails> _orderDetailsList;

        public FormDetailDelete(List<OrderDetails> orderDetailsList)
        {
            InitializeComponent();
            _orderDetailsList = orderDetailsList;
            cobox_name.DataSource = orderDetailsList;
            cobox_name.DisplayMember = "Name";
            
        }

        private void bnt_delete_Click(object sender, EventArgs e)
        {
            _orderDetailsList.Remove(_orderDetailsList.Where(d => d.Name == cobox_name.Text).First());
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cobox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSource1.DataSource = _orderDetailsList.Where(d => d.Name == cobox_name.Text).First();
        }
    }
}