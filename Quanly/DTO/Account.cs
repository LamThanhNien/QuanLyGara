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
        public Account(string userName, string displayName, string password, int checkAdmin)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Password = password;
            this.CheckAdmin = checkAdmin;
        }
        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Password = row["Password"].ToString();
            this.CheckAdmin = (int)row["CheckAdmin"];
        }
        private string userName;
        private string displayName;
        private string password;
        private int checkAdmin;
        public string DisplayName { get => displayName; set => displayName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int CheckAdmin { get => checkAdmin; set => checkAdmin = value; }
    }
}
