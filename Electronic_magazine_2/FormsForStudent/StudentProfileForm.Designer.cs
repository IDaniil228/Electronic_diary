namespace Electronic_magazine.Forms
{
    partial class StudentProfileForm
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
            panel1 = new Panel();
            BtnClose = new Button();
            panel2 = new Panel();
            BtnChange = new Button();
            BtnSave = new Button();
            EmailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            BtnEdit = new Button();
            GroupLabel = new Label();
            EmailLabel = new Label();
            PhoneLabel = new Label();
            LineLibel = new Label();
            PatronymicLabel = new Label();
            NameLable = new Label();
            SurnameLabel = new Label();
            ProfileLabel = new Label();
            PhotoPictureBox = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BtnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 41);
            panel1.TabIndex = 17;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.White;
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.Dock = DockStyle.Right;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnClose.Location = new Point(502, 0);
            BtnClose.Margin = new Padding(3, 4, 3, 4);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(35, 41);
            BtnClose.TabIndex = 10;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(BtnChange);
            panel2.Controls.Add(BtnSave);
            panel2.Controls.Add(EmailTextBox);
            panel2.Controls.Add(PhoneTextBox);
            panel2.Controls.Add(BtnEdit);
            panel2.Controls.Add(GroupLabel);
            panel2.Controls.Add(EmailLabel);
            panel2.Controls.Add(PhoneLabel);
            panel2.Controls.Add(LineLibel);
            panel2.Controls.Add(PatronymicLabel);
            panel2.Controls.Add(NameLable);
            panel2.Controls.Add(SurnameLabel);
            panel2.Controls.Add(ProfileLabel);
            panel2.Controls.Add(PhotoPictureBox);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 48);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 638);
            panel2.TabIndex = 0;
            // 
            // BtnChange
            // 
            BtnChange.BackColor = Color.White;
            BtnChange.Enabled = false;
            BtnChange.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnChange.Location = new Point(353, 175);
            BtnChange.Margin = new Padding(3, 4, 3, 4);
            BtnChange.Name = "BtnChange";
            BtnChange.Size = new Size(126, 35);
            BtnChange.TabIndex = 30;
            BtnChange.Text = "Изменить";
            BtnChange.UseVisualStyleBackColor = false;
            BtnChange.Visible = false;
            BtnChange.Click += BtnChange_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.White;
            BtnSave.Enabled = false;
            BtnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnSave.Location = new Point(187, 580);
            BtnSave.Margin = new Padding(3, 4, 3, 4);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(164, 45);
            BtnSave.TabIndex = 29;
            BtnSave.Text = "Сохранить";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Visible = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = SystemColors.ControlLight;
            EmailTextBox.Cursor = Cursors.Hand;
            EmailTextBox.Enabled = false;
            EmailTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EmailTextBox.Location = new Point(147, 473);
            EmailTextBox.Margin = new Padding(3, 4, 3, 4);
            EmailTextBox.Multiline = true;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(259, 37);
            EmailTextBox.TabIndex = 28;
            EmailTextBox.Visible = false;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.BackColor = SystemColors.ControlLight;
            PhoneTextBox.Cursor = Cursors.Hand;
            PhoneTextBox.Enabled = false;
            PhoneTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PhoneTextBox.Location = new Point(187, 427);
            PhoneTextBox.Margin = new Padding(3, 4, 3, 4);
            PhoneTextBox.Multiline = true;
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(259, 37);
            PhoneTextBox.TabIndex = 27;
            PhoneTextBox.Visible = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.White;
            BtnEdit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnEdit.Location = new Point(187, 580);
            BtnEdit.Margin = new Padding(3, 4, 3, 4);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(164, 45);
            BtnEdit.TabIndex = 11;
            BtnEdit.Text = "Редактировать";
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.BackColor = Color.White;
            GroupLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupLabel.Location = new Point(72, 382);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Size = new Size(96, 25);
            GroupLabel.TabIndex = 25;
            GroupLabel.Text = "Группа -";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.BackColor = Color.White;
            EmailLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EmailLabel.Location = new Point(72, 473);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(85, 25);
            EmailLabel.TabIndex = 24;
            EmailLabel.Text = "Email - ";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.BackColor = Color.White;
            PhoneLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PhoneLabel.Location = new Point(72, 426);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(126, 25);
            PhoneLabel.TabIndex = 23;
            PhoneLabel.Text = "Телефон - ";
            // 
            // LineLibel
            // 
            LineLibel.AutoSize = true;
            LineLibel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LineLibel.Location = new Point(72, 338);
            LineLibel.Name = "LineLibel";
            LineLibel.Size = new Size(388, 25);
            LineLibel.TabIndex = 22;
            LineLibel.Text = "-----------------------------------------------";
            // 
            // PatronymicLabel
            // 
            PatronymicLabel.BackColor = Color.White;
            PatronymicLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PatronymicLabel.Location = new Point(77, 307);
            PatronymicLabel.Name = "PatronymicLabel";
            PatronymicLabel.Size = new Size(383, 31);
            PatronymicLabel.TabIndex = 21;
            PatronymicLabel.Text = "Отчество";
            PatronymicLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLable
            // 
            NameLable.BackColor = Color.White;
            NameLable.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLable.Location = new Point(77, 276);
            NameLable.Name = "NameLable";
            NameLable.Size = new Size(383, 31);
            NameLable.TabIndex = 20;
            NameLable.Text = "Имя";
            NameLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SurnameLabel
            // 
            SurnameLabel.BackColor = Color.White;
            SurnameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurnameLabel.Location = new Point(77, 245);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(383, 31);
            SurnameLabel.TabIndex = 19;
            SurnameLabel.Text = "Фамилия";
            SurnameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProfileLabel
            // 
            ProfileLabel.AutoSize = true;
            ProfileLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            ProfileLabel.Location = new Point(10, 9);
            ProfileLabel.Name = "ProfileLabel";
            ProfileLabel.Size = new Size(107, 25);
            ProfileLabel.TabIndex = 18;
            ProfileLabel.Text = "Профиль";
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.BackColor = Color.White;
            PhotoPictureBox.Location = new Point(187, 50);
            PhotoPictureBox.Margin = new Padding(3, 4, 3, 4);
            PhotoPictureBox.Name = "PhotoPictureBox";
            PhotoPictureBox.Size = new Size(160, 160);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PhotoPictureBox.TabIndex = 17;
            PhotoPictureBox.TabStop = false;
            // 
            // StudentProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(537, 686);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Журнал";
            Load += StudentProfileForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label LineLibel;
        private System.Windows.Forms.Label PatronymicLabel;
        private System.Windows.Forms.Label NameLable;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Button BtnClose;
        private Button BtnEdit;
        private TextBox EmailTextBox;
        private TextBox PhoneTextBox;
        private Button BtnSave;
        private Button BtnChange;
    }
}