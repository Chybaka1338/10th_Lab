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
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        public Task2(Form1 form)
        {
            InitializeComponent();
            this.Size = new Size(form.Width, form.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int n);
            textBox2.Text = GetSumOfSequence(n).ToString();
        }

        private double GetSumOfSequence(int n)
        {
            double sum = (1 + n) * n / 2;
            return sum;
        }
    }
}
