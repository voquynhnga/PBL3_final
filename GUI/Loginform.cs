using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace PBL3

{

    public partial class Loginform : Form
    {
        String query;
        private bool showPassword = false;
        Mainform mf = new Mainform();
        public User currentuser = new User { 
            user_name = "",
            password = ""
        };


        public Loginform()
        {
            InitializeComponent();
            KeyPreview = true;

            // ctrl = new Controller(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    

        private void bLogin_Click(object sender, EventArgs e)
        {
            Controller.Instance.SetUser(currentuser,txtuser.Text, txtPass.Text);
            User t = GetUser();



            int check = Controller.Instance.Check_user(t);
            if (check == 0) {
                mf.Show();
                //this.Hide();

            }
            if (check == 1)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu có độ dài 8 kí tự và chỉ chứa số!");
            }
            if (check == 2)
            {
                MessageBox.Show("Mật khẩu không đúng!");
            }
            if (check == 3) MessageBox.Show("Tên người dùng không tồn tại!");


        }

        private void bWatch_Click(object sender, EventArgs e)
        {
            showPassword = !showPassword; 

            if (showPassword)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                bLogin_Click(sender, e); // Gọi hàm bLogin_Click
            }


        }
        public User GetUser()
        {
            return currentuser;
        }

    }
}
