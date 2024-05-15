using PBL_qnv.BLL;
using PBL3.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.GUI
{
    public partial class OrderForm : Form
    {
        ManageProduct m = new ManageProduct();
        Mainform mf = Application.OpenForms["MainForm"] as Mainform;
        public static OrderForm Instance;

        public OrderForm()
        {
            InitializeComponent();

             m.AddProductEvent += AddProduct;
            Instance = this;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            m.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddProduct(object sender, EventArgs e)

        {

            textBox4.Text = m.product.SL.ToString();
            label6.Text = m.product.Name.ToString();
            richTextBox1.Text = m.product.Description.ToString();
            label5.Text = m.product.Price.ToString();
 

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //public void LoadProduct(Product_item pi)
        //{

        //        Button btn = new Button()
        //        {
        //            Width = Product_item.Width,
        //            Height = Product_item.Height,
        //            Text = pi.Name + ", "+ pi.Size + ", " + pi.Color + ", " + pi.SL + ", " + pi.Price

        //        };
        //        fl.Controls.Add(btn);



        //}

        public void LoadProduct(Product_item pi)
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
                    Width = Product_item.Width,
                    Height = Product_item.Height,
                    Text = pi.Name + ", " + pi.Size + ", " + pi.Color + ", " + pi.SL + ", " + pi.Price
                };
                fl.Controls.Add(btn);
            }
        }


        private void Total_price()
        {
            float Total_price = 0;
            //foreach(Button btn in panel3.Controls)
            //{
            //    Total_price += btn.Text.pi.SL * btn.Text.pi.Price;
            //}
            //textBox1.Text = Total_price.ToString();
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
            label7.Text = Total_price.ToString();

        }

        private void bCancel_Click(object sender, EventArgs e)
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
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            textBox4.Text = "";
            numericUpDown1.Value = 1;

        }

        void Compare_pi(Product_item p1, Product_item p2) {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin");
            }
            else
            {
                Product_item pi = new Product_item()
                {
                    ID = m.product.ID,
                    Name = m.product.Name,
                    Size = comboBox1.Text,
                    Color = comboBox2.Text,
                    Price = m.product.Price,
                    SL = (int)numericUpDown1.Value
                };
                LoadProduct(pi);
                Total_price();
            }
        }

        private void bTT_Click(object sender, EventArgs e)
        {
           // this.Hide();
            mf.OpenChildForm(new Bill());
        }
        public List<Button> Getbutton()
        {
            List<Button> b = new List<Button>();
            foreach (Control control in fl.Controls)
            {
                if (control is Button )
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

    }
}
