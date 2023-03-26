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
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        public Task1(Form1 form)
        {
            InitializeComponent();
            this.Size = new Size(form.Width, form.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int a);
            int.TryParse(textBox2.Text, out int b);
            var c = a + b;
            textBox3.Text = c.ToString();
        }
    }
}
