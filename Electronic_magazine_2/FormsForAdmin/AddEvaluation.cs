using Electronic_diary.Classes;
using Electronic_diary.Classes.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_diary.FormsForAdmin
{
    public partial class AddEvaluation : Form
    {
        public AddEvaluation()
        {
            InitializeComponent();
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentComboBox.Items.Clear();
            StudentComboBox.Enabled = true;
            using (var context = new DiaryContext())
            {
                var students = context.Students
                    .Where(s => s.NumberGroup == GroupComboBox.Text).ToList();
                foreach (var student in students)
                {
                    StudentComboBox.Items.Add(student.Surname + " " + student.Name +
                        " " + student.Patronymic);
                }
            }
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Заполнение таблицы с оценками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new DiaryContext())
            {
                var student = context.Students.Where(s => s.Surname + " "
                + s.Name + " " + s.Patronymic == StudentComboBox.Text && s.NumberGroup
                == GroupComboBox.Text).FirstOrDefault();
                if (student != null)
                {
                    var matanalysisGrade = context.MatanalysisGrades.Where(s => s.StudentId
                    == student.StudentId).FirstOrDefault();
                    if (matanalysisGrade != null)
                    {
                        MathTest_1_ComboBox.Text = matanalysisGrade.Test1.ToString();
                        MathTest_2_ComboBox.Text = matanalysisGrade.Test2.ToString();
                        MathExam_1_ComboBox.Text = matanalysisGrade.Exam1.ToString();
                        MathExam_2_ComboBox.Text = matanalysisGrade.Exam2.ToString();
                    }
                    var englishGrades = context.EnglishGrades.Where(s => s.StudentId
                    == student.StudentId).FirstOrDefault();
                    if (englishGrades != null)
                    {
                        EnglishTest_1_ComboBox.Text = englishGrades.Test1.ToString();
                        EnglishTest_2_ComboBox.Text = englishGrades.Test2.ToString();
                        EnglishExam_1_ComboBox.Text = englishGrades.Exam1.ToString();
                        EnglishExam_2_ComboBox.Text = englishGrades.Exam2.ToString();
                    }
                    var pegrade = context.Pegrades.Where(s => s.StudentId
                    == student.StudentId).FirstOrDefault();
                    if (pegrade != null)
                    {
                        PETest_1_ComboBox.Text = pegrade.Test1.ToString();
                        PETest_2_ComboBox.Text = pegrade.Test2.ToString();
                        PEExam_1_ComboBox.Text = pegrade.Exam1.ToString();
                        PEExam_2_ComboBox.Text = pegrade.Exam2.ToString();
                    }
                    var algemGrade = context.AlgemGrades.Where(s => s.StudentId
                    == student.StudentId).FirstOrDefault();
                    if (algemGrade != null)
                    {
                        AlgemTest_1_ComboBox.Text = algemGrade.Test1.ToString();
                        AlgemTest_2_ComboBox.Text = algemGrade.Test2.ToString();
                        AlgemExam_1_ComboBox.Text = algemGrade.Exam1.ToString();
                        AlgemExam_2_ComboBox.Text = algemGrade.Exam2.ToString();
                    }

                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (var context = new DiaryContext())
            {
                var student = context.Students.Where(s => s.Surname + " "
                + s.Name + " " + s.Patronymic == StudentComboBox.Text && s.NumberGroup
                == GroupComboBox.Text).FirstOrDefault();
                if (student != null)
                {
                    var matanalysisGrade = context.MatanalysisGrades.Where(s => s.Student
                    == student).FirstOrDefault();
                    if (matanalysisGrade != null)
                    {
                        matanalysisGrade.Test1 = Convert.ToInt32(MathTest_1_ComboBox.SelectedItem);
                        matanalysisGrade.Test2 = Convert.ToInt32(MathTest_2_ComboBox.SelectedItem);
                        matanalysisGrade.Exam1 = Convert.ToInt32(MathExam_1_ComboBox.SelectedItem);
                        matanalysisGrade.Exam2 = Convert.ToInt32(MathExam_2_ComboBox.SelectedItem);
                        context.SaveChanges();
                        MessageBox.Show("Сохранение прошло успешно!");
                    }
                    //var englishGrades = context.EnglishGrades.Where(s => s.StudentId
                    //== student.StudentId).FirstOrDefault();
                    //if (englishGrades != null)
                    //{
                    //    EnglishTest_1_ComboBox.Text = englishGrades.Test1.ToString();
                    //    EnglishTest_2_ComboBox.Text = englishGrades.Test2.ToString();
                    //    EnglishExam_1_ComboBox.Text = englishGrades.Exam1.ToString();
                    //    EnglishExam_2_ComboBox.Text = englishGrades.Exam2.ToString();
                    //}
                    //var pegrade = context.Pegrades.Where(s => s.StudentId
                    //== student.StudentId).FirstOrDefault();
                    //if (pegrade != null)
                    //{
                    //    PETest_1_ComboBox.Text = pegrade.Test1.ToString();
                    //    PETest_2_ComboBox.Text = pegrade.Test2.ToString();
                    //    PEExam_1_ComboBox.Text = pegrade.Exam1.ToString();
                    //    PEExam_2_ComboBox.Text = pegrade.Exam2.ToString();
                    //}
                    //var algemGrade = context.AlgemGrades.Where(s => s.StudentId
                    //== student.StudentId).FirstOrDefault();
                    //if (algemGrade != null)
                    //{
                    //    AlgemTest_1_ComboBox.Text = algemGrade.Test1.ToString();
                    //    AlgemTest_2_ComboBox.Text = algemGrade.Test2.ToString();
                    //    AlgemExam_1_ComboBox.Text = algemGrade.Exam1.ToString();
                    //    AlgemExam_2_ComboBox.Text = algemGrade.Exam2.ToString();
                    //}
                }
            }
        }
    }
}
