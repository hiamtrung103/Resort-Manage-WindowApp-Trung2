using baitap.Control;
using baitap.Model;
using baitap.Object;
using Krypton.Toolkit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmSettingKhachHang : KryptonForm
    {
        private string duongDanAnh = "";
        private ConnectToSQL conn = new ConnectToSQL();
        private KhachHangCtr khCtr = new KhachHangCtr();

        public frmSettingKhachHang()
        {
            InitializeComponent();
        }

        private void frmSettingKhachHang_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                string selectKhachHangSql = "SELECT * FROM KhachHang WHERE TenTaiKhoan=@tenTaiKhoan";
                using (SqlCommand selectKhachHangCmd = new SqlCommand(selectKhachHangSql, conn.KetNoi))
                {
                    conn.MoKetNoi();
                    selectKhachHangCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);

                    using (SqlDataAdapter khachHangDataAdapter = new SqlDataAdapter(selectKhachHangCmd))
                    {
                        DataTable khachHangDataTable = new DataTable();
                        khachHangDataAdapter.Fill(khachHangDataTable);

                        if (khachHangDataTable.Rows.Count > 0)
                        {
                            txtTenTaiKhoan.Texts = khachHangDataTable.Rows[0]["TenTaiKhoan"].ToString();
                            txtHoTen.Texts = khachHangDataTable.Rows[0]["HoTen"].ToString();
                            txtGioiTinh.Texts = khachHangDataTable.Rows[0]["GioiTinh"].ToString();
                            txtNamSinh.Texts = khachHangDataTable.Rows[0]["NamSinh"].ToString();
                            txtDiaChi.Texts = khachHangDataTable.Rows[0]["DiaChi"].ToString();
                            object avatarObject = khachHangDataTable.Rows[0]["Avatar"];

                            if (avatarObject != DBNull.Value && avatarObject != null)
                            {
                                byte[] hinhAnh = (byte[])avatarObject;
                                HienThiAnhDaiDien(hinhAnh);
                            }
                            else
                            {
                                pictureBox1.Image = null;
                            }
                        }
                    }
                }
            }
        }
        private void HienThiAnhDaiDien(object hinhAnhObject)
        {
            byte[] hinhAnh = hinhAnhObject as byte[];

            if (hinhAnh?.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(hinhAnh))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        }


        private void btnChonAnhDaiDien_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                duongDanAnh = openFileDialog1.FileName;
                HienThiAnhDaiDien(ChuyenDoiHinhAnh(duongDanAnh));
            }
        }

        private byte[] ChuyenDoiHinhAnh(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                return File.ReadAllBytes(imagePath);
            }
            return null;
        }

        public void CapNhatThongTinKhachHang(string hoTen, string gioiTinh, string namSinh, string diaChi)
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                hoTen = txtHoTen.Texts;
                gioiTinh = txtGioiTinh.Texts;
                namSinh = txtNamSinh.Texts;
                diaChi = txtDiaChi.Texts;

                khCtr.CapNhatDuLieuCaNhan(tenTaiKhoan, hoTen, gioiTinh, namSinh, diaChi);
            }
        }

        public void CapNhatAvatar(byte[] avatar)
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                khCtr.CapNhatAvatar(tenTaiKhoan, avatar);
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            byte[] avatar = ChuyenDoiHinhAnh(duongDanAnh);
            CapNhatThongTinKhachHang(txtHoTen.Texts, txtGioiTinh.Texts, txtNamSinh.Texts, txtDiaChi.Texts);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            byte[] avatar = ChuyenDoiHinhAnh(duongDanAnh);
            CapNhatAvatar(avatar);
        }
    }
}
