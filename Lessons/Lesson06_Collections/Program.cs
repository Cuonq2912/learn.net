/*
 * BÀI 6: COLLECTIONS (BỘ SƯU TẬP) TRONG C#
 * =======================================
 * 
 * Trong bài này chúng ta sẽ học về:
 * 1. Arrays (Mảng)
 * 2. List<T> - Danh sách động
 * 3. Dictionary<TKey, TValue> - Từ điển
 * 4. HashSet<T> - Tập hợp không trung lập
 * 5. Queue<T> và Stack<T>
 * 6. LINQ cơ bản để xử lý collections
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson06_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BÀI 6: COLLECTIONS (BỘ SƯU TẬP) ===\n");

            // 1. ARRAYS (MẢNG)
            Console.WriteLine("1. Arrays (Mảng):");
            DemoArrays();

            // 2. LIST<T>
            Console.WriteLine("\n2. List<T> - Danh sách động:");
            DemoList();

            // 3. DICTIONARY<TKEY, TVALUE>
            Console.WriteLine("\n3. Dictionary<TKey, TValue> - Từ điển:");
            DemoDictionary();

            // 4. HASHSET<T>
            Console.WriteLine("\n4. HashSet<T> - Tập hợp không trung lập:");
            DemoHashSet();

            // 5. QUEUE VÀ STACK
            Console.WriteLine("\n5. Queue và Stack:");
            DemoQueueAndStack();

            // 6. LINQ CƠ BẢN
            Console.WriteLine("\n6. LINQ cơ bản:");
            DemoLinq();

            // 7. VÍ DỤ THỰC TẾ
            Console.WriteLine("\n7. Ví dụ thực tế - Quản lý thư viện:");
            DemoQuanLyThuVien();

            Console.WriteLine("\n=== KẾT THÚC BÀI 6 ===");
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        /// <summary>
        /// Demo về Arrays (Mảng)
        /// </summary>
        static void DemoArrays()
        {
            // Khai báo và khởi tạo mảng
            int[] diem = { 8, 7, 9, 6, 10 }; // Mảng có 5 phần tử
            string[] monHoc = new string[3] { "Toán", "Lý", "Hóa" };
            double[] luong = new double[4]; // Mảng rỗng 4 phần tử

            Console.WriteLine("Mảng điểm số:");
            for (int i = 0; i < diem.Length; i++)
            {
                Console.WriteLine($"  Điểm {i + 1}: {diem[i]}");
            }

            Console.WriteLine("Các môn học:");
            foreach (string mon in monHoc)
            {
                Console.WriteLine($"  - {mon}");
            }

            // Thao tác với mảng
            diem[0] = 9; // Thay đổi phần tử đầu tiên
            Array.Sort(diem); // Sắp xếp mảng
            
            Console.WriteLine($"Điểm cao nhất: {diem.Max()}");
            Console.WriteLine($"Điểm thấp nhất: {diem.Min()}");
            Console.WriteLine($"Số môn học: {monHoc.Length}");

            // Mảng 2 chiều
            int[,] bangDiem = {
                {8, 9, 7},  // Học sinh 1
                {6, 8, 9},  // Học sinh 2
                {7, 6, 8}   // Học sinh 3
            };

            Console.WriteLine("Bảng điểm (3 học sinh x 3 môn):");
            for (int hs = 0; hs < 3; hs++)
            {
                Console.Write($"  Học sinh {hs + 1}: ");
                for (int mon = 0; mon < 3; mon++)
                {
                    Console.Write($"{bangDiem[hs, mon]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Demo về List<T>
        /// </summary>
        static void DemoList()
        {
            // Tạo List
            List<string> danhSachHocSinh = new List<string>();
            List<int> danhSachDiem = new List<int> { 8, 7, 9 };

            // Thêm phần tử
            danhSachHocSinh.Add("Nguyễn Văn A");
            danhSachHocSinh.Add("Trần Thị B");
            danhSachHocSinh.Add("Lê Văn C");

            // Thêm nhiều phần tử
            danhSachHocSinh.AddRange(new[] { "Phạm Thị D", "Hoàng Văn E" });

            Console.WriteLine($"Danh sách {danhSachHocSinh.Count} học sinh:");
            for (int i = 0; i < danhSachHocSinh.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {danhSachHocSinh[i]}");
            }

            // Chèn phần tử
            danhSachHocSinh.Insert(2, "Đỗ Văn X"); // Chèn vào vị trí thứ 3
            Console.WriteLine($"Sau khi chèn: {string.Join(", ", danhSachHocSinh)}");

            // Tìm kiếm
            bool coHocSinhB = danhSachHocSinh.Contains("Trần Thị B");
            int viTriB = danhSachHocSinh.IndexOf("Trần Thị B");
            Console.WriteLine($"Có học sinh B: {coHocSinhB}, vị trí: {viTriB}");

            // Xóa phần tử
            danhSachHocSinh.Remove("Đỗ Văn X");
            danhSachHocSinh.RemoveAt(0); // Xóa phần tử đầu tiên
            Console.WriteLine($"Sau khi xóa: {string.Join(", ", danhSachHocSinh)}");

            // Sắp xếp
            danhSachDiem.Sort();
            Console.WriteLine($"Điểm đã sắp xếp: {string.Join(", ", danhSachDiem)}");
        }

        /// <summary>
        /// Demo về Dictionary<TKey, TValue>
        /// </summary>
        static void DemoDictionary()
        {
            // Tạo Dictionary (từ điển)
            Dictionary<string, int> diemHocSinh = new Dictionary<string, int>();
            Dictionary<int, string> monHoc = new Dictionary<int, string>
            {
                {1, "Toán học"},
                {2, "Vật lý"},
                {3, "Hóa học"},
                {4, "Sinh học"}
            };

            // Thêm phần tử
            diemHocSinh.Add("Nguyễn Văn A", 85);
            diemHocSinh.Add("Trần Thị B", 92);
            diemHocSinh["Lê Văn C"] = 78; // Cách thêm khác

            Console.WriteLine("Điểm số của học sinh:");
            foreach (KeyValuePair<string, int> item in diemHocSinh)
            {
                Console.WriteLine($"  {item.Key}: {item.Value} điểm");
            }

            // Truy cập theo key
            if (diemHocSinh.ContainsKey("Nguyễn Văn A"))
            {
                Console.WriteLine($"Điểm của Nguyễn Văn A: {diemHocSinh["Nguyễn Văn A"]}");
            }

            // Cập nhật giá trị
            diemHocSinh["Trần Thị B"] = 95;
            Console.WriteLine($"Điểm mới của Trần Thị B: {diemHocSinh["Trần Thị B"]}");

            // Lấy tất cả keys và values
            Console.WriteLine($"Danh sách học sinh: {string.Join(", ", diemHocSinh.Keys)}");
            Console.WriteLine($"Danh sách điểm: {string.Join(", ", diemHocSinh.Values)}");

            Console.WriteLine("Các môn học:");
            foreach (var item in monHoc)
            {
                Console.WriteLine($"  Môn {item.Key}: {item.Value}");
            }
        }

        /// <summary>
        /// Demo về HashSet<T>
        /// </summary>
        static void DemoHashSet()
        {
            // HashSet không cho phép phần tử trung lập
            HashSet<string> cacMonYeuThich = new HashSet<string>();
            HashSet<int> soNguyenTo = new HashSet<int> { 2, 3, 5, 7, 11, 13 };

            // Thêm phần tử
            cacMonYeuThich.Add("Toán");
            cacMonYeuThich.Add("Lý");
            cacMonYeuThich.Add("Hóa");
            cacMonYeuThich.Add("Toán"); // Không thêm được vì đã có

            Console.WriteLine($"Các môn yêu thích ({cacMonYeuThich.Count} môn):");
            foreach (string mon in cacMonYeuThich)
            {
                Console.WriteLine($"  - {mon}");
            }

            // Thao tác với tập hợp
            HashSet<string> monKho = new HashSet<string> { "Toán", "Lý", "Tiếng Anh" };
            HashSet<string> monDe = new HashSet<string> { "Văn", "Sử", "Địa" };

            // Union (Hợp)
            var tatCaMon = new HashSet<string>(cacMonYeuThich);
            tatCaMon.UnionWith(monKho);
            tatCaMon.UnionWith(monDe);
            Console.WriteLine($"Tất cả môn học: {string.Join(", ", tatCaMon)}");

            // Intersection (Giao)
            var monChung = new HashSet<string>(cacMonYeuThich);
            monChung.IntersectWith(monKho);
            Console.WriteLine($"Môn chung: {string.Join(", ", monChung)}");

            Console.WriteLine($"Có chứa số 7 không? {soNguyenTo.Contains(7)}");
        }

        /// <summary>
        /// Demo về Queue và Stack
        /// </summary>
        static void DemoQueueAndStack()
        {
            Console.WriteLine("QUEUE (Hàng đợi - FIFO: First In, First Out):");
            Queue<string> hangDoi = new Queue<string>();

            // Enqueue - thêm vào cuối hàng đợi
            hangDoi.Enqueue("Khách hàng 1");
            hangDoi.Enqueue("Khách hàng 2");
            hangDoi.Enqueue("Khách hàng 3");

            Console.WriteLine($"Số người trong hàng đợi: {hangDoi.Count}");
            Console.WriteLine($"Người đầu hàng: {hangDoi.Peek()}"); // Xem không lấy ra

            // Dequeue - lấy ra từ đầu hàng đợi
            while (hangDoi.Count > 0)
            {
                string khach = hangDoi.Dequeue();
                Console.WriteLine($"  Đang phục vụ: {khach}");
            }

            Console.WriteLine("\nSTACK (Ngăn xếp - LIFO: Last In, First Out):");
            Stack<string> nganXep = new Stack<string>();

            // Push - thêm vào đỉnh ngăn xếp
            nganXep.Push("Tài liệu 1");
            nganXep.Push("Tài liệu 2");
            nganXep.Push("Tài liệu 3");

            Console.WriteLine($"Số tài liệu: {nganXep.Count}");
            Console.WriteLine($"Tài liệu trên cùng: {nganXep.Peek()}");

            // Pop - lấy ra từ đỉnh ngăn xếp
            while (nganXep.Count > 0)
            {
                string taiLieu = nganXep.Pop();
                Console.WriteLine($"  Lấy ra: {taiLieu}");
            }
        }

        /// <summary>
        /// Demo về LINQ cơ bản
        /// </summary>
        static void DemoLinq()
        {
            List<int> danhSachSo = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<string> danhSachTen = new List<string> 
            { 
                "An", "Bình", "Cường", "Dũng", "Em", "Phong", "Giang", "Hùng" 
            };

            Console.WriteLine("Dữ liệu gốc:");
            Console.WriteLine($"Số: {string.Join(", ", danhSachSo)}");
            Console.WriteLine($"Tên: {string.Join(", ", danhSachTen)}");

            // Where - Lọc dữ liệu
            var soChan = danhSachSo.Where(x => x % 2 == 0).ToList();
            var tenDai = danhSachTen.Where(x => x.Length > 3).ToList();
            
            Console.WriteLine($"\nSố chẵn: {string.Join(", ", soChan)}");
            Console.WriteLine($"Tên dài hơn 3 ký tự: {string.Join(", ", tenDai)}");

            // Select - Biến đổi dữ liệu
            var soBinhPhuong = danhSachSo.Select(x => x * x).ToList();
            var tenInHoa = danhSachTen.Select(x => x.ToUpper()).ToList();
            
            Console.WriteLine($"\nSố bình phương: {string.Join(", ", soBinhPhuong)}");
            Console.WriteLine($"Tên in hoa: {string.Join(", ", tenInHoa)}");

            // OrderBy - Sắp xếp
            var tenSapXep = danhSachTen.OrderBy(x => x).ToList();
            var soGiamDan = danhSachSo.OrderByDescending(x => x).Take(5).ToList();
            
            Console.WriteLine($"\nTên sắp xếp A-Z: {string.Join(", ", tenSapXep)}");
            Console.WriteLine($"5 số lớn nhất: {string.Join(", ", soGiamDan)}");

            // Aggregate functions
            Console.WriteLine($"\nThống kê:");
            Console.WriteLine($"Tổng: {danhSachSo.Sum()}");
            Console.WriteLine($"Trung bình: {danhSachSo.Average():F1}");
            Console.WriteLine($"Max: {danhSachSo.Max()}, Min: {danhSachSo.Min()}");
            Console.WriteLine($"Số lượng: {danhSachSo.Count()}");

            // GroupBy - Nhóm dữ liệu
            var nhomTheoDoDao = danhSachTen.GroupBy(x => x.Length);
            Console.WriteLine("\nNhóm theo độ dài tên:");
            foreach (var nhom in nhomTheoDoDao)
            {
                Console.WriteLine($"  Độ dài {nhom.Key}: {string.Join(", ", nhom)}");
            }
        }

        /// <summary>
        /// Ví dụ thực tế - Quản lý thư viện
        /// </summary>
        static void DemoQuanLyThuVien()
        {
            // Class đại diện cho sách
            var danhSachSach = new List<dynamic>
            {
                new { TenSach = "Lập trình C#", TacGia = "Nguyễn Văn A", NamXuatBan = 2020, TheLoai = "Công nghệ", GiaTien = 250000 },
                new { TenSach = "Toán cao cấp", TacGia = "Trần Thị B", NamXuatBan = 2019, TheLoai = "Toán học", GiaTien = 180000 },
                new { TenSach = "Vật lý đại cương", TacGia = "Lê Văn C", NamXuatBan = 2021, TheLoai = "Vật lý", GiaTien = 200000 },
                new { TenSach = "Cấu trúc dữ liệu", TacGia = "Phạm Văn D", NamXuatBan = 2022, TheLoai = "Công nghệ", GiaTien = 320000 },
                new { TenSach = "Python cơ bản", TacGia = "Hoàng Thị E", NamXuatBan = 2021, TheLoai = "Công nghệ", GiaTien = 280000 }
            };

            // Dictionary để đếm số lượng sách mượn
            Dictionary<string, int> thongKeMuon = new Dictionary<string, int>
            {
                {"Lập trình C#", 15},
                {"Toán cao cấp", 8},
                {"Vật lý đại cương", 12},
                {"Cấu trúc dữ liệu", 20},
                {"Python cơ bản", 18}
            };

            Console.WriteLine("🏛️  THÔNG TIN THƯ VIỆN:");
            Console.WriteLine($"Tổng số sách: {danhSachSach.Count}");

            Console.WriteLine("\n📚 DANH SÁCH SÁCH:");
            foreach (var sach in danhSachSach)
            {
                Console.WriteLine($"  • {sach.TenSach} - {sach.TacGia} ({sach.NamXuatBan})");
                Console.WriteLine($"    Thể loại: {sach.TheLoai} | Giá: {sach.GiaTien:N0} VNĐ");
            }

            Console.WriteLine("\n📈 THỐNG KÊ:");
            
            // Sách theo thể loại
            var theoTheLoai = danhSachSach.GroupBy(s => s.TheLoai);
            Console.WriteLine("Phân loại sách:");
            foreach (var nhom in theoTheLoai)
            {
                Console.WriteLine($"  {nhom.Key}: {nhom.Count()} cuốn");
            }

            // Sách mới nhất
            var sachMoiNhat = danhSachSach.Where(s => s.NamXuatBan >= 2021).ToList();
            Console.WriteLine($"\nSách xuất bản từ 2021: {sachMoiNhat.Count} cuốn");

            // Giá trung bình
            double giaTrungBinh = danhSachSach.Average(s => (double)s.GiaTien);
            Console.WriteLine($"Giá trung bình: {giaTrungBinh:N0} VNĐ");

            // Top sách được mượn nhiều nhất
            Console.WriteLine("\n🔥 TOP SÁCH ĐƯỢC MƯỢN NHIỀU NHẤT:");
            var topMuon = thongKeMuon.OrderByDescending(x => x.Value).Take(3);
            int thuTu = 1;
            foreach (var item in topMuon)
            {
                Console.WriteLine($"  {thuTu}. {item.Key}: {item.Value} lượt mượn");
                thuTu++;
            }

            // Tìm kiếm sách
            Console.WriteLine("\n🔍 TÌM KIẾM SÁCH CÔNG NGHỆ:");
            var sachCongNghe = danhSachSach.Where(s => s.TheLoai == "Công nghệ")
                                          .OrderBy(s => s.TenSach);
            foreach (var sach in sachCongNghe)
            {
                int luotMuon = thongKeMuon.ContainsKey(sach.TenSach) ? thongKeMuon[sach.TenSach] : 0;
                Console.WriteLine($"  📖 {sach.TenSach} ({luotMuon} lượt mượn)");
            }
        }
    }
}
