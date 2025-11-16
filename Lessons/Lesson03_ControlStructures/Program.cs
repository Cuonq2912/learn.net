/*
 * BÀI 3: CẤU TRÚC ĐIỀU KHIỂN (CONTROL STRUCTURES)
 * ==============================================
 * 
 * Trong bài này chúng ta sẽ học về:
 * 1. Câu lệnh điều kiện if/else
 * 2. Câu lệnh switch/case
 * 3. Vòng lặp for
 * 4. Vòng lặp while và do-while
 * 5. Vòng lặp foreach
 * 6. Break và continue
 */

using System;

namespace Lesson03_ControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BÀI 3: CẤU TRÚC ĐIỀU KHIỂN ===\n");

            // 1. CÂU LỆNH IF/ELSE
            Console.WriteLine("1. Câu lệnh If/Else:");
            
            int diem = 85;
            
            // If đơn giản
            if (diem >= 80)
            {
                Console.WriteLine($"Điểm {diem} - Học sinh xuất sắc!");
            }
            
            // If-else
            if (diem >= 90)
            {
                Console.WriteLine("Xếp loại: Xuất sắc");
            }
            else if (diem >= 80)
            {
                Console.WriteLine("Xếp loại: Giỏi");
            }
            else if (diem >= 65)
            {
                Console.WriteLine("Xếp loại: Khá");
            }
            else if (diem >= 50)
            {
                Console.WriteLine("Xếp loại: Trung bình");
            }
            else
            {
                Console.WriteLine("Xếp loại: Yếu");
            }

            // Toán tử ternary (if ngắn gọn)
            string ketQua = diem >= 50 ? "Đậu" : "Rớt";
            Console.WriteLine($"Kết quả: {ketQua}");

            // 2. CÂU LỆNH SWITCH/CASE
            Console.WriteLine("\n2. Câu lệnh Switch/Case:");
            
            int thu = 3; // Thứ 3
            string tenThu;
            
            switch (thu)
            {
                case 1:
                    tenThu = "Chủ nhật";
                    break;
                case 2:
                    tenThu = "Thứ hai";
                    break;
                case 3:
                    tenThu = "Thứ ba";
                    break;
                case 4:
                    tenThu = "Thứ tư";
                    break;
                case 5:
                    tenThu = "Thứ năm";
                    break;
                case 6:
                    tenThu = "Thứ sáu";
                    break;
                case 7:
                    tenThu = "Thứ bảy";
                    break;
                default:
                    tenThu = "Không xác định";
                    break;
            }
            
            Console.WriteLine($"Hôm nay là: {tenThu}");

            // Switch với nhiều case cùng kết quả
            char loaiNgay;
            switch (thu)
            {
                case 1:
                case 7:
                    loaiNgay = 'C'; // Cuối tuần
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    loaiNgay = 'T'; // Trong tuần
                    break;
                default:
                    loaiNgay = '?';
                    break;
            }
            
            Console.WriteLine($"Loại ngày: {(loaiNgay == 'C' ? "Cuối tuần" : "Trong tuần")}");

            // 3. VÒNG LẶP FOR
            Console.WriteLine("\n3. Vòng lặp For:");
            
            Console.WriteLine("Đếm từ 1 đến 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Số: {i}");
            }
            
            Console.WriteLine("\nBảng cửu chương 5:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"5 x {i} = {5 * i}");
            }
            
            Console.WriteLine("\nĐếm ngược từ 10 đến 1:");
            for (int i = 10; i >= 1; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("- Hết!");

            // 4. VÒNG LẶP WHILE
            Console.WriteLine("\n\n4. Vòng lặp While:");
            
            int soKiemTra = 1;
            Console.WriteLine("Số chẵn từ 2 đến 10:");
            while (soKiemTra <= 10)
            {
                if (soKiemTra % 2 == 0) // Kiểm tra số chẵn
                {
                    Console.Write($"{soKiemTra} ");
                }
                soKiemTra++;
            }
            Console.WriteLine();

            // 5. VÒNG LẶP DO-WHILE
            Console.WriteLine("\n5. Vòng lặp Do-While:");
            Console.WriteLine("(Chạy ít nhất 1 lần, kiểm tra điều kiện sau)");
            
            int dem = 1;
            do
            {
                Console.WriteLine($"Lần thực hiện thứ: {dem}");
                dem++;
            }
            while (dem <= 3);

            // 6. VÒNG LẶP FOREACH (với mảng)
            Console.WriteLine("\n6. Vòng lặp Foreach:");
            
            string[] monHoc = { "Toán", "Lý", "Hóa", "Sinh", "Văn" };
            
            Console.WriteLine("Danh sách môn học:");
            foreach (string mon in monHoc)
            {
                Console.WriteLine($"- {mon}");
            }

            // 7. BREAK VÀ CONTINUE
            Console.WriteLine("\n7. Break và Continue:");
            
            Console.WriteLine("Tìm số đầu tiên chia hết cho 7 trong khoảng 20-30:");
            for (int i = 20; i <= 30; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine($"Số tìm được: {i}");
                    break; // Thoát khỏi vòng lặp
                }
                Console.WriteLine($"Kiểm tra số {i} - không chia hết cho 7");
            }
            
            Console.WriteLine("\nIn các số từ 1-10, bỏ qua số 5 và 8:");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5 || i == 8)
                {
                    continue; // Bỏ qua lần lặp này, chuyển sang lần tiếp theo
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // 8. VÒNG LẶP LỒNG NHAU (NESTED LOOPS)
            Console.WriteLine("\n8. Vòng lặp lồng nhau:");
            Console.WriteLine("Bảng cửu chương từ 1 đến 3:");
            
            for (int bang = 1; bang <= 3; bang++)
            {
                Console.WriteLine($"\nBảng cửu chương {bang}:");
                for (int so = 1; so <= 5; so++)
                {
                    Console.WriteLine($"{bang} x {so} = {bang * so}");
                }
            }

            // 9. VÍ DỤ THỰC TẾ - MENU ỨNG DỤNG
            Console.WriteLine("\n9. Ví dụ thực tế - Menu ứng dụng:");
            
            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.WriteLine("\n=== MENU CHÍNH ===");
                Console.WriteLine("1. Tính tổng hai số");
                Console.WriteLine("2. Kiểm tra số chẵn/lẻ");
                Console.WriteLine("3. Thoát");
                Console.Write("Chọn chức năng (1-3): ");
                
                // Giả lập nhập liệu (trong thực tế sẽ dùng Console.ReadLine())
                int luaChon = 1; // Giả sử người dùng chọn 1
                
                switch (luaChon)
                {
                    case 1:
                        int a = 10, b = 20;
                        Console.WriteLine($"Tổng của {a} và {b} là: {a + b}");
                        break;
                    case 2:
                        int soCanKiemTra = 15;
                        string loaiSo = (soCanKiemTra % 2 == 0) ? "chẵn" : "lẻ";
                        Console.WriteLine($"Số {soCanKiemTra} là số {loaiSo}");
                        break;
                    case 3:
                        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!");
                        tiepTuc = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
                
                // Dừng vòng lặp cho demo
                tiepTuc = false;
            }

            Console.WriteLine("\n=== KẾT THÚC BÀI 3 ===");
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
