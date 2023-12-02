using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap.Object
{
    public class KhachHangObj
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string TenTaiKhoan { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MaKhachHang { get; set; }
        public string MaGiamGia { get; set; }

        public KhachHangObj() { }

        public KhachHangObj(string hoTen, string gioiTinh, string namSinh, string diaChi, string dienThoai, string tenTaiKhoan, string email, string password, string maKhachHang, string maGiamGia)
        {
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NamSinh = namSinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
            TenTaiKhoan = tenTaiKhoan;
            Email = email;
            Password = password;
            MaKhachHang = maKhachHang;
            MaGiamGia = maGiamGia;
        }
    }
}
