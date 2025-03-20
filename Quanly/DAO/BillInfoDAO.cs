using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return instance; }
            private set { instance = value; }
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            string query = "SELECT * FROM BillInfo WHERE idBill = @idBill ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            foreach (DataRow row in data.Rows)
            {
                BillInfo info = new BillInfo(row);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }


        public List<BillInfo> GetListBilllInfo(int id)
        {
            return GetListBillInfo(id);
        }
        public void InsertBillInfo(int IdBill, int IdService, int IdMaterial, int Quantity)
        {
            try
            {
                DataProvider.Instance.ExecuteQuery("USP_InsertBillInfo @IdBill , @IdService ,  @IdMaterial , @count ", new object[] { IdBill, IdService, IdMaterial, Quantity });
            }   
            catch
            {
                MessageBox.Show("Không có sản phẩm");
            }
        }
        public void UpdateBillInfo(int stt, int idBill, int idMaterial)
        {
            string updateQuery = "USP_UpdateBillInfo @stt , @idBill , @IdMaterial";
            DataProvider.Instance.ExecuteNonQuery(updateQuery, new object[] { stt, idBill, idMaterial });
        }
    }
}
