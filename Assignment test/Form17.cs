﻿using System;
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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form17_Load(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
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
            Form18 f18 = new Form18();

            f18.Owner = this;

            f18.StartPosition = FormStartPosition.Manual;

            f18.Location = this.Location;

            f18.Show();

            this.Hide();
        }
    }
}
