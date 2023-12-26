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
            back_button = new Button();
            ((System.ComponentModel.ISupportInitialize)transaction_data).BeginInit();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.Location = new Point(363, 398);
            back_button.Name = "back_button";
            back_button.Size = new Size(94, 29);
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
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            transaction_data.DefaultCellStyle = dataGridViewCellStyle2;
            transaction_data.Location = new Point(48, 32);
            transaction_data.MultiSelect = false;
            transaction_data.Name = "transaction_data";
            transaction_data.ReadOnly = true;
            transaction_data.RowHeadersWidth = 50;
            transaction_data.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            transaction_data.RowTemplate.ReadOnly = true;
            transaction_data.RowTemplate.Resizable = DataGridViewTriState.False;
            transaction_data.ScrollBars = ScrollBars.Vertical;
            transaction_data.ShowEditingIcon = false;
            transaction_data.Size = new Size(749, 344);
            transaction_data.TabIndex = 0;
            // 
            // transactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(back_button);
            Controls.Add(transaction_data);
            Name = "transactions";
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)transaction_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView transaction_data;
    }
}