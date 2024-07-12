namespace ADO_03._Picture_in_Database
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
            menuStrip1 = new MenuStrip();
            loadPictureToolStripMenuItem = new ToolStripMenuItem();
            showOneToolStripMenuItem = new ToolStripMenuItem();
            idTextBox = new ToolStripTextBox();
            showAllToolStripMenuItem = new ToolStripMenuItem();
            picturesGridView = new DataGridView();
            bookCoverPictureBox = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturesGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookCoverPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadPictureToolStripMenuItem, showOneToolStripMenuItem, idTextBox, showAllToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadPictureToolStripMenuItem
            // 
            loadPictureToolStripMenuItem.Name = "loadPictureToolStripMenuItem";
            loadPictureToolStripMenuItem.Size = new Size(85, 23);
            loadPictureToolStripMenuItem.Text = "Load Picture";
            loadPictureToolStripMenuItem.Click += loadPictureToolStripMenuItem_Click;
            // 
            // showOneToolStripMenuItem
            // 
            showOneToolStripMenuItem.Name = "showOneToolStripMenuItem";
            showOneToolStripMenuItem.Size = new Size(73, 23);
            showOneToolStripMenuItem.Text = "Show One";
            showOneToolStripMenuItem.Click += showOneToolStripMenuItem_Click;
            // 
            // idTextBox
            // 
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(121, 23);
            // 
            // showAllToolStripMenuItem
            // 
            showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            showAllToolStripMenuItem.Size = new Size(65, 23);
            showAllToolStripMenuItem.Text = "Show All";
            showAllToolStripMenuItem.Click += showAllToolStripMenuItem_Click;
            // 
            // picturesGridView
            // 
            picturesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            picturesGridView.Location = new Point(12, 43);
            picturesGridView.Name = "picturesGridView";
            picturesGridView.Size = new Size(388, 406);
            picturesGridView.TabIndex = 1;
            // 
            // bookCoverPictureBox
            // 
            bookCoverPictureBox.Location = new Point(406, 43);
            bookCoverPictureBox.Name = "bookCoverPictureBox";
            bookCoverPictureBox.Size = new Size(382, 406);
            bookCoverPictureBox.TabIndex = 2;
            bookCoverPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 461);
            Controls.Add(bookCoverPictureBox);
            Controls.Add(picturesGridView);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(816, 500);
            MinimumSize = new Size(816, 500);
            Name = "Form1";
            Text = "Picture Library";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturesGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookCoverPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadPictureToolStripMenuItem;
        private ToolStripMenuItem showOneToolStripMenuItem;
        private ToolStripMenuItem showAllToolStripMenuItem;
        private DataGridView picturesGridView;
        private PictureBox bookCoverPictureBox;
        private ToolStripTextBox idTextBox;
    }
}
