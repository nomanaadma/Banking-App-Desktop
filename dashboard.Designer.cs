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
            send_money_button = new Button();
            transactions_button = new Button();
            SuspendLayout();
            // 
            // welcome_label
            // 
            welcome_label.AutoSize = true;
            welcome_label.Font = new Font("Segoe UI", 15F);
            welcome_label.Location = new Point(335, 28);
            welcome_label.Name = "welcome_label";
            welcome_label.Size = new Size(118, 35);
            welcome_label.TabIndex = 0;
            welcome_label.Text = "Welcome";
            // 
            // balance_label
            // 
            balance_label.AutoSize = true;
            balance_label.Font = new Font("Segoe UI", 12F);
            balance_label.Location = new Point(335, 142);
            balance_label.Name = "balance_label";
            balance_label.Size = new Size(107, 28);
            balance_label.TabIndex = 1;
            balance_label.Text = "Balance: Rs";
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new Font("Segoe UI", 22F);
            user_label.Location = new Point(341, 76);
            user_label.Name = "user_label";
            user_label.Size = new Size(95, 50);
            user_label.TabIndex = 3;
            user_label.Text = "User";
            // 
            // amount_label
            // 
            amount_label.AutoSize = true;
            amount_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            amount_label.Location = new Point(374, 191);
            amount_label.Name = "amount_label";
            amount_label.Size = new Size(24, 28);
            amount_label.TabIndex = 4;
            amount_label.Text = "0";
            // 
            // add_money_button
            // 
            add_money_button.Location = new Point(153, 286);
            add_money_button.Name = "add_money_button";
            add_money_button.Size = new Size(120, 29);
            add_money_button.TabIndex = 5;
            add_money_button.Text = "Add Money";
            add_money_button.UseVisualStyleBackColor = true;
            add_money_button.Click += add_money_button_Click;
            // 
            // send_money_button
            // 
            send_money_button.Location = new Point(326, 286);
            send_money_button.Name = "send_money_button";
            send_money_button.Size = new Size(136, 29);
            send_money_button.TabIndex = 6;
            send_money_button.Text = "Send Money";
            send_money_button.UseVisualStyleBackColor = true;
            send_money_button.Click += send_money_button_Click;
            // 
            // transactions_button
            // 
            transactions_button.Location = new Point(518, 286);
            transactions_button.Name = "transactions_button";
            transactions_button.Size = new Size(137, 29);
            transactions_button.TabIndex = 7;
            transactions_button.Text = "Transactions";
            transactions_button.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(transactions_button);
            Controls.Add(send_money_button);
            Controls.Add(add_money_button);
            Controls.Add(amount_label);
            Controls.Add(user_label);
            Controls.Add(balance_label);
            Controls.Add(welcome_label);
            Name = "dashboard";
            Text = "Dashboard";
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
        private Button send_money_button;
        private Button transactions_button;
    }
}