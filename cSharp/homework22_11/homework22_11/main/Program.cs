using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework22_11.entity;

namespace homework22_11.main
{
    public class Program
    {
        public static void Main()
        {
            var manager = new ProductManager();
            DataDummy(manager);

            int choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Hiển thị tất cả sản phẩm");
                Console.WriteLine("2. Lọc sản phẩm theo điều kiện");
                Console.WriteLine("3. Thống kê sản phẩm");
                Console.WriteLine("4. Thêm sản phẩm mới");
                Console.WriteLine("5. Xóa sản phẩm");
                Console.WriteLine("6. Cập nhật giá sản phẩm");
                Console.WriteLine("7. Thoát");
                Console.Write("Chọn một tùy chọn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.DisplayProducts();
                        break;

                    case 2:
                        Console.WriteLine("Nhập giá thấp nhất: ");
                        var minPrice = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập giá cao nhất: ");
                        var maxPrice = decimal.Parse(Console.ReadLine());
                        var filtered = manager.FilterProducts(p => p.Price >= minPrice && p.Price <= maxPrice);
                        Console.WriteLine("\nDanh sách sản phẩm lọc:");
                        foreach (var product in filtered)
                        {
                            Console.WriteLine(product.GetInfo());
                        }
                        break;

                    case 3:
                        var grouped = manager.FilterProducts(p => true).GroupBy(p => p.Category);
                        foreach (var group in grouped)
                        {
                            Console.WriteLine($"\n {group.Key} : {group.Count()} sản phẩm ");
                            
                        }
                        break;

                    case 4:
                        Console.WriteLine("Nhập loại sản phẩm (1: Electronics, 2: Clothing): ");
                        var type = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập ID: ");
                        var id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Nhập tên: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Nhập giá: ");
                        var price = decimal.Parse(Console.ReadLine());

                        if (type == 1)
                        {
                            var category = "Electronics";
                           Console.WriteLine("Nhập bảo hành (năm): ");
                            var warranty = int.Parse(Console.ReadLine());
                            manager.AddProduct(new Electronics { Id = id, Name = name, Price = price, Category = category, WarrantyYears = warranty });
                        }
                        else if (type == 2)
                        {
                            var category = "Clothing";
                            Console.WriteLine("Nhập kích thước: ");
                            var size = Console.ReadLine();
                            manager.AddProduct(new Clothing { Id = id, Name = name, Price = price, Category = category, Size = size });
                        }
                        Console.WriteLine("Sản phẩm đã được thêm!");
                        break;

                    case 5:
                        Console.WriteLine("Nhập giá tối đa để xóa sản phẩm: ");
                        var maxRemovePrice = decimal.Parse(Console.ReadLine());
                        manager.RemoveProducts(p => p.Price <= maxRemovePrice);
                        Console.WriteLine("Các sản phẩm phù hợp đã bị xóa!");
                        break;

                    case 6:
                        Console.WriteLine("1. Tăng giá Clothing 10%");
                        Console.WriteLine("2. Giảm giá sản phẩm > 1000 xuống 5%");
                        var updateChoice = int.Parse(Console.ReadLine());
                        if (updateChoice == 1)
                        {
                            manager.UpdatePrices(p =>
                            {
                                if (p is Clothing)
                                    p.Price *= 1.1m;
                            });
                        }
                        else if (updateChoice == 2)
                        {
                            manager.UpdatePrices(p =>
                            {
                                if (p.Price > 1000)
                                    p.Price *= 0.95m;
                            });
                        }
                        Console.WriteLine("Cập nhật giá thành công!");
                        break;

                    case 7:
                        Console.WriteLine("Thoát chương trình!");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

            } while (choice != 7);
        }

        private static void DataDummy(ProductManager manager)
        {
            manager.AddProduct(new Electronics { Id = 1, Name = "Laptop", Price = 1200, Category = "Electronics", WarrantyYears = 2 });
            manager.AddProduct(new Electronics { Id = 2, Name = "Smartphone", Price = 700, Category = "Electronics", WarrantyYears = 1 });
            manager.AddProduct(new Clothing { Id = 3, Name = "T-Shirt", Price = 20, Category = "Clothing", Size = "M" });
            manager.AddProduct(new Clothing { Id = 4, Name = "Jeans", Price = 50, Category = "Clothing", Size = "L" });

        }
    }

}
