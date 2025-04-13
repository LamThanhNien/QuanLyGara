using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DTO
{
    public class Material
    {
        public Material(string name, string type, string noiSx, int sl, float price, int idM, string image)
        {
            this.Name = name;
            this.Type = type;
            this.NoiSx = noiSx;
            this.Sl = sl;
            this.Price = price;
            this.IdMaterial = idM;
            //this.IdService = idS;
            this.Image = image;
        }
        public Material(DataRow row)
        {
            this.Name = row["name"].ToString(); 
            this.Type = row["type"].ToString();
            this.NoiSx = row["noiSx"].ToString();
            this.Sl = Convert.ToInt32(row["quantity"]);
            this.Price = Convert.ToSingle(row["price"]);
            this.IdMaterial = Convert.ToInt32(row["idMaterial"]);
            //this.IdService = Convert.ToInt32(row["idService"]);
            this.Image = row["images"].ToString();
        }

        private string name;
        private string type;
        private string noiSx;
        private int sl;
        private float price;
        private int idMaterial;
        //private int idService;
        private string image;

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string NoiSx { get => noiSx; set => noiSx = value; }
        public float Price { get => price; set => price = value; }
        public int Sl { get => sl; set => sl = value; }
        public string Image { get => image; set => image = value; }
        public int IdMaterial { get => idMaterial; set => idMaterial = value; }
        //public int IdService { get => idService; set => idService = value; }
    }
}
