using Quanly.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanly
{
    public partial class fCar : Form
    {
        public fCar()
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

        void loadCar()
        {
            DAO.CarDAO.Instance.LoadDL(dtgvCar);
            dtgvCar.RowPostPaint += dataGridView_RowPostPaint;
            dtgvCar_CellClick(null, new DataGridViewCellEventArgs(0, 0));

            dtgvCar.Columns[0].Width = 170;
            dtgvCar.Columns[0].HeaderText = "Tên Khách hàng";
            dtgvCar.Columns[1].HeaderText = "Tên xe";
            dtgvCar.Columns[2].HeaderText = "Số xe";
            dtgvCar.Columns[3].HeaderText = "Màu xe";
            dtgvCar.Columns[4].HeaderText = "Hãng xe";
            dtgvCar.Columns[5].HeaderText = "Số điện thoại";

            dtgvCar.Columns[6].Visible = false;
            dtgvCar.Columns[7].Visible = false;
            dtgvCar.Columns[8].Visible = false;
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

        private void fCar_Load(object sender, EventArgs e)
        {
            loadCar();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DTO.Car> listCar = DAO.Search.Instance.searchCarbyname(tbTimCar.Text);
            dtgvCar.DataSource = listCar;
            if (listCar == null)
            {
                tbCustomer.Text = "";
                tbPhone.Text = "";
                tbNameCar.Text = "";
                tbNumCar.Text = "";
                tbColor.Text = "";
                tbHang.Text = "";
                pictureBoxCar.Image = null;
                pictureBoxCar.Tag = null;
                tbCustomer.Focus();
            }
            dtgvCar_CellClick(null, new DataGridViewCellEventArgs(0, 0));
        }
        private int idCar;
        private int idCustomer;
        private void dtgvCar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvCar.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvCar.Rows[e.RowIndex];
                tbCustomer.Text = row.Cells["NameCustomer"].Value?.ToString();
                tbPhone.Text = row.Cells["phoneNum"].Value?.ToString();
                tbNameCar.Text = row.Cells["Namecar"].Value?.ToString();
                tbNumCar.Text = row.Cells["NumberCar"].Value?.ToString();
                tbHang.Text = row.Cells["Hang"].Value?.ToString();
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
                idCar = Convert.ToInt32(row.Cells["IdCar"].Value?.ToString());
                idCustomer = Convert.ToInt32(row.Cells["IdCtm"].Value?.ToString());
            }
        }
        private void btnAddImage1_Click(object sender, EventArgs e)
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            loadCar();
            dtgvCar_CellClick(null, new DataGridViewCellEventArgs(0, 0));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = idCar;
            if(id == 0)
            {
                MessageBox.Show("Vui lòng chọn Xe");
                return;
            }
            if (MessageBox.Show("Bạn Có Muốn Xóa XE này chứ !", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (DAO.CarDAO.Instance.DeleteCar(id) != 1)
                {
                    MessageBox.Show("Xóa Thất bại");
                    return;
                }
                MessageBox.Show("Xóa Thành Công");
                loadCar();
                tbCustomer.Text = "";
                tbPhone.Text = "";
                tbNameCar.Text = "";
                tbNumCar.Text = "";
                tbColor.Text = "";
                tbHang.Text = "";
                pictureBoxCar.Image = null;
                pictureBoxCar.Tag = null;
                tbCustomer.Focus();
            }

        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            int idCarr = idCar;
            if (idCar == -1) { MessageBox.Show("Không tìm thấy xe"); return; }

            string name = tbNameCar.Text;
            string numcar = tbNumCar.Text;
            string hang = tbHang.Text;
            string color = tbColor.Text;
            string image = pictureBoxCar.Tag as string ?? "";
            if(DAO.CarDAO.Instance.FixCar(idCarr, name, numcar, color, hang, image)==0)
            {
                MessageBox.Show("Cập nhật thất bại");
                return;
            }    
            loadCar();
        }
        private void AddCar_Click(object sender, EventArgs e)
        {
            int id = idCustomer;
            if(id==0)
            {
                MessageBox.Show("Vui lòng chọn xe");
                return;
            } 
            string nameCar = tbNameCar.Text;
            string numCar = tbNumCar.Text;
            string color = tbColor.Text;
            string image = pictureBoxCar.Tag as string ?? "";
            string hang = tbHang.Text;

            if (CustomerDAO.Instance.checkNumBerCar(numCar))
            {
                MessageBox.Show("Xe đã tồn tại, vui lòng nhập biển số xe khác", "thông báo", MessageBoxButtons.OK);
                return;
            }
            if (DAO.CarDAO.Instance.AddCar(id, nameCar, numCar, color, image, hang)==0)
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
            MessageBox.Show("Thêm Thành công");
            loadCar();
            dtgvCar_CellClick(null, new DataGridViewCellEventArgs(0, 0));

        }
    }

}
