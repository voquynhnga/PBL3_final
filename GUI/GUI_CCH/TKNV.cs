using PBL3.DAL;
using PBL3_qnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            if (textEdit5.EditValue == "")
            {
                label1.Text = "Vui lòng chọn nhân viên để tạo tài khoản!";
            }
            else
            {



                int IDnv = Convert.ToInt32(textEdit5.EditValue);


                bool existingID = db.TaiKhoans.Any(tk => tk.ID_NV == IDnv);
                string password = textEdit4.EditValue.ToString();



                if (existingID)

                {
                    label1.Text = "Nhân viên đã có tài khoản trong hệ thống!";

                }

                else

                {
                    if (password.Length != 8 && Controller.Instance.IsNumeric(password))
                    {
                        label1.Text = "Vui lòng nhập mật khẩu có độ dài 8 chữ số";
                    }
                    else
                    {
                        TaiKhoan newnv = new TaiKhoan

                        {

                            ID_NV = IDnv,

                            TaiKhoan1 = textEdit3.EditValue as string,

                            //MatKhau = textEdit4.EditValue as string,
                            MatKhau = Controller.Instance.encryption(textEdit4.EditValue as string),

                            Loai_TK = "Nhân viên"

                        };

                        db.TaiKhoans.Add(newnv);

                        db.SaveChanges();
                        TKNV_Load(sender, e);
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (textEdit5.EditValue == "")
            {
                label1.Text = "Vui lòng chọn nhân viên để đặt lại mật khẩu!";
            }
            else
            {
                int IDnv = Convert.ToInt32(textEdit5.EditValue);
                var tk = db.TaiKhoans.SingleOrDefault(nv => nv.ID_NV == IDnv);


                if (tk != null)
                {
                    tk.MatKhau = Controller.Instance.encryption("12345678");
                    db.SaveChanges();
                    TKNV_Load(sender, e);

                }
            }

        }
    }
}
