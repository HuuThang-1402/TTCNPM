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
    public partial class BinhDan : UserControl
    {
        private static BinhDan _instance;
        public static BinhDan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BinhDan();
                return _instance;
            }
        }
        public BinhDan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
