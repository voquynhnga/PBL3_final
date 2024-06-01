using DevExpress.XtraCharts.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace PBL3.GUI_CCH
{
    public partial class mnSupplier : Form
    {
        QLCH_3Entities db = new QLCH_3Entities();
        public mnSupplier()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {//ADD NEW
            txt_Ten.Text = "";
            txt_SDT.Text = "";
            txt_Email.Text = "";
            txt_Add.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {//SAVE
            int lastID = db.NhaCungCaps.OrderByDescending(x => x.ID_NCC).FirstOrDefault()?.ID_NCC ?? 0;

            NhaCungCap ncc = new NhaCungCap
            {
                ID_NCC = lastID + 1,
                Ten_NCC = txt_Ten.Text,
                SDT = txt_SDT.Text,
                Email = txt_Email.Text,
                DiaChi = txt_Add.Text,
            };
            var count = db.NhaCungCaps.Count(n => n.SDT == ncc.SDT);
            if (count == 0)
            {
                db.NhaCungCaps.Add(ncc);
                db.SaveChanges();
            }
            else
            {

                XtraMessageBox.Show("Thông tin nhà cung cấp này đã tồn tại!");
                txt_SDT.Text = "";
                txt_SDT.Focus();
            }
            mnSupplier_Load(sender, e);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {//EDIT
            var gv = gridView1;

            if (gv.IsDataRow(gv.FocusedRowHandle))

            {

                var nccEdit = new NhaCungCap

                {

                    ID_NCC = (gv.GetFocusedRow() as NhaCungCap).ID_NCC,

                    Ten_NCC = txt_Ten.Text,

                    SDT = txt_SDT.Text,
                    Email = txt_Email.Text,

                    DiaChi = txt_Add.Text,

                };

                var existingNCC = db.NhaCungCaps.FirstOrDefault(n => n.ID_NCC == nccEdit.ID_NCC);

                if (existingNCC != null)

                {

                    existingNCC.Ten_NCC = nccEdit.Ten_NCC;

                    existingNCC.SDT = nccEdit.SDT;

                    existingNCC.DiaChi = nccEdit.DiaChi;

 

                    existingNCC.Email = nccEdit.Email;

  

                    //existingNCC.Luong = nccEdit.Luong;

                    db.SaveChanges();

                }
                mnSupplier_Load(sender, e);

            }
        }

        private void mnSupplier_Load(object sender, EventArgs e)
        {
            nhaCungCapBindingSource.DataSource = db.NhaCungCaps.ToList();

        }
 

 

        private void gridView1_RowCellClick_1(object sender, RowCellClickEventArgs e)
        {
            if (e.Column == colXoa)
            {
                var nccDelete = gridView1.GetFocusedRow() as NhaCungCap;
                var dlg = XtraMessageBox.Show($"Bạn có chắc chắn muốn xóa{nccDelete.Ten_NCC}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    int deleteID = nccDelete.ID_NCC;

                    db.NhaCungCaps.Remove(nccDelete);

                    gridView1.DeleteSelectedRows();


                    var remainingEmployees = db.NhaCungCaps.Where(n => n.ID_NCC > deleteID).ToList();

                    foreach (var employee in remainingEmployees)

                    {

                        employee.ID_NCC = employee.ID_NCC - 1;

                    }



                    db.SaveChanges();

                }
                mnSupplier_Load(sender, e);

            }
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gv = sender as GridView;
            if (gv.IsDataRow(e.FocusedRowHandle))
            {
                var ncc = gv.GetFocusedRow() as NhaCungCap;
                txt_Ten.EditValue = ncc.Ten_NCC;
                txt_SDT.EditValue = ncc.SDT;
                txt_Add.EditValue = ncc.DiaChi;
                txt_Email.EditValue = ncc.Email;


            }
        }
    }
}
