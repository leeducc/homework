using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.entity
{
    interface IStudentManager
    {
        void AddStudent(Student student);
        void DisplayAllStudents();
        double CalculateGPA(string studentID);
    }
}
