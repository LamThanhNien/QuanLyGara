using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance 
        {
            get { 
                if (instance == null)
                instance = new BillDAO();
                return instance;
            }
            set { instance = value; }
        }
        private BillDAO() { }
        public int GetuncheckBillID(int idBill)
        {
            string query = "SELECT * FROM Bill WHERE idCustomer  = @id AND status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idBill });

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.Id;
            }
            return -1;
        }

        public int InsertBill(int idCustomer)
        {
            object result =  DataProvider.Instance.ExecuteScalar(" USP_InsertBill @idTable ", new object[] { idCustomer });
            return (result != null) ? Convert.ToInt32(result) : -1;
        }
        public int GetIdBill(int idCustomer)
        {
            string query = "SELECT idBill FROM Bill WHERE idCustomer = @idCustomer";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { idCustomer });

            return (result != null) ? Convert.ToInt32(result) : -1;
        }
        public int GetStatus(int idCustomer)
        {
            string query = "SELECT status FROM Bill WHERE idCustomer = @idCustomer";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { idCustomer });
            return (result != null) ? Convert.ToInt32(result) : -1;
        }

    }
}

