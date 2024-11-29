using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.entity
{
    public class Student : Person
    {
        public float GPA { get; set; }
        public string DifficultyLevel =>
            GPA >= 8.0 ? "Dễ" : GPA >= 5.0 ? "Trung bình" : "Khó";
        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, GPA: {GPA}, Difficulty Level: {DifficultyLevel} ");
        }
    }
}
