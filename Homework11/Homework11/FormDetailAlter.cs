using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Homework11
{
    public partial class FormDetailAlter : Form
    {
        private List<OrderDetail> _orderDetails;
        private int _orderId;

        public FormDetailAlter(int orderId, List<OrderDetail> orderDetails)
        {
            InitializeComponent();
            _orderId = orderId;
            _orderDetails = orderDetails;
            cobox_name.DataSource = _orderDetails;
            cobox_name.DisplayMember = "Name";
            try
            {
                OrderDetail orderDetailAlter;
                if (_orderDetails != null)
                {
                    orderDetailAlter = _orderDetails.Single(d => d.Name == cobox_name.Text);
                }
                else
                {
                    using (var db = new OrderContext())
                    {
                        orderDetailAlter = db.Orders.Single(o => o.OrderId == _orderId).OrderDetails
                            .Single(d => d.Name == cobox_name.Text);
                    }
                }
                tbox_name.Text = orderDetailAlter.Name; 
                tbox_number.Text = orderDetailAlter.Number.ToString();
                tbox_cost.Text = orderDetailAlter.Cost.ToString();
                
            }
            catch (Exception e)
            {
                tbox_name.Text = e.Message;
            }
            
        }


        private void bnt_ensure_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetail details = _orderDetails.Single(d=>d.Name == cobox_name.Text);
                using (var db = new OrderContext())
                {
                    Order order = db.Orders.Single(o => o.OrderId == _orderId);
                    if (order != null)
                    {
                        details = order.OrderDetails.Single(d => d.Name == cobox_name.Text);
                        details.Name = tbox_name.Text;
                        details.Number = Convert.ToInt32(tbox_number.Text);
                        details.Cost = Convert.ToInt32(tbox_cost.Text);
                        db.SaveChanges();
                    }
                }
                details.Name = tbox_name.Text;
                details.Number = Convert.ToInt32(tbox_number.Text);
                details.Cost = Convert.ToInt32(tbox_cost.Text);
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

        private void cobox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderDetail orderDetailAlter = _orderDetails.Single(d => d.Name == cobox_name.Text);
            tbox_name.Text = orderDetailAlter.Name;
            tbox_number.Text = orderDetailAlter.Number.ToString();
            tbox_cost.Text = orderDetailAlter.Cost.ToString();
        }
    }
}