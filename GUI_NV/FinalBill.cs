using DevExpress.XtraWaitForm;
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
using PBL3.GUI_NV;
using PBL3_qnv;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using PBL3.DTO_bs;
using PBL3.BLL;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Button = System.Windows.Forms.Button;

namespace PBL3.GUI_NV
{
    public partial class FinalBill : Form
    {
        Main_NV mf = Application.OpenForms["Main_NV"] as Main_NV;
        // Bill1 b1 = Bill1.Instance_bill;
        //QLCH_3Entities DB = new QLCH_3Entities();
        //private readonly UnitOfWork _unitOfWork;
        QLCH_3Entities db = new QLCH_3Entities();


        public FinalBill()
        {
            InitializeComponent();
            Load_FinalBill();
        }

        private void FinalBill_Load(object sender, EventArgs e)
        {
            label3.Parent = customPanel1;
            label3.BackColor = System.Drawing.Color.Transparent;

            label4.Parent = customPanel1;
            label4.BackColor = System.Drawing.Color.Transparent;

            label5.Parent = customPanel1;
            label5.BackColor = System.Drawing.Color.Transparent;

            label6.Parent = customPanel1;
            label6.BackColor = System.Drawing.Color.Transparent;

            radioButton1.Parent = customPanel1;
            radioButton1.BackColor = System.Drawing.Color.Transparent;
            groupBox1.Hide();

        }

        private void Load_FinalBill()
        {
            // Order orderForm = Application.OpenForms["OrderForm"] as Order;
            List<Button> buttons = new List<Button>();
            if (Order.Instance != null)
            {
                buttons = Order.Instance.Getbutton();
                
                foreach (Button btn in buttons)
                {
                    Button newBtn = new Button();

                    newBtn.Text = btn.Text;

                    newBtn.Size = btn.Size;

                    newBtn.BackColor = btn.BackColor;
                    // Gán các thuộc tính khác của newBtn dựa trên btn
                    // Thêm newBtn vào FlowLayoutPanel của BillForm
                    this.flowLayoutPanel1.Controls.Add(newBtn);

                  }


            }
            int lastID = db.DonHangs.OrderByDescending(x => x.ID_HoaDon).FirstOrDefault()?.ID_HoaDon ?? 1;
            textBox4.Text = lastID.ToString();
            textBox1.Text = Bill1.Instance_bill.textBox7.Text;
        }

        public DonHang Get_DonHang()
        {


            var kh = db.KhachHangs.FirstOrDefault(n => n.NameKH == Bill1.Instance_bill.textBox2.Text);
            int nvID; // Biến để lưu ID_NV hợp lệ
            int user_ID = Controller.Instance.Get_ID(Controller.user.TaiKhoan1);
            if (Controller.user != null)
            {
                var nv = db.NhanViens.FirstOrDefault(n => n.ID_NV == user_ID);
                nvID = nv.ID_NV;
            }
            else
            {
                // Xử lý khi Controller.user không tồn tại
                nvID = 100; // Có thể là 0 hoặc giá trị mặc định khác
            }
            DonHang dh = new DonHang()
            {
                ID_HoaDon = Convert.ToInt32(textBox4.Text),
                ID_KH = kh.ID_KH,
                ID_NV = nvID,
                NgayBan = DateTime.Now,
                TongTienBan = Convert.ToDouble(textBox1.Text)
            };

            return dh;



        }
        public void CompleteBill()
        {
            DonHang newBill = Get_DonHang();
            List<ChiTietDonHang> ctdh = new List<ChiTietDonHang>();
            List<ChiTietSanPham> dh = new List<ChiTietSanPham>();


            foreach(Control control in flowLayoutPanel1.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;

                    string[] btnInfo = btn.Text.Split(',');
                    string btnName = btnInfo[0].Trim();
                    var pr = db.SanPhams.FirstOrDefault(p => p.product_name == btnName);
                    var pr_d = db.ChiTietSanPhams.FirstOrDefault(p => p.ID_CTSP == pr.product_id);

                    ChiTietDonHang i = new ChiTietDonHang
                    {

                        ID_HoaDon = newBill.ID_HoaDon,
                        ID_CTSP = pr_d.ID_CTSP,
                        GiaBan = pr_d.Gia,
                        SoLuong = int.Parse(btnInfo[3].Trim())
                    };
                    ctdh.Add(i);
                }
            }

            db.DonHangs.Add(newBill);
            db.ChiTietDonHangs.AddRange(ctdh);
            db.SaveChanges();
            DeleteProduct(ctdh);
        }

        public bool DeleteProduct(List<ChiTietDonHang> ctdh)
        {
            //DELIST null
            foreach (var i in ctdh)
            {
                var query = db.ChiTietSanPhams.FirstOrDefault(r => r.ID_CTSP == i.ID_CTSP);
                if (query != null)
                {
                    query.SoLuong -= i.SoLuong;
                    db.SaveChanges();
                }
            }
            return true;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận hủy", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
                mf.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ///FIXING
            CompleteBill();
            this.Close();
            Bill1.Instance_bill.Close();
            Order.Instance.Close();
            mf.Show();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)

            //{

            //    textBox3.Text = (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text)).ToString();

            //}
            if (e.KeyCode == Keys.Enter && textBox1.Text != "")
            {

                double tientralai = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text);
                if (tientralai >= 0)
                {
                    textBox3.Text = (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text)).ToString() + "đ";
                }
                else if (tientralai < 0)
                {
                    MessageBox.Show("Điền lại tiền của Khách trả\nSố tiền không đúng. Không đủ tiền trả");
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SelectAPaymentMethod();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SelectAPaymentMethod();
        }


        public void SelectAPaymentMethod()
        {

            if (radioButton1.Checked == false)
            {
                groupBox1.Hide();
            }
            if (radioButton1.Checked != false)
            {
                groupBox1.Show();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
