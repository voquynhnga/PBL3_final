using DevExpress.Data.Linq;
using PBL3.DAL;
using PBL3_qnv;
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
using Color = System.Drawing.Color;

namespace PBL3.GUI_CCH
{
    public partial class Shift : Form
    {
        QLCH_3Entities DB = new QLCH_3Entities();
<<<<<<< HEAD
=======
        List<(DateTime Day, string ShiftTime)> selectedShifts = new List<(DateTime Day, string ShiftTime)>();

>>>>>>> 85abff1a886188270143c988969a866dbdb94731
        public Shift()
        {
            InitializeComponent();
            Load += Shift_Load;
   
        }





        private void LoadCalendar()
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            var shifts = DB.LichLams
                .Where(l => l.NgayLam >= startDate && l.NgayLam <= endDate)
                .ToList();

            tableLayoutPanel.Controls.Clear();
            CreateHeaderRow(); 

            int dayOffset = (int)startDate.DayOfWeek - 1;
            if (dayOffset < 0) dayOffset = 6; 

            for (int i = 0; i < 5; i++) { 
                for (int j = 0; j < 7; j++)  
                {
                    int dayNumber = i * 7 + j - dayOffset + 1;
                    if (dayNumber > 0 && dayNumber <= endDate.Day)
                    {
                        DateTime day = new DateTime(year, month, dayNumber);
                        Panel dayPanel = CreateDayPanel(day, shifts);
                        tableLayoutPanel.Controls.Add(dayPanel, j, i + 1); // Add to row i + 1 to account for header row
                    }
                    else
                    {
                        Panel emptyPanel = new Panel
                        {
                            BorderStyle = BorderStyle.FixedSingle,
                            Dock = DockStyle.Fill,
                            Margin = new Padding(1)
                        };
                        tableLayoutPanel.Controls.Add(emptyPanel, j, i + 1); // Add empty panel
                    }
                }
            }
        }

        private void CreateHeaderRow()
        {
            string[] daysOfWeek = { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ nhật" };
            for (int j = 0; j < 7; j++)
            {
                Label lblDay = new Label
                {
                    Text = daysOfWeek[j],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.BottomCenter,
                    BackColor = Color.LightGray,
                    Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold)
                };
                tableLayoutPanel.Controls.Add(lblDay, j, 0); 
            }
        }


        private Panel CreateDayPanel(DateTime day, List<LichLam> shifts)
        {
            Panel panel = new Panel
            {
                BackColor = Color.LightGreen,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Margin = new Padding(1)
            };

            Label lblDate = new Label
            {
                Text = day.Day.ToString(),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(lblDate);

            string[] shiftTimes = { "Sáng", "Chiều", "Tối" };
            foreach (string shiftTime in shiftTimes)
            {
                var existingShift = shifts.FirstOrDefault(s => s.NgayLam == day && s.CaLam == shiftTime);

                CheckBox chkShift = new CheckBox
                {
                    Text = shiftTime,
                    Dock = DockStyle.Top,
                    Checked = existingShift != null,
                    Enabled = existingShift == null,
                    ForeColor = existingShift != null ? Color.Red : Color.Black
                };
                chkShift.Tag = new { Day = day, ShiftTime = shiftTime };
                chkShift.CheckedChanged += ChkShift_CheckedChanged;
                panel.Controls.Add(chkShift);
            }

            return panel;
        }

        private void ChkShift_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkShift = sender as CheckBox;
            if (chkShift != null && chkShift.Checked)
            {
                var data = (dynamic)chkShift.Tag;
                DateTime day = data.Day;
                string shiftTime = data.ShiftTime;

<<<<<<< HEAD
                // Save the new shift registration to the database
                SaveShiftRegistration(day, shiftTime);
=======
                selectedShifts.Add((day, shiftTime));
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
            }
        }

        private void SaveShiftRegistration(DateTime day, string shiftTime)
        {
            int user_ID = Controller.Instance.Get_ID(Controller.user.TaiKhoan1);

<<<<<<< HEAD
            //LichLam newShift = new LichLam
            //{
            //    ID_NV = user_ID,
            //    NgayLam = day,
            //    CaLam = shiftTime,
            //    Luong = 0.0,
            //};

            //DB.LichLams.Add(newShift);
            //DB.SaveChanges();

            DB.Database.ExecuteSqlCommand(
           "EXEC InsertLichLam @ID_NV, @NgayLam, @CaLam, @Luong",
           new SqlParameter("@ID_NV", user_ID),
           new SqlParameter("@NgayLam", day),
           new SqlParameter("@CaLam", shiftTime),
           new SqlParameter("@Luong", 0.0)
           
       );
=======
            DB.Database.ExecuteSqlCommand(

    "EXEC InsertLichLam @ID_NV, @NgayLam, @CaLam, @Luong",

    new SqlParameter("@ID_NV", user_ID),

    new SqlParameter("@NgayLam", SqlDbType.DateTime) { Value = day },

    new SqlParameter("@CaLam", SqlDbType.NVarChar) { Value = shiftTime },

    new SqlParameter("@Luong", SqlDbType.Float) { Value = 0.0 }

);
>>>>>>> 85abff1a886188270143c988969a866dbdb94731

            LoadCalendar();
        }

<<<<<<< HEAD



        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegisterShift_Click_1(object sender, EventArgs e)
        {
            // ShowShiftRegistrationForm(dateTimePicker.Value);
            LoadCalendar();
=======
        private void btnRegisterShift_Click_1(object sender, EventArgs e)
        {
            // ShowShiftRegistrationForm(dateTimePicker.Value);
            foreach (var shift in selectedShifts)

            {

                SaveShiftRegistration(shift.Day, shift.ShiftTime);

            }
            //LoadCalendar();
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
        }

        private void Shift_Load(object sender, EventArgs e)
        {
            LoadCalendar();

        }

        private void dateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            LoadCalendar();
        }

        //private void cmbMonth_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (cmbMonth.SelectedItem == null)
        //    {
        //        MessageBox.Show("Vui lòng chọn tháng.");
        //        return;
        //    }
        //    LoadCalendar();
        //}

        //private void cmbYear_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    if (cmbYear.SelectedItem == null)
        //    {
        //        MessageBox.Show("Vui lòng chọn năm.");
        //        return;
        //    }
        //    LoadCalendar();
        //}
    }
}
