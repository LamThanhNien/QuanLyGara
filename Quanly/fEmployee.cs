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
    public partial class fEmployee : Form
    {
        public fEmployee()
        {
            InitializeComponent();
        }
        void load()
        {
            DAO.EmployeeDAO.Instance.loadEmployee(dtgvEmployee);
        }
        private void fEmployee_Load(object sender, EventArgs e)
        {
            load();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DTO.Employee> listCar = DAO.Search.Instance.searchEmployeebyname(tbSearch.Text);
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
                tbDay.Text = row.Cells["Day"].Value?.ToString();
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
            DateTime day = DateTime.Parse(tbDay.Text);

            int checkuot = checkBoxOut.Checked == true ? 1 : 0;
            if (DAO.EmployeeDAO.Instance.AddEmployee(name, phone, chucvu, luong, day, checkuot) == 1)
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
            DateTime day = DateTime.Parse(tbDay.Text);

            int checkuot = checkBoxOut.Checked == true ? 1 : 0;
            DAO.EmployeeDAO.Instance.FixEmployee(id, typeAccount, name, phone, chucvu, luong, day, checkuot);
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = idEmployee;
            if (MessageBox.Show("Bạn có chắc muốn cóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DAO.EmployeeDAO.Instance.DelEmployee(id) == -1)
                {
                    MessageBox.Show("Xóa Thất bại");
                    return;
                }
                load();
            }
        }
    }
}
