namespace VisitantesCartorio
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonRegister = new Button();
            buttonList = new Button();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.DarkKhaki;
            buttonRegister.Font = new Font("Malgun Gothic", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.Location = new Point(485, 541);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(220, 90);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Cadastrar";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonList
            // 
            buttonList.BackColor = Color.RosyBrown;
            buttonList.Font = new Font("Malgun Gothic", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonList.Location = new Point(927, 541);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(220, 90);
            buttonList.TabIndex = 1;
            buttonList.Text = "Listar";
            buttonList.UseVisualStyleBackColor = false;
            buttonList.Click += buttonList_Click;
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1582, 853);
            Controls.Add(buttonList);
            Controls.Add(buttonRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1600, 900);
            MinimizeBox = false;
            MinimumSize = new Size(1600, 900);
            Name = "FormMain";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += FormMain_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonRegister;
        private Button buttonList;
    }
}
