using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Homework05;

namespace Homework08
{
    public partial class FormAdd : Form
    {
        public List<OrderDetails> OrderDetailsList = new List<OrderDetails>();
        private OrderService _service;
        
        public FormAdd(OrderService service)
        {
            InitializeComponent();
            bs_orderdetails.DataSource = OrderDetailsList;
            _service = service;
        }
        
        private void bnt_change_add_Click(object sender, EventArgs e)
        {
            FormDetailAdd form = new FormDetailAdd(OrderDetailsList);
            if (form.ShowDialog() == DialogResult.OK)
            {
                bs_orderdetails.ResetBindings(false);
            }
            
        }

        private void bnt_change_delete_Click(object sender, EventArgs e)
        {
            FormDetailDelete form = new FormDetailDelete(OrderDetailsList);
            if (form.ShowDialog() == DialogResult.OK)
            {
                bs_orderdetails.ResetBindings(false);
            }
        }

        private void bnt_change_alter_Click(object sender, EventArgs e)
        {
            FormDetailAlter form = new FormDetailAlter(OrderDetailsList);
            if (form.ShowDialog() == DialogResult.OK)
            {
               bs_orderdetails.ResetBindings(false);
            }
        }

        private void bnt_ensure_Click(object sender, EventArgs e)
        {
            _service.AddOrder(tbox_name_add.Text, OrderDetailsList);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}