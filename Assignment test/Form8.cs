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
    public partial class Form8 : Form
    {
       
        public Form8()
        {
            InitializeComponent();
           
        }

        public void allToVariables_Click(object sender, EventArgs e)
        {
            Home.acl = "Green";
            pictureBox2.BackColor = Color.SeaGreen;
            pictureBox4.BackColor = Color.SeaGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home f1 = new Home();

            f1.Owner = this;

            f1.StartPosition = FormStartPosition.Manual;

            f1.Location = this.Location;

            f1.Show();

            this.Hide();
        }

        private void allToIfElse_Click(object sender, EventArgs e)
        {
            Home.acl = "Red";
            pictureBox2.BackColor = Color.LightCoral;
            pictureBox4.BackColor = Color.LightCoral;
        }

        private void allToLoops_Click(object sender, EventArgs e)
        {
            Home.acl = "Blue";
            pictureBox2.BackColor = Color.CornflowerBlue;
            pictureBox4.BackColor = Color.CornflowerBlue;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (Home.acl == "Green")
            {
                pictureBox2.BackColor = Color.SeaGreen;
                pictureBox4.BackColor = Color.SeaGreen;
               
            }
            else if (Home.acl == "Red")
            {
                pictureBox2.BackColor = Color.LightCoral;
                pictureBox4.BackColor = Color.LightCoral;
                
            }
            else if (Home.acl == "Blue")
            {
                pictureBox2.BackColor = Color.CornflowerBlue;
                pictureBox4.BackColor = Color.CornflowerBlue;
                
            }
        }

        private void allToSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
