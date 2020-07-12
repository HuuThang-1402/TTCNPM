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
    public partial class ThongTinNhanVien : Form
    {
        public ThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            textBox1.Text = NhanVien.ten;
            textBox2.Text = NhanVien.ngay;
            textBox3.Text = NhanVien.tuoi;
            textBox4.Text = NhanVien.sdt;
            textBox5.Text = NhanVien.diachi;
            textBox6.Text = NhanVien.calam;
            textBox7.Text = NhanVien.luong;
            textBox8.Text = NhanVien.note;
        }
    }
}
