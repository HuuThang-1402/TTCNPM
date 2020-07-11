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
    public partial class ChuQuayForm : Form
    {
        public ChuQuayForm()
        {
            InitializeComponent();
        }

        private void ChuQuayForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
