using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label_Loi.Hide();
            
        }
        public static string Priority = string.Empty;
        public static string Username=string.Empty;
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

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string quyentruycap = comboBox_quyentruycap.Text;
            string tentk = txtb_tentk.Text;
            string matkhau = txtb_mk.Text;

            if (quyentruycap.Trim() == "") { panel_khung.Location = new Point(13, 28); label_Loi.Show(); }
            else if (tentk.Trim() == "") { panel_khung.Location = new Point(13, 28); label_Loi.Show(); }
            else if (matkhau.Trim() == "") { panel_khung.Location = new Point(13, 28); label_Loi.Show(); }


            //điều kiện dưới đây check tài khoản đủ điều kiện đăng nhập hay không.
            //else
            //{

            //}
        }

        private void label_Loi_Click(object sender, EventArgs e)
        {
            label_Loi.Hide();
            panel_khung.Location = new Point(13, 3);
        }
    }
}
