//using System;
//using System.Drawing;
//using System.Drawing.Drawing2D;
//using System.Windows.Forms;

//namespace BaatCheet
//{
//    public partial class BaatCheet : Form
//    {
//        public BaatCheet()
//        {
//            InitializeComponent();
//            this.DoubleBuffered = true; // Reduce flickering
//        }

//        private void label1_Click(object sender, EventArgs e){}

//        private void textBox2_TextChanged(object sender, EventArgs e){}

//        private void button1_Click(object sender, EventArgs e)
//        {
//            //LoginForm loginForm = new LoginForm(); // Create LoginForm instance
//            //loginForm.Show(); // Show Login Page
//            //this.Close(); // Hide Signup Page
//            if (Application.OpenForms["LoginForm"] == null)
//            {
//                LoginForm loginForm = new LoginForm();
//                loginForm.Show();
//                this.Hide();
//            }
//        }

//        private void textBox3_TextChanged(object sender, EventArgs e){}

//        private void button2_Click(object sender, EventArgs e)
//        {
//            LoginForm LoginForm = new LoginForm();
//            LoginForm.Show();
//            this.Hide();
//        }

//        private void textBox4_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}

using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaatCheet
{
    public partial class BaatCheet : Form
    {
        public BaatCheet()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Reduce flickering
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            string usernameInput = username.Text.Trim();
            string passwordInput = pass.Text;
            string confirmPasswordInput = confirmpass.Text;

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput) || string.IsNullOrEmpty(confirmPasswordInput))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            if (passwordInput != confirmPasswordInput)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            try
            {
                string query = "INSERT INTO Users (Username, PasswordHash) VALUES (@username, @password)";

                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", usernameInput);
                    cmd.Parameters.AddWithValue("@password", passwordInput); // Storing plain text password (for now)

                    int rowsAffected = cmd.ExecuteNonQuery(); // Execute the insert query

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Signup successful!");
                        this.Hide();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Signup failed. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void login_redirect_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

