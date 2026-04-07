using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary
{
    public class FullTimeStudent : Student
    {
        public int ExamScore { get; set; }
        public FullTimeStudent(string name, string surname, DateTime birthday, string gender, int examScore)
            : base(name, surname, birthday, gender)
        {
            ExamScore = examScore;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            var extendedInfo = new string[baseInfo.Length + 1];
            baseInfo.CopyTo(extendedInfo, 0);
            extendedInfo[baseInfo.Length] = $"Балл ЕГЭ: {ExamScore}";
            return extendedInfo;
        }
    }
}
