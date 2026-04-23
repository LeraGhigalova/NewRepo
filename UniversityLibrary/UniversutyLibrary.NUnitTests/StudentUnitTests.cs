using NUnit.Framework;
using System.Collections.Generic;

namespace UniversityLibrary.NUnitTests
{
    [TestFixture]
    public class StudentUnitTests
    {
        private Student CreateTestStudent()
        {
            return new Student(
                "Иван",
                "Петров",
                "A123456",
                "ИВТ-301",
                "Институт информационных технологий",
                EducationLevel.Bachelor
            );
        }

        [Test]
        public void ConstructorTest()
        {
            var student = CreateTestStudent();

            Assert.That(student.Name, Is.EqualTo("Иван"));
            Assert.That(student.Surname, Is.EqualTo("Петров"));
            Assert.That(student.StudentIdNumber, Is.EqualTo("A123456"));
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
            Assert.That(info[1], Is.EqualTo("Зачётная книжка: A123456. Группа: ИВТ-301. Институт: Институт информационных технологий. Уровень: бакалавриат"));
        }

        [Test]
        public void CompareTo_SortBySurnameThenByName()
        {
            var studentA1 = new Student("Иван", "А", "001", "Группа1", "Институт1", EducationLevel.Bachelor);
            var studentA2 = new Student("Сидр", "А", "002", "Группа1", "Институт1", EducationLevel.Bachelor);
            var studentB1 = new Student("Пётр", "Б", "003", "Группа1", "Институт1", EducationLevel.Bachelor);

            var students = new List<Student> { studentA2, studentB1, studentA1 };
            students.Sort();

            Assert.That(students[0].Name, Is.EqualTo("Иван"));
            Assert.That(students[0].Surname, Is.EqualTo("А"));

            Assert.That(students[1].Name, Is.EqualTo("Сидр"));
            Assert.That(students[1].Surname, Is.EqualTo("А"));

            Assert.That(students[2].Name, Is.EqualTo("Пётр"));
            Assert.That(students[2].Surname, Is.EqualTo("Б"));

            Assert.That(studentA1.CompareTo(studentB1), Is.LessThan(0));
            Assert.That(studentB1.CompareTo(studentA1), Is.GreaterThan(0));
            Assert.That(studentA1.CompareTo(studentA2), Is.LessThan(0));
        }
    }
}
