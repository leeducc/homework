using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.entity
{
    class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public double MathGrade { get; set; }
        public double PhysicsGrade { get; set; }
        public double ChemistryGrade { get; set; }

        public Student(string studentID, string studentName, double math, double physics, double chemistry)
        {
            StudentID = studentID;
            StudentName = studentName;
            MathGrade = math;
            PhysicsGrade = physics;
            ChemistryGrade = chemistry;
        }
    }
}
