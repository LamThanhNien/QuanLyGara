using System.Collections.Generic;
using Quanly.DAO;
using Quanly.DTO;

namespace Quanly.BUS
{
    public class EmployeeBUS
    {
        private static EmployeeBUS instance;
        public static EmployeeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new EmployeeBUS();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private EmployeeBUS() { }

        public List<Employee> loadEmployee()
        {
            return EmployeeDAO.Instance.loadEmployee();
        }
        public int AddEmployee(string name, string phone, string chucvu, double luong, DateTime day, int checkout)
        {
            return EmployeeDAO.Instance.AddEmployee(name, phone, chucvu, luong, day, checkout);
        }
        public int FixEmployee(int idEmployee, int typeAccount, string name, string phone, string chucvu, double luong, DateTime day, int checkout)
        {
            return EmployeeDAO.Instance.FixEmployee(idEmployee, typeAccount, name, phone, chucvu, luong, day, checkout);
        }
        public int DelEmployee(int idEmployee)
        {
            return EmployeeDAO.Instance.DelEmployee(idEmployee);
        }
    }
}
