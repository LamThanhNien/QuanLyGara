using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
    public class Account
    {
        public Account(string userName, string displayName, int checkAdmin, int id)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            //this.Password = password;
            this.CheckAdmin = checkAdmin;
            this.IdAccount = id;
        }
        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            //this.Password = row["Password"].ToString();
            this.CheckAdmin = (int)row["CheckAdmin"];
            this.IdAccount = (int)row["idAccount"];
        }
        private string userName;
        private string displayName;
        //private string password;
        private int checkAdmin;
        private int idAccount;
        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
        //public string Password { get => password; set => password = value; }
        public int CheckAdmin { get => checkAdmin; set => checkAdmin = value; }
        public int IdAccount { get => idAccount; set => idAccount = value; }
    }
}
