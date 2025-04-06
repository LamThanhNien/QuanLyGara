using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
    public class Employee
    {
        public Employee(string name, string phone, string chucvu, float luong, string day, int checkout, int checkAccount)
        {
            this.Name = name;
            this.Phone = phone;
            this.Chucvu = chucvu;
            this.Luong = luong;
            this.Day = day;
            this.Checkout = checkout;
            this.CheckAccount = checkAccount;
        }
        public Employee(DataRow row)
        {
            this.Name = row["FullName"].ToString();
            this.Phone = row["Phone"].ToString();
            this.Chucvu = row["Position"].ToString();
            this.Luong = float.Parse(row["Salary"].ToString());
            this.Day = row["HireDate"].ToString();
            this.Checkout = (int)row["Status"];
            this.CheckAccount = (int)row["checkAdmin"];
        }
        private string name;
        private string phone;
        private string chucvu;
        private float luong;
        private string day;
        private int checkout;
        private int checkAccount;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public float Luong { get => luong; set => luong = value; }
        public string Day { get => day; set => day = value; }
        public int Checkout { get => checkout; set => checkout = value; }
        public int CheckAccount { get => checkAccount; set => checkAccount = value; }
    }
}
