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
    public partial class LogIn : Sample
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UsernameTxt.Text == "") { UsernameErorLable.Visible = true; } else { UsernameErorLable.Visible = false; }
            if (PasswordTxt.Text == "") { PasswordErorLable.Visible = true; } else { PasswordErorLable.Visible = false; }
            if(UsernameErorLable.Visible || PasswordErorLable.Visible)
            {
                MainClass.ShowMSG("Feilds With * Are Mendatory", "Error...", "Error");
            }
            else
            {
                var name = "Blank";
                var password = "opopopopopopop";
                if (name == "Blank" && password == "opopopopopopop") 
                { 
                    name = UsernameTxt.Text;
                    password = PasswordTxt.Text;
                    if (UsernameTxt.Text == name && PasswordTxt.Text == password)
                    {
                        HomeScreen hs = new HomeScreen();
                        MainClass.ShowWindow(hs, this, MDI.ActiveForm);
                    }
                    else
                    {
                        if (UsernameTxt.Text != name)
                        {
                            MainClass.ShowMSG("Worng Username", "Error...", "Error");
                        }
                        if (PasswordTxt.Text != password)
                        {
                            MainClass.ShowMSG("Worng Password", "Error...", "Error");
                        }
                    }
                }
            }
        }
        private void ExttBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "") { UsernameErorLable.Visible = true; } else { UsernameErorLable.Visible = false; }
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "") { PasswordErorLable.Visible = true; } else { PasswordErorLable.Visible = false; }

        }
    }
}
