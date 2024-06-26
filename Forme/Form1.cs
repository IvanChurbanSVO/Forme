using Forme;

namespace Forme
{
    public partial class Form1 : Form
    {
        private Form2 form = new();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form = new();
            form.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (form.isclick)
            {
                label1.Text = form.Popa();
            }
        }
    }
}
