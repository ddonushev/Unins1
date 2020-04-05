using System.Collections.Generic;

namespace StudentInfoSystem
{
    public class StudentData
    {
        private List<Student> _testStudents;

        public List<Student> TestStudents
        {
            get => _testStudents;
            private set { }
        }
    }
}