namespace BooksApplication
{
    partial class Main
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
            BT_AddClient = new Button();
            BT_AddBook = new Button();
            BT_Renting = new Button();
            BT_SearchClient = new Button();
            SuspendLayout();
            // 
            // BT_AddClient
            // 
            BT_AddClient.Location = new Point(132, 109);
            BT_AddClient.Name = "BT_AddClient";
            BT_AddClient.Size = new Size(150, 40);
            BT_AddClient.TabIndex = 1;
            BT_AddClient.Text = "Add Client";
            BT_AddClient.UseVisualStyleBackColor = true;
            BT_AddClient.Click += BT_AddClient_Click;
            // 
            // BT_AddBook
            // 
            BT_AddBook.Location = new Point(132, 60);
            BT_AddBook.Name = "BT_AddBook";
            BT_AddBook.Size = new Size(150, 40);
            BT_AddBook.TabIndex = 2;
            BT_AddBook.Text = "Add Book";
            BT_AddBook.UseVisualStyleBackColor = true;
            BT_AddBook.Click += BT_AddBook_Click;
            // 
            // BT_Renting
            // 
            BT_Renting.Location = new Point(132, 14);
            BT_Renting.Name = "BT_Renting";
            BT_Renting.Size = new Size(150, 40);
            BT_Renting.TabIndex = 3;
            BT_Renting.Text = "Renting";
            BT_Renting.UseVisualStyleBackColor = true;
            BT_Renting.Click += BT_Renting_Click;
            // 
            // BT_SearchClient
            // 
            BT_SearchClient.Location = new Point(132, 155);
            BT_SearchClient.Name = "BT_SearchClient";
            BT_SearchClient.Size = new Size(150, 40);
            BT_SearchClient.TabIndex = 4;
            BT_SearchClient.Text = "Search Client";
            BT_SearchClient.UseVisualStyleBackColor = true;
            BT_SearchClient.Click += BT_SearchClient_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 274);
            Controls.Add(BT_SearchClient);
            Controls.Add(BT_Renting);
            Controls.Add(BT_AddClient);
            Controls.Add(BT_AddBook);
            Name = "Main";
            Text = "Main";
            FormClosed += Main_FormClosed;
            ResumeLayout(false);
        }

        #endregion
        private Button BT_AddBook;
        private Button BT_AddClient;
        private Button BT_Renting;
        private Button BT_SearchClient;
    }
}