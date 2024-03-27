namespace Electronic_diary.Classes.Entities;

public partial class Note
{
    public int StudentId { get; set; }

    public string? Matanalysis { get; set; }

    public string? AlgebraAndGeometry { get; set; }

    public string? Physical { get; set; }

    public string? English { get; set; }

    public virtual Student Student { get; set; } = null!;
}
