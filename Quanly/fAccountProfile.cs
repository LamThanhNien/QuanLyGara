using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly
{
    public partial class fAccountProfile : Form
    {
        public fAccountProfile()
        {
            InitializeComponent();
        }
        string Username;
        public string luuUser;
        public fAccountProfile(string User, string password)
        {
            InitializeComponent();
            tbUser.Text = User;
            luuUser = User;
            this.Username = User;
            tbPasswordOld.Text = password;
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
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Thu nhỏ Form
        }
        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {
            tbDispayname.Text = DAO.AccountDAO.Instance.GetDislayName(Username);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            string Display = tbDispayname.Text;
            string User = tbUser.Text;
            string pwOld = tbPasswordOld.Text;
            string pwNew = tbPasswordNew.Text;
            string pwre = tbPasswordre.Text;
            if (DAO.AccountDAO.Instance.CheckUserInAccount(User) == 0)
            {
                DAO.AccountDAO.Instance.SaveUser(User ,luuUser);
            }
            else
            {
                MessageBox.Show("Tên Đăng nhập đã được dùng, vui lòng chọn tên đăng nhập khác");
                return;
            }
            if (pwNew != pwOld)
            {
                if (pwre != pwNew)
                {
                    MessageBox.Show("Không khớp vui lòng nhập lại");
                    tbPasswordre.Focus();
                    return;
                }
                if (pwNew == "" && pwre == "")
                {
                    pwNew = pwOld;
                }
                if (DAO.AccountDAO.Instance.UpdateAccount(Display, User, pwNew) == -1)
                {
                    MessageBox.Show("Cập nhật thông tin Không thành công");
                    return;
                }
                MessageBox.Show("Cập nhật thông tin thành công");

                fMain mainForm = Application.OpenForms["fMain"] as fMain;
                if (mainForm != null)
                {
                    //this.Close();
                    this.Hide();
                    mainForm.Close();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng tạo một mật khẩu khác mật khẩu này");
                tbPasswordNew.Focus();
            }

        }
    }
}
