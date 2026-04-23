using System;

namespace UniversityLibrary
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
        public string Institute { get; set; }
        public readonly string StudentIdNumber;
        public readonly EducationLevel Level;

        public Student(string name, string surname, string studentIdNumber, string group, string institute, EducationLevel level)
        {
            Name = name;
            Surname = surname;
            StudentIdNumber = studentIdNumber;
            Group = group;
            Institute = institute;
            Level = level;
        }

        public virtual string[] GetInfo()
        {
            string[] info = new string[2];
            info[0] = $"{Name} {Surname}";
            string levelText;
            switch (Level)
            {
                case EducationLevel.Bachelor:
                    levelText = "бакалавриат";
                    break;
                case EducationLevel.Specialist:
                    levelText = "специалитет";
                    break;
                case EducationLevel.Master:
                    levelText = "магистратура";
                    break;
                default:
                    levelText = "не указано";
                    break;
            }
            info[1] = $"Зачётная книжка: {StudentIdNumber}. Группа: {Group}. Институт: {Institute}. Уровень: {levelText}";
            return info;
        }

        public int CompareTo(Student other)
        {
            if (other == null) return 1;

            int surnameComparison = Surname.CompareTo(other.Surname);
            if (surnameComparison != 0)
                return surnameComparison;

            return Name.CompareTo(other.Name);
        }

        public override bool Equals(object obj)
        {
            if (obj is Student other)
                return StudentIdNumber == other.StudentIdNumber;
            return false;
        }

        public override int GetHashCode()
        {
            return StudentIdNumber?.GetHashCode() ?? 0;
        }
    }
}





