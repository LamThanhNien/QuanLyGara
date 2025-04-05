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
    public partial class fThemDichVu : Form
    {
        public fThemDichVu()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = tbname.Text;
            string price = tbPrice.Text;
            string query = "USP_AddService @name , @price ";
            if(DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, price })==0)
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
            MessageBox.Show("Thêm Thành Công");
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
