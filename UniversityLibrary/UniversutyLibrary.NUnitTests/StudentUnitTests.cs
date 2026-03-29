using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UniversityLibrary;

namespace UniversutyLibrary.NUnitTests
{
    [TestFixture]
    public class StudentUnitTests
    {
        private Student CreateTestStudent()
        {
            return new Student(
                name: "Иван",
                surname: "Петров",
                StudentIdNumber: "А123456",
                group: "ИВТ-301",
                insitute: "Институт информационных технологий",
                level: EducationLevel.Bachelor
                );
        }

        [Test]
        public void ConstructorTest()
        {
            var student = CreateTestStudent();

            Assert.That(student.Name, Is.EqualTo("Иван"));
            Assert.That(student.Surname, Is.EqualTo("Петров"));
            Assert.That(student.StudentIdNumber, Is.EqualTo("А123456"));
            Assert.That(student.Group, Is.EqualTo("ИВТ-301"));
            Assert.That(student.Institute, Is.EqualTo("Институт информационных технологий"));
            Assert.That(student.Level, Is.EqualTo(EducationLevel.Bachelor));
        }

        [Test]
        public void GetInfoTest()
        {
            var student = CreateTestStudent();
            var info = student.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Иван Петров"));
            Assert.That(info[1], Is.EqualTo("Зачётная книжка: А123456. Группа: ИВТ-301. Институт: Институт информационных технологий. Направление: бакалавриат."));
        }
    }
}
