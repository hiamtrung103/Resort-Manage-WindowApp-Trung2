namespace baitap.View
{
    partial class frmKhachHang
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            txtTenTaiKhoan = new Krypton.Toolkit.KryptonTextBox();
            label1 = new Label();
            txtDienThoai = new Krypton.Toolkit.KryptonTextBox();
            txtDiaChi = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            txtHoTenKhachHang = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            rjButton4 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            groupBox1 = new GroupBox();
            txtNamSinh = new ComboBox();
            txtGioiTinh = new Krypton.Toolkit.KryptonComboBox();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            lbEmail = new Krypton.Toolkit.KryptonLabel();
            txtGiamGia = new Krypton.Toolkit.KryptonTextBox();
            txtXacNhanPass = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtGioiTinh).BeginInit();
            SuspendLayout();
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.Location = new Point(96, 82);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(226, 29);
            txtTenTaiKhoan.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtTenTaiKhoan.StateCommon.Border.Rounding = 5F;
            txtTenTaiKhoan.StateCommon.Border.Width = 2;
            txtTenTaiKhoan.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 20;
            label1.Text = "Quản Lý Khách Hàng";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(744, 33);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(183, 29);
            txtDienThoai.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDienThoai.StateCommon.Border.Rounding = 5F;
            txtDienThoai.StateCommon.Border.Width = 2;
            txtDienThoai.TabIndex = 2;
            txtDienThoai.KeyPress += nhapSo_KeyPress;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(744, 135);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(183, 29);
            txtDiaChi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDiaChi.StateCommon.Border.Rounding = 5F;
            txtDiaChi.StateCommon.Border.Width = 2;
            txtDiaChi.TabIndex = 2;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(654, 86);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(62, 20);
            kryptonLabel5.TabIndex = 1;
            kryptonLabel5.Values.Text = "Năm sinh";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(654, 37);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(83, 20);
            kryptonLabel4.TabIndex = 1;
            kryptonLabel4.Values.Text = "Số điện thoại";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(6, 86);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(63, 20);
            kryptonLabel7.TabIndex = 1;
            kryptonLabel7.Values.Text = "Tài khoản";
            // 
            // txtHoTenKhachHang
            // 
            txtHoTenKhachHang.Location = new Point(96, 33);
            txtHoTenKhachHang.Name = "txtHoTenKhachHang";
            txtHoTenKhachHang.Size = new Size(226, 29);
            txtHoTenKhachHang.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtHoTenKhachHang.StateCommon.Border.Rounding = 5F;
            txtHoTenKhachHang.StateCommon.Border.Width = 2;
            txtHoTenKhachHang.TabIndex = 2;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(654, 139);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(48, 20);
            kryptonLabel3.TabIndex = 1;
            kryptonLabel3.Values.Text = "Địa chỉ";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(442, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(183, 29);
            txtPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPassword.StateCommon.Border.Rounding = 5F;
            txtPassword.StateCommon.Border.Width = 2;
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
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
            rjButton4.Location = new Point(390, 226);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(91, 30);
            rjButton4.TabIndex = 16;
            rjButton4.Text = "Huỷ";
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += btnHuy_Click;
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
            rjButton3.Location = new Point(293, 226);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(91, 30);
            rjButton3.TabIndex = 17;
            rjButton3.Text = "Sửa";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += btnSua_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(244, 91, 105);
            rjButton2.BackgroundColor = Color.FromArgb(244, 91, 105);
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 5;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(196, 226);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(91, 30);
            rjButton2.TabIndex = 18;
            rjButton2.Text = "Xoá";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += btnXoa_Click;
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
            rjButton1.Location = new Point(99, 226);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(91, 30);
            rjButton1.TabIndex = 19;
            rjButton1.Text = "Thêm";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnThem_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(352, 86);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(62, 20);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "Mật khẩu";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(192, 255, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(938, 184);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(960, 217);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dữ liệu";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(352, 37);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(57, 20);
            kryptonLabel6.TabIndex = 1;
            kryptonLabel6.Values.Text = "Giới tính";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNamSinh);
            groupBox1.Controls.Add(txtGioiTinh);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTenTaiKhoan);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(kryptonLabel5);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(kryptonLabel4);
            groupBox1.Controls.Add(kryptonLabel7);
            groupBox1.Controls.Add(txtHoTenKhachHang);
            groupBox1.Controls.Add(kryptonLabel3);
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(txtXacNhanPass);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(kryptonLabel1);
            groupBox1.Controls.Add(kryptonLabel2);
            groupBox1.Controls.Add(kryptonLabel6);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 183);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chỉnh sửa";
            // 
            // txtNamSinh
            // 
            txtNamSinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNamSinh.FormattingEnabled = true;
            txtNamSinh.Items.AddRange(new object[] { "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980" });
            txtNamSinh.Location = new Point(744, 82);
            txtNamSinh.Name = "txtNamSinh";
            txtNamSinh.Size = new Size(183, 29);
            txtNamSinh.TabIndex = 21;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.DropDownWidth = 175;
            txtGioiTinh.IntegralHeight = false;
            txtGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            txtGioiTinh.Location = new Point(442, 33);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(183, 29);
            txtGioiTinh.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtGioiTinh.StateCommon.ComboBox.Border.Rounding = 7F;
            txtGioiTinh.StateCommon.ComboBox.Border.Width = 2;
            txtGioiTinh.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            txtGioiTinh.TabIndex = 5;
            txtGioiTinh.Text = "Khác";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(226, 29);
            txtEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEmail.StateCommon.Border.Rounding = 5F;
            txtEmail.StateCommon.Border.Width = 2;
            txtEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            lbEmail.Location = new Point(6, 139);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(40, 20);
            lbEmail.TabIndex = 1;
            lbEmail.Values.Text = "Email";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(442, 135);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(183, 29);
            txtGiamGia.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtGiamGia.StateCommon.Border.Rounding = 5F;
            txtGiamGia.StateCommon.Border.Width = 2;
            txtGiamGia.TabIndex = 2;
            txtGiamGia.KeyPress += nhapSo_KeyPress;
            // 
            // txtXacNhanPass
            // 
            txtXacNhanPass.Location = new Point(352, 139);
            txtXacNhanPass.Name = "txtXacNhanPass";
            txtXacNhanPass.Size = new Size(78, 20);
            txtXacNhanPass.TabIndex = 1;
            txtXacNhanPass.Values.Text = "Mã giảm giá";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(6, 37);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(97, 20);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Tên khách hàng";
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ButtonSpecs.FormClose.Image = Properties.Resources.red_16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.Image = Properties.Resources.yellow_16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.Image = Properties.Resources.green16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormRestore.Image = Properties.Resources.yellow_16;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 495);
            Controls.Add(label1);
            Controls.Add(rjButton4);
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmKhachHang";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmKhachHang";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtGioiTinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtTenTaiKhoan;
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox txtDienThoai;
        private Krypton.Toolkit.KryptonTextBox txtDiaChi;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtHoTenKhachHang;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private GroupBox groupBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonLabel lbEmail;
        private Krypton.Toolkit.KryptonTextBox txtGiamGia;
        private Krypton.Toolkit.KryptonLabel txtXacNhanPass;
        private Krypton.Toolkit.KryptonComboBox txtGioiTinh;
        private ComboBox txtNamSinh;
    }
}