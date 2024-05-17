using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_test
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();

            f1.Owner = this;

            f1.StartPosition = FormStartPosition.Manual;

            f1.Location = this.Location;

            f1.Show();

            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            if (Home.acl == "Green")
            {
                pictureBox2.BackColor = Color.SeaGreen;
                pictureBox4.BackColor = Color.SeaGreen;
                
                button1.BackColor = Color.SeaGreen;
                
            }
            else if (Home.acl == "Red")
            {
                pictureBox2.BackColor = Color.LightCoral;
                pictureBox4.BackColor = Color.LightCoral;
                
                button1.BackColor = Color.LightCoral;
                
            }
            else if (Home.acl == "Blue")
            {
                pictureBox2.BackColor = Color.CornflowerBlue;
                pictureBox4.BackColor = Color.CornflowerBlue;
                
                button1.BackColor = Color.CornflowerBlue;
               
            }
        }

        private void allToSettings_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();

            f8.Owner = this;

            f8.StartPosition = FormStartPosition.Manual;

            f8.Location = this.Location;

            f8.Show();

            this.Hide();
        }
    }
}
