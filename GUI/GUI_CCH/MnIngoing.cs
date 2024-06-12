using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PBL3.DAL;
using PBL3.DTO_bs;
using PBL3_qnv.GUI_CCH;



namespace PBL3_qnv.GUI_CCH
{
    public partial class MnIngoing : Form
    {
        /// <summary>
        /// Main_CCH mf_cch = Application.OpenForms["Main_CCH"] as Main_CCH;
        /// </summary>
        private Dictionary<int, string> _nccDictionary;
        private Dictionary<int, string> _lhDictionary;


        QLCH_3Entities db = new QLCH_3Entities();
        public MnIngoing()
        {
            InitializeComponent();
            //LoadNCCDictionary();
            //InitializeGridView();

        }


        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "Nhà cung cấp" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int idNCC = Convert.ToInt32(e.Value);
                if (_nccDictionary.ContainsKey(idNCC))
                {
                    e.DisplayText = _nccDictionary[idNCC];
                }
            }
            if (e.Column.FieldName == "LoaiHang" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                int idLH = Convert.ToInt32(e.Value);
                if (_nccDictionary.ContainsKey(idLH))
                {
                    e.DisplayText = _nccDictionary[idLH];
                }
            }
        }
        private void LoadNCCDictionary()
        {

            _nccDictionary = db.NhaCungCaps.ToDictionary(ncc => ncc.ID_NCC, ncc => ncc.Ten_NCC);

        }
        private void LoadLHDictionary()
        {

            _lhDictionary = db.LoaiHangs.ToDictionary(n => n.ID_LoaiHang, n => n.Ten_LoaiHang);

        }


        private void InitializeGridView()
        {
            gridView1.CustomColumnDisplayText += gridView1_CustomColumnDisplayText;
        }

        private void MnIngoing_Load(object sender, EventArgs e)
        {
            loHangBindingSource.DataSource = db.LoHangs.ToList();

            var data_NCC = db.NhaCungCaps.Select(p => new { p.ID_NCC, p.Ten_NCC }).ToList();
            txt_TenNCC.Properties.DataSource = data_NCC;

            txt_TenNCC.Properties.DisplayMember = "Ten_NCC";
            txt_TenNCC.Properties.ValueMember = "ID_NCC";

            nhaCungCapBindingSource1.DataSource = db.NhaCungCaps.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {//SAVE
            int lastID = db.LoHangs.OrderByDescending(x => x.ID_LoHang).FirstOrDefault()?.ID_LoHang ?? 0;

            LoHang lh = new LoHang
            {
                ID_LoHang = lastID + 1,
                ID_NCC = Convert.ToInt32(txt_TenNCC.EditValue),
                SoLuong = Convert.ToInt32(txt_SL.EditValue),
                NgayNhap = Convert.ToDateTime(txt_in.EditValue),
                TongTienNhap = Convert.ToDouble(txt_Total.EditValue),
            };
            var count = db.LoHangs.Count(n => n.ID_NCC == lh.ID_NCC
                                && n.SoLuong == lh.SoLuong
                                && n.NgayNhap == lh.NgayNhap
                                && n.TongTienNhap == lh.TongTienNhap
                                );
            if (count == 0)
            {
                db.LoHangs.Add(lh);
                db.SaveChanges();
            }
            else
            {

                XtraMessageBox.Show("Lô hàng này đã được nhập!");
                txt_TenNCC.Text = "";
                txt_SL.Text = "";
                txt_Total.EditValue = null;
                txt_in.EditValue = null;
                txt_TenNCC.Focus();
            }
            MnIngoing_Load(sender, e);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txt_TenNCC.Text = "";
            txt_SL.Text = "";
            txt_Total.EditValue = null;
            txt_in.EditValue = null;

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {//EDIT
            var gv = gridView1;

            if (gv.IsDataRow(gv.FocusedRowHandle))

            {

                var lhEdit = new LoHang

                {

                    ID_LoHang = (gv.GetFocusedRow() as LoHang).ID_LoHang,

                    ID_NCC = Convert.ToInt32(txt_TenNCC.EditValue),

                    SoLuong = Convert.ToInt32(txt_SL.EditValue),

                    TongTienNhap = Convert.ToDouble(txt_Total.EditValue),

                    NgayNhap = Convert.ToDateTime(txt_in.EditValue)

                };

                var existingLH = db.LoHangs.FirstOrDefault(n => n.ID_LoHang == lhEdit.ID_LoHang);

                if (existingLH != null)

                {

                    //existingLH.ID_NCC = lhEdit.ID_NCC;

                    existingLH.SoLuong = lhEdit.SoLuong;

                    existingLH.TongTienNhap = lhEdit.TongTienNhap;

                    existingLH.NgayNhap = lhEdit.NgayNhap;

                    // Lưu các thay đổi vào db

                    try

                    {

                        db.SaveChanges();

                    }

                    catch (DbUpdateException ex)

                    {

                  MessageBox.Show("Xung đột khóa ngoại. Vui lòng kiểm tra thông tin nhập.");

                    }

                }

                MnIngoing_Load(sender, e);

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gv = sender as GridView;
            if (gv.IsDataRow(e.FocusedRowHandle))
            {
                var lh = gv.GetFocusedRow() as LoHang;
               // var ncc = db.NhaCungCaps.FirstOrDefault(n => n.ID_NCC == lh.ID_NCC);
                txt_TenNCC.EditValue = lh.ID_NCC;
                txt_SL.EditValue = lh.SoLuong;
                txt_in.EditValue = lh.NgayNhap;
                txt_Total.EditValue = Controller.Instance.FormatCurrency((long)lh.TongTienNhap);


            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {//DELETE
            if (e.Column == colXoa)
            {
                var result = XtraMessageBox.Show("Bạn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = gridView1.GetSelectedRows()[0];
                    LoHang selectedIN = gridView1.GetRow(rowIndex) as LoHang;

                    if (selectedIN != null)
                    {
                        int deleteID = selectedIN.ID_LoHang;

                        db.LoHangs.Attach(selectedIN);
                        db.LoHangs.Remove(selectedIN);
                        db.SaveChanges();


                        var remainingIN = db.LoHangs.Where(n => n.ID_LoHang > deleteID).ToList();

                        foreach (var lh in remainingIN)

                        {

                            lh.ID_LoHang = lh.ID_LoHang - 1;

                        }

                    }
                    MnIngoing_Load(sender, e);
                }
            }
        }
    }
}
