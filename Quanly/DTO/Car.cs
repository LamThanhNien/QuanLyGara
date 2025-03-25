using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
    public class Car
    {
        public Car(string nameCtm, string phonenum, string namCar, string numbercar, string clolor, string image, int idCtm, int idCar)
        {
            this.NameCustomer = nameCtm;
            this.Phonenum = phonenum;
            this.NameCar = nameCar;
            this.NumberCar = numbercar;
            this.Color = color;
            this.Image = image;
            this.IdCtm = idCtm;
            this.IdCar = idCar;
        }

        public Car(DataRow row)
        {
            this.NameCustomer = row["NameCustomer"].ToString();
            this.Phonenum = row["PhoneNum"].ToString();
            this.NameCar = row["Namecar"].ToString();
            this.NumberCar = row["NumberCar"].ToString();
            this.Color = row["Logo"].ToString();
            this.Image = row["Image"].ToString();
            this.IdCtm = (int)row["IdCtm"];
            this.IdCar = (int)row["IdCar"];
        }
        private string nameCustomer;
        private string phonenum;
        private string nameCar;
        private string numberCar;
        private string color;
        private string image;
        private int idCtm;
        private int idCar;

        public string NameCustomer { get => nameCustomer; set => nameCustomer = value; }
        public string NameCar { get => nameCar; set => nameCar = value; }
        public string NumberCar { get => numberCar; set => numberCar = value; }
        public string Color { get => color; set => color = value; }
        public string Phonenum { get => phonenum; set => phonenum = value; }
        public string Image { get => image; set => image = value; }
        public int IdCtm { get => idCtm; set => idCtm = value; }
        public int IdCar { get => idCar; set => idCar = value; }

    }
}
