using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NguyenTrongCuong_2023602667
{
    public partial class Window2 : Window
    {

        public Window2(List<NhanVien> ds)
        {
            InitializeComponent();
            dataGridMax.ItemsSource = ds;
        }

    }
}
