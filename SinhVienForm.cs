using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKFoodCourt
{
    public partial class SinhVienForm : Form
    {

        public SinhVienForm()
        {
            InitializeComponent();
            custom();
        }
        private void custom()
        {
            if (!panel1.Controls.Contains(Trangchu.Instance))
            {
                panel1.Controls.Add(Trangchu.Instance);
                Trangchu.Instance.Dock = DockStyle.Fill;
                Trangchu.Instance.BringToFront();
            }
            else { Trangchu.Instance.BringToFront(); }
            panel3.Visible = false;
            panel4.Visible = false;
            
        }
        private void hide()
        {
            if (panel3.Visible == true)
                panel3.Visible = false;
        }
        private void show(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hide();
                submenu.Visible = true;

            }
            else
                submenu.Visible = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            show(panel3);
            
        }

        private void KFCbutton_Click(object sender, EventArgs e)
        {
            
            if (!panel1.Controls.Contains(KFC.Instance))
            {
                panel1.Controls.Add(KFC.Instance);
                KFC.Instance.Dock = DockStyle.Fill;
                KFC.Instance.BringToFront();
            }
            else { KFC.Instance.BringToFront(); }
            hide();
        }

        private void Monhuebutton_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(MonHue.Instance))
            {
                panel1.Controls.Add(MonHue.Instance);
                MonHue.Instance.Dock = DockStyle.Fill;
                MonHue.Instance.BringToFront();
            }
            else { MonHue.Instance.BringToFront(); }
            hide();
        }

        private void Pho24button_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Pho24.Instance))
            {
                panel1.Controls.Add(Pho24.Instance);
                Pho24.Instance.Dock = DockStyle.Fill;
                Pho24.Instance.BringToFront();
            }
            else { Pho24.Instance.BringToFront(); }
            
            hide();
        }

        private void binhdanbutton_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(BinhDan.Instance))
            {
                panel1.Controls.Add(BinhDan.Instance);
                BinhDan.Instance.Dock = DockStyle.Fill;
                BinhDan.Instance.BringToFront();
            }
            else { BinhDan.Instance.BringToFront(); }
            hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Trangchu.Instance))
            {
                panel1.Controls.Add(Trangchu.Instance);
                Trangchu.Instance.Dock = DockStyle.Fill;
                Trangchu.Instance.BringToFront();
            }
            else { Trangchu.Instance.BringToFront(); }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Height = button3.Height;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
             new TinhTrangDonHang().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show(panel4);
        }
        public static int a = 0;
        private void button8_Click(object sender, EventArgs e)
        {

            if (a == 0)
            {
                new Thongtincanhan().Show();
            }
                
            hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new NapTien().Show();
            hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new doimatkhau().Show();
            hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.hide();
            new LoginForm().Show();
            hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
