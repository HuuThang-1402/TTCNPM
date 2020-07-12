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
    public partial class NhanVien : UserControl
    {

        private static NhanVien _instance;
        public static NhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NhanVien();
                return _instance;
            }
        }
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string ten;
        public static string tuoi;
        public static string ngay;
        public static string sdt;
        public static string diachi;
        public static string calam;
        public static string luong;
        public static string note;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nguyen Van A" && textBox2.Text == "1")
            {
                ten = "Nguyen Van A";
                tuoi = "20";
                ngay = "17/12/2000";
                sdt = "090483586";
                diachi = "123 đường số 1 Quận 10 Phường 10";
                calam = "Thứ 2 4 6";
                luong = "6.000.000đ/tháng";
                note = "Chưa có ghi chú";
                ThongTinNhanVien TTNV = new ThongTinNhanVien();
                TTNV.Show();
            }
            if (textBox1.Text == "Tran Van B" && textBox2.Text == "2")
            {
                ten = "Tran Van B";
                tuoi = "21";
                ngay = "14/1/1999";
                sdt = "090448626";
                diachi = "456 đường số 2 Quận 1 Phường 2";
                calam = "Thứ 3 5 7";
                luong = "6.000.000đ/tháng";
                note = "Chưa có ghi chú";
                ThongTinNhanVien TTNV = new ThongTinNhanVien();
                TTNV.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
