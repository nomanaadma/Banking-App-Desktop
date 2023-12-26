namespace Banking_App
{
    partial class transactions
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
            Button back_button;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            transaction_data = new DataGridView();
            transactions_label = new Label();
            back_button = new Button();
            ((System.ComponentModel.ISupportInitialize)transaction_data).BeginInit();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.FlatStyle = FlatStyle.Flat;
            back_button.ForeColor = Color.Black;
            back_button.Location = new Point(334, 524);
            back_button.Margin = new Padding(4, 3, 4, 3);
            back_button.Name = "back_button";
            back_button.Size = new Size(118, 32);
            back_button.TabIndex = 1;
            back_button.Text = "Back";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // transaction_data
            // 
            transaction_data.AllowUserToAddRows = false;
            transaction_data.AllowUserToDeleteRows = false;
            transaction_data.AllowUserToResizeColumns = false;
            transaction_data.AllowUserToResizeRows = false;
            transaction_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            transaction_data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            transaction_data.BackgroundColor = SystemColors.Window;
            transaction_data.BorderStyle = BorderStyle.None;
            transaction_data.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            transaction_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            transaction_data.ColumnHeadersHeight = 29;
            transaction_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            transaction_data.DefaultCellStyle = dataGridViewCellStyle2;
            transaction_data.Location = new Point(31, 118);
            transaction_data.Margin = new Padding(4, 3, 4, 3);
            transaction_data.MultiSelect = false;
            transaction_data.Name = "transaction_data";
            transaction_data.ReadOnly = true;
            transaction_data.RowHeadersWidth = 50;
            transaction_data.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            transaction_data.RowTemplate.ReadOnly = true;
            transaction_data.RowTemplate.Resizable = DataGridViewTriState.False;
            transaction_data.ScrollBars = ScrollBars.Vertical;
            transaction_data.ShowEditingIcon = false;
            transaction_data.Size = new Size(739, 378);
            transaction_data.TabIndex = 0;
            transaction_data.CellContentClick += transaction_data_CellContentClick;
            // 
            // transactions_label
            // 
            transactions_label.AutoSize = true;
            transactions_label.Font = new Font("JetBrains Mono", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transactions_label.ForeColor = Color.FromArgb(27, 39, 51);
            transactions_label.Location = new Point(31, 29);
            transactions_label.Margin = new Padding(4, 0, 4, 0);
            transactions_label.Name = "transactions_label";
            transactions_label.Size = new Size(363, 62);
            transactions_label.TabIndex = 24;
            transactions_label.Text = "Transactions";
            // 
            // transactions
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(802, 586);
            Controls.Add(transactions_label);
            Controls.Add(back_button);
            Controls.Add(transaction_data);
            Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Bold);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "transactions";
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)transaction_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView transaction_data;
        private Label transactions_label;
    }
}