using System;
using System.Data;

namespace Quanly.DTO
{
    public class Customer_Car
    {
        public Customer_Car(string nameCustomer, int sex, string address, string phone, string nameCar, string numCar,string hang, string color, string image, int idCustomer)
        {
            this.NameCtm = nameCustomer;
            this.Sex = sex;
            this.Address = address;
            this.Phone = phone;
            this.NameCar = nameCar;
            this.NumCar = numCar;
            this.Hang = hang;
            this.Color = color;
            this.Image = image;
            this.IdCustomer = idCustomer;
        }
        public Customer_Car(DataRow row)
        {
            this.NameCtm = row["name"].ToString();
            this.Sex = row["sex"] != DBNull.Value ? Convert.ToInt32(row["sex"]) : 0;
            this.Address = row["address"].ToString(); 
            this.Phone = row["phoneNum"].ToString();
            this.NameCar = row["nameCar"].ToString();
            this.NumCar = row["numberCar"].ToString();
            this.Hang = row["Hang"].ToString();
            this.Color = row["color"].ToString();
            this.Image = row["ImageBase64"].ToString();
            this.IdCustomer = row["idCustomer"] != DBNull.Value ? Convert.ToInt32(row["idCustomer"]) : 0;
        }

        private string nameCtm;
        private int sex;
        private string address;
        private string phone;
        private string nameCar;
        private string numCar;
        private string hang;
        private string color;
        private string image;
        private int idCustomer;

        public string NameCtm { get => nameCtm; set => nameCtm = value; }
        public int Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string NameCar { get => nameCar; set => nameCar = value; }
        public string NumCar { get => numCar; set => numCar = value; }
        public string Hang { get => hang; set => hang = value; }
        public string Color { get => color; set => color = value; }
        public string Image { get => image; set => image = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }

    }
}
