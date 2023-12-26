namespace Banking_App
{
    partial class send_money
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
            send_by_label = new Label();
            send_by_input = new ComboBox();
            enter_label = new Label();
            send_type_label = new Label();
            enter_input = new TextBox();
            amount_label = new Label();
            amount_input = new TextBox();
            send_money_button = new Button();
            back_button = new Button();
            send_money_label = new Label();
            SuspendLayout();
            // 
            // send_by_label
            // 
            send_by_label.AutoSize = true;
            send_by_label.Location = new Point(45, 128);
            send_by_label.Margin = new Padding(4, 0, 4, 0);
            send_by_label.Name = "send_by_label";
            send_by_label.Size = new Size(80, 22);
            send_by_label.TabIndex = 0;
            send_by_label.Text = "Send By";
            // 
            // send_by_input
            // 
            send_by_input.FormattingEnabled = true;
            send_by_input.Items.AddRange(new object[] { "Email", "CNIC" });
            send_by_input.Location = new Point(45, 169);
            send_by_input.Margin = new Padding(4, 3, 4, 3);
            send_by_input.Name = "send_by_input";
            send_by_input.Size = new Size(252, 30);
            send_by_input.TabIndex = 1;
            send_by_input.SelectedIndexChanged += send_by_input_SelectedIndexChanged;
            // 
            // enter_label
            // 
            enter_label.AutoSize = true;
            enter_label.Location = new Point(45, 225);
            enter_label.Margin = new Padding(4, 0, 4, 0);
            enter_label.Name = "enter_label";
            enter_label.Size = new Size(60, 22);
            enter_label.TabIndex = 2;
            enter_label.Text = "Enter";
            // 
            // send_type_label
            // 
            send_type_label.AutoSize = true;
            send_type_label.Location = new Point(90, 225);
            send_type_label.Margin = new Padding(4, 0, 4, 0);
            send_type_label.Name = "send_type_label";
            send_type_label.Size = new Size(0, 22);
            send_type_label.TabIndex = 3;
            // 
            // enter_input
            // 
            enter_input.Location = new Point(45, 265);
            enter_input.Margin = new Padding(4, 3, 4, 3);
            enter_input.Name = "enter_input";
            enter_input.Size = new Size(252, 30);
            enter_input.TabIndex = 4;
            // 
            // amount_label
            // 
            amount_label.AutoSize = true;
            amount_label.Location = new Point(45, 317);
            amount_label.Margin = new Padding(4, 0, 4, 0);
            amount_label.Name = "amount_label";
            amount_label.Size = new Size(70, 22);
            amount_label.TabIndex = 5;
            amount_label.Text = "Amount";
            // 
            // amount_input
            // 
            amount_input.Location = new Point(45, 355);
            amount_input.Margin = new Padding(4, 3, 4, 3);
            amount_input.Name = "amount_input";
            amount_input.Size = new Size(252, 30);
            amount_input.TabIndex = 6;
            // 
            // send_money_button
            // 
            send_money_button.BackColor = Color.FromArgb(0, 112, 224);
            send_money_button.FlatStyle = FlatStyle.Flat;
            send_money_button.ForeColor = Color.White;
            send_money_button.Location = new Point(97, 412);
            send_money_button.Margin = new Padding(4, 3, 4, 3);
            send_money_button.Name = "send_money_button";
            send_money_button.Size = new Size(150, 44);
            send_money_button.TabIndex = 7;
            send_money_button.Text = "Send Money";
            send_money_button.UseVisualStyleBackColor = false;
            send_money_button.Click += send_money_button_Click;
            // 
            // back_button
            // 
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.ForeColor = Color.Black;
            back_button.Location = new Point(112, 479);
            back_button.Margin = new Padding(4, 3, 4, 3);
            back_button.Name = "back_button";
            back_button.Size = new Size(118, 32);
            back_button.TabIndex = 8;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // send_money_label
            // 
            send_money_label.AutoSize = true;
            send_money_label.Font = new Font("JetBrains Mono", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            send_money_label.ForeColor = Color.FromArgb(27, 39, 51);
            send_money_label.Location = new Point(22, 37);
            send_money_label.Margin = new Padding(4, 0, 4, 0);
            send_money_label.Name = "send_money_label";
            send_money_label.Size = new Size(307, 62);
            send_money_label.TabIndex = 23;
            send_money_label.Text = "Send Money";
            // 
            // send_money
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(352, 541);
            Controls.Add(send_money_label);
            Controls.Add(back_button);
            Controls.Add(send_money_button);
            Controls.Add(amount_input);
            Controls.Add(amount_label);
            Controls.Add(enter_input);
            Controls.Add(send_type_label);
            Controls.Add(enter_label);
            Controls.Add(send_by_input);
            Controls.Add(send_by_label);
            Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Bold);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "send_money";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "N&H Send Money";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label send_by_label;
        private ComboBox send_by_input;
        private Label enter_label;
        private Label send_type_label;
        private TextBox enter_input;
        private Label amount_label;
        private TextBox amount_input;
        private Button send_money_button;
        private Button back_button;
        private Label send_money_label;
    }
}