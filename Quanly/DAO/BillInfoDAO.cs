using Quanly.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

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
        public void InsertBillInfo(int IdBill, int IdService, int IdMaterial, int Quantity)
        {
            
            string get1 = "SELECT quantity FROM BillInfo WHERE idMaterial = @idMaterial";
            object getValua1 = DAO.DataProvider.Instance.ExecuteScalar(get1, new object[] { IdBill });

            string get2 = "SELECT quantity FROM Material WHERE idMaterial = @idMaterial";
            object getValua2 = DAO.DataProvider.Instance.ExecuteScalar(get2, new object[] { IdMaterial });
            if(Convert.ToInt32(getValua2) < Convert.ToInt32(getValua1))
            {
                MessageBox.Show("Số Lượng sản phẩm bạn thêm là " + Quantity + " vược quá số lượng tần kho là" + Convert.ToInt32(getValua2), "thông báo", MessageBoxButtons.OK);
                return;
                
            }    
            try
            {
                DataProvider.Instance.ExecuteQuery("USP_InsertBillInfo @IdBill , @IdService ,  @IdMaterial , @count ", new object[] { IdBill, IdService, IdMaterial, Quantity });
            }   
            catch
            {
                MessageBox.Show("Không có sản phẩm");
            }
        }
        public bool DeleteBillInfo(string name)
        {
            string query = "DELETE FROM BillInfo WHERE idMaterial = (SELECT idMaterial FROM Material WHERE name = @name )";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name});
            return result > 0;
        }
    }
}
