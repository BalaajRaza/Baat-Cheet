using System;

namespace BaatCheet
{
    partial class BaatCheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaatCheet));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.signup_button = new System.Windows.Forms.Button();
            this.login_redirect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(446, 271);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 20);
            this.textBox1.TabIndex = 6;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(477, 367);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(325, 19);
            this.username.TabIndex = 7;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pass.ForeColor = System.Drawing.Color.White;
            this.pass.Location = new System.Drawing.Point(477, 463);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(325, 19);
            this.pass.TabIndex = 8;
            this.pass.TextChanged += new System.EventHandler(this.pass_TextChanged);
            // 
            // confirmpass
            // 
            this.confirmpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.confirmpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmpass.ForeColor = System.Drawing.Color.White;
            this.confirmpass.Location = new System.Drawing.Point(477, 558);
            this.confirmpass.Margin = new System.Windows.Forms.Padding(4);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.Size = new System.Drawing.Size(325, 19);
            this.confirmpass.TabIndex = 9;
            this.confirmpass.TextChanged += new System.EventHandler(this.confirmpass_TextChanged);
            // 
            // signup_button
            // 
            this.signup_button.AutoEllipsis = true;
            this.signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.signup_button.FlatAppearance.BorderSize = 0;
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.ForeColor = System.Drawing.Color.White;
            this.signup_button.Location = new System.Drawing.Point(584, 639);
            this.signup_button.Margin = new System.Windows.Forms.Padding(4);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(109, 35);
            this.signup_button.TabIndex = 10;
            this.signup_button.Text = "Signup";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // login_redirect
            // 
            this.login_redirect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.login_redirect.FlatAppearance.BorderSize = 0;
            this.login_redirect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_redirect.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_redirect.ForeColor = System.Drawing.Color.White;
            this.login_redirect.Location = new System.Drawing.Point(448, 710);
            this.login_redirect.Name = "login_redirect";
            this.login_redirect.Size = new System.Drawing.Size(394, 31);
            this.login_redirect.TabIndex = 11;
            this.login_redirect.Text = "Already have an account";
            this.login_redirect.UseVisualStyleBackColor = false;
            this.login_redirect.Click += new System.EventHandler(this.login_redirect_Click);
            // 
            // BaatCheet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1202, 753);
            this.Controls.Add(this.login_redirect);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.username);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaatCheet";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void username_TextChanged(object sender, EventArgs e)
        {
            // Handle username text changed event
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            // Handle password text changed event
        }

        private void confirmpass_TextChanged(object sender, EventArgs e)
        {
            // Handle confirm password text changed event
        }
    

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button login_redirect;
    }
}
    


