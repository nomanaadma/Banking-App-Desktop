namespace Banking_App
{
    partial class signup
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
            SuspendLayout();
            // 
            // full_name_label
            // 
            full_name_label.AutoSize = true;
            full_name_label.Location = new Point(55, 27);
            full_name_label.Name = "full_name_label";
            full_name_label.Size = new Size(76, 20);
            full_name_label.TabIndex = 0;
            full_name_label.Text = "Full Name";
            // 
            // full_name_input
            // 
            full_name_input.Location = new Point(55, 60);
            full_name_input.Name = "full_name_input";
            full_name_input.Size = new Size(299, 27);
            full_name_input.TabIndex = 1;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(55, 107);
            email_label.Name = "email_label";
            email_label.Size = new Size(46, 20);
            email_label.TabIndex = 2;
            email_label.Text = "Email";
            // 
            // email_input
            // 
            email_input.Location = new Point(55, 141);
            email_input.Name = "email_input";
            email_input.Size = new Size(299, 27);
            email_input.TabIndex = 3;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(55, 196);
            password_label.Name = "password_label";
            password_label.Size = new Size(70, 20);
            password_label.TabIndex = 4;
            password_label.Text = "Password";
            // 
            // password_input
            // 
            password_input.Location = new Point(55, 235);
            password_input.Name = "password_input";
            password_input.PasswordChar = '*';
            password_input.Size = new Size(299, 27);
            password_input.TabIndex = 5;
            // 
            // show_password_input
            // 
            show_password_input.AutoSize = true;
            show_password_input.Location = new Point(222, 286);
            show_password_input.Name = "show_password_input";
            show_password_input.RightToLeft = RightToLeft.No;
            show_password_input.Size = new Size(132, 24);
            show_password_input.TabIndex = 6;
            show_password_input.Text = "Show Password";
            show_password_input.UseVisualStyleBackColor = true;
            show_password_input.CheckedChanged += show_password_input_CheckedChanged;
            // 
            // signup_button
            // 
            signup_button.Location = new Point(538, 117);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(193, 29);
            signup_button.TabIndex = 9;
            signup_button.Text = "Signup";
            signup_button.UseVisualStyleBackColor = true;
            signup_button.Click += signup_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(448, 27);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 12;
            label1.Text = "CNIC";
            // 
            // cnic_input
            // 
            cnic_input.Location = new Point(448, 60);
            cnic_input.Name = "cnic_input";
            cnic_input.Size = new Size(283, 27);
            cnic_input.TabIndex = 13;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "signup";
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
    }
}