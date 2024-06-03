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
            bool allConditionsMet = true;

            if (txt_Thuong.EditValue == null)

            {

                label1.Text = "Vui lòng nhập tiền thưởng!";

                txt_Thuong.Focus();

                allConditionsMet = false;

            }

            else if (cbb_Ap.EditValue == null)

            {

                label1.Text = "Vui lòng chọn nhân viên!";

                cbb_Ap.Focus();

                allConditionsMet = false;

            }

            else if (dateEdit1.EditValue == null)

            {

                label1.Text = "Vui lòng chọn tháng!";

                dateEdit1.Focus();

                allConditionsMet = false;

            }

            else if(allConditionsMet)

            {

                DateTime dateValue = (DateTime)dateEdit1.EditValue;
                int currentMonth = dateValue.Month;






                for (int i = 0; i < gridView1.RowCount; i++)

                {


                    int dataMonth = Convert.ToInt32(gridView1.GetRowCellValue(i, "NgayLam").ToString().Split('/')[0]);



                    if (dataMonth == currentMonth)

                    {

                        var nhanVienValue = gridView1.GetRowCellValue(i, "NhanVien").ToString();

                        var thuongValue = txt_Thuong.EditValue;

                        if (!string.IsNullOrEmpty(nhanVienValue) && nhanVienValue == cbb_Ap.Text)

                        {


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
                        else MessageBox.Show("Không có dữ liệu của nhân viên " + cbb_Ap.Text + " trong tháng " + currentMonth);
                        cbb_Ap.Focus();

                    }
                    else MessageBox.Show("Không có dữ liệu tháng " + currentMonth + " trong bảng lương!");
                    dateEdit1.Focus();

                }
;


                Salary_Load(sender, e);

            }
        }

        private void Salary_Load(object sender, EventArgs e)
        {

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

            cbb_Ap.EditValue = null;
            dateEdit1.EditValue = null;
            txt_Thuong.EditValue = null;




        }


    }
}
