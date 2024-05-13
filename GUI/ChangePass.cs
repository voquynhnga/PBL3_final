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
    public partial class ChangePass : Form
    {
        private Loginform lg;
        private User user ;
        public ChangePass()
        {
            InitializeComponent();
 
           lg = (Loginform)Application.OpenForms["Loginform"];
                user = lg.GetUser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User t = new User()
            {
                user_name = user.user_name,
                password = textBox3.Text
            };
            int check = Controller.Instance.Check_user(user);
            int check1 = Controller.Instance.Check_user(t);

            if (textBox3.Text == textBox2.Text &&  check == 0) {
                MessageBox.Show("Đổi mật khẩu thành công!");
            }
            else if (check == 2) MessageBox.Show("Mật khẩu cũ không chính xác!");
            else if (check1 == 1) MessageBox.Show("Vui lòng nhập mật khẩu mới có độ dài 8 kí tự và chỉ chứa số!");
            else if (textBox3.Text != textBox2.Text) MessageBox.Show("Nhập lại mật khẩu mới!");
            else MessageBox.Show("Đổi mật khẩu thất bại!");

            Controller.Instance.SavePass(t);
        }
    }
}
