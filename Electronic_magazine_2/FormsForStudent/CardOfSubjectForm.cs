using Electronic_diary.Classes;
using System.Data;

namespace Electronic_magazine
{
    public partial class CardOfSubjectForm : Form
    {
        public CardOfSubjectForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Сохранение заметок в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            using (var context = new DiaryContext())
            {
                var note = context.Notes.Where(n => n.StudentId == CurrentData.CurrentStudent.StudentId).Single();
                switch (CurrentData.CurrentSubject.Title)
                {
                    case "Мат.анализ":
                        note.Matanalysis = NotesRichTextBox.Text;
                        break;
                    case "Алгебра и геометрия":
                        note.AlgebraAndGeometry = NotesRichTextBox.Text;
                        break;
                    case "Физическая культура":
                        note.Physical = NotesRichTextBox.Text;
                        break;
                    case "Анлг. яз":
                        note.English = NotesRichTextBox.Text;
                        break;
                }
                context.SaveChanges();
            }
            CurrentData.CurrentSubject = null;
            Close();
        }
        /// <summary>
        /// Заполнение формы при открытии 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardOfSubjectForm_Load(object sender, EventArgs e)
        {
            SubjectTitleLable.Text = CurrentData.CurrentSubject.Title;
            DescriptionLabel.Text = CurrentData.CurrentSubject.Description;
            ClassroomLable.Text = "Кабинет - " + CurrentData.CurrentSubject.Classroom;
            using (var context = new DiaryContext())
            {
                var note = context.Notes.Where(n => n.StudentId == CurrentData.CurrentStudent.StudentId).Single();
                if (CurrentData.CurrentSubject.Title == "Мат. анализ")
                {
                    NotesRichTextBox.Text = note.Matanalysis;
                }
                else if (CurrentData.CurrentSubject.Title == "Алгебра и геометрия")
                {
                    NotesRichTextBox.Text = note.AlgebraAndGeometry;
                }
                else if (CurrentData.CurrentSubject.Title == "Физическая культура")
                {
                    NotesRichTextBox.Text = note.Physical;
                }
                else if (CurrentData.CurrentSubject.Title == "Анлг. яз")
                {
                    NotesRichTextBox.Text = note.English;
                }
            }
        }
    }
}
