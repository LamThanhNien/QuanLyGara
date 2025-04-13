using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
    public class Menu
    {
        public Menu(string Name, int count, float price, float totalPrice)
        {
            this.Name = Name;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.Name = row["name"].ToString();
            this.Count = Convert.ToInt32(row["quantity"]);
            this.Price = Convert.ToSingle(row["price"]);
            this.TotalPrice = Convert.ToSingle(row["totalPrice"]);
        }

        public float TotalPrice { get; set; }
        public float Price { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
    }
}
