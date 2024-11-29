using System;
using StudentManagement.entity;
using StudentManagement.main;

namespace StudentManagement.main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var manager = new StudentManager();
            DataDummy.AddData(manager);

            var controller = new StudentController(manager);
            controller.Run();
        }
    }
}
