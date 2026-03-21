using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace UniversityLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public string Institute { get; set; }

        public readonly string StudentIdNumber;
        public readonly EducationLevel Level;

        public Student(
            string name,
            string surname,
            string StudentIdNumber,
            string group,
            string insitute,
            EducationLevel level)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Institute = Institute;
            Level = level;
        }

        public virtual string[] GetInfo()
        {
            string[] info = new string[2];
            info[0] = $"{Name} {Surname}";
            string LevelText;
            switch (Level)
            {
                case EducationLevel.Bachelor:
                    LevelText = "бакалавриат";
                    break;
                case EducationLevel.Specialist:
                    LevelText = "специалитет";
                    break;
                case EducationLevel.Master:
                    LevelText = "магистратура";
                    break;
                default:
                    LevelText = "не указано";
                    break;
            };

            info[1] = $"Зачётная книжка: {StudentIdNumber}. Группа: {Group}. Институт: {Institute}. Направление:{LevelText}.";
            return info; 
        }
    }
}
