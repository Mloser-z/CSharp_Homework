using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Homework11
{
    public partial class FormDetailAdd : Form
    {
        private int _orderId;

        public OrderDetail DetailAdd;
        
        public FormDetailAdd(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void bnt_ensure_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetail newDetail = new OrderDetail()
                {
                    Name = tbox_name.Text,
                    Number = Convert.ToInt32(tbox_number.Text),
                    Cost =  Convert.ToInt32(tbox_cost.Text),
                    OrderId = _orderId
                };

                using (var db = new OrderContext())
                {
                    Order order = db.Orders.SingleOrDefault(o => o.OrderId == _orderId);
                    if (order != null)
                    {
                        order.OrderDetails.Add(newDetail);
                        db.OrderDetails.Add(newDetail);
                        db.SaveChanges();
                    }
                    else
                    {
                        DetailAdd = newDetail;
                    }
                }
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