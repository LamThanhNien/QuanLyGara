using Quanly.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
                c.Color,
                cs.idCustomer
            FROM Customer cs 
            INNER JOIN Car c ON cs.idCustomer = c.idCustomer
            ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<ThanhToan> listTT = new List<ThanhToan>();
            foreach (DataRow row in data.Rows)
            {
                DTO.ThanhToan Item = new DTO.ThanhToan(row);
                listTT.Add(Item);
            }
            dtgvCustomer.DataSource = listTT;
        }

        public int ThanhToan(int idBill)
        {
            string query = "USP_ThanhToan @idBill";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill });
            return (result != null) ? result : -1;
        }
    }
}
