using System.Data;
using System.Data.SqlClient;
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbname.Text) || string.IsNullOrEmpty(tbpassword.Text))
            {
                MessageBox.Show("Vui long điền đầy đủ thông tin");
            }
            if (checkLogin(tbname.Text, tbpassword.Text))
            {
                this.Hide();
                fManage fManage = new fManage();
                fManage.ShowDialog();
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
