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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form19 f19 = new Form19();

            f19.Owner = this;

            f19.StartPosition = FormStartPosition.Manual;

            f19.Location = this.Location;

            f19.Show();

            this.Hide();
        }

        private void homeToCourse_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.Owner = this;

            f3.StartPosition = FormStartPosition.Manual;

            f3.Location = this.Location;

            f3.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void allToFunctions_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();

            f14.Owner = this;

            f14.StartPosition = FormStartPosition.Manual;

            f14.Location = this.Location;

            f14.Show();

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void allToIfElse_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();

            f15.Owner = this;

            f15.StartPosition = FormStartPosition.Manual;

            f15.Location = this.Location;

            f15.Show();

            this.Hide();
        }
    }
}
