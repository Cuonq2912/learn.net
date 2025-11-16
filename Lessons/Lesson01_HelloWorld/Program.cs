/*
 * BÀI 1: HELLO WORLD VÀ CÚ PHÁP CƠ BẢN C#
 * =========================================
 * 
 * Đây là bài học đầu tiên về C# .NET
 * Chúng ta sẽ học về:
 * 1. Cấu trúc chương trình C# cơ bản
 * 2. Namespace và using statements
 * 3. Console.WriteLine() để in ra màn hình
 * 4. Comments (ghi chú) trong code
 */

// Using statement: Import các thư viện cần thiết
// System chứa các class cơ bản như Console
using System;

// Namespace: Không gian tên để tổ chức code
namespace Lesson01_HelloWorld
{
    // Class: Lớp chứa code của chúng ta
    // Mọi chương trình C# đều phải có ít nhất 1 class
    class Program
    {
        // Main method: Điểm bắt đầu của chương trình
        // static: có thể gọi mà không cần tạo object
        // void: không trả về giá trị
        // string[] args: tham số dòng lệnh
        static void Main(string[] args)
        {
            // In ra màn hình - đây là câu lệnh đầu tiên của mọi lập trình viên!
            Console.WriteLine("Xin chào thế giới! Hello World!");
            
            // Ví dụ khác về in ra màn hình
            Console.WriteLine("Chào mừng bạn đến với C# .NET!");
            
            // Console.Write() in không xuống dòng
            Console.Write("Tôi tên là: ");
            Console.Write("Học viên C#");
            Console.WriteLine(); // Xuống dòng
            
            // Sử dụng escape characters (ký tự đặc biệt)
            Console.WriteLine("Dòng 1\nDòng 2"); // \n = xuống dòng
            Console.WriteLine("Tab:\tVị trí tab"); // \t = tab
            Console.WriteLine("Dấu ngoặc kép: \"Hello\""); // \" = dấu "
            
            // Chờ người dùng nhấn phím để thoát
            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
