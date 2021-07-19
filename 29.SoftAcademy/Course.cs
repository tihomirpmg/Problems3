using System;
using System.Collections.Generic;
using System.Text;

namespace _29.SoftAcademy
{
    class Course
    {
        private string courseName;
        private string eMail;
        private List<string> students;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string EMail
        {
            get { return eMail; }
            set { eMail = value; }
        }
        public List<string> Students
        {
            get { return students; }
            set { students = value; }
        }
        public Course(string courseName, string eMail, List<string> students)
        {
            this.courseName = courseName;
            this.eMail = eMail;
            this.students = students;
        }
        public override string ToString()
        {
            return "Course name: " + courseName + ", student e-mail: " + eMail + ", student: " + students;
        }
    }
}
