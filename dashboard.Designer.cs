namespace Banking_App
{
    partial class Dashboard
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
            card_label = new Label();
            card_value = new Label();
            expiry_label = new Label();
            expiry_value = new Label();
            cvc_label = new Label();
            cvc_value = new Label();
            withdraw_money_button = new Button();
            SuspendLayout();
            // 
            // welcome_label
            // 
            welcome_label.AutoSize = true;
            welcome_label.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcome_label.Location = new Point(24, 32);
            welcome_label.Margin = new Padding(4, 0, 4, 0);
            welcome_label.Name = "welcome_label";
            welcome_label.Size = new Size(111, 30);
            welcome_label.TabIndex = 0;
            welcome_label.Text = "Welcome";
            welcome_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // balance_label
            // 
            balance_label.AutoSize = true;
            balance_label.ForeColor = Color.Black;
            balance_label.Location = new Point(27, 122);
            balance_label.Margin = new Padding(4, 0, 4, 0);
            balance_label.Name = "balance_label";
            balance_label.Size = new Size(120, 22);
            balance_label.TabIndex = 1;
            balance_label.Text = "Balance: Rs";
            balance_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // user_label
            // 
            user_label.AutoSize = true;
            user_label.Font = new Font("JetBrains Mono", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            user_label.ForeColor = Color.FromArgb(27, 39, 51);
            user_label.Location = new Point(20, 63);
            user_label.Margin = new Padding(4, 0, 4, 0);
            user_label.Name = "user_label";
            user_label.Size = new Size(199, 44);
            user_label.TabIndex = 3;
            user_label.Text = "User User";
            user_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // amount_label
            // 
            amount_label.AutoSize = true;
            amount_label.Font = new Font("JetBrains Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amount_label.ForeColor = Color.Black;
            amount_label.Location = new Point(147, 120);
            amount_label.Margin = new Padding(4, 0, 4, 0);
            amount_label.Name = "amount_label";
            amount_label.Size = new Size(24, 26);
            amount_label.TabIndex = 4;
            amount_label.Text = "0";
            amount_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // add_money_button
            // 
            add_money_button.BackColor = Color.FromArgb(27, 39, 51);
            add_money_button.FlatStyle = FlatStyle.Popup;
            add_money_button.ForeColor = Color.White;
            add_money_button.Location = new Point(411, 28);
            add_money_button.Margin = new Padding(4, 3, 4, 3);
            add_money_button.Name = "add_money_button";
            add_money_button.Size = new Size(256, 44);
            add_money_button.TabIndex = 10;
            add_money_button.Text = "Add Money";
            add_money_button.UseVisualStyleBackColor = false;
            add_money_button.Click += Add_money_button_Click;
            // 
            // transactions_button
            // 
            transactions_button.BackColor = Color.FromArgb(0, 0, 15, 255);
            transactions_button.FlatAppearance.BorderColor = Color.FromArgb(0, 112, 224);
            transactions_button.FlatStyle = FlatStyle.Popup;
            transactions_button.ForeColor = Color.Black;
            transactions_button.Location = new Point(411, 197);
            transactions_button.Margin = new Padding(4, 3, 4, 3);
            transactions_button.Name = "transactions_button";
            transactions_button.Size = new Size(256, 44);
            transactions_button.TabIndex = 9;
            transactions_button.Text = "Transactions";
            transactions_button.UseVisualStyleBackColor = false;
            transactions_button.Click += Transactions_button_Click;
            // 
            // send_money_button
            // 
            send_money_button.BackColor = Color.FromArgb(0, 112, 224);
            send_money_button.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            send_money_button.FlatStyle = FlatStyle.Flat;
            send_money_button.ForeColor = Color.WhiteSmoke;
            send_money_button.Location = new Point(411, 83);
            send_money_button.Margin = new Padding(4, 3, 4, 3);
            send_money_button.Name = "send_money_button";
            send_money_button.Size = new Size(256, 44);
            send_money_button.TabIndex = 8;
            send_money_button.Text = "Send Money";
            send_money_button.UseMnemonic = false;
            send_money_button.UseVisualStyleBackColor = false;
            send_money_button.Click += Send_money_button_Click;
            // 
            // card_label
            // 
            card_label.AutoSize = true;
            card_label.Location = new Point(27, 162);
            card_label.Name = "card_label";
            card_label.Size = new Size(60, 22);
            card_label.TabIndex = 11;
            card_label.Text = "Card:";
            // 
            // card_value
            // 
            card_value.AutoSize = true;
            card_value.Cursor = Cursors.Hand;
            card_value.Location = new Point(93, 162);
            card_value.Name = "card_value";
            card_value.Size = new Size(20, 22);
            card_value.TabIndex = 12;
            card_value.Text = "-";
            // 
            // expiry_label
            // 
            expiry_label.AutoSize = true;
            expiry_label.Location = new Point(27, 201);
            expiry_label.Name = "expiry_label";
            expiry_label.Size = new Size(80, 22);
            expiry_label.TabIndex = 13;
            expiry_label.Text = "Expiry:";
            // 
            // expiry_value
            // 
            expiry_value.AutoSize = true;
            expiry_value.Location = new Point(107, 201);
            expiry_value.Name = "expiry_value";
            expiry_value.Size = new Size(20, 22);
            expiry_value.TabIndex = 14;
            expiry_value.Text = "-";
            expiry_value.UseMnemonic = false;
            // 
            // cvc_label
            // 
            cvc_label.AutoSize = true;
            cvc_label.Location = new Point(198, 201);
            cvc_label.Name = "cvc_label";
            cvc_label.Size = new Size(50, 22);
            cvc_label.TabIndex = 15;
            cvc_label.Text = "CVC:";
            // 
            // cvc_value
            // 
            cvc_value.AutoSize = true;
            cvc_value.Location = new Point(254, 201);
            cvc_value.Name = "cvc_value";
            cvc_value.Size = new Size(20, 22);
            cvc_value.TabIndex = 16;
            cvc_value.Text = "-";
            // 
            // withdraw_money_button
            // 
            withdraw_money_button.BackColor = Color.Maroon;
            withdraw_money_button.FlatAppearance.BorderColor = Color.Black;
            withdraw_money_button.FlatAppearance.BorderSize = 0;
            withdraw_money_button.FlatStyle = FlatStyle.Flat;
            withdraw_money_button.ForeColor = Color.WhiteSmoke;
            withdraw_money_button.Location = new Point(411, 139);
            withdraw_money_button.Margin = new Padding(4, 3, 4, 3);
            withdraw_money_button.Name = "withdraw_money_button";
            withdraw_money_button.Size = new Size(256, 44);
            withdraw_money_button.TabIndex = 17;
            withdraw_money_button.Text = "Withdraw Money";
            withdraw_money_button.UseMnemonic = false;
            withdraw_money_button.UseVisualStyleBackColor = false;
            withdraw_money_button.Click += Withdraw_money_button_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(705, 266);
            Controls.Add(withdraw_money_button);
            Controls.Add(cvc_value);
            Controls.Add(cvc_label);
            Controls.Add(expiry_value);
            Controls.Add(expiry_label);
            Controls.Add(card_value);
            Controls.Add(card_label);
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
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
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
        private Label card_label;
        private Label card_value;
        private Label expiry_label;
        private Label expiry_value;
        private Label cvc_label;
        private Label cvc_value;
        private Button withdraw_money_button;
    }
}