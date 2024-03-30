namespace Electronic_diary.FormsForAdmin
{
    partial class AddEvaluation
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
            StudenytLabel = new Label();
            GroupLable = new Label();
            StudentComboBox = new ComboBox();
            GroupComboBox = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            SubjectTitleLable = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            AlgemExam_2_ComboBox = new ComboBox();
            AlgemTest_2_ComboBox = new ComboBox();
            AlgemExam_1_ComboBox = new ComboBox();
            AlgemTest_1_ComboBox = new ComboBox();
            PEExam_2_ComboBox = new ComboBox();
            PETest_2_ComboBox = new ComboBox();
            PEExam_1_ComboBox = new ComboBox();
            PETest_1_ComboBox = new ComboBox();
            EnglishExam_2_ComboBox = new ComboBox();
            EnglishTest_2_ComboBox = new ComboBox();
            EnglishExam_1_ComboBox = new ComboBox();
            EnglishTest_1_ComboBox = new ComboBox();
            MathExam_2_ComboBox = new ComboBox();
            MathTest_2_ComboBox = new ComboBox();
            MathExam_1_ComboBox = new ComboBox();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label7 = new Label();
            Exam_1_Label = new Label();
            Test_2_Label = new Label();
            Test_1_Label = new Label();
            MathTest_1_ComboBox = new ComboBox();
            BtnEnter = new Button();
            UpperPanel = new Panel();
            BtnMinimaze = new Button();
            BtnClose = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            UpperPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(StudenytLabel);
            panel1.Controls.Add(GroupLable);
            panel1.Controls.Add(StudentComboBox);
            panel1.Controls.Add(GroupComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SubjectTitleLable);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(BtnEnter);
            panel1.Location = new Point(0, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 504);
            panel1.TabIndex = 0;
            // 
            // StudenytLabel
            // 
            StudenytLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            StudenytLabel.Location = new Point(378, 41);
            StudenytLabel.Name = "StudenytLabel";
            StudenytLabel.Size = new Size(99, 35);
            StudenytLabel.TabIndex = 56;
            StudenytLabel.Text = "Студент";
            StudenytLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GroupLable
            // 
            GroupLable.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            GroupLable.Location = new Point(127, 41);
            GroupLable.Name = "GroupLable";
            GroupLable.Size = new Size(88, 35);
            GroupLable.TabIndex = 55;
            GroupLable.Text = "Группа";
            GroupLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentComboBox
            // 
            StudentComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentComboBox.Enabled = false;
            StudentComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            StudentComboBox.FormattingEnabled = true;
            StudentComboBox.Items.AddRange(new object[] { "09-321", "09-322" });
            StudentComboBox.Location = new Point(304, 79);
            StudentComboBox.Name = "StudentComboBox";
            StudentComboBox.Size = new Size(259, 36);
            StudentComboBox.TabIndex = 54;
            StudentComboBox.SelectedIndexChanged += StudentComboBox_SelectedIndexChanged;
            // 
            // GroupComboBox
            // 
            GroupComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GroupComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GroupComboBox.FormattingEnabled = true;
            GroupComboBox.Items.AddRange(new object[] { "09-321", "09-322" });
            GroupComboBox.Location = new Point(34, 79);
            GroupComboBox.Name = "GroupComboBox";
            GroupComboBox.Size = new Size(259, 36);
            GroupComboBox.TabIndex = 53;
            GroupComboBox.SelectedIndexChanged += GroupComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(364, 145);
            label2.Name = "label2";
            label2.Size = new Size(124, 31);
            label2.TabIndex = 20;
            label2.Text = "Семестр 2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(181, 145);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 19;
            label1.Text = "Семестр 1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubjectTitleLable
            // 
            SubjectTitleLable.BackColor = Color.White;
            SubjectTitleLable.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            SubjectTitleLable.Location = new Point(236, -3);
            SubjectTitleLable.Name = "SubjectTitleLable";
            SubjectTitleLable.Size = new Size(100, 31);
            SubjectTitleLable.TabIndex = 18;
            SubjectTitleLable.Text = "Оценки";
            SubjectTitleLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5588722F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.24212F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0663338F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0663338F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0663338F));
            tableLayoutPanel1.Controls.Add(AlgemExam_2_ComboBox, 4, 4);
            tableLayoutPanel1.Controls.Add(AlgemTest_2_ComboBox, 3, 4);
            tableLayoutPanel1.Controls.Add(AlgemExam_1_ComboBox, 2, 4);
            tableLayoutPanel1.Controls.Add(AlgemTest_1_ComboBox, 1, 4);
            tableLayoutPanel1.Controls.Add(PEExam_2_ComboBox, 4, 3);
            tableLayoutPanel1.Controls.Add(PETest_2_ComboBox, 3, 3);
            tableLayoutPanel1.Controls.Add(PEExam_1_ComboBox, 2, 3);
            tableLayoutPanel1.Controls.Add(PETest_1_ComboBox, 1, 3);
            tableLayoutPanel1.Controls.Add(EnglishExam_2_ComboBox, 4, 2);
            tableLayoutPanel1.Controls.Add(EnglishTest_2_ComboBox, 3, 2);
            tableLayoutPanel1.Controls.Add(EnglishExam_1_ComboBox, 2, 2);
            tableLayoutPanel1.Controls.Add(EnglishTest_1_ComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(MathExam_2_ComboBox, 4, 1);
            tableLayoutPanel1.Controls.Add(MathTest_2_ComboBox, 3, 1);
            tableLayoutPanel1.Controls.Add(MathExam_1_ComboBox, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label8, 0, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 2);
            tableLayoutPanel1.Controls.Add(label10, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 4, 0);
            tableLayoutPanel1.Controls.Add(Exam_1_Label, 2, 0);
            tableLayoutPanel1.Controls.Add(Test_2_Label, 3, 0);
            tableLayoutPanel1.Controls.Add(Test_1_Label, 1, 0);
            tableLayoutPanel1.Controls.Add(MathTest_1_ComboBox, 1, 1);
            tableLayoutPanel1.Location = new Point(50, 179);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(484, 181);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // AlgemExam_2_ComboBox
            // 
            AlgemExam_2_ComboBox.Dock = DockStyle.Fill;
            AlgemExam_2_ComboBox.FormattingEnabled = true;
            AlgemExam_2_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            AlgemExam_2_ComboBox.Location = new Point(389, 147);
            AlgemExam_2_ComboBox.Name = "AlgemExam_2_ComboBox";
            AlgemExam_2_ComboBox.Size = new Size(89, 28);
            AlgemExam_2_ComboBox.TabIndex = 35;
            // 
            // AlgemTest_2_ComboBox
            // 
            AlgemTest_2_ComboBox.Dock = DockStyle.Fill;
            AlgemTest_2_ComboBox.FormattingEnabled = true;
            AlgemTest_2_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            AlgemTest_2_ComboBox.Location = new Point(293, 147);
            AlgemTest_2_ComboBox.Name = "AlgemTest_2_ComboBox";
            AlgemTest_2_ComboBox.Size = new Size(87, 28);
            AlgemTest_2_ComboBox.TabIndex = 34;
            // 
            // AlgemExam_1_ComboBox
            // 
            AlgemExam_1_ComboBox.Dock = DockStyle.Fill;
            AlgemExam_1_ComboBox.FormattingEnabled = true;
            AlgemExam_1_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            AlgemExam_1_ComboBox.Location = new Point(197, 147);
            AlgemExam_1_ComboBox.Name = "AlgemExam_1_ComboBox";
            AlgemExam_1_ComboBox.Size = new Size(87, 28);
            AlgemExam_1_ComboBox.TabIndex = 33;
            // 
            // AlgemTest_1_ComboBox
            // 
            AlgemTest_1_ComboBox.Dock = DockStyle.Fill;
            AlgemTest_1_ComboBox.FormattingEnabled = true;
            AlgemTest_1_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            AlgemTest_1_ComboBox.Location = new Point(109, 147);
            AlgemTest_1_ComboBox.Name = "AlgemTest_1_ComboBox";
            AlgemTest_1_ComboBox.Size = new Size(79, 28);
            AlgemTest_1_ComboBox.TabIndex = 32;
            // 
            // PEExam_2_ComboBox
            // 
            PEExam_2_ComboBox.Dock = DockStyle.Fill;
            PEExam_2_ComboBox.FormattingEnabled = true;
            PEExam_2_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            PEExam_2_ComboBox.Location = new Point(389, 111);
            PEExam_2_ComboBox.Name = "PEExam_2_ComboBox";
            PEExam_2_ComboBox.Size = new Size(89, 28);
            PEExam_2_ComboBox.TabIndex = 31;
            // 
            // PETest_2_ComboBox
            // 
            PETest_2_ComboBox.Dock = DockStyle.Fill;
            PETest_2_ComboBox.FormattingEnabled = true;
            PETest_2_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            PETest_2_ComboBox.Location = new Point(293, 111);
            PETest_2_ComboBox.Name = "PETest_2_ComboBox";
            PETest_2_ComboBox.Size = new Size(87, 28);
            PETest_2_ComboBox.TabIndex = 30;
            // 
            // PEExam_1_ComboBox
            // 
            PEExam_1_ComboBox.Dock = DockStyle.Fill;
            PEExam_1_ComboBox.FormattingEnabled = true;
            PEExam_1_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            PEExam_1_ComboBox.Location = new Point(197, 111);
            PEExam_1_ComboBox.Name = "PEExam_1_ComboBox";
            PEExam_1_ComboBox.Size = new Size(87, 28);
            PEExam_1_ComboBox.TabIndex = 29;
            // 
            // PETest_1_ComboBox
            // 
            PETest_1_ComboBox.Dock = DockStyle.Fill;
            PETest_1_ComboBox.FormattingEnabled = true;
            PETest_1_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            PETest_1_ComboBox.Location = new Point(109, 111);
            PETest_1_ComboBox.Name = "PETest_1_ComboBox";
            PETest_1_ComboBox.Size = new Size(79, 28);
            PETest_1_ComboBox.TabIndex = 28;
            // 
            // EnglishExam_2_ComboBox
            // 
            EnglishExam_2_ComboBox.Dock = DockStyle.Fill;
            EnglishExam_2_ComboBox.FormattingEnabled = true;
            EnglishExam_2_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            EnglishExam_2_ComboBox.Location = new Point(389, 75);
            EnglishExam_2_ComboBox.Name = "EnglishExam_2_ComboBox";
            EnglishExam_2_ComboBox.Size = new Size(89, 28);
            EnglishExam_2_ComboBox.TabIndex = 27;
            // 
            // EnglishTest_2_ComboBox
            // 
            EnglishTest_2_ComboBox.Dock = DockStyle.Fill;
            EnglishTest_2_ComboBox.FormattingEnabled = true;
            EnglishTest_2_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            EnglishTest_2_ComboBox.Location = new Point(293, 75);
            EnglishTest_2_ComboBox.Name = "EnglishTest_2_ComboBox";
            EnglishTest_2_ComboBox.Size = new Size(87, 28);
            EnglishTest_2_ComboBox.TabIndex = 26;
            // 
            // EnglishExam_1_ComboBox
            // 
            EnglishExam_1_ComboBox.Dock = DockStyle.Fill;
            EnglishExam_1_ComboBox.FormattingEnabled = true;
            EnglishExam_1_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            EnglishExam_1_ComboBox.Location = new Point(197, 75);
            EnglishExam_1_ComboBox.Name = "EnglishExam_1_ComboBox";
            EnglishExam_1_ComboBox.Size = new Size(87, 28);
            EnglishExam_1_ComboBox.TabIndex = 25;
            // 
            // EnglishTest_1_ComboBox
            // 
            EnglishTest_1_ComboBox.Dock = DockStyle.Fill;
            EnglishTest_1_ComboBox.FormattingEnabled = true;
            EnglishTest_1_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            EnglishTest_1_ComboBox.Location = new Point(109, 75);
            EnglishTest_1_ComboBox.Name = "EnglishTest_1_ComboBox";
            EnglishTest_1_ComboBox.Size = new Size(79, 28);
            EnglishTest_1_ComboBox.TabIndex = 24;
            // 
            // MathExam_2_ComboBox
            // 
            MathExam_2_ComboBox.Dock = DockStyle.Fill;
            MathExam_2_ComboBox.FormattingEnabled = true;
            MathExam_2_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            MathExam_2_ComboBox.Location = new Point(389, 39);
            MathExam_2_ComboBox.Name = "MathExam_2_ComboBox";
            MathExam_2_ComboBox.Size = new Size(89, 28);
            MathExam_2_ComboBox.TabIndex = 23;
            // 
            // MathTest_2_ComboBox
            // 
            MathTest_2_ComboBox.Dock = DockStyle.Fill;
            MathTest_2_ComboBox.FormattingEnabled = true;
            MathTest_2_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            MathTest_2_ComboBox.Location = new Point(293, 39);
            MathTest_2_ComboBox.Name = "MathTest_2_ComboBox";
            MathTest_2_ComboBox.Size = new Size(87, 28);
            MathTest_2_ComboBox.TabIndex = 22;
            // 
            // MathExam_1_ComboBox
            // 
            MathExam_1_ComboBox.Dock = DockStyle.Fill;
            MathExam_1_ComboBox.FormattingEnabled = true;
            MathExam_1_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            MathExam_1_ComboBox.Location = new Point(197, 39);
            MathExam_1_ComboBox.Name = "MathExam_1_ComboBox";
            MathExam_1_ComboBox.Size = new Size(87, 28);
            MathExam_1_ComboBox.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(6, 144);
            label4.Name = "label4";
            label4.Size = new Size(94, 34);
            label4.TabIndex = 16;
            label4.Text = "Алгем";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(6, 108);
            label8.Name = "label8";
            label8.Size = new Size(94, 33);
            label8.TabIndex = 17;
            label8.Text = "Физ-ра";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(6, 72);
            label9.Name = "label9";
            label9.Size = new Size(94, 33);
            label9.TabIndex = 18;
            label9.Text = "Английский";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(6, 36);
            label10.Name = "label10";
            label10.Size = new Size(94, 33);
            label10.TabIndex = 19;
            label10.Text = "Мат. анализ";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(389, 3);
            label7.Name = "label7";
            label7.Size = new Size(89, 30);
            label7.TabIndex = 6;
            label7.Text = "Экзамен";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Exam_1_Label
            // 
            Exam_1_Label.AutoSize = true;
            Exam_1_Label.BorderStyle = BorderStyle.FixedSingle;
            Exam_1_Label.Dock = DockStyle.Fill;
            Exam_1_Label.Location = new Point(197, 3);
            Exam_1_Label.Name = "Exam_1_Label";
            Exam_1_Label.Size = new Size(87, 30);
            Exam_1_Label.TabIndex = 5;
            Exam_1_Label.Text = "Экзамен";
            Exam_1_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Test_2_Label
            // 
            Test_2_Label.AutoSize = true;
            Test_2_Label.BorderStyle = BorderStyle.FixedSingle;
            Test_2_Label.Dock = DockStyle.Fill;
            Test_2_Label.Location = new Point(293, 3);
            Test_2_Label.Name = "Test_2_Label";
            Test_2_Label.Size = new Size(87, 30);
            Test_2_Label.TabIndex = 3;
            Test_2_Label.Text = "Зачет";
            Test_2_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Test_1_Label
            // 
            Test_1_Label.AutoSize = true;
            Test_1_Label.BorderStyle = BorderStyle.FixedSingle;
            Test_1_Label.Dock = DockStyle.Fill;
            Test_1_Label.Location = new Point(109, 3);
            Test_1_Label.Name = "Test_1_Label";
            Test_1_Label.Size = new Size(79, 30);
            Test_1_Label.TabIndex = 0;
            Test_1_Label.Text = "Зачет";
            Test_1_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MathTest_1_ComboBox
            // 
            MathTest_1_ComboBox.Dock = DockStyle.Fill;
            MathTest_1_ComboBox.FormattingEnabled = true;
            MathTest_1_ComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            MathTest_1_ComboBox.Location = new Point(109, 39);
            MathTest_1_ComboBox.Name = "MathTest_1_ComboBox";
            MathTest_1_ComboBox.Size = new Size(79, 28);
            MathTest_1_ComboBox.TabIndex = 2;
            // 
            // BtnEnter
            // 
            BtnEnter.BackColor = SystemColors.Control;
            BtnEnter.Cursor = Cursors.Hand;
            BtnEnter.FlatStyle = FlatStyle.Flat;
            BtnEnter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnEnter.Location = new Point(236, 428);
            BtnEnter.Margin = new Padding(3, 4, 3, 4);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(136, 59);
            BtnEnter.TabIndex = 16;
            BtnEnter.Text = " Сохранить";
            BtnEnter.UseVisualStyleBackColor = false;
            BtnEnter.Click += BtnEnter_Click;
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
            UpperPanel.Size = new Size(598, 41);
            UpperPanel.TabIndex = 1;
            // 
            // BtnMinimaze
            // 
            BtnMinimaze.BackColor = Color.White;
            BtnMinimaze.Cursor = Cursors.Hand;
            BtnMinimaze.Dock = DockStyle.Right;
            BtnMinimaze.FlatStyle = FlatStyle.Flat;
            BtnMinimaze.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            BtnMinimaze.Location = new Point(528, 0);
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
            BtnClose.Location = new Point(563, 0);
            BtnClose.Margin = new Padding(3, 4, 3, 4);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(35, 41);
            BtnClose.TabIndex = 9;
            BtnClose.Text = "X";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click_1;
            // 
            // AddEvaluation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(598, 548);
            Controls.Add(UpperPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEvaluation";
            Text = "AddEvaluation";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            UpperPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel UpperPanel;
        private Button BtnMinimaze;
        private Button BtnClose;
        private Label label2;
        private Label label1;
        private Label SubjectTitleLable;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label Exam_1_Label;
        private Label Test_2_Label;
        private Label Test_1_Label;
        private Button BtnEnter;
        private ComboBox StudentComboBox;
        private ComboBox GroupComboBox;
        private Label StudenytLabel;
        private Label GroupLable;
        private ComboBox AlgemExam_2_ComboBox;
        private ComboBox AlgemTest_2_ComboBox;
        private ComboBox AlgemExam_1_ComboBox;
        private ComboBox AlgemTest_1_ComboBox;
        private ComboBox PEExam_2_ComboBox;
        private ComboBox PETest_2_ComboBox;
        private ComboBox PEExam_1_ComboBox;
        private ComboBox PETest_1_ComboBox;
        private ComboBox EnglishExam_2_ComboBox;
        private ComboBox EnglishTest_2_ComboBox;
        private ComboBox EnglishExam_1_ComboBox;
        private ComboBox EnglishTest_1_ComboBox;
        private ComboBox MathExam_2_ComboBox;
        private ComboBox MathTest_2_ComboBox;
        private ComboBox MathExam_1_ComboBox;
        private ComboBox MathTest_1_ComboBox;
    }
}