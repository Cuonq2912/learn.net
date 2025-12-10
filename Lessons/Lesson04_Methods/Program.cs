/*
 * BÀI 4: METHODS (PHƯƠNG THỨC/HÀM) TRONG C#
 * ========================================
 * 
 * Trong bài này chúng ta sẽ học về:
 * 1. Cách khai báo và gọi method
 * 2. Method có tham số và không có tham số
 * 3. Method có giá trị trả về và void
 * 4. Method overloading (nạp chồng phương thức)
 * 5. Tham số ref, out và params
 * 6. Method static và non-static
 */

using System;

namespace Lesson04_Methods
{
    class Program
    {
        // Method Main - điểm bắt đầu chương trình
        static void Main(string[] args)
        {
            Console.WriteLine("=== BÀI 4: METHODS (PHƯƠNG THỨC) ===\n");

            // 1. GỌI METHOD KHÔNG THAM SỐ
            Console.WriteLine("1. Method không có tham số:");
            ChaoMung(); // Gọi method ChaoMung
            InThongTinCongTy();

            // 2. GỌI METHOD CÓ THAM SỐ
            Console.WriteLine("\n2. Method có tham số:");
            ChaoNguoiDung("Nguyễn Văn A");
            ChaoNguoiDung("Trần Thị B");
            InThongTin("John", 25, "Hà Nội");

            // 3. METHOD CÓ GIÁ TRỊ TRẢ VỀ
            Console.WriteLine("\n3. Method có giá trị trả về:");
            
            int tong = TinhTong(10, 20);
            Console.WriteLine($"Tổng của 10 và 20 là: {tong}");
            
            double dienTich = TinhDienTichHinhTron(5);
            Console.WriteLine($"Diện tích hình tròn bán kính 5: {dienTich:F2}");
            
            bool laSoNguyenTo = KiemTraSoNguyenTo(17);
            Console.WriteLine($"17 có phải số nguyên tố không? {laSoNguyenTo}");

            // 4. METHOD OVERLOADING (NẠPCHỒNG)
            Console.WriteLine("\n4. Method Overloading:");
            
            Console.WriteLine($"Tính tổng 2 số: {TinhTong(5, 3)}");
            Console.WriteLine($"Tính tổng 3 số: {TinhTong(5, 3, 2)}");
            Console.WriteLine($"Tính tổng 2 số thực: {TinhTong(5.5, 3.2):F1}");

            // 5. THAM SỐ REF VÀ OUT
            Console.WriteLine("\n5. Tham số ref và out:");
            
            int soA = 10;
            int soB = 20;
            Console.WriteLine($"Trước khi hoán đổi: A={soA}, B={soB}");
            HoanDoiSo(ref soA, ref soB); // ref: truyền tham chiếu
            Console.WriteLine($"Sau khi hoán đổi: A={soA}, B={soB}");
            
            // Sử dụng out parameter
            int thuong, du;
            ChiaNguyen(17, 3, out thuong, out du);
            Console.WriteLine($"17 chia 3 = {thuong} dư {du}");

            // 6. THAM SỐ PARAMS
            Console.WriteLine("\n6. Tham số params (số lượng tham số không xác định):");
            
            double trungBinh1 = TinhTrungBinh(8, 9, 7);
            double trungBinh2 = TinhTrungBinh(8, 9, 7, 6, 10);
            Console.WriteLine($"Trung bình 3 số: {trungBinh1:F1}");
            Console.WriteLine($"Trung bình 5 số: {trungBinh2:F1}");

            // 7. VÍ DỤ THỰC TẾ
            Console.WriteLine("\n7. Ví dụ thực tế - Chương trình quản lý học sinh:");
            
            string tenHS = "Nguyễn Văn Nam";
            double[] diemSo = { 8.5, 7.0, 9.0, 8.0 };
            
            double dtb = TinhDiemTrungBinh(diemSo);
            string xepLoai = XepLoaiHocSinh(dtb);
            bool doDaiLop = KiemTraDoDaiLop(dtb);
            
            Console.WriteLine($"Học sinh: {tenHS}");
            Console.WriteLine($"Điểm trung bình: {dtb:F1}");
            Console.WriteLine($"Xếp loại: {xepLoai}");
            Console.WriteLine($"Có được lên lớp không? {(doDaiLop ? "Có" : "Không")}");

            Console.WriteLine("\n=== KẾT THÚC BÀI 4 ===");
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        // =============================================
        // CÁC METHODS ĐƯỢC ĐỊNH NGHĨA BÊN DƯỚI
        // =============================================

        /// <summary>
        /// Method không có tham số và không trả về giá trị (void)
        /// </summary>
        static void ChaoMung()
        {
            Console.WriteLine("🎉 Chào mừng bạn đến với bài học về Methods!");
        }

        /// <summary>
        /// Method in thông tin công ty
        /// </summary>
        static void InThongTinCongTy()
        {
            Console.WriteLine("Công ty: ABC Technology");
            Console.WriteLine("Địa chỉ: 123 Đường ABC, Hà Nội");
            Console.WriteLine("Email: info@abctech.com");
        }

        /// <summary>
        /// Method có một tham số
        /// </summary>
        /// <param name="tenNguoiDung">Tên người dùng</param>
        static void ChaoNguoiDung(string tenNguoiDung)
        {
            Console.WriteLine($"Xin chào, {tenNguoiDung}! Chúc bạn học tốt C#!");
        }

        /// <summary>
        /// Method có nhiều tham số
        /// </summary>
        /// <param name="ten">Tên</param>
        /// <param name="tuoi">Tuổi</param>
        /// <param name="diaChi">Địa chỉ</param>
        static void InThongTin(string ten, int tuoi, string diaChi)
        {
            Console.WriteLine($"Họ tên: {ten}");
            Console.WriteLine($"Tuổi: {tuoi}");
            Console.WriteLine($"Địa chỉ: {diaChi}");
        }

        /// <summary>
        /// Method trả về giá trị - tính tổng 2 số
        /// </summary>
        /// <param name="a">Số thứ nhất</param>
        /// <param name="b">Số thứ hai</param>
        /// <returns>Tổng của a và b</returns>
        static int TinhTong(int a, int b)
        {
            return a + b; // Trả về kết quả
        }

        /// <summary>
        /// Method overload - tính tổng 3 số
        /// </summary>
        static int TinhTong(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Method overload - tính tổng 2 số thực
        /// </summary>
        static double TinhTong(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Tính diện tích hình tròn
        /// </summary>
        /// <param name="banKinh">Bán kính hình tròn</param>
        /// <returns>Diện tích</returns>
        static double TinhDienTichHinhTron(double banKinh)
        {
            const double PI = 3.14159;
            return PI * banKinh * banKinh;
        }

        /// <summary>
        /// Kiểm tra số nguyên tố
        /// </summary>
        /// <param name="n">Số cần kiểm tra</param>
        /// <returns>true nếu là số nguyên tố, false nếu không</returns>
        static bool KiemTraSoNguyenTo(int n)
        {
            if (n < 2) return false;
            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            
            return true;
        }

        /// <summary>
        /// Hoán đổi 2 số sử dụng ref parameter
        /// </summary>
        /// <param name="a">Số thứ nhất (tham chiếu)</param>
        /// <param name="b">Số thứ hai (tham chiếu)</param>
        static void HoanDoiSo(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Phép chia nguyên với out parameter
        /// </summary>
        /// <param name="soBiChia">Số bị chia</param>
        /// <param name="soChia">Số chia</param>
        /// <param name="thuong">Thương (out parameter)</param>
        /// <param name="du">Số dư (out parameter)</param>
        static void ChiaNguyen(int soBiChia, int soChia, out int thuong, out int du)
        {
            thuong = soBiChia / soChia;
            du = soBiChia % soChia;
        }

        /// <summary>
        /// Tính trung bình với params (số lượng tham số không xác định)
        /// </summary>
        /// <param name="cacSo">Mảng các số</param>
        /// <returns>Trung bình cộng</returns>
        static double TinhTrungBinh(params double[] cacSo)
        {
            if (cacSo.Length == 0) return 0;
            
            double tong = 0;
            foreach (double so in cacSo)
            {
                tong += so;
            }
            
            return tong / cacSo.Length;
        }

        /// <summary>
        /// Tính điểm trung bình từ mảng điểm
        /// </summary>
        /// <param name="diemSo">Mảng điểm số</param>
        /// <returns>Điểm trung bình</returns>
        static double TinhDiemTrungBinh(double[] diemSo)
        {
            double tong = 0;
            foreach (double diem in diemSo)
            {
                tong += diem;
            }
            return tong / diemSo.Length;
        }

        /// <summary>
        /// Xếp loại học sinh dựa trên điểm trung bình
        /// </summary>
        /// <param name="diemTrungBinh">Điểm trung bình</param>
        /// <returns>Xếp loại</returns>
        static string XepLoaiHocSinh(double diemTrungBinh)
        {
            if (diemTrungBinh >= 9.0) return "Xuất sắc";
            else if (diemTrungBinh >= 8.0) return "Giỏi";
            else if (diemTrungBinh >= 6.5) return "Khá";
            else if (diemTrungBinh >= 5.0) return "Trung bình";
            else return "Yếu";
        }

        /// <summary>
        /// Kiểm tra học sinh có đủ điều kiện lên lớp không
        /// </summary>
        /// <param name="diemTrungBinh">Điểm trung bình</param>
        /// <returns>true nếu được lên lớp</returns>
        static bool KiemTraDoDaiLop(double diemTrungBinh)
        {
            return diemTrungBinh >= 5.0; // Điều kiện lên lớp là DTB >= 5.0
        }
    }
}
