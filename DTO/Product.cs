using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_qnv.BLL
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int ID_NCC { get; set; }
        public int ID_type { get; set; }
        public int SL {  get; set; }
        public float Price { get; set; }
        public int ID_IG {  get; set; }

        public string Description { get; set; }



        //public Product(DataRow row)
        //{
        //    this.ID = (int)row["ID_MatHang"];
        //    this.Name = (string)row["TenHang"];
        //    this.ID_NCC = (int)row["ID_NCC"];
        //    this.ID_type = (int)row["ID_LoaiHang"];
        //    this.SL = (int)row["SoLuong"];
        //    this.Price = Convert.ToSingle(row["Gia"]);

        //    //this.Price = (float)row["Gia"];
        //    this.ID_IG = (int)row["ID_LoHang"];
        //    //this.Description = (string)row["Mo_ta"];


        //}
        public void Get_Allproduct(DataGridView dg)

        {

            foreach (DataGridViewRow row in dg.Rows)

            {

                Product p = new Product()

                {

                    ID = Convert.ToInt32(row.Cells["ID_MatHang"].Value),

                    Name = Convert.ToString(row.Cells["TenHang"].Value),

                    ID_NCC = Convert.ToInt32(row.Cells["ID_NCC"].Value),

                    ID_type = Convert.ToInt32(row.Cells["ID_LoaiHang"].Value),

                    SL = Convert.ToInt32(row.Cells["SoLuong"].Value),

                    Price = Convert.ToSingle(row.Cells["Gia"].Value),

                    ID_IG = Convert.ToInt32(row.Cells["ID_LoHang"].Value),

                    Description = Convert.ToString(row.Cells["Mo_Ta"].Value)

                    // Nếu có các trường dữ liệu khác trong DataGridViewRow, thêm vào ở đây

                };

            }

        }
        public Product  Get_product(DataGridViewRow row)
        {
            Product p = new Product()

            {

                ID = Convert.ToInt32(row.Cells["ID_MatHang"].Value),

                Name = Convert.ToString(row.Cells["TenHang"].Value),

                ID_NCC = Convert.ToInt32(row.Cells["ID_NCC"].Value),

                ID_type = Convert.ToInt32(row.Cells["ID_LoaiHang"].Value),

                SL = Convert.ToInt32(row.Cells["SoLuong"].Value),

                Price = Convert.ToSingle(row.Cells["Gia"].Value),

                ID_IG = Convert.ToInt32(row.Cells["ID_LoHang"].Value),

                Description = Convert.ToString(row.Cells["Mo_Ta"].Value)

                // Nếu có các trường dữ liệu khác trong DataGridViewRow, thêm vào ở đây

            };
            return p;
        }
    }
}
