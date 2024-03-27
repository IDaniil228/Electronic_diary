using System;
using System.Collections.Generic;
using Electronic_diary.Classes.weekday;

namespace Electronic_diary.Classes.Entities;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string Title { get; set; } = null!;

    public string Classroom { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Duration { get; set; } = null!;

    public virtual ICollection<Friday> FridayLesson1Navigations { get; set; } = new List<Friday>();

    public virtual ICollection<Friday> FridayLesson2Navigations { get; set; } = new List<Friday>();

    public virtual ICollection<Friday> FridayLesson3Navigations { get; set; } = new List<Friday>();

    public virtual ICollection<Friday> FridayLesson4Navigations { get; set; } = new List<Friday>();

    public virtual ICollection<Monday> MondayLesson1Navigations { get; set; } = new List<Monday>();

    public virtual ICollection<Monday> MondayLesson2Navigations { get; set; } = new List<Monday>();

    public virtual ICollection<Monday> MondayLesson3Navigations { get; set; } = new List<Monday>();

    public virtual ICollection<Monday> MondayLesson4Navigations { get; set; } = new List<Monday>();

    public virtual ICollection<Saturday> SaturdayLesson1Navigations { get; set; } = new List<Saturday>();

    public virtual ICollection<Saturday> SaturdayLesson2Navigations { get; set; } = new List<Saturday>();

    public virtual ICollection<Saturday> SaturdayLesson3Navigations { get; set; } = new List<Saturday>();

    public virtual ICollection<Saturday> SaturdayLesson4Navigations { get; set; } = new List<Saturday>();

    public virtual ICollection<Thursday> ThursdayLesson1Navigations { get; set; } = new List<Thursday>();

    public virtual ICollection<Thursday> ThursdayLesson2Navigations { get; set; } = new List<Thursday>();

    public virtual ICollection<Thursday> ThursdayLesson3Navigations { get; set; } = new List<Thursday>();

    public virtual ICollection<Thursday> ThursdayLesson4Navigations { get; set; } = new List<Thursday>();

    public virtual ICollection<Tuesday> TuesdayLesson1Navigations { get; set; } = new List<Tuesday>();

    public virtual ICollection<Tuesday> TuesdayLesson2Navigations { get; set; } = new List<Tuesday>();

    public virtual ICollection<Tuesday> TuesdayLesson3Navigations { get; set; } = new List<Tuesday>();

    public virtual ICollection<Tuesday> TuesdayLesson4Navigations { get; set; } = new List<Tuesday>();

    public virtual ICollection<Wednesday> WednesdayLesson1Navigations { get; set; } = new List<Wednesday>();

    public virtual ICollection<Wednesday> WednesdayLesson2Navigations { get; set; } = new List<Wednesday>();

    public virtual ICollection<Wednesday> WednesdayLesson3Navigations { get; set; } = new List<Wednesday>();

    public virtual ICollection<Wednesday> WednesdayLesson4Navigations { get; set; } = new List<Wednesday>();
}
