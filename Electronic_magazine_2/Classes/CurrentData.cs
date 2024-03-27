using Electronic_diary.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_diary.Classes
{
    internal static class CurrentData
    {
        public static Student CurrentStudent { get; set; }
        public static Admin CurrentAdmin{ get; set; }
        public static Subject CurrentSubject { get; set; }
    }
}
