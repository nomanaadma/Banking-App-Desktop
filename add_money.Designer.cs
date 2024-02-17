namespace Banking_App
{
    partial class add_money
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
            enter_amount_label = new Label();
            add_money_label = new Label();
            enter_amount_input = new TextBox();
            add_money_button = new Button();
            back_button = new Button();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.BackColor = Color.White;
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.ForeColor = Color.Black;
            back_button.Location = new Point(99, 309);
            back_button.Margin = new Padding(5, 3, 5, 3);
            back_button.Name = "back_button";
            back_button.Size = new Size(102, 38);
            back_button.TabIndex = 20;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = false;
            back_button.Click += Back_button_Click;
            // 
            // enter_amount_label
            // 
            enter_amount_label.AutoSize = true;
            enter_amount_label.Location = new Point(84, 134);
            enter_amount_label.Margin = new Padding(4, 0, 4, 0);
            enter_amount_label.Name = "enter_amount_label";
            enter_amount_label.Size = new Size(130, 22);
            enter_amount_label.TabIndex = 0;
            enter_amount_label.Text = "Enter Amount";
            // 
            // add_money_label
            // 
            add_money_label.AutoSize = true;
            add_money_label.Font = new Font("JetBrains Mono", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_money_label.ForeColor = Color.FromArgb(27, 39, 51);
            add_money_label.Location = new Point(16, 34);
            add_money_label.Margin = new Padding(4, 0, 4, 0);
            add_money_label.Name = "add_money_label";
            add_money_label.Size = new Size(279, 62);
            add_money_label.TabIndex = 18;
            add_money_label.Text = "Add Money";
            // 
            // enter_amount_input
            // 
            enter_amount_input.Location = new Point(48, 163);
            enter_amount_input.Margin = new Padding(5, 3, 5, 3);
            enter_amount_input.Name = "enter_amount_input";
            enter_amount_input.Size = new Size(205, 30);
            enter_amount_input.TabIndex = 17;
            // 
            // add_money_button
            // 
            add_money_button.BackColor = Color.FromArgb(0, 112, 224);
            add_money_button.FlatStyle = FlatStyle.Flat;
            add_money_button.ForeColor = Color.White;
            add_money_button.Location = new Point(83, 210);
            add_money_button.Margin = new Padding(5, 3, 5, 3);
            add_money_button.Name = "add_money_button";
            add_money_button.Size = new Size(136, 38);
            add_money_button.TabIndex = 19;
            add_money_button.Text = "Add Money";
            add_money_button.UseVisualStyleBackColor = false;
            add_money_button.Click += Add_money_button_Click;
            // 
            // add_money
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(308, 370);
            Controls.Add(back_button);
            Controls.Add(add_money_button);
            Controls.Add(add_money_label);
            Controls.Add(enter_amount_input);
            Controls.Add(enter_amount_label);
            Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Bold);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "add_money";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Money";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enter_amount_label;
        private TextBox enter_amount_input;
        private Button add_money_button;
        private Button back_button;
        private Label add_money_label;
    }
}