using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNINE_Fee_Management
{
    public partial class HomeScreen : Sample
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff st = new Staff();
            MainClass.ShowWindow(st, this, MDI.ActiveForm);
        }

        private void FeeBtn_Click(object sender, EventArgs e)
        {
            FeeHomeScreen fhs = new FeeHomeScreen();
            MainClass.ShowWindow(fhs, this, MDI.ActiveForm);
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            Class_LKG LK = new Class_LKG();
            MainClass.ShowWindow(LK, this, MDI.ActiveForm);
        }
    }
}
