
using DevExpress.XtraEditors.ColorPick.Picker;
using PBL3.DAL;
using PBL3.DTO_bs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class Product_BLL
    {

        private QLCH_3Entities DB = new QLCH_3Entities();

        public static Product_BLL instance;
        public static Product_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Product_BLL();
                }
                return instance;
            }
            private set { }
        }
        //public List<string> GetLH(ChiTietSanPham mh)
        //{
        //    int id = (int)mh.ID_LoaiHang;
        //    var a = DB.LoaiHangs.Where(p => p.ID_LoaiHang == id).Select(p => p.Ten_LoaiHang).ToList();
        //    return a;
        //}
        //public List<string> GetAllLH()
        //{
        //    var a = DB.LoaiHangs.Select(p => p.Ten_LoaiHang).ToList();
        //    return a;
        //}



        public List<SalesReportItem> GetSalesReport(DateTime d1)
        {
            DateTime startDate = new DateTime(d1.Year, d1.Month, 1);
            DateTime endDate = new DateTime(d1.Year, d1.Month, DateTime.DaysInMonth(d1.Year, d1.Month));
            int index = 1;


            var query = DB.ChiTietDonHangs //ct
                .Join(DB.ChiTietSanPhams /* m */, ct => ct.ID_CTSP, m => m.ID_CTSP, (ct, m) => new { ct, m })
                .Join(DB.DonHangs /* dh */, t => t.ct.ID_HoaDon, dh => dh.ID_HoaDon, (t, dh) => new { t, dh })
                .Join(DB.LoaiHangs /*lh*/, z => z.t.m.ID_LoaiHang, lh => lh.ID_LoaiHang, (z, lh) => new { z, lh })
                .Where(x => x.z.dh.NgayBan >= startDate && x.z.dh.NgayBan <= endDate)
                .GroupBy(x => new
                {
                    TenHang = DB.SanPhams.FirstOrDefault(n => x.z.t.m.product_id == n.product_id).product_name,
                    x.lh.Ten_LoaiHang
                })
                .Select(g => new SalesReportItem
                {
                    SoThuTu = 1,
                    TenHang = g.Key.TenHang,
                    TenLoaiHang = g.Key.Ten_LoaiHang,
                    SoLuong = g.Sum(x => x.z.t.ct.SoLuong),
                    Gia = g.FirstOrDefault().z.t.m.Gia,
                    TongTien = g.Sum(x => x.z.t.ct.SoLuong * x.z.t.m.Gia)
                })
                .ToList();

            foreach (var item in query)
            {
                item.SoThuTu = index++;
            }

            return query;
        }


  
        public List<ProductTypeReport> GetProductTypeReports(DateTime d1)
        {
            DateTime startDate = new DateTime(d1.Year, d1.Month, 1);

            var query = GetSalesReport(startDate)
                        .GroupBy(x => x.TenLoaiHang)
                        .Select(g => new ProductTypeReport
                        {
                            TenLoaiHang = g.Key,
                            TongTien = g.Sum(item => item.TongTien)
                        })
                        .ToList();

            return query;
        }
        public ChiTietSanPham GetSP_frUI(int ID, int product_id, int LH_id, int LoH_id, int size_id, int color_id, double gia_ban, double gia_nhap, int SL)
        {
            var sp = new ChiTietSanPham

            {

                ID_CTSP = ID,
                product_id = product_id,
                ID_LoaiHang = LH_id,
                ID_LoHang = LoH_id,
                size_id = size_id,
                color_id = color_id,
                Gia = gia_ban,
                Gia_nhap = gia_nhap,

                SoLuong = SL,





            };
            return sp;


        }
        public bool Compare_SP(ChiTietSanPham a, ChiTietSanPham b)
        {
            if (a == null || b == null)
                return false;

            return
                   a.product_id == b.product_id &&
                   a.ID_LoaiHang == b.ID_LoaiHang &&
                   a.size_id == b.size_id &&
                   a.color_id == b.color_id &&
                   a.ID_LoHang == b.ID_LoHang;
        }




    }
}
