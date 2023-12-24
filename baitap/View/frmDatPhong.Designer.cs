namespace baitap.View
{
    partial class frmDatPhong
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
            label1 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            kryptonDateTimePicker1 = new Krypton.Toolkit.KryptonDateTimePicker();
            ComboBox_SoNguoi = new Krypton.Toolkit.KryptonComboBox();
            ComboBox_DiaDiem = new Krypton.Toolkit.KryptonComboBox();
            label3 = new Label();
            txtDiaDiem = new Krypton.Toolkit.KryptonTextBox();
            kryptonDateTimePicker2 = new Krypton.Toolkit.KryptonDateTimePicker();
            txtTenDiaDiem = new GroupBox();
            label8 = new Label();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            label7 = new Label();
            txtSoNguoi = new Krypton.Toolkit.KryptonTextBox();
            label5 = new Label();
            txtNgayDi = new Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            txtNgayDen = new Krypton.Toolkit.KryptonTextBox();
            txtHoTen = new Krypton.Toolkit.KryptonTextBox();
            label9 = new Label();
            txtNamSinh = new Krypton.Toolkit.KryptonTextBox();
            label11 = new Label();
            txtMaGiamGia = new Krypton.Toolkit.KryptonTextBox();
            label13 = new Label();
            txtDiaChi = new Krypton.Toolkit.KryptonTextBox();
            label14 = new Label();
            txtGioiTinh = new Krypton.Toolkit.KryptonTextBox();
            label10 = new Label();
            txtDienThoai = new Krypton.Toolkit.KryptonTextBox();
            label12 = new Label();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            label15 = new Label();
            groupBox1 = new GroupBox();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            lbMieuTa = new Label();
            lbGioiThieu = new Label();
            lbTenResort = new Label();
            rjButton1 = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ComboBox_SoNguoi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ComboBox_DiaDiem).BeginInit();
            txtTenDiaDiem.SuspendLayout();
            groupBox1.SuspendLayout();
            bunifuCards1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 0;
            label1.Text = "Booking";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 71);
            label6.Name = "label6";
            label6.Size = new Size(360, 90);
            label6.TabIndex = 1;
            label6.Text = "Tìm chỗ nghỉ tiếp theo\r\n\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 149);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1534, 220);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 118);
            label2.Name = "label2";
            label2.Size = new Size(793, 32);
            label2.TabIndex = 1;
            label2.Text = "Tìm ưu đãi khách sạn, resort, chỗ nghỉ dạng nhà và nhiều hơn nữa...\r\n";
            // 
            // kryptonDateTimePicker1
            // 
            kryptonDateTimePicker1.CustomFormat = "dddd, dd MMMM, yyyy";
            kryptonDateTimePicker1.Format = DateTimePickerFormat.Custom;
            kryptonDateTimePicker1.Location = new Point(500, 198);
            kryptonDateTimePicker1.Name = "kryptonDateTimePicker1";
            kryptonDateTimePicker1.Size = new Size(304, 35);
            kryptonDateTimePicker1.StateCommon.Border.Color1 = Color.FromArgb(255, 183, 0);
            kryptonDateTimePicker1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonDateTimePicker1.StateCommon.Border.Rounding = 2F;
            kryptonDateTimePicker1.StateCommon.Border.Width = 4;
            kryptonDateTimePicker1.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonDateTimePicker1.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonDateTimePicker1.TabIndex = 4;
            kryptonDateTimePicker1.ValueChanged += datetimepicker_NgayDen_ValueChanged;
            // 
            // ComboBox_SoNguoi
            // 
            ComboBox_SoNguoi.DropDownWidth = 236;
            ComboBox_SoNguoi.IntegralHeight = false;
            ComboBox_SoNguoi.Items.AddRange(new object[] { "1 Người", "2 Người", "3 Người", "4 Người", "5 Người" });
            ComboBox_SoNguoi.Location = new Point(1108, 198);
            ComboBox_SoNguoi.Name = "ComboBox_SoNguoi";
            ComboBox_SoNguoi.Size = new Size(246, 35);
            ComboBox_SoNguoi.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(255, 183, 0);
            ComboBox_SoNguoi.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(255, 183, 0);
            ComboBox_SoNguoi.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ComboBox_SoNguoi.StateCommon.ComboBox.Border.Rounding = 2F;
            ComboBox_SoNguoi.StateCommon.ComboBox.Border.Width = 4;
            ComboBox_SoNguoi.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_SoNguoi.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ComboBox_SoNguoi.TabIndex = 5;
            ComboBox_SoNguoi.SelectedIndexChanged += ComboBox_SoNguoi_SelectedIndexChanged;
            // 
            // ComboBox_DiaDiem
            // 
            ComboBox_DiaDiem.DropDownWidth = 236;
            ComboBox_DiaDiem.IntegralHeight = false;
            ComboBox_DiaDiem.Items.AddRange(new object[] { "Resort The Nam Hai - Hội An", "Victoria Hoi An Beach - Hội An", "Resort Six Senses Ninh Van Bay - Khánh Hòa", "Resort L'Alyana Ninh Vân Bay - Khánh Hòa", "Resort Amanoi - Ninh Thuận", "Resort Princess D'AnNam - Bình Thuận", "Resort Six Senses Côn Đảo - Bà Rịa - Vũng Tàu", "Resort Flamingo Đại Lải - Vĩnh Phúc", "Resort Banyan Tree Lang Co Resort - Huế", "InterContinental Phú Quốc Long Beach - Phú Quốc" });
            ComboBox_DiaDiem.Location = new Point(148, 198);
            ComboBox_DiaDiem.Name = "ComboBox_DiaDiem";
            ComboBox_DiaDiem.Size = new Size(352, 35);
            ComboBox_DiaDiem.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(255, 183, 0);
            ComboBox_DiaDiem.StateCommon.ComboBox.Border.Color2 = Color.FromArgb(255, 183, 0);
            ComboBox_DiaDiem.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ComboBox_DiaDiem.StateCommon.ComboBox.Border.Rounding = 2F;
            ComboBox_DiaDiem.StateCommon.ComboBox.Border.Width = 4;
            ComboBox_DiaDiem.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox_DiaDiem.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ComboBox_DiaDiem.TabIndex = 5;
            ComboBox_DiaDiem.SelectedIndexChanged += ComboBox_DiaDiem_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 19);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 8;
            label3.Text = "Tên Resort";
            // 
            // txtDiaDiem
            // 
            txtDiaDiem.Enabled = false;
            txtDiaDiem.Location = new Point(22, 43);
            txtDiaDiem.Name = "txtDiaDiem";
            txtDiaDiem.Size = new Size(338, 33);
            txtDiaDiem.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDiaDiem.StateCommon.Border.Rounding = 2F;
            txtDiaDiem.StateCommon.Border.Width = 2;
            txtDiaDiem.StateCommon.Content.Color1 = Color.Black;
            txtDiaDiem.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaDiem.TabIndex = 9;
            // 
            // kryptonDateTimePicker2
            // 
            kryptonDateTimePicker2.CustomFormat = "dddd, dd MMMM, yyyy";
            kryptonDateTimePicker2.Format = DateTimePickerFormat.Custom;
            kryptonDateTimePicker2.Location = new Point(804, 198);
            kryptonDateTimePicker2.Name = "kryptonDateTimePicker2";
            kryptonDateTimePicker2.Size = new Size(304, 35);
            kryptonDateTimePicker2.StateCommon.Border.Color1 = Color.FromArgb(255, 183, 0);
            kryptonDateTimePicker2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonDateTimePicker2.StateCommon.Border.Rounding = 2F;
            kryptonDateTimePicker2.StateCommon.Border.Width = 4;
            kryptonDateTimePicker2.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonDateTimePicker2.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonDateTimePicker2.TabIndex = 4;
            kryptonDateTimePicker2.ValueChanged += datetimepicker_NgayDi_ValueChanged;
            // 
            // txtTenDiaDiem
            // 
            txtTenDiaDiem.Controls.Add(label8);
            txtTenDiaDiem.Controls.Add(kryptonTextBox1);
            txtTenDiaDiem.Controls.Add(label7);
            txtTenDiaDiem.Controls.Add(txtSoNguoi);
            txtTenDiaDiem.Controls.Add(label5);
            txtTenDiaDiem.Controls.Add(txtNgayDi);
            txtTenDiaDiem.Controls.Add(label4);
            txtTenDiaDiem.Controls.Add(txtNgayDen);
            txtTenDiaDiem.Controls.Add(label3);
            txtTenDiaDiem.Controls.Add(txtDiaDiem);
            txtTenDiaDiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenDiaDiem.Location = new Point(12, 261);
            txtTenDiaDiem.Name = "txtTenDiaDiem";
            txtTenDiaDiem.Size = new Size(738, 176);
            txtTenDiaDiem.TabIndex = 10;
            txtTenDiaDiem.TabStop = false;
            txtTenDiaDiem.Text = "Booking";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(200, 79);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 8;
            label8.Text = "Địa chỉ";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Enabled = false;
            kryptonTextBox1.Location = new Point(200, 103);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(160, 33);
            kryptonTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.Rounding = 2F;
            kryptonTextBox1.StateCommon.Border.Width = 2;
            kryptonTextBox1.StateCommon.Content.Color1 = Color.Black;
            kryptonTextBox1.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonTextBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 79);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 8;
            label7.Text = "Số người";
            // 
            // txtSoNguoi
            // 
            txtSoNguoi.Enabled = false;
            txtSoNguoi.Location = new Point(22, 103);
            txtSoNguoi.Name = "txtSoNguoi";
            txtSoNguoi.Size = new Size(156, 33);
            txtSoNguoi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtSoNguoi.StateCommon.Border.Rounding = 2F;
            txtSoNguoi.StateCommon.Border.Width = 2;
            txtSoNguoi.StateCommon.Content.Color1 = Color.Black;
            txtSoNguoi.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoNguoi.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(402, 79);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 8;
            label5.Text = "Ngày đi";
            // 
            // txtNgayDi
            // 
            txtNgayDi.Enabled = false;
            txtNgayDi.Location = new Point(402, 103);
            txtNgayDi.Name = "txtNgayDi";
            txtNgayDi.Size = new Size(324, 33);
            txtNgayDi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNgayDi.StateCommon.Border.Rounding = 2F;
            txtNgayDi.StateCommon.Border.Width = 2;
            txtNgayDi.StateCommon.Content.Color1 = Color.Black;
            txtNgayDi.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgayDi.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(402, 19);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 8;
            label4.Text = "Ngày đến";
            // 
            // txtNgayDen
            // 
            txtNgayDen.Enabled = false;
            txtNgayDen.Location = new Point(402, 43);
            txtNgayDen.Name = "txtNgayDen";
            txtNgayDen.Size = new Size(326, 33);
            txtNgayDen.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNgayDen.StateCommon.Border.Rounding = 2F;
            txtNgayDen.StateCommon.Border.Width = 2;
            txtNgayDen.StateCommon.Content.Color1 = Color.Black;
            txtNgayDen.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgayDen.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Enabled = false;
            txtHoTen.Location = new Point(6, 43);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(366, 33);
            txtHoTen.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtHoTen.StateCommon.Border.Rounding = 2F;
            txtHoTen.StateCommon.Border.Width = 2;
            txtHoTen.StateCommon.Content.Color1 = Color.Black;
            txtHoTen.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(56, 21);
            label9.TabIndex = 8;
            label9.Text = "Họ tên";
            // 
            // txtNamSinh
            // 
            txtNamSinh.Enabled = false;
            txtNamSinh.Location = new Point(6, 103);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(172, 33);
            txtNamSinh.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNamSinh.StateCommon.Border.Rounding = 2F;
            txtNamSinh.StateCommon.Border.Width = 2;
            txtNamSinh.StateCommon.Content.Color1 = Color.Black;
            txtNamSinh.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamSinh.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 79);
            label11.Name = "label11";
            label11.Size = new Size(77, 21);
            label11.TabIndex = 8;
            label11.Text = "Năm sinh";
            // 
            // txtMaGiamGia
            // 
            txtMaGiamGia.Enabled = false;
            txtMaGiamGia.Location = new Point(402, 163);
            txtMaGiamGia.Name = "txtMaGiamGia";
            txtMaGiamGia.Size = new Size(326, 33);
            txtMaGiamGia.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtMaGiamGia.StateCommon.Border.Rounding = 2F;
            txtMaGiamGia.StateCommon.Border.Width = 2;
            txtMaGiamGia.StateCommon.Content.Color1 = Color.Black;
            txtMaGiamGia.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaGiamGia.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(404, 139);
            label13.Name = "label13";
            label13.Size = new Size(96, 21);
            label13.TabIndex = 8;
            label13.Text = "Mã giảm giá";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Enabled = false;
            txtDiaChi.Location = new Point(6, 163);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(366, 33);
            txtDiaChi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDiaChi.StateCommon.Border.Rounding = 2F;
            txtDiaChi.StateCommon.Border.Width = 2;
            txtDiaChi.StateCommon.Content.Color1 = Color.Black;
            txtDiaChi.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(6, 139);
            label14.Name = "label14";
            label14.Size = new Size(57, 21);
            label14.TabIndex = 8;
            label14.Text = "Địa chỉ";
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Enabled = false;
            txtGioiTinh.Location = new Point(200, 103);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(172, 33);
            txtGioiTinh.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtGioiTinh.StateCommon.Border.Rounding = 2F;
            txtGioiTinh.StateCommon.Border.Width = 2;
            txtGioiTinh.StateCommon.Content.Color1 = Color.Black;
            txtGioiTinh.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGioiTinh.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(200, 79);
            label10.Name = "label10";
            label10.Size = new Size(70, 21);
            label10.TabIndex = 8;
            label10.Text = "Giới tính";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Enabled = false;
            txtDienThoai.Location = new Point(404, 103);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(322, 33);
            txtDienThoai.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDienThoai.StateCommon.Border.Rounding = 2F;
            txtDienThoai.StateCommon.Border.Width = 2;
            txtDienThoai.StateCommon.Content.Color1 = Color.Black;
            txtDienThoai.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDienThoai.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(404, 79);
            label12.Name = "label12";
            label12.Size = new Size(81, 21);
            label12.TabIndex = 8;
            label12.Text = "Điện thoại";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(404, 43);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(322, 33);
            txtEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEmail.StateCommon.Border.Rounding = 2F;
            txtEmail.StateCommon.Border.Width = 2;
            txtEmail.StateCommon.Content.Color1 = Color.Black;
            txtEmail.StateCommon.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(408, 19);
            label15.Name = "label15";
            label15.Size = new Size(48, 21);
            label15.TabIndex = 8;
            label15.Text = "Email";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtNamSinh);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(txtMaGiamGia);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 443);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 217);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.White;
            bunifuCards1.BorderRadius = 20;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Transparent;
            bunifuCards1.Controls.Add(lbMieuTa);
            bunifuCards1.Controls.Add(lbGioiThieu);
            bunifuCards1.Controls.Add(lbTenResort);
            bunifuCards1.IndicatorColor = Color.Transparent;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(778, 263);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(731, 397);
            bunifuCards1.TabIndex = 12;
            // 
            // lbMieuTa
            // 
            lbMieuTa.AutoSize = true;
            lbMieuTa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbMieuTa.Location = new Point(15, 77);
            lbMieuTa.Name = "lbMieuTa";
            lbMieuTa.Size = new Size(31, 17);
            lbMieuTa.TabIndex = 1;
            lbMieuTa.Text = "ABC";
            // 
            // lbGioiThieu
            // 
            lbGioiThieu.AutoSize = true;
            lbGioiThieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbGioiThieu.Location = new Point(15, 41);
            lbGioiThieu.Name = "lbGioiThieu";
            lbGioiThieu.Size = new Size(39, 21);
            lbGioiThieu.TabIndex = 1;
            lbGioiThieu.Text = "ABC";
            // 
            // lbTenResort
            // 
            lbTenResort.AutoSize = true;
            lbTenResort.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbTenResort.Location = new Point(15, 13);
            lbTenResort.Name = "lbTenResort";
            lbTenResort.Size = new Size(112, 25);
            lbTenResort.TabIndex = 1;
            lbTenResort.Text = "Resort ABC";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(1359, 196);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(100, 40);
            rjButton1.TabIndex = 13;
            rjButton1.Text = "Đặt phòng";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // frmDatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1534, 690);
            Controls.Add(rjButton1);
            Controls.Add(bunifuCards1);
            Controls.Add(groupBox1);
            Controls.Add(txtTenDiaDiem);
            Controls.Add(kryptonDateTimePicker2);
            Controls.Add(ComboBox_DiaDiem);
            Controls.Add(ComboBox_SoNguoi);
            Controls.Add(kryptonDateTimePicker1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDatPhong";
            Text = "frmDieuKhien";
            Load += frmDieuKhien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ComboBox_SoNguoi).EndInit();
            ((System.ComponentModel.ISupportInitialize)ComboBox_DiaDiem).EndInit();
            txtTenDiaDiem.ResumeLayout(false);
            txtTenDiaDiem.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            bunifuCards1.ResumeLayout(false);
            bunifuCards1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label6;
        private Panel panel1;
        private Label label2;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker1;
        private Krypton.Toolkit.KryptonComboBox ComboBox_SoNguoi;
        private Krypton.Toolkit.KryptonComboBox ComboBox_DiaDiem;
        private Label label3;
        private Krypton.Toolkit.KryptonTextBox txtDiaDiem;
        private Krypton.Toolkit.KryptonDateTimePicker kryptonDateTimePicker2;
        private GroupBox txtTenDiaDiem;
        private Label label7;
        private Krypton.Toolkit.KryptonTextBox txtSoNguoi;
        private Label label5;
        private Krypton.Toolkit.KryptonTextBox txtNgayDi;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox txtNgayDen;
        private Krypton.Toolkit.KryptonTextBox txtHoTen;
        private Label label9;
        private Krypton.Toolkit.KryptonTextBox txtNamSinh;
        private Label label11;
        private Krypton.Toolkit.KryptonTextBox txtMaGiamGia;
        private Label label13;
        private Krypton.Toolkit.KryptonTextBox txtDiaChi;
        private Label label14;
        private Krypton.Toolkit.KryptonTextBox txtGioiTinh;
        private Label label10;
        private Krypton.Toolkit.KryptonTextBox txtDienThoai;
        private Label label12;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Label label15;
        private GroupBox groupBox1;
        private Label label8;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Label lbTenResort;
        private Label lbMieuTa;
        private Label lbGioiThieu;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}