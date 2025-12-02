using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NguyenTrongCuong_2023602667
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<NhanVien> DanhSachNV { get; set; } = new ObservableCollection<NhanVien>();

        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = DanhSachNV;
        }

        private void Nhap_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Mã nhân viên và Họ tên không được để trống!");
                return;
            }

            if (dateNgaySinh.SelectedDate == null)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh!");
                return;
            }

            DateTime ngaySinhCheck = dateNgaySinh.SelectedDate.Value;
            if(ngaySinhCheck > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }
            int tuoi = DateTime.Now.Year - ngaySinhCheck.Year;

            if (DateTime.Now.DayOfYear < ngaySinhCheck.DayOfYear)
                tuoi--;

            //if (tuoi < 18)
            //{
            //    MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!");
            //    return;
            //}

            if (choosePhongBan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phòng ban!");
                return;
            }
            // Hệ số lương phải là số nguyên và lớn hơn 0
            if (!int.TryParse(txtHeSoLuong.Text, out int heSoLuong) || heSoLuong <= 0)
            {
                MessageBox.Show("Hệ số lương phải là số nguyên và lớn hơn 0!");
                return;
            }

            //if (!double.TryParse(txtHeSoLuong.Text, out double heSoLuong) || heSoLuong <= 0)
            //{
            //    MessageBox.Show("Hệ số lương không hợp lệ! (Phải là số thực > 0)");
            //    return;
            //}

            string maNV = txtMaNV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = ngaySinhCheck;
            string gioiTinh = (chooseNam.IsChecked == true) ? "Nam" : "Nữ";
            string phongBan = (choosePhongBan.SelectedItem as ComboBoxItem).Content.ToString();

            NhanVien nvMoi = new NhanVien
            {
                MaNV = maNV,
                HoTen = hoTen,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                PhongBan = phongBan,
                HeSoLuong = heSoLuong
            };

            DanhSachNV.Add(nvMoi);

            txtMaNV.Clear();
            txtHoTen.Clear();
            txtHeSoLuong.Clear();
            dateNgaySinh.SelectedDate = null;
            choosePhongBan.SelectedIndex = -1;
            chooseNam.IsChecked = true;
        }


        private void Window2_Click(object sender, RoutedEventArgs e)
        {
            if (DanhSachNV.Count == 0)
            {
                MessageBox.Show("Danh sách nhân viên đang trống!");
                return;
            }

            int maxTuoi = DanhSachNV.Max(nv => nv.Tuoi);


            List<NhanVien> dsTuoiCaoNhat = DanhSachNV.Where(nv => nv.Tuoi == maxTuoi).ToList();

            Window2 win2 = new Window2(dsTuoiCaoNhat);
            win2.Show();
        }
    }
}