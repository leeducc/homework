using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.entity
{
    class StudentManager : IStudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        public void DisplayAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.StudentID}, Name: {student.StudentName}, Math: {student.MathGrade}, Physics: {student.PhysicsGrade}, Chemistry: {student.ChemistryGrade}");
            }
        }

        public double CalculateGPA(string studentID)
        {
            var student = students.Find(s => s.StudentID == studentID);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return 0;
            }
            return (student.MathGrade + student.PhysicsGrade + student.ChemistryGrade) / 3;
        }
    }

}
