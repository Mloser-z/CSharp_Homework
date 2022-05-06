using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Homework11
{
    public partial class FormMain : Form
    {
        private List<Order> _orders;

        public FormMain()
        {
            
            InitializeComponent();
            Init_bs();
        }
        
        private void Init_bs()
        {
            using (var db = new OrderContext())
            {
                _orders = db.Orders.Where(o=>true).ToList();
                bs_order.DataSource = _orders;
                cobox_id.DisplayMember = "OrderId";
                cobox_customer.DisplayMember = "Customer";
            }
           
        }

        private void cobox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                tbox_cost.Text = db.Orders
                    .Single(o=>o.OrderId == Convert.ToInt64(cobox_id.Text)).TotalCost.ToString();
                
                bs_detail.DataSource = db.Orders
                    .Single(o=>o.OrderId == Convert.ToInt64(cobox_id.Text)).OrderDetails;;
            }
            
        }


        private void UpDateCobox()
        {
            using (var db = new OrderContext())
            {
                _orders = db.Orders.Where(o=>true).ToList();
                bs_order.ResetBindings(false);
            }
        }

        private void bnt_add_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                UpDateCobox();
            }
        }

        private void bnt_change_Click(object sender, EventArgs e)
        {
            FormDetailAdd formDetailAdd = new FormDetailAdd(Convert.ToInt64(cobox_id.Text));
            if (formDetailAdd.ShowDialog() == DialogResult.OK)
            {
                UpDateCobox();
                // bs_order.ResetBindings(false);
                bs_detail.ResetBindings(false); 
            }
        }

        private void bnt_change_alter_Click(object sender, EventArgs e)
        {
            FormDetailAlter formDetailAlter = new FormDetailAlter(Convert.ToInt64(cobox_id.Text), null);
            if (formDetailAlter.ShowDialog() == DialogResult.OK)
            {
                bs_order.ResetBindings(false);
                bs_detail.ResetBindings(false); 
            }
        }

        private void bnt_change_delete_Click(object sender, EventArgs e)
        {
            FormDetailDelete formDetailDelete =
                new FormDetailDelete(Convert.ToInt64(cobox_id.Text), null);
            if (formDetailDelete.ShowDialog() == DialogResult.OK)
            {
                bs_detail.ResetBindings(false);
                bs_order.ResetBindings(false);
            }
        }

        private void bnt_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnt_import_Click(object sender, EventArgs e)
        {
            
        }

        private void bnt_delete_Click(object sender, EventArgs e)
        {
            using (var db = new OrderContext())
            {
                Order order = db.Orders.Include("OrderDetails").Single(o => o.OrderId == Convert.ToInt64(cobox_id.Text));
                db.Orders.Remove(order);
                db.SaveChanges();
            }
            
            UpDateCobox();
            // bs_order.ResetBindings(false);
            bs_detail.ResetBindings(false);
        }
        
    }
}