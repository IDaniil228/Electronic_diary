using System;
using System.Collections.Generic;

namespace Electronic_diary.Classes.Entities;

public partial class Admin
{
    public int AdminId { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronymic { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte[]? Photo { get; set; }
}
