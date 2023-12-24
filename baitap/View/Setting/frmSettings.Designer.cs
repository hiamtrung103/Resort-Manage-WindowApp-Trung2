namespace baitap.View
{
    partial class frmSettings
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
            label7 = new Label();
            label6 = new Label();
            bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            panelMain = new Panel();
            panel7 = new Panel();
            panel2 = new Panel();
            rjButton4 = new CustomControls.RJControls.RJButton();
            panel6 = new Panel();
            rjButton3 = new CustomControls.RJControls.RJButton();
            panel5 = new Panel();
            rjButton2 = new CustomControls.RJControls.RJButton();
            panel4 = new Panel();
            rjButton1 = new CustomControls.RJControls.RJButton();
            panel3 = new Panel();
            bunifuCards1.SuspendLayout();
            panelMain.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DimGray;
            label7.Location = new Point(12, 41);
            label7.Name = "label7";
            label7.Size = new Size(376, 21);
            label7.TabIndex = 1;
            label7.Text = "Thay đỗi trang cá nhân và cài đặt tài khoản của bạn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(206, 32);
            label6.TabIndex = 2;
            label6.Text = "Cài đặt tài khoản";
            // 
            // bunifuCards1
            // 
            bunifuCards1.BackColor = Color.White;
            bunifuCards1.BorderRadius = 20;
            bunifuCards1.BottomSahddow = true;
            bunifuCards1.BottomShadow = true;
            bunifuCards1.color = Color.Transparent;
            bunifuCards1.Controls.Add(panelMain);
            bunifuCards1.Controls.Add(panel2);
            bunifuCards1.IndicatorColor = Color.Transparent;
            bunifuCards1.LeftSahddow = false;
            bunifuCards1.LeftShadow = false;
            bunifuCards1.Location = new Point(12, 74);
            bunifuCards1.Name = "bunifuCards1";
            bunifuCards1.RightSahddow = true;
            bunifuCards1.RightShadow = true;
            bunifuCards1.ShadowDepth = 20;
            bunifuCards1.Size = new Size(1031, 604);
            bunifuCards1.TabIndex = 4;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panel7);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(146, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(885, 604);
            panelMain.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ControlDarkDark;
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(2, 604);
            panel7.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(rjButton4);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(rjButton3);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(rjButton2);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(rjButton1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(146, 604);
            panel2.TabIndex = 2;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.Transparent;
            rjButton4.BackgroundColor = Color.Transparent;
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 0;
            rjButton4.BorderSize = 0;
            rjButton4.Dock = DockStyle.Top;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton4.ForeColor = Color.Black;
            rjButton4.Image = Properties.Resources.help_24;
            rjButton4.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton4.Location = new Point(0, 216);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(146, 40);
            rjButton4.TabIndex = 7;
            rjButton4.Text = "Hỗ trợ";
            rjButton4.TextColor = Color.Black;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += SettingHoTroOpen;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 192);
            panel6.Name = "panel6";
            panel6.Size = new Size(146, 24);
            panel6.TabIndex = 6;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.Transparent;
            rjButton3.BackgroundColor = Color.Transparent;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 0;
            rjButton3.BorderSize = 0;
            rjButton3.Dock = DockStyle.Top;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton3.ForeColor = Color.Black;
            rjButton3.Image = Properties.Resources.notification_24;
            rjButton3.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton3.Location = new Point(0, 152);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(146, 40);
            rjButton3.TabIndex = 5;
            rjButton3.Text = "Thông báo";
            rjButton3.TextColor = Color.Black;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += SettingThongBaoOpen;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 128);
            panel5.Name = "panel5";
            panel5.Size = new Size(146, 24);
            panel5.TabIndex = 4;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Transparent;
            rjButton2.BackgroundColor = Color.Transparent;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 0;
            rjButton2.BorderSize = 0;
            rjButton2.Dock = DockStyle.Top;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.Black;
            rjButton2.Image = Properties.Resources.password_24;
            rjButton2.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton2.Location = new Point(0, 88);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(146, 40);
            rjButton2.TabIndex = 3;
            rjButton2.Text = "Mật khẩu";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += SettingMatKhauOpen;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 24);
            panel4.TabIndex = 2;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.Transparent;
            rjButton1.BackgroundColor = Color.Transparent;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.Dock = DockStyle.Top;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.Black;
            rjButton1.Image = Properties.Resources.account_24;
            rjButton1.ImageAlign = ContentAlignment.MiddleLeft;
            rjButton1.Location = new Point(0, 24);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(146, 40);
            rjButton1.TabIndex = 1;
            rjButton1.Text = "Hồ sơ";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += SettingKhachHangOpen;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 24);
            panel3.TabIndex = 0;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1534, 690);
            Controls.Add(bunifuCards1);
            Controls.Add(label7);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSettings";
            Text = "frmSettings";
            Load += frmSettings_Load;
            bunifuCards1.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Panel panelMain;
        private Panel panel7;
        private Panel panel2;
        private CustomControls.RJControls.RJButton rjButton4;
        private Panel panel6;
        private CustomControls.RJControls.RJButton rjButton3;
        private Panel panel5;
        private CustomControls.RJControls.RJButton rjButton2;
        private Panel panel4;
        private CustomControls.RJControls.RJButton rjButton1;
        private Panel panel3;
    }
}