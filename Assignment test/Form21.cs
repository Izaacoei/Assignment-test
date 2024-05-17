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
    public partial class Form21 : Form
    {
        PictureBox[] pictures = new PictureBox[4];
        public Form21()
        {
            InitializeComponent();
            //The 4 here is dependant on how many rows in the table            

            for (int i = 0; i < 4; i++)

            {

                pictures[i] = new PictureBox();

                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;

                pictures[i].AllowDrop = true;

                pictures[i].DragEnter += new DragEventHandler(pictures_DragEnter);

                pictures[i].DragDrop += new DragEventHandler(pictures_DragDrop);

                tblCodeArea.Controls.Add(pictures[i]);

            }
        }

        private void Form21_Load(object sender, EventArgs e)
        {
            if (Home.acl == "Green")
            {
                pictureBox2.BackColor = Color.SeaGreen;
                pictureBox4.BackColor = Color.SeaGreen;
                label6.BackColor = Color.SeaGreen;
                button1.BackColor = Color.SeaGreen;
                allToFunctions.BackColor = Color.SeaGreen;
            }
            else if (Home.acl == "Red")
            {
                pictureBox2.BackColor = Color.LightCoral;
                pictureBox4.BackColor = Color.LightCoral;
                label6.BackColor = Color.LightCoral;
                button1.BackColor = Color.LightCoral;
                allToFunctions.BackColor = Color.LightCoral;
            }
            else if (Home.acl == "Blue")
            {
                pictureBox2.BackColor = Color.CornflowerBlue;
                pictureBox4.BackColor = Color.CornflowerBlue;
                label6.BackColor = Color.CornflowerBlue;
                button1.BackColor = Color.CornflowerBlue;
                allToFunctions.BackColor = Color.CornflowerBlue;
            }
        }

        private void codeBlock_MouseDown(object sender, MouseEventArgs e)

        {

            //Defines sender as a picturebox so we can use it

            PictureBox codeBlock = sender as PictureBox;
            //Define a data object and store the image and the tag

            DataObject dragImage = new DataObject();

            dragImage.SetData(DataFormats.Bitmap, true, codeBlock.Image);

            dragImage.SetData(DataFormats.Text, true, codeBlock.Tag);



            //Copies the data object as we drag

            DoDragDrop(dragImage, DragDropEffects.Copy);


        }
        private void pictures_DragEnter(object sender, DragEventArgs e)

        {

            e.Effect = e.AllowedEffect;

        }
        private void pictures_DragDrop(object sender, DragEventArgs e)

        {

            PictureBox picture = sender as PictureBox;
            picture.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

            picture.Tag = e.Data.GetData(TextDataFormat.Text.ToString());
            lblList.Text = "";



            for (int i = 0; i < 4; i++)

            {

                lblList.Text = String.Format("{0}{1}\n", lblList.Text, pictures[i].Tag);



            }

        }

        private void pbWhenClicked_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void allToFunctions_Click(object sender, EventArgs e)
        {
            Form22 f22 = new Form22();

            f22.Owner = this;

            f22.StartPosition = FormStartPosition.Manual;

            f22.Location = this.Location;

            f22.Show();

            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.StartPosition = FormStartPosition.Manual;

            f21.Location = this.Location;
            this.Close();
            f21.Show();
        }
    }
}
