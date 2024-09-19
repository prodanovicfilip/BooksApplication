namespace BooksApplication
{
    partial class AddClient
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
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TB_Firstname = new TextBox();
            TB_Lastname = new TextBox();
            TB_Address = new TextBox();
            TB_Phone = new TextBox();
            TB_Email = new TextBox();
            SuspendLayout();
            // 
            // BT_Save
            // 
            BT_Save.Location = new Point(293, 313);
            BT_Save.Name = "BT_Save";
            BT_Save.Size = new Size(75, 23);
            BT_Save.TabIndex = 0;
            BT_Save.Text = "Save";
            BT_Save.UseVisualStyleBackColor = true;
            BT_Save.Click += BT_Save_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 313);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 97);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 129);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 165);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 5;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(124, 200);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // TB_Firstname
            // 
            TB_Firstname.Location = new Point(202, 59);
            TB_Firstname.Name = "TB_Firstname";
            TB_Firstname.Size = new Size(166, 23);
            TB_Firstname.TabIndex = 7;
            // 
            // TB_Lastname
            // 
            TB_Lastname.Location = new Point(202, 94);
            TB_Lastname.Name = "TB_Lastname";
            TB_Lastname.Size = new Size(166, 23);
            TB_Lastname.TabIndex = 8;
            // 
            // TB_Address
            // 
            TB_Address.Location = new Point(202, 126);
            TB_Address.Name = "TB_Address";
            TB_Address.Size = new Size(166, 23);
            TB_Address.TabIndex = 9;
            // 
            // TB_Phone
            // 
            TB_Phone.Location = new Point(202, 162);
            TB_Phone.Name = "TB_Phone";
            TB_Phone.Size = new Size(166, 23);
            TB_Phone.TabIndex = 10;
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(202, 197);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(166, 23);
            TB_Email.TabIndex = 11;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 368);
            Controls.Add(TB_Email);
            Controls.Add(TB_Phone);
            Controls.Add(TB_Address);
            Controls.Add(TB_Lastname);
            Controls.Add(TB_Firstname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(BT_Save);
            Name = "AddClient";
            Text = "AddClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_Save;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TB_Firstname;
        private TextBox TB_Lastname;
        private TextBox TB_Address;
        private TextBox TB_Phone;
        private TextBox TB_Email;
    }
}