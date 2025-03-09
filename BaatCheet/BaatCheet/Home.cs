//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace BaatCheet
//{
//    public partial class Home: Form
//    {
//        public Home()
//        {
//            InitializeComponent();
//        }

//        private void label1_Click(object sender, EventArgs e)
//        {

//        }

//        private void pictureBox5_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}
using System;
using System.Windows.Forms;

namespace BaatCheet
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.FormClosing += Home_FormClosing; // Ensure proper termination

            // Add click event handlers
            pictureBox5.Click += PictureBox5_Click; // Search icon
            pictureBox1.Click += PictureBox1_Click; // Bell icon
            pictureBox2.Click += PictureBox2_Click; // Message icon
            pictureBox3.Click += PictureBox3_Click; // Connect icon
        }
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label clicked!");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PictureBox5 clicked!");
        }


        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Ensures the application fully terminates
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show($"Searching for: {searchText}", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Notifications clicked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Messages clicked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connections clicked!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
