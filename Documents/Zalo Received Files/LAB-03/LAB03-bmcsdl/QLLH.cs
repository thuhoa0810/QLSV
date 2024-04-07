using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB03_bmcsdl
{
    public partial class QLLH : Form
    {
       public string MANV { get; set; }

        public QLLH()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
     
        private void OpenChildForm(Form ChildForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            } 
            currentFormChild= ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(ChildForm);
            panel_Body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btn_Class_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LOP());
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            SINHVIEN formSV = new SINHVIEN();
            formSV.MANV = MANV;
            OpenChildForm(formSV);
        }

        private void btn_Score_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DIEM());
        }
    }
}
