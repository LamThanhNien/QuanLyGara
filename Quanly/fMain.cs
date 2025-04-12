using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quanly
{
    public partial class fMain : Form
    {
        int progress = 0;
        public fMain()
        {
            InitializeComponent();
        }
        string Username = "";
        string Password = "";
        public fMain(int check, string Username, string password)
        {
            InitializeComponent();
            this.Username = Username;
            this.Password = password;
            Phanquyen(check);
        }
        public void Phanquyen(int check)
        {
            btnLogout.Visible = true;
            Exit.Enabled = true;
            if (check == 1)
            {
                btnEmployee.Visible = (check == 1);
                btnAccount.Visible = (check == 1);
                btnThongke.Visible = (check == 1);
                phânQuyềnToolStripMenuItem.Visible = (check == 1);
            }
        }
        private async void fMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            tbUsername.Text = string.Format("Xin chào {0}", DAO.AccountDAO.Instance.GetDislayName(this.Username));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 10;
            if (progress > 100)
                progress = 100;
            progressBar1.Value = progress;
            if (progress <= 30)
                label1.Text = "Đang khởi động hệ thống...";
            else if (progress <= 60)
                label1.Text = "Đang kết nối cơ sở dữ liệu...";
            else if (progress <= 90)
                label1.Text = "Đang chuẩn bị giao diện...";
            else
                label1.Text = "Hoàn tất. Đang mở ứng dụng...";

            if (progress >= 100)
            {
                timer1.Stop();
                progressBar1.Visible = false;
                label1.Text = "Thanh Toán Hóa Đơn";
                OpenChildForm(new fThanhToan());
            }
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                if (currentFormChild.GetType() == childForm.GetType())
                    return;

                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelbody.Controls.Clear();
            panelbody.Controls.Add(childForm);
            panelbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCustomer());
            label1.Text = "Khách Hàng";
        }
        private void btnCar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCar());
            label1.Text = "Thông tin Xe";
        }
        private void btnDichvu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDichVu());
            label1.Text = "Dịch vụ và phụ tùng";
        }
        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fAccount());
            label1.Text = "Quản lý tài khoản";
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLThongKe());
            label1.Text = "";

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (currentFormChild != null)
            //{
            //    currentFormChild.Close();
            //    OpenChildForm(new fThanhToan());
            //}
            //label1.Text = "Thanh Toán Hóa Đơn";
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fEmployee());
            label1.Text = "Quản Lý Nhân Viên";
        }
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThanhToan());
            label1.Text = "Thanh Toán Hóa Đơn";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đăng xuất chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile fAccount = new fAccountProfile(Username, Password);
            this.Hide();
            fAccount.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đăng xuất chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
