using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNINE_Fee_Management
{
    public partial class Settings : Sample
    {
        private object sb;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
        StringBuilder asb = new StringBuilder();
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (ISCB.Checked)
            {
                if (DataSourceTxt.Text == "") { DataSourceErorLable.Visible = true; } else { DataSourceErorLable.Visible = false; }
                if (DatabaseTxt.Text == "") { DataBaseErorLable.Visible = true; } else { DataBaseErorLable.Visible = false; }
                if(DataSourceErorLable.Visible || DataBaseErorLable.Visible)
                {
                    MessageBox.Show("Feilds with * are mendatory");
                }
                else
                {
                    asb.Append("Data Source=" + DataSourceTxt.Text + ";Initial Catalog" + DatabaseTxt.Text + ";Integrated Security = true;MultipleActiveResultSets=True");
                    File.WriteAllText(MainClass.path + "\\cnt", asb.ToString());
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        LogIn log = new LogIn();
                        MainClass.ShowWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
            else
            {
                if (DataSourceTxt.Text == "") { DataSourceErorLable.Visible = true; } else { DataSourceErorLable.Visible = false; }
                if (DatabaseTxt.Text == "") { DataBaseErorLable.Visible = true; } else { DataBaseErorLable.Visible = false; }
                if (UsernameTxt.Text == "") { UserNameErorLable.Visible = true; } else { UserNameErorLable.Visible = false; }
                if (PasswordTxt.Text == "") { PassWordErorLable.Visible = true; } else { PassWordErorLable.Visible = false; }
                if (DataSourceErorLable.Visible || DataBaseErorLable.Visible || UserNameErorLable.Visible || PassWordErorLable.Visible)
                {
                    MessageBox.Show("Feilds with * are mendatory");
                }
                else
                {
                    asb.Append("Data Source=" + DataSourceTxt.Text + ";Initial Catalog" + DatabaseTxt.Text + ";User ID=" + UsernameTxt.Text + "Password = " + PasswordTxt.Text + "MultipleActiveResultSets=True");
                    File.WriteAllText(MainClass.path + "\\cnt", sb.ToString());
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        LogIn log = new LogIn();
                        MainClass.ShowWindow(log, this, MDI.ActiveForm);
                    }
                }
            }
        }

        private void DataSourceTxt_TextChanged(object sender, EventArgs e)
        {
            if (DataSourceTxt.Text == "") { DataSourceErorLable.Visible = true; } else { DataSourceErorLable.Visible = false; }
        }

        private void DatabaseTxt_TextChanged(object sender, EventArgs e)
        {
            if (DatabaseTxt.Text == "") { DataBaseErorLable.Visible = true; } else { DataBaseErorLable.Visible = false; }
        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "") { UserNameErorLable.Visible = true; } else { UserNameErorLable.Visible = false; }
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.Text == "") { PassWordErorLable.Visible = true; } else { PassWordErorLable.Visible = false; }
        }

        private void ISCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ISCB.Checked)
            {
                UsernameTxt.Text = "";
                UsernameTxt.Enabled = false;
                PasswordTxt.Text = "";
                PasswordTxt.Enabled = false;
                UserNameErorLable.Visible = false;
                PassWordErorLable.Visible = false;
            }
            else
            {
                UsernameTxt.Enabled = true;
                PasswordTxt.Enabled = true;
                UserNameErorLable.Visible = true;
                PassWordErorLable.Visible = true;
            }
        }
    }
}
