namespace Banking_App
{
    partial class banking_app
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            login = new Button();
            signup_button = new Button();
            atm = new Button();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(70, 184);
            login.Name = "login";
            login.Size = new Size(205, 29);
            login.TabIndex = 0;
            login.Text = "Login";
            login.TextAlign = ContentAlignment.TopCenter;
            login.UseMnemonic = false;
            login.UseVisualStyleBackColor = true;
            // 
            // signup_button
            // 
            signup_button.Location = new Point(315, 184);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(189, 29);
            signup_button.TabIndex = 1;
            signup_button.Text = "Signup";
            signup_button.UseVisualStyleBackColor = true;
            signup_button.Click += signup_Click;
            // 
            // atm
            // 
            atm.Location = new Point(547, 184);
            atm.Name = "atm";
            atm.Size = new Size(181, 29);
            atm.TabIndex = 2;
            atm.Text = "Atm";
            atm.UseVisualStyleBackColor = true;
            // 
            // banking_app
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(atm);
            Controls.Add(signup_button);
            Controls.Add(login);
            Name = "banking_app";
            Text = "Banking App";
            Load += banking_app_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button login;
        private Button signup_button;
        private Button atm;
    }
}
