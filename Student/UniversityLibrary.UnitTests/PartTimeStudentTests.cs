using NUnit.Framework;
using System;
using UniversityLibrary;

namespace UniversityLibrary.UnitTests
{
    [TestFixture]
    public class PartTimeStudentTests
    {
        private PartTimeStudent GetTestStudent()
        {
            return new PartTimeStudent("Мария", "Петрова", new DateTime(1999, 8, 20), "Женский",
                                       "ООО Ромашка", "Бухгалтер");
        }

        [Test]
        public void ConstructorTest()
        {
            var student = GetTestStudent();
            Assert.That(student.Name, Is.EqualTo("Мария"));
            Assert.That(student.Surname, Is.EqualTo("Петрова"));
            Assert.That(student.WorkPlace, Is.EqualTo("ООО Ромашка"));
            Assert.That(student.JobTitle, Is.EqualTo("Бухгалтер"));
        }

        [Test]
        public void GetInfoTest()
        {
            var student = GetTestStudent();
            var result = student.GetInfo();

            Assert.That(result.Length, Is.EqualTo(4));
            Assert.That(result[0], Is.EqualTo("Мария Петрова"));
            Assert.That(result[2], Is.EqualTo("Место работы: ООО Ромашка"));
            Assert.That(result[3], Is.EqualTo("Должность: Бухгалтер"));
        }
    }
}





