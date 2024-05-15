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
    public partial class Bill : Form
    {
        Mainform mf = Application.OpenForms["MainForm"] as Mainform;

        public Bill()
        {
            InitializeComponent();
            Load_Bill();
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = OrderForm.Instance;

            if (orderForm != null)

            {

               // this.Hide();
                mf.OpenChildForm(orderForm);

            }

        }
        private void Load_Bill()
        {
            OrderForm orderForm = Application.OpenForms["OrderForm"] as OrderForm;
            List<Button> buttons = new List<Button>();
            if (orderForm != null)
            {
               buttons =  orderForm.Getbutton();
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mf.OpenChildForm(new Bill1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận hủy", "Xác nhận", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
                mf.Show();
            }
        }
    }
}
