namespace Electronic_magazine
{
    partial class CardOfSubjectForm
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
            BtnEnter = new Button();
            SubjectTitleLable = new Label();
            DescriptionLabel = new Label();
            NotesRichTextBox = new RichTextBox();
            NoteLable = new Label();
            ClassroomLable = new Label();
            SuspendLayout();
            // 
            // BtnEnter
            // 
            BtnEnter.Cursor = Cursors.Hand;
            BtnEnter.FlatStyle = FlatStyle.Flat;
            BtnEnter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnEnter.Location = new Point(145, 479);
            BtnEnter.Margin = new Padding(3, 4, 3, 4);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(122, 59);
            BtnEnter.TabIndex = 10;
            BtnEnter.Text = " ОК";
            BtnEnter.UseVisualStyleBackColor = true;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // SubjectTitleLable
            // 
            SubjectTitleLable.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            SubjectTitleLable.Location = new Point(12, 20);
            SubjectTitleLable.Name = "SubjectTitleLable";
            SubjectTitleLable.Size = new Size(383, 31);
            SubjectTitleLable.TabIndex = 12;
            SubjectTitleLable.Text = "Предмет";
            SubjectTitleLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            DescriptionLabel.Location = new Point(12, 102);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(383, 76);
            DescriptionLabel.TabIndex = 13;
            DescriptionLabel.Text = "Описание";
            DescriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NotesRichTextBox
            // 
            NotesRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            NotesRichTextBox.Location = new Point(17, 213);
            NotesRichTextBox.Margin = new Padding(3, 4, 3, 4);
            NotesRichTextBox.Name = "NotesRichTextBox";
            NotesRichTextBox.Size = new Size(378, 205);
            NotesRichTextBox.TabIndex = 14;
            NotesRichTextBox.Text = "";
            // 
            // NoteLable
            // 
            NoteLable.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NoteLable.Location = new Point(17, 178);
            NoteLable.Name = "NoteLable";
            NoteLable.Size = new Size(104, 31);
            NoteLable.TabIndex = 15;
            NoteLable.Text = "Заметки";
            NoteLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClassroomLable
            // 
            ClassroomLable.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            ClassroomLable.Location = new Point(12, 60);
            ClassroomLable.Name = "ClassroomLable";
            ClassroomLable.Size = new Size(383, 29);
            ClassroomLable.TabIndex = 16;
            ClassroomLable.Text = "Дата";
            ClassroomLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardOfSubjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 598);
            Controls.Add(ClassroomLable);
            Controls.Add(NoteLable);
            Controls.Add(NotesRichTextBox);
            Controls.Add(DescriptionLabel);
            Controls.Add(SubjectTitleLable);
            Controls.Add(BtnEnter);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CardOfSubjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += CardOfSubjectForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label DurationLable;
        private System.Windows.Forms.Label SubjectTitleLable;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.RichTextBox NotesRichTextBox;
        private Label NoteLable;
        private Label ClassroomLable;
    }
}