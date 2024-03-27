using System;
using System.Collections.Generic;
using Electronic_diary.Classes.Entities;

namespace Electronic_diary.Classes.weekday;

public partial class Saturday
{
    public string NumberGroup { get; set; } = null!;

    public int? Lesson1 { get; set; }

    public int? Lesson2 { get; set; }

    public int? Lesson3 { get; set; }

    public int? Lesson4 { get; set; }

    public virtual Subject? Lesson1Navigation { get; set; }

    public virtual Subject? Lesson2Navigation { get; set; }

    public virtual Subject? Lesson3Navigation { get; set; }

    public virtual Subject? Lesson4Navigation { get; set; }

    public virtual Group NumberGroupNavigation { get; set; } = null!;
}
