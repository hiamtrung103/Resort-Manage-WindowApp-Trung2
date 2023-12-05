namespace baitap.View
{
    partial class ForgetPassword
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
            btnDN = new CustomControls.RJControls.RJButton();
            label8 = new Label();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            txtUserName = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            rjButton2 = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            panel1.Controls.Add(btnDN);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 461);
            panel1.TabIndex = 7;
            // 
            // btnDN
            // 
            btnDN.BackColor = Color.DeepSkyBlue;
            btnDN.BackgroundColor = Color.DeepSkyBlue;
            btnDN.BorderColor = Color.PaleVioletRed;
            btnDN.BorderRadius = 5;
            btnDN.BorderSize = 0;
            btnDN.FlatAppearance.BorderSize = 0;
            btnDN.FlatStyle = FlatStyle.Flat;
            btnDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDN.ForeColor = Color.White;
            btnDN.Location = new Point(123, 242);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(100, 40);
            btnDN.TabIndex = 8;
            btnDN.Text = "Đăng nhập";
            btnDN.TextColor = Color.White;
            btnDN.UseVisualStyleBackColor = false;
            btnDN.Click += btnDN_Click;
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
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.user_16;
            pictureBox5.Location = new Point(489, 170);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(20, 20);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(489, 125);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 14;
            label1.Text = "Quên mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(430, 173);
            label4.Name = "label4";
            label4.Size = new Size(63, 17);
            label4.TabIndex = 16;
            label4.Text = "Tài khoản";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(430, 194);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(268, 31);
            txtUserName.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtUserName.StateCommon.Border.Rounding = 7F;
            txtUserName.StateCommon.Border.Width = 2;
            txtUserName.TabIndex = 18;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(430, 249);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(268, 31);
            kryptonTextBox1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBox1.StateCommon.Border.Rounding = 7F;
            kryptonTextBox1.StateCommon.Border.Width = 2;
            kryptonTextBox1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(430, 228);
            label2.Name = "label2";
            label2.Size = new Size(39, 17);
            label2.TabIndex = 16;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            rjButton2.Location = new Point(516, 286);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(100, 40);
            rjButton2.TabIndex = 19;
            rjButton2.Text = "Đỗi mật khẩu";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(rjButton2);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(kryptonTextBox1);
            Controls.Add(label4);
            Controls.Add(txtUserName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ForgetPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Panel panel1;
        private CustomControls.RJControls.RJButton btnDN;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox txtUserName;
        private CustomControls.RJControls.RJButton rjButton2;
    }
}