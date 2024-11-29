using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.main
{
    public class Menu
    {
        public static void Display()
        {
            Console.WriteLine("\n--- Quản lý sinh viên ---");
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Xóa sinh viên");
            Console.WriteLine("3. Hiển thị danh sách");
            Console.WriteLine("4. Tìm kiếm sinh viên");
            Console.WriteLine("5. Lọc danh sách theo mức độ khó");
            Console.WriteLine("6. Sắp xếp danh sách");
            Console.WriteLine("7. Thống kê dữ liệu");
            Console.WriteLine("8. Phân nhóm sinh viên theo độ tuổi");
            Console.WriteLine("9. Tìm sinh viên trùng tên");
            Console.WriteLine("10. Kiểm tra các sinh viên cùng độ khó");
            Console.WriteLine("11. Tìm kiếm nâng cao");
            Console.WriteLine("12. Thoát");
            Console.Write("Chọn chức năng: ");
        }
    }
}
