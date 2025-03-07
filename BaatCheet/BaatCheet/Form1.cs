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
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); // Ensure the base form is painted

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Smooth edges

            // Define the rounded rectangle area
            int x = (this.ClientSize.Width - 350) / 2; // Center horizontally
            int y = 180;  // Position below the tagline
            int width = 350, height = 250, radius = 30;

            GraphicsPath path = CreateRoundedRectangle(x, y, width, height, radius);

            // Fill the rectangle with color
            Brush fillBrush = new SolidBrush(Color.FromArgb(230, 230, 230)); // Light Gray
            g.FillPath(fillBrush, path);

            // Draw the border
            Pen borderPen = new Pen(Color.Gray, 2);
            g.DrawPath(borderPen, path);
        }

        private GraphicsPath CreateRoundedRectangle(int x, int y, int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(x, y, radius, radius, 180, 90); // Top-left corner
            path.AddArc(x + width - radius, y, radius, radius, 270, 90); // Top-right
            path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90); // Bottom-right
            path.AddArc(x, y + height - radius, radius, radius, 90, 90); // Bottom-left
            path.CloseFigure(); // Connect all points

            return path;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty or add any desired behavior
        }
    }
}
