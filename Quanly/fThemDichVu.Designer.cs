namespace Quanly
{
    partial class fThemDichVu
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
            panel1 = new Panel();
            tbPrice = new TextBox();
            tbname = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            cbbname = new ComboBox();
            panel2 = new Panel();
            btnDel = new Button();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tbPrice);
            panel1.Controls.Add(tbname);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 232);
            panel1.TabIndex = 1;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(390, 98);
            tbPrice.Multiline = true;
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(281, 37);
            tbPrice.TabIndex = 12;
            tbPrice.Visible = false;
            // 
            // tbname
            // 
            tbname.Location = new Point(72, 98);
            tbname.Multiline = true;
            tbname.Name = "tbname";
            tbname.Size = new Size(281, 37);
            tbname.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(249, 177);
            button2.Name = "button2";
            button2.Size = new Size(104, 38);
            button2.TabIndex = 10;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnHuy_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(71, 177);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 9;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 40);
            label3.Name = "label3";
            label3.Size = new Size(52, 29);
            label3.TabIndex = 1;
            label3.Text = "Giá";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 40);
            label2.Name = "label2";
            label2.Size = new Size(200, 29);
            label2.TabIndex = 0;
            label2.Text = "Tên dịch vụ mới";
            // 
            // cbbname
            // 
            cbbname.FormattingEnabled = true;
            cbbname.Location = new Point(72, 70);
            cbbname.Name = "cbbname";
            cbbname.Size = new Size(281, 37);
            cbbname.TabIndex = 13;
            cbbname.SelectedIndexChanged += cbbname_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(cbbname);
            panel2.Controls.Add(btnDel);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(688, 140);
            panel2.TabIndex = 14;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.DeepSkyBlue;
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(403, 70);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(98, 38);
            btnDel.TabIndex = 9;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 16);
            label5.Name = "label5";
            label5.Size = new Size(149, 29);
            label5.TabIndex = 0;
            label5.Text = "Xóa dịch vụ";
            // 
            // fThemDichVu
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(711, 391);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fThemDichVu";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm dịch vụ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox tbPrice;
        private TextBox tbname;
        private Button button2;
        private ComboBox cbbname;
        private Panel panel2;
        private Button btnDel;
        private Label label5;
    }
}