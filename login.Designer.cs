namespace Banking_App
{
    partial class Login
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
            email_label = new Label();
            email_input = new TextBox();
            password_label = new Label();
            password_input = new TextBox();
            login_label = new Label();
            login_button = new Button();
            show_password_input = new CheckBox();
            SuspendLayout();
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(58, 115);
            email_label.Margin = new Padding(4, 0, 4, 0);
            email_label.Name = "email_label";
            email_label.Size = new Size(60, 22);
            email_label.TabIndex = 0;
            email_label.Text = "Email";
            // 
            // email_input
            // 
            email_input.Location = new Point(60, 145);
            email_input.Margin = new Padding(4, 3, 4, 3);
            email_input.Name = "email_input";
            email_input.Size = new Size(309, 30);
            email_input.TabIndex = 1;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(58, 214);
            password_label.Margin = new Padding(4, 0, 4, 0);
            password_label.Name = "password_label";
            password_label.Size = new Size(90, 22);
            password_label.TabIndex = 0;
            password_label.Text = "Password";
            // 
            // password_input
            // 
            password_input.Location = new Point(60, 244);
            password_input.Margin = new Padding(4, 3, 4, 3);
            password_input.Name = "password_input";
            password_input.PasswordChar = '*';
            password_input.Size = new Size(309, 30);
            password_input.TabIndex = 2;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("JetBrains Mono", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_label.ForeColor = Color.FromArgb(27, 39, 51);
            login_label.Location = new Point(45, 23);
            login_label.Name = "login_label";
            login_label.Size = new Size(167, 62);
            login_label.TabIndex = 15;
            login_label.Text = "Login";
            // 
            // login_button
            // 
            login_button.BackColor = Color.FromArgb(0, 112, 224);
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.ForeColor = Color.White;
            login_button.Location = new Point(146, 352);
            login_button.Margin = new Padding(4, 3, 4, 3);
            login_button.Name = "login_button";
            login_button.Size = new Size(135, 41);
            login_button.TabIndex = 4;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // show_password_input
            // 
            show_password_input.AutoSize = true;
            show_password_input.Location = new Point(214, 283);
            show_password_input.Margin = new Padding(4, 3, 4, 3);
            show_password_input.Name = "show_password_input";
            show_password_input.RightToLeft = RightToLeft.No;
            show_password_input.Size = new Size(162, 26);
            show_password_input.TabIndex = 3;
            show_password_input.Text = "Show Password";
            show_password_input.UseVisualStyleBackColor = true;
            show_password_input.CheckedChanged += show_password_input_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(426, 426);
            Controls.Add(show_password_input);
            Controls.Add(login_button);
            Controls.Add(login_label);
            Controls.Add(password_input);
            Controls.Add(password_label);
            Controls.Add(email_input);
            Controls.Add(email_label);
            Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Bold);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label email_label;
        private TextBox email_input;
        private Label password_label;
        private TextBox password_input;
        private Button login_button;
        private CheckBox show_password_input;
        private Label login_label;
    }
}