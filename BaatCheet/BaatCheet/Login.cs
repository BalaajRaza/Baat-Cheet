using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BaatCheet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Reduce flickering
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Labels
            Label lblUsername = CreateLabel("Username:", 420, 250);
            Label lblPassword = CreateLabel("Password:", 420, 320);

            // Textboxes
            TextBox txtUsername = CreateRoundedTextBox(420, 270);
            TextBox txtPassword = CreateRoundedTextBox(420, 340);
            txtPassword.UseSystemPasswordChar = true;

            // Login Button
            Button btnLogin = new Button
            {
                Text = "Login",
                Font = new Font("Arial", 16, FontStyle.Bold),
                Size = new Size(100, 40),
                ForeColor = Color.Gray,
                Location = new Point(500, 490),  
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += new EventHandler(btnLogin_Click);

            // Go to Signup Button
            Button btnGoToSignup = new Button
            {
                Text = "Go to Signup",
                Font = new Font("Arial", 8, FontStyle.Regular),
                Size = new Size(90, 25),
                Location = new Point(585, 380),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnGoToSignup.Click += new EventHandler(btnGoToSignup_Click);

            // Add controls
            this.Controls.Add(lblUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtUsername);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
            this.Controls.Add(btnGoToSignup);
        }

        private Label CreateLabel(string text, int x, int y)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(x, y),
                AutoSize = true,
                BackColor = Color.Transparent
            };
        }

        private TextBox CreateRoundedTextBox(int x, int y)
        {
            TextBox textBox = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(250, 30),
                BorderStyle = BorderStyle.None,
                Font = new Font("Arial", 10)
            };

            Panel panel = new Panel
            {
                Location = new Point(x - 5, y - 5),
                Size = new Size(260, 40),
                BackColor = Color.White
            };
            panel.Paint += (s, e) => DrawRoundedRectangle(e.Graphics, panel.ClientRectangle);

            this.Controls.Add(panel);
            panel.Controls.Add(textBox);
            textBox.BringToFront();

            return textBox;
        }

        private void DrawRoundedRectangle(Graphics g, Rectangle rect)
        {
            using (GraphicsPath path = new GraphicsPath())
            using (Pen borderPen = new Pen(Color.Gray, 2))
            {
                int radius = 15;
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawPath(borderPen, path);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int width = 300, height = 320, radius = 30;
            int x = 400, y = 220;
            using (GraphicsPath path = CreateRoundedRectangle(x, y, width, height, radius))
            using (Brush fillBrush = new SolidBrush(Color.FromArgb(230, 230, 230)))
            using (Pen borderPen = new Pen(Color.Gray, 2))
            {
                g.FillPath(fillBrush, path);
                g.DrawPath(borderPen, path);
            }
        }

        private GraphicsPath CreateRoundedRectangle(int x, int y, int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(x, y, radius, radius, 180, 90);
            path.AddArc(x + width - radius, y, radius, radius, 270, 90);
            path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
            path.AddArc(x, y + height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidLogin())
            {
                MessageBox.Show("Login Successful!");
                Home homeForm = new Home(); // Create an instance of Home
                homeForm.Show(); // Show the Home form
                this.Hide(); // Hide the Login form
            }
            else
            {
                MessageBox.Show("Invalid credentials, try again.");
            }
        }

        private bool IsValidLogin()
        {
            // Dummy function, replace with actual login validation
            return true;
        }


        private void btnGoToSignup_Click(object sender, EventArgs e)
        {
            BaatCheet signupForm = new BaatCheet(); // Navigate to Signup Page
            signupForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
