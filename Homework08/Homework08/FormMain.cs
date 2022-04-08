﻿using System;
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
            tbox_cost.Text = _service.FindById(Convert.ToInt16(cobox_id.Text)).TotalCost.ToString();
            dgv_detail.DataSource = _service.FindById(Convert.ToInt16(cobox_id.Text)).Data;
        }

        private void bnt_add_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                _service.AddOrder(formAdd.Customer, formAdd.OrderDetailsList);
            }
        }
    }
}