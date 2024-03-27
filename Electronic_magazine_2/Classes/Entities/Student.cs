namespace Electronic_diary.Classes;

public partial class Student
{
    public int StudentId { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string NumberGroup { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte[]? Photo { get; set; }

    public virtual Group NumberGroupNavigation { get; set; } = null!;
}
