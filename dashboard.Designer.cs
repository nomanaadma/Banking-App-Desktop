namespace Banking_App
{
    partial class dashboard
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
            welcome_label = new Label();
            balance_label = new Label();
            user_label = new Label();
            amount_label = new Label();
            add_money_button = new Button();
            transactions_button = new Button();
            send_money_button = new Button();
            SuspendLayout();
            // 
            // welcome_label
            // 
            welcome_label.AutoSize = true;
            welcome_label.Font = new Font("Segoe UI", 15F);
            welcome_label.Location = new Point(24, 28);
            welcome_label.Margin = new Padding(4, 0, 4, 0);
            welcome_label.Name = "welcome_label";
            welcome_label.Size = new Size(118, 35);
            welcome_label.TabIndex = 0;
            welcome_label.Text = "Welcome";
            welcome_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // balance_label
            // 
            balance_label.AutoSize = true;
            balance_label.Font = new Font("Segoe UI", 12F);
            balance_label.ForeColor = Color.Black;
            balance_label.Location = new Point(27, 141);
            balance_label.Margin = new Padding(4, 0, 4, 0);
            balance_label.Name = "balance_label";
            balance_label.Size = new Size(107, 28);
            balance_label.TabIndex = 1;
            balance_label.Text = "Balance: Rs";
            balance_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new Font("Segoe UI", 22F);
            user_label.ForeColor = Color.FromArgb(27, 39, 51);
            user_label.Location = new Point(19, 74);
            user_label.Margin = new Padding(4, 0, 4, 0);
            user_label.Name = "user_label";
            user_label.Size = new Size(178, 50);
            user_label.TabIndex = 3;
            user_label.Text = "User User";
            user_label.TextAlign = ContentAlignment.MiddleCenter;
            user_label.Click += user_label_Click;
            // 
            // amount_label
            // 
            amount_label.AutoSize = true;
            amount_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            amount_label.ForeColor = Color.Black;
            amount_label.Location = new Point(133, 142);
            amount_label.Margin = new Padding(4, 0, 4, 0);
            amount_label.Name = "amount_label";
            amount_label.Size = new Size(24, 28);
            amount_label.TabIndex = 4;
            amount_label.Text = "0";
            amount_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // add_money_button
            // 
            add_money_button.BackColor = Color.FromArgb(27, 39, 51);
            add_money_button.FlatStyle = FlatStyle.Popup;
            add_money_button.ForeColor = Color.White;
            add_money_button.Location = new Point(479, 28);
            add_money_button.Margin = new Padding(4, 3, 4, 3);
            add_money_button.Name = "add_money_button";
            add_money_button.Size = new Size(256, 44);
            add_money_button.TabIndex = 10;
            add_money_button.Text = "Add Money";
            add_money_button.UseVisualStyleBackColor = false;
            add_money_button.Click += add_money_button_Click;
            // 
            // transactions_button
            // 
            transactions_button.BackColor = Color.FromArgb(0, 0, 15, 255);
            transactions_button.FlatAppearance.BorderColor = Color.FromArgb(0, 112, 224);
            transactions_button.FlatStyle = FlatStyle.Popup;
            transactions_button.ForeColor = Color.Black;
            transactions_button.Location = new Point(479, 175);
            transactions_button.Margin = new Padding(4, 3, 4, 3);
            transactions_button.Name = "transactions_button";
            transactions_button.Size = new Size(256, 44);
            transactions_button.TabIndex = 9;
            transactions_button.Text = "Transactions";
            transactions_button.UseVisualStyleBackColor = false;
            transactions_button.Click += transactions_button_Click;
            // 
            // send_money_button
            // 
            send_money_button.BackColor = Color.FromArgb(0, 112, 224);
            send_money_button.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            send_money_button.FlatStyle = FlatStyle.Flat;
            send_money_button.ForeColor = Color.WhiteSmoke;
            send_money_button.Location = new Point(479, 102);
            send_money_button.Margin = new Padding(4, 3, 4, 3);
            send_money_button.Name = "send_money_button";
            send_money_button.Size = new Size(256, 44);
            send_money_button.TabIndex = 8;
            send_money_button.Text = "Send Money";
            send_money_button.UseMnemonic = false;
            send_money_button.UseVisualStyleBackColor = false;
            send_money_button.Click += send_money_button_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(787, 243);
            Controls.Add(add_money_button);
            Controls.Add(transactions_button);
            Controls.Add(send_money_button);
            Controls.Add(amount_label);
            Controls.Add(user_label);
            Controls.Add(balance_label);
            Controls.Add(welcome_label);
            Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Bold);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "N&H Dashboard";
            Load += dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcome_label;
        private Label balance_label;
        private Label user_label;
        private Label amount_label;
        private Button add_money_button;
        private Button transactions_button;
        private Button send_money_button;
    }
}