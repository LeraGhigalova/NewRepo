using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class TargetStudent : Student
    {
        public string CompanyName { get; set; }
        public decimal TuitionAmount { get; set; }

        public TargetStudent(string name, string surname, DateTime birthday, string gender, string companyName, decimal tuitionAmount)
            : base(name, surname, birthday, gender)
        {
            CompanyName = companyName;
            TuitionAmount = tuitionAmount;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            var extendedInfo = new string[baseInfo.Length + 2];
            baseInfo.CopyTo(extendedInfo, 0);
            extendedInfo[baseInfo.Length] = $"Целевое предприятие: {CompanyName}";
            extendedInfo[baseInfo.Length + 1] = $"Сумма обучения: {TuitionAmount:F2} руб.";
            return extendedInfo;
        }
    }
}
