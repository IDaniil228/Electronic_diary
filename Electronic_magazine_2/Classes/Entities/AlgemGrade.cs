namespace Electronic_diary.Classes.Entities;

public partial class AlgemGrade
{
    public int StudentId { get; set; }

    public int? Test1 { get; set; }

    public int? Test2 { get; set; }

    public int? Exam1 { get; set; }

    public int? Exam2 { get; set; }

    public virtual Student Student { get; set; } = null!;
}
