using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
    public class Customer
    {
        public Customer(string name, string phone, string address, int id)
        {
            this.Name = name;
            this.Phonenum = phone;
            this.Address = address;
            this.Id = id;
        }
        public Customer(DataRow row)
        {
            this.Name = row["name"].ToString();
            this.Phonenum = row["phoneNum"].ToString();
            this.Address = row["address"].ToString();
            this.Id = (int)row["idCustomer"];
        }
        private string name;
        private string phonenum;
        private string address;
        private int id;

        public string Name { get => name; set => name = value; }
        public string Phonenum { get => phonenum; set => phonenum = value; }
        public string Address { get => address; set => address = value; }
        public int Id { get => id; set => id = value; }

    }
}
