using System;
using StudentManagement.entity;

namespace StudentManagement.main
{
    class StudentController
    {
        private readonly StudentManager _manager;

        public StudentController(StudentManager manager)
        {
            _manager = manager;
        }

        public void Run()
        {
            int choice;
            do
            {
                Menu.Display();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập tên: ");
                        string name = Console.ReadLine();
                        Console.Write("Nhập tuổi: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Nhập GPA: ");
                        float gpa = float.Parse(Console.ReadLine());
                        _manager.AddStudent(new Student { Name = name, Age = age, GPA = gpa });
                        break;
                    case 2:
                        Console.Write("Nhập ID sinh viên cần xóa: ");
                        int removeId = int.Parse(Console.ReadLine());
                        _manager.RemoveStudent(removeId);
                        break;
                    case 3:
                        _manager.DisplayAllStudents();
                        break;
                    case 4:
                        Console.Write("Nhập từ khóa tìm kiếm: ");
                        string keyword = Console.ReadLine();
                        _manager.SearchStudents(keyword);
                        break;
                    case 5:
                        Console.Write("Nhập mức độ (1.Dễ, 2.Trung bình, 3.Khó): ");
                        int difficultyChoice = int.Parse(Console.ReadLine());
                        string level = difficultyChoice switch
                        {
                            1 => "Dễ",
                            2 => "Trung bình",
                            3 => "Khó",
                            _ => null
                        };

                        if (level == null)
                        {
                            Console.WriteLine("Lựa chọn không hợp lệ");
                        }
                        else
                        {
                            _manager.FilterByDifficulty(level);
                        }
                        break;
                    case 6:
                        _manager.topGPA();
                        Console.WriteLine("Sắp xếp nâng cao");
                        _manager.SortByUserChoice();
                        break;
                    case 7:
                        _manager.AnalyzeData();
                        break;
                    case 8:
                        _manager.GroupByAge();
                        break;
                    case 9:
                        _manager.FindDuplicateNames();
                        break;
                    case 10:
                        _manager.CheckSameDifficultyLevel();
                        break;
                    case 11:
                        _manager.SearchStudentsByGpaAndAge();
                        break;
                    case 12:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            } while (choice != 12);
        }
    }
}
