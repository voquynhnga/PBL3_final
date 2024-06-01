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

namespace PBL3.GUI_CCH
{
    public partial class TKNV : Form
    {
        QLCH_3Entities db = new QLCH_3Entities();
        public TKNV()
        {
            InitializeComponent();
        }



        private void TKNV_Load(object sender, EventArgs e)
        {
            nhanVienBindingSource.DataSource = db.NhanViens.ToList();
            taiKhoanBindingSource.DataSource = db.TaiKhoans.ToList();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {

            int IDnv = Convert.ToInt32(textEdit5.EditValue);


            bool existingID = db.TaiKhoans.Any(tk => tk.ID_NV == IDnv);
            string password = textEdit4.EditValue.ToString();



            if (existingID)

            {
                MessageBox.Show("Nhân viên đã có tài khoản trong hệ thống!", "Thông báo");

            }

            else

            {
                if (password.Length != 8 && Controller.Instance.IsNumeric(password ))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu có độ dài 8 chữ số");
                }
                else
                {
                    TaiKhoan newnv = new TaiKhoan

                    {

                        ID_NV = IDnv,

                        TaiKhoan1 = textEdit3.EditValue as string,

                        MatKhau = textEdit4.EditValue as string,

                        Loai_TK = "Nhân viên"

                    };

                    db.TaiKhoans.Add(newnv);

                    db.SaveChanges();
                    TKNV_Load(sender, e);
                }
            }
        }
    }
}
