/*
 * BÀI 2: BIẾN VÀ KIỂU DỮ LIỆU TRONG C#
 * ====================================
 * 
 * Trong bài này chúng ta sẽ học về:
 * 1. Các kiểu dữ liệu cơ bản (int, string, bool, double, etc.)
 * 2. Cách khai báo và khởi tạo biến
 * 3. Quy tắc đặt tên biến
 * 4. Const và readonly
 * 5. Var keyword và type inference
 */

using System;

namespace Lesson02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BÀI 2: BIẾN VÀ KIỂU DỮ LIỆU ===\n");

            // 1. KIỂU DỮ LIỆU SỐ NGUYÊN
            Console.WriteLine("1. Kiểu dữ liệu số nguyên:");
            
            int tuoi = 25;              // 32-bit số nguyên (-2 tỷ đến +2 tỷ)
            long soNguoiTrenTrai = 8000000000L; // 64-bit số nguyên (thêm L ở cuối)
            short namSinh = 1999;       // 16-bit số nguyên (-32,768 đến 32,767)
            byte diem = 100;            // 8-bit số nguyên (0 đến 255)
            
            Console.WriteLine($"Tuổi: {tuoi}");
            Console.WriteLine($"Số người trên trái đất: {soNguoiTrenTrai:N0}");
            Console.WriteLine($"Năm sinh: {namSinh}");
            Console.WriteLine($"Điểm: {diem}");

            // 2. KIỂU DỮ LIỆU SỐ THỰC
            Console.WriteLine("\n2. Kiểu dữ liệu số thực:");
            
            double chieuCao = 1.75;     // 64-bit số thực (độ chính xác cao)
            float canNang = 65.5f;      // 32-bit số thực (thêm f ở cuối)
            decimal tienLuong = 15000000.50m; // 128-bit số thực (dành cho tiền tệ, thêm m)
            
            Console.WriteLine($"Chiều cao: {chieuCao} mét");
            Console.WriteLine($"Cân nặng: {canNang} kg");
            Console.WriteLine($"Tiền lương: {tienLuong:C}"); // :C format tiền tệ

            // 3. KIỂU DỮ LIỆU CHUỖI VÀ KÝ TỰ
            Console.WriteLine("\n3. Kiểu dữ liệu chuỗi và ký tự:");
            
            string hoTen = "Nguyễn Văn A"; // Chuỗi ký tự
            char gioiTinh = 'M';           // Một ký tự duy nhất (dùng dấu ' không phải ")
            string diaChi = "Hà Nội, Việt Nam";
            
            Console.WriteLine($"Họ tên: {hoTen}");
            Console.WriteLine($"Giới tính: {gioiTinh}");
            Console.WriteLine($"Địa chỉ: {diaChi}");

            // 4. KIỂU DỮ LIỆU BOOLEAN
            Console.WriteLine("\n4. Kiểu dữ liệu Boolean (true/false):");
            
            bool laSinhVien = true;     // true hoặc false
            bool daKetHon = false;
            bool coGiayPhep = tuoi >= 18; // Biểu thức logic
            
            Console.WriteLine($"Là sinh viên: {laSinhVien}");
            Console.WriteLine($"Đã kết hôn: {daKetHon}");
            Console.WriteLine($"Có giấy phép (≥18 tuổi): {coGiayPhep}");

            // 5. KIỂU DỮ LIỆU DATETIME
            Console.WriteLine("\n5. Kiểu dữ liệu ngày tháng:");
            
            DateTime ngayHienTai = DateTime.Now;     // Ngày giờ hiện tại
            DateTime ngaySinh = new DateTime(1999, 5, 15); // Năm, tháng, ngày
            
            Console.WriteLine($"Ngày hiện tại: {ngayHienTai:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine($"Ngày sinh: {ngaySinh:dd/MM/yyyy}");

            // 6. BIẾN CONST (HẰNG SỐ)
            Console.WriteLine("\n6. Hằng số (const):");
            
            const double PI = 3.14159;  // Hằng số không thể thay đổi
            const string TEN_TRUONG = "Đại học Công nghệ";
            
            Console.WriteLine($"Số PI: {PI}");
            Console.WriteLine($"Tên trường: {TEN_TRUONG}");

            // 7. VAR KEYWORD - TỰ ĐỘNG XÁC ĐỊNH KIỂU
            Console.WriteLine("\n7. Từ khóa 'var' - tự động xác định kiểu:");
            
            var tenSanPham = "Laptop Dell"; // Tự động thành string
            var giaSanPham = 15000000;      // Tự động thành int
            var ngayMua = DateTime.Now;     // Tự động thành DateTime
            
            Console.WriteLine($"Sản phẩm: {tenSanPham} (kiểu: {tenSanPham.GetType().Name})");
            Console.WriteLine($"Giá: {giaSanPham:N0} VNĐ (kiểu: {giaSanPham.GetType().Name})");
            Console.WriteLine($"Ngày mua: {ngayMua:dd/MM/yyyy} (kiểu: {ngayMua.GetType().Name})");

            // 8. THAO TÁC VỚI CHUỖI
            Console.WriteLine("\n8. Thao tác với chuỗi:");
            
            string ten = "Nguyễn";
            string ho = "Văn A";
            string hoTenDayDu = ten + " " + ho;           // Nối chuỗi bằng +
            string thongTin = $"Tên: {ten}, Họ: {ho}";   // String interpolation
            
            Console.WriteLine($"Họ tên đầy đủ: {hoTenDayDu}");
            Console.WriteLine($"Thông tin: {thongTin}");
            Console.WriteLine($"Độ dài tên: {hoTenDayDu.Length} ký tự");
            Console.WriteLine($"Chữ hoa: {hoTenDayDu.ToUpper()}");
            Console.WriteLine($"Chữ thường: {hoTenDayDu.ToLower()}");

            // 9. NULLABLE TYPES - CHO PHÉP GIÁ TRỊ NULL
            Console.WriteLine("\n9. Nullable types - cho phép giá trị null:");
            
            int? tuoiCoTheNull = null;  // int? có thể chứa null
            DateTime? ngayKetHon = null; // Chưa kết hôn nên để null
            
            Console.WriteLine($"Tuổi có thể null: {tuoiCoTheNull?.ToString() ?? "Không có giá trị"}");
            Console.WriteLine($"Ngày kết hôn: {ngayKetHon?.ToString("dd/MM/yyyy") ?? "Chưa kết hôn"}");

            Console.WriteLine("\n=== KẾT THÚC BÀI 2 ===");
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
