namespace Quanly
{
    partial class fAccountProfile
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
            btnSave = new Button();
            btnThoat = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            tbPasswordre = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            tbPasswordNew = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            tbPasswordOld = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            tbUser = new TextBox();
            label2 = new Label();
            panel6 = new Panel();
            tbDispayname = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnSave.Location = new Point(286, 423);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 38);
            btnSave.TabIndex = 5;
            btnSave.Text = "Cập nhật";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.None;
            btnThoat.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnThoat.Location = new Point(440, 423);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(124, 38);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Location = new Point(30, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 364);
            panel1.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(tbPasswordre);
            panel5.Controls.Add(label5);
            panel5.Font = new Font("Arial", 11F, FontStyle.Bold);
            panel5.Location = new Point(10, 282);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(532, 61);
            panel5.TabIndex = 9;
            // 
            // tbPasswordre
            // 
            tbPasswordre.Font = new Font("Arial", 11F, FontStyle.Bold);
            tbPasswordre.Location = new Point(212, 12);
            tbPasswordre.Margin = new Padding(2);
            tbPasswordre.Name = "tbPasswordre";
            tbPasswordre.Size = new Size(312, 33);
            tbPasswordre.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11F, FontStyle.Bold);
            label5.Location = new Point(22, 19);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 26);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại mật khẩu";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbPasswordNew);
            panel4.Controls.Add(label4);
            panel4.Font = new Font("Arial", 11F, FontStyle.Bold);
            panel4.Location = new Point(10, 217);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 61);
            panel4.TabIndex = 8;
            // 
            // tbPasswordNew
            // 
            tbPasswordNew.Font = new Font("Arial", 11F, FontStyle.Bold);
            tbPasswordNew.Location = new Point(212, 12);
            tbPasswordNew.Margin = new Padding(2);
            tbPasswordNew.Name = "tbPasswordNew";
            tbPasswordNew.Size = new Size(312, 33);
            tbPasswordNew.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Bold);
            label4.Location = new Point(22, 19);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 26);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới";
            // 
            // panel3
            // 
            panel3.Controls.Add(tbPasswordOld);
            panel3.Controls.Add(label3);
            panel3.Font = new Font("Arial", 11F, FontStyle.Bold);
            panel3.Location = new Point(11, 152);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 61);
            panel3.TabIndex = 7;
            // 
            // tbPasswordOld
            // 
            tbPasswordOld.Font = new Font("Arial", 11F, FontStyle.Bold);
            tbPasswordOld.Location = new Point(212, 12);
            tbPasswordOld.Margin = new Padding(2);
            tbPasswordOld.Name = "tbPasswordOld";
            tbPasswordOld.PasswordChar = '*';
            tbPasswordOld.ReadOnly = true;
            tbPasswordOld.Size = new Size(311, 33);
            tbPasswordOld.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F, FontStyle.Bold);
            label3.Location = new Point(22, 19);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 26);
            label3.TabIndex = 0;
            label3.Text = "Mật Khẩu cũ";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbUser);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Arial", 11F, FontStyle.Bold);
            panel2.Location = new Point(11, 87);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 61);
            panel2.TabIndex = 6;
            // 
            // tbUser
            // 
            tbUser.Font = new Font("Arial", 11F, FontStyle.Bold);
            tbUser.Location = new Point(212, 12);
            tbUser.Margin = new Padding(2);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(312, 33);
            tbUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold);
            label2.Location = new Point(22, 19);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 26);
            label2.TabIndex = 0;
            label2.Text = "Tên Đăng nhập";
            // 
            // panel6
            // 
            panel6.Controls.Add(tbDispayname);
            panel6.Controls.Add(label1);
            panel6.Font = new Font("Arial", 11F, FontStyle.Bold);
            panel6.Location = new Point(11, 22);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(530, 61);
            panel6.TabIndex = 5;
            // 
            // tbDispayname
            // 
            tbDispayname.Font = new Font("Arial", 11F, FontStyle.Bold);
            tbDispayname.Location = new Point(211, 15);
            tbDispayname.Margin = new Padding(2);
            tbDispayname.Name = "tbDispayname";
            tbDispayname.ReadOnly = true;
            tbDispayname.Size = new Size(312, 33);
            tbDispayname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11F, FontStyle.Bold);
            label1.Location = new Point(22, 15);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 26);
            label1.TabIndex = 0;
            label1.Text = "Tên hiển thị";
            // 
            // fAccountProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(606, 472);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btnThoat);
            Controls.Add(btnSave);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(2);
            Name = "fAccountProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Update Password";
            Load += fAccountProfile_Load;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
        private Button btnThoat;
        private Panel panel1;
        private Panel panel5;
        private TextBox tbPasswordre;
        private Label label5;
        private Panel panel4;
        private TextBox tbPasswordNew;
        private Label label4;
        private Panel panel3;
        private TextBox tbPasswordOld;
        private Label label3;
        private Panel panel2;
        private TextBox tbUser;
        private Label label2;
        private Panel panel6;
        private TextBox tbDispayname;
        private Label label1;
    }
}