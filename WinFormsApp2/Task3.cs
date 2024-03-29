﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    delegate int MathFunc(int x);
    public partial class Task3 : Form
    {
        Pen pen = new Pen(Color.Black, 1f);
        int dx = 0;
        int dy = 0;
        static int scaleX = 10;
        static int scaleY = 5;

        public Task3(Form1 form)
        {
            InitializeComponent();
            pen.CustomEndCap = new AdjustableArrowCap(6, 6);
            dx = Size.Width / 2;
            dy = Size.Height / 2;
        }

        private void Task3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
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
            g.DrawLine(pen, -400, 0, 400, 0);
            g.DrawLine(new Pen(Color.Black, 1f), -4, -1 * scaleY, 4, -1 * scaleY);
            g.DrawLine(new Pen(Color.Black, 1f), 1 * scaleX, 4, 1 * scaleX, -4);
            label1.Location = new Point(dx + 400, dy + 2);
            label2.Location = new Point(dx + 20, dy - 400);
            label3.Location = new Point(dx + scaleX, dy + scaleY);
            label4.Location = new Point(dx - 2 * scaleX, dy - 3 * scaleY);
            g.DrawLine(pen, 0, 400, 0, -400);
        }

        private void DrawGraph(double a, double b, int n, MathFunc Func, Graphics g)
        {
            double increment = (b - a) / n;
            for (double x = a; x <= b; x += increment)
            {
                int y = Func((int)x) * (-1);
                g.DrawEllipse(new Pen(Color.Red, 2.5f), (int)x * scaleX, y * scaleY, 1, 1);
                g.DrawLine(new Pen(Color.Black, 1f), (int)x * scaleX, 4, (int)x * scaleX, -4);
            }
        }
    }
}
