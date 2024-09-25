namespace BooksApplication
{
    partial class ExportDialog
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
            BT_Json = new Button();
            BT_Txt = new Button();
            SuspendLayout();
            // 
            // BT_Json
            // 
            BT_Json.Location = new Point(36, 54);
            BT_Json.Name = "BT_Json";
            BT_Json.Size = new Size(100, 40);
            BT_Json.TabIndex = 0;
            BT_Json.Text = "Json";
            BT_Json.UseVisualStyleBackColor = true;
            BT_Json.Click += BT_Json_Click;
            // 
            // BT_Txt
            // 
            BT_Txt.Location = new Point(159, 54);
            BT_Txt.Name = "BT_Txt";
            BT_Txt.Size = new Size(100, 40);
            BT_Txt.TabIndex = 1;
            BT_Txt.Text = "Text";
            BT_Txt.UseVisualStyleBackColor = true;
            BT_Txt.Click += BT_Txt_Click;
            // 
            // ExportDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 157);
            Controls.Add(BT_Txt);
            Controls.Add(BT_Json);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ExportDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExportDialog";
            ResumeLayout(false);
        }

        #endregion

        private Button BT_Json;
        private Button BT_Txt;
    }
}