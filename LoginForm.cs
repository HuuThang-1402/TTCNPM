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
  
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tendangnhap.Text == "sinhvien" && matkhau.Text == "123")
            {
                new SinhVienForm().Show();
                this.Hide();
            }
            else if (tendangnhap.Text == "daubep" && matkhau.Text == "123")
            {
                new DauBepForm().Show();
                this.Hide();
            }
            else if (tendangnhap.Text == "chuquay" && matkhau.Text == "123")
            {
                new ChuQuayForm().Show();
                this.Hide();
            }
            else if (tendangnhap.Text == "quanli" && matkhau.Text == "123")
            {
                new QuanLiForm().Show();
                this.Hide();
            }
            else
            {
                new LoiForm().Show();

            }
          
        }

        private void label5_Click(object sender, EventArgs e)
        {
           new QuenMatKhauForm().Show();
        }
    }
}
