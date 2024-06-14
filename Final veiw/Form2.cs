using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_veiw
{
    public partial class Form2 : Form
    {
        int timeMS, timeSecs, timeMin;
        bool isActive;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {   
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();

        }
    }
}
