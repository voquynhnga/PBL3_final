
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
        public List<string> GetLH(ChiTietSanPham mh)
        {
            int id = (int)mh.ID_LoaiHang;
            var a = DB.LoaiHangs.Where(p => p.ID_LoaiHang == id).Select(p => p.Ten_LoaiHang).ToList();
            return a;
        }
        public List<string> GetAllLH()
        {
            var a = DB.LoaiHangs.Select(p => p.Ten_LoaiHang).ToList();
            return a;
        }

        // Dùng cho bảng
        public List<SalesReportItem> GetSalesReport(DateTime d1, DateTime d2)
        {
            var query = DB.ChiTietDonHangs //ct
            .Join(DB.ChiTietSanPhams /* m */  , ct => ct.ID_CTSP, m => m.ID_CTSP, (ct, m) => new { ct, m })
            .Join(DB.DonHangs /* dh */ , t => t.ct.ID_HoaDon, dh => dh.ID_HoaDon, (t, dh) => new { t, dh })
            .Join(DB.LoaiHangs /*lh*/  , z => z.t.m.ID_LoaiHang, lh => lh.ID_LoaiHang, (z, lh) => new { z, lh })
            .Where(x => x.z.dh.NgayBan >= d1 && x.z.dh.NgayBan <= d2)
            .Select(x => new SalesReportItem
            {
                TenHang = DB.SanPhams.FirstOrDefault(n => x.z.t.m.product_id == n.product_id).product_name,
                TenLoaiHang = x.lh.Ten_LoaiHang,
                SoLuong = x.z.t.ct.SoLuong,
                Gia = x.z.t.m.Gia,
                TongTien = x.z.t.ct.SoLuong * x.z.t.m.Gia
            })
            .ToList();

            return query;
        }

        //Thống kê theo từng Loại hàng
        public List<ProductTypeReport> GetProductTypeReports(DateTime d1, DateTime d2)
        {
            var query = GetSalesReport(d1, d2).GroupBy(x => x.TenLoaiHang)
                                             .Select(g => new ProductTypeReport
                                             {
                                                 TenLoaiHang = g.Key,
                                                 TongTien = g.Sum(iteam => iteam.TongTien)
                                             })
                                             .ToList();
            return query;
            /*var query = DB.ChiTietDonHangs //ct
            .Join(DB.ChiTietSanPhams *//* m *//*  , ct => ct.ID_ChiTietSanPham, m => m.ID_ChiTietSanPham, (ct, m) => new { ct, m })
            .Join(DB.DonHangs *//* dh *//* , t => t.ct.ID_HoaDon, dh => dh.ID_HoaDon, (t, dh) => new { t, dh })
            .Join(DB.LoaiHangs *//*lh*//*  , z => z.t.m.ID_LoaiHang, lh => lh.ID_LoaiHang, (z, lh) => new { z, lh })
            .Where(x => x.z.dh.NgayBan >= d1 && x.z.dh.NgayBan <= d2)
            .GroupBy(y => y.lh.Ten_LoaiHang)
            .Select(y => new ProductTypeReport
            {
                TenLoaiHang = y.Key,
                TongTien = y.Sum(item => item.z.dh.TongTienBan)
            })
            .ToList();

            return query;*/
        }



    }
}
