using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Quanly.DAO
{
    public class AddCustomerDAO
    {
        private static AddCustomerDAO instance;
        public static AddCustomerDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AddCustomerDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private AddCustomerDAO() { }
        public bool checkNumBerCar(string numberCar)
        {
            string query = "SELECT COUNT(*) FROM Car WHERE numberCar = @numberCar";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { numberCar });

            return Convert.ToInt32(result) > 0;
        }

        public bool AddCustomer(string name, string address, string numberphone, string namecar, string numcar, string logo, string filePath)
        {
            string query = "InsertCustomer @Ten , @address , @Mobile , @namecar , @numcar , @logo , @filePath ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, address, numberphone, namecar, numcar, logo, filePath });

            return result > 0;
        }

    }
}
