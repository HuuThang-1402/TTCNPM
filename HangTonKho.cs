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
    public partial class HangTonKho : UserControl
    {
        private static HangTonKho _instance;
        public static HangTonKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HangTonKho();
                return _instance;
            }
        }
        public HangTonKho()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HangTonKho_Load(object sender, EventArgs e)
        {

            string absolutePath = System.IO.Path.GetFullPath("Hangtonkho.txt");
            Helper.file = absolutePath;
            dataGridView1.DataSource = Helper.DataTableFromTextFile("Hangtonkho.txt");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
