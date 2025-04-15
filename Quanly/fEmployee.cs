using Quanly.DTO;
using Quanly.BUS;
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
    public partial class fEmployee : Form
    {
        public fEmployee()
        {
            InitializeComponent();
        }
        void load()
        {
            dtgvEmployee.DataSource = EmployeeBUS.Instance.loadEmployee();
            dtgvEmployee_CellClick(null, new DataGridViewCellEventArgs(0, 0));
            dtgvEmployee.RowPostPaint += dataGridView_RowPostPaint;
            dtgvEmployee.Columns[0].Width = 170;
            dtgvEmployee.Columns[0].HeaderText = "Tên Nhân viên";
            dtgvEmployee.Columns[1].HeaderText = "Số điện thoại";
            dtgvEmployee.Columns[2].HeaderText = "Chức vụ";
            dtgvEmployee.Columns[3].HeaderText = "Lương";
            dtgvEmployee.Columns[4].HeaderText = "Ngày vào";
            dtgvEmployee.Columns[5].HeaderText = "Trạng thái làm";
            dtgvEmployee.Columns[6].HeaderText = "Loại tài khoản";
            dtgvEmployee.Columns[7].HeaderText = "ID";


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
        private void fEmployee_Load(object sender, EventArgs e)
        {
            load();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DTO.Employee> listCar = SearchBUS.Instance.searchEmployeebyname(tbSearch.Text);
            dtgvEmployee.DataSource = listCar;
            dtgvEmployee_CellClick(null, new DataGridViewCellEventArgs(0, 0));
        }
        int idEmployee = 0;
        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvEmployee.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvEmployee.Rows[e.RowIndex];
                tbName.Text = row.Cells["Name"].Value?.ToString();
                tbPhone.Text = row.Cells["Phone"].Value?.ToString();
                tbChucvu.Text = row.Cells["Chucvu"].Value?.ToString();
                tbLuong.Text = row.Cells["Luong"].Value?.ToString();
                dtpkDay.Text = row.Cells["Day"].Value?.ToString();
                checkBoxOut.Checked = Convert.ToInt32(row.Cells["Checkout"].Value?.ToString()) == 1 ? true : false;
                cbbType.Text = Convert.ToInt32(row.Cells["CheckAccount"].Value?.ToString()) == 2 ? "Nhân viên" : "Admin";
                idEmployee = Convert.ToInt32(row.Cells["IdEmployee"].Value?.ToString());
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            load();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string chucvu = tbChucvu.Text;
            double luong = Convert.ToDouble(tbLuong.Text);
            DateTime day = DateTime.Parse(dtpkDay.Text);

            int checkuot = checkBoxOut.Checked == true ? 1 : 0;
            if (EmployeeBUS.Instance.AddEmployee(name, phone, chucvu, luong, day, checkuot) == 1)
            {
                MessageBox.Show("Thêm thành công");
                load();
            }
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            int id = idEmployee;
            int typeAccount = string.Equals(cbbType.Text, "Admin", StringComparison.OrdinalIgnoreCase) ? 1 : 2;
            string name = tbName.Text;
            string phone = tbPhone.Text;
            string chucvu = tbChucvu.Text;
            double luong = Convert.ToDouble(tbLuong.Text);
            DateTime day = DateTime.Parse(dtpkDay.Text);

            int checkuot = checkBoxOut.Checked == true ? 1 : 0;
            EmployeeBUS.Instance.FixEmployee(id, typeAccount, name, phone, chucvu, luong, day, checkuot);
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = idEmployee;
            if (MessageBox.Show("Bạn có chắc muốn cóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (EmployeeBUS.Instance.DelEmployee(id) == -1)
                {
                    MessageBox.Show("Xóa Thất bại");
                    return;
                }
                load();
            }
        }
    }
}
