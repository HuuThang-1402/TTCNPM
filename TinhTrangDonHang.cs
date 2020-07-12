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
    public partial class TinhTrangDonHang : Form
    {
        public TinhTrangDonHang()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

       public void TinhTrangDonHang_Load(object sender, EventArgs e)
        {
            if (KFC.KFCo > 0)
            {
                if (KFC.GHK1 > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Combo Gà Hoàng Kim 1", SoLuong = KFC.GHK1, TinhTrang = "Đang tiến hành",UocTinh = "15:00" });
                }
                if (KFC.GHK2 > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Combo Gà Hoàng Kim 2", SoLuong = KFC.GHK2, TinhTrang = "Đang tiến hành", UocTinh = "15:00" });
                }
                if (KFC.GRA > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Combo Gà Rán A", SoLuong = KFC.GRA, TinhTrang = "Đang tiến hành", UocTinh = "15:00" });
                }
                if (KFC.GRB > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Combo Gà Rán B", SoLuong = KFC.GRB, TinhTrang = "Đang tiến hành", UocTinh = "15:00" });
                }
                if (KFC.GQ > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Gà Quay", SoLuong = KFC.GQ, TinhTrang = "Đang tiến hành", UocTinh = "10:00" });
                }
                if (KFC.GR > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Gà Rán", SoLuong = KFC.GR, TinhTrang = "Đang tiến hành", UocTinh = "10:00" });
                }
                if (KFC.BT > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Burger Tôm", SoLuong = KFC.BT, TinhTrang = "Đang tiến hành", UocTinh = "10:00" });
                }
                if (KFC.Chip > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Khoai Tây chiên", SoLuong = KFC.Chip, TinhTrang = "Đang tiến hành", UocTinh = "5:00" });
                }
                if (KFC.PEP > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Pepsi lon", SoLuong = KFC.PEP, TinhTrang = "Đang tiến hành", UocTinh = "1:00" });
                }
            }
            if (MonHue.MonHueo > 0)
            {
                if (MonHue.GHK1 > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Bánh bèo tôm tươi", SoLuong = MonHue.GHK1, TinhTrang = "Đang tiến hành", UocTinh = "10:00" });
                }
                if (MonHue.GHK2 > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Bánh bột lọc lá", SoLuong = MonHue.GHK2, TinhTrang = "Đang tiến hành", UocTinh = "10:00" });
                }
                if (MonHue.GRA > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Bánh thập cẩm", SoLuong = MonHue.GRA, TinhTrang = "Đang tiến hành", UocTinh = "10:00" });
                }
                if (MonHue.GRB > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Bánh ướt thịt nướng", SoLuong = MonHue.GRB, TinhTrang = "Đang tiến hành", UocTinh = "10:00" });
                }
                if (MonHue.GQ > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Bún bò chả cua", SoLuong = MonHue.GQ, TinhTrang = "Đang tiến hành", UocTinh = "15:00" });
                }
                if (MonHue.GR > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Bún bò đặc biệt", SoLuong = MonHue.GR, TinhTrang = "Đang tiến hành", UocTinh = "15:00" });
                }
                if (MonHue.BT > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Gỏi mít non tôm thịt", SoLuong = MonHue.BT, TinhTrang = "Đang tiến hành", UocTinh = "5:00" });
                }
                if (MonHue.Chip > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Bún mắm nêm", SoLuong = MonHue.Chip, TinhTrang = "Đang tiến hành", UocTinh = "5:00" });
                }
                if (MonHue.PEP > 0)
                {
                    tinhtrangBindingSource.Add(new tinhtrang() { MonAn = "Bún nem lụi", SoLuong = MonHue.PEP, TinhTrang = "Đang tiến hành", UocTinh = "5:00" });
                }
            }
        }

       private void button9_Click(object sender, EventArgs e)
       {
           this.Hide();
       }

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {

       }

       private void label1_Click(object sender, EventArgs e)
       {

       }

       private void tinhtrangBindingSource_CurrentChanged(object sender, EventArgs e)
       {

       }
    }
}
