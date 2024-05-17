using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment_test.preprehome;

namespace Assignment_test
{
    
    public partial class Home : Form
    {

        public static string acl = "CornflowerBlue";
        public Home()
        {
            InitializeComponent();
            string username = UserData.Username;
            Menu.Text = "Welcome back \n" + username;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (Home.acl == "Green")
            {
                pictureBox2.BackColor = Color.SeaGreen;
                Menu.BackColor = Color.SeaGreen;
                homeToCourse.BackColor = Color.SeaGreen;
                homeToSettings.BackColor = Color.SeaGreen;
                homeToAll.BackColor = Color.SeaGreen;
            }
            else if (Home.acl == "Red")
            {
                pictureBox2.BackColor = Color.LightCoral;
                Menu.BackColor = Color.LightCoral;
                homeToCourse.BackColor = Color.LightCoral;
                homeToSettings.BackColor = Color.LightCoral;
                homeToAll.BackColor = Color.LightCoral;
            }
            else if (Home.acl == "Blue")
            {
                pictureBox2.BackColor = Color.CornflowerBlue;
                Menu.BackColor = Color.CornflowerBlue;
                homeToCourse.BackColor = Color.CornflowerBlue;
                homeToSettings.BackColor = Color.CornflowerBlue;
                homeToAll.BackColor = Color.CornflowerBlue;
            }
        }

        private void homeToAll_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Owner = this;

            f2.StartPosition = FormStartPosition.Manual;

            f2.Location = this.Location;

            f2.Show();

            this.Hide();
        }

        private void homeToSettings_Click(object sender, EventArgs e)
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
