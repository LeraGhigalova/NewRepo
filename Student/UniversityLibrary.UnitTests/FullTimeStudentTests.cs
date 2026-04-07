using NUnit.Framework;
using System;
using UniversityLibrary;

namespace UniversityLibrary.UnitTests
{
    [TestFixture]
    public class FullTimeStudentTests
    {
        private FullTimeStudent GetTestStudent()
        {
            return new FullTimeStudent("Иван", "Иванов", new DateTime(2000, 5, 20), "Мужской", 95);
        }

        [Test]
        public void ConstructorTest()
        {
            var student = GetTestStudent();
            Assert.That(student.Name, Is.EqualTo("Иван"));
            Assert.That(student.Surname, Is.EqualTo("Иванов"));
            Assert.That(student.ExamScore, Is.EqualTo(95));
        }

        [Test]
        public void GetInfoTest()
        {
            var student = GetTestStudent();
            var result = student.GetInfo();

            Assert.That(result.Length, Is.EqualTo(3));
            Assert.That(result[0], Is.EqualTo("Иван Иванов"));
            Assert.That(result[2], Is.EqualTo("Балл ЕГЭ: 95"));
        }
    }
}