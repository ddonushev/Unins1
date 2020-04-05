namespace StudentInfoSystem
{
    public class Student
    {
        public Student()
        {
        }

        public Student(string nameI, string middleNameI, string lastNameI, string facultyI, string majorI, string OKSI,
            string studentStatusI, string fakNoI, string kursI, string potokI, string grupaI)
        {
            name = nameI;
            middleName = middleNameI;
            lastName = lastNameI;
            faculty = facultyI;
            major = majorI;
            OKS = OKSI;
            studentStatus = studentStatusI;
            fakNo = fakNoI;
            kurs = kursI;
            potok = potokI;
            grupa = grupaI;
        }

        public string name { get; set; }

        public string middleName { get; set; }

        public string lastName { get; set; }

        public string faculty { get; set; }

        public string major { get; set; }

        public string OKS { get; set; }

        public string studentStatus { get; set; }

        public string fakNo { get; set; }

        public string kurs { get; set; }

        public string potok { get; set; }

        public string grupa { get; set; }
    }
}