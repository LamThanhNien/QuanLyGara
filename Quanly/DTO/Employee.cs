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
            public Employee(string name, string phone, string chucvu, double luong, DateTime day, int checkout, int checkAccount, int idEmployee)
            {
                this.Name = name;
                this.Phone = phone;
                this.Chucvu = chucvu;
                this.Luong = luong;
                this.Day = day;
                this.Checkout = checkout;
                this.CheckAccount = checkAccount;
                this.IdEmployee = idEmployee;
            }

            public Employee(DataRow row)
            {
                this.Name = row["FullName"].ToString();
                this.Phone = row["Phone"].ToString();
                this.Chucvu = row["Position"].ToString();
                this.Luong = float.Parse(row["Salary"].ToString());
                this.Day = Convert.ToDateTime(row["HireDate"]); // Convert to DateTime
                this.Checkout = (int)row["Status"];
                this.CheckAccount = (int)row["checkAdmin"];
                this.IdEmployee = (int)row["IdEmployee"];
            }

            private string name;
            private string phone;
            private string chucvu;
            private double luong;
            private DateTime day; // Change to DateTime type
            private int checkout;
            private int checkAccount;
            private int idEmployee;

            public string Name { get => name; set => name = value; }
            public string Phone { get => phone; set => phone = value; }
            public string Chucvu { get => chucvu; set => chucvu = value; }
            public double Luong { get => luong; set => luong = value; }
            public DateTime Day { get => day; set => day = value; } // Change to DateTime type
            public int Checkout { get => checkout; set => checkout = value; }
            public int CheckAccount { get => checkAccount; set => checkAccount = value; }
            public int IdEmployee { get => idEmployee; set => idEmployee = value; }
    }
}
