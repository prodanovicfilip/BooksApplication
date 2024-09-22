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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            TB_Search = new TextBox();
            BT_Search = new Button();
            GV_Books = new DataGridView();
            CT_Context = new ContextMenuStrip(components);
            TS_Rent = new ToolStripMenuItem();
            TS_Delete = new ToolStripMenuItem();
            TS_Edit = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)GV_Books).BeginInit();
            CT_Context.SuspendLayout();
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
            GV_Books.ContextMenuStrip = CT_Context;
            GV_Books.Location = new Point(-1, 35);
            GV_Books.Name = "GV_Books";
            GV_Books.ReadOnly = true;
            GV_Books.Size = new Size(928, 462);
            GV_Books.TabIndex = 3;
            GV_Books.CellClick += GV_Books_CellClick;
            GV_Books.SelectionChanged += GV_Books_SelectionChanged;
            GV_Books.MouseDown += GV_Books_MouseDown;
            // 
            // CT_Context
            // 
            CT_Context.Items.AddRange(new ToolStripItem[] { TS_Rent, TS_Delete, TS_Edit });
            CT_Context.Name = "CT_Context";
            CT_Context.Size = new Size(108, 70);
            // 
            // TS_Rent
            // 
            TS_Rent.Name = "TS_Rent";
            TS_Rent.Size = new Size(107, 22);
            TS_Rent.Text = "Rent";
            TS_Rent.Click += TS_Rent_Click;
            // 
            // TS_Delete
            // 
            TS_Delete.Name = "TS_Delete";
            TS_Delete.Size = new Size(107, 22);
            TS_Delete.Text = "Delete";
            TS_Delete.Click += TS_Delete_Click;
            // 
            // TS_Edit
            // 
            TS_Edit.Name = "TS_Edit";
            TS_Edit.Size = new Size(107, 22);
            TS_Edit.Text = "Edit";
            TS_Edit.Click += TS_Edit_Click;
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
            CT_Context.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TB_Search;
        private Button BT_Search;
        private DataGridView GV_Books;
        private ContextMenuStrip CT_Context;
        private ToolStripMenuItem TS_Rent;
        private ToolStripMenuItem TS_Delete;
        private ToolStripMenuItem TS_Edit;
    }
}