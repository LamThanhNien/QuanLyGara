using System;
using System.Collections.Generic;
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
    }
}
