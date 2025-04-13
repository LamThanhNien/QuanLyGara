using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly
{
    public partial class fAccount : Form
    {
        public fAccount()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            DAO.AccountDAO.Instance.LoadAccount(dtgvAccount);
            dtgvAccount.RowPostPaint += dataGridView_RowPostPaint;

            dtgvAccount.Columns[0].HeaderText = "Tên hiển thị";
            dtgvAccount.Columns[1].HeaderText = "Tên Account";
            dtgvAccount.Columns[2].HeaderText = "Loại tài khoản";
            dtgvAccount.Columns[3].HeaderText = "idAccount";
            dtgvAccount_CellClick(null, new DataGridViewCellEventArgs(0, 0));
        }
        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            string stt = (e.RowIndex + 1).ToString();
            using (SolidBrush brush = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(stt,
                                      dgv.Font,
                                      brush,
                                      e.RowBounds.Location.X + 10,
                                      e.RowBounds.Location.Y + 4);
            }
        }
        int id = 0;
        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvAccount.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvAccount.Rows[e.RowIndex];
                tbNameDisplay.Text = row.Cells["DisplayName"].Value?.ToString();
                tbNameAccount.Text = row.Cells["UserName"].Value?.ToString();
                cbbTypeAccount.Text = row.Cells["CheckAdmin"].Value?.ToString() == "1"? "Admin": "Nhân Viên";
                id = Convert.ToInt32(row.Cells["idAccount"].Value?.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //string DisplayName = tbNameDisplay.Text;
            //string UserName = tbNameAccount.Text;
            //if(DAO.AccountDAO.Instance.GetUser(UserName)==1)
            //{
            //    MessageBox.Show("Tài Khoản đã tồn tại");
            //    return;
            //}    

            //int TypeAccount = Convert.ToInt32(tbTypeAccount.Text);
            //if (DAO.AccountDAO.Instance.AddAccount(DisplayName, UserName, TypeAccount)==-1)
            //{
            //    MessageBox.Show("Thêm Account Thất bại");
            //    return;
            //}
            //MessageBox.Show("Thêm Account Thành công");
            //Load();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //if(DAO.AccountDAO.Instance.DelAccount(id)==-1)
            //{
            //    MessageBox.Show("Xóa thất bại");
            //    return;
            //}
            //MessageBox.Show("xóa thành công");
            //Load();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            string DisplayName = tbNameDisplay.Text;
            string UserName = tbNameAccount.Text;
            int TypeAccount = cbbTypeAccount.Text == "Admin"? 1 : 2;
            if (DAO.AccountDAO.Instance.FixAccount(id, DisplayName,UserName, TypeAccount) == -1)
            {
                MessageBox.Show("Cập nhật Account thất bại");
                return;
            }
            MessageBox.Show("Cập nhật Account thành công");
            Load();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (DAO.AccountDAO.Instance.Resetpasswword(id) == -1)
            {
                MessageBox.Show("Cập nhật mật khẩu thất bại");
                return;
            }
            MessageBox.Show("Cập nhật mật khẩu thành công");
            Load();
        }
    }
}
