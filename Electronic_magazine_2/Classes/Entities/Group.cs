using System;
using System.Collections.Generic;
using Electronic_diary.Classes.weekday;

namespace Electronic_diary.Classes;

public partial class Group
{
    public string NumberGroup { get; set; } = null!;

    public virtual Friday? Friday { get; set; }

    public virtual Monday? Monday { get; set; }

    public virtual Saturday? Saturday { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    public virtual Thursday? Thursday { get; set; }

    public virtual Tuesday? Tuesday { get; set; }

    public virtual Wednesday? Wednesday { get; set; }
}
