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
    public partial class ClassesHomeScreen : Sample
    {
        public ClassesHomeScreen()
        {
            InitializeComponent();
        }

        private void ClassesHomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            MainClass.ShowWindow(hs, this, MDI.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class_LKG Lk = new Class_LKG();
            MainClass.ShowWindow(Lk, this, MDI.ActiveForm);
        }
    }
}
