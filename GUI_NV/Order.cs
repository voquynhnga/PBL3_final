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
<<<<<<< HEAD
        //Mainform mf = Application.OpenForms["MainForm"] as Mainform;
        //Main_2 mf_cch = Application.OpenForms["Main_2"] as Main_2;
        Main_NV mf = Application.OpenForms["Main_NV"] as Main_NV;
        public static Order Instance;
        //QLCH_3Entities DB = new QLCH_3Entities();
=======
        Main_NV mf = Application.OpenForms["Main_NV"] as Main_NV;
        public static Order Instance;
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
        QLCH_3Entities db = new QLCH_3Entities();
        public Order()
        {
            InitializeComponent();
            m.AddProductEvent += AddProduct;
            Instance = this;
        }



        private void AddProduct(object sender, EventArgs e)

        {

            if (m.product != null)
            {
                textBox4.Text = m.product.SoLuong.ToString();
<<<<<<< HEAD
                var p = db.SanPhams.FirstOrDefault(s => s.product_id == m.product.product_id);
                textBox2.Text = p.product_name;
                //if (m.product.D != null)
                //{
                //    richTextBox1.Text = m.product.Mo.ToString();
                //}
                //else
                //{
                //    richTextBox1.Text = "";
                //}
                textBox1.Text = m.product.Gia.ToString();
            }


            //if (m.product.Hinh_anh != null && m.product.Hinh_anh.Length > 0)

            //{

            //    using (MemoryStream ms = new MemoryStream(m.product.Hinh_anh))

            //    {

            //        pictureBox2.Image = Image.FromStream(ms);

            //    }

            //}
=======
                //var p = db.SanPhams.FirstOrDefault(s => s.product_id == m.product.product_id);
                textBox2.Text = m.product.SanPham.product_name;
                textBox1.Text = m.product.Gia.ToString();
                textBox10.Text = m.product.Size.size_value.ToString();
                textBox11.Text = m.product.Color.color_name.ToString();
            }

>>>>>>> 85abff1a886188270143c988969a866dbdb94731
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
                    if ((pi.Name == btnName) && (pi.Size == btnSize))
<<<<<<< HEAD
                    {
                        if (pi.Color == btnColor)
                        {
                            btnSL += pi.SL;
                            btn.Text = $"{btnName}, {btnSize}, {btnColor}, {btnSL}, {btnPrice}";
                            isProductExist = true;
                            break;
=======

                    {

                        if (pi.Color == btnColor)

                        {

                            btnSL += pi.SL;

                            btn.Text = $"{btnName}, {btnSize}, {btnColor}, {btnSL}, {btnPrice}";

                            btn.Font = new Font("Arial", 10, FontStyle.Bold);

                            btn.ForeColor = System.Drawing.Color.White;

                            btn.BackColor = System.Drawing.Color.Blue;

                            isProductExist = true;

                            break;

>>>>>>> 85abff1a886188270143c988969a866dbdb94731
                        }
                    }
                }
            }
            if (!isProductExist)
            {
                Button btn = new Button()
                {
                    Width = Item.Width,
<<<<<<< HEAD
                    Height = Item.Height,
                    Text = pi.Name + ", " + pi.Size + ", " + pi.Color + ", " + pi.SL + ", " + pi.Price
=======

                    Height = Item.Height,

                    Text = FormatButtonText(pi.Name, pi.Size, pi.Color, pi.SL, pi.Price),

                    Font = new Font("Arial", 10, FontStyle.Bold),

                    ForeColor = System.Drawing.Color.White,

                    BackColor = System.Drawing.Color.Green,

                    TextAlign = ContentAlignment.MiddleCenter
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
                };
                fl.Controls.Add(btn);
            }
        }

<<<<<<< HEAD
=======
        private (string Name, string Size, string Color, int Quantity, float Price) ParseButtonText(string text)
        {
            string[] btnInfo = text.Split(',');
            return (
                Name: btnInfo[0].Trim(),
                Size: btnInfo[1].Trim(),
                Color: btnInfo[2].Trim(),
                Quantity: int.Parse(btnInfo[3].Trim()),
                Price: float.Parse(btnInfo[4].Trim())
            );
        }

        private string FormatButtonText(string name, string size, string color, int quantity, double price)
        {
            return $"{name}, {size}, {color}, {quantity}, {price:F2}";
        }

>>>>>>> 85abff1a886188270143c988969a866dbdb94731

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
            textBox3.Text = Total_price.ToString();

        }
        //FIX//22/4
        //public List<Item> Get_listItem()
        //{
        //    List<Item> list = new List<Item>();
<<<<<<< HEAD
            
=======

>>>>>>> 85abff1a886188270143c988969a866dbdb94731
        //      foreach (Control control in fl.Controls)
        //    {
        //        if(control is Button btn)
        //        {

        //        }
        //    }
<<<<<<< HEAD
            
        //}
    
=======

        //}

>>>>>>> 85abff1a886188270143c988969a866dbdb94731



        public List<Button> Getbutton()
        {
            List<Button> b = new List<Button>();
            foreach (Control control in fl.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;

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
                // Name = db.SanPhams(n => m.product.product_id == n.product_id).Default,
                Name = n.product_name,
<<<<<<< HEAD
                Size = comboBox1.Text,
                Color = comboBox2.Text,
=======
                Size = textBox10.Text,
                Color = textBox11.Text,
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
                Price = m.product.Gia,
                SL = (int)numericUpDown1.Value
            };
            return pi;
        }

        private void bTT_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show(fl.Controls.Count == 0 ? "Vui lòng thêm sản phẩm vào giỏ hàng" : "Vui lòng chọn đủ thông tin kích cỡ, màu sắc!");
            }
            else
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
=======
            //if (textBox10.SelectedItem == null || textBox11.SelectedItem == null)
            //{
            //    MessageBox.Show(fl.Controls.Count == 0 ? "Vui lòng thêm sản phẩm vào giỏ hàng" : "Vui lòng chọn đủ thông tin kích cỡ, màu sắc!");
            //}
            //else
            //{
            if (fl.Controls.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào giỏ hàng");
            }
            else
            {
                mf.OpenChildForm(new FinalBill());
            }
            // }
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
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
<<<<<<< HEAD
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
=======
            textBox10.Text = "";
            textBox11.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
            pictureBox2.Image = null;
            numericUpDown1.Value = 1;

        }


<<<<<<< HEAD
        private void pictureBox2_Click_1(object sender, EventArgs e)
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
=======
        public void pictureBox2_Click_1(object sender, EventArgs e)
        {
            KhachHang cus = new KhachHang();
            if (textBox5 != null)
            {
                cus = Controller.Instance.GetKH_SearchBill(textBox5.Text);
                if (cus != null)
                {
                    textBox8.Text = cus.NameKH.ToString();
                    textBox7.Text = cus.GT.ToString();
                    textBox6.Text = "-" + cus.DTL.ToString();
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
                }
                else
                {
                    XtraMessageBox.Show("Khách hàng mới, chưa được lưu");
<<<<<<< HEAD
                    mf.OpenChildForm(new Customer());
=======
                    Customer c = new Customer();
                    c.txt_sdt.Text = textBox5.Text;

                    mf.OpenChildForm(c);
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin");
            }
            else
            {
                Item pi = get_Item();
                LoadProduct(pi);
                Total_price();
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = panel_Body;
            pictureBox2.BackColor = System.Drawing.Color.Transparent;


            //CustomPanel1
            label8.Parent = customPanel1;
            label8.BackColor = System.Drawing.Color.Transparent;

            label9.Parent = customPanel1;
            label9.BackColor = System.Drawing.Color.Transparent;

            label11.Parent = customPanel1;
            label11.BackColor = System.Drawing.Color.Transparent;

            radioButton1.Parent = customPanel1;
            radioButton1.BackColor = System.Drawing.Color.Transparent;

            radioButton2.Parent = customPanel1;
            radioButton2.BackColor = System.Drawing.Color.Transparent;

            //customPanel2
            label4.Parent = customPanel2;
            label4.BackColor = System.Drawing.Color.Transparent;

            label10.Parent = customPanel2;
            label10.BackColor = System.Drawing.Color.Transparent;

            label5.Parent = customPanel2;
            label5.BackColor = System.Drawing.Color.Transparent;

        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

=======
            //if (textBox10.SelectedItem == null || textBox11.SelectedItem == null)
            //{
            //    MessageBox.Show("Vui lòng chọn đủ thông tin");
            //}
            //else
            //{
            Item pi = get_Item();
            LoadProduct(pi);
            Total_price();
            //}
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radioButton2.Checked = false;
                //textBox6.Text = "- " + textBox4.Text;
                textBox9.Text = (Convert.ToDouble(Order.Instance.textBox3.Text) - (Convert.ToDouble(textBox6.Text) * 100)).ToString();

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                radioButton1.Checked = false;
                textBox9.Text = textBox3.Text;
            }
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
        }
    }
}
