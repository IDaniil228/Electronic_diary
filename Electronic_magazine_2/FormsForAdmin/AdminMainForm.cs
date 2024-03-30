using Electronic_diary.Classes;
using Electronic_diary.Classes.Entities;
using Electronic_diary.Classes.weekday;
using Electronic_diary.FormsForAdmin;
using Electronic_magazine.Forms;

namespace Electronic_magazine.FormsForAdmin
{
    public partial class AdminMainForm : Form
    {
        List<int> idStud = new List<int>();
        public AdminMainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
        /// <summary>
        /// сворачивание формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Открытие формы с добавлением нового пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm();
            addUser.ShowDialog();
        }
        /// <summary>
        /// Открытие профиля админа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnProfile_Click(object sender, EventArgs e)
        {
            AdminProfileForm profileForm = new AdminProfileForm();
            profileForm.ShowDialog();
            if (CurrentData.CurrentAdmin.Photo != null)
            {
                var imageMemoryStream = new MemoryStream(CurrentData.CurrentAdmin.Photo);
                PhotoPictureBox.Image = Image.FromStream(imageMemoryStream);
            }
        }
        /// <summary>
        /// Заполнение информацией формы админа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            FullNameLabel.Text = CurrentData.CurrentAdmin.Surname + " " + CurrentData.CurrentAdmin.Name + " " + CurrentData.CurrentAdmin.Patronymic;
            if (CurrentData.CurrentAdmin.Photo != null)
            {
                var imageMemoryStream = new MemoryStream(CurrentData.CurrentAdmin.Photo);
                PhotoPictureBox.Image = Image.FromStream(imageMemoryStream);
            }

        }
        /// <summary>
        /// Вывод составва группы в ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idStud.Clear();
            ListOfStudentListView.Items.Clear();
            using (var context = new DiaryContext())
            {
                if (SelectGroupComboBox.Text == "09-321")
                {
                    var students = context.Students.Where(s => s.NumberGroup == "09-321").ToList();
                    foreach (var student in students)
                    {
                        idStud.Add(student.StudentId);
                        ListOfStudentListView.Items.Add(student.Surname + " " + student.Name + " " + student.Patronymic + $" (Id - {student.StudentId})");
                    }
                }
                else if (SelectGroupComboBox.Text == "09-322")
                {
                    var students = context.Students.Where(s => s.NumberGroup == "09-322").ToList();
                    foreach (var student in students)
                    {
                        idStud.Add(student.StudentId);
                        ListOfStudentListView.Items.Add(student.Surname + " " + student.Name + " " + student.Patronymic + $" (Id - {student.StudentId})");
                    }
                }
            }

        }
        /// <summary>
        /// Добавление студента по ID в группу 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            foreach (var id in idStud)
            {
                if (AddStudentIdTextBox.Text == id.ToString())
                {
                    MessageBox.Show("Студент с таким ID уже добавлен в группу!", "Ошибка");
                    return;
                }
            }
            using (var context = new DiaryContext())
            {
                var student = context.Students.Where(s => s.StudentId.ToString() == AddStudentIdTextBox.Text).FirstOrDefault();
                if (student == null)
                {
                    MessageBox.Show("Студента с таким ID не существует!", "Ошибка");
                    return;
                }
                else
                {
                    idStud.Add(student.StudentId);
                    ListOfStudentListView.Items.Add(student.Surname + " " + student.Name + " " + student.Patronymic + $" (Id - {student.StudentId})");
                }
            }
        }
        /// <summary>
        /// Сохранение состава группы в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveGroup_Click(object sender, EventArgs e)
        {
            using (var context = new DiaryContext())
            {
                var students = context.Students.Where(s => idStud.Contains(s.StudentId)).ToList();
                foreach (var student in students)
                {
                    student.NumberGroup = SelectGroupComboBox.Text;
                }
                context.SaveChanges();
                MessageBox.Show("Группа сохранена", "Успешно");
            }
        }

        private void BtnAddEvaluation_Click(object sender, EventArgs e)
        {
            AddEvaluation addEvaluation = new AddEvaluation();
            addEvaluation.ShowDialog();
        }
        /// <summary>
        /// Очищение таблицы с расписанием
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClearTable_Click(object sender, EventArgs e)
        {
            MondayLesson_1_СomboBox.Text = string.Empty;
            MondayLesson_2_СomboBox.Text = string.Empty;
            MondayLesson_3_СomboBox.Text = string.Empty;
            MondayLesson_4_СomboBox.Text = string.Empty;

            TuesdayLesson_1_ComboBox.Text = string.Empty;
            TuesdayLesson_2_ComboBox.Text = string.Empty;
            TuesdayLesson_3_ComboBox.Text = string.Empty;
            TuesdayLesson_4_ComboBox.Text = string.Empty;

            WednesdayLesson_1_ComboBox.Text = string.Empty;
            WednesdayLesson_2_ComboBox.Text = string.Empty;
            WednesdayLesson_3_ComboBox.Text = string.Empty;
            WednesdayLesson_4_ComboBox.Text = string.Empty;

            ThursdayLesson_1_ComboBox.Text = string.Empty;
            ThursdayLesson_2_ComboBox.Text = string.Empty;
            ThursdayLesson_3_ComboBox.Text = string.Empty;
            ThursdayLesson_4_ComboBox.Text = string.Empty;

            FridayLesson_1_ComboBox.Text = string.Empty;
            FridayLesson_2_ComboBox.Text = string.Empty;
            FridayLesson_3_ComboBox.Text = string.Empty;
            FridayLesson_4_ComboBox.Text = string.Empty;

            SaturdayLesson_1_ComboBox.Text = string.Empty;
            SaturdayLesson_2_ComboBox.Text = string.Empty;
            SaturdayLesson_3_ComboBox.Text = string.Empty;
            SaturdayLesson_4_ComboBox.Text = string.Empty;
        }
        /// <summary>
        /// Заполнение таблицы расписанием группы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new DiaryContext())
            {
                var subject = context.Subjects;
                #region Понедельник
                var monday = context.Mondays.Where(x => x.NumberGroup == SelectGroup.SelectedItem).FirstOrDefault();
                if (monday == null)
                {
                    MessageBox.Show("Ошибка загрузки расписания", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (monday.Lesson1 != null)
                {
                    MondayLesson_1_СomboBox.Text = subject.Find(monday.Lesson1).Title;
                }
                else
                {
                    MondayLesson_2_СomboBox.Text = string.Empty;
                }
                if (monday.Lesson2 != null)
                {
                    MondayLesson_3_СomboBox.Text = subject.Find(monday.Lesson2).Title;
                }
                else
                {
                    MondayLesson_4_СomboBox.Text = string.Empty;
                }
                if (monday.Lesson3 != null)
                {
                    MondayLesson_3_СomboBox.Text = subject.Find(monday.Lesson3).Title;
                }
                else
                {
                    MondayLesson_3_СomboBox.Text = string.Empty;
                }
                if (monday.Lesson4 != null)
                {
                    MondayLesson_4_СomboBox.Text = subject.Find(monday.Lesson4).Title;
                }
                else
                {
                    MondayLesson_4_СomboBox.Text = string.Empty;
                }
                #endregion
                #region Вторник
                var tuesday = context.Tuesdays.Where(m => m.NumberGroup == SelectGroup.SelectedItem).FirstOrDefault();
                if (tuesday == null)
                {
                    MessageBox.Show("Ошибка загрузки расписания", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (tuesday.Lesson1 != null)
                {
                    TuesdayLesson_1_ComboBox.Text = subject.Find(tuesday.Lesson1).Title;
                }
                else
                {
                    TuesdayLesson_1_ComboBox.Text = string.Empty;
                }
                if (tuesday.Lesson2 != null)
                {
                    TuesdayLesson_2_ComboBox.Text = subject.Find(tuesday.Lesson2).Title;
                }
                else
                {
                    TuesdayLesson_2_ComboBox.Text = string.Empty;
                }
                if (tuesday.Lesson3 != null)
                {
                    TuesdayLesson_3_ComboBox.Text = subject.Find(tuesday.Lesson3).Title;
                }
                else
                {
                    TuesdayLesson_3_ComboBox.Text = string.Empty;
                }
                if (tuesday.Lesson4 != null)
                {
                    TuesdayLesson_4_ComboBox.Text = subject.Find(tuesday.Lesson4).Title;
                }
                else
                {
                    TuesdayLesson_4_ComboBox.Text = string.Empty;
                }
                #endregion
                #region Среда
                var wednesday = context.Wednesdays.Where(m => m.NumberGroup == SelectGroup.SelectedItem).FirstOrDefault();

                if (wednesday == null)
                {
                    MessageBox.Show("Ошибка загрузки расписания", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (wednesday.Lesson1 != null)
                {
                    WednesdayLesson_1_ComboBox.Text = subject.Find(wednesday.Lesson1).Title;
                }
                else
                {
                    WednesdayLesson_1_ComboBox.Text = string.Empty;
                }

                if (wednesday.Lesson2 != null)
                {
                    WednesdayLesson_2_ComboBox.Text = subject.Find(wednesday.Lesson2).Title;
                }
                else
                {
                    WednesdayLesson_2_ComboBox.Text = string.Empty;
                }
                if (wednesday.Lesson3 != null)
                {
                    WednesdayLesson_3_ComboBox.Text = subject.Find(wednesday.Lesson3).Title;
                }
                else
                {
                    WednesdayLesson_3_ComboBox.Text = string.Empty;
                }

                if (wednesday.Lesson4 != null)
                {
                    WednesdayLesson_4_ComboBox.Text = subject.Find(wednesday.Lesson4).Title;
                }
                else
                {
                    WednesdayLesson_4_ComboBox.Text = string.Empty;
                }
                #endregion
                #region Четверг
                var thursday = context.Thursdays.Where(m => m.NumberGroup == SelectGroup.SelectedItem).FirstOrDefault();

                if (thursday == null)
                {
                    MessageBox.Show("Ошибка загрузки расписания", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (thursday.Lesson1 != null)
                {
                    ThursdayLesson_1_ComboBox.Text = subject.Find(thursday.Lesson1).Title;
                }
                else
                {
                    ThursdayLesson_1_ComboBox.Text = string.Empty;
                }
                if (thursday.Lesson2 != null)
                {
                    ThursdayLesson_2_ComboBox.Text = subject.Find(thursday.Lesson2).Title;
                }
                else
                {
                    ThursdayLesson_2_ComboBox.Text = string.Empty;
                }
                if (thursday.Lesson3 != null)
                {
                    ThursdayLesson_3_ComboBox.Text = subject.Find(thursday.Lesson3).Title;
                }
                else
                {
                    ThursdayLesson_3_ComboBox.Text = string.Empty;
                }
                if (thursday.Lesson4 != null)
                {
                    ThursdayLesson_4_ComboBox.Text = subject.Find(thursday.Lesson4).Title;
                }
                else
                {
                    ThursdayLesson_4_ComboBox.Text = string.Empty;
                }
                #endregion
                #region Пятница
                var friday = context.Fridays.Where(m => m.NumberGroup == SelectGroup.SelectedItem).FirstOrDefault();

                if (friday == null)
                {
                    MessageBox.Show("Ошибка загрузки расписания", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (friday.Lesson1 != null)
                {
                    FridayLesson_1_ComboBox.Text = subject.Find(friday.Lesson1).Title;
                }
                else
                {
                    FridayLesson_1_ComboBox.Text = string.Empty;
                }
                if (friday.Lesson2 != null)
                {
                    FridayLesson_2_ComboBox.Text = subject.Find(friday.Lesson2).Title;
                }
                else
                {
                    FridayLesson_2_ComboBox.Text = string.Empty;
                }
                if (friday.Lesson3 != null)
                {
                    FridayLesson_3_ComboBox.Text = subject.Find(friday.Lesson3).Title;
                }
                else
                {
                    FridayLesson_3_ComboBox.Text = string.Empty;
                }
                if (friday.Lesson4 != null)
                {
                    FridayLesson_4_ComboBox.Text = subject.Find(friday.Lesson4).Title;
                }
                else
                {
                    FridayLesson_4_ComboBox.Text = string.Empty;
                }
                #endregion
                #region Суббота
                var saturday = context.Saturdays.Where(m => m.NumberGroup == SelectGroup.SelectedItem).FirstOrDefault();

                if (saturday == null)
                {
                    MessageBox.Show("Ошибка загрузки расписания", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (saturday.Lesson1 != null)
                {
                    SaturdayLesson_1_ComboBox.Text = subject.Find(saturday.Lesson1).Title;
                }
                else
                {
                    SaturdayLesson_1_ComboBox.Text = string.Empty;
                }
                if (saturday.Lesson2 != null)
                {
                    SaturdayLesson_2_ComboBox.Text = subject.Find(saturday.Lesson2).Title;
                }
                else
                {
                    SaturdayLesson_2_ComboBox.Text = string.Empty;
                }
                if (saturday.Lesson3 != null)
                {
                    SaturdayLesson_3_ComboBox.Text = subject.Find(saturday.Lesson3).Title;
                }
                else
                {
                    SaturdayLesson_3_ComboBox.Text = string.Empty;
                }
                if (saturday.Lesson4 != null)
                {
                    SaturdayLesson_4_ComboBox.Text = subject.Find(saturday.Lesson4).Title;
                }
                else
                {
                    SaturdayLesson_4_ComboBox.Text = string.Empty;
                }
                #endregion
            }
        }
        /// <summary>
        /// Выход из аккаунта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExitFromAcount_Click(object sender, EventArgs e)
        {
            AuthorizationForm authorizationForm = new AuthorizationForm();
            Close();
            authorizationForm.Show();
        }
        /// <summary>
        /// Сохранение нового расписания в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (SelectGroup.Text == "Выбрать группу")
            {
                MessageBox.Show("Необходимо выбрать группу!", "Ошибка");
                return;
            }
            using (var context = new DiaryContext())
            {
                var subjects = context.Subjects;
                var monday = context.Mondays.Where(x => x.NumberGroup == SelectGroup.SelectedItem)
                    .FirstOrDefault();
                if (monday != null)
                {
                    if (MondayLesson_1_СomboBox.Text == string.Empty)
                    {
                        monday.Lesson1 = null;
                    }
                    else 
                    {
                        monday.Lesson1 = subjects.Where(x => x.Title == MondayLesson_1_СomboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }

                    if (MondayLesson_2_СomboBox.Text == string.Empty)
                    {
                        monday.Lesson2 = null;
                    }
                    else
                    {
                        monday.Lesson2 = subjects.Where(x => x.Title == MondayLesson_2_СomboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }

                    if (MondayLesson_3_СomboBox.Text == string.Empty)
                    {
                        monday.Lesson3 = null;
                    }
                    else
                    {
                        monday.Lesson3 = subjects.Where(x => x.Title == MondayLesson_3_СomboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }

                    if (MondayLesson_4_СomboBox.Text == string.Empty)
                    {
                        monday.Lesson4 = null;
                    }
                    else
                    {
                        monday.Lesson4 = subjects.Where(x => x.Title == MondayLesson_4_СomboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                }

                var tuesday = context.Tuesdays.Where(x => x.NumberGroup == SelectGroup.SelectedItem)
                    .FirstOrDefault();
                if (tuesday != null) 
                {
                    if (TuesdayLesson_1_ComboBox.Text == string.Empty)
                    {
                        tuesday.Lesson1 = null;
                    }
                    else 
                    {
                        tuesday.Lesson1 = subjects.Where(x => x.Title == TuesdayLesson_1_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                    if (TuesdayLesson_2_ComboBox.Text == string.Empty)
                    {
                        tuesday.Lesson2 = null;
                    }
                    else
                    {
                        tuesday.Lesson2 = subjects.Where(x => x.Title == TuesdayLesson_2_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                    if (TuesdayLesson_3_ComboBox.Text == string.Empty)
                    {
                        tuesday.Lesson3 = null;
                    }
                    else 
                    {
                        tuesday.Lesson3 = subjects.Where(x => x.Title == TuesdayLesson_3_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                    if (TuesdayLesson_4_ComboBox.Text == string.Empty)
                    {
                        tuesday.Lesson4 = null;
                    }
                    else
                    {
                        tuesday.Lesson4 = subjects.Where(x => x.Title == TuesdayLesson_4_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                }

                var wednesday = context.Wednesdays.Where(x => x.NumberGroup == SelectGroup.SelectedItem)
                    .FirstOrDefault();
                if (wednesday != null)
                {
                    if (WednesdayLesson_1_ComboBox.Text == string.Empty)
                    {
                        wednesday.Lesson1 = null;
                    }
                    else 
                    {
                        wednesday.Lesson1 = subjects.Where(x => x.Title == WednesdayLesson_1_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }

                    if (WednesdayLesson_2_ComboBox.Text == string.Empty)
                    {
                        wednesday.Lesson2 = null;
                    }
                    else
                    {
                        wednesday.Lesson2 = subjects.Where(x => x.Title == WednesdayLesson_2_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }

                    if (WednesdayLesson_3_ComboBox.Text == string.Empty)
                    {
                        wednesday.Lesson3 = null;
                    }
                    else
                    {
                        wednesday.Lesson3 = subjects.Where(x => x.Title == WednesdayLesson_3_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }

                    if (WednesdayLesson_4_ComboBox.Text == string.Empty)
                    {
                        wednesday.Lesson4 = null;
                    }
                    else
                    {
                        wednesday.Lesson4 = subjects.Where(x => x.Title == WednesdayLesson_4_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                }

                var thursday = context.Thursdays.Where(x => x.NumberGroup == SelectGroup.SelectedItem)
                    .FirstOrDefault();
                if(thursday != null)
                {
                    if (ThursdayLesson_1_ComboBox.Text == string.Empty)
                    {
                        thursday.Lesson1 = null;
                    }
                    else 
                    {
                        thursday.Lesson1 = subjects.Where(x => x.Title == ThursdayLesson_1_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }

                    if (ThursdayLesson_2_ComboBox.Text == string.Empty)
                    {
                        thursday.Lesson2 = null;
                    }
                    else
                    {
                        thursday.Lesson2 = subjects.Where(x => x.Title == ThursdayLesson_2_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }

                    if (ThursdayLesson_3_ComboBox.Text == string.Empty)
                    {
                        thursday.Lesson3 = null;
                    }
                    else
                    {
                        thursday.Lesson3 = subjects.Where(x => x.Title == ThursdayLesson_3_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }

                    if (ThursdayLesson_4_ComboBox.Text == string.Empty)
                    {
                        thursday.Lesson4 = null;
                    }
                    else
                    {
                        thursday.Lesson4 = subjects.Where(x => x.Title == ThursdayLesson_4_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                }

                var friday = context.Fridays.Where(x => x.NumberGroup == SelectGroup.SelectedItem)
                    .FirstOrDefault();
                if (friday != null)
                {
                    if (FridayLesson_1_ComboBox.Text == string.Empty)
                    {
                        friday.Lesson1 = null;
                    }
                    else 
                    {
                        friday.Lesson1 = subjects.Where(x => x.Title == FridayLesson_1_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                    if (FridayLesson_2_ComboBox.Text == string.Empty)
                    {
                        friday.Lesson2 = null;
                    }
                    else
                    {
                        friday.Lesson2 = subjects.Where(x => x.Title == FridayLesson_2_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                    if (FridayLesson_3_ComboBox.Text == string.Empty)
                    {
                        friday.Lesson3 = null;
                    }
                    else
                    {
                        friday.Lesson3 = subjects.Where(x => x.Title == FridayLesson_3_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                    if (FridayLesson_4_ComboBox.Text == string.Empty)
                    {
                        friday.Lesson4 = null;
                    }
                    else
                    {
                        friday.Lesson4 = subjects.Where(x => x.Title == FridayLesson_4_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                }

                var saturday = context.Saturdays.Where(x => x.NumberGroup == SelectGroup.SelectedItem)
                    .FirstOrDefault();
                if (saturday != null) 
                {
                    if (SaturdayLesson_1_ComboBox.Text == string.Empty)
                    {
                        saturday.Lesson1 = null;
                    }
                    else
                    {
                        saturday.Lesson1 = subjects.Where(x => x.Title == SaturdayLesson_1_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                    if (SaturdayLesson_2_ComboBox.Text == string.Empty)
                    {
                        saturday.Lesson2 = null;
                    }
                    else
                    {
                        saturday.Lesson2 = subjects.Where(x => x.Title == SaturdayLesson_2_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                    if (SaturdayLesson_3_ComboBox.Text == string.Empty)
                    {
                        saturday.Lesson3 = null;
                    }
                    else
                    {
                        saturday.Lesson3 = subjects.Where(x => x.Title == SaturdayLesson_3_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                    if (SaturdayLesson_4_ComboBox.Text == string.Empty)
                    {
                        saturday.Lesson4 = null;
                    }
                    else
                    {
                        saturday.Lesson4 = subjects.Where(x => x.Title == SaturdayLesson_4_ComboBox.Text)
                            .FirstOrDefault().SubjectId;
                    }
                }
                context.SaveChanges();
                MessageBox.Show("Расписание сохранено!");
            }

        }
    }
}
