using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL_qnv.BLL;
using PBL3.BLL;

namespace PBL3.GUI
{
    public partial class ManageIngoing_detail : Form
    {
        public delegate void MyDel(int id);
        public MyDel d { get; set; }
       // public string M { get; set; }
        public ManageIngoing_detail()
        {
            InitializeComponent();
        }
        private void Add(int id)
        {
            Controller_MI ctrl = new Controller_MI();
            InGoing ig = new InGoing()
            {
            //    ID = 
            };
            //ctrl.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
