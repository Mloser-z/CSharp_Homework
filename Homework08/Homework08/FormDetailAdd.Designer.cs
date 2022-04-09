using System.ComponentModel;

namespace Homework08
{
    partial class FormDetailAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbox_cost = new System.Windows.Forms.TextBox();
            this.tbox_number = new System.Windows.Forms.TextBox();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnt_ensure = new System.Windows.Forms.Button();
            this.bnt_cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbox_cost);
            this.panel1.Controls.Add(this.tbox_number);
            this.panel1.Controls.Add(this.tbox_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 71);
            this.panel1.TabIndex = 0;
            // 
            // tbox_cost
            // 
            this.tbox_cost.Location = new System.Drawing.Point(533, 16);
            this.tbox_cost.Name = "tbox_cost";
            this.tbox_cost.Size = new System.Drawing.Size(112, 25);
            this.tbox_cost.TabIndex = 5;
            // 
            // tbox_number
            // 
            this.tbox_number.Location = new System.Drawing.Point(323, 16);
            this.tbox_number.Name = "tbox_number";
            this.tbox_number.Size = new System.Drawing.Size(112, 25);
            this.tbox_number.TabIndex = 4;
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(108, 16);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(112, 25);
            this.tbox_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(468, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(242, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // bnt_ensure
            // 
            this.bnt_ensure.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnt_ensure.Location = new System.Drawing.Point(46, 91);
            this.bnt_ensure.Name = "bnt_ensure";
            this.bnt_ensure.Size = new System.Drawing.Size(90, 30);
            this.bnt_ensure.TabIndex = 1;
            this.bnt_ensure.Text = "添加";
            this.bnt_ensure.UseVisualStyleBackColor = true;
            this.bnt_ensure.Click += new System.EventHandler(this.bnt_ensure_Click);
            // 
            // bnt_cancel
            // 
            this.bnt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnt_cancel.Location = new System.Drawing.Point(564, 91);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(90, 30);
            this.bnt_cancel.TabIndex = 2;
            this.bnt_cancel.Text = "取消";
            this.bnt_cancel.UseVisualStyleBackColor = true;
            this.bnt_cancel.Click += new System.EventHandler(this.bnt_cancel_Click);
            // 
            // FormDetailAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 134);
            this.Controls.Add(this.bnt_cancel);
            this.Controls.Add(this.bnt_ensure);
            this.Controls.Add(this.panel1);
            this.Name = "FormDetailAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDetailAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bnt_ensure;
        private System.Windows.Forms.Button bnt_cancel;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.TextBox tbox_number;
        private System.Windows.Forms.TextBox tbox_cost;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}