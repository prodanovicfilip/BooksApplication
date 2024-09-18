namespace BooksApplication
{
    partial class RegistrationForm
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
            label2 = new Label();
            TB_Username = new TextBox();
            TB_Password = new TextBox();
            BT_Register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 63);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 97);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // TB_Username
            // 
            TB_Username.Location = new Point(137, 60);
            TB_Username.Name = "TB_Username";
            TB_Username.Size = new Size(153, 23);
            TB_Username.TabIndex = 2;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(137, 97);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(153, 23);
            TB_Password.TabIndex = 3;
            // 
            // BT_Register
            // 
            BT_Register.Location = new Point(137, 176);
            BT_Register.Name = "BT_Register";
            BT_Register.Size = new Size(125, 43);
            BT_Register.TabIndex = 4;
            BT_Register.Text = "REGISTER";
            BT_Register.UseVisualStyleBackColor = true;
            BT_Register.Click += BT_Register_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 259);
            Controls.Add(BT_Register);
            Controls.Add(TB_Password);
            Controls.Add(TB_Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TB_Username;
        private TextBox TB_Password;
        private Button BT_Register;
    }
}