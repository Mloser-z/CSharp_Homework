using System.ComponentModel;

namespace Homework08
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbox_name_add = new System.Windows.Forms.TextBox();
            this.l_name_add = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_orderdetails = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnt_cancel = new System.Windows.Forms.Button();
            this.bnt_ensure = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bnt_change_alter = new System.Windows.Forms.Button();
            this.bnt_change_delete = new System.Windows.Forms.Button();
            this.bnt_change_add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bs_orderdetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbox_name_add);
            this.panel1.Controls.Add(this.l_name_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 48);
            this.panel1.TabIndex = 0;
            // 
            // tbox_name_add
            // 
            this.tbox_name_add.Location = new System.Drawing.Point(186, 9);
            this.tbox_name_add.Name = "tbox_name_add";
            this.tbox_name_add.Size = new System.Drawing.Size(141, 25);
            this.tbox_name_add.TabIndex = 1;
            // 
            // l_name_add
            // 
            this.l_name_add.Location = new System.Drawing.Point(12, 12);
            this.l_name_add.Name = "l_name_add";
            this.l_name_add.Size = new System.Drawing.Size(177, 27);
            this.l_name_add.TabIndex = 0;
            this.l_name_add.Text = "要添加订单的顾客姓名:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.name, this.number, this.cost});
            this.dataGridView1.DataSource = this.bs_orderdetails;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(836, 374);
            this.dataGridView1.TabIndex = 1;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // number
            // 
            this.number.DataPropertyName = "Number";
            this.number.HeaderText = "Number";
            this.number.Name = "number";
            // 
            // cost
            // 
            this.cost.DataPropertyName = "Cost";
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bnt_cancel);
            this.panel2.Controls.Add(this.bnt_ensure);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 389);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.panel2.Size = new System.Drawing.Size(836, 33);
            this.panel2.TabIndex = 2;
            // 
            // bnt_cancel
            // 
            this.bnt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnt_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnt_cancel.Location = new System.Drawing.Point(686, 2);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(130, 29);
            this.bnt_cancel.TabIndex = 1;
            this.bnt_cancel.Text = "取消";
            this.bnt_cancel.UseVisualStyleBackColor = true;
            this.bnt_cancel.Click += new System.EventHandler(this.bnt_cancel_Click);
            // 
            // bnt_ensure
            // 
            this.bnt_ensure.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnt_ensure.Dock = System.Windows.Forms.DockStyle.Left;
            this.bnt_ensure.Location = new System.Drawing.Point(20, 2);
            this.bnt_ensure.Name = "bnt_ensure";
            this.bnt_ensure.Size = new System.Drawing.Size(130, 29);
            this.bnt_ensure.TabIndex = 0;
            this.bnt_ensure.Text = "确定";
            this.bnt_ensure.UseVisualStyleBackColor = true;
            this.bnt_ensure.Click += new System.EventHandler(this.bnt_ensure_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bnt_change_alter);
            this.panel3.Controls.Add(this.bnt_change_delete);
            this.panel3.Controls.Add(this.bnt_change_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 351);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(836, 38);
            this.panel3.TabIndex = 3;
            // 
            // bnt_change_alter
            // 
            this.bnt_change_alter.Location = new System.Drawing.Point(654, 4);
            this.bnt_change_alter.Name = "bnt_change_alter";
            this.bnt_change_alter.Size = new System.Drawing.Size(130, 30);
            this.bnt_change_alter.TabIndex = 2;
            this.bnt_change_alter.Text = "修改明细";
            this.bnt_change_alter.UseVisualStyleBackColor = true;
            this.bnt_change_alter.Click += new System.EventHandler(this.bnt_change_alter_Click);
            // 
            // bnt_change_delete
            // 
            this.bnt_change_delete.Location = new System.Drawing.Point(327, 5);
            this.bnt_change_delete.Name = "bnt_change_delete";
            this.bnt_change_delete.Size = new System.Drawing.Size(130, 30);
            this.bnt_change_delete.TabIndex = 1;
            this.bnt_change_delete.Text = "删除明细";
            this.bnt_change_delete.UseVisualStyleBackColor = true;
            this.bnt_change_delete.Click += new System.EventHandler(this.bnt_change_delete_Click);
            // 
            // bnt_change_add
            // 
            this.bnt_change_add.Location = new System.Drawing.Point(20, 3);
            this.bnt_change_add.Name = "bnt_change_add";
            this.bnt_change_add.Size = new System.Drawing.Size(130, 30);
            this.bnt_change_add.TabIndex = 0;
            this.bnt_change_add.Text = "添加明细";
            this.bnt_change_add.UseVisualStyleBackColor = true;
            this.bnt_change_add.Click += new System.EventHandler(this.bnt_change_add_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 422);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bs_orderdetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;

        private System.Windows.Forms.BindingSource bs_orderdetails;

        private System.Windows.Forms.Button bnt_ensure;
        private System.Windows.Forms.Button bnt_cancel;

        private System.Windows.Forms.Button bnt_change_alter;

        private System.Windows.Forms.Button bnt_change_delete;

        private System.Windows.Forms.Button bnt_change_add;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.TextBox tbox_name_add;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label l_name_add;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}