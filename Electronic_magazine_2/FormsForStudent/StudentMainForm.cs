using Electronic_diary.Classes;
using Electronic_diary.FormsForStudent;
using Electronic_magazine.Forms;
using System.Data;

namespace Electronic_magazine
{
    public partial class StudentMainForm : Form
    {

        public StudentMainForm()
        {
            InitializeComponent();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void BtnMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Заполнение формы при открывании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            using (var context = new DiaryContext())
            {
                FullNameLable.Text = CurrentData.CurrentStudent.Surname + " " + CurrentData.CurrentStudent.Name + " " + CurrentData.CurrentStudent.Patronymic;
                #region Фото
                if (CurrentData.CurrentStudent.Photo != null)
                {
                    var imageMemoryStream = new MemoryStream(CurrentData.CurrentStudent.Photo);
                    StudentPhotoPictureBox.Image = Image.FromStream(imageMemoryStream);
                }
                #endregion
                var subject = context.Subjects;
                #region Понедельник
                var monday = context.Mondays.Where(m => m.NumberGroup == CurrentData.CurrentStudent.NumberGroup).Single();

                if (monday.Lesson1 != null)
                {
                    MondayLesson_1_Lable.Text = subject.Find(monday.Lesson1).Title;
                }
                else
                {
                    MondayLesson_1_Lable.Text = string.Empty;
                }
                if (monday.Lesson2 != null)
                {
                    MondayLesson_2_Lable.Text = subject.Find(monday.Lesson2).Title;
                }
                else
                {
                    MondayLesson_2_Lable.Text = string.Empty;
                }
                if (monday.Lesson3 != null)
                {
                    MondayLesson_3_Lable.Text = subject.Find(monday.Lesson3).Title;
                }
                else
                {
                    MondayLesson_3_Lable.Text = string.Empty;
                }
                if (monday.Lesson4 != null)
                {
                    MondayLesson_4_Lable.Text = subject.Find(monday.Lesson4).Title;
                }
                else
                {
                    MondayLesson_4_Lable.Text = string.Empty;
                }
                #endregion
                #region Вторник
                var tuesday = context.Tuesdays.Where(m => m.NumberGroup == CurrentData.CurrentStudent.NumberGroup).Single();
                if (tuesday.Lesson1 != null)
                {
                    TuesdayLesson_1_Lable.Text = subject.Find(tuesday.Lesson1).Title;
                }
                else
                {
                    TuesdayLesson_1_Lable.Text = string.Empty;
                }
                if (tuesday.Lesson2 != null)
                {
                    TuesdayLesson_2_Lable.Text = subject.Find(tuesday.Lesson2).Title;
                }
                else
                {
                    TuesdayLesson_2_Lable.Text = string.Empty;
                }
                if (tuesday.Lesson3 != null)
                {
                    TuesdayLesson_3_Lable.Text = subject.Find(tuesday.Lesson3).Title;
                }
                else
                {
                    TuesdayLesson_3_Lable.Text = string.Empty;
                }
                if (tuesday.Lesson4 != null)
                {
                    TuesdayLesson_4_Lable.Text = subject.Find(tuesday.Lesson4).Title;
                }
                else
                {
                    TuesdayLesson_4_Lable.Text = string.Empty;
                }
                #endregion
                #region Среда
                var wednesday = context.Wednesdays.Where(m => m.NumberGroup == CurrentData.CurrentStudent.NumberGroup).Single();
                if (wednesday.Lesson1 != null)
                {
                    WednesdayLesson_1_Lable.Text = subject.Find(wednesday.Lesson1).Title;
                }
                else
                {
                    WednesdayLesson_1_Lable.Text = string.Empty;
                }

                if (wednesday.Lesson2 != null)
                {
                    WednesdayLesson_2_Lable.Text = subject.Find(wednesday.Lesson2).Title;
                }
                else
                {
                    WednesdayLesson_2_Lable.Text = string.Empty;
                }
                if (wednesday.Lesson3 != null)
                {
                    WednesdayLesson_3_Lable.Text = subject.Find(wednesday.Lesson3).Title;
                }
                else
                {
                    WednesdayLesson_3_Lable.Text = string.Empty;
                }

                if (wednesday.Lesson4 != null)
                {
                    WednesdayLesson_4_Lable.Text = subject.Find(wednesday.Lesson4).Title;
                }
                else
                {
                    WednesdayLesson_4_Lable.Text = string.Empty;
                }
                #endregion
                #region Четверг
                var thursday = context.Thursdays.Where(m => m.NumberGroup == CurrentData.CurrentStudent.NumberGroup).Single();
                if (thursday.Lesson1 != null)
                {
                    ThursdayLesson_1_Lable.Text = subject.Find(thursday.Lesson1).Title;
                }
                else
                {
                    ThursdayLesson_1_Lable.Text = string.Empty;
                }
                if (thursday.Lesson2 != null)
                {
                    ThursdayLesson_2_Lable.Text = subject.Find(thursday.Lesson2).Title;
                }
                else
                {
                    ThursdayLesson_2_Lable.Text = string.Empty;
                }
                if (thursday.Lesson3 != null)
                {
                    ThursdayLesson_3_Lable.Text = subject.Find(thursday.Lesson3).Title;
                }
                else
                {
                    ThursdayLesson_3_Lable.Text = string.Empty;
                }
                if (thursday.Lesson4 != null)
                {
                    ThursdayLesson_4_Lable.Text = subject.Find(thursday.Lesson4).Title;
                }
                else
                {
                    ThursdayLesson_4_Lable.Text = string.Empty;
                }
                #endregion
                #region Пятница
                var friday = context.Fridays.Where(m => m.NumberGroup == CurrentData.CurrentStudent.NumberGroup).Single();
                if (friday.Lesson1 != null)
                {
                    FridayLesson_1_Lable.Text = subject.Find(friday.Lesson1).Title;
                }
                else
                {
                    FridayLesson_1_Lable.Text = string.Empty;
                }
                if (friday.Lesson2 != null)
                {
                    FridayLesson_2_Lable.Text = subject.Find(friday.Lesson2).Title;
                }
                else
                {
                    FridayLesson_2_Lable.Text = string.Empty;
                }
                if (friday.Lesson3 != null)
                {
                    FridayLesson_3_Lable.Text = subject.Find(friday.Lesson3).Title;
                }
                else
                {
                    FridayLesson_3_Lable.Text = string.Empty;
                }
                if (friday.Lesson4 != null)
                {
                    FridayLesson_4_Lable.Text = subject.Find(friday.Lesson4).Title;
                }
                else
                {
                    FridayLesson_4_Lable.Text = string.Empty;
                }
                #endregion
                #region Суббота
                var saturday = context.Saturdays.Where(m => m.NumberGroup == CurrentData.CurrentStudent.NumberGroup).Single();
                if (saturday.Lesson1 != null)
                {
                    SaturdayLesson_1_Lable.Text = subject.Find(saturday.Lesson1).Title;
                }
                else
                {
                    SaturdayLesson_1_Lable.Text = string.Empty;
                }
                if (saturday.Lesson2 != null)
                {
                    SaturdayLesson_2_Lable.Text = subject.Find(saturday.Lesson2).Title;
                }
                else
                {
                    SaturdayLesson_2_Lable.Text = string.Empty;
                }
                if (saturday.Lesson3 != null)
                {
                    SaturdayLesson_3_Lable.Text = subject.Find(saturday.Lesson3).Title;
                }
                else
                {
                    SaturdayLesson_3_Lable.Text = string.Empty;
                }
                if (saturday.Lesson4 != null)
                {
                    SaturdayLesson_4_Lable.Text = subject.Find(saturday.Lesson4).Title;
                }
                else
                {
                    SaturdayLesson_4_Lable.Text = string.Empty;
                }
                #endregion

            }
        }
        /// <summary>
        /// Открытие формы с профилем студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProfile_Click(object sender, EventArgs e)
        {
            StudentProfileForm studentProfileForm = new StudentProfileForm();
            studentProfileForm.ShowDialog();
            if (CurrentData.CurrentStudent.Photo != null)
            {
                var imageMemoryStream = new MemoryStream(CurrentData.CurrentStudent.Photo);
                StudentPhotoPictureBox.Image = Image.FromStream(imageMemoryStream);
            }
        }
        /// <summary>
        /// Обработка нажатия на ячейку в таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lable_Click(object sender, EventArgs e)
        {
            using (var context = new DiaryContext())
            {
                var subjects = context.Subjects.Where(s => s.Title == (sender as Label).Text).FirstOrDefault();
                if (subjects == null)
                {
                    return;
                }
                CurrentData.CurrentSubject = subjects;
            }
            CardOfSubjectForm card = new CardOfSubjectForm();
            card.ShowDialog();
        }
        /// <summary>
        /// Открытие формы с оценка студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Evaluations_Click(object sender, EventArgs e)
        {
            EvaluationsForm evaluationsForm = new EvaluationsForm();
            evaluationsForm.ShowDialog();
        }

        private void BtnExitFromAcount_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            Close();
            authorizationForm.Show();
        }
    }
}
