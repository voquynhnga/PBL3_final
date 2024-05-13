using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Product_item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public int SL { get; set; }
        public static int Width = 200;
        public static int Height = 80;
    }


}
