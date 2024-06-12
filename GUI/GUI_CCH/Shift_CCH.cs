using PBL3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI_CCH
{
    public partial class Shift_CCH : Form
    {
        QLCH_3Entities db = new QLCH_3Entities();
        public Shift_CCH()
        {
            InitializeComponent();
        }

        private void Shift_CCH_Load(object sender, EventArgs e)
        {
            lichLamBindingSource.DataSource = db.LichLams.ToList();
            nhanVienBindingSource.DataSource = db.NhanViens.ToList();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var p = db.LichLams.ToList();
            foreach (var s in p)
            {
                db.Database.ExecuteSqlCommand("UPDATE LichLam SET Luong = @Luong Where ID_NV = @ID_NV",

                                    new SqlParameter("@Luong", textEdit2.EditValue),

                                    new SqlParameter("@ID_NV", s.ID_NV));

                db.SaveChanges();
            }
            Shift_CCH_Load(sender, e);

        }
    }
}
