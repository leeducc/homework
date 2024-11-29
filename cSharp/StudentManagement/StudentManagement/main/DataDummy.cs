using StudentManagement.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.main
{
    public class DataDummy
    {
        public static void AddData(StudentManager manager)
        {
            manager.AddStudent(new Student { Name = "Alice", Age = 20, GPA = 8.5f });
            manager.AddStudent(new Student { Name = "Bob", Age = 19, GPA = 6.5f });
            manager.AddStudent(new Student { Name = "Charlie", Age = 21, GPA = 4.5f });
            manager.AddStudent(new Student { Name = "David", Age = 22, GPA = 7.0f });
            manager.AddStudent(new Student { Name = "Eve", Age = 20, GPA = 9.0f });
            manager.AddStudent(new Student { Name = "Frank", Age = 23, GPA = 5.8f });
            manager.AddStudent(new Student { Name = "Grace", Age = 18, GPA = 3.9f });
        }
    }
}
