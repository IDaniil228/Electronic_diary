using Electronic_diary.Classes.Entities;

namespace Electronic_diary.Classes
{
    internal static class CurrentData
    {
        public static Student CurrentStudent { get; set; }
        public static Admin CurrentAdmin { get; set; }
        public static Subject CurrentSubject { get; set; }
    }
}
