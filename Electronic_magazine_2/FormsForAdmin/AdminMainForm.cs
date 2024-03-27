using Electronic_diary.Classes;
using Electronic_diary.FormsForAdmin;
using Electronic_magazine.Forms;

namespace Electronic_magazine.FormsForAdmin
{
    public partial class AdminMainForm : Form
    {
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
    }
}
