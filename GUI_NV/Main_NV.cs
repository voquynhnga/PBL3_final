using DevExpress.XtraBars;
using PBL3.GUI_CCH;
using PBL3_qnv.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL3.GUI_NV
{
    public partial class Main_NV : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Form currentFormChild;

        public Main_NV()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form childForm)
        {
            currentFormChild = childForm;

            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;

            Container1.Controls.Add(childForm);

            Container1.Tag = childForm;

            childForm.BringToFront();

            childForm.Show();

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer());
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Account());
        }

        private void o_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePass_1());
        }

        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            Loginform lg = new Loginform();
            this.Close();
            lg.Show();
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Shift());
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Order());
        }
    }
}
