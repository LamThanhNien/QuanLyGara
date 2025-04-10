namespace Quanly
{
    partial class fAccount
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
            dtgvAccount = new DataGridView();
            panel6 = new Panel();
            btnFix = new Button();
            btnShow = new Button();
            btnDel = new Button();
            button1 = new Button();
            panel27 = new Panel();
            tbTypeAccount = new TextBox();
            label2 = new Label();
            panel28 = new Panel();
            tbNameDisplay = new TextBox();
            label3 = new Label();
            panel29 = new Panel();
            tbNameAccount = new TextBox();
            label4 = new Label();
            btnReset = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel6.SuspendLayout();
            panel27.SuspendLayout();
            panel28.SuspendLayout();
            panel29.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvAccount
            // 
            dtgvAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.BackgroundColor = SystemColors.Control;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(5, 12);
            dtgvAccount.Margin = new Padding(4, 3, 4, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.RowHeadersWidth = 62;
            dtgvAccount.Size = new Size(728, 580);
            dtgvAccount.TabIndex = 14;
            dtgvAccount.CellClick += dtgvAccount_CellClick;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.Controls.Add(btnFix);
            panel6.Controls.Add(btnShow);
            panel6.Controls.Add(btnDel);
            panel6.Controls.Add(button1);
            panel6.Controls.Add(panel27);
            panel6.Controls.Add(panel28);
            panel6.Controls.Add(panel29);
            panel6.Location = new Point(737, 12);
            panel6.Margin = new Padding(4, 3, 4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(606, 304);
            panel6.TabIndex = 15;
            // 
            // btnFix
            // 
            btnFix.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFix.Location = new Point(481, 220);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(112, 58);
            btnFix.TabIndex = 10;
            btnFix.Text = "Sửa";
            btnFix.UseVisualStyleBackColor = true;
            btnFix.Click += btnFix_Click;
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow.Location = new Point(337, 220);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(112, 58);
            btnShow.TabIndex = 9;
            btnShow.Text = "Xem";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnDel
            // 
            btnDel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDel.Location = new Point(181, 220);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(112, 58);
            btnDel.TabIndex = 8;
            btnDel.Text = "Xóa ";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(20, 220);
            button1.Name = "button1";
            button1.Size = new Size(112, 58);
            button1.TabIndex = 7;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // panel27
            // 
            panel27.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel27.Controls.Add(tbTypeAccount);
            panel27.Controls.Add(label2);
            panel27.Location = new Point(4, 122);
            panel27.Margin = new Padding(4, 3, 4, 3);
            panel27.Name = "panel27";
            panel27.Size = new Size(599, 54);
            panel27.TabIndex = 6;
            // 
            // tbTypeAccount
            // 
            tbTypeAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbTypeAccount.Location = new Point(205, 11);
            tbTypeAccount.Margin = new Padding(4, 3, 4, 3);
            tbTypeAccount.Name = "tbTypeAccount";
            tbTypeAccount.Size = new Size(275, 30);
            tbTypeAccount.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.Location = new Point(32, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 24);
            label2.TabIndex = 0;
            label2.Text = "Loại Account";
            // 
            // panel28
            // 
            panel28.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel28.Controls.Add(tbNameDisplay);
            panel28.Controls.Add(label3);
            panel28.Location = new Point(4, 62);
            panel28.Margin = new Padding(4, 3, 4, 3);
            panel28.Name = "panel28";
            panel28.Size = new Size(599, 54);
            panel28.TabIndex = 5;
            // 
            // tbNameDisplay
            // 
            tbNameDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbNameDisplay.Location = new Point(204, 14);
            tbNameDisplay.Margin = new Padding(4, 3, 4, 3);
            tbNameDisplay.Name = "tbNameDisplay";
            tbNameDisplay.Size = new Size(275, 30);
            tbNameDisplay.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(32, 14);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 0;
            label3.Text = "Tên Hiển thị";
            // 
            // panel29
            // 
            panel29.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel29.Controls.Add(tbNameAccount);
            panel29.Controls.Add(label4);
            panel29.Location = new Point(4, 3);
            panel29.Margin = new Padding(4, 3, 4, 3);
            panel29.Name = "panel29";
            panel29.Size = new Size(599, 54);
            panel29.TabIndex = 4;
            // 
            // tbNameAccount
            // 
            tbNameAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbNameAccount.Location = new Point(205, 12);
            tbNameAccount.Margin = new Padding(4, 3, 4, 3);
            tbNameAccount.Name = "tbNameAccount";
            tbNameAccount.Size = new Size(275, 30);
            tbNameAccount.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.Location = new Point(32, 15);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 24);
            label4.TabIndex = 0;
            label4.Text = "Tên đăng nhập";
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReset.BackColor = Color.SteelBlue;
            btnReset.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.Control;
            btnReset.Location = new Point(1120, 322);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(236, 60);
            btnReset.TabIndex = 13;
            btnReset.Text = "Đặt Lại Mật Khẩu";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // fAccount
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 595);
            Controls.Add(btnReset);
            Controls.Add(panel6);
            Controls.Add(dtgvAccount);
            Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "fAccount";
            Text = "fAccount";
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel6.ResumeLayout(false);
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel28.ResumeLayout(false);
            panel28.PerformLayout();
            panel29.ResumeLayout(false);
            panel29.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvAccount;
        private Panel panel6;
        private Button btnReset;
        private Panel panel27;
        private TextBox tbTypeAccount;
        private Label label2;
        private Panel panel28;
        private TextBox tbNameDisplay;
        private Label label3;
        private Panel panel29;
        private TextBox tbNameAccount;
        private Label label4;
        private Button btnFix;
        private Button btnShow;
        private Button btnDel;
        private Button button1;
    }
}