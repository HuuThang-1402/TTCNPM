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
    public partial class DatMonForm : Form
    {

        public DatMonForm()
        {
            InitializeComponent();
        }
        public static int KFCF = 0;
        public static int MonHueF = 0;
        private void datmon_Load(object sender, EventArgs e)
        {
            if (KFC.KFCo > 0 && MonHueF == 0)
            {
            if (KFC.GHK1 > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Combo Gà Hoàng Kim 1", SoLuong = KFC.GHK1, Gia = KFC.GHK1 * 85000 });
            }
            if (KFC.GHK2 > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Combo Gà Hoàng Kim 2", SoLuong = KFC.GHK2, Gia = KFC.GHK2 * 89000 });
            }
            if (KFC.GRA > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Combo Gà Rán A", SoLuong = KFC.GRA, Gia = KFC.GRA * 79000 });
            }
            if (KFC.GRB > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Combo Gà Rán B", SoLuong = KFC.GRB, Gia = KFC.GRB * 79000 });
            }
            if (KFC.GQ > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Gà Quay", SoLuong = KFC.GQ, Gia = KFC.GQ * 58000 });
            }
            if (KFC.GR > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Gà Rán", SoLuong = KFC.GR, Gia = KFC.GR * 36000 });
            }
            if (KFC.BT > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Burger Tôm", SoLuong = KFC.BT, Gia = KFC.BT * 42000 });
            }
            if (KFC.Chip > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Khoai Tây chiên", SoLuong = KFC.Chip, Gia = KFC.Chip * 14000 });
            }
            if (KFC.PEP > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Pepsi lon", SoLuong = KFC.PEP, Gia = KFC.PEP * 10000 });
            }
            }
            if (MonHue.MonHueo > 0 && KFCF == 0)
            {
            if (MonHue.GHK1 > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Bánh bèo tôm tươi", SoLuong = MonHue.GHK1, Gia = MonHue.GHK1 * 25000 });
            }
            if (MonHue.GHK2 > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Bánh bột lọc lá", SoLuong = MonHue.GHK2, Gia = MonHue.GHK2 * 25000 });
            }
            if (MonHue.GRA > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Bánh thập cẩm", SoLuong = MonHue.GRA, Gia = MonHue.GRA * 20000 });
            }
            if (MonHue.GRB > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Bánh ướt thịt nướng", SoLuong = MonHue.GRB, Gia = MonHue.GRB * 20000 });
            }
            if (MonHue.GQ > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Bún bò chả cua", SoLuong = MonHue.GQ, Gia = MonHue.GQ * 30000 });
            }
            if (MonHue.GR > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Bún bò đặc biệt", SoLuong = MonHue.GR, Gia = MonHue.GR * 36000 });
            }
            if (MonHue.BT > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Gỏi mít non tôm thịt", SoLuong = MonHue.BT, Gia = MonHue.BT * 22000 });
            }
            if (MonHue.Chip > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Bún mắm nêm", SoLuong = MonHue.Chip, Gia = MonHue.Chip * 24000 });
            }
            if (MonHue.PEP > 0)
            {
                orderBindingSource.Add(new order() { MonAn = "Bún nem lụi", SoLuong = MonHue.PEP, Gia = MonHue.PEP * 23000 });
            }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = "Tổng số tiền";
            decimal tong = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++ )
            {
                var value = dataGridView1.Rows[i].Cells[2].Value;
                tong += Convert.ToDecimal(value);
            }
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = tong;
        }
        public static decimal Total;
        public static int thanhtoan = 0;
        private void button3_Click(object sender, EventArgs e)
        {
           
            decimal tong = 0;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++ )
            {
                var value = dataGridView1.Rows[i].Cells[2].Value;
                tong += Convert.ToDecimal(value);
            }
            Total = tong;
            XacNhanForm xacnhan = new XacNhanForm();
            xacnhan.Show();
        }
    }
}
