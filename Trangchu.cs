using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BKFoodCourt
{
    public partial class Trangchu : UserControl
    {
        public static Trangchu _instance;
        public static Trangchu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Trangchu();
                return _instance;
            }
        }
        public Trangchu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(KFC.Instance))
            {
                panel1.Controls.Add(KFC.Instance);
                KFC.Instance.Dock = DockStyle.Fill;
                KFC.Instance.BringToFront();
            }
            else { KFC.Instance.BringToFront(); }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Pho24.Instance))
            {
                panel1.Controls.Add(Pho24.Instance);
                Pho24.Instance.Dock = DockStyle.Fill;
                Pho24.Instance.BringToFront();
            }
            else { Pho24.Instance.BringToFront(); }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(KFC.Instance))
            {
                panel1.Controls.Add(KFC.Instance);
                KFC.Instance.Dock = DockStyle.Fill;
                KFC.Instance.BringToFront();
            }
            else { KFC.Instance.BringToFront(); }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(KFC.Instance))
            {
                panel1.Controls.Add(KFC.Instance);
                KFC.Instance.Dock = DockStyle.Fill;
                KFC.Instance.BringToFront();
            }
            else { KFC.Instance.BringToFront(); }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(KFC.Instance))
            {
                panel1.Controls.Add(KFC.Instance);
                KFC.Instance.Dock = DockStyle.Fill;
                KFC.Instance.BringToFront();
            }
            else { KFC.Instance.BringToFront(); }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(BinhDan.Instance))
            {
                panel1.Controls.Add(BinhDan.Instance);
                BinhDan.Instance.Dock = DockStyle.Fill;
                BinhDan.Instance.BringToFront();
            }
            else { BinhDan.Instance.BringToFront(); }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(BinhDan.Instance))
            {
                panel1.Controls.Add(BinhDan.Instance);
                BinhDan.Instance.Dock = DockStyle.Fill;
                BinhDan.Instance.BringToFront();
            }
            else { BinhDan.Instance.BringToFront(); }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(BinhDan.Instance))
            {
                panel1.Controls.Add(BinhDan.Instance);
                BinhDan.Instance.Dock = DockStyle.Fill;
                BinhDan.Instance.BringToFront();
            }
            else { BinhDan.Instance.BringToFront(); }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
