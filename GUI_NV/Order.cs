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
        //Mainform mf = Application.OpenForms["MainForm"] as Mainform;
        //Main_2 mf_cch = Application.OpenForms["Main_2"] as Main_2;
        Main_NV mf = Application.OpenForms["Main_NV"] as Main_NV;
        public static Order Instance;
        //QLCH_3Entities DB = new QLCH_3Entities();
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
                    {
                        if (pi.Color == btnColor)
                        {
                            btnSL += pi.SL;
                            btn.Text = $"{btnName}, {btnSize}, {btnColor}, {btnSL}, {btnPrice}";
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
                    Text = pi.Name + ", " + pi.Size + ", " + pi.Color + ", " + pi.SL + ", " + pi.Price
                };
                fl.Controls.Add(btn);
            }
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
            textBox3.Text = Total_price.ToString();

        }
        //FIX//22/4
        //public List<Item> Get_listItem()
        //{
        //    List<Item> list = new List<Item>();
            
        //      foreach (Control control in fl.Controls)
        //    {
        //        if(control is Button btn)
        //        {

        //        }
        //    }
            
        //}
    



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
                Size = comboBox1.Text,
                Color = comboBox2.Text,
                Price = m.product.Gia,
                SL = (int)numericUpDown1.Value
            };
            return pi;
        }

        private void bTT_Click_1(object sender, EventArgs e)
        {
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
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            pictureBox2.Image = null;
            numericUpDown1.Value = 1;

        }


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
                }
                else
                {
                    XtraMessageBox.Show("Khách hàng mới, chưa được lưu");
                    mf.OpenChildForm(new Customer());
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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

        }
    }
}
