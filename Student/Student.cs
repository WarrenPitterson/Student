using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string name { get; set; }
        public int semester { get; set; }
        public int rollNumber { get; set; }
        public DateTime dateOfAdmission { get; set; }

        public Student()
        {
            this.name = "student";
            this.semester = 1;
            this.rollNumber = 0000;
            this.dateOfAdmission = dateOfAdmission;
        }

        public Student(string name, int semester, int rollNumber, DateTime dateOfAdmission)
        {
            this.name = name;
            this.semester = semester;
            this.rollNumber = rollNumber;
            this.dateOfAdmission = dateOfAdmission;
        }
    }
}
