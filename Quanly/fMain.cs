using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



namespace Quanly
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            OpenChillldForm(new fThanhToan());
        }

        #region Control
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnlTitleBar_MouseDown_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Di chuyển form
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn đóng ứng dụng không","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnMaxsize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btnMax_Normal.Text = "❐";
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                btnMax_Normal.Text = "⬜";
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Thu nhỏ Form
        }
        #endregion

        private Form currentFormChild;
        private void OpenChillldForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelbody.Controls.Add(childForm);
            panelbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChillldForm(new fCustomer());
            label1.Text = "Khách Hàng";
        }
        private void btnCar_Click(object sender, EventArgs e)
        {
            OpenChillldForm(new fCar());
            label1.Text = "Thông tin Xe";
        }
        private void btnDichvu_Click(object sender, EventArgs e)
        {
            OpenChillldForm(new fDichVu());
            label1.Text = "Dịch vụ và phụ tùng";
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            OpenChillldForm(new QLThongKe());

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                OpenChillldForm(new fThanhToan());
            }
            label1.Text = "Thanh Toán Hóa Đơn";
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChillldForm(new fEmployee());
            label1.Text = "Quản Lý Nhân Viên";
        }
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            OpenChillldForm(new fThanhToan());
            label1.Text = "Thanh Toán Hóa Đơn";
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có đăng xuất chứ", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnEmployee.Visible = false;
                btnThongke.Visible = false;
                tbUsername.Text = "Xin chào";
                btnLogout.Visible = false;
                Exit.Enabled = false;
            }
        }
        private void cậpNhậtThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile fAccount = new fAccountProfile();
            fAccount.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có đăng xuất chứ","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                btnEmployee.Visible = false;
                btnThongke.Visible = false;
                tbUsername.Text = "Xin chào";
                btnLogout.Visible = false;
                Exit.Enabled = false;
            }    
        }
    }
}
