namespace BooksApplication
{
    partial class SearchClient
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
            DG_Clients = new DataGridView();
            CT_Context = new ContextMenuStrip(components);
            TS_SeeBooks = new ToolStripMenuItem();
            TB_Search = new TextBox();
            BT_Search = new Button();
            BT_Select = new Button();
            BT_Import = new Button();
            BT_Export = new Button();
            ((System.ComponentModel.ISupportInitialize)DG_Clients).BeginInit();
            CT_Context.SuspendLayout();
            SuspendLayout();
            // 
            // DG_Clients
            // 
            DG_Clients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_Clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_Clients.ContextMenuStrip = CT_Context;
            DG_Clients.Location = new Point(0, 80);
            DG_Clients.Name = "DG_Clients";
            DG_Clients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DG_Clients.Size = new Size(720, 309);
            DG_Clients.TabIndex = 0;
            DG_Clients.SelectionChanged += DG_Clients_SelectionChanged;
            DG_Clients.MouseDown += DG_Clients_MouseDown;
            // 
            // CT_Context
            // 
            CT_Context.Items.AddRange(new ToolStripItem[] { TS_SeeBooks });
            CT_Context.Name = "CT_Context";
            CT_Context.Size = new Size(168, 26);
            // 
            // TS_SeeBooks
            // 
            TS_SeeBooks.Name = "TS_SeeBooks";
            TS_SeeBooks.Size = new Size(167, 22);
            TS_SeeBooks.Text = "See Rented Books";
            TS_SeeBooks.Click += TS_SeeBooks_Click;
            // 
            // TB_Search
            // 
            TB_Search.Location = new Point(12, 16);
            TB_Search.Name = "TB_Search";
            TB_Search.Size = new Size(182, 23);
            TB_Search.TabIndex = 1;
            // 
            // BT_Search
            // 
            BT_Search.Location = new Point(200, 17);
            BT_Search.Name = "BT_Search";
            BT_Search.Size = new Size(75, 23);
            BT_Search.TabIndex = 2;
            BT_Search.Text = "Search";
            BT_Search.UseVisualStyleBackColor = true;
            BT_Search.Click += BT_Search_Click;
            // 
            // BT_Select
            // 
            BT_Select.Location = new Point(337, 16);
            BT_Select.Name = "BT_Select";
            BT_Select.Size = new Size(75, 23);
            BT_Select.TabIndex = 3;
            BT_Select.Text = "Select";
            BT_Select.UseVisualStyleBackColor = true;
            BT_Select.Visible = false;
            BT_Select.Click += BT_Select_Click;
            // 
            // BT_Import
            // 
            BT_Import.Location = new Point(93, 51);
            BT_Import.Name = "BT_Import";
            BT_Import.Size = new Size(75, 23);
            BT_Import.TabIndex = 4;
            BT_Import.Text = "Import";
            BT_Import.UseVisualStyleBackColor = true;
            BT_Import.Click += BT_Import_Click;
            // 
            // BT_Export
            // 
            BT_Export.Location = new Point(12, 51);
            BT_Export.Name = "BT_Export";
            BT_Export.Size = new Size(75, 23);
            BT_Export.TabIndex = 5;
            BT_Export.Text = "Export";
            BT_Export.UseVisualStyleBackColor = true;
            BT_Export.Click += BT_Export_Click;
            // 
            // SearchClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 387);
            Controls.Add(BT_Export);
            Controls.Add(BT_Import);
            Controls.Add(BT_Select);
            Controls.Add(BT_Search);
            Controls.Add(TB_Search);
            Controls.Add(DG_Clients);
            Name = "SearchClient";
            Text = "SearchClient";
            Load += SearchClient_Load;
            ((System.ComponentModel.ISupportInitialize)DG_Clients).EndInit();
            CT_Context.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DG_Clients;
        private TextBox TB_Search;
        private Button BT_Search;
        private Button BT_Select;
        private ContextMenuStrip CT_Context;
        private ToolStripMenuItem TS_SeeBooks;
        private Button BT_Import;
        private Button BT_Export;
    }
}