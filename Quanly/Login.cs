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
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Thu nhỏ Form
        }
        #endregion

        private async void Login_Load(object sender, EventArgs e)
        {
            fMain fMain = new fMain();
            fMain.Close();
            await Task.Delay(100);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbname.Text) || string.IsNullOrEmpty(tbpassword.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                tbname.Focus();
                return;
            }
            if (checkLogin(tbname.Text, tbpassword.Text))
            {
                DTO.Account loginAc = DAO.AccountDAO.Instance.CheckAccount(tbname.Text);
                int check = loginAc.CheckAdmin;
                //fMain mainForm = Application.OpenForms["fMain"] as fMain;
                //if (mainForm != null)
                //{
                //}
                fMain fMain = new fMain(check, tbname.Text, tbpassword.Text);
                fAccountProfile fAccountProfile = new fAccountProfile(tbname.Text, tbpassword.Text);
                tbpassword.Text = "";
                this.Hide();
                fMain.ShowDialog();
                this.Show();
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

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chứ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbpassword.UseSystemPasswordChar = CheckBoxShow.Checked ? false : true;

        }
    }
}
