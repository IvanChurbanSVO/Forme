using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Forme
{
    public partial class Form2 : Form
    {
        public bool isclick = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isclick = true;
        }

        public string Popa()
        {
            if (isclick)
            {
                return "Тебе выпал БО СИН";
            }
            return "";
        }
    }
}
