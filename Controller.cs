using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL_qnv
{
    public class Controller
    {
        string query;
        //Main mf = new Main();
        //private Main mf;
        //private Login lg;



        public int Check_user(User user)
        {
            query = "SELECT password FROM [User] WHERE username = @username";
            SqlParameter[] parameters = new SqlParameter[] {
                 new SqlParameter("@username", user.user_name)
             };

            DataTable result = DBcontrol.Instance.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                string passwordFromDB = result.Rows[0]["password"].ToString();

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



    }
}
