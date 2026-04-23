using NUnit.Framework;
using System.Collections.Generic;

namespace UniversityLibrary.NUnitTests
{
    [TestFixture]
    public class AcademicGroupTests
    {
        private Student student1;
        private Student student2;
        private Student student3;
        private Student studentDuplicate;

        [SetUp]
        public void Setup()
        {
            student1 = new Student("Иван", "Иванов", "S001", "ИТ-301", "Институт информационных технологий", EducationLevel.Bachelor);
            student2 = new Student("Пётр", "Петров", "S002", "ИТ-301", "Институт информационных технологий", EducationLevel.Bachelor);
            student3 = new Student("Сидор", "Сидоров", "S003", "ИТ-301", "Институт информационных технологий", EducationLevel.Master);
            studentDuplicate = new Student("Иван", "Иванов", "S001", "ИТ-301", "Институт информационных технологий", EducationLevel.Bachelor);
        }

        [TearDown]
        public void TearDown()
        {
            student1 = null;
            student2 = null;
            student3 = null;
            studentDuplicate = null;
        }

        [Test]
        public void Constructor_ShouldNotAddDuplicates()
        {
            var initialStudents = new[] { student1, student2, student3, studentDuplicate };
            var group = new AcademicGroup("Группа 101", initialStudents);
            Assert.That(group.StudentCount, Is.EqualTo(3));
        }

        [Test]
        public void Constructor_ShouldSetGroupNameCorrectly()
        {
            var group = new AcademicGroup("Группа 101", new[] { student1 });
            Assert.That(group.GroupName, Is.EqualTo("Группа 101"));
        }

        [Test]
        public void StudentCount_ShouldReturnCorrectNumberOfUniqueStudents()
        {
            var initialStudents = new List<Student> { student1, student2, student3 };
            var group = new AcademicGroup("Группа 101", initialStudents);
            Assert.That(group.StudentCount, Is.EqualTo(3));
        }

        [Test]
        public void IEnumerable_ShouldIterateOverAllStudents()
        {
            var students = new[] { student1, student2, student3 };
            var group = new AcademicGroup("Группа 101", students);
            var resultList = new List<Student>();

            foreach (var student in group)
            {
                resultList.Add(student);
            }

            Assert.That(resultList.Count, Is.EqualTo(3));
            Assert.That(resultList, Does.Contain(student1));
            Assert.That(resultList, Does.Contain(student2));
            Assert.That(resultList, Does.Contain(student3));
        }

        [Test]
        public void Constructor_WithNullCollection_ShouldCreateEmptyGroup()
        {
            var group = new AcademicGroup("Пустая группа", null);
            Assert.That(group.StudentCount, Is.EqualTo(0));
            Assert.That(group.GroupName, Is.EqualTo("Пустая группа"));
        }
    }
}





