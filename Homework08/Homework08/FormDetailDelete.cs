using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Homework05;

namespace Homework08
{
    public partial class FormDetailDelete : Form
    {
        public string DName;
        
        public FormDetailDelete(List<OrderDetails> orderDetailsList)
        {
            InitializeComponent();
            cobox_name.DataSource = orderDetailsList;
            cobox_name.DisplayMember = "Name";
            dataGridView1.DataSource = orderDetailsList.Where(d => d.Name == cobox_name.Text);
        }

        private void bnt_delete_Click(object sender, EventArgs e)
        {
            DName = cobox_name.Text;
            Close();
        }

        private void bnt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}