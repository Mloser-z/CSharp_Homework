using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Homework05;

namespace Homework08
{
    public partial class FormDetailAlter : Form
    {
        public OrderDetails Details;
        public string Iname;
        
        public FormDetailAlter(List<OrderDetails> orderDetailsList)
        {
            InitializeComponent();
            cobox_name.DataSource = orderDetailsList;
            cobox_name.DisplayMember = "Name";
            dataGridView1.DataSource = orderDetailsList.Where(d => d.Name == cobox_name.Text);
            try
            {
                tbox_name.Text = orderDetailsList.Where(d => d.Name == cobox_name.Text).FirstOrDefault().Name;
                tbox_number.Text = orderDetailsList.Where(d => d.Name == cobox_name.Text).FirstOrDefault().Number
                    .ToString();
                tbox_cost.Text = orderDetailsList.Where(d => d.Name == cobox_name.Text).FirstOrDefault().Cost
                    .ToString();
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
                Iname = cobox_name.Text;
                Details = new OrderDetails();
                Details.Name = tbox_name.Text;
                Details.Number = Convert.ToInt32(tbox_number.Text);
                Details.Cost = Convert.ToInt32(tbox_cost.Text);
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