namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(400, 300);
            button1.Location = new System.Drawing.Point(Width / 2 - 75, Height / 2 - 63);
            button2.Location = new System.Drawing.Point(button1.Location.X, button1.Location.Y + 40);
            button3.Location = new System.Drawing.Point(button2.Location.X, button2.Location.Y + 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1 form = new Task1(this);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task2 form = new Task2(this);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3 form = new Task3(this);
        }
    }
}