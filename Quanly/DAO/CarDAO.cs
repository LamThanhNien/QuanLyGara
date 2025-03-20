using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quanly.DAO
{
    public class CarDAO
    {
        private static CarDAO instance;
        public static CarDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CarDAO();
                return instance;
            }
            set { instance = value; }
        }
        private CarDAO() { }
        public void LoadDL(DataGridView dtgvCar)
        {
            string query = "SELECT cs.name, c.name as namecar,c.numberCar,cs.address,cs.phoneNum, c.ImageBase64\r\nFROM Customer cs \r\nINNER JOIN Car c ON cs.idCustomer = c.idCustomer;";
            dtgvCar.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        public int GetCar(int idCustomer, string namecar, int numcar, string logo, string filePath )
        {
            string query = "USP_insertCar @idCustomer, @namecar , @numcar , @logo , @filePath";
            object result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { idCustomer, namecar, numcar, logo, filePath });
            return (result != null) ? Convert.ToInt32(result) : -1;
        }
    }
}
