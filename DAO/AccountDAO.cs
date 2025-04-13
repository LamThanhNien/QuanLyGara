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
        public DTO.Account CheckAccount(string userName)
        {
            string query = "SELECT * FROM Account WHERE UserName = @userName";
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            foreach (DataRow item in data.Rows)
            {
                return new DTO.Account(item);
            }
            return null;
        }
        public List<DTO.Account> LoadAccount()
        {
            List<DTO.Account> list = new List<DTO.Account>();
            string query = "select DisplayName,UserName,checkAdmin,idAccount from Account";
            DataTable dt = DAO.DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in dt.Rows)
            {
                DTO.Account item = new DTO.Account(row);
                list.Add(item);
            }
            return list;
        }
        //public int GetUser(string User)
        //{
        //    string query = "SELECT * FROM Account WHERE UserName = @UserName";
        //    int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { User });
        //    return result > 1 ? 1 : -1;
        //}
        public string GetDislayName(string User)
        {
            string query = "SELECT DisplayName FROM Account WHERE UserName = @UserName";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { User });
            return result.ToString();
        }

        //public int AddAccount(string DispayName, string UserName, int Type)
        //{
        //    string query = "INSERT INTO Account (DisplayName, UserName, checkAdmin) VALUES  ( @Dispay , @User , @Check )";
        //    object result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { DispayName, UserName, Type });
        //    return result != null ? 1 : -1;
        //}

        public int FixAccount(int id, string DispayName, string UserName, int Type)
        {
            string query = "UPDATE Account SET DisplayName = @Display , UserName = @User , checkAdmin = @checkAdmin WHERE idAccount = @idAccount ";
            object result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { DispayName, UserName, Type ,id});
            return result != null ? 1 : -1;
        }

        public int Resetpasswword(int Id)
        {
            string query = "UPDATE Account SET Password = N'0' WHERE idAccount = @idAccount ";
            object result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { Id });
            return result != null ? 1 : -1;
        }
        public void SaveUser(string UserName, string SaveUser)
        {
            string query = "UPDATE Account SET UserName = @UserName WHERE UserName = @SaveUser ";
            DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {UserName, SaveUser});
        }
        public int CheckUserInAccount(string Username)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE Username = @Username ";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { Username });
            return Convert.ToInt32(result);
        }
        public int UpdateAccount(string DisplayName, string UserName, string password )
        {
            string query = "UPDATE Account SET DisplayName = @DisplayName , UserName = @UserName , Password = @Password WHERE UserName = @UserName ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {DisplayName, UserName, password });
            return result > 0 ? 1 : -1;
        }
    }
}
