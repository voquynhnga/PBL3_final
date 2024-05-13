using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DAL;
using PBL3;
using PBL_qnv.BLL;
using System.Windows.Forms;

namespace PBL3.BLL
{
    internal class Controller_Product
    {
        private static Controller_Product instance;
        string query = "";
        public static Controller_Product Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller_Product();
                }
                return instance;
            }
            private set { }
        }

    }

}
