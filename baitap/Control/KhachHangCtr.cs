using baitap.Model;
using baitap.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap.Control
{
    class KhachHangCtr
    {
        class KhachHangControl
        {
            private KhachHangMod khMod = new KhachHangMod();

            public DataTable LayDuLieuKhachHang()
            {
                return khMod.LayDuLieuKhachHang();
            }

            public bool ThemDuLieuKhachHang(string hoTen, string gioiTinh, string namSinh, string diaChi, string dienThoai, string tenTaiKhoan, string email, string password)
            {
                if (kiemTraTonTai(tenTaiKhoan, email))
                {
                    MessageBox.Show("Tên tài khoản hoặc Email đã tồn tại.");
                    return false;
                }

                KhachHangObj khObj = new KhachHangObj
                {
                    HoTen = hoTen,
                    GioiTinh = gioiTinh,
                    NamSinh = namSinh,
                    DiaChi = diaChi,
                    DienThoai = dienThoai,
                    TenTaiKhoan = tenTaiKhoan,
                    Email = email,
                    Password = password
                };

                return khMod.ThemDuLieuKhachHang(khObj);
            }

            public void CapNhatDuLieuKhachHang(string maKhachHang, string hoTen, string gioiTinh, string namSinh, string diaChi, string dienThoai, string tenTaiKhoan, string email, string password)
            {
                KhachHangObj khObj = new KhachHangObj
                {
                    MaKhachHang = maKhachHang,
                    HoTen = hoTen,
                    GioiTinh = gioiTinh,
                    NamSinh = namSinh,
                    DiaChi = diaChi,
                    DienThoai = dienThoai,
                    TenTaiKhoan = tenTaiKhoan,
                    Email = email,
                    Password = password
                };

                khMod.CapNhatDuLieuKhachHang(khObj);
            }

            public bool XoaDuLieuKhachHang(string maKhachHang)
            {
                return khMod.XoaDuLieuKhachHang(maKhachHang);
            }

            private bool kiemTraTonTai(string tenTaiKhoan, string email)
            {
                DataTable dt = khMod.LayDuLieuKhachHang();

                foreach (DataRow row in dt.Rows)
                {
                    if (row["ten_tai_khoan"].ToString() == tenTaiKhoan || row["email"].ToString() == email)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}
