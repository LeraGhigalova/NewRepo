using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class PartTimeStudent : Student
    {
        public string WorkPlace { get; set; }
        public string JobTitle { get; set; }
        public PartTimeStudent(string name, string surname, DateTime birthday, string gender, string workPlace, string jobTitle)
            : base(name, surname, birthday, gender)
        {
            WorkPlace = workPlace;
            JobTitle = jobTitle;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            var extendedInfo = new string[baseInfo.Length + 2];
            baseInfo.CopyTo(extendedInfo, 0);
            extendedInfo[baseInfo.Length] = $"Место работы: {WorkPlace}";
            extendedInfo[baseInfo.Length + 1] = $"Должность: {JobTitle}";
            return extendedInfo;
        }
    }
}
