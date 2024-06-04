using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PBL3.DAL;
using PBL3_qnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL3.GUI_NV
{
    public partial class Customer : Form
    {
        QLCH_3Entities DB = new QLCH_3Entities ();

        public Customer()
        {
            InitializeComponent();


        }




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //Controller_Customer.Instance.Add(dataGridView1);

        //    Customer cus = new Customer()
        //    {
        //        //FIXXXXXXXXXXXXXX

        //        ID = Controller_Customer.Instance.GetLastRow(dataGridView1),
        //        Name = textBox2.Text,
        //        SDT = textBox3.Text,
        //        GT = GT,
        //        DTL = 0,

        //    };
        //    Controller_Customer.Instance.Add(cus);
        //    Show_DG();
        //    textBox2.Text = "";
        //    textBox3.Text = "";
        //    radioButton1.Checked = false;
        //    radioButton2.Checked = false;

        //}
  








      
        private void Customer_Load(object sender, EventArgs e)
        {
            khachHangBindingSource.DataSource = DB.KhachHangs.ToList();

        }

  



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (var DB = new QLCH_3Entities())
            {
                int lastID = DB.KhachHangs.OrderByDescending(x => x.ID_KH).FirstOrDefault()?.ID_KH ?? 0;

                KhachHang kh = new KhachHang
                {



                    ID_KH = lastID + 1,
                    NameKH = txt_name.Text,
                    SDT = txt_sdt.Text,
                    GT = comboBoxEdit1.Text,
                    DTL = Convert.ToInt32(txt_d.Text)
               



                };
                var count = DB.KhachHangs.Count(n => n.SDT == kh.SDT);
                if (count == 0)
                {
                    DB.KhachHangs.Add(kh);
                    DB.SaveChanges();
                }
                else
                {

                    XtraMessageBox.Show("Thông tin khách hàng này đã tồn tại");
                    txt_sdt.Text = "";
                    txt_sdt.Focus();
                }




            }
            Customer_Load(sender, e);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var gv = gridView1;

            if (gv.IsDataRow(gv.FocusedRowHandle))

            {

                var khEdit = new KhachHang

                {

                    ID_KH = (gv.GetFocusedRow() as KhachHang).ID_KH,

                    NameKH = txt_name.Text,

                    SDT = txt_sdt.Text,

                    GT = comboBoxEdit1.Text,

                    DTL = Convert.ToInt32(txt_d.Text),


  

                };

                var existKH = DB.KhachHangs.FirstOrDefault(n => n.ID_KH == khEdit.ID_KH);

                if (existKH != null)

                {

                    existKH.NameKH = khEdit.NameKH;

                    existKH.SDT = khEdit.SDT;

                    existKH.GT = khEdit.GT;

                    existKH.DTL = khEdit.DTL;


                    DB.SaveChanges();

                }
                Customer_Load(sender, e);

            }
        }



        private void gridView1_RowCellClick_1(object sender, RowCellClickEventArgs e)
        {
            if (e.Column == colDelete)
            {
                var khDelete = gridView1.GetFocusedRow() as KhachHang;
                var dlg = XtraMessageBox.Show($"Bạn có chắc chắn muốn xóa {khDelete.NameKH}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    int deleteID = khDelete.ID_KH;

                    DB.KhachHangs.Remove(khDelete);

                    gridView1.DeleteSelectedRows();


                    var remainingEmployees = DB.NhanViens.Where(n => n.ID_NV > deleteID).ToList();

                    foreach (var employee in remainingEmployees)

                    {

                        employee.ID_NV = employee.ID_NV - 1;

                    }

                    //FIXXX

                    DB.SaveChanges();

                }
                Customer_Load(sender, e);

            }
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gv = sender as GridView;
            if (gv.IsDataRow(e.FocusedRowHandle))
            {
                var kh = gv.GetFocusedRow() as KhachHang;
                txt_name.EditValue = kh.NameKH;
                txt_sdt.EditValue = kh.SDT;
                //txt_Add.EditValue = nv.Dia
                comboBoxEdit1.EditValue = kh.GT;
                txt_d.EditValue = kh.DTL;


            }
        }
    }
}
