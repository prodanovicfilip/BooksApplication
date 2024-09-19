namespace BooksApplication
{
    partial class AddBook
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
            BT_Save = new Button();
            BT_Exit = new Button();
            Naziv = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TB_Title = new TextBox();
            TB_Author = new TextBox();
            TB_Year = new TextBox();
            TB_Desc = new RichTextBox();
            label1 = new Label();
            TB_Count = new TextBox();
            SuspendLayout();
            // 
            // BT_Save
            // 
            BT_Save.Location = new Point(542, 415);
            BT_Save.Name = "BT_Save";
            BT_Save.Size = new Size(75, 23);
            BT_Save.TabIndex = 0;
            BT_Save.Text = "Save";
            BT_Save.UseVisualStyleBackColor = true;
            BT_Save.Click += BT_Save_Click;
            // 
            // BT_Exit
            // 
            BT_Exit.Location = new Point(146, 415);
            BT_Exit.Name = "BT_Exit";
            BT_Exit.Size = new Size(75, 23);
            BT_Exit.TabIndex = 1;
            BT_Exit.Text = "Exit";
            BT_Exit.UseVisualStyleBackColor = true;
            BT_Exit.Click += BT_Exit_Click;
            // 
            // Naziv
            // 
            Naziv.AutoSize = true;
            Naziv.Location = new Point(191, 68);
            Naziv.Name = "Naziv";
            Naziv.Size = new Size(29, 15);
            Naziv.TabIndex = 2;
            Naziv.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 107);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 148);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 4;
            label3.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 208);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 5;
            label4.Text = "Description";
            // 
            // TB_Title
            // 
            TB_Title.Location = new Point(310, 68);
            TB_Title.Name = "TB_Title";
            TB_Title.Size = new Size(193, 23);
            TB_Title.TabIndex = 6;
            // 
            // TB_Author
            // 
            TB_Author.Location = new Point(310, 104);
            TB_Author.Name = "TB_Author";
            TB_Author.Size = new Size(193, 23);
            TB_Author.TabIndex = 7;
            // 
            // TB_Year
            // 
            TB_Year.Location = new Point(310, 145);
            TB_Year.Name = "TB_Year";
            TB_Year.Size = new Size(193, 23);
            TB_Year.TabIndex = 8;
            // 
            // TB_Desc
            // 
            TB_Desc.Location = new Point(310, 208);
            TB_Desc.Name = "TB_Desc";
            TB_Desc.Size = new Size(422, 175);
            TB_Desc.TabIndex = 9;
            TB_Desc.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(648, 71);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Count";
            // 
            // TB_Count
            // 
            TB_Count.Location = new Point(618, 99);
            TB_Count.Name = "TB_Count";
            TB_Count.Size = new Size(100, 23);
            TB_Count.TabIndex = 11;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TB_Count);
            Controls.Add(label1);
            Controls.Add(TB_Desc);
            Controls.Add(TB_Year);
            Controls.Add(TB_Author);
            Controls.Add(TB_Title);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Naziv);
            Controls.Add(BT_Exit);
            Controls.Add(BT_Save);
            Name = "AddBook";
            Text = "AddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_Save;
        private Button BT_Exit;
        private Label Naziv;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TB_Title;
        private TextBox TB_Author;
        private TextBox TB_Year;
        private RichTextBox TB_Desc;
        private Label label1;
        private TextBox TB_Count;
    }
}