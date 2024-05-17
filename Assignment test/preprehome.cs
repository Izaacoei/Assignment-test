using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_test
{
    public partial class preprehome : Form
    {
        public preprehome()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);

        }
        public static class UserData
        {
            public static string Username { get; set; }
        }
        private void homeToSettings_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "")
            {
                
                MessageBox.Show("Please enter a name (It doesn't have to be your real one ;) )");

                preprehome f0 = new preprehome();
                f0.StartPosition = FormStartPosition.Manual;

                f0.Location = this.Location;
                this.Close();
                f0.Show();

            }

            if (textBox1.Text != "")
            {
                string username = textBox1.Text;

                UserData.Username = username;

                prehome f1 = new prehome();

                f1.Owner = this;

                f1.StartPosition = FormStartPosition.Manual;

                f1.Location = this.Location;

                f1.Show();

                this.Hide();
                return;
            }
            Application.Exit();

            
            Process.Start(Application.ExecutablePath);
        }
    }
}
