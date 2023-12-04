namespace baitap.View
{
    partial class Login
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
            label1 = new Label();
            panelMain = new Panel();
            pic = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            txtUserName = new Krypton.Toolkit.KryptonTextBox();
            pictureBox3 = new PictureBox();
            menu = new PictureBox();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            rjButton2 = new CustomControls.RJControls.RJButton();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            báoCáoSựCốToolStripMenuItem = new ToolStripMenuItem();
            chuyểnDạngĐăngNhậpToolStripMenuItem = new ToolStripMenuItem();
            administratorToolStripMenuItem = new ToolStripMenuItem();
            staffToolStripMenuItem = new ToolStripMenuItem();
            staffToolStripMenuItem1 = new ToolStripMenuItem();
            chếĐộTốiToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(509, 54);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 2;
            label1.Text = "Đăng nhập";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.WhiteSmoke;
            panelMain.Controls.Add(pic);
            panelMain.Controls.Add(pictureBox6);
            panelMain.Controls.Add(pictureBox5);
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(pictureBox2);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(txtUserName);
            panelMain.Controls.Add(pictureBox3);
            panelMain.Controls.Add(menu);
            panelMain.Controls.Add(pictureBox4);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(txtPassword);
            panelMain.Controls.Add(rjButton1);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(784, 461);
            panelMain.TabIndex = 3;
            panelMain.Click += btnDangNhap_Click;
            // 
            // pic
            // 
            pic.Cursor = Cursors.Hand;
            pic.Image = Properties.Resources.eye_close;
            pic.Location = new Point(647, 278);
            pic.Name = "pic";
            pic.Size = new Size(24, 24);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.TabIndex = 1;
            pic.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.password_16;
            pictureBox6.Location = new Point(509, 252);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(20, 20);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user_16;
            pictureBox5.Location = new Point(509, 195);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(450, 255);
            label6.Name = "label6";
            label6.Size = new Size(62, 17);
            label6.TabIndex = 2;
            label6.Text = "Mật khẩu";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.google_48;
            pictureBox2.Location = new Point(459, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(450, 198);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 2;
            label4.Text = "Tài khoản";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(450, 219);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(225, 31);
            txtUserName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUserName.StateCommon.Border.Rounding = 7F;
            txtUserName.StateCommon.Border.Width = 2;
            txtUserName.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.facebook_48;
            pictureBox3.Location = new Point(539, 101);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
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
            menu.Click += menu_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.twitter_48;
            pictureBox4.Location = new Point(621, 101);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(505, 167);
            label5.Name = "label5";
            label5.Size = new Size(124, 17);
            label5.TabIndex = 2;
            label5.Text = "Lựa chọn đăng nhập\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.Hand;
            txtPassword.Location = new Point(450, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(225, 31);
            txtPassword.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtPassword.StateCommon.Border.Rounding = 7F;
            txtPassword.StateCommon.Border.Width = 2;
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
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
            rjButton1.Location = new Point(509, 324);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(100, 40);
            rjButton1.TabIndex = 7;
            rjButton1.Text = "Đăng nhập";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnDangNhap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(100, 135);
            label2.Name = "label2";
            label2.Size = new Size(146, 45);
            label2.TabIndex = 2;
            label2.Text = "Đăng Ký";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(52, 198);
            label3.Name = "label3";
            label3.Size = new Size(241, 51);
            label3.TabIndex = 2;
            label3.Text = "Nhập thông tin cá nhân của bạn và \r\ntạo tài khoản mới để kết nối với chúng tôi\r\n\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._5153829;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(rjButton2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 461);
            panel1.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(98, 145);
            label8.Name = "label8";
            label8.Size = new Size(146, 45);
            label8.TabIndex = 2;
            label8.Text = "Đăng Ký";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(48, 198);
            label7.Name = "label7";
            label7.Size = new Size(241, 34);
            label7.TabIndex = 2;
            label7.Text = "Nhập thông tin cá nhân của bạn và \r\ntạo tài khoản mới để kết nối với chúng tôi";
            label7.TextAlign = ContentAlignment.MiddleCenter;
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
            rjButton2.Location = new Point(113, 244);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(100, 40);
            rjButton2.TabIndex = 7;
            rjButton2.Text = "Đăng ký";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += btnDangKy_click;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 40;
            bunifuElipse1.TargetControl = this;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { báoCáoSựCốToolStripMenuItem, chuyểnDạngĐăngNhậpToolStripMenuItem, chếĐộTốiToolStripMenuItem, thoátToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(206, 114);
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
            administratorToolStripMenuItem.Size = new Size(180, 22);
            administratorToolStripMenuItem.Text = "Administrator";
            administratorToolStripMenuItem.Click += administratorToolStripMenuItem_Click;
            // 
            // staffToolStripMenuItem
            // 
            staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            staffToolStripMenuItem.Size = new Size(180, 22);
            staffToolStripMenuItem.Text = "Manager";
            // 
            // staffToolStripMenuItem1
            // 
            staffToolStripMenuItem1.Name = "staffToolStripMenuItem1";
            staffToolStripMenuItem1.Size = new Size(180, 22);
            staffToolStripMenuItem1.Text = "Staff";
            // 
            // chếĐộTốiToolStripMenuItem
            // 
            chếĐộTốiToolStripMenuItem.Name = "chếĐộTốiToolStripMenuItem";
            chếĐộTốiToolStripMenuItem.Size = new Size(205, 22);
            chếĐộTốiToolStripMenuItem.Text = "Chế độ tối";
            chếĐộTốiToolStripMenuItem.Click += chếĐộTốiToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(205, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelMain;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private Krypton.Toolkit.KryptonTextBox txtUserName;
        private Label label6;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private PictureBox pictureBox5;
        private PictureBox menu;
        private Panel panel1;
        private PictureBox pic;
        private PictureBox pictureBox6;
        private Label label8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem báoCáoSựCốToolStripMenuItem;
        private ToolStripMenuItem chuyểnDạngĐăngNhậpToolStripMenuItem;
        private ToolStripMenuItem administratorToolStripMenuItem;
        private ToolStripMenuItem staffToolStripMenuItem;
        private ToolStripMenuItem staffToolStripMenuItem1;
        private ToolStripMenuItem chếĐộTốiToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Label label7;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
    }
}