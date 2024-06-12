using PBL3.BLL;
using PBL3.DTO_bs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PBL3.GUI_CCH
{
    public partial class fDoanhThu : Form
    {
        public bool pk1 = true;
        int currentYear = DateTime.Now.Month == 12 ? DateTime.Now.Year + 1 : DateTime.Now.Year;
        int currentMonth = DateTime.Now.Month == 12 ? 1 : DateTime.Now.Month + 1;

        public fDoanhThu()
        {
            InitializeComponent();
            int lastDayOfMonth = DateTime.DaysInMonth(currentYear, currentMonth);


            dateTimePicker1.Value = new DateTime(currentYear, currentMonth , 1);

        }

        private void fDoanhThu_Load(object sender, EventArgs e)
        {


            label1.Parent = panelControl1;
            label1.BackColor = System.Drawing.Color.Transparent;






        }





        public void SetSizeColumn()
        {

            float i = dataGridView1.Size.Width;
            dataGridView1.RowHeadersWidth = Convert.ToInt32((i * 0.04));
            dataGridView1.Columns[0].Width = Convert.ToInt32((i * 0.15));
            dataGridView1.Columns[1].Width = Convert.ToInt32((i * 0.26));
            dataGridView1.Columns[2].Width = Convert.ToInt32((i * 0.17));
            dataGridView1.Columns[3].Width = Convert.ToInt32((i * 0.26));
            dataGridView1.Columns[4].Width = Convert.ToInt32((i * 0.26));
            dataGridView1.Columns[5].Width = Convert.ToInt32((i * 0.26));



        }


        private void setPannel2(DateTime d1)
        {
            double[,] a = new double[4, 2];
            double[] b = new double[4];



            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[i, 1] == 0 ? 1 : a[i, 1];
            }

            foreach (ProductTypeReport i in Product_BLL.Instance.GetProductTypeReports(d1))
            {
                if (i.TenLoaiHang == "Giày")
                { a[0, 0] += i.TongTien; a[0, 1] = (a[0, 1] + i.TongTien) / b[0]; }
                if (i.TenLoaiHang == "Dép")
                { a[1, 0] += i.TongTien; a[1, 1] = (a[1, 1] + i.TongTien) / b[1]; }
                if (i.TenLoaiHang == "Sandal")
                { a[2, 0] += i.TongTien; a[2, 1] = (a[2, 1] + i.TongTien) / b[2]; }
                if (i.TenLoaiHang == "Vớ")
                { a[3, 0] += i.TongTien; a[3, 1] = (a[3, 1] + i.TongTien) / b[3]; }
            }



            foreach (ProductTypeReport i in Product_BLL.Instance.GetProductTypeReports(d1))
            {
                if (i.TenLoaiHang == "Giày")
                {
                    SneakerDT.Text = i.TongTien.ToString();
                }
                else if (i.TenLoaiHang == "Dép")
                {
                    PhuKienDT.Text = i.TongTien.ToString();
                }
                else if (i.TenLoaiHang == "Sandal")
                {
                    SandalDT.Text = i.TongTien.ToString();
                }
                else if (i.TenLoaiHang == "Vớ")
                {
                    TatDT.Text = i.TongTien.ToString();
                }
            }


            if (chartControl1 != null && chartControl1.Series.Count > 0)
            {
                // Xóa tất cả các series trong ChartControl
                chartControl1.Series.Clear();
            }



            // Create a new series and add points
            DevExpress.XtraCharts.Series series = new DevExpress.XtraCharts.Series("Doanh thu theo nhóm hàng", DevExpress.XtraCharts.ViewType.Pie);
            series.Label.TextPattern = "{A} : {VP:p0} ";

            string[] productTypes = { "Giày", "Dép", "Sandal", "Vớ" };
            for (int i = 0; i < productTypes.Length; i++)
            {
                series.Points.Add(new DevExpress.XtraCharts.SeriesPoint(productTypes[i], a[i, 0]));
            }

            // Add the series to the chart control
            chartControl1.Series.Add(series);

            // Optionally refresh or update the chart control
            //chartControl1.RefreshData();
        }

        private void setDatagridview(DateTime d1)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = Product_BLL.Instance.GetSalesReport(d1);


            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoThuTu", HeaderText = "STT", DataPropertyName = "SoThuTu" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenHang", HeaderText = "Tên Hàng", DataPropertyName = "TenHang" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenLoaiHang", HeaderText = "Loại Hàng", DataPropertyName = "TenLoaiHang" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoLuong", HeaderText = "Số Lượng", DataPropertyName = "SoLuong" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Gia", HeaderText = "Giá", DataPropertyName = "Gia" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "TongTien", HeaderText = "Tổng Tiền", DataPropertyName = "TongTien" });

            //dataGridView1.Columns["TenHang"].Visible = true;
            //dataGridView1.Columns["TenLoaiHang"].Visible = true;
            //dataGridView1.Columns["SoLuong"].Visible = true;
            //dataGridView1.Columns["Gia"].Visible = true;
            //dataGridView1.Columns["TongTien"].Visible = true;
            //dataGridView1.Columns["SoThuTu"].Visible = true;


        }




        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value;
            setDatagridview(d1);
            SetSizeColumn();
            setPannel2(d1);
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            pk1 = true;

        }
    }
}