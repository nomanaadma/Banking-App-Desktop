namespace Banking_App
{
    partial class Signup
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
            full_name_label = new Label();
            full_name_input = new TextBox();
            email_label = new Label();
            email_input = new TextBox();
            password_label = new Label();
            password_input = new TextBox();
            show_password_input = new CheckBox();
            signup_button = new Button();
            label1 = new Label();
            cnic_input = new TextBox();
            signup_label = new Label();
            SuspendLayout();
            // 
            // full_name_label
            // 
            full_name_label.AutoSize = true;
            full_name_label.Location = new Point(341, 115);
            full_name_label.Margin = new Padding(4, 0, 4, 0);
            full_name_label.Name = "full_name_label";
            full_name_label.Size = new Size(100, 22);
            full_name_label.TabIndex = 0;
            full_name_label.Text = "Full Name";
            // 
            // full_name_input
            // 
            full_name_input.Location = new Point(345, 145);
            full_name_input.Margin = new Padding(4, 3, 4, 3);
            full_name_input.Name = "full_name_input";
            full_name_input.Size = new Size(258, 30);
            full_name_input.TabIndex = 4;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(35, 115);
            email_label.Margin = new Padding(4, 0, 4, 0);
            email_label.Name = "email_label";
            email_label.Size = new Size(60, 22);
            email_label.TabIndex = 0;
            email_label.Text = "Email";
            // 
            // email_input
            // 
            email_input.BackColor = Color.White;
            email_input.BorderStyle = BorderStyle.FixedSingle;
            email_input.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Bold);
            email_input.Location = new Point(38, 145);
            email_input.Margin = new Padding(4, 3, 4, 3);
            email_input.Name = "email_input";
            email_input.Size = new Size(258, 30);
            email_input.TabIndex = 1;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(34, 196);
            password_label.Margin = new Padding(4, 0, 4, 0);
            password_label.Name = "password_label";
            password_label.Size = new Size(90, 22);
            password_label.TabIndex = 0;
            password_label.Text = "Password";
            // 
            // password_input
            // 
            password_input.Location = new Point(38, 225);
            password_input.Margin = new Padding(4, 3, 4, 3);
            password_input.Name = "password_input";
            password_input.PasswordChar = '*';
            password_input.Size = new Size(258, 30);
            password_input.TabIndex = 2;
            // 
            // show_password_input
            // 
            show_password_input.AutoSize = true;
            show_password_input.Location = new Point(142, 261);
            show_password_input.Margin = new Padding(4, 3, 4, 3);
            show_password_input.Name = "show_password_input";
            show_password_input.RightToLeft = RightToLeft.No;
            show_password_input.Size = new Size(162, 26);
            show_password_input.TabIndex = 3;
            show_password_input.Text = "Show Password";
            show_password_input.UseVisualStyleBackColor = true;
            show_password_input.CheckedChanged += show_password_input_CheckedChanged;
            // 
            // signup_button
            // 
            signup_button.BackColor = Color.FromArgb(0, 112, 224);
            signup_button.FlatStyle = FlatStyle.Flat;
            signup_button.ForeColor = Color.White;
            signup_button.Location = new Point(468, 278);
            signup_button.Margin = new Padding(4, 3, 4, 3);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(135, 41);
            signup_button.TabIndex = 6;
            signup_button.Text = "Signup";
            signup_button.UseVisualStyleBackColor = false;
            signup_button.Click += signup_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 195);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 0;
            label1.Text = "CNIC";
            // 
            // cnic_input
            // 
            cnic_input.Location = new Point(345, 225);
            cnic_input.Margin = new Padding(4, 3, 4, 3);
            cnic_input.Name = "cnic_input";
            cnic_input.Size = new Size(258, 30);
            cnic_input.TabIndex = 5;
            // 
            // signup_label
            // 
            signup_label.AutoSize = true;
            signup_label.Font = new Font("JetBrains Mono", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_label.ForeColor = Color.FromArgb(27, 39, 51);
            signup_label.Location = new Point(30, 24);
            signup_label.Name = "signup_label";
            signup_label.Size = new Size(195, 62);
            signup_label.TabIndex = 14;
            signup_label.Text = "SignUp";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(657, 383);
            Controls.Add(signup_label);
            Controls.Add(cnic_input);
            Controls.Add(label1);
            Controls.Add(signup_button);
            Controls.Add(show_password_input);
            Controls.Add(password_input);
            Controls.Add(password_label);
            Controls.Add(email_input);
            Controls.Add(email_label);
            Controls.Add(full_name_input);
            Controls.Add(full_name_label);
            Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label full_name_label;
        private TextBox full_name_input;
        private Label email_label;
        private TextBox email_input;
        private Label password_label;
        private TextBox password_input;
        private CheckBox show_password_input;
        private Button signup_button;
        private Label label1;
        private TextBox cnic_input;
        private Label signup_label;
    }
}