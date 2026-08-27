namespace VisitantesCartorio
{
    partial class FormList
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
            richTextBoxList = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxList
            // 
            richTextBoxList.BorderStyle = BorderStyle.None;
            richTextBoxList.Dock = DockStyle.Fill;
            richTextBoxList.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxList.Location = new Point(0, 0);
            richTextBoxList.Name = "richTextBoxList";
            richTextBoxList.ReadOnly = true;
            richTextBoxList.Size = new Size(682, 953);
            richTextBoxList.TabIndex = 0;
            richTextBoxList.Text = "";
            // 
            // FormList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 953);
            Controls.Add(richTextBoxList);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormList";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxList;
    }
}