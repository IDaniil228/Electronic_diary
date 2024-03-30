using Electronic_diary.Classes;
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
    }
}
