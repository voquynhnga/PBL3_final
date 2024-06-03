using DevExpress.Utils.About;
using DevExpress.XtraCharts.Design;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PBL3.DAL;
using PBL3.DTO_bs;
using PBL3_qnv;
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

namespace PBL3.GUI_CCH
{
    public partial class MnProduct_CCH : Form
    {
        QLCH_3Entities db = new QLCH_3Entities();
        public MnProduct_CCH()
        {
            InitializeComponent();
        }

        private List<ProductInCM> products = new List<ProductInCM>();

        private void MnProduct_CCH_Load(object sender, EventArgs e)
        {
            var data_LH = db.LoaiHangs.Select(p => new { p.ID_LoaiHang, p.Ten_LoaiHang });
            txt_LoaiHang.Properties.DataSource = data_LH.ToList();
            txt_LoaiHang.Properties.ValueMember = "ID_LoaiHang";
            txt_LoaiHang.Properties.DisplayMember = "Ten_LoaiHang";
      




            var data_Mau = db.Colors.Select(p => new { p.color_id, p.color_name });
            txt_Mau.Properties.DataSource = data_Mau.ToList();
            txt_Mau.Properties.ValueMember = "color_id";
            txt_Mau.Properties.DisplayMember = "color_name";
         




            var data_Size = db.Sizes.Select(p => new { p.size_id, p.size_value });
            txt_Size.Properties.DataSource = data_Size.ToList();
            txt_Size.Properties.ValueMember = "size_id";
            txt_Size.Properties.DisplayMember = "size_value";
  





            var data_LoH = db.LoHangs.Select(p => new { p.ID_LoHang }).ToList();

            txt_IN.Properties.DataSource = data_LoH;

            txt_IN.Properties.DisplayMember = "ID_LoHang";
            txt_IN.Properties.ValueMember = "ID_LoHang"; // Uncomment if needed


            var data_SP = db.SanPhams.Select(p => new { p.product_id, p.product_name }).ToList();
            txt_TenSP.Properties.DataSource = data_SP;

            txt_TenSP.Properties.DisplayMember = "product_name";
            txt_TenSP.Properties.ValueMember = "product_id";


            chiTietSanPhamBindingSource.DataSource = db.ChiTietSanPhams.ToList();
            sanPhamBindingSource.DataSource = db.SanPhams.ToList();
            loaiHangBindingSource.DataSource = db.LoaiHangs.ToList();
            loHangBindingSource.DataSource = db.LoHangs.ToList();
            sizeBindingSource.DataSource = db.Sizes.ToList();
            colorBindingSource1.DataSource = db.Colors.ToList();



        }

        private void btn_Edit_Click_1(object sender, EventArgs e)
        {
 
            var gv = gridView1;

            if (gv.IsDataRow(gv.FocusedRowHandle))

            {

                var spEdit = new ChiTietSanPham

                {

                    ID_CTSP = (gv.GetFocusedRow() as ChiTietSanPham).ID_CTSP,

                    ID_LoaiHang = Convert.ToInt32(txt_LoaiHang.EditValue),
                    ID_LoHang = Convert.ToInt32(txt_IN.EditValue),
                    size_id = Convert.ToInt32(txt_Size.EditValue),
                    color_id = Convert.ToInt32(txt_Mau.EditValue),
                    Gia = Convert.ToDouble(txt_Priceout.EditValue),
                    Gia_nhap = Convert.ToDouble(txt_Pricein.EditValue),



                    SoLuong = Convert.ToInt32(txt_SL.EditValue),


               

                };

                var existingSP = db.ChiTietSanPhams.FirstOrDefault(n => n.ID_CTSP == spEdit.ID_CTSP);

                if (existingSP != null)

                {

                    //existingLH.ID_NCC = lhEdit.ID_NCC;

                    existingSP.SoLuong = spEdit.SoLuong;
                    existingSP.Gia = spEdit.Gia;
                    existingSP.Gia_nhap = spEdit.Gia_nhap;
                    existingSP.ID_LoHang = spEdit.ID_LoHang;
                    existingSP.ID_LoaiHang = spEdit.ID_LoaiHang;
                    existingSP.color_id = spEdit.color_id;
                    existingSP.size_id = spEdit.size_id;
                    try

                    {

                        db.SaveChanges();

                    }

                    catch (DbUpdateException ex)

                    {

                        MessageBox.Show("Xung đột khóa ngoại. Vui lòng kiểm tra thông tin nhập.");

                    }

                }

              MnProduct_CCH_Load(sender, e);

            }

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {//ADD


            int lastID = db.ChiTietSanPhams.OrderByDescending(x => x.ID_CTSP).FirstOrDefault()?.ID_CTSP ?? 0;

            ChiTietSanPham sp = new ChiTietSanPham
            {



                ID_CTSP = lastID + 1,
                ID_LoaiHang = Convert.ToInt32(txt_LoaiHang.EditValue),
                product_id = Convert.ToInt32(txt_TenSP.EditValue),
                size_id = Convert.ToInt32(txt_Size.EditValue),
                color_id = Convert.ToInt32(txt_Mau.EditValue),
                ID_LoHang = Convert.ToInt32(txt_IN.EditValue),
                SoLuong = Convert.ToInt32(txt_SL.EditValue),
                Gia = Convert.ToDouble(txt_Priceout.EditValue),
                Gia_nhap = Convert.ToDouble(txt_Pricein.EditValue)


                //product_id = Te

                //Luong = 0,
                // TaiKhoan = "";



            };
            db.ChiTietSanPhams.Add(sp);
            db.SaveChanges();
            //ReloadGridView();
            MnProduct_CCH_Load(sender, e);
        }
  

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            txt_TenSP.Text = "";
            txt_LoaiHang.Text = "";
            txt_Size.EditValue = 0;
            txt_Mau.Text = "";
            txt_SL.EditValue = 0;
            txt_Pricein.EditValue = 0;
            txt_IN.EditValue = 0;
            txt_Priceout.EditValue = 0;
            txt_TenSP.Focus();

        }

 

        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column == btnXoa)
            { 

                var result = XtraMessageBox.Show("Bạn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = gridView1.GetSelectedRows()[0];
                    //ProductInCM selectedIN = gridView1.GetRow(rowIndex) as LoHang;
                    ChiTietSanPham selectedSP = gridView1.GetRow(rowIndex) as ChiTietSanPham;

                    if (selectedSP != null)
                    {
                        int deleteID = selectedSP.ID_CTSP;

                        //db.ChiTietSanPhams.Attach(selectedSP);
                        db.ChiTietSanPhams.Remove(selectedSP);
                        db.SaveChanges();


                        //gridControl1.DataSource = null;

                        //gridControl1.DataSource = db.LoHangs.ToList();

                        var remainingSP = db.ChiTietSanPhams.Where(n => n.ID_CTSP > deleteID).ToList();

                        foreach (var lh in remainingSP)

                        {

                            lh.ID_CTSP = lh.ID_CTSP - 1;

                        }

                    }
                    MnProduct_CCH_Load(sender, e);

                }
               // gridControl1.DataSource = null;
                //gridControl1.DataSource = products;
            }

        }

        private void UpdateDataSource()
        {
            var data_SP = db.SanPhams.Select(p => new { p.product_id, p.product_name }).ToList();
            txt_TenSP.Properties.DataSource = data_SP;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var gv = sender as GridView;
            if (gv.IsDataRow(e.FocusedRowHandle))
            {
                var sp = gv.GetFocusedRow() as ChiTietSanPham;
                // var ncc = db.NhaCungCaps.FirstOrDefault(n => n.ID_NCC == lh.ID_NCC);
                txt_TenSP.EditValue = sp.product_id;
                txt_SL.EditValue = sp.SoLuong;
                txt_IN.EditValue = sp.ID_LoHang;
                txt_Pricein.EditValue = sp.Gia_nhap;
                txt_Mau.EditValue = sp.color_id;
                txt_LoaiHang.EditValue = sp.ID_LoaiHang;
                txt_Size.EditValue = sp.size_id;
                txt_Priceout.EditValue = sp.Gia;


            }
        }

        private void txt_TenSP_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
        {
            if (e.DisplayValue == null || string.IsNullOrEmpty(e.DisplayValue.ToString()))
                return;

            var newSP_name = e.DisplayValue.ToString();

            var existingSP = db.SanPhams.FirstOrDefault(p => p.product_name == newSP_name);
            if (existingSP == null)
            {
                int lastID = db.SanPhams.OrderByDescending(x => x.product_id).FirstOrDefault()?.product_id ?? 0;

                var newSP = new SanPham
                {
                    product_name = newSP_name,
                    product_id = lastID + 1,
                };
                db.SanPhams.Add(newSP);
                db.SaveChanges();
                txt_TenSP.EditValue = newSP.product_id;
                UpdateDataSource();

                //var data_SP = db.SanPhams.Select(p => new { p.product_id, p.product_name }).ToList();
                //txt_TenSP.Properties.DataSource = data_SP;
                //txt_TenSP_ProcessNewValue_1(sender, e);



            }
        }


    }
}
