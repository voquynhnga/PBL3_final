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

namespace PBL3.GUI_CCH
{
    public partial class ReBox : Form
    {
        QLCH_3Entities db = new QLCH_3Entities();
        public ReBox()
        {
            InitializeComponent();
        }


        private DateTime date;

        public ReBox(DateTime date)
        {

            InitializeComponent();
            this.date = date;
            lblDate.Text = "Ngày: " + date.ToShortDateString();
            LoadShiftData();
        }

        private void LoadShiftData()

        {

            var shifts = db.LichLams.Where(l => l.NgayLam == date).ToList();
            chkMorning.Checked = shifts.Any(s => s.CaLam == "Sáng");
            chkAfternoon.Checked = shifts.Any(s => s.CaLam == "Chiều");
            chkEvening.Checked = shifts.Any(s => s.CaLam == "Tối");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var shifts = db.LichLams.Where(l => l.NgayLam == date).ToList();

            if (chkMorning.Checked && !shifts.Any(s => s.CaLam == "Sáng"))
                db.LichLams.Add(new LichLam { NgayLam = date, CaLam = "Sáng", ID_NV = 1 });

            if (chkAfternoon.Checked && !shifts.Any(s => s.CaLam == "Chiều"))
                db.LichLams.Add(new LichLam { NgayLam = date, CaLam = "Chiều", ID_NV = 1 });

            if (chkEvening.Checked && !shifts.Any(s => s.CaLam == "Tối"))
                db.LichLams.Add(new LichLam { NgayLam = date, CaLam = "Tối", ID_NV = 1 });

            if (!chkMorning.Checked && shifts.Any(s => s.CaLam == "Sáng"))
                db.LichLams.Remove(shifts.First(s => s.CaLam == "Sáng"));

            if (!chkAfternoon.Checked && shifts.Any(s => s.CaLam == "Chiều"))
                db.LichLams.Remove(shifts.First(s => s.CaLam == "Chiều"));

            if (!chkEvening.Checked && shifts.Any(s => s.CaLam == "Tối"))
                db.LichLams.Remove(shifts.First(s => s.CaLam == "Tối"));

            db.SaveChanges();
            this.Close();
        }
    }
}
