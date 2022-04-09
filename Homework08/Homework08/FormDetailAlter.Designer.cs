using System.ComponentModel;

namespace Homework08
{
    partial class FormDetailAlter
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
            this.cobox_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnt_cancel = new System.Windows.Forms.Button();
            this.bnt_ensure = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbox_cost = new System.Windows.Forms.TextBox();
            this.tbox_number = new System.Windows.Forms.TextBox();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cobox_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 51);
            this.panel1.TabIndex = 0;
            // 
            // cobox_name
            // 
            this.cobox_name.FormattingEnabled = true;
            this.cobox_name.Location = new System.Drawing.Point(116, 6);
            this.cobox_name.Name = "cobox_name";
            this.cobox_name.Size = new System.Drawing.Size(144, 23);
            this.cobox_name.TabIndex = 1;
            this.cobox_name.SelectedIndexChanged += new System.EventHandler(this.cobox_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bnt_cancel);
            this.panel2.Controls.Add(this.bnt_ensure);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(820, 31);
            this.panel2.TabIndex = 1;
            // 
            // bnt_cancel
            // 
            this.bnt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnt_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bnt_cancel.Location = new System.Drawing.Point(716, 0);
            this.bnt_cancel.Name = "bnt_cancel";
            this.bnt_cancel.Size = new System.Drawing.Size(84, 31);
            this.bnt_cancel.TabIndex = 1;
            this.bnt_cancel.Text = "取消";
            this.bnt_cancel.UseVisualStyleBackColor = true;
            this.bnt_cancel.Click += new System.EventHandler(this.bnt_cancel_Click);
            // 
            // bnt_ensure
            // 
            this.bnt_ensure.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnt_ensure.Dock = System.Windows.Forms.DockStyle.Left;
            this.bnt_ensure.Location = new System.Drawing.Point(20, 0);
            this.bnt_ensure.Name = "bnt_ensure";
            this.bnt_ensure.Size = new System.Drawing.Size(84, 31);
            this.bnt_ensure.TabIndex = 0;
            this.bnt_ensure.Text = "确定";
            this.bnt_ensure.UseVisualStyleBackColor = true;
            this.bnt_ensure.Click += new System.EventHandler(this.bnt_ensure_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbox_cost);
            this.panel3.Controls.Add(this.tbox_number);
            this.panel3.Controls.Add(this.tbox_name);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 34);
            this.panel3.TabIndex = 2;
            // 
            // tbox_cost
            // 
            this.tbox_cost.Location = new System.Drawing.Point(651, 3);
            this.tbox_cost.Name = "tbox_cost";
            this.tbox_cost.Size = new System.Drawing.Size(110, 25);
            this.tbox_cost.TabIndex = 5;
            // 
            // tbox_number
            // 
            this.tbox_number.Location = new System.Drawing.Point(378, 3);
            this.tbox_number.Name = "tbox_number";
            this.tbox_number.Size = new System.Drawing.Size(110, 25);
            this.tbox_number.TabIndex = 4;
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(116, 3);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(110, 25);
            this.tbox_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(539, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "修改Cost：";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(260, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "修改Number：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "修改Name:";
            // 
            // FormDetailAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 122);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDetailAlter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDetailAlter";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.TextBox tbox_number;
        private System.Windows.Forms.TextBox tbox_cost;
        private System.Windows.Forms.Button bnt_ensure;
        private System.Windows.Forms.Button bnt_cancel;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}