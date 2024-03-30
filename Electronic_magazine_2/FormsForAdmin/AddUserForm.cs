using Electronic_diary.Classes;
using Electronic_diary.Classes.Entities;

namespace Electronic_diary.FormsForAdmin
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
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
        }
        /// <summary>
        /// Сворачивание формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Разблокировка элементов управления после выбора роли
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectRole.Text == "Студент")
            {
                NameTextBox.Enabled = true;
                SurnameTextBox.Enabled = true;
                PatronymicTextBox.Enabled = true;
                LoginTextBox.Enabled = true;
                PasswordTextBox.Enabled = true;
                GroupLable.Enabled = true;
                GroupLable.Visible = true;
                GroupComboBox.Visible = true;
                GroupComboBox.Enabled = true;
            }
            if (SelectRole.Text == "Администратор")
            {
                NameTextBox.Enabled = true;
                SurnameTextBox.Enabled = true;
                PatronymicTextBox.Enabled = true;
                LoginTextBox.Enabled = true;
                PasswordTextBox.Enabled = true;
                GroupComboBox.Visible = false;
                GroupComboBox.Enabled = false;
                GroupLable.Enabled = false;
                GroupLable.Visible = false;
            }
        }
        /// <summary>
        /// Запись нового пользователя в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == string.Empty || SurnameTextBox.Text == string.Empty ||
                PatronymicTextBox.Text == string.Empty || LoginTextBox.Text == string.Empty ||
                PasswordTextBox.Text == string.Empty)
            {
                MessageBox.Show("Заполнены не все данные", "Ошибка регистрации");
                return;
            }
            using (var context = new DiaryContext())
            {
                if (SelectRole.Text == "Студент")
                {
                    if (GroupComboBox.Text == string.Empty)
                    {
                        MessageBox.Show("Необходимо выбрать группу", "Ошибка регистрации");
                        return;
                    }
                    var students = context.Students;
                    foreach (var student in students)
                    {
                        if (student.Login == LoginTextBox.Text)
                        {
                            MessageBox.Show("Такой логин уже существует!", "Ошибка регистрации");
                            return;
                        }
                    }
                    Student newStudent = new Student();
                    newStudent.Login = LoginTextBox.Text;
                    newStudent.Surname = SurnameTextBox.Text;
                    newStudent.Name = NameTextBox.Text;
                    newStudent.Patronymic = PatronymicTextBox.Text;
                    newStudent.Password = PasswordTextBox.Text;
                    newStudent.NumberGroup = GroupComboBox.Text;
                    context.Students.Add(newStudent);

                    //Note newNote = new Note();
                    //context.Notes.Add(newNote);
                    //AlgemGrade newAlgemGrade = new AlgemGrade();
                    //newAlgemGrade.StudentId = newStudent.StudentId;
                    //context.AlgemGrades.Add(newAlgemGrade);
                    //EnglishGrade newEnglishGrade = new EnglishGrade();
                    //newEnglishGrade.StudentId = newStudent.StudentId;
                    //context.EnglishGrades.Add(newEnglishGrade);
                    //MatanalysisGrade matanalysisGrade = new MatanalysisGrade();
                    //matanalysisGrade.StudentId = newStudent.StudentId;
                    //context.MatanalysisGrades.Add(matanalysisGrade);
                    //Pegrade newPegrade = new Pegrade();
                    //newPegrade.StudentId = newStudent.StudentId;
                    //context.Pegrades.Add(newPegrade);

                    context.SaveChanges();
                    MessageBox.Show("Новый студент зарегистрирован", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                if (SelectRole.Text == "Администратор")
                {
                    var admins = context.Admins;
                    foreach (var admin in admins)
                    {
                        if (admin.Login == LoginTextBox.Text)
                        {
                            MessageBox.Show("Такой логин уже существует!", "Ошибка регистрации");
                            return;
                        }
                    }
                    Admin newAdmin = new Admin();
                    newAdmin.Login = LoginTextBox.Text;
                    newAdmin.Surname = SurnameTextBox.Text;
                    newAdmin.Name = NameTextBox.Text;
                    newAdmin.Patronymic = PatronymicTextBox.Text;
                    newAdmin.Password = PasswordTextBox.Text;
                    context.Admins.Add(newAdmin);
                    context.SaveChanges();
                    MessageBox.Show("Новый aдминистратор зарегистрирован", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();


            }
        }
    }
}
