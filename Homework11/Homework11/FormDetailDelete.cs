using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Homework11
{
    public partial class FormDetailDelete : Form
    {
        private List<OrderDetail> _orderDetailsList;
        private int _orderId;

        public FormDetailDelete(int orderId, List<OrderDetail> orderDetailsList)
        {
            InitializeComponent();
            _orderId = orderId;
            _orderDetailsList = orderDetailsList;
            cobox_name.DataSource = orderDetailsList;
            cobox_name.DisplayMember = "Name";
            
        }

        private void bnt_delete_Click(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                Order order = db.Orders.SingleOrDefault(o => o.OrderId == _orderId);
                if (order != null)
                {
                    order.OrderDetails.Remove(order.OrderDetails.Single(d => d.Name == cobox_name.Text));
                    db.OrderDetails.Remove(order.OrderDetails.Single(d => d.Name == cobox_name.Text));
                    db.SaveChanges();
                }
                else
                {
                    _orderDetailsList.Remove(_orderDetailsList.Single(d => d.Name == cobox_name.Text));
                }
            }
            
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cobox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSource1.DataSource = _orderDetailsList.Single(d => d.Name == cobox_name.Text);
        }
    }
}