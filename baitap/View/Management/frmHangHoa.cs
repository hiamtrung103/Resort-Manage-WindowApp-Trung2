using baitap.Control;
using baitap.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitap.View
{
    public partial class frmHangHoa : Form
    {
        private string duongDanAnh = "";
        private HangHoaCtr hhCtr = new HangHoaCtr();
        public frmHangHoa()
        {
            InitializeComponent();
        }
        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hhCtr.LayDuLieuHangHoa();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaHangHoa.Text = row.Cells["ID"].Value.ToString();
                txtTenHangHoa.Text = row.Cells["TenHangHoa"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();

                byte[] imageData = row.Cells["Avatar"].Value as byte[];
                HienThiAnhDaiDien(imageData);
            }
        }
        private HanghoaObj LayHangHoaObjTuForm()
        {
            return new HanghoaObj
            {
                MaHangHoa = txtMaHangHoa.Text,
                TenHangHoa = txtTenHangHoa.Text,
                DonGia = Convert.ToInt32(txtDonGia.Text),
                SoLuong = Convert.ToInt32(txtSoLuong.Text),
            };
        }


        private void btnThem()
        {
            if (string.IsNullOrWhiteSpace(txtTenHangHoa.Text) || 
                string.IsNullOrWhiteSpace(txtDonGia.Text) || 
                string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            HanghoaObj hhObj = LayHangHoaObjTuForm();

            if (hhCtr.ThemDuLieuHangHoa(hhObj))
            {
                dataGridView1.DataSource = hhCtr.LayDuLieuHangHoa();
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại.");
            }
        }

        private void btnXoa()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maHangHoa = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá hàng hóa này?", "Xoá hàng hóa!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    hhCtr.XoaDuLieuHangHoa(maHangHoa);
                    MessageBox.Show("Xoá dữ liệu thành công.");
                    ClearTextBox();
                    dataGridView1.DataSource = hhCtr.LayDuLieuHangHoa();
                }
                else
                {
                    MessageBox.Show("Xoá dữ liệu thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xoá.");
            }
        }

        private void btnSua()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                if (!decimal.TryParse(txtDonGia.Text, out decimal donGia) || !int.TryParse(txtSoLuong.Text, out int soLuong))
                {
                    MessageBox.Show("Nhập giá trị hợp lệ cho Đơn giá và Số lượng.", "Lỗi");
                    return;
                }

                HanghoaObj hhObj = LayHangHoaObjTuForm();

                hhCtr.CapNhatDuLieuHangHoa(hhObj);
                dataGridView1.DataSource = hhCtr.LayDuLieuHangHoa();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void ClearTextBox()
        {
            txtTenHangHoa.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtMaHangHoa.Text = "";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string maHangHoa = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                byte[] avatar = ChuyenDoiHinhAnh(duongDanAnh);

                if (avatar != null)
                {
                    hhCtr.CapNhatAvatar(maHangHoa, avatar);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hình ảnh.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng hóa để cập nhật hình ảnh.", "Thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        public void nhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiNhapSo(e);
        }

        public void ChiNhapSo(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
