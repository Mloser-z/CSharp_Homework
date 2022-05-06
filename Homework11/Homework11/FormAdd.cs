using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;


namespace Homework11
{
    public partial class FormAdd : Form
    {
        public List<OrderDetail> OrderDetails = new List<OrderDetail>();
        public long OrderId;

        public FormAdd()
        {
            InitializeComponent();
            bs_orderdetails.DataSource = OrderDetails;
            OrderId = Convert.ToInt64(DateTime.Now.ToString("yyMMddHHmmss"));
        }
        
        private void bnt_change_add_Click(object sender, EventArgs e)
        {
            FormDetailAdd form = new FormDetailAdd(OrderId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                OrderDetails.Add(form.DetailAdd);
                bs_orderdetails.ResetBindings(false);
            }
            
        }

        private void bnt_change_delete_Click(object sender, EventArgs e)
        {
            FormDetailDelete form = new FormDetailDelete(OrderId, OrderDetails);
            if (form.ShowDialog() == DialogResult.OK)
            {
                bs_orderdetails.ResetBindings(false);
            }
        }

        private void bnt_change_alter_Click(object sender, EventArgs e)
        {
            FormDetailAlter form = new FormDetailAlter(OrderId, OrderDetails);
            if (form.ShowDialog() == DialogResult.OK)
            {
               bs_orderdetails.ResetBindings(false);
            }
        }

        private void bnt_ensure_Click(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                int totalCost = 0;
                foreach (var orderDetail in OrderDetails)
                {
                    totalCost += orderDetail.Cost;
                }
                
                Order newOrder = new Order()
                {
                    OrderId = this.OrderId,
                    Customer =  tbox_name_add.Text,
                    OrderDetails = OrderDetails,
                    TotalCost = totalCost
                };
                db.OrderDetails.AddRange(OrderDetails);
                db.Orders.Add(newOrder);
                db.SaveChanges();
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}