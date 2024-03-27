using Electronic_diary.Classes.Entities;
using Electronic_diary.Classes.weekday;
using Microsoft.EntityFrameworkCore;

namespace Electronic_diary.Classes;

public partial class DiaryContext : DbContext
{
    public DiaryContext()
    {
    }

    public DiaryContext(DbContextOptions<DiaryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<AlgemGrade> AlgemGrades { get; set; }

    public virtual DbSet<EnglishGrade> EnglishGrades { get; set; }

    public virtual DbSet<Friday> Fridays { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<MatanalysisGrade> MatanalysisGrades { get; set; }

    public virtual DbSet<Monday> Mondays { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<Pegrade> Pegrades { get; set; }

    public virtual DbSet<Saturday> Saturdays { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Thursday> Thursdays { get; set; }

    public virtual DbSet<Tuesday> Tuesdays { get; set; }

    public virtual DbSet<Wednesday> Wednesdays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=../../../Magazine.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.ToTable("Admin");

            entity.HasIndex(e => e.Login, "IX_Admin_login").IsUnique();

            entity.Property(e => e.AdminId).HasColumnName("adminId");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Photo).HasColumnName("photo");
            entity.Property(e => e.Surname).HasColumnName("surname");
        });

        modelBuilder.Entity<AlgemGrade>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.StudentId, "IX_AlgemGrades_StudentId").IsUnique();

            entity.Property(e => e.Exam1).HasColumnName("exam_1");
            entity.Property(e => e.Exam2).HasColumnName("exam_2");
            entity.Property(e => e.Test1).HasColumnName("test_1");
            entity.Property(e => e.Test2).HasColumnName("test_2");

            entity.HasOne(d => d.Student).WithOne()
                .HasForeignKey<AlgemGrade>(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<EnglishGrade>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.StudentId, "IX_EnglishGrades_StudentId").IsUnique();

            entity.Property(e => e.Exam1).HasColumnName("exam_1");
            entity.Property(e => e.Exam2).HasColumnName("exam_2");
            entity.Property(e => e.Test1).HasColumnName("test_1");
            entity.Property(e => e.Test2).HasColumnName("test_2");

            entity.HasOne(d => d.Student).WithOne()
                .HasForeignKey<EnglishGrade>(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Friday>(entity =>
        {
            entity.HasKey(e => e.NumberGroup);

            entity.ToTable("Friday");

            entity.Property(e => e.NumberGroup)
                .HasColumnType("NUMERIC")
                .HasColumnName("numberGroup");
            entity.Property(e => e.Lesson1).HasColumnName("lesson_1");
            entity.Property(e => e.Lesson2).HasColumnName("lesson_2");
            entity.Property(e => e.Lesson3).HasColumnName("lesson_3");
            entity.Property(e => e.Lesson4).HasColumnName("lesson_4");

            entity.HasOne(d => d.Lesson1Navigation).WithMany(p => p.FridayLesson1Navigations).HasForeignKey(d => d.Lesson1);

            entity.HasOne(d => d.Lesson2Navigation).WithMany(p => p.FridayLesson2Navigations).HasForeignKey(d => d.Lesson2);

            entity.HasOne(d => d.Lesson3Navigation).WithMany(p => p.FridayLesson3Navigations).HasForeignKey(d => d.Lesson3);

            entity.HasOne(d => d.Lesson4Navigation).WithMany(p => p.FridayLesson4Navigations).HasForeignKey(d => d.Lesson4);

            entity.HasOne(d => d.NumberGroupNavigation).WithOne(p => p.Friday)
                .HasForeignKey<Friday>(d => d.NumberGroup)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.NumberGroup);

            entity.ToTable("Group");

            entity.Property(e => e.NumberGroup)
                .HasColumnType("NUMERIC")
                .HasColumnName("numberGroup");
        });

        modelBuilder.Entity<MatanalysisGrade>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.StudentId, "IX_MatanalysisGrades_StudentId").IsUnique();

            entity.Property(e => e.Exam1).HasColumnName("exam_1");
            entity.Property(e => e.Exam2).HasColumnName("exam_2");
            entity.Property(e => e.Test1).HasColumnName("test_1");
            entity.Property(e => e.Test2).HasColumnName("test_2");

            entity.HasOne(d => d.Student).WithOne()
                .HasForeignKey<MatanalysisGrade>(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Monday>(entity =>
        {
            entity.HasKey(e => e.NumberGroup);

            entity.ToTable("Monday");

            entity.Property(e => e.NumberGroup)
                .HasColumnType("NUMERIC")
                .HasColumnName("numberGroup");
            entity.Property(e => e.Lesson1).HasColumnName("lesson_1");
            entity.Property(e => e.Lesson2).HasColumnName("lesson_2");
            entity.Property(e => e.Lesson3).HasColumnName("lesson_3");
            entity.Property(e => e.Lesson4).HasColumnName("lesson_4");

            entity.HasOne(d => d.Lesson1Navigation).WithMany(p => p.MondayLesson1Navigations).HasForeignKey(d => d.Lesson1);

            entity.HasOne(d => d.Lesson2Navigation).WithMany(p => p.MondayLesson2Navigations).HasForeignKey(d => d.Lesson2);

            entity.HasOne(d => d.Lesson3Navigation).WithMany(p => p.MondayLesson3Navigations).HasForeignKey(d => d.Lesson3);

            entity.HasOne(d => d.Lesson4Navigation).WithMany(p => p.MondayLesson4Navigations).HasForeignKey(d => d.Lesson4);

            entity.HasOne(d => d.NumberGroupNavigation).WithOne(p => p.Monday)
                .HasForeignKey<Monday>(d => d.NumberGroup)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.StudentId, "IX_Notes_studentId").IsUnique();

            entity.Property(e => e.AlgebraAndGeometry).HasColumnName("algebraAndGeometry");
            entity.Property(e => e.English).HasColumnName("english");
            entity.Property(e => e.Matanalysis).HasColumnName("matanalysis");
            entity.Property(e => e.Physical).HasColumnName("physical");
            entity.Property(e => e.StudentId).HasColumnName("studentId");

            entity.HasOne(d => d.Student).WithOne()
                .HasForeignKey<Note>(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Pegrade>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PEGrades");

            entity.HasIndex(e => e.StudentId, "IX_PEGrades_StudentId").IsUnique();

            entity.Property(e => e.Exam1).HasColumnName("exam_1");
            entity.Property(e => e.Exam2).HasColumnName("exam_2");
            entity.Property(e => e.Test1).HasColumnName("test_1");
            entity.Property(e => e.Test2).HasColumnName("test_2");

            entity.HasOne(d => d.Student).WithOne()
                .HasForeignKey<Pegrade>(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Saturday>(entity =>
        {
            entity.HasKey(e => e.NumberGroup);

            entity.ToTable("Saturday");

            entity.Property(e => e.NumberGroup)
                .HasColumnType("NUMERIC")
                .HasColumnName("numberGroup");
            entity.Property(e => e.Lesson1).HasColumnName("lesson_1");
            entity.Property(e => e.Lesson2).HasColumnName("lesson_2");
            entity.Property(e => e.Lesson3).HasColumnName("lesson_3");
            entity.Property(e => e.Lesson4).HasColumnName("lesson_4");

            entity.HasOne(d => d.Lesson1Navigation).WithMany(p => p.SaturdayLesson1Navigations).HasForeignKey(d => d.Lesson1);

            entity.HasOne(d => d.Lesson2Navigation).WithMany(p => p.SaturdayLesson2Navigations).HasForeignKey(d => d.Lesson2);

            entity.HasOne(d => d.Lesson3Navigation).WithMany(p => p.SaturdayLesson3Navigations).HasForeignKey(d => d.Lesson3);

            entity.HasOne(d => d.Lesson4Navigation).WithMany(p => p.SaturdayLesson4Navigations).HasForeignKey(d => d.Lesson4);

            entity.HasOne(d => d.NumberGroupNavigation).WithOne(p => p.Saturday)
                .HasForeignKey<Saturday>(d => d.NumberGroup)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.ToTable("Student");

            entity.HasIndex(e => e.Login, "IX_Student_login").IsUnique();

            entity.Property(e => e.StudentId).HasColumnName("studentId");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.NumberGroup)
                .HasColumnType("NUMERIC")
                .HasColumnName("numberGroup");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Photo).HasColumnName("photo");
            entity.Property(e => e.Surname).HasColumnName("surname");

            entity.HasOne(d => d.NumberGroupNavigation).WithMany(p => p.Students)
                .HasForeignKey(d => d.NumberGroup)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.ToTable("Subject");

            entity.Property(e => e.SubjectId).HasColumnName("subjectId");
            entity.Property(e => e.Classroom).HasColumnName("classroom");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Title).HasColumnName("title");
        });

        modelBuilder.Entity<Thursday>(entity =>
        {
            entity.HasKey(e => e.NumberGroup);

            entity.ToTable("Thursday");

            entity.Property(e => e.NumberGroup)
                .HasColumnType("NUMERIC")
                .HasColumnName("numberGroup");
            entity.Property(e => e.Lesson1).HasColumnName("lesson_1");
            entity.Property(e => e.Lesson2).HasColumnName("lesson_2");
            entity.Property(e => e.Lesson3).HasColumnName("lesson_3");
            entity.Property(e => e.Lesson4).HasColumnName("lesson_4");

            entity.HasOne(d => d.Lesson1Navigation).WithMany(p => p.ThursdayLesson1Navigations).HasForeignKey(d => d.Lesson1);

            entity.HasOne(d => d.Lesson2Navigation).WithMany(p => p.ThursdayLesson2Navigations).HasForeignKey(d => d.Lesson2);

            entity.HasOne(d => d.Lesson3Navigation).WithMany(p => p.ThursdayLesson3Navigations).HasForeignKey(d => d.Lesson3);

            entity.HasOne(d => d.Lesson4Navigation).WithMany(p => p.ThursdayLesson4Navigations).HasForeignKey(d => d.Lesson4);

            entity.HasOne(d => d.NumberGroupNavigation).WithOne(p => p.Thursday)
                .HasForeignKey<Thursday>(d => d.NumberGroup)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Tuesday>(entity =>
        {
            entity.HasKey(e => e.NumberGroup);

            entity.ToTable("Tuesday");

            entity.Property(e => e.NumberGroup)
                .HasColumnType("NUMERIC")
                .HasColumnName("numberGroup");
            entity.Property(e => e.Lesson1).HasColumnName("lesson_1");
            entity.Property(e => e.Lesson2).HasColumnName("lesson_2");
            entity.Property(e => e.Lesson3).HasColumnName("lesson_3");
            entity.Property(e => e.Lesson4).HasColumnName("lesson_4");

            entity.HasOne(d => d.Lesson1Navigation).WithMany(p => p.TuesdayLesson1Navigations).HasForeignKey(d => d.Lesson1);

            entity.HasOne(d => d.Lesson2Navigation).WithMany(p => p.TuesdayLesson2Navigations).HasForeignKey(d => d.Lesson2);

            entity.HasOne(d => d.Lesson3Navigation).WithMany(p => p.TuesdayLesson3Navigations).HasForeignKey(d => d.Lesson3);

            entity.HasOne(d => d.Lesson4Navigation).WithMany(p => p.TuesdayLesson4Navigations).HasForeignKey(d => d.Lesson4);

            entity.HasOne(d => d.NumberGroupNavigation).WithOne(p => p.Tuesday)
                .HasForeignKey<Tuesday>(d => d.NumberGroup)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Wednesday>(entity =>
        {
            entity.HasKey(e => e.NumberGroup);

            entity.ToTable("Wednesday");

            entity.Property(e => e.NumberGroup)
                .HasColumnType("NUMERIC")
                .HasColumnName("numberGroup");
            entity.Property(e => e.Lesson1).HasColumnName("lesson_1");
            entity.Property(e => e.Lesson2).HasColumnName("lesson_2");
            entity.Property(e => e.Lesson3).HasColumnName("lesson_3");
            entity.Property(e => e.Lesson4).HasColumnName("lesson_4");

            entity.HasOne(d => d.Lesson1Navigation).WithMany(p => p.WednesdayLesson1Navigations).HasForeignKey(d => d.Lesson1);

            entity.HasOne(d => d.Lesson2Navigation).WithMany(p => p.WednesdayLesson2Navigations).HasForeignKey(d => d.Lesson2);

            entity.HasOne(d => d.Lesson3Navigation).WithMany(p => p.WednesdayLesson3Navigations).HasForeignKey(d => d.Lesson3);

            entity.HasOne(d => d.Lesson4Navigation).WithMany(p => p.WednesdayLesson4Navigations).HasForeignKey(d => d.Lesson4);

            entity.HasOne(d => d.NumberGroupNavigation).WithOne(p => p.Wednesday)
                .HasForeignKey<Wednesday>(d => d.NumberGroup)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
