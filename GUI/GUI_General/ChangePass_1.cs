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
            richTextBox1.KeyPress += new KeyPressEventHandler(ChangePass_KeyPress);
            textBox3.KeyPress += new KeyPressEventHandler(ChangePass_KeyPress);

            labelControl1.Parent = pictureEdit1;
            labelControl1.BackColor = System.Drawing.Color.Transparent;
            labelControl1.ForeColor = System.Drawing.Color.Red;

            labelControl2.Parent = pictureEdit1;
            labelControl2.BackColor = System.Drawing.Color.Transparent;
            
            label1.Parent = pictureEdit1;
            label1.BackColor = System.Drawing.Color.Transparent;

            label2.Parent = pictureEdit1;
            label2.BackColor = System.Drawing.Color.Transparent;

            label3.Parent = pictureEdit1;
            label3.BackColor = System.Drawing.Color.Transparent;


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

            if (textBox3.Text == richTextBox1.Text && check == 0 && richTextBox1.Text != "" && textBox3.Text != "")
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                Controller.Instance.SavePass(t);
            }
            else if (check == 2)
            {
                labelControl1.Show();
                labelControl1.Text = "Mật khẩu cũ không chính xác!";
                textBox1.Text = "";
                textBox1.Focus();

            }
            else if (check1 == 1)
            {
                labelControl1.Show();
                labelControl1.Text = "Vui lòng nhập mật khẩu mới có độ dài 8 kí tự và chỉ chứa số!";
                richTextBox1.Text = "";
                textBox3.Text = "";

            }
            else if (textBox3.Text != richTextBox1.Text)
            {
                labelControl1.Show();
                labelControl1.Text = "Mật khẩu mới không trùng nhau!!!";
                textBox1.Text = "";
                richTextBox1.Text = "";
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");
                richTextBox1.Text = "";
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            richTextBox1.Text = "";
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
        private void ChangePass_1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
                showPassword = !showPassword;

                if (showPassword)
                {
                    textBox1.PasswordChar = '\0';
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\eye_flaticon.png");
                }
                else
                {
                    textBox1.PasswordChar = '*';
                    pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image\\eye.png");
                }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                richTextBox1.PasswordChar = '\0';
                pictureBox2.Image = new Bitmap(Application.StartupPath + "\\Resources\\eye_flaticon.png");
            }
            else
            {
                richTextBox1.PasswordChar = '*';
                pictureBox2.Image = new Bitmap(Application.StartupPath + "\\Image\\eye.png");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword;
            if (showPassword)
            {
                textBox3.PasswordChar = '\0';
                pictureBox3.Image = new Bitmap(Application.StartupPath + "\\Resources\\eye_flaticon.png");
            }
            else
            {
                textBox3.PasswordChar = '*';
                pictureBox3.Image = new Bitmap(Application.StartupPath + "\\Image\\eye.png");
            }
        }
    }
}


