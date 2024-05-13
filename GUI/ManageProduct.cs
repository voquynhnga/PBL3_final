using PBL_qnv.BLL;
using PBL3.BLL;
using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class ManageProduct : Form
    {
        public Product product = new Product();

        public delegate void AddProductHandler(object sender, EventArgs e);

        public event AddProductHandler AddProductEvent;
        public ManageProduct()
        {
            InitializeComponent();
            //LoadProduct();
            View_DG("MatHang");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void View_DG(string table)
        {
            DataTable d = Controller.Instance.View_DG(table);
            dataGridView1.DataSource = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    product = product.Get_product(row);

                }
            }

            this.Close();
            this.FormClosed += new FormClosedEventHandler(AddProductEvent);


        }
        //public void LoadProduct()
        //{
        //    List<Product> list = DB_Table.Instance.Get_ProductList("MatHang");
        //    foreach (Product item in list)
        //    {
        //        Button btn = new Button()
        //        {
        //            Width = Product.Width,
        //            Height = Product.Height,
        //            Text = item.Name

        //        };
        //        fl.Controls.Add(btn);

        //    }

        //}
    }
}
