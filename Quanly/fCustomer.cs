using Quanly.DAO;
using Quanly.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Quanly
{
    public partial class fCustomer : Form
    {
        public fCustomer()
        {
            InitializeComponent();
        }
        #region Control
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnlTitleBar_MouseDown_MouseDown(object sender, MouseEventArgs e)
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
        private void fCustomer_Load(object sender, EventArgs e)
        {
            loadCustomer();
            //dtgvCustomer_CellClick(null, new DataGridViewCellEventArgs(0, 0));

        }
        void loadCustomer()
        {
            DAO.CustomerDAO.Instance.LoadDLByCustomer(dtgvCustomer);
            dtgvCustomer.RowPostPaint += dataGridView_RowPostPaint;
            dtgvCustomer.Columns[0].Width = 170;
            dtgvCustomer.Columns[0].HeaderText = "Tên Khách hàng";
            dtgvCustomer.Columns[1].HeaderText = "Giới tính";
            dtgvCustomer.Columns[2].HeaderText = "Địa chỉ";
            dtgvCustomer.Columns[3].HeaderText = "Số điện thoại";
            dtgvCustomer.Columns[4].HeaderText = "Tên xe";
            dtgvCustomer.Columns[5].HeaderText = "Số xe";
            dtgvCustomer.Columns[6].HeaderText = "Hãng xe";
            dtgvCustomer.Columns[7].HeaderText = "Màu xe";

            dtgvCustomer.Columns[8].Visible = false;
            dtgvCustomer.Columns[9].Visible = false;
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


        private int idKhach;
        public fCustomer(int idCustomer, string nameCustomer, string phone, string address)
        {
            InitializeComponent();
            this.idKhach = idCustomer;
            tbCustomer.Text = nameCustomer;
            tbphone.Text = phone;
            tbAddress.Text = address;
        }
        private void lbSearch_Click(object sender, EventArgs e)
        {
            List<DTO.Customer_Car> listCustomer = DAO.Search.Instance.searchCustomer(textBoxTim.Text);
            var displayList = listCustomer.Select(c => new
            {
                c.NameCtm, Sex = c.Sex == 0 ? "Nam" : "Nữ",c.Address,c.Phone,c.NameCar,c.NumCar,c.Hang,c.Color,c.Image, c.IdCustomer
            }).ToList();
            dtgvCustomer.DataSource = displayList;
            if(listCustomer==null)
            {
                tbCustomer.Text = "";
                tbAddress.Text = "";
                tbphone.Text = "";
                tbNamcar.Text = "";
                tbNumcar.Text = "";
                tbColor.Text = "";
                txthang.Text = "";
                pictureBoxCar.Image = null;
                pictureBoxCar.Tag = null;
                tbCustomer.Focus();
            }    
            dtgvCustomer_CellClick(null, new DataGridViewCellEventArgs(0, 0));
        }
        private int idCtm;
        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvCustomer.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvCustomer.Rows[e.RowIndex];
                tbCustomer.Text = row.Cells["NameCtm"].Value?.ToString();
                comboBoxSex.Text = row.Cells["Sex"].Value?.ToString();
                tbAddress.Text = row.Cells["Address"].Value?.ToString();
                tbphone.Text = row.Cells["Phone"].Value?.ToString();
                tbNamcar.Text = row.Cells["NameCar"].Value?.ToString();
                tbNumcar.Text = row.Cells["NumCar"].Value?.ToString();
                txthang.Text = row.Cells["Hang"].Value?.ToString();
                tbColor.Text = row.Cells["Color"].Value?.ToString();
                string imagePath = row.Cells["Image"].Value?.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBoxCar.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBoxCar.Image = null;
                }
                idCtm = Convert.ToInt32(row.Cells["idCustomer"].Value?.ToString());
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg",
                Title = "Chọn ảnh"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBoxCar.Image = Image.FromFile(filePath);
                pictureBoxCar.Tag = filePath;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadCustomer();
            dtgvCustomer_CellClick(null, new DataGridViewCellEventArgs(0, 0));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string filePath = pictureBoxCar.Tag as string ?? "";
            if (!check_thongtin()) return;
            if (CustomerDAO.Instance.checkNumBerCar(tbNumcar.Text))
            {
                MessageBox.Show("Xe đã tồn tại, vui lòng nhập biển số xe khác", "thông báo", MessageBoxButtons.OK);
                tbNumcar.Focus();
                return;
            }
            else if (!insert(idKhach, tbCustomer.Text, tbAddress.Text, tbphone.Text, tbNamcar.Text, tbNumcar.Text, txthang.Text, tbColor.Text, filePath))
            {
                MessageBox.Show("Quá trình thêm đã thất bại do nguyên nhân không rõ", "thông báo", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Đã thêm khách hàng", "thông báo", MessageBoxButtons.OK);
            loadCustomer();
        }
        public bool insert(int idKhach, string name, string address, string numberphone, string namecar, string numcar, string hang, string logo, string filePath)
        {
            if (!DAO.CustomerDAO.Instance.checkidKhach(idKhach))
            {
                return DAO.CustomerDAO.Instance.AddCustomer(name, address, numberphone, namecar, numcar, hang, logo, filePath);
            }
            return DAO.CustomerDAO.Instance.AddCar_Customer(idKhach, name, address, numberphone, namecar, numcar, hang, logo, filePath);
        }
        public bool check_thongtin()
        {
            if (tbCustomer.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên Khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCustomer.Focus();
                return false;
            }

            if (comboBoxSex.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxSex.Focus();
                return false;
            }
            if (tbAddress.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbAddress.Focus();
                return false;
            }
            if (tbphone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbphone.Focus();
                return false;
            }
            if (tbNamcar.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên xe", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNamcar.Focus();
                return false;
            }
            if (tbNumcar.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNumcar.Focus();
                return false;
            }
            if (pictureBoxCar.Image == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh xe!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {

            int id = idCtm;
            if(id == 0)
            {
                MessageBox.Show("Vui lòng chọn đối tượng");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này chứ!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(DAO.CustomerDAO.Instance.DeleteCtn_Car(id)!=1)
                {
                    MessageBox.Show("Xóa thất bại vui lòng thử lại");
                }
                MessageBox.Show("Xóa thành công");
                loadCustomer();
                tbCustomer.Text = "";
                tbAddress.Text = "";
                tbphone.Text = "";
                tbNamcar.Text = "";
                tbNumcar.Text = "";
                tbColor.Text = "";
                txthang.Text = "";
                pictureBoxCar.Image = null;
                pictureBoxCar.Tag = null;
                tbCustomer.Focus();
            }
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            int idCustomer = idCtm;
            string name = tbCustomer.Text;
            int sex = comboBoxSex.Text == "Nam" ? 0 : 1;
            string address = tbAddress.Text;
            string phone = tbphone.Text;
            string nameCar = tbNamcar.Text;
            string numCar = tbNumcar.Text;
            string color = tbColor.Text;
            string hang = txthang.Text;
            string imagePath = pictureBoxCar.Tag as string ?? "";

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBoxCar.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBoxCar.Image = null;
            }

            int result = DAO.CustomerDAO.Instance.FixCustomer_Car(idCustomer, name, sex, address, phone, nameCar, numCar, color, hang, imagePath);
            if (result == 0)
            {
                MessageBox.Show("Cập nhật thất bại");
                return;
            }
            MessageBox.Show("cập nhật thành công");
            loadCustomer();
        }

    }
}
