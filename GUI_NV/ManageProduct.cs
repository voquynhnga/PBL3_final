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
            ChiTietSanPhamBindingSource.DataSource = DBContext.ChiTietSanPhams.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
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


        //private void load_information()
        //{
        //    if (gridView1 != null && gridView1.FocusedRowHandle >= 0)

        //    {

        //        var selectedRow = gridView1.GetDataRow(gridView1.FocusedRowHandle);

        //        textBox2.Text = selectedRow["TenHang"].ToString(); // Thay "ColumnName1" bằng tên cột tương ứng

        //        textBox3.Text = selectedRow["Gia"].ToString(); // Thay "ColumnName2" bằng tên cột tương ứng

        //        textBox4.Text = selectedRow["SoLuong"].ToString(); // Thay "ColumnName2" bằng tên cột tương ứng
        //        richTextBox1.Text = selectedRow["Mo_ta"].ToString();
        //    }
        //}

        private void gridControl1_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            //load_information();
        }

        //FIXXXXXX

        private void gridControl1_EnabledChanged(object sender, EventArgs e)
        {
            //DBContext.SaveChanges();
        }

        private void gridControl1_Validated(object sender, EventArgs e)
        {

            // Lưu các thay đổi vào cơ sở dữ liệu
            //using( var DB = new QLCH_3Entities())
            //{
            //    var product = (ChiTietSanPham)DB.
            //    DB.SaveChanges();
            //}

        }
        //FIXXXXXXXXXXX
        private void gridControl1_TextChanged(object sender, EventArgs e)
        {
            //DBContext.SaveChanges();
        }
    }
}
