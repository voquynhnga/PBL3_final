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
    public partial class ShiftCCH : Form
    {
        QLCH_3Entities db = new QLCH_3Entities();
        public ShiftCCH()
        {
            InitializeComponent();
        }

        private void ShiftCCH_Load(object sender, EventArgs e)
        {
            lichLamBindingSource.DataSource = db.LichLams.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(textEdit2.EditValue != null)
            {
                //var p = db.LichLams.ToList();
                //foreach (var s in p)
                //{
                //    if (s.Luong == 0)
                //    {
                //        s.Luong = Convert.ToDouble(textEdit2.EditValue);
                //    }
                //}
                if (textEdit2.EditValue != null)
                {
                    var luongToSet = Convert.ToDouble(textEdit2.EditValue);
                    db.Database.ExecuteSqlCommand("UPDATE LichLam SET Luong = @Luong", new SqlParameter("@Luong", luongToSet));
                }

                db.SaveChanges();
            }
            ShiftCCH_Load(sender, e);
        }
    }
}
