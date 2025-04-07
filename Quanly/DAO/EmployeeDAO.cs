using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Quanly.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeDAO();
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        private EmployeeDAO() { }
        public void loadEmployee(DataGridView dtgv)
        {
            List<DTO.Employee> list = new List<DTO.Employee>();
            string query = "select e.FullName,e.Phone,e.Position,e.Salary,e.HireDate,e.Status,a.checkAdmin, e.idEmployee from Employee e,Account a where e.idAccount = a.idAccount\r\n";
            DataTable dt = DAO.DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                DTO.Employee item = new DTO.Employee(row);
                list.Add(item);
            }
            dtgv.DataSource = list;
        }
        public int AddEmployee(string name, string phone, string chucvu, double luong, DateTime day, int checkout)
        {
            string query = "USP_InsertEmployee @name , @phone , @chucvu , @luong , @day , @Checkout ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, phone, chucvu, luong, day, checkout });
            return result > 0 ? 1 : -1;
        }
        public int FixEmployee(int idEmployee, int typeAccount, string name, string phone, string chucvu, double luong, DateTime day, int checkout)
        {
            string query = "USP_FixEmployee @idEmployee , @TypeAccount , @name , @phone , @chucvu , @luong , @day , @Checkout ";
            object result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { idEmployee, typeAccount, name, phone, chucvu, luong, day, checkout });
            return result != null ? 1 : -1;
        }
        public int DelEmployee(int idEmployee)
        {
            string query = "USP_DeleteEmployee @idEmployee ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {idEmployee});
            return result > 0 ? 1 : -1;
        }
    }
}
