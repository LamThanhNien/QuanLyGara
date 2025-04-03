namespace Quanly
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            CheckBoxShow = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            tbpassword = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            tbname = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pnlTitleBar_MouseDown = new Panel();
            btnMinimize = new Button();
            btnExit = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlTitleBar_MouseDown.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 608);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(CheckBoxShow);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel2.Location = new Point(572, 129);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 266);
            panel2.TabIndex = 3;
            // 
            // CheckBoxShow
            // 
            CheckBoxShow.Anchor = AnchorStyles.None;
            CheckBoxShow.AutoSize = true;
            CheckBoxShow.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckBoxShow.Location = new Point(324, 153);
            CheckBoxShow.Name = "CheckBoxShow";
            CheckBoxShow.Size = new Size(161, 25);
            CheckBoxShow.TabIndex = 6;
            CheckBoxShow.Text = "Hiện mật khẩu";
            CheckBoxShow.UseVisualStyleBackColor = true;
            CheckBoxShow.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold);
            button2.Location = new Point(318, 205);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(151, 42);
            button2.TabIndex = 3;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(124, 205);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(151, 42);
            button1.TabIndex = 2;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(tbpassword);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel3.Location = new Point(24, 86);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(476, 62);
            panel3.TabIndex = 1;
            // 
            // tbpassword
            // 
            tbpassword.Anchor = AnchorStyles.None;
            tbpassword.Font = new Font("Arial", 12F, FontStyle.Bold);
            tbpassword.HideSelection = false;
            tbpassword.Location = new Point(199, 11);
            tbpassword.Margin = new Padding(2);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(262, 35);
            tbpassword.TabIndex = 1;
            tbpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 33);
            label2.TabIndex = 0;
            label2.Text = "Password:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(tbname);
            panel4.Controls.Add(label1);
            panel4.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel4.Location = new Point(24, 19);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(476, 61);
            panel4.TabIndex = 0;
            // 
            // tbname
            // 
            tbname.Anchor = AnchorStyles.None;
            tbname.Font = new Font("Arial", 12F, FontStyle.Bold);
            tbname.Location = new Point(199, 15);
            tbname.Margin = new Padding(2);
            tbname.Name = "tbname";
            tbname.Size = new Size(262, 35);
            tbname.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 33);
            label1.TabIndex = 0;
            label1.Text = "User:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.vo_lang_dinh_kim_cuong_gia_2_1699434500319350442308_1699493126299_16994931264015605531821;
            pictureBox1.Location = new Point(0, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(540, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(663, 44);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(293, 33);
            label3.TabIndex = 4;
            label3.Text = "Thông tin đăng nhập";
            // 
            // pnlTitleBar_MouseDown
            // 
            pnlTitleBar_MouseDown.BackColor = Color.FromArgb(45, 47, 51);
            pnlTitleBar_MouseDown.Controls.Add(btnMinimize);
            pnlTitleBar_MouseDown.Controls.Add(btnExit);
            pnlTitleBar_MouseDown.Dock = DockStyle.Top;
            pnlTitleBar_MouseDown.Location = new Point(0, 0);
            pnlTitleBar_MouseDown.Name = "pnlTitleBar_MouseDown";
            pnlTitleBar_MouseDown.Size = new Size(1095, 35);
            pnlTitleBar_MouseDown.TabIndex = 2;
            pnlTitleBar_MouseDown.MouseDown += pnlTitleBar_MouseDown_MouseDown_1;
            // 
            // btnMinimize
            // 
            btnMinimize.Location = new Point(1000, 1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(41, 34);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "−";
            btnMinimize.TextAlign = ContentAlignment.TopCenter;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(1045, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(41, 34);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 641);
            ControlBox = false;
            Controls.Add(pnlTitleBar_MouseDown);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlTitleBar_MouseDown.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private TextBox tbpassword;
        private Label label2;
        private Panel panel4;
        private TextBox tbname;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private RadioButton rbtnShow;
        private CheckBox CheckBoxShow;
        private Panel pnlTitleBar_MouseDown;
        private Button btnMinimize;
        private Button btnExit;
    }
}
