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
        private void dtgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0 && dtgvEmployee.Rows.Count>0)
            {
                DataGridViewRow row = dtgvEmployee.Rows[e.RowIndex];
                tbName.Text = row.Cells["Name"].Value?.ToString();
                tbPhone.Text = row.Cells["Phone"].Value?.ToString();
                tbChucvu.Text = row.Cells["Chucvu"].Value?.ToString();
                tbLuong.Text = row.Cells["Luong"].Value?.ToString();
                tbDay.Text = row.Cells["Day"].Value?.ToString();
                checkBoxOut.Checked = Convert.ToInt32(row.Cells["Checkout"].Value?.ToString()) == 1 ? true : false;
                cbbType.Text = Convert.ToInt32(row.Cells["CheckAccount"].Value?.ToString()) == 2 ? "Nhân viên" : "Admin";
            }
        }
    }
}
