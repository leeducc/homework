using Q3.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3.main
{
    class Program
    {
        static void Main()
        {
            StudentManager manager = new StudentManager();

            
            manager.AddStudent(new Student("S1", "Duc", 85, 90, 95));
            manager.AddStudent(new Student("S2", "Long", 78, 88, 82));

            
            Console.WriteLine("All Students:");
            manager.DisplayAllStudents();

           
            Console.WriteLine($"GPA of S1: {manager.CalculateGPA("S1")}");
        }
    }
}
