using System;
using System.Collections.Generic;
using System.Text;

namespace _29.SoftAcademy
{
    class Academy
    {
        private string acadName;
        private List<string> courses;
        private List<string> students;

        public string AcadName
        {
            get { return acadName; }
            set { acadName = value; }
        }
        public List<string> Courses
        {
            get { return courses; }
            set { courses = value; }
        }
        public List<string> Students
        {
            get { return students; }
            set { students = value; }
        }
        public Academy(string acadName, List<string> courses, List<string> students)
        {
            this.acadName = acadName;
            this.courses = courses;
            this.students = students;
        }
        public override string ToString()
        {
            return "Academy name: " + acadName + ", courses: " + courses + ", student: " + students;
        }
    }
}
