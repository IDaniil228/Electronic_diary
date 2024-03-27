using Electronic_diary.Classes;
using System.Data;

namespace Electronic_magazine.Forms
{
    public partial class AdminProfileForm : Form
    {
        public AdminProfileForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Закрытие окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Выбор новой фотографии из файлов
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
        /// <summary>
        /// Открытие нужныз элементов управления для изменения данных
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
            PhoneTextBox.Text = CurrentData.CurrentAdmin.Phone;
            EmailTextBox.Text = CurrentData.CurrentAdmin.Email;
        }
        /// <summary>
        /// Сохранение данных в бд
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
            CurrentData.CurrentAdmin.Phone = PhoneTextBox.Text;
            CurrentData.CurrentAdmin.Email = EmailTextBox.Text;
            using (var context = new DiaryContext())
            {
                var admin = context.Students.Where(s => s.Login == CurrentData.CurrentAdmin.Login).Single();
                admin.Phone = PhoneTextBox.Text;
                admin.Email = EmailTextBox.Text;
                using (var ms = new MemoryStream())
                {
                    PhotoPictureBox.Image.Save(ms, PhotoPictureBox.Image.RawFormat);
                    admin.Photo = ms.ToArray();
                    CurrentData.CurrentAdmin.Photo = admin.Photo;
                }
                context.SaveChanges();
            }
        }
        /// <summary>
        /// Заполнение формы информацией о админе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminProfileForm_Load(object sender, EventArgs e)
        {
            var imageMemoryStream = new MemoryStream(CurrentData.CurrentAdmin.Photo);
            PhotoPictureBox.Image = Image.FromStream(imageMemoryStream);
            SurnameLabel.Text = CurrentData.CurrentAdmin.Surname;
            NameLable.Text = CurrentData.CurrentAdmin.Name;
            PatronymicLabel.Text = CurrentData.CurrentAdmin.Patronymic;
            EmailLabel.Text = "Почта - " + CurrentData.CurrentAdmin.Email;
            PhoneLabel.Text = "Телефон - " + CurrentData.CurrentAdmin.Phone;
        }
    }
}
