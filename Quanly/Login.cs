using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quanly
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Control
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnlTitleBar_MouseDown_MouseDown_1(object sender, MouseEventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbname.Text) || string.IsNullOrEmpty(tbpassword.Text))
            {
                MessageBox.Show("Vui long điền đầy đủ thông tin");
            }
            DTO.Account loginAc = DAO.AccountDAO.Instance.GetAccount(tbname.Text);
            int check = loginAc.CheckAdmin;
            if (checkLogin(tbname.Text, tbpassword.Text))
            {
                //MessageBox.Show(check+"");
                fMain mainForm = Application.OpenForms["fMain"] as fMain;
                if (mainForm != null)
                {
                    mainForm.btnEmployee.Visible = (check == 1);
                    mainForm.btnThongke.Visible = (check == 1);
                    mainForm.tbUsername.Text = "Xin Chào "+ tbname.Text;
                    mainForm.btnLogout.Visible = true;

                    mainForm.phânQuyềnToolStripMenuItem.Visible = (check == 1);
                    mainForm.Exit.Enabled = true;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool checkLogin(string username, string password)
        {
            return DAO.AccountDAO.Instance.Login(username, password);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbpassword.PasswordChar = rbtnShow.Checked ? '\0' : '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbpassword.UseSystemPasswordChar = CheckBoxShow.Checked ? false : true;

        }
    }
}
