using Electronic_diary.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_diary.FormsForStudent
{
    public partial class EvaluationsForm : Form
    {
        public EvaluationsForm()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Заполнение таблицы с оценками
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EvaluationsForm_Load(object sender, EventArgs e)
        {
            using (var context = new DiaryContext())
            {
                var mathEstimation = context.MatanalysisGrades.Where(m => m.StudentId == CurrentData.CurrentStudent.StudentId).Single();
                MathTest_1_Lable.Text = mathEstimation.Test1.ToString();
                MathTest_2_Lable.Text = mathEstimation.Test2.ToString();
                MathExam_1_Lable.Text = mathEstimation.Exam1.ToString();
                MathExam_2_Lable.Text = mathEstimation.Exam2.ToString();
                var englishEstimation = context.EnglishGrades.Where(e => e.StudentId == CurrentData.CurrentStudent.StudentId).Single();
                EnglishTest_1_Lable.Text = englishEstimation.Test1.ToString();
                EnglishTest_2_Lable.Text = englishEstimation.Test2.ToString();
                EnglishExam_1_Lable.Text = englishEstimation.Exam1.ToString();
                EnglishExam_2_Lable.Text = englishEstimation.Exam2.ToString();
                var PEEstimation = context.Pegrades.Where(e => e.StudentId == CurrentData.CurrentStudent.StudentId).Single();
                PETest_1_Lable.Text = PEEstimation.Test1.ToString();
                PETest_2_Lable.Text = PEEstimation.Test2.ToString();
                PETest_1_Lable.Text = PEEstimation.Exam1.ToString();
                PETest_2_Lable.Text = PEEstimation.Exam2.ToString();
                var AlgemEstimation = context.AlgemGrades.Where(e => e.StudentId == CurrentData.CurrentStudent.StudentId).Single();
                AlgemTest_1_Lable.Text = AlgemEstimation.Test1.ToString();
                AlgemTest_2_Lable.Text = AlgemEstimation.Test2.ToString();
                AlgemExam_1_Lable.Text = AlgemEstimation.Exam1.ToString();
                AlgemExam_2_Lable.Text = AlgemEstimation.Exam1.ToString();
            }
        }
    }
}
