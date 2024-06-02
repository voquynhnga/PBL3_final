using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO_bs
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public int SL { get; set; }
        public static int Width = 200;
        public static int Height = 80;
    }
}



