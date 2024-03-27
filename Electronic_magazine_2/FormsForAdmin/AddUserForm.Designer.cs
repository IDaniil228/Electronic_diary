namespace Electronic_diary.FormsForAdmin
{
    partial class AddUserForm
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
            UpperPanel = new Panel();
            BtnMinimaze = new Button();
            BtnClose = new Button();
            panel1 = new Panel();
            BtnEnter = new Button();
            GroupLable = new Label();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            LoginLable = new Label();
            PasswordLable = new Label();
            PatronymicTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            NameTextBox = new TextBox();
            PatronymicLabel = new Label();
            SurnameLabel = new Label();
            NameLabel = new Label();
            SelectRole = new ComboBox();
            label35 = new Label();
            GroupComboBox = new ComboBox();
            UpperPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // UpperPanel
            // 
            UpperPanel.BackColor = Color.White;
            UpperPanel.Controls.Add(BtnMinimaze);
            UpperPanel.Controls.Add(BtnClose);
            UpperPanel.Dock = DockStyle.Top;
            UpperPanel.Location = new Point(0, 0);
            UpperPanel.Margin = new Padding(3, 4, 3, 4);
            UpperPanel.Name = "UpperPanel";
            UpperPanel.Size = new Size(645, 41);
            UpperPanel.TabIndex = 2;
            // 
            // BtnMinimaze
            // 
            BtnMinimaze.BackColor = Color.White;
            BtnMinimaze.Cursor = Cursors.Hand;
            BtnMinimaze.Dock = DockStyle.Right;
            BtnMinimaze.FlatStyle = FlatStyle.Flat;
            BtnMinimaze.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnMinimaze.Location = new Point(575, 0);
            BtnMinimaze.Margin = new Padding(3, 4, 3, 4);
            BtnMinimaze.Name = "BtnMinimaze";
            BtnMinimaze.Size = new Size(35, 41);
            BtnMinimaze.TabIndex = 10;
            BtnMinimaze.Text = "—\r\n";
            BtnMinimaze.UseVisualStyleBackColor = false;
            BtnMinimaze.Click += BtnMinimaze_Click;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.White;
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.Dock = DockStyle.Right;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnClose.Location = new Point(610, 0);
            BtnClose.Margin = new Padding(3, 4, 3, 4);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(35, 41);
            BtnClose.TabIndex = 9;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(GroupComboBox);
            panel1.Controls.Add(BtnEnter);
            panel1.Controls.Add(GroupLable);
            panel1.Controls.Add(PasswordTextBox);
            panel1.Controls.Add(LoginTextBox);
            panel1.Controls.Add(LoginLable);
            panel1.Controls.Add(PasswordLable);
            panel1.Controls.Add(PatronymicTextBox);
            panel1.Controls.Add(SurnameTextBox);
            panel1.Controls.Add(NameTextBox);
            panel1.Controls.Add(PatronymicLabel);
            panel1.Controls.Add(SurnameLabel);
            panel1.Controls.Add(NameLabel);
            panel1.Controls.Add(SelectRole);
            panel1.Controls.Add(label35);
            panel1.Location = new Point(0, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 498);
            panel1.TabIndex = 3;
            // 
            // BtnEnter
            // 
            BtnEnter.BackColor = SystemColors.ControlLight;
            BtnEnter.Cursor = Cursors.Hand;
            BtnEnter.FlatStyle = FlatStyle.Flat;
            BtnEnter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnEnter.Location = new Point(216, 427);
            BtnEnter.Margin = new Padding(3, 4, 3, 4);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(218, 59);
            BtnEnter.TabIndex = 51;
            BtnEnter.Text = "Зарегестрировать";
            BtnEnter.UseVisualStyleBackColor = false;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // GroupLable
            // 
            GroupLable.Enabled = false;
            GroupLable.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupLable.Location = new Point(377, 281);
            GroupLable.Name = "GroupLable";
            GroupLable.Size = new Size(88, 35);
            GroupLable.TabIndex = 49;
            GroupLable.Text = "Группа";
            GroupLable.TextAlign = ContentAlignment.MiddleCenter;
            GroupLable.Visible = false;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = SystemColors.ControlLight;
            PasswordTextBox.Cursor = Cursors.Hand;
            PasswordTextBox.Enabled = false;
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(377, 219);
            PasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(259, 37);
            PasswordTextBox.TabIndex = 48;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BackColor = SystemColors.ControlLight;
            LoginTextBox.Cursor = Cursors.Hand;
            LoginTextBox.Enabled = false;
            LoginTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginTextBox.Location = new Point(377, 126);
            LoginTextBox.Margin = new Padding(3, 4, 3, 4);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(259, 37);
            LoginTextBox.TabIndex = 47;
            // 
            // LoginLable
            // 
            LoginLable.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginLable.Location = new Point(377, 87);
            LoginLable.Name = "LoginLable";
            LoginLable.Size = new Size(88, 35);
            LoginLable.TabIndex = 46;
            LoginLable.Text = "Логин";
            LoginLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordLable
            // 
            PasswordLable.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PasswordLable.Location = new Point(377, 180);
            PasswordLable.Name = "PasswordLable";
            PasswordLable.Size = new Size(88, 35);
            PasswordLable.TabIndex = 45;
            PasswordLable.Text = "Пароль";
            PasswordLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.BackColor = SystemColors.ControlLight;
            PatronymicTextBox.Cursor = Cursors.Hand;
            PatronymicTextBox.Enabled = false;
            PatronymicTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PatronymicTextBox.Location = new Point(12, 320);
            PatronymicTextBox.Margin = new Padding(3, 4, 3, 4);
            PatronymicTextBox.Multiline = true;
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(259, 37);
            PatronymicTextBox.TabIndex = 44;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.BackColor = SystemColors.ControlLight;
            SurnameTextBox.Cursor = Cursors.Hand;
            SurnameTextBox.Enabled = false;
            SurnameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurnameTextBox.Location = new Point(12, 219);
            SurnameTextBox.Margin = new Padding(3, 4, 3, 4);
            SurnameTextBox.Multiline = true;
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(259, 37);
            SurnameTextBox.TabIndex = 43;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = SystemColors.ControlLight;
            NameTextBox.Cursor = Cursors.Hand;
            NameTextBox.Enabled = false;
            NameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameTextBox.Location = new Point(12, 126);
            NameTextBox.Margin = new Padding(3, 4, 3, 4);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(259, 37);
            NameTextBox.TabIndex = 42;
            // 
            // PatronymicLabel
            // 
            PatronymicLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PatronymicLabel.Location = new Point(0, 281);
            PatronymicLabel.Name = "PatronymicLabel";
            PatronymicLabel.Size = new Size(134, 35);
            PatronymicLabel.TabIndex = 41;
            PatronymicLabel.Text = "Отчество";
            PatronymicLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SurnameLabel
            // 
            SurnameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurnameLabel.Location = new Point(3, 180);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(131, 35);
            SurnameLabel.TabIndex = 40;
            SurnameLabel.Text = "Фамилия";
            SurnameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            NameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(3, 87);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(88, 35);
            NameLabel.TabIndex = 39;
            NameLabel.Text = "Имя";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SelectRole
            // 
            SelectRole.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SelectRole.FormattingEnabled = true;
            SelectRole.Items.AddRange(new object[] { "Студент", "Администратор" });
            SelectRole.Location = new Point(206, 38);
            SelectRole.Name = "SelectRole";
            SelectRole.Size = new Size(259, 36);
            SelectRole.TabIndex = 38;
            SelectRole.SelectedIndexChanged += SelectRole_SelectedIndexChanged;
            // 
            // label35
            // 
            label35.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label35.Location = new Point(261, 0);
            label35.Name = "label35";
            label35.Size = new Size(148, 35);
            label35.TabIndex = 37;
            label35.Text = "Кого создать";
            label35.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GroupComboBox
            // 
            GroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GroupComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GroupComboBox.FormattingEnabled = true;
            GroupComboBox.Items.AddRange(new object[] { "09-321", "09-322" });
            GroupComboBox.Location = new Point(377, 317);
            GroupComboBox.Name = "GroupComboBox";
            GroupComboBox.Size = new Size(259, 36);
            GroupComboBox.TabIndex = 52;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(645, 547);
            Controls.Add(panel1);
            Controls.Add(UpperPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUserForm";
            Text = "AddUser";
            UpperPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel UpperPanel;
        private Button BtnMinimaze;
        private Button BtnClose;
        private Panel panel1;
        private Label label35;
        private ComboBox SelectRole;
        private Label PatronymicLabel;
        private Label SurnameLabel;
        private Label NameLabel;
        private TextBox PatronymicTextBox;
        private TextBox SurnameTextBox;
        private TextBox NameTextBox;
        private Label GroupLable;
        private TextBox PasswordTextBox;
        private TextBox LoginTextBox;
        private Label LoginLable;
        private Label PasswordLable;
        private Button BtnEnter;
        private ComboBox GroupComboBox;
    }
}