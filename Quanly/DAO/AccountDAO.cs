using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get {
                if (instance == null)
                    instance = new AccountDAO();
                    return instance;
            }
            set
            {
                instance = value;
            }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string query = "USP_login @UserName , @Password";

            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { username, password });

            return result != null && Convert.ToInt32(result) > 0;
        }
        public DTO.Account GetAccount(string userName)
        {
            string query = "SELECT * FROM Account WHERE UserName = @userName";
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            foreach(DataRow item in data.Rows)
            {
                return new DTO.Account(item);
            }
            return null;
        }
    }
}
