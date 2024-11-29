using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using StudentManagement.entity;

namespace StudentManagement.main
{

    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Sinh viên đã được thêm thành công.");
        }


        public void RemoveStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Sinh viên đã bị xóa.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên với ID này.");
            }
        }


        public void DisplayAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên trống.");
                return;
            }

            Console.WriteLine("Danh sách sinh viên:");
            students.ForEach(s => s.DisplayInfo());
        }


        public void SearchStudents(string keyword)
        {
            var results = students.Where(s =>
                s.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                s.Id.ToString() == keyword).ToList();

            if (results.Count > 0)
            {
                Console.WriteLine($"Tìm thấy {results.Count} sinh viên:");
                results.ForEach(s => s.DisplayInfo());
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên.");
            }
        }
        public void FilterByDifficulty(string level)
        {
            var filtered = students.Where(s => s.DifficultyLevel == level).ToList();
            if (filtered.Count > 0)
            {
                Console.WriteLine($"Danh sách Sinh viên có mức độ {level}: ");
                filtered.ForEach(s => s.DisplayInfo());
            }
            else
            {
                Console.WriteLine("Không có sinh viên phù hợp");
            }
        }
        public void Sort()
        {
            var sorted = students.OrderByDescending(s => s.GPA)
                                 .ThenByDescending(s => s.DifficultyLevel)
                                 .ThenByDescending(s => s.Name)
                                 .ToList();
            Console.WriteLine("Danh sách sinh viên sắp xếp :");
            sorted.ForEach(s => s.DisplayInfo());
        }

        public void topGPA()
        {
            var topGPA = students.OrderByDescending(s => s.GPA)
                                 .Take(3)
                                 .ToList();
            Console.WriteLine("Top 3 GPA: ");
            foreach (var student in topGPA)
            {
                student.DisplayInfo();
            }
        }

        public void SortByUserChoice()
        {
            if (students == null || students.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên trống");
                return;
            }

            Console.WriteLine("Bạn muốn xếp tên theo thứ tự :");
            Console.WriteLine("1. Tăng dần");
            Console.WriteLine("2. Giảm dần");
            string nameChoice = Console.ReadLine();


            Console.WriteLine("Bạn muốn xếp tuổi theo thứ tự :");
            Console.WriteLine("1. Tăng dần");
            Console.WriteLine("2. Giảm dần");
            string ageChoice = Console.ReadLine();
            var sortedStudent = students.AsEnumerable();

            if (nameChoice == "1")
            {
                sortedStudent = sortedStudent.OrderBy(s => s.Name);
            }
            else if (nameChoice == "2")
            {
                sortedStudent = sortedStudent.OrderByDescending(s => s.Name);
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ");
            }

            if (ageChoice == "1")
            {
                sortedStudent = sortedStudent.OrderBy(s => s.Age);
            }
            else if (ageChoice == "2")
            {
                sortedStudent = sortedStudent.OrderByDescending(s => s.Age);
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ");
            }

            var finalList = sortedStudent.ToList();

            Console.WriteLine("Danh sách sinh viên sau khi sắp xếp: ");
            foreach (var student in finalList)
            {
                student.DisplayInfo();
            }

        }


        public void AnalyzeData()
        {
            int studentCount = students.Count;
            Console.WriteLine($"Tổng số sinh viên: {studentCount}");
            var groupCount = students.GroupBy(s => s.DifficultyLevel)
                                     .Select(g => new { Level = g.Key, Count = g.Count() })
                                     .ToList();

            foreach (var group in groupCount)
            {
                double percentage = (double)group.Count / studentCount * 100;
                Console.WriteLine($"Mức độ {group.Level}: {group.Count} sinh viên chiếm {percentage:F2}% tổng số sinh viên");
            }


            var maxGPAStudent = students.OrderByDescending(s => s.GPA).FirstOrDefault();
            var minGPAStudent = students.OrderBy(s => s.GPA).FirstOrDefault();
            var averageGPA = students.Average(s => s.GPA);

            Console.WriteLine($"Sinh viên có GPA cao nhất: {maxGPAStudent?.Name}, GPA: {maxGPAStudent?.GPA}");
            Console.WriteLine($"Sinh viên có GPA thấp nhất: {minGPAStudent?.Name}, GPA: {minGPAStudent?.GPA}");
            Console.WriteLine($"GPA trung bình: {averageGPA:F2}");
        }

        public void GroupByAge()
        {

            var groups = students.GroupBy(s =>
                s.Age < 18 ? "Dưới 18" :
                s.Age <= 22 ? "18-22" : "Trên 22")
                .Select(g => new { AgeGroup = g.Key, Count = g.Count() });

            foreach (var group in groups)
            {
                Console.WriteLine($"Nhóm {group.AgeGroup}: {group.Count} sinh viên");
            }
        }


        public void FindDuplicateNames()
        {
            var duplicates = students.GroupBy(s => s.Name.ToLower())
                                     .Where(g => g.Count() > 1)
                                     .Select(g => g.Key)
                                     .ToList();

            if (duplicates.Count > 0)
            {
                Console.WriteLine("Sinh viên có tên trùng lặp:");
                duplicates.ForEach(name => Console.WriteLine(name));
            }
            else
            {
                Console.WriteLine("Không có tên trùng lặp.");
            }
        }


        public void CheckSameDifficultyLevel()
        {
            bool isSameDifficultyLevel = students.All(s => s.DifficultyLevel == students[0].DifficultyLevel);
            Console.WriteLine(isSameDifficultyLevel
                ? "Tất cả sinh viên có cùng mức độ khó."
                : "Sinh viên có các mức độ khó khác nhau.");
        }

        public List<Student> AdvancedSearch(List<Student> students, double maxGPA, int maxAge)
        {
            if (students == null || students.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên trống.");
                return new List<Student>();
            }


            var filteredStudents = students
                .Where(s => s.GPA < maxGPA && s.Age < maxAge)
                .ToList();

            return filteredStudents;
        }

        public void SearchStudentsByGpaAndAge()
        {
            Console.WriteLine("Nhập điểm GPA tối đa:");
            double maxGPA;
            if (!double.TryParse(Console.ReadLine(), out maxGPA))
            {
                Console.WriteLine("GPA không hợp lệ.");
                return;
            }

            Console.WriteLine("Nhập độ tuổi tối đa:");
            int maxAge;
            if (!int.TryParse(Console.ReadLine(), out maxAge))
            {
                Console.WriteLine("Tuổi không hợp lệ.");
                return;
            }


            var results = AdvancedSearch(students, maxGPA, maxAge);


            if (results.Count == 0)
            {
                Console.WriteLine("Không tìm thấy sinh viên nào.");
            }
            else
            {
                Console.WriteLine("Danh sách sinh viên phù hợp:");
                foreach (var student in results)
                {
                    student.DisplayInfo();
                }
            }
        }
    }
}

