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
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "123")
            {
                new MatKhauSai().Show();
            }
            else if (textBox2.Text != textBox3.Text)
            {
                new MatKhauMoi().Show();
            }
            else
            {
                this.Hide();
                new ThanhCong().Show();
            }
        }
    }
}
