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
        public string Customer;
        
        public FormAdd()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            bs_orderdetails.DataSource = OrderDetailsList;
        }


        private void bnt_change_add_Click(object sender, EventArgs e)
        {
            FormDetailAdd form = new FormDetailAdd();
            if (form.ShowDialog() == DialogResult.OK)
            {
                OrderDetailsList.Add(form.NewDetail);
            }
            
        }

        private void bnt_change_delete_Click(object sender, EventArgs e)
        {
            FormDetailDelete form = new FormDetailDelete(OrderDetailsList);
            if (form.ShowDialog() == DialogResult.OK)
            {
                OrderDetailsList.Remove(OrderDetailsList.Where(d => d.Name == form.DName).First());
            }
        }

        private void bnt_change_alter_Click(object sender, EventArgs e)
        {
            FormDetailAlter form = new FormDetailAlter(OrderDetailsList);
            if (form.ShowDialog() == DialogResult.OK)
            {
                OrderDetails p = OrderDetailsList.Where(d => d.Name == form.Iname).First();
                p.Name = form.Details.Name;
                p.Number = form.Details.Number;
                p.Cost = form.Details.Cost;
            }
        }

        private void bnt_ensure_Click(object sender, EventArgs e)
        {
            Customer = tbox_name_add.Text;
            Close();
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}