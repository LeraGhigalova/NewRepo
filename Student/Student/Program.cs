using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public Student(string name, string surname, DateTime birthday, string gender)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Gender = gender;
        }

        public virtual string[] GetInfo()
        {
            string[] info = new string[2];
            info[0] = $"{Name} {Surname}";
            info[1] = $"Дата рождения: {Birthday:dd.MM.yyyy}. Пол: {Gender}.";
            return info;
        }
    }
}
