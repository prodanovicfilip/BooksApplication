namespace BooksApplication
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
            BT_Submit = new Button();
            label1 = new Label();
            label2 = new Label();
            TB_Username = new TextBox();
            TB_Password = new TextBox();
            SuspendLayout();
            // 
            // BT_Submit
            // 
            BT_Submit.Location = new Point(93, 197);
            BT_Submit.Name = "BT_Submit";
            BT_Submit.Size = new Size(314, 82);
            BT_Submit.TabIndex = 0;
            BT_Submit.Text = "LOGIN";
            BT_Submit.UseVisualStyleBackColor = true;
            BT_Submit.Click += BT_Submit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 62);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 117);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(139, 62);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(254, 23);
            TB_Username.TabIndex = 3;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(141, 117);
            TB_Password.Name = "TB_Password";
            TB_Password.PasswordChar = '*';
            TB_Password.Size = new Size(252, 23);
            TB_Password.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 327);
            Controls.Add(TB_Password);
            Controls.Add(TB_Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BT_Submit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_Submit;
        private Label label1;
        private Label label2;
        private TextBox TB_Username;
        private TextBox TB_Password;
    }
}
