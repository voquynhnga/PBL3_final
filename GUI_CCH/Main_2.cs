using DevExpress.XtraBars;
using PBL3.GUI_NV;
using PBL3_qnv.GUI;
using PBL3_qnv.GUI_CCH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL3.GUI_CCH
{
    public partial class Main_2 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Form currentFormChild;
        public static Main_2 mf2;
        public Main_2()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form childForm)
        {
            currentFormChild = childForm;

            childForm.TopLevel = false;

            childForm.FormBorderStyle = FormBorderStyle.None;

            childForm.Dock = DockStyle.Fill;

            container.Controls.Add(childForm);

            container.Tag = childForm;

            childForm.BringToFront();

            childForm.Show();

        }





        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fDoanhThu());
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Account());
        }

        private void accordionControlElement3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ChangePass_1());
        }

        private void accordionControlElement4_Click_1(object sender, EventArgs e)
        {
            Loginform lg = new Loginform();
            this.Close();
            lg.Show();
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MnEmployee());

        }



        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShiftCCH());
        }

        private void accordionControlElement12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MnProduct_CCH());

        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MnIngoing());

        }

        private void accordionControlElement13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new mnSupplier());
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Salary());
        }

        private void accordionControlElement14_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TKNV());
        }
    }
}

