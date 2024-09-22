namespace BooksApplication
{
    partial class Renting
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
            label1 = new Label();
            TB_Search = new TextBox();
            BT_Search = new Button();
            GV_Books = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GV_Books).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Search Book";
            // 
            // TB_Search
            // 
            TB_Search.Location = new Point(90, 6);
            TB_Search.Name = "TB_Search";
            TB_Search.Size = new Size(181, 23);
            TB_Search.TabIndex = 1;
            // 
            // BT_Search
            // 
            BT_Search.Location = new Point(277, 6);
            BT_Search.Name = "BT_Search";
            BT_Search.Size = new Size(75, 23);
            BT_Search.TabIndex = 2;
            BT_Search.Text = "Search";
            BT_Search.UseVisualStyleBackColor = true;
            BT_Search.Click += BT_Search_Click;
            // 
            // GV_Books
            // 
            GV_Books.AllowUserToAddRows = false;
            GV_Books.AllowUserToDeleteRows = false;
            GV_Books.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GV_Books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GV_Books.Location = new Point(-1, 35);
            GV_Books.Name = "GV_Books";
            GV_Books.ReadOnly = true;
            GV_Books.Size = new Size(928, 462);
            GV_Books.TabIndex = 3;
            // 
            // Renting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 498);
            Controls.Add(GV_Books);
            Controls.Add(BT_Search);
            Controls.Add(TB_Search);
            Controls.Add(label1);
            Name = "Renting";
            Text = "Renting";
            Load += Renting_Load;
            ((System.ComponentModel.ISupportInitialize)GV_Books).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TB_Search;
        private Button BT_Search;
        private DataGridView GV_Books;
    }
}