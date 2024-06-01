using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
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

namespace PBL3.GUI_NV
{
    public partial class Bill1 : Form
    {
        Main_NV mf = Application.OpenForms["Main_NV"] as Main_NV;
        public static Bill1 Instance_bill;


        public Bill1()
        {
            InitializeComponent();
            Load_Bill();
            Instance_bill = this;
        }

        private void Load_Bill()
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
        }

  




        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            KhachHang cus = new KhachHang();
            if (textBox1 != null)
            {
                cus = Controller.Instance.GetKH_SearchBill(textBox1.Text);
                if (cus != null)
                {
                    textBox2.Text = cus.NameKH.ToString();
                    textBox3.Text = cus.GT.ToString();
                    textBox4.Text = cus.DTL.ToString();
                }
                else
                {
                    XtraMessageBox.Show("Khách hàng mới, chưa được lưu");
                    mf.OpenChildForm(new Customer());
                }

            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            Order orderForm = Order.Instance;

            if (orderForm != null)

            {

                // this.Hide();
                mf.OpenChildForm(orderForm);

            }
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mf.OpenChildForm(new FinalBill());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                textBox6.Text = "- " + textBox4.Text;
                textBox7.Text = (Convert.ToDouble(Order.Instance.textBox3.Text) - Convert.ToDouble(textBox4.Text)).ToString();

            }
        }
    }
}
