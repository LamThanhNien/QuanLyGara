using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DAO
{
    public class ThanhToanDAO
    {
        private static ThanhToanDAO instance;
        public static ThanhToanDAO Instance 
        {
            get
            {
                if (instance == null)
                    instance = new ThanhToanDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private ThanhToanDAO() { }
        public void LoadDL(DataGridView dtgvCustomer)
        {
            string query = @"
            SELECT 
                cs.name, 
                cs.address, 
                cs.phoneNum, 
                c.name AS namecar, 
                c.numberCar, 
                c.logo,
                cs.idCustomer
            FROM Customer cs 
            INNER JOIN Car c ON cs.idCustomer = c.idCustomer
            ";
            dtgvCustomer.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtgvCustomer.Columns[0].Width = 250;
            dtgvCustomer.Columns[0].HeaderText = "Tên Khách hàng";
            dtgvCustomer.Columns[1].Width = 300;
            dtgvCustomer.Columns[1].HeaderText = "Địa chỉ";
            dtgvCustomer.Columns[2].Width = 150;
            dtgvCustomer.Columns[2].HeaderText = "Số điện thoại";
            dtgvCustomer.Columns[3].Width = 150;
            dtgvCustomer.Columns[3].HeaderText = "Tên xe";
            dtgvCustomer.Columns[4].Width = 150;
            dtgvCustomer.Columns[4].HeaderText = "Số xe";
            dtgvCustomer.Columns[5].Width = 150;
            dtgvCustomer.Columns[5].HeaderText = "Tên hãng";
        }
        public int ThanhToan(int idBill)
        {
            string query = "USP_ThanhToan @idBill";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill });
            return (result != null) ? result : -1;
        }
    }
}
