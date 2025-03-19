using Quanly.DAO;
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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            loadDt();
            loadCar();
            loadCustomer();
            load_Service();
            loadAccount();
        }
        //load data
        void loadAccount()
        {
            string query = "SELECT * FROM Account";
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadDt()
        {
            string query = "SELECT * FROM Revenue";
            dtgvDt.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvDt.Columns[0].Width = 40;
            dtgvDt.Columns[0].HeaderText = "Stt";
            dtgvDt.Columns[1].Width = 40;
            dtgvDt.Columns[1].HeaderText = "ID bill";
            dtgvDt.Columns[2].Width = 400;
            dtgvDt.Columns[2].HeaderText = "Tổng doanh thu";
            dtgvDt.Columns[3].Width = 800;
            dtgvDt.Columns[3].HeaderText = "Ngày ghi nhận";
        }
        void loadCar()
        {
            string query = "SELECT * FROM Car";
            dtgvCar.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void loadCustomer()
        {
            string query = "SELECT * FROM Customer";
            dtgvCustomer.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        void load_Service()
        {
            string query = "SELECT * FROM _Service";
            dtgvDv.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        //
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAccountProfile fAp = new fAccountProfile();
            fAp.ShowDialog();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            //this.Owner?.Show();
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            Search.searchDataGridView(dtgvCar, "numberCar", textBoxTim.Text);
        }
    }
}
