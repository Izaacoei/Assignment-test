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

namespace Assignment_test
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            string ans2 = textBox1.Text;

            // Check if the word "repeat" is present in the text
            bool containsRepeat = ans2.Contains("repeat");

            // Display the result in a message box
            if (containsRepeat)
            {
                Form23 f23 = new Form23();

                f23.Owner = this;

                f23.StartPosition = FormStartPosition.Manual;

                f23.Location = this.Location;

                f23.Show();

                this.Hide();
            }
            else
            {
                Form6 f6 = new Form6();

                f6.Owner = this;

                f6.StartPosition = FormStartPosition.Manual;

                f6.Location = this.Location;

                f6.Show();

                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
    }
}
