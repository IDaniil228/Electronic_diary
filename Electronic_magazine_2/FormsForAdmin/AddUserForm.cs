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

namespace Electronic_diary.FormsForAdmin
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
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
        /// <summary>
        /// 
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
                PasswordLable.Enabled = true;
                GroupComboBox.Visible = false;
                GroupComboBox.Enabled = false;
                GroupLable.Enabled = false;
                GroupLable.Visible = false;
            }
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            using (var context = new DiaryContext())
            {
                if (SelectRole.Text == "Студент")
                {
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
                    context.Students.Add(newStudent);
                }
                context.SaveChanges();
                return;
            }
        }
    }
}
