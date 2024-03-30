using Electronic_diary.Classes;
using Electronic_magazine.FormsForAdmin;
using Microsoft.EntityFrameworkCore;

namespace Electronic_magazine
{
    public partial class AuthorizationForm : Form
    {

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMinimaze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (SelectRole.Text == String.Empty)
            {
                MessageBox.Show("Выберите значене в ячейке 'Войти как'", "Ошибка входа");
                return;
            }
            if (SelectRole.Text == "Студент")
            {
                using (var context = new DiaryContext())
                {
                    var students = context.Students.Include(s => s.NumberGroupNavigation);
                    foreach (var student in students)
                    {
                        if (LoginTextBox.Text.Trim() == student.Login)
                        {
                            if (PasswordTextBox.Text.Trim() == student.Password)
                            {
                                CurrentData.CurrentStudent = student;
                                StudentMainForm studentMainForm = new StudentMainForm();
                                studentMainForm.Show();
                                Hide();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль", "Ошибка входа");
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Неверный логин", "Ошибка входа");
                    return;
                }
            }
            if (SelectRole.Text.Trim() == "Администратор")
            {
                using (var context = new DiaryContext())
                {
                    var admins = context.Admins;
                    foreach (var admin in admins)
                    {
                        if (LoginTextBox.Text.Trim() == admin.Login)
                        {
                            if (PasswordTextBox.Text.Trim() == admin.Password)
                            {
                                CurrentData.CurrentAdmin = admin;
                                AdminMainForm adminMainForm = new AdminMainForm();
                                adminMainForm.Show();
                                Hide();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль", "Ошибка входа");
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Неверный логин", "Ошибка входа");
                    return;
                }
            }
        }
    }
}
