using PBL_qnv.BLL;
using PBL3.BLL;
using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void Load_Information(DataGridView dg)
        {
            if(dg.SelectedRows != null && dg.SelectedRows.Count == 1)
            {
                foreach(DataGridViewRow row in dg.SelectedRows)
                {
                    textBox2.Text = row.Cells[1].Value.ToString();
                    textBox3.Text = row.Cells[5].Value.ToString();
                    textBox4.Text = row.Cells[4].Value.ToString();
                }
            }



        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Load_Information(dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query;
            string txt = textBox1.Text;
            Product p = new Product();
            int flag;
            if (txt != null)
            {
                p.Name = txt;

                flag = 1;

            }
            else flag = 2;
            dataGridView1.DataSource = Controller_Product.Instance.Search_Product(flag, p);

        }
    }
}
