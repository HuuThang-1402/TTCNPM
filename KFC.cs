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
    public partial class KFC : UserControl
    {
        private static KFC _instance;
        public static KFC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new KFC();
                return _instance;
            }
        }
        public KFC()
        {
            InitializeComponent();
        }

        private void KFC_Load(object sender, EventArgs e)
        {

        }

        public static decimal GHK1;
        public static decimal GHK2;
        public static decimal GRA;
        public static decimal GRB;
        public static decimal GQ;
        public static decimal GR;
        public static decimal BT;
        public static decimal Chip;
        public static decimal PEP;
        public static int KFCo = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            KFCo = 1;
            GHK1 = numericGHK1.Value;
            GHK2 = numeriGHK2.Value;
            GRA = numericGRA.Value;
            GRB = numericGRB.Value;
            GR = numericGR.Value;
            GQ = numericGQ.Value;
            BT = numericBT.Value;
            Chip = numericchip.Value;
            PEP = numericpepsi.Value;
            DatMonForm datmon = new DatMonForm();
            datmon.Show();

            //new DatMonForm().Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericchip_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericBT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericGR_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericGQ_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericGRB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericGRA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numeriGHK2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericGHK1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericpepsi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
