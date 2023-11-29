namespace baitap.Object
{
    public class NhanvienObj
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string GioiTinh { get; set; }
        public string NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string TenTaiKhoan { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public string QuyenHan {  get; set; }

        public NhanvienObj() { }

        public NhanvienObj(string ma, string ten, string gioitinh, string namsinh, string diachi, string sdt, string matkhau, string quyenHan, string tenTaiKhoan, string email)
        {
            MaNhanVien = ma;
            TenNhanVien = ten;
            GioiTinh = gioitinh;
            NamSinh = namsinh;
            DiaChi = diachi;
            DienThoai = sdt;
            MatKhau = matkhau;
            QuyenHan = quyenHan;
            TenTaiKhoan = tenTaiKhoan;
            Email = email;  
        }
    }
}
