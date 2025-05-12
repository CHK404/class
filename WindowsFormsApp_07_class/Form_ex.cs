using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_07_class
{
    public partial class Form_ex : Form
    {
        public Form_ex()
        {
            InitializeComponent();

            Bev bev1 = new Bev(100, "Coke", 2500);
            Bev bev2 = new Bev(150, "Cider", 2000);
            Bev bev3 = new Bev(200, "Soda", 1500);

            bev1.Buy(5);
            bev2.Buy(7);
            bev3.Buy(30);

            bev1.BevInfo();
            bev2.BevInfo();
            bev3.BevInfo();
            Bev.CustInfo();
        }
    }
}
