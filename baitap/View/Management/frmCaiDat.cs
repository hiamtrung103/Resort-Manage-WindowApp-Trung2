using baitap.Control;
using baitap.Model;
using baitap.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap.View.Management
{
    public partial class frmCaiDat : Form
    {
        private string duongDanAnh = "";
        private NhanVienCtr nvCtr = new NhanVienCtr();
        ConnectToSQL conn = new ConnectToSQL();
        public frmCaiDat()
        {
            InitializeComponent();
        }
        private void frmCaiDat_Load(object sender, EventArgs e)
        {
            HienThiThongTinNhanVien();
        }

        private void HienThiThongTinNhanVien()
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                string selectNhanVienSql = "SELECT * FROM NhanVien WHERE TenTaiKhoan=@tenTaiKhoan";
                using (SqlCommand selectNhanVienCmd = new SqlCommand(selectNhanVienSql, conn.KetNoi))
                {
                    conn.MoKetNoi();
                    selectNhanVienCmd.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);
                    using (SqlDataAdapter nhanVienDataAdapter = new SqlDataAdapter(selectNhanVienCmd))
                    {
                        DataTable nhanVienDataTable = new DataTable();
                        nhanVienDataAdapter.Fill(nhanVienDataTable);

                        if (nhanVienDataTable.Rows.Count > 0)
                        {
                            txtTenTaiKhoan.Text = nhanVienDataTable.Rows[0]["TenTaiKhoan"].ToString();
                            txtHoTen.Text = nhanVienDataTable.Rows[0]["HoTen"].ToString();
                            txtGioiTinh.Text = nhanVienDataTable.Rows[0]["GioiTinh"].ToString();
                            txtNamSinh.Text = nhanVienDataTable.Rows[0]["NamSinh"].ToString();
                            txtDiaChi.Text = nhanVienDataTable.Rows[0]["DiaChi"].ToString();
                            txtDienThoai.Text = nhanVienDataTable.Rows[0]["DienThoai"].ToString();
                            txtEmail.Text = nhanVienDataTable.Rows[0]["Email"].ToString();
                            txtQuyenHan.Text = nhanVienDataTable.Rows[0]["QuyenHan"].ToString();
                            object avatarObject = nhanVienDataTable.Rows[0]["Avatar"];

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

        public void HienThiAnhDaiDien(byte[] hinhAnh)
        {
            if (hinhAnh != null && hinhAnh.Length > 0)
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

        public void CapNhatAvatar(byte[] avatar)
        {
            if (!string.IsNullOrEmpty(Session.TenTaiKhoan))
            {
                string tenTaiKhoan = Session.TenTaiKhoan;

                nvCtr.CapNhatAvatar(tenTaiKhoan, avatar);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            byte[] avatar = ChuyenDoiHinhAnh(duongDanAnh);
            CapNhatAvatar(avatar);
        }
    }
}
