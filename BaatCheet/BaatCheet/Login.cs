using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaatCheet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Reduce flickering
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            
        }

        private string ValidateUser(string user, string pass)
        {
            try
            {
                string query = "SELECT PasswordHash FROM Users WHERE Username = @username";
                using (MySqlCommand cmd = new MySqlCommand(query, DatabaseHelper.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", user);
                    object result = cmd.ExecuteScalar(); // Get the password hash from the database

                    if (result == null)
                    {
                        return "User does not exist.";
                    }

                    string storedPassword = result.ToString();

                    if (storedPassword != pass) // Replace this with proper password hashing later
                    {
                        return "Incorrect password.";
                    }

                    return "success"; // Login successful
                }
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            BaatCheet signupForm = new BaatCheet();
            signupForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Any initialization code
        }

        private void login_button_Click_1(object sender, EventArgs e)
        {
            string usernameInput = username.Text.Trim();
            string passwordInput = password.Text;

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string loginResult = ValidateUser(usernameInput, passwordInput);

            if (loginResult == "success")
            {
                MessageBox.Show("Login Successful!");
                Home homeForm = new Home();
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(loginResult);
            }

        }
    }
}
