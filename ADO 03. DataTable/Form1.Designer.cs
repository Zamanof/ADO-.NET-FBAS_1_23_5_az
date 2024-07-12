namespace ADO_03._DataTable
{
    partial class Form1
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
            queryTextBox = new TextBox();
            executeButton = new Button();
            myDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)myDataGrid).BeginInit();
            SuspendLayout();
            // 
            // queryTextBox
            // 
            queryTextBox.Location = new Point(12, 12);
            queryTextBox.Name = "queryTextBox";
            queryTextBox.Size = new Size(356, 23);
            queryTextBox.TabIndex = 0;
            // 
            // executeButton
            // 
            executeButton.Location = new Point(390, 12);
            executeButton.Name = "executeButton";
            executeButton.Size = new Size(114, 23);
            executeButton.TabIndex = 1;
            executeButton.Text = "Execute";
            executeButton.UseVisualStyleBackColor = true;
            executeButton.Click += executeButton_Click;
            // 
            // myDataGrid
            // 
            myDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myDataGrid.Location = new Point(12, 57);
            myDataGrid.Name = "myDataGrid";
            myDataGrid.Size = new Size(492, 298);
            myDataGrid.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 367);
            Controls.Add(myDataGrid);
            Controls.Add(executeButton);
            Controls.Add(queryTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)myDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox queryTextBox;
        private Button executeButton;
        private DataGridView myDataGrid;
    }
}
