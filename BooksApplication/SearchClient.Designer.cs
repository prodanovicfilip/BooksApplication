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
            DG_Clients = new DataGridView();
            TB_Search = new TextBox();
            BT_Search = new Button();
            ((System.ComponentModel.ISupportInitialize)DG_Clients).BeginInit();
            SuspendLayout();
            // 
            // DG_Clients
            // 
            DG_Clients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DG_Clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DG_Clients.Location = new Point(0, 46);
            DG_Clients.Name = "DG_Clients";
            DG_Clients.Size = new Size(720, 343);
            DG_Clients.TabIndex = 0;
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
            // SearchClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 387);
            Controls.Add(BT_Search);
            Controls.Add(TB_Search);
            Controls.Add(DG_Clients);
            Name = "SearchClient";
            Text = "SearchClient";
            Load += SearchClient_Load;
            ((System.ComponentModel.ISupportInitialize)DG_Clients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DG_Clients;
        private TextBox TB_Search;
        private Button BT_Search;
    }
}