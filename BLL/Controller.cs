using DevExpress.Data.Browsing;
using DevExpress.XtraEditors;
using PBL3;
//using PBL3_qnv.BLL;
using PBL3.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_qnv
{
    public class Controller
    {
        // string query;
        //Main mf = new Main();
        //private Main mf;
        //private Login lg;
        static Loginform lg = Application.OpenForms["Loginform"] as Loginform;
        private static Controller instance;
        public static TaiKhoan user = lg.GetUser();
        QLCH_3Entities db = new QLCH_3Entities();


        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
            private set { }
        }

        public int Check_user(TaiKhoan user)

        {



            var userFromDB = db.TaiKhoans.Where(t => t.TaiKhoan1 == user.TaiKhoan1).FirstOrDefault();

            if (userFromDB != null)

            {

                if (userFromDB.MatKhau == user.MatKhau)

                {

                    return 0;

                }

                else if (user.MatKhau.Length != 8 || !IsNumeric(user.MatKhau))

                {

                    return 1;

                }

                else

                {

                    return 2;

                }

            }

            return 3;



        }

        public int Check_type(TaiKhoan user)

        {



            var userFromDB = db.TaiKhoans.Where(t => t.TaiKhoan1 == user.TaiKhoan1).FirstOrDefault();



            if (userFromDB != null)

            {

                if (userFromDB.Loai_TK == "Nhân viên")

                {

                    return 1;

                }

                if (userFromDB.Loai_TK == "Chủ cửa hàng")
                {

                    return 2;

                }

            }

            return 0;

        }

    

        public void SavePass(TaiKhoan user)

        {



                var userFromDB = db.TaiKhoans.Where(t => t.TaiKhoan1 == user.TaiKhoan1).FirstOrDefault();

                if (userFromDB != null)

                {

                    userFromDB.MatKhau = user.MatKhau;
                    db.SaveChanges();

                }

            

        }

        private bool IsNumeric(string input)

        {

            foreach (char c in input)

            {

                if (!char.IsDigit(c))

                {

                    return false;

                }

            }

            return true;

        }
        public int Get_ID(string username)
        {

                var user = db.TaiKhoans
                             .Where(t => t.TaiKhoan1 == username)
                             .FirstOrDefault();

                if (user != null)
                {
                    return user.ID_NV;
                }
                else
                {
                    throw new Exception("User not found");
                }
            
        }
        public NhanVien Get_NV(TaiKhoan user)
        {
            string usrname = user.TaiKhoan1.ToString();
            int id_nv = Get_ID(usrname); 
            using (var DB = new QLCH_3Entities())
            {
                var nhanVien = DB.NhanViens.FirstOrDefault(nv => nv.ID_NV == id_nv); 
                if (nhanVien != null)
                {
                    return nhanVien;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Nhân viên có ID_NV tương ứng với user.");
                    return null;
                    // Xử lý khi không tìm thấy NhanVien tương ứng
                }
            }
        }
        public void SetUser(TaiKhoan u, string name, string pass)

        {

            u.TaiKhoan1 = name;

            u.MatKhau = pass;

        }
        public void Savein4_NV(string n, string sdt, string e, string gt, DateTime d, string cc, string p)
        {
            string usrname = user.TaiKhoan1.ToString();
            int id_nv = Get_ID(usrname);
            NhanVien nv = Get_NV(user);
            using (var DB = new QLCH_3Entities())
            {
                var nhanVien = DB.NhanViens.FirstOrDefault(nv1 => nv1.ID_NV == id_nv);
                if (nhanVien != null)
                {
                    // Lấy thông tin từ các TextBox
                    nhanVien.NameNV = n;
                    nhanVien.SDT = sdt;
                    nhanVien.Email = e;
                    nhanVien.GT = gt;
                    nhanVien.NS = d;
                    nhanVien.CCCD = cc;
                    nhanVien.ChucVu = p;

                    // Lưu các thay đổi vào cơ sở dữ liệu
                    DB.SaveChanges();
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy NhanVien với ID_NV tương ứng
                    MessageBox.Show("Không tìm thấy nhân viên với ID_NV tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }
        public KhachHang GetKH_SearchBill(string txt)
        {


            KhachHang cus = null;



            if (IsNumeric(txt))

            {


                cus = db.KhachHangs.FirstOrDefault(kh => kh.SDT == txt);

            }
            else XtraMessageBox.Show("Vui lòng nhập số điện thoại");



            return cus;




        }


    }






}

