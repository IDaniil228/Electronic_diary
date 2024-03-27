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
            this.BtnEnter = new System.Windows.Forms.Button();
            this.TimeSubjectLable = new System.Windows.Forms.Label();
            this.SubjectTitleLable = new System.Windows.Forms.Label();
            this.DateSubjectLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnEnter
            // 
            this.BtnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnter.Location = new System.Drawing.Point(135, 353);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(122, 47);
            this.BtnEnter.TabIndex = 10;
            this.BtnEnter.Text = " ОК";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // TimeSubjectLable
            // 
            this.TimeSubjectLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeSubjectLable.Location = new System.Drawing.Point(12, 114);
            this.TimeSubjectLable.Name = "TimeSubjectLable";
            this.TimeSubjectLable.Size = new System.Drawing.Size(383, 25);
            this.TimeSubjectLable.TabIndex = 11;
            this.TimeSubjectLable.Text = "Время";
            this.TimeSubjectLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubjectTitleLable
            // 
            this.SubjectTitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectTitleLable.Location = new System.Drawing.Point(12, 9);
            this.SubjectTitleLable.Name = "SubjectTitleLable";
            this.SubjectTitleLable.Size = new System.Drawing.Size(383, 25);
            this.SubjectTitleLable.TabIndex = 12;
            this.SubjectTitleLable.Text = "Предмет";
            this.SubjectTitleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateSubjectLabel
            // 
            this.DateSubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateSubjectLabel.Location = new System.Drawing.Point(12, 58);
            this.DateSubjectLabel.Name = "DateSubjectLabel";
            this.DateSubjectLabel.Size = new System.Drawing.Size(383, 25);
            this.DateSubjectLabel.TabIndex = 13;
            this.DateSubjectLabel.Text = "Дата";
            this.DateSubjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(17, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(378, 205);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // CardOfSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 478);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DateSubjectLabel);
            this.Controls.Add(this.SubjectTitleLable);
            this.Controls.Add(this.TimeSubjectLable);
            this.Controls.Add(this.BtnEnter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardOfSubjectForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label TimeSubjectLable;
        private System.Windows.Forms.Label SubjectTitleLable;
        private System.Windows.Forms.Label DateSubjectLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}