using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    delegate int MathFunc(int x);
    public partial class Task3 : Form
    {
        Pen pen = new Pen(Color.Black, 2f);

        public Task3()
        {
            InitializeComponent();
        }

        public Task3(Form1 form)
        {
            InitializeComponent();
            this.Show();
        }

        private void Task3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int dx = this.Width / 2;
            int dy = this.Height / 2;
            g.TranslateTransform(dx, dy);
            DrawCoordPlane(g);
            MathFunc func = delegate (int x)
            {
                return (int)(x * x - 18 * x + 72);
            };
            DrawGraph(5, 20, 40, func, g);
        }

        private void DrawCoordPlane(Graphics g)
        {
            g.DrawLine(pen, -200, 0, 200, 0);
            label1.Location = new Point(this.Width / 2 + 200, this.Height / 2);
            label2.Location = new Point(this.Width / 2, this.Height / 2 - 200);
            g.DrawLine(pen, 0, -200, 0, 200);
        }

        private void DrawGraph(double a, double b, int n, MathFunc Func, Graphics g)
        {
            double increment = (b - a) / n;
            for (double x = a; x <= b; x += increment)
            {
                int y = Func((int)x);
                g.DrawEllipse(pen, (int)x * 5, -y * 3, 1, 1);
            }
        }

        private Point GetCurrentPoint(int x, MathFunc Func)
        {
            return new Point(x, Func.Invoke(x));
        }
    }
}
