using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
    public class ThanhToan
    {
        public ThanhToan(string name, string address, string phoneNum, string namecar, string numnberCar, string color, int idCustomer)
        {
            this.Name = name;
            this.Address = address;
            this.PhoneNum = phoneNum;
            this.Namecar = namecar;
            this.NumberCar = numberCar;
            this.Color = color;
            this.IdCustomer = idCustomer;
        }
        public ThanhToan(DataRow row)
        {
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.PhoneNum = row["phoneNum"].ToString();
            this.Namecar = row["namecar"].ToString(); 
            this.NumberCar = row["numberCar"].ToString();
            this.Color = row["Color"].ToString(); 
            this.IdCustomer = (int)row["idCustomer"];
        }
        private string name;
        private string address;
        private string phoneNum;
        private string namecar;
        private string numberCar;
        private string color;
        private int idCustomer;
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Namecar { get => namecar; set => namecar = value; }
        public string NumberCar { get => numberCar; set => numberCar = value; }
        public string Color { get => color; set => color = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
    }
}
