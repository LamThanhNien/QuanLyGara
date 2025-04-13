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
            label3 = new Label();
            button1 = new Button();
            panel3 = new Panel();
            tbpassword = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            tbname = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 602);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(CheckBoxShow);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel2.Location = new Point(191, 42);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 517);
            panel2.TabIndex = 0;
            // 
            // CheckBoxShow
            // 
            CheckBoxShow.Anchor = AnchorStyles.None;
            CheckBoxShow.AutoSize = true;
            CheckBoxShow.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckBoxShow.Location = new Point(297, 287);
            CheckBoxShow.Name = "CheckBoxShow";
            CheckBoxShow.Size = new Size(161, 25);
            CheckBoxShow.TabIndex = 3;
            CheckBoxShow.Text = "Hiện mật khẩu";
            CheckBoxShow.UseVisualStyleBackColor = true;
            CheckBoxShow.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(159, 13);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(135, 43);
            label3.TabIndex = 0;
            label3.Text = "Sign in";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.SteelBlue;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(2, 379);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(456, 61);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLogin_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(tbpassword);
            panel3.Controls.Add(label2);
            panel3.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel3.Location = new Point(11, 184);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(438, 98);
            panel3.TabIndex = 2;
            // 
            // tbpassword
            // 
            tbpassword.Anchor = AnchorStyles.None;
            tbpassword.BackColor = SystemColors.Control;
            tbpassword.Font = new Font("Arial", 12F, FontStyle.Bold);
            tbpassword.HideSelection = false;
            tbpassword.Location = new Point(22, 43);
            tbpassword.Margin = new Padding(2);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(404, 35);
            tbpassword.TabIndex = 2;
            tbpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold);
            label2.Location = new Point(2, 15);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 26);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu:";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(tbname);
            panel4.Controls.Add(label1);
            panel4.Font = new Font("Arial", 12F, FontStyle.Bold);
            panel4.Location = new Point(11, 82);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(438, 98);
            panel4.TabIndex = 1;
            // 
            // tbname
            // 
            tbname.Anchor = AnchorStyles.None;
            tbname.BackColor = SystemColors.Control;
            tbname.Font = new Font("Arial", 12F, FontStyle.Bold);
            tbname.Location = new Point(22, 47);
            tbname.Margin = new Padding(2);
            tbname.Name = "tbname";
            tbname.Size = new Size(404, 35);
            tbname.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11F, FontStyle.Bold);
            label1.Location = new Point(2, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 26);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // Login
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(842, 614);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private TextBox tbpassword;
        private Label label2;
        private Panel panel4;
        private TextBox tbname;
        private Label label1;
        private Label label3;
        private RadioButton rbtnShow;
        private CheckBox CheckBoxShow;
    }
}
