using PBL3.DAL;
using PBL3_qnv;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    internal class DonHang_BLL
    {

        private QLCH_3Entities DB = new QLCH_3Entities();

        public static DonHang_BLL instance;
        public static DonHang_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DonHang_BLL();
                }
                return instance;
            }
            private set { }
        }
        public void CreateBill(DonHang newbill, List<ChiTietDonHang> ctdh)
        {
            DB.DonHangs.Add(newbill);
            DB.ChiTietDonHangs.AddRange(ctdh);
            DB.SaveChanges();
        }

        
    }
}
