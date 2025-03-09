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