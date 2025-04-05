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
            label1 = new Label();
            panel1 = new Panel();
            tbPrice = new TextBox();
            tbname = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 33);
            label1.Name = "label1";
            label1.Size = new Size(277, 29);
            label1.TabIndex = 0;
            label1.Text = "Nhập thông tin dịch vụ";
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
            panel1.Location = new Point(12, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 247);
            panel1.TabIndex = 1;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(390, 98);
            tbPrice.Multiline = true;
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(226, 37);
            tbPrice.TabIndex = 12;
            // 
            // tbname
            // 
            tbname.Location = new Point(72, 98);
            tbname.Multiline = true;
            tbname.Name = "tbname";
            tbname.Size = new Size(226, 37);
            tbname.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(512, 177);
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
            button1.Location = new Point(346, 177);
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 40);
            label2.Name = "label2";
            label2.Size = new Size(148, 29);
            label2.TabIndex = 0;
            label2.Text = "Tên dịch vụ";
            // 
            // fThemDichVu
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(711, 409);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "fThemDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm dịch vụ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox tbPrice;
        private TextBox tbname;
        private Button button2;
    }
}