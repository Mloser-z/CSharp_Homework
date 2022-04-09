using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework05;

namespace Homework08
{
    public partial class FormMain : Form
    {
        private OrderService _service;

        public FormMain()
        {
            InitializeComponent();
            _service = new OrderService();
            test();
            Init_bs();

        }

        // test
        private void test()
        {
            _service.AddOrder("A",
                new List<OrderDetails>()
                {
                    new OrderDetails("a", 1, 1),
                    new OrderDetails("b", 2, 2)
                });
            _service.AddOrder("B",
                new List<OrderDetails>()
                {
                    new OrderDetails("c", 3, 3)
                });
        }

        private void Init_bs()
        {
            bs_order.DataSource = _service.orders;
            cobox_id.DisplayMember = "Id";
            cobox_customer.DisplayMember = "Customer";
        }

        private void cobox_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbox_cost.Text = _service.FindById(Convert.ToInt32(cobox_id.Text)).TotalCost.ToString();
            bs_detail.DataSource = _service.FindById(Convert.ToInt32(cobox_id.Text)).Data;
        }


        private void bnt_add_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(_service);
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                bs_order.ResetBindings(false);
            }
        }

        private void bnt_change_Click(object sender, EventArgs e)
        {
            FormDetailAdd formDetailAdd = new FormDetailAdd(_service.FindById(Convert.ToInt32(cobox_id.Text)).Data);
            if (formDetailAdd.ShowDialog() == DialogResult.OK)
            {
                bs_order.ResetBindings(false);
                bs_detail.ResetBindings(false); 
            }

        }

        private void bnt_change_alter_Click(object sender, EventArgs e)
        {
            FormDetailAlter formDetailAlter = new FormDetailAlter(_service.FindById(Convert.ToInt32(cobox_id.Text)).Data);
            if (formDetailAlter.ShowDialog() == DialogResult.OK)
            {
                bs_order.ResetBindings(false);
                bs_detail.ResetBindings(false); 
            }
        }

        private void bnt_change_delete_Click(object sender, EventArgs e)
        {
            FormDetailDelete formDetailDelete =
                new FormDetailDelete(_service.FindById(Convert.ToInt32(cobox_id.Text)).Data);
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
    }
}