using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap.Object
{
    public class BanObj
    {
        public string MaBan {  get; set; }
        public string TenBan { get; set; }
        public string Lau { get; set; }
        public decimal Gia { get; set; }
        public string TrangThai { get; set; }

        public BanObj() { }

        public BanObj(string maBan, string tenBan, string lau, decimal gia, string trangThai)
        {
            MaBan = maBan;
            TenBan = tenBan;
            Lau = lau;
            Gia = gia;
            TrangThai = trangThai;
        }
    }
}
