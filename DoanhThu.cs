using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BKFoodCourt
{
    public partial class DoanhThu : UserControl
    {
    
        private static DoanhThu _instance;
        public static DoanhThu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DoanhThu();
                return _instance;
            }
        }
        public DoanhThu()
        {
            InitializeComponent();
        }

       

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog
            //{
            //    CheckFileExists = true,
            //    CheckPathExists = true,
            //    DefaultExt = "txt",
            //    Filter = "txt file (*.txt)|*.txt",
            //    FilterIndex = 2,
            //    RestoreDirectory = true,
            //    ReadOnlyChecked = true,
            //    ShowReadOnly = true,

       
            //};
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    textBox1.Text = openFileDialog1.FileName;
            string absolutePath = System.IO.Path.GetFullPath("doanhthu.txt");
            Helper.file = absolutePath;
            dataGridView1.DataSource = Helper.DataTableFromTextFile("doanhthu.txt");
            string absolutePath2 = System.IO.Path.GetFullPath("doanhthu2.txt");
            Helper.file = absolutePath2;
            dataGridView2.DataSource = Helper.DataTableFromTextFile("doanhthu2.txt");
            string absolutePath3 = System.IO.Path.GetFullPath("doanhthu3.txt");
            Helper.file = absolutePath3;
            dataGridView3.DataSource = Helper.DataTableFromTextFile("doanhthu3.txt");
            string absolutePath4 = System.IO.Path.GetFullPath("doanhthu4.txt");
            Helper.file = absolutePath3;
            dataGridView4.DataSource = Helper.DataTableFromTextFile("doanhthu4.txt");
            //}
            //"D:\\Visual studio\\PMT\\HDH-lab2\\BKFoodCourt\\BKFoodCourt\\doanhthu.txt"
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
