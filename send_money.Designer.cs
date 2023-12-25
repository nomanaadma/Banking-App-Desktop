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
            SuspendLayout();
            // 
            // send_by_label
            // 
            send_by_label.AutoSize = true;
            send_by_label.Location = new Point(306, 74);
            send_by_label.Name = "send_by_label";
            send_by_label.Size = new Size(62, 20);
            send_by_label.TabIndex = 0;
            send_by_label.Text = "Send By";
            // 
            // send_by_input
            // 
            send_by_input.FormattingEnabled = true;
            send_by_input.Items.AddRange(new object[] { "Email", "CNIC" });
            send_by_input.Location = new Point(306, 111);
            send_by_input.Name = "send_by_input";
            send_by_input.Size = new Size(202, 28);
            send_by_input.TabIndex = 1;
            send_by_input.SelectedIndexChanged += send_by_input_SelectedIndexChanged;
            // 
            // enter_label
            // 
            enter_label.AutoSize = true;
            enter_label.Location = new Point(306, 162);
            enter_label.Name = "enter_label";
            enter_label.Size = new Size(43, 20);
            enter_label.TabIndex = 2;
            enter_label.Text = "Enter";
            // 
            // send_type_label
            // 
            send_type_label.AutoSize = true;
            send_type_label.Location = new Point(346, 162);
            send_type_label.Name = "send_type_label";
            send_type_label.Size = new Size(0, 20);
            send_type_label.TabIndex = 3;
            // 
            // enter_input
            // 
            enter_input.Location = new Point(306, 198);
            enter_input.Name = "enter_input";
            enter_input.Size = new Size(202, 27);
            enter_input.TabIndex = 4;
            // 
            // amount_label
            // 
            amount_label.AutoSize = true;
            amount_label.Location = new Point(306, 245);
            amount_label.Name = "amount_label";
            amount_label.Size = new Size(62, 20);
            amount_label.TabIndex = 5;
            amount_label.Text = "Amount";
            // 
            // amount_input
            // 
            amount_input.Location = new Point(306, 280);
            amount_input.Name = "amount_input";
            amount_input.Size = new Size(202, 27);
            amount_input.TabIndex = 6;
            // 
            // send_money_button
            // 
            send_money_button.Location = new Point(346, 332);
            send_money_button.Name = "send_money_button";
            send_money_button.Size = new Size(120, 29);
            send_money_button.TabIndex = 7;
            send_money_button.Text = "Send Money";
            send_money_button.UseVisualStyleBackColor = true;
            send_money_button.Click += send_money_button_Click;
            // 
            // back_button
            // 
            back_button.Location = new Point(357, 399);
            back_button.Name = "back_button";
            back_button.Size = new Size(94, 29);
            back_button.TabIndex = 8;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // send_money
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back_button);
            Controls.Add(send_money_button);
            Controls.Add(amount_input);
            Controls.Add(amount_label);
            Controls.Add(enter_input);
            Controls.Add(send_type_label);
            Controls.Add(enter_label);
            Controls.Add(send_by_input);
            Controls.Add(send_by_label);
            Name = "send_money";
            Text = "Send Money";
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
    }
}