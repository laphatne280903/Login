using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAAn
{
    public partial class FormDangnhap : Form
    {
        public FormDangnhap()
        {
            InitializeComponent();
            label_Loi.Hide();
        }
        private Form cformChild;
        private void OpenChildForm(Form childForm)
        {
            if (cformChild != null)
            {
                cformChild.Close();
            }
            cformChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_khung.Controls.Add(childForm);
            panel_khung.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = txtb_tentk.Text;
            string matkhau = txtb_mk.Text;

            if (tentk.Trim() == "") { panel_khung.Location = new Point(0, 35); label_Loi.Show(); }
            else if (matkhau.Trim() == "") { panel_khung.Location = new Point(0, 35); label_Loi.Show(); }
            //điều kiện dưới đây check tài khoản đủ điều kiện đăng nhập hay không.
            //else
            //{

            //}
        }

        private void label_Loi_Click(object sender, EventArgs e)
        {
            label_Loi.Hide();
            panel_khung.Location = new Point(0, 7);
        }
    }
}
