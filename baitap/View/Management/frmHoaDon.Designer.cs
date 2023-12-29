namespace baitap.View.Management
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            rjButton4 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtThoiGian = new Krypton.Toolkit.KryptonTextBox();
            txtDonGia = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            txtThanhTien = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            txtSoLuong = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            txtMaHoaDon = new Krypton.Toolkit.KryptonTextBox();
            txtThucUong = new Krypton.Toolkit.KryptonTextBox();
            txtTenKhachHang = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            saveFileDialog1 = new SaveFileDialog();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 43;
            label1.Text = "Hóa Đơn";
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(255, 224, 102);
            rjButton4.BackgroundColor = Color.FromArgb(255, 224, 102);
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 5;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton4.ForeColor = Color.White;
            rjButton4.Location = new Point(207, 240);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(91, 30);
            rjButton4.TabIndex = 39;
            rjButton4.Text = "Huỷ";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(13, 135, 242);
            rjButton3.BackgroundColor = Color.FromArgb(13, 135, 242);
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 5;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(110, 240);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(91, 30);
            rjButton3.TabIndex = 40;
            rjButton3.Text = "Xuất";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += btnExportToExcel_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(63, 194, 138);
            rjButton1.BackgroundColor = Color.FromArgb(63, 194, 138);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(13, 240);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(91, 30);
            rjButton1.TabIndex = 42;
            rjButton1.Text = "Thêm";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(693, 217);
            groupBox2.TabIndex = 38;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(666, 184);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtThoiGian);
            groupBox1.Controls.Add(txtDonGia);
            groupBox1.Controls.Add(kryptonLabel6);
            groupBox1.Controls.Add(kryptonLabel3);
            groupBox1.Controls.Add(txtThanhTien);
            groupBox1.Controls.Add(kryptonLabel5);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(kryptonLabel7);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Controls.Add(txtThucUong);
            groupBox1.Controls.Add(txtTenKhachHang);
            groupBox1.Controls.Add(kryptonLabel1);
            groupBox1.Controls.Add(kryptonLabel4);
            groupBox1.Controls.Add(kryptonLabel2);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(733, 197);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chỉnh sửa";
            // 
            // txtThoiGian
            // 
            txtThoiGian.Enabled = false;
            txtThoiGian.Location = new Point(96, 133);
            txtThoiGian.Name = "txtThoiGian";
            txtThoiGian.Size = new Size(226, 29);
            txtThoiGian.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtThoiGian.StateCommon.Border.Rounding = 5F;
            txtThoiGian.StateCommon.Border.Width = 2;
            txtThoiGian.TabIndex = 2;
            // 
            // txtDonGia
            // 
            txtDonGia.Enabled = false;
            txtDonGia.Location = new Point(96, 97);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(226, 29);
            txtDonGia.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDonGia.StateCommon.Border.Rounding = 5F;
            txtDonGia.StateCommon.Border.Width = 2;
            txtDonGia.TabIndex = 2;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(16, 137);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(61, 20);
            kryptonLabel6.TabIndex = 1;
            kryptonLabel6.Values.Text = "Thời gian";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(20, 101);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(53, 20);
            kryptonLabel3.TabIndex = 1;
            kryptonLabel3.Values.Text = "Đơn giá";
            // 
            // txtThanhTien
            // 
            txtThanhTien.Enabled = false;
            txtThanhTien.Location = new Point(456, 97);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(226, 29);
            txtThanhTien.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtThanhTien.StateCommon.Border.Rounding = 5F;
            txtThanhTien.StateCommon.Border.Width = 2;
            txtThanhTien.TabIndex = 2;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(366, 101);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(68, 20);
            kryptonLabel5.TabIndex = 1;
            kryptonLabel5.Values.Text = "Thành tiền";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Enabled = false;
            txtSoLuong.Location = new Point(456, 62);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(226, 29);
            txtSoLuong.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSoLuong.StateCommon.Border.Rounding = 5F;
            txtSoLuong.StateCommon.Border.Width = 2;
            txtSoLuong.TabIndex = 2;
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(370, 66);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(60, 20);
            kryptonLabel7.TabIndex = 1;
            kryptonLabel7.Values.Text = "Số lượng";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Enabled = false;
            txtMaHoaDon.Location = new Point(96, 27);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(226, 29);
            txtMaHoaDon.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtMaHoaDon.StateCommon.Border.Rounding = 5F;
            txtMaHoaDon.StateCommon.Border.Width = 2;
            txtMaHoaDon.TabIndex = 2;
            // 
            // txtThucUong
            // 
            txtThucUong.Enabled = false;
            txtThucUong.Location = new Point(96, 62);
            txtThucUong.Name = "txtThucUong";
            txtThucUong.Size = new Size(226, 29);
            txtThucUong.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtThucUong.StateCommon.Border.Rounding = 5F;
            txtThucUong.StateCommon.Border.Width = 2;
            txtThucUong.TabIndex = 2;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Enabled = false;
            txtTenKhachHang.Location = new Point(456, 27);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(226, 29);
            txtTenKhachHang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTenKhachHang.StateCommon.Border.Rounding = 5F;
            txtTenKhachHang.StateCommon.Border.Width = 2;
            txtTenKhachHang.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(6, 31);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(80, 20);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Mã Hóa Đơn";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(12, 66);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(69, 20);
            kryptonLabel4.TabIndex = 1;
            kryptonLabel4.Values.Text = "Thức uống";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(350, 31);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(100, 20);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Tên Khách Hàng";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 674);
            Controls.Add(label1);
            Controls.Add(rjButton4);
            Controls.Add(rjButton3);
            Controls.Add(rjButton1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHoaDon";
            Text = "frmBill";
            Load += frmHoaDon_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Krypton.Toolkit.KryptonTextBox txtDonGia;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtSoLuong;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtMaHoaDon;
        private Krypton.Toolkit.KryptonTextBox txtTenKhachHang;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtThoiGian;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox txtThanhTien;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtThucUong;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private SaveFileDialog saveFileDialog1;
    }
}