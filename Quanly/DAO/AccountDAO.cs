using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
        public void LoadAccount(DataGridView dtgv)
        {
            string query = "select DisplayName,UserName,checkAdmin,idAccount from Account";
            DataTable result = DAO.DataProvider.Instance.ExecuteQuery(query);
            dtgv.DataSource = result;
        }

        public int AddAccount(string DispayName, string UserName, int Type)
        {
            string query = "INSERT INTO Account (DisplayName, UserName, checkAdmin) VALUES  ( @Dispay , @User , @Check )";
            object result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { DispayName, UserName, Type });
            return result != null ? 1 : -1;
        }
        public int GetUser(string User)
        {
            string query = "SELECT * FROM Account WHERE UserName = @UserName";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { User });
            return result >1  ? 1 : -1;
        }
        public string GetDislayName(string User)
        {
            string query = "SELECT DisplayName FROM Account WHERE UserName = @UserName";
            object result = DAO.DataProvider.Instance.ExecuteScalar(query, new object[] { User });
            return result.ToString();
        }
        public int FixAccount(int id, string DispayName, string UserName, int Type)
        {
            string query = "UPDATE Account SET DisplayName = @Display , UserName = @User , checkAdmin = @checkAdmin WHERE idAccount = @idAccount ";
            object result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { DispayName, UserName, Type ,id});
            return result != null ? 1 : -1;
        }
        public int DelAccount(int Id)
        {
            string query =  "DELETE From Account WHERE idAccount = @idAccount";
            object result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { Id });
            return result != null ? 1 : -1;
        }
        public int Resetpasswword(int Id)
        {
            string query = "UPDATE Account SET Password = N'0' WHERE idAccount = @idAccount ";
            object result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] { Id });
            return result != null ? 1 : -1;
        }
        public int Updatepasswword(string DisplayName, string UserName, string password )
        {
            string query = "UPDATE Account SET DisplayName = @DisplayName , UserName = @UserName , Password = @Password WHERE UserName = @UserName ";
            int result = DAO.DataProvider.Instance.ExecuteNonQuery(query, new object[] {DisplayName, UserName, password });
            return result > 0 ? 1 : -1;
        }
    }
}
