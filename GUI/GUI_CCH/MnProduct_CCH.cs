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
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PBL3.BLL;
using System.Data.Entity;

namespace PBL3.GUI_CCH
{
    public partial class MnProduct_CCH : Form
    {
        QLCH_3Entities db = new QLCH_3Entities();
        CultureInfo culture = new CultureInfo("vi-VN");
        //int ID_LoaiHang = 0, ID_LoHang = 0, size_id = 0, color_id = 0,   SoLuong = 0;
        //double Gia_nhap= 0.0, Gia = 0.0;


        public MnProduct_CCH()
        {
            InitializeComponent();


        }
        public int ID_LoaiHang
        {
            get { return Convert.ToInt32(txt_LoaiHang.EditValue); }
        }
        public int product_id
        {
            get { return Convert.ToInt32(txt_TenSP.EditValue); }
        }

        public int ID_LoHang
        {
            get { return Convert.ToInt32(txt_IN.EditValue); }
        }

        public int size_id
        {
            get { return Convert.ToInt32(txt_Size.EditValue); }
        }

        public int color_id
        {
            get { return Convert.ToInt32(txt_Mau.EditValue); }
        }

        public double Gia_nhap
        {
            get
            {
                string value = txt_Pricein.EditValue.ToString();
                return Controller.Instance.ParseCurrency(value); 
            }
        }

        public double Gia
        {
            get
            {
                string value = txt_Priceout.EditValue.ToString();
                return Controller.Instance.ParseCurrency(value); 
            }
        }
        public int SoLuong
        {
            get { return Convert.ToInt32(txt_SL.EditValue); }
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
                int ID_CTSP = (gv.GetFocusedRow() as ChiTietSanPham).ID_CTSP;


                var spEdit = Product_BLL.Instance.GetSP_frUI(ID_CTSP, product_id, ID_LoaiHang, ID_LoHang, size_id, color_id, Gia, Gia_nhap, SoLuong);


                var existingSP = db.ChiTietSanPhams.FirstOrDefault(n => n.ID_CTSP == spEdit.ID_CTSP);

                if (existingSP != null)

                {


                    existingSP.SoLuong = spEdit.SoLuong;
                    existingSP.Gia = spEdit.Gia;
                    existingSP.ID_LoHang = spEdit.ID_LoHang;
                    existingSP.ID_LoaiHang = spEdit.ID_LoaiHang;
                    existingSP.color_id = spEdit.color_id;
                    existingSP.size_id = spEdit.size_id;
                    existingSP.Gia_nhap = spEdit.Gia_nhap;

 

                        db.SaveChanges();

                    



                }

              MnProduct_CCH_Load(sender, e);

            }

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {//ADD
            var gv = gridView1;

            if (gv.IsDataRow(gv.FocusedRowHandle))

            {
                int lastID = db.ChiTietSanPhams.OrderByDescending(x => x.ID_CTSP).FirstOrDefault()?.ID_CTSP ?? 1;
                var Esp = gv.GetFocusedRow() as ChiTietSanPham;
                var Newsp = Product_BLL.Instance.GetSP_frUI(lastID + 1,product_id, ID_LoaiHang, ID_LoHang, size_id, color_id, Gia, Gia_nhap, SoLuong) ;

                if (Product_BLL.Instance.Compare_SP(Esp,Newsp))
                {
                    MessageBox.Show("Sản phẩm này đã tồn tại!");
                }
                else
                {

                   
                    if (Gia_nhap > Gia)
                    {
                        label1.Text = "Giá bán phải cao hơn giá nhập!";
                        txt_Priceout.Focus();
                    }


                    db.ChiTietSanPhams.Add(Newsp);
                    db.SaveChanges();
                    MnProduct_CCH_Load(sender, e);
                }
            }
        }
  

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            txt_TenSP.EditValue = "";
            txt_LoaiHang.EditValue = "";
            txt_Size.EditValue = 0;
            txt_Mau.EditValue = "";
            txt_SL.EditValue = 0;
            txt_Priceout.EditValue = "";
            txt_IN.EditValue = "";
            txt_TenSP.Focus();
            txt_Pricein.EditValue = "";
            var gv = gridView1;
            gv.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
            gv.ClearSelection();


        }



        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            if (e.Column == btnXoa)
            {

                var result = XtraMessageBox.Show("Bạn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
   


                if (result == DialogResult.Yes)
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            int rowIndex = gridView1.GetSelectedRows()[0];
                            ChiTietSanPham selectedSP = gridView1.GetRow(rowIndex) as ChiTietSanPham;

                            if (selectedSP != null)
                            {
                                int deleteID = selectedSP.ID_CTSP;

                                // Xóa các bản ghi liên quan trong bảng ChiTietDonHang
                                var relatedRecords = db.ChiTietDonHangs.Where(dh => dh.ID_CTSP == deleteID).ToList();
                                foreach (var record in relatedRecords)
                                {
                                    db.ChiTietDonHangs.Remove(record);
                                }
                                db.SaveChanges();

                                db.ChiTietSanPhams.Remove(selectedSP);
                                db.SaveChanges();

                               // var remainingSP = db.ChiTietSanPhams.Where(n => n.ID_CTSP > deleteID).OrderBy(n => n.ID_CTSP).ToList();

                                //foreach (var lh in remainingSP)
                                //{
                                //    db.Entry(lh).State = EntityState.Detached;

                                //    lh.ID_CTSP -= 1;

                                //    db.ChiTietSanPhams.Attach(lh);
                                //    db.Entry(lh).Property(x => x.ID_CTSP).IsModified = true;
                                //}

                                //db.SaveChanges();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine(ex.Message);
                        }
                    }
                
            



                }
                MnProduct_CCH_Load(sender, e);

                
 
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
                txt_TenSP.EditValue = sp.product_id;
                txt_SL.EditValue = sp.SoLuong;
                txt_IN.EditValue = sp.ID_LoHang;
                txt_Priceout.EditValue = Controller.Instance.FormatCurrency((long)sp.Gia);
                txt_Mau.EditValue = sp.color_id;
                txt_LoaiHang.EditValue = sp.ID_LoaiHang;
                txt_Size.EditValue = sp.size_id;
                txt_Pricein.EditValue = Controller.Instance.FormatCurrency((long)sp.Gia_nhap);



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




            }
        }



        private void txt_Pricein_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Pricein.Text != "")
            {
                txt_Pricein.Text = Controller.Instance.FormatCurrency(Convert.ToInt64(txt_Pricein.Text));
            }
        }

        private void txt_Priceout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_Priceout.Text != "")
            {
                txt_Priceout.Text = Controller.Instance.FormatCurrency(Convert.ToInt64(txt_Priceout.Text));
            }
        }
    }
}
