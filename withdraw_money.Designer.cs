namespace Banking_App
{
    partial class withdraw_money
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
            back_button = new Button();
            enter_amount_label = new Label();
            withdraw_label = new Label();
            enter_amount_input = new TextBox();
            withdraw_money_button = new Button();
            money_label = new Label();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.BackColor = Color.White;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.ForeColor = Color.Black;
            back_button.Location = new Point(98, 373);
            back_button.Margin = new Padding(5, 3, 5, 3);
            back_button.Name = "back_button";
            back_button.Size = new Size(102, 38);
            back_button.TabIndex = 20;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += back_button_Click;
            // 
            // enter_amount_label
            // 
            enter_amount_label.AutoSize = true;
            enter_amount_label.Location = new Point(83, 198);
            enter_amount_label.Margin = new Padding(4, 0, 4, 0);
            enter_amount_label.Name = "enter_amount_label";
            enter_amount_label.Size = new Size(130, 22);
            enter_amount_label.TabIndex = 0;
            enter_amount_label.Text = "Enter Amount";
            // 
            // withdraw_label
            // 
            withdraw_label.AutoSize = true;
            withdraw_label.Font = new Font("JetBrains Mono", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdraw_label.ForeColor = Color.FromArgb(27, 39, 51);
            withdraw_label.Location = new Point(28, 27);
            withdraw_label.Margin = new Padding(4, 0, 4, 0);
            withdraw_label.Name = "withdraw_label";
            withdraw_label.Size = new Size(251, 62);
            withdraw_label.TabIndex = 18;
            withdraw_label.Text = "Withdraw";
            // 
            // enter_amount_input
            // 
            enter_amount_input.Location = new Point(47, 227);
            enter_amount_input.Margin = new Padding(5, 3, 5, 3);
            enter_amount_input.Name = "enter_amount_input";
            enter_amount_input.Size = new Size(205, 30);
            enter_amount_input.TabIndex = 17;
            // 
            // withdraw_money_button
            // 
            withdraw_money_button.BackColor = Color.FromArgb(0, 112, 224);
            withdraw_money_button.FlatStyle = FlatStyle.Flat;
            withdraw_money_button.ForeColor = Color.White;
            withdraw_money_button.Location = new Point(82, 274);
            withdraw_money_button.Margin = new Padding(5, 3, 5, 3);
            withdraw_money_button.Name = "withdraw_money_button";
            withdraw_money_button.Size = new Size(131, 40);
            withdraw_money_button.TabIndex = 19;
            withdraw_money_button.Text = "Withdraw";
            withdraw_money_button.UseVisualStyleBackColor = false;
            withdraw_money_button.Click += withdraw_money_button_Click;
            // 
            // money_label
            // 
            money_label.AutoSize = true;
            money_label.Font = new Font("JetBrains Mono", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            money_label.ForeColor = Color.FromArgb(27, 39, 51);
            money_label.Location = new Point(65, 98);
            money_label.Margin = new Padding(4, 0, 4, 0);
            money_label.Name = "money_label";
            money_label.Size = new Size(167, 62);
            money_label.TabIndex = 21;
            money_label.Text = "Money";
            // 
            // withdraw_money
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(303, 441);
            Controls.Add(money_label);
            Controls.Add(back_button);
            Controls.Add(withdraw_money_button);
            Controls.Add(withdraw_label);
            Controls.Add(enter_amount_input);
            Controls.Add(enter_amount_label);
            Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Bold);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "withdraw_money";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Withdraw Money";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enter_amount_label;
        private TextBox enter_amount_input;
        private Button withdraw_money_button;
        private Button back_button;
        private Label withdraw_label;
        private Label money_label;
    }
}