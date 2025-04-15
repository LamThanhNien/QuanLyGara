using Quanly.DTO;
using Quanly.BUS;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            List<DTO.Service> dt = ServiceBUS.Instance.LoadDLByThanhToan();
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
            string price = "0";
            if (ServiceBUS.Instance.themDichvu(name, price)==-1)
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
            MessageBox.Show("Thêm Thành Công");
            this.Close();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (ServiceBUS.Instance.CheckServiceInBillInfo(id)>0)
            {
                MessageBox.Show("Dịch vụ bạn chọn đang ở trong quá trình thanh toán vui lòng thanh toán trước khi xóa");
                return;
            }
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa không", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ServiceBUS.Instance.DelDichvu(id))
                    {
                        loadcbbName();
                        return;
                    }
                    MessageBox.Show("Xóa dịch vụ thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng xóa sản phẩm thuộc dịch vụ trước khi xóa dịch vụ");
            }
        }
    }
}
