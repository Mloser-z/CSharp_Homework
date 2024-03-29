using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Homework05;

namespace Homework08
{
    public partial class FormDetailAlter : Form
    {
        private List<OrderDetails> _orderDetailsList;

        public FormDetailAlter(List<OrderDetails> orderDetailsList)
        {
            InitializeComponent();
            _orderDetailsList = orderDetailsList;
            cobox_name.DataSource = _orderDetailsList;
            cobox_name.DisplayMember = "Name";
            try
            {
                tbox_name.Text = _orderDetailsList.Where(d => d.Name == cobox_name.Text).First().Name;
                tbox_number.Text = _orderDetailsList.Where(d => d.Name == cobox_name.Text).First().Number
                    .ToString();
                tbox_cost.Text = _orderDetailsList.Where(d => d.Name == cobox_name.Text).First().Cost
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
                OrderDetails details = _orderDetailsList.Where(d=>d.Name == cobox_name.Text).First();
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
            tbox_name.Text = _orderDetailsList.Where(d => d.Name == cobox_name.Text).First().Name;
            tbox_number.Text = _orderDetailsList.Where(d => d.Name == cobox_name.Text).First().Number
                .ToString();
            tbox_cost.Text = _orderDetailsList.Where(d => d.Name == cobox_name.Text).First().Cost
                .ToString();
        }
    }
}