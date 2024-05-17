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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            if (Home.acl == "Green")
            {
                pictureBox2.BackColor = Color.SeaGreen;
                pictureBox4.BackColor = Color.SeaGreen;
                label1.BackColor = Color.SeaGreen;
                button1.BackColor = Color.SeaGreen;
                allToFunctions.BackColor = Color.SeaGreen;
            }
            else if (Home.acl == "Red")
            {
                pictureBox2.BackColor = Color.LightCoral;
                pictureBox4.BackColor = Color.LightCoral;
                label1.BackColor = Color.LightCoral;
                button1.BackColor = Color.LightCoral;
                allToFunctions.BackColor = Color.LightCoral;
            }
            else if (Home.acl == "Blue")
            {
                pictureBox2.BackColor = Color.CornflowerBlue;
                pictureBox4.BackColor = Color.CornflowerBlue;
                label1.BackColor = Color.CornflowerBlue;
                button1.BackColor = Color.CornflowerBlue;
                allToFunctions.BackColor = Color.CornflowerBlue;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void allToFunctions_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();

            f16.Owner = this;

            f16.StartPosition = FormStartPosition.Manual;

            f16.Location = this.Location;

            f16.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
