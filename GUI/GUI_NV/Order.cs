

using PBL3_qnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO_bs;
using PBL3.GUI_CCH;
using DevExpress.XtraWaitForm;
using DevExpress.XtraEditors;
using PBL3.DAL;

namespace PBL3.GUI_NV
{
    public partial class Order : Form
    {
        ManageProduct m = new ManageProduct();
        Main_NV mf = Application.OpenForms["Main_NV"] as Main_NV;
        public static Order Instance;
        QLCH_3Entities db = new QLCH_3Entities();

        public Order()
        {
            InitializeComponent();
            m.AddProductEvent += AddProduct;
            Instance = this;
            //label6.BackColor = SystemColors.Transparent;
        }

        private void AddProduct(object sender, EventArgs e)
        {
            if (m.product != null)
            {
                textBox4.Text = m.product.SoLuong.ToString();
                var p = db.SanPhams.FirstOrDefault(s => s.product_id == m.product.product_id);
                richTextBox1.Text = p.product_name;

                textBox1.Text = m.product.Gia.ToString();
            }

            richTextBox1.Text = m.product.SanPham.product_name;
            textBox1.Text = FormatCurrency((long)m.product.Gia);
            textBox10.Text = m.product.Size.size_value.ToString();
            textBox11.Text = m.product.Color.color_name.ToString();
            numericUpDown1.Value = 1;
        }

        public void LoadProduct(Item pi)
        {
            bool isProductExist = false;
            foreach (Control control in fl.Controls)
            {
                if (control is Button btn)
                {
                    string[] btnInfo = btn.Text.Split(',');
                    string btnName = btnInfo[0].Trim();
                    string btnSize = btnInfo[1].Trim();
                    string btnColor = btnInfo[2].Trim();
                    float btnPrice = float.Parse(btnInfo[4].Trim());
                    int btnSL = int.Parse(btnInfo[3].Trim());
                    if ( (pi.Name.Trim() == btnName.Trim()) && (pi.Size.Trim() == btnSize.Trim()))
                    {
                        if (pi.Color.Trim() == btnColor.Trim())
                        {
                            btnSL += pi.SL;
                            btn.Text = $"{btnName}, {btnSize}, {btnColor}, {btnSL},{btnPrice}";
                            btn.Font = new Font("Arial", 10, FontStyle.Bold);
                            btn.ForeColor = System.Drawing.Color.White;
                            btn.BackColor = System.Drawing.Color.Green;
                            isProductExist = true;
                            break;
                        }
                    }
                }
            }
            if (!isProductExist)
            {
                Button btn = new Button()
                {
                    Width = Item.Width,
                    Height = Item.Height,
                    Text = FormatButtonText(pi.Name, pi.Size, pi.Color, pi.SL, pi.Price),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = System.Drawing.Color.White,
                    BackColor = System.Drawing.Color.Green,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                fl.Controls.Add(btn);
            }
        }

        private string FormatButtonText(string name, string size, string color, int quantity, double price)
        {
            return $"{name}, {size}, {color}, {quantity}, {price:F2}";
        }

        private void Total_price()
        {
            float Total_price = 0;

            foreach (Control control in fl.Controls)
            {
                if (control is Button btn)
                {
                    string[] btnInfo = btn.Text.Split(',');
                    int SL = int.Parse(btnInfo[3].Trim());
                    float Price = float.Parse(btnInfo[4]);
                    Total_price += SL * Price;
                }
            }
            textBox3.Text = FormatCurrency((long)Total_price);
        }

        public List<Button> Getbutton()
        {
            List<Button> b = new List<Button>();
            foreach (Control control in fl.Controls)
            {
                if (control is Button btn)
                {
                    string[] btnInfo = btn.Text.Split(',');
                    string btnName = btnInfo[0].Trim();
                    string btnSize = btnInfo[1].Trim();
                    string btnColor = btnInfo[2].Trim();
                    float btnPrice = float.Parse(btnInfo[4].Trim());
                    int btnSL = int.Parse(btnInfo[3].Trim());
                    b.Add(btn);
                }
            }
            return b;
        }

        public Item get_Item()
        {
            var n = db.SanPhams.FirstOrDefault(k => m.product.product_id == k.product_id);

            Item pi = new Item()
            {
                ID = m.product.ID_CTSP,
                Name = n.product_name,
                Size = textBox10.Text,
                Color = textBox11.Text,
                Price = m.product.Gia,
                SL = (int)numericUpDown1.Value
            };
            return pi;
        }

        private void bTT_Click_1(object sender, EventArgs e)
        {
            if (fl.Controls.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào giỏ hàng");
            }
            else
            {
                mf.OpenChildForm(new FinalBill());
            }
        }

        private void bAdd_Click_1(object sender, EventArgs e)
        {
            m.ShowDialog();
        }

        private void bCancel_Click_1(object sender, EventArgs e)
        {
            for (int i = fl.Controls.Count - 1; i >= 0; i--)
            {
                Control control = fl.Controls[i];
                if (control is Button)
                {
                    fl.Controls.Remove(control);
                    control.Dispose();
                }
            }
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            textBox10.Text = "";
            textBox11.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


            richTextBox1.Text = "";
            pictureBox2.Image = null;
            numericUpDown1.Value = 1;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            KhachHang cus = new KhachHang();
            if (!string.IsNullOrWhiteSpace(textBox5.Text))
            {
                cus = Controller.Instance.GetKH_SearchBill(textBox5.Text);
                if (cus != null)
                {
                    textBox8.Text = cus.NameKH.ToString();
                    textBox7.Text = cus.GT.ToString();
                    textBox6.Text = FormatCurrency((long)cus.DTL);
                }
                else
                {
                    Customer c = new Customer();
                    c.txt_sdt.Text = textBox5.Text;
                    mf.OpenChildForm(c);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Item pi = get_Item();
            LoadProduct(pi);
            Total_price();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = panel_Body;
            //pictureBox2.BackColor = System.Drawing.Color.Transparent;

            //CustomPanel1
            SetControlTransparent(customPanel1, new Control[] { label8, label9, label11, radioButton1, radioButton2 });

            //customPanel2
            SetControlTransparent(customPanel2, new Control[] { label4, label10, label5 });
        }

        private void SetControlTransparent(Control parent, Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Parent = parent;
                control.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                UpdateTotalPriceWithDiscount();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                textBox6.Text = "0";
                UpdateTotalPriceWithDiscount();
            }
        }

        private void UpdateTotalPriceWithDiscount()
        {
            long totalPrice = ParseCurrency(textBox3.Text);
            long discount = ParseCurrency(textBox6.Text) * 100;
            long finalPrice = totalPrice - discount;
            textBox9.Text = FormatCurrency(finalPrice);
        }

        private long ParseCurrency(string text)
        {
            string cleanedText = text.Replace("đ", "").Replace(",", "").Trim();
            return long.Parse(cleanedText);
        }

        private string FormatCurrency(long value)
        {
            return string.Format("{0:N0} đ", value);
        }
    }
}


