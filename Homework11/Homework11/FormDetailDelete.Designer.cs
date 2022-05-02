using System.ComponentModel;

namespace Homework11
{
    partial class FormDetailDelete
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
            this.cobox_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnt_cancel = new System.Windows.Forms.Button();
            this.bnt_delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cobox_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(662, 35);
            this.panel1.TabIndex = 0;
            // 
            // cobox_name
            // 
            this.cobox_name.FormattingEnabled = true;
            this.cobox_name.Location = new System.Drawing.Point(64, 6);
            this.cobox_name.Name = "cobox_name";
            this.cobox_name.Size = new System.Drawing.Size(104, 23);
            this.cobox_name.TabIndex = 1;
            this.cobox_name.SelectedIndexChanged += new System.EventHandler(this.cobox_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bnt_cancel);
            this.panel2.Controls.Add(this.bnt_delete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 168);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 2, 20, 2);
            this.panel2.Size = new System.Drawing.Size(662, 33);
            this.panel2.TabIndex = 1;
            // 
            // bnt_cancel
            // 
            this.bnt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnt_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnt_cancel.Location = new System.Drawing.Point(525, 2);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(117, 29);
            this.bnt_cancel.TabIndex = 1;
            this.bnt_cancel.Text = "取消";
            this.bnt_cancel.UseVisualStyleBackColor = true;
            this.bnt_cancel.Click += new System.EventHandler(this.bnt_cancel_Click);
            // 
            // bnt_delete
            // 
            this.bnt_delete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnt_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.bnt_delete.Location = new System.Drawing.Point(20, 2);
            this.bnt_delete.Name = "bnt_delete";
            this.bnt_delete.Size = new System.Drawing.Size(117, 29);
            this.bnt_delete.TabIndex = 0;
            this.bnt_delete.Text = "删除";
            this.bnt_delete.UseVisualStyleBackColor = true;
            this.bnt_delete.Click += new System.EventHandler(this.bnt_delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.name, this.number, this.cost});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(662, 133);
            this.dataGridView1.TabIndex = 2;
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
            // FormDetailDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 201);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDetailDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDetailDelete";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.BindingSource bindingSource1;

        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;

        private System.Windows.Forms.Button bnt_delete;
        private System.Windows.Forms.Button bnt_cancel;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobox_name;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}