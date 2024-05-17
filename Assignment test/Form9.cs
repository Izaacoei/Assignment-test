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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ans1 = textBox1.Text;
            if (ans1 == "int amount = 5;")
            {
                Form10 f10 = new Form10();

                f10.Owner = this;

                f10.StartPosition = FormStartPosition.Manual;

                f10.Location = this.Location;

                f10.Show();

                this.Hide();
            }
            else {
                Form6 f6 = new Form6();

                f6.Owner = this;

                f6.StartPosition = FormStartPosition.Manual;

                f6.Location = this.Location;

                f6.Show();

                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void allToSettings_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();

            f8.Owner = this;

            f8.StartPosition = FormStartPosition.Manual;

            f8.Location = this.Location;

            f8.Show();

            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
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
    }
}
