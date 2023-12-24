namespace baitap.View
{
    partial class Register
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
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            panel1 = new Panel();
            rjButton1 = new CustomControls.RJControls.RJButton();
            label8 = new Label();
            label7 = new Label();
            panelMain = new Panel();
            pictureBox2 = new PictureBox();
            txtDiaChi = new Krypton.Toolkit.KryptonTextBox();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            txtGioiTinh = new Krypton.Toolkit.KryptonComboBox();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            txtNgaySinh = new Krypton.Toolkit.KryptonDateTimePicker();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            label5 = new Label();
            label6 = new Label();
            label12 = new Label();
            txtHoTen = new Krypton.Toolkit.KryptonTextBox();
            label4 = new Label();
            txtUserName = new Krypton.Toolkit.KryptonTextBox();
            menu = new PictureBox();
            txtPassword2 = new Krypton.Toolkit.KryptonTextBox();
            txtDienThoai = new Krypton.Toolkit.KryptonTextBox();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            báoCáoSựCốToolStripMenuItem = new ToolStripMenuItem();
            chuyểnDạngĐăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            administratorToolStripMenuItem = new ToolStripMenuItem();
            staffToolStripMenuItem = new ToolStripMenuItem();
            staffToolStripMenuItem1 = new ToolStripMenuItem();
            chếĐộTốiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGioiTinh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 40;
            bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.sign_up1;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(rjButton1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 450);
            panel1.TabIndex = 6;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.DeepSkyBlue;
            rjButton1.BackgroundColor = Color.DeepSkyBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 5;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(123, 242);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(100, 40);
            rjButton1.TabIndex = 8;
            rjButton1.Text = "Đăng nhập";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnDangNhap_click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(77, 145);
            label8.Name = "label8";
            label8.Size = new Size(190, 45);
            label8.TabIndex = 2;
            label8.Text = "Đăng Nhập";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(48, 198);
            label7.Name = "label7";
            label7.Size = new Size(252, 51);
            label7.TabIndex = 2;
            label7.Text = "Để duy trì kết nối với chúng tôi vui lòng \r\nđăng nhập bằng thông tin cá nhân của bạn\r\n\r\n";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Controls.Add(pictureBox2);
            panelMain.Controls.Add(txtDiaChi);
            panelMain.Controls.Add(rjButton3);
            panelMain.Controls.Add(rjButton2);
            panelMain.Controls.Add(txtGioiTinh);
            panelMain.Controls.Add(txtEmail);
            panelMain.Controls.Add(txtNgaySinh);
            panelMain.Controls.Add(pictureBox7);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(label11);
            panelMain.Controls.Add(label9);
            panelMain.Controls.Add(label10);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(label12);
            panelMain.Controls.Add(txtHoTen);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(txtUserName);
            panelMain.Controls.Add(menu);
            panelMain.Controls.Add(txtPassword2);
            panelMain.Controls.Add(txtDienThoai);
            panelMain.Controls.Add(txtPassword);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 450);
            panelMain.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(372, 323);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 71);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(371, 288);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(417, 29);
            txtDiaChi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDiaChi.StateCommon.Border.Rounding = 5F;
            txtDiaChi.StateCommon.Border.Width = 2;
            txtDiaChi.TabIndex = 11;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.LightGreen;
            rjButton3.BackgroundColor = Color.LightGreen;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 5;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton3.ForeColor = Color.White;
            rjButton3.Location = new Point(372, 401);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(77, 21);
            rjButton3.TabIndex = 13;
            rjButton3.Text = "Tải ảnh";
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += btnChonAnhDaiDien_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Crimson;
            rjButton2.BackgroundColor = Color.Crimson;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 5;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(538, 382);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(100, 40);
            rjButton2.TabIndex = 13;
            rjButton2.Text = "Đăng ký";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += btnDangKy_click;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.DropDownWidth = 191;
            txtGioiTinh.IntegralHeight = false;
            txtGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            txtGioiTinh.Location = new Point(588, 234);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(197, 27);
            txtGioiTinh.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtGioiTinh.StateCommon.ComboBox.Border.Rounding = 5F;
            txtGioiTinh.StateCommon.ComboBox.Border.Width = 2;
            txtGioiTinh.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            txtGioiTinh.StateNormal.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtGioiTinh.StateNormal.ComboBox.Border.Rounding = 5F;
            txtGioiTinh.StateNormal.ComboBox.Border.Width = 2;
            txtGioiTinh.StateNormal.ComboBox.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGioiTinh.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(371, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(203, 29);
            txtEmail.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtEmail.StateCommon.Border.Rounding = 5F;
            txtEmail.StateCommon.Border.Width = 2;
            txtEmail.TabIndex = 11;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.CustomFormat = "yyyy";
            txtNgaySinh.Format = DateTimePickerFormat.Custom;
            txtNgaySinh.Location = new Point(370, 234);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(201, 27);
            txtNgaySinh.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtNgaySinh.StateCommon.Border.Rounding = 5F;
            txtNgaySinh.StateCommon.Border.Width = 2;
            txtNgaySinh.StateCommon.Content.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNgaySinh.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            txtNgaySinh.TabIndex = 8;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.eye_close;
            pictureBox7.Location = new Point(545, 182);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(24, 24);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(499, 15);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 2;
            label1.Text = "Đăng Ký Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(587, 161);
            label2.Name = "label2";
            label2.Size = new Size(118, 17);
            label2.TabIndex = 2;
            label2.Text = "Xác nhận mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(584, 108);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 2;
            label3.Text = "Số Điện Thoại";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(370, 108);
            label11.Name = "label11";
            label11.Size = new Size(39, 17);
            label11.TabIndex = 2;
            label11.Text = "Email";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(372, 268);
            label9.Name = "label9";
            label9.Size = new Size(47, 17);
            label9.TabIndex = 2;
            label9.Text = "Địa chỉ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(591, 214);
            label10.Name = "label10";
            label10.Size = new Size(56, 17);
            label10.TabIndex = 2;
            label10.Text = "Giới tính";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(372, 214);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 2;
            label5.Text = "Năm Sinh";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(370, 160);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 2;
            label6.Text = "Mật khẩu";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(584, 53);
            label12.Name = "label12";
            label12.Size = new Size(66, 17);
            label12.TabIndex = 2;
            label12.Text = "Họ và Tên";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(584, 74);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(204, 31);
            txtHoTen.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtHoTen.StateCommon.Border.Rounding = 7F;
            txtHoTen.StateCommon.Border.Width = 2;
            txtHoTen.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(370, 53);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 2;
            label4.Text = "Tài khoản";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(370, 74);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(204, 31);
            txtUserName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUserName.StateCommon.Border.Rounding = 7F;
            txtUserName.StateCommon.Border.Width = 2;
            txtUserName.TabIndex = 6;
            // 
            // menu
            // 
            menu.Image = Properties.Resources.Settings;
            menu.Location = new Point(732, 12);
            menu.Name = "menu";
            menu.Size = new Size(40, 40);
            menu.SizeMode = PictureBoxSizeMode.StretchImage;
            menu.TabIndex = 1;
            menu.TabStop = false;
            // 
            // txtPassword2
            // 
            txtPassword2.Location = new Point(585, 180);
            txtPassword2.Name = "txtPassword2";
            txtPassword2.PasswordChar = '●';
            txtPassword2.Size = new Size(203, 31);
            txtPassword2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPassword2.StateCommon.Border.Rounding = 7F;
            txtPassword2.StateCommon.Border.Width = 2;
            txtPassword2.TabIndex = 6;
            txtPassword2.UseSystemPasswordChar = true;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(583, 128);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(206, 31);
            txtDienThoai.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtDienThoai.StateCommon.Border.Rounding = 7F;
            txtDienThoai.StateCommon.Border.Width = 2;
            txtDienThoai.TabIndex = 6;
            txtDienThoai.KeyPress += txtDienThoai_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(370, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(204, 31);
            txtPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPassword.StateCommon.Border.Rounding = 7F;
            txtPassword.StateCommon.Border.Width = 2;
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { báoCáoSựCốToolStripMenuItem, chuyểnDạngĐăngNhậpToolStripMenuItem, chếĐộTốiToolStripMenuItem, thoátToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(206, 92);
            // 
            // báoCáoSựCốToolStripMenuItem
            // 
            báoCáoSựCốToolStripMenuItem.Name = "báoCáoSựCốToolStripMenuItem";
            báoCáoSựCốToolStripMenuItem.Size = new Size(205, 22);
            báoCáoSựCốToolStripMenuItem.Text = "Báo cáo sự cố";
            // 
            // chuyểnDạngĐăngNhậpToolStripMenuItem
            // 
            chuyểnDạngĐăngNhậpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { administratorToolStripMenuItem, staffToolStripMenuItem, staffToolStripMenuItem1 });
            chuyểnDạngĐăngNhậpToolStripMenuItem.Name = "chuyểnDạngĐăngNhậpToolStripMenuItem";
            chuyểnDạngĐăngNhậpToolStripMenuItem.Size = new Size(205, 22);
            chuyểnDạngĐăngNhậpToolStripMenuItem.Text = "Chuyển dạng đăng nhập";
            // 
            // administratorToolStripMenuItem
            // 
            administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            administratorToolStripMenuItem.Size = new Size(147, 22);
            administratorToolStripMenuItem.Text = "Administrator";
            // 
            // staffToolStripMenuItem
            // 
            staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            staffToolStripMenuItem.Size = new Size(147, 22);
            staffToolStripMenuItem.Text = "Manager";
            // 
            // staffToolStripMenuItem1
            // 
            staffToolStripMenuItem1.Name = "staffToolStripMenuItem1";
            staffToolStripMenuItem1.Size = new Size(147, 22);
            staffToolStripMenuItem1.Text = "Staff";
            // 
            // chếĐộTốiToolStripMenuItem
            // 
            chếĐộTốiToolStripMenuItem.Name = "chếĐộTốiToolStripMenuItem";
            chếĐộTốiToolStripMenuItem.Size = new Size(205, 22);
            chếĐộTốiToolStripMenuItem.Text = "Chế độ tối";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(205, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dangky";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGioiTinh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Panel panelMain;
        private PictureBox pictureBox7;
        private Label label1;
        private Label label6;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox txtUserName;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Label label2;
        private Krypton.Toolkit.KryptonTextBox txtPassword2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem báoCáoSựCốToolStripMenuItem;
        private ToolStripMenuItem chuyểnDạngĐăngNhậpToolStripMenuItem;
        private ToolStripMenuItem administratorToolStripMenuItem;
        private ToolStripMenuItem staffToolStripMenuItem;
        private ToolStripMenuItem staffToolStripMenuItem1;
        private ToolStripMenuItem chếĐộTốiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Krypton.Toolkit.KryptonDateTimePicker txtNgaySinh;
        private Krypton.Toolkit.KryptonTextBox txtDiaChi;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Label label3;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label label5;
        private Krypton.Toolkit.KryptonTextBox txtDienThoai;
        private Label label12;
        private Krypton.Toolkit.KryptonTextBox txtHoTen;
        private Krypton.Toolkit.KryptonComboBox txtGioiTinh;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private PictureBox menu;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private CustomControls.RJControls.RJButton rjButton3;
    }
}