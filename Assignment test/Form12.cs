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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            f6.Owner = this;

            f6.StartPosition = FormStartPosition.Manual;

            f6.Location = this.Location;

            f6.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            f6.Owner = this;

            f6.StartPosition = FormStartPosition.Manual;

            f6.Location = this.Location;

            f6.Show();

            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            f6.Owner = this;

            f6.StartPosition = FormStartPosition.Manual;

            f6.Location = this.Location;

            f6.Show();

            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            f6.Owner = this;

            f6.StartPosition = FormStartPosition.Manual;

            f6.Location = this.Location;

            f6.Show();

            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();

            f6.Owner = this;

            f6.StartPosition = FormStartPosition.Manual;

            f6.Location = this.Location;

            f6.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();

            f13.Owner = this;

            f13.StartPosition = FormStartPosition.Manual;

            f13.Location = this.Location;

            f13.Show();

            this.Hide();
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

        private void Form12_Load(object sender, EventArgs e)
        {
            if (Home.acl == "Green")
            {
                pictureBox2.BackColor = Color.SeaGreen;
                pictureBox4.BackColor = Color.SeaGreen;
                label1.BackColor = Color.SeaGreen;
                button1.BackColor = Color.SeaGreen;
                
            }
            else if (Home.acl == "Red")
            {
                pictureBox2.BackColor = Color.LightCoral;
                pictureBox4.BackColor = Color.LightCoral;
                label1.BackColor = Color.LightCoral;
                button1.BackColor = Color.LightCoral;
               
            }
            else if (Home.acl == "Blue")
            {
                pictureBox2.BackColor = Color.CornflowerBlue;
                pictureBox4.BackColor = Color.CornflowerBlue;
                label1.BackColor = Color.CornflowerBlue;
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
