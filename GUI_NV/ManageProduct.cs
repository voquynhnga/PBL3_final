using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
namespace PBL3.GUI_NV
{
    public partial class ManageProduct : Form
    {
        public  QLCH_3Entities DBContext = new QLCH_3Entities();
        public ChiTietSanPham product = new ChiTietSanPham();
        public delegate void AddProductHandler(object sender, EventArgs e);

        public event AddProductHandler AddProductEvent;
        public ManageProduct()
        {
            InitializeComponent();
            View_DG();
        }
        private void View_DG()
        {
            // products = new BindingList<ChiTietSanPham>(DBContext.ChiTietSanPhams.ToList());
            // dataGridView1.DataSource = products;
            chiTietSanPhamBindingSource.DataSource = DBContext.ChiTietSanPhams.ToList();
        }

  


  


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount == 1)
            {
                int[] selectedRowHandles = gridView1.GetSelectedRows();
                foreach (int rowHandle in selectedRowHandles)
                {
                    product = (ChiTietSanPham)gridView1.GetRow(rowHandle);
                }
            }
            this.Close();
            this.FormClosed += new FormClosedEventHandler(AddProductEvent);
        }
    }
}
