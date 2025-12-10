/*
 * BÀI 5: LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG (OOP) CƠ BẢN
 * ===============================================
 * 
 * Trong bài này chúng ta sẽ học về:
 * 1. Class và Object
 * 2. Properties (Thuộc tính)
 * 3. Constructor (Hàm khởi tạo)
 * 4. Methods trong class
 * 5. Access modifiers (public, private, protected)
 * 6. Static members
 * 7. Inheritance (Kế thừa) cơ bản
 */

using System;

namespace Lesson05_OOP
{
    // =============================================
    // ĐỊNH NGHĨA CLASS HOCSINH
    // =============================================
    
    /// <summary>
    /// Class đại diện cho một học sinh
    /// Class là blueprint (bản thiết kế) để tạo ra objects
    /// </summary>
    public class HocSinh
    {
        // FIELDS (Trường) - thường là private
        private string _hoTen;
        private int _tuoi;

        // PROPERTIES (Thuộc tính) - cách hiện đại để truy cập fields
        /// <summary>
        /// Họ tên của học sinh
        /// </summary>
        public string HoTen 
        { 
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        /// <summary>
        /// Tuổi học sinh (chỉ cho phép từ 6-25 tuổi)
        /// </summary>
        public int Tuoi 
        { 
            get { return _tuoi; }
            set 
            { 
                if (value >= 6 && value <= 25)
                    _tuoi = value;
                else
                    throw new ArgumentException("Tuổi phải từ 6 đến 25");
            }
        }

        // Auto-implemented properties (Thuộc tính tự động)
        public string Lop { get; set; }
        public double DiemTrungBinh { get; set; }

        // Static field - chung cho tất cả instances
        private static int _soLuongHocSinh = 0;

        // Static property
        public static int SoLuongHocSinh 
        { 
            get { return _soLuongHocSinh; } 
        }

        // CONSTRUCTORS (Hàm khởi tạo)
        
        /// <summary>
        /// Constructor mặc định
        /// </summary>
        public HocSinh()
        {
            _hoTen = "Chưa có tên";
            _tuoi = 18;
            Lop = "Chưa xác định";
            DiemTrungBinh = 0.0;
            _soLuongHocSinh++; // Tăng số lượng học sinh
            
            Console.WriteLine("🎓 Tạo học sinh mới (constructor mặc định)");
        }

        /// <summary>
        /// Constructor có tham số
        /// </summary>
        /// <param name="hoTen">Họ tên</param>
        /// <param name="tuoi">Tuổi</param>
        /// <param name="lop">Lớp</param>
        public HocSinh(string hoTen, int tuoi, string lop)
        {
            _hoTen = hoTen;
            Tuoi = tuoi; // Sử dụng property để validate
            Lop = lop;
            DiemTrungBinh = 0.0;
            _soLuongHocSinh++;
            
            Console.WriteLine($"🎓 Tạo học sinh mới: {hoTen}");
        }

        /// <summary>
        /// Constructor đầy đủ tham số
        /// </summary>
        public HocSinh(string hoTen, int tuoi, string lop, double diemTrungBinh) 
            : this(hoTen, tuoi, lop) // Gọi constructor khác
        {
            DiemTrungBinh = diemTrungBinh;
        }

        // METHODS (Phương thức)
        
        /// <summary>
        /// Hiển thị thông tin học sinh
        /// </summary>
        public void HienThiThongTin()
        {
            Console.WriteLine("─────────────────────────────");
            Console.WriteLine($"Họ tên: {_hoTen}");
            Console.WriteLine($"Tuổi: {_tuoi}");
            Console.WriteLine($"Lớp: {Lop}");
            Console.WriteLine($"Điểm TB: {DiemTrungBinh:F1}");
            Console.WriteLine($"Xếp loại: {LayXepLoai()}");
            Console.WriteLine("─────────────────────────────");
        }

        /// <summary>
        /// Tính xếp loại học sinh
        /// </summary>
        /// <returns>Xếp loại</returns>
        public string LayXepLoai()
        {
            if (DiemTrungBinh >= 9.0) return "Xuất sắc";
            else if (DiemTrungBinh >= 8.0) return "Giỏi";
            else if (DiemTrungBinh >= 6.5) return "Khá";
            else if (DiemTrungBinh >= 5.0) return "Trung bình";
            else return "Yếu";
        }

        /// <summary>
        /// Kiểm tra có đỗ lên lớp không
        /// </summary>
        /// <returns>true nếu đỗ</returns>
        public bool CoDoLenLop()
        {
            return DiemTrungBinh >= 5.0;
        }

        /// <summary>
        /// Cập nhật điểm trung bình
        /// </summary>
        /// <param name="diemMoi">Điểm mới</param>
        public void CapNhatDiem(double diemMoi)
        {
            if (diemMoi >= 0 && diemMoi <= 10)
            {
                DiemTrungBinh = diemMoi;
                Console.WriteLine($"✅ Đã cập nhật điểm TB: {diemMoi:F1}");
            }
            else
            {
                Console.WriteLine("❌ Điểm phải từ 0 đến 10!");
            }
        }

        /// <summary>
        /// Static method - phương thức tĩnh
        /// </summary>
        /// <returns>Thống kê số học sinh</returns>
        public static string LayThongKeHocSinh()
        {
            return $"Tổng số học sinh đã tạo: {_soLuongHocSinh}";
        }

        // Override ToString method
        public override string ToString()
        {
            return $"{_hoTen} - Lớp {Lop} - DTB: {DiemTrungBinh:F1}";
        }
    }

    // =============================================
    // CLASS KẾ THỪA - HOCSINHNANGCAO
    // =============================================
    
    /// <summary>
    /// Class kế thừa từ HocSinh
    /// Minh họa tính inheritance (kế thừa)
    /// </summary>
    public class HocSinhNangCao : HocSinh
    {
        // Thêm thuộc tính riêng
        public string ChuyenNganh { get; set; }
        public bool ThamGiaNghienCuu { get; set; }

        /// <summary>
        /// Constructor của class con
        /// </summary>
        public HocSinhNangCao(string hoTen, int tuoi, string lop, string chuyenNganh) 
            : base(hoTen, tuoi, lop) // Gọi constructor của class cha
        {
            ChuyenNganh = chuyenNganh;
            ThamGiaNghienCuu = false;
            
            Console.WriteLine($"🌟 Tạo học sinh nâng cao chuyên ngành: {chuyenNganh}");
        }

        /// <summary>
        /// Override method từ class cha
        /// </summary>
        public new void HienThiThongTin()
        {
            base.HienThiThongTin(); // Gọi method của class cha
            Console.WriteLine($"Chuyên ngành: {ChuyenNganh}");
            Console.WriteLine($"Tham gia nghiên cứu: {(ThamGiaNghienCuu ? "Có" : "Không")}");
        }

        /// <summary>
        /// Method riêng của class con
        /// </summary>
        public void DangKyNghienCuu()
        {
            ThamGiaNghienCuu = true;
            Console.WriteLine($"✨ {HoTen} đã đăng ký tham gia nghiên cứu!");
        }
    }

    // =============================================
    // CHƯƠNG TRÌNH CHÍNH
    // =============================================
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BÀI 5: LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG ===\n");

            // 1. TẠO OBJECTS (ĐỐI TƯỢNG)
            Console.WriteLine("1. Tạo objects từ class:");
            
            // Sử dụng constructor mặc định
            HocSinh hs1 = new HocSinh();
            hs1.HoTen = "Nguyễn Văn An";
            hs1.Tuoi = 20;
            hs1.Lop = "CNTT01";
            hs1.DiemTrungBinh = 8.5;

            // Sử dụng constructor có tham số
            HocSinh hs2 = new HocSinh("Trần Thị Bình", 19, "CNTT02");
            hs2.DiemTrungBinh = 9.2;

            // Sử dụng constructor đầy đủ
            HocSinh hs3 = new HocSinh("Lê Văn Cường", 21, "CNTT03", 7.8);

            Console.WriteLine();

            // 2. SỬ DỤNG METHODS
            Console.WriteLine("2. Sử dụng methods của objects:");
            
            hs1.HienThiThongTin();
            hs2.HienThiThongTin();
            hs3.HienThiThongTin();

            // 3. SỬ DỤNG STATIC MEMBERS
            Console.WriteLine("\n3. Static members:");
            Console.WriteLine(HocSinh.LayThongKeHocSinh());

            // 4. THAO TÁC VỚI OBJECTS
            Console.WriteLine("\n4. Thao tác với objects:");
            
            Console.WriteLine($"Học sinh {hs2.HoTen} có đỗ lên lớp không? {(hs2.CoDoLenLop() ? "Có" : "Không")}");
            
            hs3.CapNhatDiem(8.5);
            Console.WriteLine($"Xếp loại mới của {hs3.HoTen}: {hs3.LayXepLoai()}");

            // 5. KẾ THỪA (INHERITANCE)
            Console.WriteLine("\n5. Kế thừa - Inheritance:");
            
            HocSinhNangCao hsNC1 = new HocSinhNangCao("Phạm Thị Dung", 22, "CNTT04", "Trí tuệ nhân tạo");
            hsNC1.DiemTrungBinh = 9.5;
            hsNC1.DangKyNghienCuu();
            
            HocSinhNangCao hsNC2 = new HocSinhNangCao("Hoàng Văn Em", 20, "CNTT05", "An ninh mạng");
            hsNC2.DiemTrungBinh = 8.8;

            Console.WriteLine("\nThông tin học sinh nâng cao:");
            hsNC1.HienThiThongTin();
            hsNC2.HienThiThongTin();

            // 6. ARRAY CỦA OBJECTS
            Console.WriteLine("\n6. Array của objects:");
            
            HocSinh[] danhSachHocSinh = { hs1, hs2, hs3, hsNC1, hsNC2 };
            
            Console.WriteLine("Danh sách tất cả học sinh:");
            for (int i = 0; i < danhSachHocSinh.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {danhSachHocSinh[i].ToString()}");
            }

            // 7. TÌM KIẾM VÀ LỌC DỮ LIỆU
            Console.WriteLine("\n7. Tìm kiếm và lọc:");
            
            Console.WriteLine("Học sinh giỏi (DTB >= 8.0):");
            foreach (HocSinh hs in danhSachHocSinh)
            {
                if (hs.DiemTrungBinh >= 8.0)
                {
                    Console.WriteLine($"  🌟 {hs.HoTen}: {hs.DiemTrungBinh:F1}");
                }
            }

            // 8. TỔNG KẾT
            Console.WriteLine($"\n8. Tổng kết:");
            Console.WriteLine(HocSinh.LayThongKeHocSinh());
            
            double tongDiem = 0;
            foreach (HocSinh hs in danhSachHocSinh)
            {
                tongDiem += hs.DiemTrungBinh;
            }
            double diemTrungBinhLop = tongDiem / danhSachHocSinh.Length;
            Console.WriteLine($"Điểm trung bình của lớp: {diemTrungBinhLop:F2}");

            Console.WriteLine("\n=== KẾT THÚC BÀI 5 ===");
            Console.WriteLine("\nKiến thức đã học:");
            Console.WriteLine("✅ Class và Object");
            Console.WriteLine("✅ Properties và Fields");  
            Console.WriteLine("✅ Constructor");
            Console.WriteLine("✅ Methods");
            Console.WriteLine("✅ Access modifiers");
            Console.WriteLine("✅ Static members");
            Console.WriteLine("✅ Inheritance cơ bản");
            
            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
