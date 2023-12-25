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
            enter_amount_input = new TextBox();
            add_money_label = new Button();
            SuspendLayout();
            // 
            // enter_amount_label
            // 
            enter_amount_label.AutoSize = true;
            enter_amount_label.Location = new Point(342, 135);
            enter_amount_label.Name = "enter_amount_label";
            enter_amount_label.Size = new Size(100, 20);
            enter_amount_label.TabIndex = 0;
            enter_amount_label.Text = "Enter Amount";
            // 
            // enter_amount_input
            // 
            enter_amount_input.Location = new Point(327, 180);
            enter_amount_input.Name = "enter_amount_input";
            enter_amount_input.Size = new Size(128, 27);
            enter_amount_input.TabIndex = 1;
            // 
            // add_money_label
            // 
            add_money_label.Location = new Point(348, 228);
            add_money_label.Name = "add_money_label";
            add_money_label.Size = new Size(94, 29);
            add_money_label.TabIndex = 2;
            add_money_label.Text = "Add Money";
            add_money_label.UseVisualStyleBackColor = true;
            add_money_label.Click += add_money_label_Click;
            // 
            // add_money
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(add_money_label);
            Controls.Add(enter_amount_input);
            Controls.Add(enter_amount_label);
            Name = "add_money";
            Text = "Add Money";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enter_amount_label;
        private TextBox enter_amount_input;
        private Button add_money_label;
    }
}