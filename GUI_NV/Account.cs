using DevExpress.XtraGrid.Views.Card;
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

namespace PBL3_qnv.GUI
{
    public partial class Account : Form
    {
        QLCH_3Entities pbl = new QLCH_3Entities ();
        //TaiKhoan currentUser = Controller.user;



        public Account()
        {
            InitializeComponent();
            Load_Information();
            textBox1.KeyPress += new KeyPressEventHandler(Account_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(Account_KeyPress);
            textBox3.KeyPress += new KeyPressEventHandler(Account_KeyPress);
            textBox4.KeyPress += new KeyPressEventHandler(Account_KeyPress);
            textBox5.KeyPress += new KeyPressEventHandler(Account_KeyPress);
            textBox6.KeyPress += new KeyPressEventHandler(Account_KeyPress);

<<<<<<< HEAD
=======
            label2.Parent = panelControl1;
            label2.BackColor = System.Drawing.Color.Transparent;

            label5.Parent = panelControl1;
            label5.BackColor = System.Drawing.Color.Transparent;

            label9.Parent = panelControl1;
            label9.BackColor = System.Drawing.Color.Transparent;

            label6.Parent = panelControl1;
            label6.BackColor = System.Drawing.Color.Transparent;

            label8.Parent = panelControl1;
            label8.BackColor = System.Drawing.Color.Transparent;

            textBox1.Parent = panelControl1;
            textBox1.BackColor = System.Drawing.Color.Red;
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
        


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;

            //textBox1.Text = textBox1.Text;

            //textBox2.Text = textBox2.Text;

            //textBox3.Text = textBox3.Text;

            //textBox4.Text = textBox4.Text;
            //dateTimePicker1.Value = dateTimePicker1.Value;
            //textBox5.Text = textBox5.Text;

            //textBox6.Text = textBox6.Text;
            Controller.Instance.Savein4_NV(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Value, textBox5.Text, textBox6.Text);


        }

        void Load_Information()
        {

            /*NhanVien nv = Controller.Instance.Get_NV(currentUser);
            textBox1.Text = nv.NameNV.ToString();
            textBox2.Text = nv.SDT.ToString();
            textBox3.Text = nv.Email.ToString();
            textBox4.Text = nv.GT.ToString();
            dateTimePicker1.Value = nv.NS;
            textBox5.Text = nv.CCCD.ToString();
            textBox6.Text = currentUser.Loai_TK.ToString();*/

<<<<<<< HEAD


=======
>>>>>>> 85abff1a886188270143c988969a866dbdb94731
        }

        private void Account_KeyPress(object sender, KeyPressEventArgs e)
        
        
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TextBox currentTextBox = sender as TextBox;

                if (currentTextBox != null)
                {
                    SelectNextControl(currentTextBox, true, true, true, true);
                }

                e.Handled = true;
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            label2.Parent = panelControl1;
            label2.BackColor = System.Drawing.Color.Transparent;

            label3.Parent = panelControl1;
            label3.BackColor = System.Drawing.Color.Transparent;

            label5.Parent = panelControl1;
            label5.BackColor = System.Drawing.Color.Transparent;

            label9.Parent = panelControl1;
            label9.BackColor = System.Drawing.Color.Transparent;

            label6.Parent = panelControl1;
            label6.BackColor = System.Drawing.Color.Transparent;

            label8.Parent = panelControl1;
            label8.BackColor = System.Drawing.Color.Transparent;

            textBox1.Parent = panelControl1;
            textBox1.BackColor = System.Drawing.Color.Red;
=======

>>>>>>> 85abff1a886188270143c988969a866dbdb94731
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
