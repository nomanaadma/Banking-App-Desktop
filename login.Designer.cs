namespace Banking_App
{
    partial class login
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
            login_button = new Button();
            SuspendLayout();
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Location = new Point(255, 97);
            email_label.Name = "email_label";
            email_label.Size = new Size(46, 20);
            email_label.TabIndex = 0;
            email_label.Text = "Email";
            // 
            // email_input
            // 
            email_input.Location = new Point(255, 134);
            email_input.Name = "email_input";
            email_input.Size = new Size(248, 27);
            email_input.TabIndex = 1;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(255, 188);
            password_label.Name = "password_label";
            password_label.Size = new Size(70, 20);
            password_label.TabIndex = 2;
            password_label.Text = "Password";
            // 
            // password_input
            // 
            password_input.Location = new Point(255, 224);
            password_input.Name = "password_input";
            password_input.Size = new Size(248, 27);
            password_input.TabIndex = 3;
            // 
            // login_button
            // 
            login_button.Location = new Point(295, 297);
            login_button.Name = "login_button";
            login_button.Size = new Size(157, 29);
            login_button.TabIndex = 4;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(login_button);
            Controls.Add(password_input);
            Controls.Add(password_label);
            Controls.Add(email_input);
            Controls.Add(email_label);
            Name = "login";
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
    }
}