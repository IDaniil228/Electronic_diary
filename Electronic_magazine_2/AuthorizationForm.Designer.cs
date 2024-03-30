namespace Electronic_magazine
{
    partial class AuthorizationForm
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
            button1 = new Button();
            panel1 = new Panel();
            BtnMinimaze = new Button();
            BtnClose = new Button();
            panel2 = new Panel();
            ShowPassword = new CheckBox();
            EnterLikeLible = new Label();
            SelectRole = new ComboBox();
            AuthorizationLabel = new Label();
            BtnEnter = new Button();
            PasswordTextBox = new TextBox();
            LoginTextBox = new TextBox();
            PasswordLabel = new Label();
            LoginLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(402, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(30, 38);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(BtnMinimaze);
            panel1.Controls.Add(BtnClose);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 41);
            panel1.TabIndex = 8;
            // 
            // BtnMinimaze
            // 
            BtnMinimaze.BackColor = Color.White;
            BtnMinimaze.Cursor = Cursors.Hand;
            BtnMinimaze.Dock = DockStyle.Right;
            BtnMinimaze.FlatStyle = FlatStyle.Flat;
            BtnMinimaze.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnMinimaze.Location = new Point(362, 0);
            BtnMinimaze.Margin = new Padding(3, 4, 3, 4);
            BtnMinimaze.Name = "BtnMinimaze";
            BtnMinimaze.Size = new Size(35, 41);
            BtnMinimaze.TabIndex = 12;
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
            BtnClose.Location = new Point(397, 0);
            BtnClose.Margin = new Padding(3, 4, 3, 4);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(35, 41);
            BtnClose.TabIndex = 11;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(ShowPassword);
            panel2.Controls.Add(EnterLikeLible);
            panel2.Controls.Add(SelectRole);
            panel2.Controls.Add(AuthorizationLabel);
            panel2.Controls.Add(BtnEnter);
            panel2.Controls.Add(PasswordTextBox);
            panel2.Controls.Add(LoginTextBox);
            panel2.Controls.Add(PasswordLabel);
            panel2.Controls.Add(LoginLabel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 48);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 518);
            panel2.TabIndex = 9;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Location = new Point(89, 347);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(150, 24);
            ShowPassword.TabIndex = 10;
            ShowPassword.Text = "Показать пароль";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // EnterLikeLible
            // 
            EnterLikeLible.AutoSize = true;
            EnterLikeLible.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EnterLikeLible.Location = new Point(89, 96);
            EnterLikeLible.Name = "EnterLikeLible";
            EnterLikeLible.Size = new Size(113, 25);
            EnterLikeLible.TabIndex = 14;
            EnterLikeLible.Text = "Войти как\r\n";
            // 
            // SelectRole
            // 
            SelectRole.DropDownStyle = ComboBoxStyle.DropDownList;
            SelectRole.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SelectRole.FormattingEnabled = true;
            SelectRole.Items.AddRange(new object[] { "Студент", "Администратор" });
            SelectRole.Location = new Point(89, 124);
            SelectRole.Name = "SelectRole";
            SelectRole.Size = new Size(259, 36);
            SelectRole.TabIndex = 13;
            // 
            // AuthorizationLabel
            // 
            AuthorizationLabel.AutoSize = true;
            AuthorizationLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AuthorizationLabel.Location = new Point(133, 22);
            AuthorizationLabel.Name = "AuthorizationLabel";
            AuthorizationLabel.Size = new Size(146, 25);
            AuthorizationLabel.TabIndex = 12;
            AuthorizationLabel.Text = "Авторизация";
            AuthorizationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnEnter
            // 
            BtnEnter.BackColor = SystemColors.ControlLight;
            BtnEnter.Cursor = Cursors.Hand;
            BtnEnter.FlatStyle = FlatStyle.Flat;
            BtnEnter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnEnter.Location = new Point(157, 420);
            BtnEnter.Margin = new Padding(3, 4, 3, 4);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(122, 59);
            BtnEnter.TabIndex = 11;
            BtnEnter.Text = "Вход";
            BtnEnter.UseVisualStyleBackColor = false;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = SystemColors.ControlLight;
            PasswordTextBox.Cursor = Cursors.Hand;
            PasswordTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(89, 303);
            PasswordTextBox.Margin = new Padding(3, 4, 3, 4);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(259, 30);
            PasswordTextBox.TabIndex = 10;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BackColor = SystemColors.ControlLight;
            LoginTextBox.Cursor = Cursors.Hand;
            LoginTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginTextBox.Location = new Point(89, 213);
            LoginTextBox.Margin = new Padding(3, 4, 3, 4);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(259, 37);
            LoginTextBox.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PasswordLabel.Location = new Point(84, 268);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(86, 25);
            PasswordLabel.TabIndex = 8;
            PasswordLabel.Text = "Пароль";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginLabel.Location = new Point(84, 178);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(73, 25);
            LoginLabel.TabIndex = 7;
            LoginLabel.Text = "Логин";
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(432, 566);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AuthorizationForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Журнал";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AuthorizationLabel;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button BtnMinimaze;
        private ComboBox SelectRole;
        private Label EnterLikeLible;
        private CheckBox ShowPassword;
    }
}

