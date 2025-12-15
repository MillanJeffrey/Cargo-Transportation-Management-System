using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cargo_Transportation_Management_System
{
    public partial class Form1 : Form
    {
        // Variables for dragging functionality
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public Form1()  
        {
            InitializeComponent();
            ConfigureModernUI();
            EnableFormDragging();
        }

        private void ConfigureModernUI()
        {
            // Remove form border for modern look
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Set modern colors and shadows
            this.BackColor = Color.FromArgb(240, 244, 248);

            // Configure textboxes for modern appearance
            if (userbox != null)
            {
                userbox.Font = new Font("Segoe UI", 10F);
                userbox.BorderStyle = BorderStyle.FixedSingle;
            }

            if (textBox1 != null)
            {
                textBox1.Font = new Font("Segoe UI", 10F);
                textBox1.BorderStyle = BorderStyle.FixedSingle;
                textBox1.UseSystemPasswordChar = true; // For password field
            }

            // Add rounded corners effect (optional - requires panel)
            this.Padding = new Padding(2);
        }

        private void EnableFormDragging()
        {
            // Enable dragging from the form itself
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;

            // Also enable dragging from the title label/panel if you have one
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Label || ctrl is Panel)
                {
                    ctrl.MouseDown += Form1_MouseDown;
                    ctrl.MouseMove += Form1_MouseMove;
                    ctrl.MouseUp += Form1_MouseUp;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                int deltaX = currentCursor.X - lastCursor.X;
                int deltaY = currentCursor.Y - lastCursor.Y;
                this.Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Login button click handler
            var username = userbox.Text?.Trim();
            var password = textBox1.Text ?? string.Empty;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowModernMessageBox("Please enter both username and password.", "Validation", MessageBoxIcon.Warning);
                return;
            }

            // Demo authentication
            if (username == "admin" && password == "password")
            {
                var main = new Form2();
                main.FormClosed += (s, args) => Application.Exit();
                main.Show();
                this.Hide();
            }
            else
            {
                ShowModernMessageBox("Invalid credentials. Try admin/password.", "Login Failed", MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Cancel button with fade effect
            this.Close();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ShowModernMessageBox("Registration coming soon. Use admin/password.", "Register", MessageBoxIcon.Information);
        }

        private void ShowModernMessageBox(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
