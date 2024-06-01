using DevExpress.Data;
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
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;
using System.Data.SqlClient;

namespace PBL3.GUI_CCH
{
    public partial class Salary : Form
    {
        QLCH_3Entities db = new QLCH_3Entities();
        public Salary()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < gridView1.RowCount; i++)
            //{

            //    var nhanVienValue = gridView1.GetRowCellValue(i, colNhanVien).ToString();
            //    var thuongValue = txt_Thuong.EditValue;


            //    if (!string.IsNullOrEmpty(nhanVienValue) && nhanVienValue == cbb_Ap.Text)
            //    {
            //        db.Database.ExecuteSqlCommand("UPDATE LichLam SET Thuong = @Thuong", new SqlParameter("@Thuong", thuongValue));

            //    }
            //}
            //Salary_Load(sender, e);

            int currentMonth = DateTime.Now.Month;



            for (int i = 0; i < gridView1.RowCount; i++)

            {

                // Lấy tháng của dữ liệu trong gridControl1

                int dataMonth = Convert.ToInt32(gridView1.GetRowCellValue(i, "NgayLam").ToString().Split('/')[0]);



                if (dataMonth == currentMonth)

                {

                    var nhanVienValue = gridView1.GetRowCellValue(i, "NhanVien").ToString();

                    var thuongValue = txt_Thuong.EditValue;

                    if (!string.IsNullOrEmpty(nhanVienValue) && nhanVienValue == cbb_Ap.Text)

                    {

                        // Cập nhật dữ liệu vào cột "Thuong" cho hàng tương ứng

                        gridView1.SetRowCellValue(i, "Thuong", thuongValue);


                        int idNV = Convert.ToInt32(gridView1.GetRowCellValue(i, "ID_NV"));

                        var lichLam = db.LichLams.FirstOrDefault(x => x.ID_NV == idNV && x.NgayLam.Month == currentMonth);

                        if (lichLam != null)

                        {

                            db.Database.ExecuteSqlCommand("UPDATE LichLam SET Thuong = @Thuong Where ID_NV = @ID_NV",

                                new SqlParameter("@Thuong", thuongValue),

                                new SqlParameter("@ID_NV", idNV));

                            db.SaveChanges();

                        }

                    }

                }

            }

            Salary_Load(sender, e);


        }

        private void Salary_Load(object sender, EventArgs e)
        {
            //FIXINGGGGGG

            //lichLamBindingSource.DataSource = db.LichLams.ToList();
            nhanVienBindingSource.DataSource = db.NhanViens.ToList();
            var data = db.LichLams.GroupBy(x => new { x.NgayLam.Month, x.NgayLam.Year })
                                  .Select(grp => new
                                  {
                                      ID_NV = grp.FirstOrDefault().ID_NV,
                                      NhanVien = grp.FirstOrDefault().NhanVien.NameNV,
                                      NgayLam = grp.Key.Month + "/" + grp.FirstOrDefault().NgayLam.Year,
                                      Luong = grp.Sum(y => y.Luong),
                                      Thuong = grp.FirstOrDefault().Thuong
                                  }).ToList();
            lichLamBindingSource.DataSource = data;




        }


        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

        }
    }
}
