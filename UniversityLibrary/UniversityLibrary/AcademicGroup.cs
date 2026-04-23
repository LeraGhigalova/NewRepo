using System;
using System.Collections;
using System.Collections.Generic;

namespace UniversityLibrary
{
    public class AcademicGroup : IEnumerable<Student>
    {
        public string GroupName { get; set; }
        public int StudentCount => students.Count;

        private List<Student> students;

        public AcademicGroup(string groupName, IEnumerable<Student> initialStudents)
        {
            GroupName = groupName;
            students = new List<Student>();

            if (initialStudents != null)
            {
                foreach (var student in initialStudents)
                {
                    if (!students.Contains(student))
                    {
                        students.Add(student);
                    }
                }
            }
        }

        public IEnumerator<Student> GetEnumerator()
        {
            return students.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
