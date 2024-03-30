namespace Electronic_magazine.FormsForAdmin
{
    partial class AdminMainForm
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
            panel3 = new Panel();
            FullNameLabel = new Label();
            PhotoPictureBox = new PictureBox();
            panel4 = new Panel();
            BtnExitFromAcount = new Button();
            BtnAddEvaluation = new Button();
            BtnProfile = new Button();
            BtnAddUser = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            SaturdayLesson_4_ComboBox = new ComboBox();
            FridayLesson_4_ComboBox = new ComboBox();
            ThursdayLesson_4_ComboBox = new ComboBox();
            WednesdayLesson_4_ComboBox = new ComboBox();
            TuesdayLesson_4_ComboBox = new ComboBox();
            MondayLesson_4_СomboBox = new ComboBox();
            SaturdayLesson_3_ComboBox = new ComboBox();
            FridayLesson_3_ComboBox = new ComboBox();
            ThursdayLesson_3_ComboBox = new ComboBox();
            WednesdayLesson_3_ComboBox = new ComboBox();
            TuesdayLesson_3_ComboBox = new ComboBox();
            MondayLesson_3_СomboBox = new ComboBox();
            SaturdayLesson_2_ComboBox = new ComboBox();
            FridayLesson_2_ComboBox = new ComboBox();
            ThursdayLesson_2_ComboBox = new ComboBox();
            WednesdayLesson_2_ComboBox = new ComboBox();
            TuesdayLesson_2_ComboBox = new ComboBox();
            MondayLesson_2_СomboBox = new ComboBox();
            SaturdayLesson_1_ComboBox = new ComboBox();
            FridayLesson_1_ComboBox = new ComboBox();
            ThursdayLesson_1_ComboBox = new ComboBox();
            WednesdayLesson_1_ComboBox = new ComboBox();
            TuesdayLesson_1_ComboBox = new ComboBox();
            MondayLesson_1_СomboBox = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            schedulePanel = new Panel();
            btnSave = new Button();
            BtnClearTable = new Button();
            SelectGroup = new ComboBox();
            ChengeGroupsPanel = new Panel();
            label35 = new Label();
            BtnAdd = new Button();
            AddStudentIdTextBox = new TextBox();
            BtnSaveGroup = new Button();
            SelectGroupComboBox = new ComboBox();
            ListOfStudentListView = new ListView();
            tabControl1 = new TabControl();
            Schedule = new TabPage();
            Groups = new TabPage();
            UpperPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            schedulePanel.SuspendLayout();
            ChengeGroupsPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            Schedule.SuspendLayout();
            Groups.SuspendLayout();
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
            UpperPanel.Size = new Size(1132, 41);
            UpperPanel.TabIndex = 1;
            // 
            // BtnMinimaze
            // 
            BtnMinimaze.BackColor = Color.White;
            BtnMinimaze.Cursor = Cursors.Hand;
            BtnMinimaze.Dock = DockStyle.Right;
            BtnMinimaze.FlatStyle = FlatStyle.Flat;
            BtnMinimaze.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnMinimaze.Location = new Point(1062, 0);
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
            BtnClose.Location = new Point(1097, 0);
            BtnClose.Margin = new Padding(3, 4, 3, 4);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(35, 41);
            BtnClose.TabIndex = 9;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(FullNameLabel);
            panel3.Controls.Add(PhotoPictureBox);
            panel3.Location = new Point(0, 49);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(227, 260);
            panel3.TabIndex = 2;
            // 
            // FullNameLabel
            // 
            FullNameLabel.BackColor = Color.White;
            FullNameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(0, 168);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(227, 92);
            FullNameLabel.TabIndex = 36;
            FullNameLabel.Text = "ФИО\r\n";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.BackColor = Color.White;
            PhotoPictureBox.Location = new Point(48, 29);
            PhotoPictureBox.Margin = new Padding(3, 4, 3, 4);
            PhotoPictureBox.Name = "PhotoPictureBox";
            PhotoPictureBox.Size = new Size(135, 135);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PhotoPictureBox.TabIndex = 35;
            PhotoPictureBox.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(BtnExitFromAcount);
            panel4.Controls.Add(BtnAddEvaluation);
            panel4.Controls.Add(BtnProfile);
            panel4.Controls.Add(BtnAddUser);
            panel4.Location = new Point(0, 316);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(227, 484);
            panel4.TabIndex = 3;
            // 
            // BtnExitFromAcount
            // 
            BtnExitFromAcount.BackColor = Color.White;
            BtnExitFromAcount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnExitFromAcount.Location = new Point(37, 302);
            BtnExitFromAcount.Margin = new Padding(3, 4, 3, 4);
            BtnExitFromAcount.Name = "BtnExitFromAcount";
            BtnExitFromAcount.Size = new Size(164, 60);
            BtnExitFromAcount.TabIndex = 6;
            BtnExitFromAcount.Text = "Выйти из аккаунта";
            BtnExitFromAcount.UseVisualStyleBackColor = false;
            BtnExitFromAcount.Click += BtnExitFromAcount_Click;
            // 
            // BtnAddEvaluation
            // 
            BtnAddEvaluation.BackColor = Color.White;
            BtnAddEvaluation.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnAddEvaluation.Location = new Point(37, 142);
            BtnAddEvaluation.Margin = new Padding(3, 4, 3, 4);
            BtnAddEvaluation.Name = "BtnAddEvaluation";
            BtnAddEvaluation.Size = new Size(164, 60);
            BtnAddEvaluation.TabIndex = 5;
            BtnAddEvaluation.Text = "Выставить оценки ";
            BtnAddEvaluation.UseVisualStyleBackColor = false;
            BtnAddEvaluation.Click += BtnAddEvaluation_Click;
            // 
            // BtnProfile
            // 
            BtnProfile.BackColor = Color.White;
            BtnProfile.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnProfile.Location = new Point(37, 61);
            BtnProfile.Margin = new Padding(3, 4, 3, 4);
            BtnProfile.Name = "BtnProfile";
            BtnProfile.Size = new Size(164, 60);
            BtnProfile.TabIndex = 4;
            BtnProfile.Text = "Профиль";
            BtnProfile.UseVisualStyleBackColor = false;
            BtnProfile.Click += BtnProfile_Click;
            // 
            // BtnAddUser
            // 
            BtnAddUser.BackColor = Color.White;
            BtnAddUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnAddUser.Location = new Point(37, 221);
            BtnAddUser.Margin = new Padding(3, 4, 3, 4);
            BtnAddUser.Name = "BtnAddUser";
            BtnAddUser.Size = new Size(164, 60);
            BtnAddUser.TabIndex = 3;
            BtnAddUser.Text = "Создать пользователя";
            BtnAddUser.UseVisualStyleBackColor = false;
            BtnAddUser.Click += BtnAddUser_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Controls.Add(SaturdayLesson_4_ComboBox, 6, 4);
            tableLayoutPanel1.Controls.Add(FridayLesson_4_ComboBox, 5, 4);
            tableLayoutPanel1.Controls.Add(ThursdayLesson_4_ComboBox, 4, 4);
            tableLayoutPanel1.Controls.Add(WednesdayLesson_4_ComboBox, 3, 4);
            tableLayoutPanel1.Controls.Add(TuesdayLesson_4_ComboBox, 2, 4);
            tableLayoutPanel1.Controls.Add(MondayLesson_4_СomboBox, 1, 4);
            tableLayoutPanel1.Controls.Add(SaturdayLesson_3_ComboBox, 6, 3);
            tableLayoutPanel1.Controls.Add(FridayLesson_3_ComboBox, 5, 3);
            tableLayoutPanel1.Controls.Add(ThursdayLesson_3_ComboBox, 4, 3);
            tableLayoutPanel1.Controls.Add(WednesdayLesson_3_ComboBox, 3, 3);
            tableLayoutPanel1.Controls.Add(TuesdayLesson_3_ComboBox, 2, 3);
            tableLayoutPanel1.Controls.Add(MondayLesson_3_СomboBox, 1, 3);
            tableLayoutPanel1.Controls.Add(SaturdayLesson_2_ComboBox, 6, 2);
            tableLayoutPanel1.Controls.Add(FridayLesson_2_ComboBox, 5, 2);
            tableLayoutPanel1.Controls.Add(ThursdayLesson_2_ComboBox, 4, 2);
            tableLayoutPanel1.Controls.Add(WednesdayLesson_2_ComboBox, 3, 2);
            tableLayoutPanel1.Controls.Add(TuesdayLesson_2_ComboBox, 2, 2);
            tableLayoutPanel1.Controls.Add(MondayLesson_2_СomboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(SaturdayLesson_1_ComboBox, 6, 1);
            tableLayoutPanel1.Controls.Add(FridayLesson_1_ComboBox, 5, 1);
            tableLayoutPanel1.Controls.Add(ThursdayLesson_1_ComboBox, 4, 1);
            tableLayoutPanel1.Controls.Add(WednesdayLesson_1_ComboBox, 3, 1);
            tableLayoutPanel1.Controls.Add(TuesdayLesson_1_ComboBox, 2, 1);
            tableLayoutPanel1.Controls.Add(MondayLesson_1_СomboBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label6, 3, 0);
            tableLayoutPanel1.Controls.Add(label13, 4, 0);
            tableLayoutPanel1.Controls.Add(label15, 5, 0);
            tableLayoutPanel1.Controls.Add(label16, 6, 0);
            tableLayoutPanel1.Controls.Add(label31, 0, 1);
            tableLayoutPanel1.Controls.Add(label32, 0, 2);
            tableLayoutPanel1.Controls.Add(label33, 0, 3);
            tableLayoutPanel1.Controls.Add(label34, 0, 4);
            tableLayoutPanel1.Location = new Point(3, 48);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.927F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.193512F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2931614F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2931614F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2931614F));
            tableLayoutPanel1.Size = new Size(879, 666);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // SaturdayLesson_4_ComboBox
            // 
            SaturdayLesson_4_ComboBox.FormattingEnabled = true;
            SaturdayLesson_4_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            SaturdayLesson_4_ComboBox.Location = new Point(756, 507);
            SaturdayLesson_4_ComboBox.Name = "SaturdayLesson_4_ComboBox";
            SaturdayLesson_4_ComboBox.Size = new Size(117, 28);
            SaturdayLesson_4_ComboBox.TabIndex = 57;
            // 
            // FridayLesson_4_ComboBox
            // 
            FridayLesson_4_ComboBox.FormattingEnabled = true;
            FridayLesson_4_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            FridayLesson_4_ComboBox.Location = new Point(631, 507);
            FridayLesson_4_ComboBox.Name = "FridayLesson_4_ComboBox";
            FridayLesson_4_ComboBox.Size = new Size(116, 28);
            FridayLesson_4_ComboBox.TabIndex = 56;
            // 
            // ThursdayLesson_4_ComboBox
            // 
            ThursdayLesson_4_ComboBox.FormattingEnabled = true;
            ThursdayLesson_4_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            ThursdayLesson_4_ComboBox.Location = new Point(506, 507);
            ThursdayLesson_4_ComboBox.Name = "ThursdayLesson_4_ComboBox";
            ThursdayLesson_4_ComboBox.Size = new Size(116, 28);
            ThursdayLesson_4_ComboBox.TabIndex = 55;
            // 
            // WednesdayLesson_4_ComboBox
            // 
            WednesdayLesson_4_ComboBox.FormattingEnabled = true;
            WednesdayLesson_4_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            WednesdayLesson_4_ComboBox.Location = new Point(381, 507);
            WednesdayLesson_4_ComboBox.Name = "WednesdayLesson_4_ComboBox";
            WednesdayLesson_4_ComboBox.Size = new Size(116, 28);
            WednesdayLesson_4_ComboBox.TabIndex = 54;
            // 
            // TuesdayLesson_4_ComboBox
            // 
            TuesdayLesson_4_ComboBox.FormattingEnabled = true;
            TuesdayLesson_4_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            TuesdayLesson_4_ComboBox.Location = new Point(256, 507);
            TuesdayLesson_4_ComboBox.Name = "TuesdayLesson_4_ComboBox";
            TuesdayLesson_4_ComboBox.Size = new Size(116, 28);
            TuesdayLesson_4_ComboBox.TabIndex = 53;
            // 
            // MondayLesson_4_СomboBox
            // 
            MondayLesson_4_СomboBox.FormattingEnabled = true;
            MondayLesson_4_СomboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            MondayLesson_4_СomboBox.Location = new Point(131, 507);
            MondayLesson_4_СomboBox.Name = "MondayLesson_4_СomboBox";
            MondayLesson_4_СomboBox.Size = new Size(116, 28);
            MondayLesson_4_СomboBox.TabIndex = 52;
            // 
            // SaturdayLesson_3_ComboBox
            // 
            SaturdayLesson_3_ComboBox.FormattingEnabled = true;
            SaturdayLesson_3_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            SaturdayLesson_3_ComboBox.Location = new Point(756, 347);
            SaturdayLesson_3_ComboBox.Name = "SaturdayLesson_3_ComboBox";
            SaturdayLesson_3_ComboBox.Size = new Size(117, 28);
            SaturdayLesson_3_ComboBox.TabIndex = 51;
            // 
            // FridayLesson_3_ComboBox
            // 
            FridayLesson_3_ComboBox.FormattingEnabled = true;
            FridayLesson_3_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            FridayLesson_3_ComboBox.Location = new Point(631, 347);
            FridayLesson_3_ComboBox.Name = "FridayLesson_3_ComboBox";
            FridayLesson_3_ComboBox.Size = new Size(116, 28);
            FridayLesson_3_ComboBox.TabIndex = 50;
            // 
            // ThursdayLesson_3_ComboBox
            // 
            ThursdayLesson_3_ComboBox.FormattingEnabled = true;
            ThursdayLesson_3_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            ThursdayLesson_3_ComboBox.Location = new Point(506, 347);
            ThursdayLesson_3_ComboBox.Name = "ThursdayLesson_3_ComboBox";
            ThursdayLesson_3_ComboBox.Size = new Size(116, 28);
            ThursdayLesson_3_ComboBox.TabIndex = 49;
            // 
            // WednesdayLesson_3_ComboBox
            // 
            WednesdayLesson_3_ComboBox.FormattingEnabled = true;
            WednesdayLesson_3_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            WednesdayLesson_3_ComboBox.Location = new Point(381, 347);
            WednesdayLesson_3_ComboBox.Name = "WednesdayLesson_3_ComboBox";
            WednesdayLesson_3_ComboBox.Size = new Size(116, 28);
            WednesdayLesson_3_ComboBox.TabIndex = 48;
            // 
            // TuesdayLesson_3_ComboBox
            // 
            TuesdayLesson_3_ComboBox.FormattingEnabled = true;
            TuesdayLesson_3_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            TuesdayLesson_3_ComboBox.Location = new Point(256, 347);
            TuesdayLesson_3_ComboBox.Name = "TuesdayLesson_3_ComboBox";
            TuesdayLesson_3_ComboBox.Size = new Size(116, 28);
            TuesdayLesson_3_ComboBox.TabIndex = 47;
            // 
            // MondayLesson_3_СomboBox
            // 
            MondayLesson_3_СomboBox.FormattingEnabled = true;
            MondayLesson_3_СomboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            MondayLesson_3_СomboBox.Location = new Point(131, 347);
            MondayLesson_3_СomboBox.Name = "MondayLesson_3_СomboBox";
            MondayLesson_3_СomboBox.Size = new Size(116, 28);
            MondayLesson_3_СomboBox.TabIndex = 46;
            // 
            // SaturdayLesson_2_ComboBox
            // 
            SaturdayLesson_2_ComboBox.FormattingEnabled = true;
            SaturdayLesson_2_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            SaturdayLesson_2_ComboBox.Location = new Point(756, 187);
            SaturdayLesson_2_ComboBox.Name = "SaturdayLesson_2_ComboBox";
            SaturdayLesson_2_ComboBox.Size = new Size(117, 28);
            SaturdayLesson_2_ComboBox.TabIndex = 45;
            // 
            // FridayLesson_2_ComboBox
            // 
            FridayLesson_2_ComboBox.FormattingEnabled = true;
            FridayLesson_2_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            FridayLesson_2_ComboBox.Location = new Point(631, 187);
            FridayLesson_2_ComboBox.Name = "FridayLesson_2_ComboBox";
            FridayLesson_2_ComboBox.Size = new Size(116, 28);
            FridayLesson_2_ComboBox.TabIndex = 44;
            // 
            // ThursdayLesson_2_ComboBox
            // 
            ThursdayLesson_2_ComboBox.FormattingEnabled = true;
            ThursdayLesson_2_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            ThursdayLesson_2_ComboBox.Location = new Point(506, 187);
            ThursdayLesson_2_ComboBox.Name = "ThursdayLesson_2_ComboBox";
            ThursdayLesson_2_ComboBox.Size = new Size(116, 28);
            ThursdayLesson_2_ComboBox.TabIndex = 43;
            // 
            // WednesdayLesson_2_ComboBox
            // 
            WednesdayLesson_2_ComboBox.FormattingEnabled = true;
            WednesdayLesson_2_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            WednesdayLesson_2_ComboBox.Location = new Point(381, 187);
            WednesdayLesson_2_ComboBox.Name = "WednesdayLesson_2_ComboBox";
            WednesdayLesson_2_ComboBox.Size = new Size(116, 28);
            WednesdayLesson_2_ComboBox.TabIndex = 42;
            // 
            // TuesdayLesson_2_ComboBox
            // 
            TuesdayLesson_2_ComboBox.FormattingEnabled = true;
            TuesdayLesson_2_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            TuesdayLesson_2_ComboBox.Location = new Point(256, 187);
            TuesdayLesson_2_ComboBox.Name = "TuesdayLesson_2_ComboBox";
            TuesdayLesson_2_ComboBox.Size = new Size(116, 28);
            TuesdayLesson_2_ComboBox.TabIndex = 41;
            // 
            // MondayLesson_2_СomboBox
            // 
            MondayLesson_2_СomboBox.FormattingEnabled = true;
            MondayLesson_2_СomboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            MondayLesson_2_СomboBox.Location = new Point(131, 187);
            MondayLesson_2_СomboBox.Name = "MondayLesson_2_СomboBox";
            MondayLesson_2_СomboBox.Size = new Size(116, 28);
            MondayLesson_2_СomboBox.TabIndex = 40;
            // 
            // SaturdayLesson_1_ComboBox
            // 
            SaturdayLesson_1_ComboBox.FormattingEnabled = true;
            SaturdayLesson_1_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            SaturdayLesson_1_ComboBox.Location = new Point(756, 47);
            SaturdayLesson_1_ComboBox.Name = "SaturdayLesson_1_ComboBox";
            SaturdayLesson_1_ComboBox.Size = new Size(117, 28);
            SaturdayLesson_1_ComboBox.TabIndex = 39;
            // 
            // FridayLesson_1_ComboBox
            // 
            FridayLesson_1_ComboBox.FormattingEnabled = true;
            FridayLesson_1_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            FridayLesson_1_ComboBox.Location = new Point(631, 47);
            FridayLesson_1_ComboBox.Name = "FridayLesson_1_ComboBox";
            FridayLesson_1_ComboBox.Size = new Size(116, 28);
            FridayLesson_1_ComboBox.TabIndex = 38;
            // 
            // ThursdayLesson_1_ComboBox
            // 
            ThursdayLesson_1_ComboBox.FormattingEnabled = true;
            ThursdayLesson_1_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            ThursdayLesson_1_ComboBox.Location = new Point(506, 47);
            ThursdayLesson_1_ComboBox.Name = "ThursdayLesson_1_ComboBox";
            ThursdayLesson_1_ComboBox.Size = new Size(116, 28);
            ThursdayLesson_1_ComboBox.TabIndex = 37;
            // 
            // WednesdayLesson_1_ComboBox
            // 
            WednesdayLesson_1_ComboBox.FormattingEnabled = true;
            WednesdayLesson_1_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            WednesdayLesson_1_ComboBox.Location = new Point(381, 47);
            WednesdayLesson_1_ComboBox.Name = "WednesdayLesson_1_ComboBox";
            WednesdayLesson_1_ComboBox.Size = new Size(116, 28);
            WednesdayLesson_1_ComboBox.TabIndex = 36;
            // 
            // TuesdayLesson_1_ComboBox
            // 
            TuesdayLesson_1_ComboBox.FormattingEnabled = true;
            TuesdayLesson_1_ComboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            TuesdayLesson_1_ComboBox.Location = new Point(256, 47);
            TuesdayLesson_1_ComboBox.Name = "TuesdayLesson_1_ComboBox";
            TuesdayLesson_1_ComboBox.Size = new Size(116, 28);
            TuesdayLesson_1_ComboBox.TabIndex = 35;
            // 
            // MondayLesson_1_СomboBox
            // 
            MondayLesson_1_СomboBox.FormattingEnabled = true;
            MondayLesson_1_СomboBox.Items.AddRange(new object[] { "Мат. анализ", "Алгебра и геометрия", "Физическая культура", "Англ. яз" });
            MondayLesson_1_СomboBox.Location = new Point(131, 47);
            MondayLesson_1_СomboBox.Name = "MondayLesson_1_СomboBox";
            MondayLesson_1_СomboBox.Size = new Size(116, 28);
            MondayLesson_1_СomboBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(131, 3);
            label1.Name = "label1";
            label1.Size = new Size(116, 38);
            label1.TabIndex = 0;
            label1.Text = "Понедельник";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(256, 3);
            label3.Name = "label3";
            label3.Size = new Size(116, 38);
            label3.TabIndex = 2;
            label3.Text = "Вторник";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(381, 3);
            label6.Name = "label6";
            label6.Size = new Size(116, 38);
            label6.TabIndex = 5;
            label6.Text = "Среда";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label13.Location = new Point(506, 3);
            label13.Name = "label13";
            label13.Size = new Size(116, 38);
            label13.TabIndex = 12;
            label13.Text = "Четверг";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label15.Location = new Point(631, 3);
            label15.Name = "label15";
            label15.Size = new Size(116, 38);
            label15.TabIndex = 14;
            label15.Text = "Пятница";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label16.Location = new Point(756, 3);
            label16.Name = "label16";
            label16.Size = new Size(117, 38);
            label16.TabIndex = 15;
            label16.Text = "Суббота";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            label31.BorderStyle = BorderStyle.FixedSingle;
            label31.Dock = DockStyle.Fill;
            label31.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label31.Location = new Point(6, 44);
            label31.Name = "label31";
            label31.Size = new Size(116, 137);
            label31.TabIndex = 30;
            label31.Text = "8:30-10:00";
            label31.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            label32.BorderStyle = BorderStyle.FixedSingle;
            label32.Dock = DockStyle.Fill;
            label32.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label32.Location = new Point(6, 184);
            label32.Name = "label32";
            label32.Size = new Size(116, 157);
            label32.TabIndex = 31;
            label32.Text = "10:10-11:40";
            label32.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label33
            // 
            label33.BorderStyle = BorderStyle.FixedSingle;
            label33.Dock = DockStyle.Fill;
            label33.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label33.Location = new Point(6, 344);
            label33.Name = "label33";
            label33.Size = new Size(116, 157);
            label33.TabIndex = 32;
            label33.Text = "12:10-13:40";
            label33.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            label34.BorderStyle = BorderStyle.FixedSingle;
            label34.Dock = DockStyle.Fill;
            label34.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label34.Location = new Point(6, 504);
            label34.Name = "label34";
            label34.Size = new Size(116, 159);
            label34.TabIndex = 33;
            label34.Text = "13:50-15:20";
            label34.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // schedulePanel
            // 
            schedulePanel.BackColor = Color.White;
            schedulePanel.Controls.Add(btnSave);
            schedulePanel.Controls.Add(BtnClearTable);
            schedulePanel.Controls.Add(SelectGroup);
            schedulePanel.Controls.Add(tableLayoutPanel1);
            schedulePanel.Dock = DockStyle.Fill;
            schedulePanel.Location = new Point(3, 4);
            schedulePanel.Margin = new Padding(3, 4, 3, 4);
            schedulePanel.Name = "schedulePanel";
            schedulePanel.Size = new Size(885, 710);
            schedulePanel.TabIndex = 34;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(535, 5);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(235, 35);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить расписание\r\n";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // BtnClearTable
            // 
            BtnClearTable.BackColor = Color.White;
            BtnClearTable.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnClearTable.Location = new Point(337, 4);
            BtnClearTable.Margin = new Padding(3, 4, 3, 4);
            BtnClearTable.Name = "BtnClearTable";
            BtnClearTable.Size = new Size(192, 35);
            BtnClearTable.TabIndex = 6;
            BtnClearTable.Text = "Очистить таблицу";
            BtnClearTable.UseVisualStyleBackColor = false;
            BtnClearTable.Click += BtnClearTable_Click;
            // 
            // SelectGroup
            // 
            SelectGroup.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectGroup.FormattingEnabled = true;
            SelectGroup.Items.AddRange(new object[] { "09-321", "09-322" });
            SelectGroup.Location = new Point(110, 8);
            SelectGroup.Margin = new Padding(3, 4, 3, 4);
            SelectGroup.Name = "SelectGroup";
            SelectGroup.Size = new Size(221, 28);
            SelectGroup.TabIndex = 5;
            SelectGroup.Text = "Выбрать группу";
            SelectGroup.SelectedIndexChanged += SelectGroup_SelectedIndexChanged;
            // 
            // ChengeGroupsPanel
            // 
            ChengeGroupsPanel.BackColor = SystemColors.Control;
            ChengeGroupsPanel.Controls.Add(label35);
            ChengeGroupsPanel.Controls.Add(BtnAdd);
            ChengeGroupsPanel.Controls.Add(AddStudentIdTextBox);
            ChengeGroupsPanel.Controls.Add(BtnSaveGroup);
            ChengeGroupsPanel.Controls.Add(SelectGroupComboBox);
            ChengeGroupsPanel.Controls.Add(ListOfStudentListView);
            ChengeGroupsPanel.Dock = DockStyle.Fill;
            ChengeGroupsPanel.Location = new Point(3, 4);
            ChengeGroupsPanel.Margin = new Padding(3, 4, 3, 4);
            ChengeGroupsPanel.Name = "ChengeGroupsPanel";
            ChengeGroupsPanel.Size = new Size(885, 710);
            ChengeGroupsPanel.TabIndex = 36;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(688, 144);
            label35.Name = "label35";
            label35.Size = new Size(87, 20);
            label35.TabIndex = 16;
            label35.Text = "ID студента";
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.White;
            BtnAdd.FlatStyle = FlatStyle.Popup;
            BtnAdd.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnAdd.Location = new Point(706, 234);
            BtnAdd.Margin = new Padding(3, 4, 3, 4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(151, 48);
            BtnAdd.TabIndex = 15;
            BtnAdd.Text = "Добавить\r\n";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // AddStudentIdTextBox
            // 
            AddStudentIdTextBox.Location = new Point(688, 168);
            AddStudentIdTextBox.Margin = new Padding(3, 4, 3, 4);
            AddStudentIdTextBox.Name = "AddStudentIdTextBox";
            AddStudentIdTextBox.Size = new Size(183, 27);
            AddStudentIdTextBox.TabIndex = 14;
            // 
            // BtnSaveGroup
            // 
            BtnSaveGroup.BackColor = Color.White;
            BtnSaveGroup.FlatStyle = FlatStyle.Popup;
            BtnSaveGroup.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnSaveGroup.Location = new Point(228, 14);
            BtnSaveGroup.Margin = new Padding(3, 4, 3, 4);
            BtnSaveGroup.Name = "BtnSaveGroup";
            BtnSaveGroup.Size = new Size(199, 28);
            BtnSaveGroup.TabIndex = 12;
            BtnSaveGroup.Text = "Сохранить таблицу \r\n";
            BtnSaveGroup.UseVisualStyleBackColor = false;
            BtnSaveGroup.Click += BtnSaveGroup_Click;
            // 
            // SelectGroupComboBox
            // 
            SelectGroupComboBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectGroupComboBox.FormattingEnabled = true;
            SelectGroupComboBox.Items.AddRange(new object[] { "09-321", "09-322" });
            SelectGroupComboBox.Location = new Point(14, 14);
            SelectGroupComboBox.Margin = new Padding(3, 4, 3, 4);
            SelectGroupComboBox.Name = "SelectGroupComboBox";
            SelectGroupComboBox.Size = new Size(208, 28);
            SelectGroupComboBox.TabIndex = 11;
            SelectGroupComboBox.Text = "Выберите группу";
            SelectGroupComboBox.SelectedIndexChanged += SelectGroupComboBox_SelectedIndexChanged;
            // 
            // ListOfStudentListView
            // 
            ListOfStudentListView.Location = new Point(0, 61);
            ListOfStudentListView.Margin = new Padding(3, 4, 3, 4);
            ListOfStudentListView.Name = "ListOfStudentListView";
            ListOfStudentListView.Size = new Size(673, 649);
            ListOfStudentListView.TabIndex = 0;
            ListOfStudentListView.UseCompatibleStateImageBehavior = false;
            ListOfStudentListView.View = View.List;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Schedule);
            tabControl1.Controls.Add(Groups);
            tabControl1.Location = new Point(233, 49);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(899, 751);
            tabControl1.TabIndex = 0;
            // 
            // Schedule
            // 
            Schedule.Controls.Add(schedulePanel);
            Schedule.Location = new Point(4, 29);
            Schedule.Margin = new Padding(3, 4, 3, 4);
            Schedule.Name = "Schedule";
            Schedule.Padding = new Padding(3, 4, 3, 4);
            Schedule.Size = new Size(891, 718);
            Schedule.TabIndex = 0;
            Schedule.Text = "Расписание";
            Schedule.UseVisualStyleBackColor = true;
            // 
            // Groups
            // 
            Groups.Controls.Add(ChengeGroupsPanel);
            Groups.Location = new Point(4, 29);
            Groups.Margin = new Padding(3, 4, 3, 4);
            Groups.Name = "Groups";
            Groups.Padding = new Padding(3, 4, 3, 4);
            Groups.Size = new Size(891, 718);
            Groups.TabIndex = 1;
            Groups.Text = "Группы";
            Groups.UseVisualStyleBackColor = true;
            // 
            // AdminMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1132, 814);
            Controls.Add(tabControl1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(UpperPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AdminMainForm_Load;
            UpperPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            schedulePanel.ResumeLayout(false);
            ChengeGroupsPanel.ResumeLayout(false);
            ChengeGroupsPanel.PerformLayout();
            tabControl1.ResumeLayout(false);
            Schedule.ResumeLayout(false);
            Groups.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button BtnMinimaze;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnProfile;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.ComboBox SelectGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnClearTable;
        private System.Windows.Forms.Panel ChengeGroupsPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Schedule;
        private System.Windows.Forms.TabPage Groups;
        private System.Windows.Forms.ListView ListOfStudentListView;
        private System.Windows.Forms.ComboBox SelectGroupComboBox;
        private System.Windows.Forms.Button BtnSaveGroup;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox AddStudentIdTextBox;
        private Label label35;
        private Button BtnAddEvaluation;
        private ComboBox SaturdayLesson_4_ComboBox;
        private ComboBox FridayLesson_4_ComboBox;
        private ComboBox ThursdayLesson_4_ComboBox;
        private ComboBox WednesdayLesson_4_ComboBox;
        private ComboBox TuesdayLesson_4_ComboBox;
        private ComboBox MondayLesson_4_СomboBox;
        private ComboBox SaturdayLesson_3_ComboBox;
        private ComboBox FridayLesson_3_ComboBox;
        private ComboBox ThursdayLesson_3_ComboBox;
        private ComboBox WednesdayLesson_3_ComboBox;
        private ComboBox TuesdayLesson_3_ComboBox;
        private ComboBox MondayLesson_3_СomboBox;
        private ComboBox SaturdayLesson_2_ComboBox;
        private ComboBox FridayLesson_2_ComboBox;
        private ComboBox ThursdayLesson_2_ComboBox;
        private ComboBox WednesdayLesson_2_ComboBox;
        private ComboBox TuesdayLesson_2_ComboBox;
        private ComboBox MondayLesson_2_СomboBox;
        private ComboBox SaturdayLesson_1_ComboBox;
        private ComboBox FridayLesson_1_ComboBox;
        private ComboBox ThursdayLesson_1_ComboBox;
        private ComboBox WednesdayLesson_1_ComboBox;
        private ComboBox TuesdayLesson_1_ComboBox;
        private ComboBox MondayLesson_1_СomboBox;
        private Button BtnExitFromAcount;
    }
}