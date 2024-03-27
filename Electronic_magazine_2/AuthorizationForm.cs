using Electronic_diary.Classes;
using Electronic_magazine.FormsForAdmin;
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
                        if (LoginTextBox.Text == student.Login)
                        {
                            if (PasswordTextBox.Text == student.Password)
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
            if (SelectRole.Text == "Администратор")
            {
                using (var context = new DiaryContext())
                {
                    var admins = context.Admins;
                    foreach (var admin in admins)
                    {
                        if (LoginTextBox.Text == admin.Login)
                        {
                            if (PasswordTextBox.Text == admin.Password)
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
