using System.Collections.Generic;
using Quanly.DAO;
using Quanly.DTO;

namespace Quanly.BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        private AccountBUS() { }

        public bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        public Account CheckAccount(string userName)
        {
            return AccountDAO.Instance.CheckAccount(userName);
        }

        public List<Account> LoadAccount()
        {
            return AccountDAO.Instance.LoadAccount();
        }

        public string GetDisplayName(string user)
        {
            return AccountDAO.Instance.GetDislayName(user);
        }

        public int FixAccount(int id, string displayName, string userName, int type)
        {
            return AccountDAO.Instance.FixAccount(id, displayName, userName, type);
        }

        public int ResetPassword(int id)
        {
            return AccountDAO.Instance.Resetpasswword(id);
        }

        public void SaveUser(string userName, string saveUser)
        {
            AccountDAO.Instance.SaveUser(userName, saveUser);
        }

        public int CheckUserInAccount(string userName)
        {
            return AccountDAO.Instance.CheckUserInAccount(userName);
        }

        public int UpdateAccount(string displayName, string userName, string password)
        {
            return AccountDAO.Instance.UpdateAccount(displayName, userName, password);
        }
    }
}
