namespace ADO_03._Disconnected_mode
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
            fillButton = new Button();
            updateButton = new Button();
            resultDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)resultDataGrid).BeginInit();
            SuspendLayout();
            // 
            // queryTextBox
            // 
            queryTextBox.Location = new Point(12, 12);
            queryTextBox.Multiline = true;
            queryTextBox.Name = "queryTextBox";
            queryTextBox.Size = new Size(425, 104);
            queryTextBox.TabIndex = 0;
            // 
            // fillButton
            // 
            fillButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            fillButton.Location = new Point(181, 126);
            fillButton.Name = "fillButton";
            fillButton.Size = new Size(116, 35);
            fillButton.TabIndex = 1;
            fillButton.Text = "Fill";
            fillButton.UseVisualStyleBackColor = true;
            fillButton.Click += fillButton_Click;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            updateButton.Location = new Point(321, 126);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(116, 35);
            updateButton.TabIndex = 1;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // resultDataGrid
            // 
            resultDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGrid.Location = new Point(12, 176);
            resultDataGrid.Name = "resultDataGrid";
            resultDataGrid.Size = new Size(425, 375);
            resultDataGrid.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 563);
            Controls.Add(resultDataGrid);
            Controls.Add(updateButton);
            Controls.Add(fillButton);
            Controls.Add(queryTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)resultDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox queryTextBox;
        private Button fillButton;
        private Button updateButton;
        private DataGridView resultDataGrid;
    }
}
