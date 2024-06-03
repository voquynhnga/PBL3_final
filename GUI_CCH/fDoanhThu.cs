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
        public fDoanhThu()
        {
            InitializeComponent();
        }

        private void fDoanhThu_Load(object sender, EventArgs e)
        {


            label1.Parent = panelControl1;
            label1.BackColor = System.Drawing.Color.Transparent;

            label2.Parent = panelControl1;
            label2.BackColor = System.Drawing.Color.Transparent;

            /*groupBox1.Parent = panelControl1;
            groupBox1.BackColor = System.Drawing.Color.FromArgb(86,89,100);

            groupBox2.Parent = panelControl1;
            groupBox2.BackColor = System.Drawing.Color.Transparent;

            groupBox3.Parent = panelControl1;
            groupBox3.BackColor = System.Drawing.Color.Transparent;

            groupBox4.Parent = panelControl1;
            groupBox4.BackColor = System.Drawing.Color.Transparent;*/
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DateTime d1 = dateTimePicker1.Value;
            DateTime d2 = dateTimePicker2.Value;

            if (d1 >= d2)
            {
                if (pk1)
                {
                    MessageBox.Show("Chọn Thời gian không hợp lý");
                    dateTimePicker1.Value = d2.AddDays(-1);
                    return;
                }
                if (!pk1)
                {
                    MessageBox.Show("Chọn Thời gian không hợp lý");
                    dateTimePicker2.Value = d1.AddDays(1);
                    return;
                }
            }
            setDatagridview(d1, d2);
            SetSizeColumn();
            setPannel2(d1, d2);
        }
       
        public void SetSizeColumn()
        {

            float i = dataGridView1.Size.Width;
            dataGridView1.Columns.RemoveAt(1);
            dataGridView1.RowHeadersWidth = Convert.ToInt32((i * 0.04));
            dataGridView1.Columns[0].Width = Convert.ToInt32((i * 0.26));
            dataGridView1.Columns[1].Width = Convert.ToInt32((i * 0.26));
            dataGridView1.Columns[2].Width = Convert.ToInt32((i * 0.17));
            dataGridView1.Columns[3].Width = Convert.ToInt32((i * 0.26));
            //dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void setPannel2(DateTime d1, DateTime d2)
        {
            ProductTypeReport ptr = new ProductTypeReport();
            Product_BLL bll = new Product_BLL();
            double[,] a = new double[4, 2];
            foreach (ProductTypeReport i in bll.GetProductTypeReports(d1, d1))
            {
                if (i.TenLoaiHang == "Sneaker")
                { a[0, 0] += i.TongTien; a[0, 1] = (i.TongTien); }
                if (i.TenLoaiHang == "Phụ kiện")
                { a[1, 0] += i.TongTien; a[1, 1] = (i.TongTien); }
                if (i.TenLoaiHang == "Sandal")
                { a[2, 0] += i.TongTien; a[2, 1] = (i.TongTien); }
                if (i.TenLoaiHang == "Tất")
                { a[3, 0] += i.TongTien; a[3, 1] = (i.TongTien); }
            }
            double[] b = new double[4];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == 0)
                {
                    b[i] = 1;
                }
                else if (b[i] != 0)
                {
                    b[i] = a[i, 1];
                }
            }
            foreach (ProductTypeReport i in bll.GetProductTypeReports(d2, d2))
            {
                if (i.TenLoaiHang == "Giày")
                { a[0, 0] += i.TongTien; a[0, 1] = (a[0, 1] + i.TongTien) / (b[0]); }
                if (i.TenLoaiHang == "Dép")
                { a[1, 0] += i.TongTien; a[1, 1] = (a[1, 1] + i.TongTien) / (b[1]); }
                if (i.TenLoaiHang == "Sandal")
                { a[2, 0] += i.TongTien; a[2, 1] = (a[2, 1] + i.TongTien) / (b[2]); }
                if (i.TenLoaiHang == "Vớ")
                { a[3, 0] += i.TongTien; a[3, 1] = (a[3, 1] + i.TongTien) / (b[3]); }
            }
            SneakerDT.Text = a[0, 0].ToString();
            TextSNK.Text = a[0, 1].ToString();


            PhuKienDT.Text = a[1, 0].ToString();
            TextPK.Text = a[1, 1].ToString();

            SandalDT.Text = a[2, 0].ToString();
            TextSD.Text = a[2, 1].ToString();

            TatDT.Text = a[3, 0].ToString();
            TextTat.Text = a[3, 1].ToString();

            int j = 0;
            //chartDT.Series["DoanhThu"].Points.Clear();

            chartControl1.Series.Add("Doanh thu theo nhóm hàng", DevExpress.XtraCharts.ViewType.Pie);
            chartControl1.Series["Doanh thu theo nhóm hàng"].Label.TextPattern = "{A} : {VP:p0} ";

            foreach (string i in bll.GetAllLH())
            {
                //chartDT.Series["DoanhThu"].Points.AddXY(i, a[j, 0]);
                chartControl1.Series["Doanh thu theo nhóm hàng"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(i, a[j, 0]                    ));

                j++;
            }
        }
        private void setDatagridview(DateTime d1, DateTime d2)
        {
            Product_BLL bll = new Product_BLL();
            dataGridView1.DataSource = bll.GetSalesReport(d1, d2);
        }


  

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            pk1 = true;

        }
    }
}
