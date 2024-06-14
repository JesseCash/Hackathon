using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_veiw
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> users;
        public Form1()
        {
            InitializeComponent();
            LoadUsersFromCsv("users.csv");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadUsersFromCsv(string filepath)
        {
            users = new Dictionary<string, string>();
            try
            {
                using (var reader = new StreamReader(filepath))
                {
                    using (var csv = new CsvHelper.CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                    {
                        while (csv.Read())
                        {
                            var username = csv.GetField<string>("username");
                            var password = csv.GetField<string>("password");
                            users[username] = password;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Error: File '{filepath}' not found.");
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("Error: CSV file must contain 'username' and 'password' columns.");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
