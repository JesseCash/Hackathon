using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_veiw
{
    public partial class Form3 : Form
    {
        String conv;
        public Form3()
        {
            InitializeComponent();
            button1.Click += new System.EventHandler(ClickedButton);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void ClickedButton(object sender, EventArgs e)
        {

            int a;

            a = int.Parse(textBox1.Text);
            double b = 100.0 / 1000.0;
            double result = b * a;
            conv = result.ToString();
            label1.Text = $"{result} points";

        }
    }
}
