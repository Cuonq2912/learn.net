using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenTrongCuong_2023602667
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string PhongBan { get; set; }
        public DateTime NgaySinh { get; set; }
        public double HeSoLuong { get; set; }



        public int Tuoi
        {
            get
            {
                int age = DateTime.Now.Year - NgaySinh.Year;
                if (DateTime.Now.DayOfYear < NgaySinh.DayOfYear)
                {
                    age = age - 1;
                }
                return age;
            }
        }
    }
}

