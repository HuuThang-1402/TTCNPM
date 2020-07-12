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
    public partial class HangTonKhoNV : UserControl
    {
        private static HangTonKhoNV _instance;
        public static HangTonKhoNV Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HangTonKhoNV();
                return _instance;
            }
        }
        public HangTonKhoNV()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HangTonKhoNV_Load(object sender, EventArgs e)
        {
            string absolutePath = System.IO.Path.GetFullPath("Hangtonkho.txt");
            Helper.file = absolutePath;
            dataGridView1.DataSource = Helper.DataTableFromTextFile("Hangtonkho.txt");
        }
    }
}
