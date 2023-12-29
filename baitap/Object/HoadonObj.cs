using System;

namespace baitap.Object
{
    public class HoadonObj
    {
        public int ID { get; set; }
        public string TenKhachHang { get; set; }
        public string ThucUong { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }
        public DateTime ThoiGian { get; set; }

        public HoadonObj() { }

        public HoadonObj(string tenKhachHang, string thucUong, int soLuong, int donGia, int thanhTien, DateTime thoiGian)
        {
            TenKhachHang = tenKhachHang;
            ThucUong = thucUong;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
            ThoiGian = thoiGian;
        }
    }
}