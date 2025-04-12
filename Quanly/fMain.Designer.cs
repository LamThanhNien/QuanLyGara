namespace Quanly
{
    partial class fMain
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
            panel1 = new Panel();
            btnAccount = new Button();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            btnThongke = new Button();
            btnEmployee = new Button();
            btnDichvu = new Button();
            btnCar = new Button();
            btnCustomer = new Button();
            btnThanhToan = new Button();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            tÀIKHOẢNToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            cậpNhậtThôngTinToolStripMenuItem = new ToolStripMenuItem();
            phânQuyềnToolStripMenuItem = new ToolStripMenuItem();
            Exit = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            tbUsername = new TextBox();
            panelbody = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnThongke);
            panel1.Controls.Add(btnEmployee);
            panel1.Controls.Add(btnDichvu);
            panel1.Controls.Add(btnCar);
            panel1.Controls.Add(btnCustomer);
            panel1.Controls.Add(btnThanhToan);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 902);
            panel1.TabIndex = 0;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.SteelBlue;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnAccount.ForeColor = SystemColors.ButtonHighlight;
            btnAccount.Location = new Point(0, 504);
            btnAccount.Margin = new Padding(4, 3, 4, 3);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(235, 64);
            btnAccount.TabIndex = 6;
            btnAccount.Text = "Ql Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Visible = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_removebg_preview;
            pictureBox1.Location = new Point(24, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(0, 843);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(235, 47);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Visible = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnThongke
            // 
            btnThongke.BackColor = Color.SteelBlue;
            btnThongke.FlatAppearance.BorderSize = 0;
            btnThongke.FlatStyle = FlatStyle.Flat;
            btnThongke.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnThongke.ForeColor = SystemColors.ButtonHighlight;
            btnThongke.Location = new Point(0, 574);
            btnThongke.Margin = new Padding(4, 3, 4, 3);
            btnThongke.Name = "btnThongke";
            btnThongke.Size = new Size(235, 64);
            btnThongke.TabIndex = 5;
            btnThongke.Text = "Thống Kê";
            btnThongke.UseVisualStyleBackColor = false;
            btnThongke.Visible = false;
            btnThongke.Click += btnThongke_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.BackColor = Color.SteelBlue;
            btnEmployee.FlatAppearance.BorderSize = 0;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnEmployee.ForeColor = SystemColors.ButtonHighlight;
            btnEmployee.Location = new Point(0, 434);
            btnEmployee.Margin = new Padding(4, 3, 4, 3);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(235, 64);
            btnEmployee.TabIndex = 6;
            btnEmployee.Text = "QL Nhân Viên";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Visible = false;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnDichvu
            // 
            btnDichvu.BackColor = Color.SteelBlue;
            btnDichvu.FlatAppearance.BorderSize = 0;
            btnDichvu.FlatStyle = FlatStyle.Flat;
            btnDichvu.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnDichvu.ForeColor = SystemColors.ButtonHighlight;
            btnDichvu.Location = new Point(0, 364);
            btnDichvu.Margin = new Padding(4, 3, 4, 3);
            btnDichvu.Name = "btnDichvu";
            btnDichvu.Size = new Size(235, 64);
            btnDichvu.TabIndex = 4;
            btnDichvu.Text = "QL Dịch Vụ";
            btnDichvu.UseVisualStyleBackColor = false;
            btnDichvu.Click += btnDichvu_Click;
            // 
            // btnCar
            // 
            btnCar.BackColor = Color.SteelBlue;
            btnCar.FlatAppearance.BorderSize = 0;
            btnCar.FlatStyle = FlatStyle.Flat;
            btnCar.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnCar.ForeColor = SystemColors.ButtonHighlight;
            btnCar.Location = new Point(0, 294);
            btnCar.Margin = new Padding(4, 3, 4, 3);
            btnCar.Name = "btnCar";
            btnCar.Size = new Size(235, 64);
            btnCar.TabIndex = 3;
            btnCar.Text = "Xe";
            btnCar.UseVisualStyleBackColor = false;
            btnCar.Click += btnCar_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.SteelBlue;
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnCustomer.ForeColor = SystemColors.ButtonHighlight;
            btnCustomer.Location = new Point(0, 224);
            btnCustomer.Margin = new Padding(4, 3, 4, 3);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(235, 64);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Khách Hàng";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.SteelBlue;
            btnThanhToan.FlatAppearance.BorderColor = Color.Red;
            btnThanhToan.FlatAppearance.BorderSize = 0;
            btnThanhToan.FlatAppearance.MouseDownBackColor = Color.Red;
            btnThanhToan.FlatStyle = FlatStyle.Flat;
            btnThanhToan.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnThanhToan.ForeColor = SystemColors.ButtonHighlight;
            btnThanhToan.Location = new Point(0, 154);
            btnThanhToan.Margin = new Padding(4, 3, 4, 3);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(235, 64);
            btnThanhToan.TabIndex = 1;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhtoan_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(menuStrip1);
            panel2.Controls.Add(progressBar1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbUsername);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(235, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1287, 50);
            panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Right;
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tÀIKHOẢNToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            menuStrip1.Location = new Point(1111, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(176, 44);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tÀIKHOẢNToolStripMenuItem
            // 
            tÀIKHOẢNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem, Exit });
            tÀIKHOẢNToolStripMenuItem.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tÀIKHOẢNToolStripMenuItem.Image = Properties.Resources.download__4_1;
            tÀIKHOẢNToolStripMenuItem.Name = "tÀIKHOẢNToolStripMenuItem";
            tÀIKHOẢNToolStripMenuItem.Size = new Size(159, 40);
            tÀIKHOẢNToolStripMenuItem.Text = "TÀI KHOẢN";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cậpNhậtThôngTinToolStripMenuItem, phânQuyềnToolStripMenuItem });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(206, 34);
            thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            cậpNhậtThôngTinToolStripMenuItem.Size = new Size(305, 34);
            cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
            cậpNhậtThôngTinToolStripMenuItem.Click += cậpNhậtThôngTinToolStripMenuItem_Click;
            // 
            // phânQuyềnToolStripMenuItem
            // 
            phânQuyềnToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            phânQuyềnToolStripMenuItem.Size = new Size(305, 34);
            phânQuyềnToolStripMenuItem.Text = "Thêm Nhân viên mới";
            // 
            // Exit
            // 
            Exit.Enabled = false;
            Exit.Image = Properties.Resources.download__2_;
            Exit.Name = "Exit";
            Exit.RightToLeft = RightToLeft.Yes;
            Exit.Size = new Size(206, 34);
            Exit.Text = "Đăng xuất";
            Exit.TextImageRelation = TextImageRelation.TextBeforeImage;
            Exit.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(16, 40);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(16, 40);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(16, 40);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(16, 40);
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(16, 40);
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(16, 40);
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 37);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1105, 10);
            progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(149, 29);
            label1.TabIndex = 2;
            label1.Text = "Thanh Toán";
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbUsername.BackColor = SystemColors.ControlLight;
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(484, 11);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.ReadOnly = true;
            tbUsername.RightToLeft = RightToLeft.Yes;
            tbUsername.Size = new Size(624, 26);
            tbUsername.TabIndex = 1;
            tbUsername.Text = "Xin chào";
            // 
            // panelbody
            // 
            panelbody.Dock = DockStyle.Fill;
            panelbody.Location = new Point(235, 50);
            panelbody.Name = "panelbody";
            panelbody.Size = new Size(1287, 852);
            panelbody.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 902);
            Controls.Add(panelbody);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "fMain";
            RightToLeft = RightToLeft.No;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += fMain_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panelbody;
        private TextBox textBox1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tÀIKHOẢNToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ContextMenuStrip contextMenuStrip1;
        public ToolStripMenuItem Exit;
        public TextBox tbUsername;
        public Button btnLogout;
        public ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        protected Panel panel1;
        protected Button btnCar;
        protected Button btnCustomer;
        protected Button btnThanhToan;
        protected Button btnEmployee;
        protected Button btnThongke;
        protected Button btnDichvu;
        protected Button btnAccount;
    }
}