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
            go_to = new Button();
            SuspendLayout();
            // 
            // go_to
            // 
            go_to.Location = new Point(265, 143);
            go_to.Name = "go_to";
            go_to.Size = new Size(205, 29);
            go_to.TabIndex = 0;
            go_to.Text = "Go to another form";
            go_to.TextAlign = ContentAlignment.TopCenter;
            go_to.UseVisualStyleBackColor = true;
            go_to.Click += go_to_Click;
            // 
            // banking_app
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(go_to);
            Name = "banking_app";
            Text = "Banking App";
            Load += banking_app_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button go_to;
    }
}
