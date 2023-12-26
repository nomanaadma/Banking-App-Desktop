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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(banking_app));
            login = new Button();
            signup_button = new Button();
            atm = new Button();
            logo_box = new PictureBox();
            get_started_lable = new Label();
            ((System.ComponentModel.ISupportInitialize)logo_box).BeginInit();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(0, 112, 224);
            login.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            login.FlatStyle = FlatStyle.Flat;
            login.ForeColor = Color.WhiteSmoke;
            login.Location = new Point(69, 317);
            login.Margin = new Padding(4, 3, 4, 3);
            login.Name = "login";
            login.Size = new Size(256, 44);
            login.TabIndex = 0;
            login.Text = "Login";
            login.UseMnemonic = false;
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // signup_button
            // 
            signup_button.BackColor = Color.FromArgb(0, 0, 15, 255);
            signup_button.FlatAppearance.BorderColor = Color.FromArgb(0, 112, 224);
            signup_button.FlatStyle = FlatStyle.Popup;
            signup_button.ForeColor = Color.Black;
            signup_button.Location = new Point(69, 243);
            signup_button.Margin = new Padding(4, 3, 4, 3);
            signup_button.Name = "signup_button";
            signup_button.Size = new Size(256, 44);
            signup_button.TabIndex = 1;
            signup_button.Text = "Signup";
            signup_button.UseVisualStyleBackColor = false;
            signup_button.Click += signup_Click;
            // 
            // atm
            // 
            atm.BackColor = Color.FromArgb(27, 39, 51);
            atm.FlatStyle = FlatStyle.Popup;
            atm.ForeColor = Color.White;
            atm.Location = new Point(69, 393);
            atm.Margin = new Padding(4, 3, 4, 3);
            atm.Name = "atm";
            atm.Size = new Size(256, 44);
            atm.TabIndex = 2;
            atm.Text = "Atm";
            atm.UseVisualStyleBackColor = false;
            atm.Click += atm_Click;
            // 
            // logo_box
            // 
            logo_box.Image = (Image)resources.GetObject("logo_box.Image");
            logo_box.Location = new Point(37, 67);
            logo_box.Name = "logo_box";
            logo_box.Size = new Size(316, 62);
            logo_box.SizeMode = PictureBoxSizeMode.Zoom;
            logo_box.TabIndex = 3;
            logo_box.TabStop = false;
            // 
            // get_started_lable
            // 
            get_started_lable.AutoSize = true;
            get_started_lable.Location = new Point(141, 193);
            get_started_lable.Name = "get_started_lable";
            get_started_lable.Size = new Size(120, 22);
            get_started_lable.TabIndex = 4;
            get_started_lable.Text = "Get Started";
            // 
            // banking_app
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(390, 544);
            Controls.Add(get_started_lable);
            Controls.Add(logo_box);
            Controls.Add(atm);
            Controls.Add(signup_button);
            Controls.Add(login);
            Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "banking_app";
            Text = "N&H Banking App";
            Load += banking_app_Load;
            ((System.ComponentModel.ISupportInitialize)logo_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private Button signup_button;
        private Button atm;
        private PictureBox logo_box;
        private Label get_started_lable;
    }
}
