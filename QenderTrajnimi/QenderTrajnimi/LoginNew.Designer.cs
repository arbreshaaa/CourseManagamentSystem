namespace QenderTrajnimi
{
    partial class LoginNew
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label(); // Label for Username
            this.labelPassword = new System.Windows.Forms.Label(); // Label for Password
            this.labelWelcome = new System.Windows.Forms.Label();  // Label for Welcome message
            this.SuspendLayout();

            // 
            // Gradient background
            // 
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginNew_Paint);

            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.ForeColor = System.Drawing.Color.White; // White text
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent; // Transparent background
            this.labelWelcome.Location = new System.Drawing.Point(250, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(300, 32);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Welcome Back";

            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Arial", 12F);
            this.labelUsername.ForeColor = System.Drawing.Color.White; // White text
            this.labelUsername.BackColor = System.Drawing.Color.Transparent; // Transparent background
            this.labelUsername.Location = new System.Drawing.Point(250, 95); // Adjust position
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(95, 23);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username:";

            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.labelPassword.ForeColor = System.Drawing.Color.White; // White text
            this.labelPassword.BackColor = System.Drawing.Color.Transparent; // Transparent background
            this.labelPassword.Location = new System.Drawing.Point(250, 155); // Adjust position
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(91, 23);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";

            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 84); // Moved a little to the right for space
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 39);
            this.textBox1.TabIndex = 0;

            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(380, 143); // Moved a little to the right for space
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 35);
            this.textBox2.TabIndex = 1;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // 
            // LoginNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "LoginNew";
            this.Text = "LoginNew";
            this.Load += new System.EventHandler(this.LoginNew_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelWelcome;

        // Event to handle blue gradient background
        private void LoginNew_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle, System.Drawing.Color.SkyBlue, System.Drawing.Color.DarkSlateBlue, 45F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
