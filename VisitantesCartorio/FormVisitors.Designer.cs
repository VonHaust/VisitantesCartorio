namespace VisitantesCartorio
{
    partial class FormVisitors
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
            textBoxName = new TextBox();
            buttonRegInfo = new Button();
            dateTimePickerDMY = new DateTimePicker();
            comboBoxProcedure = new ComboBox();
            comboBoxGender = new ComboBox();
            panel1 = new Panel();
            labelDate = new Label();
            labelProcedure = new Label();
            labelGender = new Label();
            labelName = new Label();
            dataGridViewPrev = new DataGridView();
            panel2 = new Panel();
            labelPreview = new Label();
            buttonDelete = new Button();
            buttonReset = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrev).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.HighlightText;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Arial Narrow", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(47, 147);
            textBoxName.MaxLength = 50;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(212, 26);
            textBoxName.TabIndex = 4;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonRegInfo
            // 
            buttonRegInfo.BackColor = Color.PaleGreen;
            buttonRegInfo.Font = new Font("Malgun Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegInfo.Location = new Point(860, 307);
            buttonRegInfo.Name = "buttonRegInfo";
            buttonRegInfo.Size = new Size(171, 63);
            buttonRegInfo.TabIndex = 8;
            buttonRegInfo.Text = "Cadastrar";
            buttonRegInfo.UseVisualStyleBackColor = false;
            buttonRegInfo.Click += buttonRegInfo_Click;
            // 
            // dateTimePickerDMY
            // 
            dateTimePickerDMY.CustomFormat = "dd/MM/yyyy";
            dateTimePickerDMY.Format = DateTimePickerFormat.Custom;
            dateTimePickerDMY.Location = new Point(893, 147);
            dateTimePickerDMY.Name = "dateTimePickerDMY";
            dateTimePickerDMY.RightToLeft = RightToLeft.Yes;
            dateTimePickerDMY.RightToLeftLayout = true;
            dateTimePickerDMY.ShowUpDown = true;
            dateTimePickerDMY.Size = new Size(250, 27);
            dateTimePickerDMY.TabIndex = 9;
            // 
            // comboBoxProcedure
            // 
            comboBoxProcedure.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProcedure.FormattingEnabled = true;
            comboBoxProcedure.Items.AddRange(new object[] { "Abertura de Firma", "Autenticação", "Reconhecimento", "Sinal Público" });
            comboBoxProcedure.Location = new Point(617, 147);
            comboBoxProcedure.Name = "comboBoxProcedure";
            comboBoxProcedure.Size = new Size(212, 28);
            comboBoxProcedure.TabIndex = 10;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Feminino", "Masculino" });
            comboBoxGender.Location = new Point(325, 147);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(212, 28);
            comboBoxGender.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(labelProcedure);
            panel1.Controls.Add(labelGender);
            panel1.Controls.Add(labelName);
            panel1.Location = new Point(1, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1153, 53);
            panel1.TabIndex = 12;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = Color.Transparent;
            labelDate.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(910, 10);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(203, 34);
            labelDate.TabIndex = 17;
            labelDate.Text = "Data da Visita";
            // 
            // labelProcedure
            // 
            labelProcedure.AutoSize = true;
            labelProcedure.BackColor = Color.Transparent;
            labelProcedure.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProcedure.Location = new Point(659, 10);
            labelProcedure.Name = "labelProcedure";
            labelProcedure.Size = new Size(116, 34);
            labelProcedure.TabIndex = 17;
            labelProcedure.Text = "Serviço";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.BackColor = Color.Transparent;
            labelGender.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGender.Location = new Point(365, 10);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(119, 34);
            labelGender.TabIndex = 16;
            labelGender.Text = "Gênero";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(90, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(98, 34);
            labelName.TabIndex = 15;
            labelName.Text = "Nome";
            // 
            // dataGridViewPrev
            // 
            dataGridViewPrev.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewPrev.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrev.Location = new Point(38, 307);
            dataGridViewPrev.Name = "dataGridViewPrev";
            dataGridViewPrev.RowHeadersWidth = 51;
            dataGridViewPrev.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPrev.Size = new Size(701, 234);
            dataGridViewPrev.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(labelPreview);
            panel2.Location = new Point(260, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 53);
            panel2.TabIndex = 13;
            // 
            // labelPreview
            // 
            labelPreview.AutoSize = true;
            labelPreview.BackColor = Color.Transparent;
            labelPreview.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPreview.Location = new Point(81, 10);
            labelPreview.Name = "labelPreview";
            labelPreview.Size = new Size(99, 34);
            labelPreview.TabIndex = 18;
            labelPreview.Text = "Prévia";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.PaleTurquoise;
            buttonDelete.Font = new Font("Malgun Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(860, 394);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(171, 63);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Deletar";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.PaleVioletRed;
            buttonReset.Font = new Font("Malgun Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(860, 477);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(171, 63);
            buttonReset.TabIndex = 15;
            buttonReset.Text = "Resetar";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // FormVisitors
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1155, 553);
            Controls.Add(buttonReset);
            Controls.Add(buttonDelete);
            Controls.Add(panel2);
            Controls.Add(dataGridViewPrev);
            Controls.Add(comboBoxGender);
            Controls.Add(comboBoxProcedure);
            Controls.Add(dateTimePickerDMY);
            Controls.Add(buttonRegInfo);
            Controls.Add(textBoxName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1173, 600);
            MinimizeBox = false;
            MinimumSize = new Size(1173, 600);
            Name = "FormVisitors";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormVisitors_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrev).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonRegInfo;
        private Button buttonDelete;
        private Button buttonReset;
        private DataGridView dataGridViewPrev;
        private TextBox textBoxName;
        private ComboBox comboBoxProcedure;
        private ComboBox comboBoxGender;
        private DateTimePicker dateTimePickerDMY;
        private Panel panel1;
        private Panel panel2;
        private Label labelName;
        private Label labelGender;
        private Label labelProcedure;
        private Label labelDate;
        private Label labelPreview;
    }
}