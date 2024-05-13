using PBL3.BLL;
using PBL3.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public class Controller
    {
        string query;
        //Main mf = new Main();
        //private Main mf;
        //private Login lg;
        private static Controller instance;

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

        public int Check_user(User user)
        {
            query = "SELECT MatKhau FROM [TaiKhoan] WHERE TaiKhoan = @username";
 
            
            SqlParameter[] parameters = new SqlParameter[] {
                 new SqlParameter("@username", user.user_name)
             };

            DataTable result = DBcontrol.Instance.ExcuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                string passwordFromDB = result.Rows[0]["MatKhau"].ToString();

                if (user.password == passwordFromDB)
                {

                    return 0;

                }
                else if (user.password.Length != 8 || !IsNumeric(user.password))
                {
                    return 1;
                }
                else
                {
                    return 2;

                }
            }
            else
            {
                return 3;
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

        public void SavePass(User user)
        {
            query = "UPDATE TaiKhoan SET MatKhau = @password WHERE TaiKhoan = @user_name";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@password", user.password),
                new SqlParameter("@user_name", user.user_name),

            };
            DBcontrol.Instance.ExcuteDB(query, parameter);

        }
        public void SetUser(User u, string name, string pass)
        {
            u.user_name = name;

            u.password = pass;

        }

        public DataTable View_DG(string table)
        {
  
            query = "select * from " + table;
            DataTable dt = DBcontrol.Instance.getRecord(query);
            return dt;
     
           
        }





    }
}
