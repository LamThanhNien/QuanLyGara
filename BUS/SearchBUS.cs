using System.Collections.Generic;
using Quanly.DAO;
using Quanly.DTO;

namespace Quanly.BUS
{
    public class SearchBUS
    {
        private static SearchBUS instance;
        public static SearchBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SearchBUS();
                return instance;
            }
            set
            {
                value = instance;
            }
        }
        public SearchBUS() { }

        public List<Customer_Car> searchCustomer(string name)
        {
            return Search.Instance.searchCustomer(name);
        }
        public List<Car> searchCarbyname(string name)
        {
            return Search.Instance.searchCarbyname(name);
        }
        public List<ThanhToan> searchCustomerbyname(string name)
        {
            return Search.Instance.searchCustomerbyname(name);
        }
        public List<Customer> searchCtmbyname(string name)
        {
            return Search.Instance.searchCtmbyname(name);
        }
        public List<Material> searchMaterialbyname(string name)
        {
            return Search.Instance.searchMaterialbyname(name);
        }
        public List<Employee> searchEmployeebyname(string name)
        {
            return Search.Instance.searchEmployeebyname(name);
        }
    }
}
