using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraDashboardLayout;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PBL3.DAL;

namespace PBL3.GUI_CCH
{
    public partial class MnEmployee : Form
    {
        public QLCH_3Entities DB = new QLCH_3Entities();

        public MnEmployee()
        {
            InitializeComponent();
        }

        private void MnEmployee_Load(object sender, EventArgs e)
        {
            nhanVienBindingSource.DataSource = DB.NhanViens.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {//SAVE
            
                int lastID = DB.NhanViens.OrderByDescending(x => x.ID_NV).FirstOrDefault()?.ID_NV ?? 0;

                NhanVien nv = new NhanVien
                {
                    


                    ID_NV = lastID + 1,
                    NameNV = txt_Ten.Text,
                    SDT = txt_SDT.Text,
                    GT = comboBoxEdit1.Text,
                    NS = dateEdit1.DateTime,
                    CCCD = txt_CC.Text,
                    Email = txt_Email.Text,
                    ChucVu = txt_CV.Text,
                    //Luong = 0,
                   // TaiKhoan = "";

                    

                };
                var count = DB.NhanViens.Count(n => n.SDT == nv.SDT);
                if (count == 0)
                {
                    DB.NhanViens.Add(nv);
                    DB.SaveChanges();
                }
                else
                {

                    XtraMessageBox.Show("Thông tin nhân viên này đã tồn tại");
                    txt_SDT.Text = "";
                    txt_SDT.Focus();
                }




            
            MnEmployee_Load(sender, e);
        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {//EDIT
    
            var gv = gridView1;

            if (gv.IsDataRow(gv.FocusedRowHandle))

            {

                var nvEdit = new NhanVien

                {

                    ID_NV = (gv.GetFocusedRow() as NhanVien).ID_NV,

                    NameNV = txt_Ten.Text,

                    SDT = txt_SDT.Text,

                    GT = comboBoxEdit1.Text,

                    NS = dateEdit1.DateTime,

                    CCCD = txt_CC.Text,

                    Email = txt_Email.Text,

                    ChucVu = txt_CV.Text,

                    //Luong = 0,

                };

                var existingNhanVien = DB.NhanViens.FirstOrDefault(n => n.ID_NV == nvEdit.ID_NV);

                if (existingNhanVien != null)

                {

                    existingNhanVien.NameNV = nvEdit.NameNV;

                    existingNhanVien.SDT = nvEdit.SDT;

                    existingNhanVien.GT = nvEdit.GT;

                    existingNhanVien.NS = nvEdit.NS;

                    existingNhanVien.CCCD = nvEdit.CCCD;

                    existingNhanVien.Email = nvEdit.Email;

                    existingNhanVien.ChucVu = nvEdit.ChucVu;

                    //existingNhanVien.Luong = nvEdit.Luong;

                    DB.SaveChanges();

                }
                MnEmployee_Load(sender, e);

            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gv = sender as GridView;
            if (gv.IsDataRow(e.FocusedRowHandle))
            {
                var nv = gv.GetFocusedRow() as NhanVien;
                txt_Ten.EditValue = nv.NameNV;
                txt_SDT.EditValue = nv.SDT;
                //txt_Add.EditValue = nv.Dia
                txt_CC.EditValue = nv.CCCD;
                txt_CV.EditValue = nv.ChucVu;
                txt_Email.EditValue = nv.Email;
                dateEdit1.EditValue = nv.NS;
                comboBoxEdit1.EditValue = nv.GT;

            }
        }



        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if(e.Column == ColXoa)
            {
                var nvDelete = gridView1.GetFocusedRow() as NhanVien;
                var dlg = XtraMessageBox.Show($"Bạn có chắc chắn muốn xóa{nvDelete.NameNV}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg ==DialogResult.Yes)
                {
                    int deleteID = nvDelete.ID_NV;

                    DB.NhanViens.Remove(nvDelete);

                    gridView1.DeleteSelectedRows();


                    var remainingEmployees = DB.NhanViens.Where(n => n.ID_NV > deleteID).ToList();

                    foreach (var employee in remainingEmployees)

                    {

                        employee.ID_NV = employee.ID_NV - 1;

                    }



                    DB.SaveChanges();

                }
                MnEmployee_Load(sender, e);

            }
        }
    }
}
