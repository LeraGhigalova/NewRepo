using NUnit.Framework;
using System;
using UniversityLibrary;

namespace UniversityLibrary.UnitTests
{
    [TestFixture]
    public class TargetStudentTests
    {
        private TargetStudent GetTestStudent()
        {
            return new TargetStudent("Алексей", "Сидоров", new DateTime(2001, 3, 15), "Мужской",
                                     "Газпром", 250000m);
        }

        [Test]
        public void ConstructorTest()
        {
            var student = GetTestStudent();
            Assert.That(student.Name, Is.EqualTo("Алексей"));
            Assert.That(student.Surname, Is.EqualTo("Сидоров"));
            Assert.That(student.CompanyName, Is.EqualTo("Газпром"));
            Assert.That(student.TuitionAmount, Is.EqualTo(250000m));
        }

        [Test]
        public void GetInfoTest()
        {
            var student = GetTestStudent();
            var result = student.GetInfo();

            Assert.That(result.Length, Is.EqualTo(4));
            Assert.That(result[0], Is.EqualTo("Алексей Сидоров"));
            Assert.That(result[2], Is.EqualTo("Целевое предприятие: Газпром"));
            Assert.That(result[3], Is.EqualTo("Сумма обучения: 250000,00 руб."));
        }
    }
}





