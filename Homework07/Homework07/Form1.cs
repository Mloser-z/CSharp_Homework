using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Homework07
{
    public partial class Form1 : Form
    {
         private Graphics graphics;
         private int depth = 10;
         private int length = 100;
         private double th1 = 30 * Math.PI / 180;
         private double th2 = 20 * Math.PI / 180;
         private double per1 = 0.6;
         private double per2 = 0.7;
         private Pen penColor = Pens.Blue;


         public Form1()
        {
            InitializeComponent();
            // PaintP.Paint += new PaintEventHandler(this.Form1_Paint);
            
        }
         
        void DrawCayleyTree(int n, 
            double x0, double y0, double leng, double th)
        {
            if( n==0 ) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
		
            DrawLine(x0, y0, x1, y1);
		
            DrawCayleyTree( n - 1, x1, y1, per1 * leng, th + th1 );
            DrawCayleyTree( n - 1, x1, y1, per2 * leng, th - th2 );
        }
        
        void DrawLine( double x0, double y0, double x1, double y1 ){
            graphics.DrawLine( 
                penColor,
                (int)x0, (int)y0, (int)x1, (int)y1 );
        }
        

        private void bntDraw_Click(object sender, EventArgs e)
        {
            try
            {
                th1 = Convert.ToDouble(tBoxTh1.Text);
                th2 = Convert.ToDouble(tBoxTh2.Text);
                per1 = Convert.ToDouble(tBoxPer1.Text);
                per2 = Convert.ToDouble(tBoxPer2.Text);
                depth = Convert.ToInt16(tBoxN.Text);
                length = Convert.ToInt16(tBoxLeng.Text);
                // Form1 cur = new Form1(this);
                // cur.ShowDialog();
                if (graphics == null)
                {
                    graphics = PaintP.CreateGraphics();
                }
                graphics.Clear(Color.White);
                DrawCayleyTree( depth, PaintP.Location.X + PaintP.Size.Width / 2, PaintP.Location.Y + PaintP.Size.Height - 50, length, -Math.PI/2 );
                
            }
            catch (Exception)
            {
                tBoxN.Text = "Error";
            }
            
        }

        private void rBntBlack_CheckedChanged(object sender, EventArgs e)
        {
            penColor = Pens.Black;
        }

        private void rBntRed_CheckedChanged(object sender, EventArgs e)
        {
            penColor = Pens.Red;
        }

        private void rBntYellow_CheckedChanged(object sender, EventArgs e)
        {
            penColor = Pens.Yellow;
        }
    }
}