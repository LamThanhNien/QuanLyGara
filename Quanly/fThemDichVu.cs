using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quanly
{
    public partial class fThemDichVu : Form
    {
        public fThemDichVu()
        {
            InitializeComponent();
            loadcbbName();
        }
        public void loadcbbName()
        {
            List<DTO.Service> dt = DAO.ServiceDAO.Instance.LoadDLByThanhToan();
            cbbname.DataSource = dt;
            cbbname.DisplayMember = "name";
        }
        public int id = 0;
        private void cbbname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbname.SelectedItem == null) return;
            id = (cbbname.SelectedItem as DTO.Service).Id;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = tbname.Text;
            string price = tbPrice.Text;
            string query = "INSERT INTO _Service (name, price) VALUES( @name , @price );";
            if (DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, price }) == 0)
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
            MessageBox.Show("Thêm Thành Công");
            this.Close();
            //fDichVu fDich = new fDichVu();
            //fDich.fDichVu_Load(this, EventArgs.Empty);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (DAO.ServiceDAO.Instance.CheckDichvu_in_Billinfo(id)>0)
            {
                MessageBox.Show("Dịch vụ bạn chọn đang ở trong quá trình thanh toán vui lòng thanh toán trước khi xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa không","thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (DAO.ServiceDAO.Instance.DelDichvu(id)== 1)
                {
                    loadcbbName();
                    return;
                }
                MessageBox.Show("Xóa dịch vụ thất bại");
            }    
        }
    }
}
