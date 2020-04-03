using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th11 = 30 * Math.PI / 180;
        double th22 = 20 * Math.PI / 180;
        double per11 = 0.6;
        double per22 = 0.7;
        int depth1=10;
        int leng1=100;
        Pen penColor1=new Pen(Color.Blue);

        public void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per11 * leng, th + th11);
            drawCayleyTree(n - 1, x1, y1, per22 * leng, th - th22);
        }

        private void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(penColor1, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void drawTree_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = panel1.CreateGraphics();
            drawCayleyTree(depth1, 200, 500, leng1, -Math.PI / 2);
        }

        private void depthValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                depth1 = Convert.ToInt32(depthValue.Text);
            }catch (Exception)
            {
                
            }           
        }

        private void lengValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                leng1 = Convert.ToInt32(lengValue.Text);
            }
            catch (Exception)
            {

            }
        }

        private void per1Value_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per11 = Convert.ToDouble(per1Value.Text);
            }
            catch (Exception)
            {

            }
        }

        private void per2Value_TextChanged(object sender, EventArgs e)
        {
            try
            {
                per22 = Convert.ToDouble(per2Value.Text);
            }
            catch (Exception)
            {

            }
        }

        private void th1Value_TextChanged(object sender, EventArgs e)
        {
         
            try
            {
                th11 = Convert.ToDouble(th1Value.Text) * Math.PI / 180;
            }
            catch (Exception)
            {

            }
        }

        private void th2Value_TextChanged(object sender, EventArgs e)
        {

            try
            {
                th22 = Convert.ToDouble(th2Value.Text) * Math.PI / 180;
            }
            catch (Exception)
            {

            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            graphics.Clear(this.BackColor);
        }

        private void penColorValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color cl = Color.FromName(penColorValue.SelectedItem+"");
            penColor1 = new Pen(cl);
        }
    }
}
