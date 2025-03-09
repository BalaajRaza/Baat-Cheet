using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BaatCheet
{
    public partial class BaatCheet : Form
    {
        public BaatCheet()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Reduce flickering
            //InitializeCustomComponents();
        }

        //private void InitializeCustomComponents()
        //{
        //    // Labels
        //    Label lblUsername = CreateLabel("Username:", 420, 200);
        //    Label lblPassword = CreateLabel("Password:", 420, 270);
        //    Label lblConfirmPassword = CreateLabel("Confirm Password:", 420, 340);

        //    // Textboxes
        //    TextBox txtUsername = CreateRoundedTextBox(420, 220);
        //    TextBox txtPassword = CreateRoundedTextBox(420, 290);
        //    TextBox txtConfirmPassword = CreateRoundedTextBox(420, 360);
        //    txtPassword.UseSystemPasswordChar = true;
        //    txtConfirmPassword.UseSystemPasswordChar = true;

        //    // Add controls
        //    this.Controls.Add(lblUsername);
        //    this.Controls.Add(lblPassword);
        //    this.Controls.Add(lblConfirmPassword);
        //    this.Controls.Add(txtUsername);
        //    this.Controls.Add(txtPassword);
        //    this.Controls.Add(txtConfirmPassword);
        //}


        //private Label CreateLabel(string text, int x, int y)
        //{
        //    return new Label
        //    {
        //        Text = text,
        //        Font = new Font("Arial", 10, FontStyle.Bold),
        //        Location = new Point(x, y),
        //        AutoSize = true,
        //        BackColor = Color.Transparent  // Makes the background inherit from parent
        //    };
        //}


        //private TextBox CreateRoundedTextBox(int x, int y)
        //{
        //    TextBox textBox = new TextBox
        //    {
        //        Location = new Point(x, y),
        //        Size = new Size(250, 30),
        //        BorderStyle = BorderStyle.None,
        //        Font = new Font("Arial", 10)
        //    };

        //    Panel panel = new Panel
        //    {
        //        Location = new Point(x - 5, y - 5),
        //        Size = new Size(260, 40),
        //        BackColor = Color.White
        //    };
        //    panel.Paint += (s, e) => DrawRoundedRectangle(e.Graphics, panel.ClientRectangle);

        //    this.Controls.Add(panel);
        //    panel.Controls.Add(textBox);
        //    textBox.BringToFront();

        //    return textBox;
        //}

        //private void DrawRoundedRectangle(Graphics g, Rectangle rect)
        //{
        //    using (GraphicsPath path = new GraphicsPath())
        //    using (Pen borderPen = new Pen(Color.Gray, 2))
        //    {
        //        int radius = 15;
        //        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        //        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
        //        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        //        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
        //        path.CloseFigure();
        //        g.SmoothingMode = SmoothingMode.AntiAlias;
        //        g.DrawPath(borderPen, path);
        //    }
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    base.OnPaint(e);
        //    Graphics g = e.Graphics;
        //    g.SmoothingMode = SmoothingMode.AntiAlias;
        //    int width = 300, height = 330, radius = 30;
        //    int x = 400, y = 160;
        //    //using (GraphicsPath path = CreateRoundedRectangle(x, y, width, height, radius))
        //    //using (Brush fillBrush = new SolidBrush(Color.FromArgb(230, 230, 230)))
        //    //using (Pen borderPen = new Pen(Color.Gray, 2))
        //    //{
        //    //    g.FillPath(fillBrush, path);
        //    //    g.DrawPath(borderPen, path);
        //    //}
        //}

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
        private void label1_Click(object sender, EventArgs e)
       {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm(); // Create LoginForm instance
            //loginForm.Show(); // Show Login Page
            //this.Close(); // Hide Signup Page
            if (Application.OpenForms["LoginForm"] == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }
    }
}
