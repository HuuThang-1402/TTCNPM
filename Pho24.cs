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
    public partial class Pho24 : UserControl
    {
        private static Pho24 _instance;
        public static Pho24 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Pho24();
                return _instance;
            }
        }
        public Pho24()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
