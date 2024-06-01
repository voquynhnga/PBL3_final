using PBL3.DAL;
using PBL3_qnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace PBL3.GUI_NV
{
    public partial class ChangePass_1 : Form
    {
        private Loginform lg;
        private TaiKhoan currentUser = Controller.user;
        private bool showPassword = false;

        public ChangePass_1()
        {
            InitializeComponent();
            textBox1.KeyPress += new KeyPressEventHandler(ChangePass_KeyPress);
            textBox2.KeyPress += new KeyPressEventHandler(ChangePass_KeyPress);
            textBox3.KeyPress += new KeyPressEventHandler(ChangePass_KeyPress);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoan t = new TaiKhoan()
            {
                TaiKhoan1 = currentUser.TaiKhoan1,
                MatKhau = textBox3.Text
            };
            int check = Controller.Instance.Check_user(currentUser);
            int check1 = Controller.Instance.Check_user(t);

            if (textBox3.Text == textBox2.Text && check == 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                Controller.Instance.SavePass(t);
            }
            else if (check == 2)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
                textBox1.Text = "";

            }
            else if (check1 == 1)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới có độ dài 8 kí tự và chỉ chứa số!");
                textBox2.Text = "";
                textBox3.Text = "";

            }
            else if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }



            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ChangePass_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;

            if (showPassword)
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }

        }
    }
}


