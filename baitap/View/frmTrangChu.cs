using baitap.Control;
using baitap.Model;
using baitap.Object;
using baitap.View.Management;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmTrangChu : Form
    {
        private HangHoaMod hangHoaMod = new HangHoaMod();
        private HoaDonCtr hoadonCtr = new HoaDonCtr();
        private ConnectToSQL conn = new ConnectToSQL();

        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            TaiDuLieuVaCapNhatMauPanel();
            LoadHangHoa();
            LoadThongTinKhachHang();
        }
        private void ThemHoaDon()
        {
            HoadonObj newBill = new HoadonObj
            {
                TenKhachHang = txtHoTen.Text,
                ThucUong = cbHangHoa.Text,
                SoLuong = Convert.ToInt32(txtSoLuong.Text),
                DonGia = Convert.ToInt32(txtDonGia.Text),
                ThanhTien = Convert.ToInt32(txtThanhTien.Text),
                ThoiGian = DateTime.Now
            };

            if (hoadonCtr.ThemDuLieuHoaDon(newBill))
            {
                MessageBox.Show("Thêm hóa đơn thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHangHoa()
        {
            string query = "SELECT TenHangHoa FROM HangHoa";
            using (SqlCommand command = new SqlCommand(query, conn.KetNoi))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tenHangHoa = reader.GetString(0);
                        cbHangHoa.Items.Add(tenHangHoa);
                    }
                }
            }
        }

        private void LoadThongTinKhachHang()
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
                            HienThiThongTinKhachHang(khachHangDataTable);
                        }
                    }
                }
            }
        }

        private void HienThiThongTinKhachHang(DataTable khachHangDataTable)
        {
            txtHoTen.Text = khachHangDataTable.Rows[0]["HoTen"].ToString();

            object avatarObject = khachHangDataTable.Rows[0]["Avatar"];

            if (avatarObject != DBNull.Value && avatarObject != null)
            {
                byte[] hinhAnh = (byte[])avatarObject;
                HienThiAnhDaiDienKhachHang(hinhAnh);
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        private void HienThiAnhDaiDienKhachHang(byte[] hinhAnh)
        {
            if (hinhAnh != null)
            {
                using (MemoryStream ms = new MemoryStream(hinhAnh))
                {
                    pictureBox2.Image = Image.FromStream(ms);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        private void HienThiAnhDaiDienHangHoa(byte[] hinhAnh)
        {
            if (hinhAnh != null)
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

        private void cbHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHangHoa = cbHangHoa.SelectedItem.ToString();

            HanghoaObj hhObj = hangHoaMod.LayThongTinHangHoa(selectedHangHoa);

            txtDonGia.Text = hhObj.DonGia.ToString();

            if (hhObj.Avatar != null)
            {
                HienThiAnhDaiDienHangHoa(hhObj.Avatar);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private void CapNhatMauPanel(string maBan)
        {
            for (int i = 1; i <= 16; i++)
            {
                Panel panel = this.Controls.Find("panel" + i, true).FirstOrDefault() as Panel;

                if (panel != null)
                {
                    string query = "SELECT TrangThai FROM Ban WHERE MaBan = @MaBan";
                    using (SqlCommand cmd = new SqlCommand(query, conn.KetNoi))
                    {
                        conn.MoKetNoi();
                        cmd.Parameters.AddWithValue("@MaBan", "P" + i);
                        object trangThaiObj = cmd.ExecuteScalar();

                        if (trangThaiObj != null && trangThaiObj != DBNull.Value)
                        {
                            DatMauChoPanel(panel, trangThaiObj.ToString());
                        }
                    }
                }
            }
        }

        private void DatMauChoPanel(Panel panel, string trangThai)
        {
            switch (trangThai)
            {
                case "Đang có khách":
                    panel.BackColor = Color.Red;
                    break;
                case "Đang dọn dẹp":
                    panel.BackColor = Color.LightBlue;
                    break;
                default:
                    panel.BackColor = Color.LightGreen;
                    break;
            }
        }

        private void TaiDuLieuVaCapNhatMauPanel()
        {
            for (int i = 1; i <= 16; i++)
            {
                Panel panel = this.Controls.Find("panel" + i, true).FirstOrDefault() as Panel;

                if (panel != null)
                {
                    string maBan = "P" + i;
                    CapNhatMauPanel(maBan);
                }
            }
        }

        private void CapNhatThanhTien()
        {
            if (decimal.TryParse(txtDonGia.Text, out decimal donGia) && int.TryParse(txtSoLuong.Text, out int soLuong))
            {
                decimal thanhTien = donGia * soLuong;
                txtThanhTien.Text = thanhTien.ToString();
            }
            else
            {
                txtThanhTien.Text = string.Empty;
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            CapNhatThanhTien();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            ThemHoaDon();
        }
    }
}
