using Electronic_diary.Classes;
using System.Data;

namespace Electronic_magazine.Forms
{
    public partial class StudentProfileForm : Form
    {
        public StudentProfileForm()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Метод, отвечающий за заполнение формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentProfileForm_Load(object sender, EventArgs e)
        {
            var imageMemoryStream = new MemoryStream(CurrentData.CurrentStudent.Photo);
            PhotoPictureBox.Image = System.Drawing.Image.FromStream(imageMemoryStream);
            SurnameLabel.Text = CurrentData.CurrentStudent.Surname;
            NameLable.Text = CurrentData.CurrentStudent.Name;
            PatronymicLabel.Text = CurrentData.CurrentStudent.Patronymic;
            GroupLabel.Text = "Группа - " + CurrentData.CurrentStudent.NumberGroup;
            EmailLabel.Text = "Почта - " + CurrentData.CurrentStudent.Email;
            PhoneLabel.Text = "Телефон - " + CurrentData.CurrentStudent.Phone;
        }
        /// <summary>
        /// Метод, обрабатывающий кнопку "Редактировать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            PhoneTextBox.Enabled = true;
            PhoneTextBox.Visible = true;
            EmailTextBox.Visible = true;
            EmailTextBox.Enabled = true;
            BtnSave.Enabled = true;
            BtnSave.Visible = true;
            BtnEdit.Enabled = false;
            BtnEdit.Visible = false;
            BtnChange.Enabled = true;
            BtnChange.Visible = true;
            PhoneTextBox.Text = CurrentData.CurrentStudent.Phone;
            EmailTextBox.Text = CurrentData.CurrentStudent.Email;
        }

        /// <summary>
        /// Сохранение данных в бд при нажатии на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            PhoneTextBox.Enabled = false;
            PhoneTextBox.Visible = false;
            EmailTextBox.Visible = false;
            EmailTextBox.Enabled = false;
            BtnSave.Enabled = false;
            BtnSave.Visible = false;
            BtnEdit.Enabled = true;
            BtnEdit.Visible = true;
            BtnChange.Enabled = false;
            BtnChange.Visible = false;
            PhoneLabel.Text = "Телефон - " + PhoneTextBox.Text;
            EmailLabel.Text = "Почта - " + EmailTextBox.Text;
            CurrentData.CurrentStudent.Phone = PhoneTextBox.Text;
            CurrentData.CurrentStudent.Email = EmailTextBox.Text;
            using (var context = new DiaryContext())
            {
                var student = context.Students.Where(s => s.Login == CurrentData.CurrentStudent.Login).Single();
                student.Phone = PhoneTextBox.Text;
                student.Email = EmailTextBox.Text;
                using (var ms = new MemoryStream())
                {
                    PhotoPictureBox.Image.Save(ms, PhotoPictureBox.Image.RawFormat);
                    student.Photo = ms.ToArray();
                    CurrentData.CurrentStudent.Photo = student.Photo;
                }
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Выбор фотки в профиль студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.gif;*.raw;*.jpg)|*.png;*.jpeg;*.gif;*.raw|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PhotoPictureBox.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно загрузить эту картинку", "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
