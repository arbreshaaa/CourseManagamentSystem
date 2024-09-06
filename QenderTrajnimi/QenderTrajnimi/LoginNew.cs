using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QenderTrajnimi
{
    public partial class LoginNew : Form
    {
        private string placeholderUsername = "Username";
        private string placeholderPassword = "Password";
        private string placeholderbutton = "Log In";

        public LoginNew()
        {
            InitializeComponent();
        }

        private void LoginNew_Load(object sender, EventArgs e)
        {
            // Set form background color with a gradient effect
            this.Paint += (s, args) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    this.ClientRectangle, Color.SkyBlue, Color.DarkSlateBlue, 45F))
                {
                    args.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            };

            // Style buttons
            button1.BackColor = Color.MediumSlateBlue;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Arial", 11, FontStyle.Bold);
            button1.Padding = new Padding(10);
            button1.Text = placeholderbutton;

            // Style text boxes
            ConfigureTextBox(textBox1, placeholderUsername);
            ConfigureTextBox(textBox2, placeholderPassword, true);
        }

        private void ConfigureTextBox(TextBox textBox, string placeholder, bool isPassword = false)
        {
            textBox.BackColor = Color.WhiteSmoke;
            textBox.ForeColor = Color.DarkSlateBlue;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Padding = new Padding(5);
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (s, args) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                    if (isPassword) textBox.UseSystemPasswordChar = true;
                }
            };
            textBox.Leave += (s, args) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                    if (isPassword) textBox.UseSystemPasswordChar = false;
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=ARBRESHA;Initial Catalog=QenderTrajnimiDatabase;Integrated Security=True;"))
            {
                con.Open();
                string select = "SELECT * FROM Useret WHERE username=@username AND password=@password";
                using (SqlCommand cmd = new SqlCommand(select, con))
                {
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("You have been logged in successfully!");
                            textBox1.Clear();
                            textBox2.Clear();
                            Form frm = new Home();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username or Password is incorrect, please try again!");
                        }
                    }
                }
            }
        }

        private void LoginNew_Load_1(object sender, EventArgs e)
        {

        }
    }
}