namespace Homework08
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tbox_cost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cobox_customer = new System.Windows.Forms.ComboBox();
            this.bs_order = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cobox_id = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_detail = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_detail = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnt_export = new System.Windows.Forms.Button();
            this.bnt_delete = new System.Windows.Forms.Button();
            this.bnt_change = new System.Windows.Forms.Button();
            this.bnt_add = new System.Windows.Forms.Button();
            this.bnt_import = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.bs_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bs_detail)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbox_cost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cobox_customer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cobox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 57);
            this.panel1.TabIndex = 0;
            // 
            // tbox_cost
            // 
            this.tbox_cost.Location = new System.Drawing.Point(606, 16);
            this.tbox_cost.Name = "tbox_cost";
            this.tbox_cost.Size = new System.Drawing.Size(140, 25);
            this.tbox_cost.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(509, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "TotalCost:";
            // 
            // cobox_customer
            // 
            this.cobox_customer.DataSource = this.bs_order;
            this.cobox_customer.FormattingEnabled = true;
            this.cobox_customer.Location = new System.Drawing.Point(327, 16);
            this.cobox_customer.Name = "cobox_customer";
            this.cobox_customer.Size = new System.Drawing.Size(140, 23);
            this.cobox_customer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(231, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer:";
            // 
            // cobox_id
            // 
            this.cobox_id.DataSource = this.bs_order;
            this.cobox_id.FormattingEnabled = true;
            this.cobox_id.Location = new System.Drawing.Point(52, 16);
            this.cobox_id.Name = "cobox_id";
            this.cobox_id.Size = new System.Drawing.Size(140, 23);
            this.cobox_id.TabIndex = 1;
            this.cobox_id.SelectedIndexChanged += new System.EventHandler(this.cobox_id_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dgv_detail
            // 
            this.dgv_detail.AutoGenerateColumns = false;
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.name, this.number, this.cost});
            this.dgv_detail.DataSource = this.bs_detail;
            this.dgv_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_detail.Location = new System.Drawing.Point(0, 57);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.RowTemplate.Height = 27;
            this.dgv_detail.Size = new System.Drawing.Size(820, 473);
            this.dgv_detail.TabIndex = 1;
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
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.Width = -1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bnt_export);
            this.panel2.Controls.Add(this.bnt_delete);
            this.panel2.Controls.Add(this.bnt_change);
            this.panel2.Controls.Add(this.bnt_add);
            this.panel2.Controls.Add(this.bnt_import);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 64);
            this.panel2.TabIndex = 2;
            // 
            // bnt_export
            // 
            this.bnt_export.Location = new System.Drawing.Point(631, 20);
            this.bnt_export.Name = "bnt_export";
            this.bnt_export.Size = new System.Drawing.Size(110, 30);
            this.bnt_export.TabIndex = 4;
            this.bnt_export.Text = "导出订单";
            this.bnt_export.UseVisualStyleBackColor = true;
            // 
            // bnt_delete
            // 
            this.bnt_delete.Location = new System.Drawing.Point(477, 20);
            this.bnt_delete.Name = "bnt_delete";
            this.bnt_delete.Size = new System.Drawing.Size(110, 30);
            this.bnt_delete.TabIndex = 3;
            this.bnt_delete.Text = "删除订单";
            this.bnt_delete.UseVisualStyleBackColor = true;
            // 
            // bnt_change
            // 
            this.bnt_change.Location = new System.Drawing.Point(327, 20);
            this.bnt_change.Name = "bnt_change";
            this.bnt_change.Size = new System.Drawing.Size(110, 30);
            this.bnt_change.TabIndex = 2;
            this.bnt_change.Text = "修改订单";
            this.bnt_change.UseVisualStyleBackColor = true;
            // 
            // bnt_add
            // 
            this.bnt_add.Location = new System.Drawing.Point(177, 20);
            this.bnt_add.Name = "bnt_add";
            this.bnt_add.Size = new System.Drawing.Size(110, 30);
            this.bnt_add.TabIndex = 1;
            this.bnt_add.Text = "添加订单";
            this.bnt_add.UseVisualStyleBackColor = true;
            this.bnt_add.Click += new System.EventHandler(this.bnt_add_Click);
            // 
            // bnt_import
            // 
            this.bnt_import.Location = new System.Drawing.Point(23, 20);
            this.bnt_import.Name = "bnt_import";
            this.bnt_import.Size = new System.Drawing.Size(110, 30);
            this.bnt_import.TabIndex = 0;
            this.bnt_import.Text = "导入订单";
            this.bnt_import.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_detail);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.bs_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bs_detail)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;

        private System.Windows.Forms.BindingSource bs_order;

        private System.Windows.Forms.BindingSource bs_detail;

        private System.Windows.Forms.BindingSource bs_id;

        private System.Windows.Forms.Button bnt_export;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_cost;

        private System.Windows.Forms.Button bnt_import;
        private System.Windows.Forms.Button bnt_add;
        private System.Windows.Forms.Button bnt_change;
        private System.Windows.Forms.Button bnt_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobox_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobox_customer;

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.DataGridView dgv_detail;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}