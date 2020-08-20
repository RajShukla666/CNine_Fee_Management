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
    public partial class Staff : Sample2
    {
        public Staff()
        {
            InitializeComponent();
        }
        int edit = 0;
        MyDBDataContext obj = new MyDBDataContext();
        private void Staff_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel2);
        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel2);
        }
        private void loadData()
        {
            var data = obj.st_getStaffDetails();
            UserIDGV.DataPropertyName = "ID";
            NameGV.DataPropertyName = "Name";
            FatherNameGV.DataPropertyName = "FatherNamme";
            EPFID_GV.DataPropertyName = "EPFID";
            DOB_GV.DataPropertyName = "DateOfBirth";
            DOJ_GV.DataPropertyName = "DateOfJoin";
            EmailGV.DataPropertyName = "EmailAddress";
            Phone1GV.DataPropertyName = "Phone1";
            Phone2GV.DataPropertyName = "Phone2";
            PostGV.DataPropertyName = "Post";
            dataGridView1.DataSource = data; 
            MainClass.sno(dataGridView1, "snoGV");
        }
        public override void EditBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel2);
        }
        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "") { NameErrorLable.Visible = true; } else { NameErrorLable.Visible = false; }
            if (FathersNameTxt.Text == "") { FatherNameErorLable.Visible = true; } else { FatherNameErorLable.Visible = false; }
            if (EPFID_Txt.Text == "") { EPFID_ErorLable.Visible = true; } else { EPFID_ErorLable.Visible = false; }
            if (DOB_Txt.Text == "") { DOB_ErorLable.Visible = true; } else { DOB_ErorLable.Visible = false; }
            if (DOJ_Txt.Text == "") { DOJ_ErorLable.Visible = true; } else { DOJ_ErorLable.Visible = false; }
            if (EmailTxt.Text == "") { EmailErorLable.Visible = true; } else { EmailErorLable.Visible = false; }
            if (Phone1_Txt.Text == "") { Phone1ErorLable.Visible = true; } else { Phone1ErorLable.Visible = false; }
            if(Phone1_Txt.Text == Phone2Txt.Text) { MainClass.ShowMSG("Both phone numbers are same", "Error...", "Error"); }
            if (PostTxt.Text == "") { PostErorLable.Visible = true; } else { PostErorLable.Visible = false; }
            if (StatusDD.SelectedIndex == -1) { StatusErorLable.Visible = true; } else { StatusErorLable.Visible = false; }
            if (NameErrorLable.Visible || FatherNameErorLable.Visible || EPFID_ErorLable.Visible || DOB_ErorLable.Visible || DOJ_ErorLable.Visible || EmailErorLable.Visible || Phone1ErorLable.Visible || PostErorLable.Visible || PostErorLable.Visible || StatusErorLable.Visible)
            {
                MainClass.ShowMSG("Feilds With * Are Mendatory", "Error...", "Error");
            }
            else
            {
                if (edit == 0)// Code for save
                {
                    byte stat = StatusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                    staff s = new staff();
                    s.st_name = NameTxt.Text;
                    s.st_fatherName = FathersNameTxt.Text;
                    s.st_EPFID = EPFID_Txt.Text;
                    s.st_DOB = DOB_Txt.Text;
                    s.st_DOJ = DOJ_Txt.Text;
                    s.st_emailAddress = EmailTxt.Text;
                    s.st_phone1 = Phone1_Txt.Text;
                    s.st_phone2 = Phone2Txt.Text;
                    s.st_Post = PostTxt.Text;
                    s.st_status = stat;
                    obj.staffs.InsertOnSubmit(s);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(NameTxt.Text + " Added Successfully", "Success...", "Success");
                    MainClass.disable_reset(panel2);
                    loadData();
                }
                else if (edit == 1)// Code for update
                {
                    var data = obj.staffs.Single(x => x.st_id == staffID);

                    byte stat = StatusDD.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                    data.st_name = NameTxt.Text;
                    data.st_fatherName = FathersNameTxt.Text;
                    data.st_EPFID = EPFID_Txt.Text;
                    data.st_DOB = DOB_Txt.Text;
                    data.st_DOJ = DOJ_Txt.Text;
                    data.st_emailAddress = EmailTxt.Text;
                    data.st_phone1 = Phone1_Txt.Text;
                    data.st_phone2 = Phone2Txt.Text;
                    data.st_Post = PostTxt.Text;
                    data.st_status = stat;
                    obj.SubmitChanges();
                    MainClass.ShowMSG(NameTxt.Text + " Updated Successfully", "Success...", "Success");
                    MainClass.disable_reset(panel2);
                    loadData();
                }
            }
        }

        public override void DeleteBtn_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure ?", "Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    obj.st_deleteStaff(staffID);
                    MainClass.ShowMSG(NameTxt.Text + " Deleted Successfully", "Success...", "Success");
                    MainClass.disable_reset(panel2);
                    loadData();
                }
            }
        }
        public override void ViewBtn_Click_1(object sender, EventArgs e)
        {
            loadData();
        }
        public override void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void NameErrorLable_Click(object sender, EventArgs e)
        {

        }

        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            if (NameTxt.Text == "") { NameErrorLable.Visible = true; } else { NameErrorLable.Visible = false; }
        }

        private void FathersNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (FathersNameTxt.Text == "") { FatherNameErorLable.Visible = true; } else { FatherNameErorLable.Visible = false; }
        }

        private void EPFID_Txt_TextChanged(object sender, EventArgs e)
        {
            if (EPFID_Txt.Text == "") { EPFID_ErorLable.Visible = true; } else { EPFID_ErorLable.Visible = false; }
        }

        private void DOB_Txt_TextChanged(object sender, EventArgs e)
        {
            if (DOB_Txt.Text == "") { DOB_ErorLable.Visible = true; } else { DOB_ErorLable.Visible = false; }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DOJ_Txt_TextChanged(object sender, EventArgs e)
        {
            if (DOJ_Txt.Text == "") { DOJ_ErorLable.Visible = true; } else { DOJ_ErorLable.Visible = false; }
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            if (EmailTxt.Text == "") { EmailErorLable.Visible = true; } else { EmailErorLable.Visible = false; }
        }

        private void Phone1_Txt_TextChanged(object sender, EventArgs e)
        {
            if (Phone1_Txt.Text == "") { Phone1ErorLable.Visible = true; } else { Phone1ErorLable.Visible = false; }
        }

        private void Phone2Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PostDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PostTxt.Text == "") { PostErorLable.Visible = true; } else { PostErorLable.Visible = false; }
        }

        private void StatusDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusDD.SelectedIndex == -1) { StatusErorLable.Visible = true; } else { StatusErorLable.Visible = false; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int staffID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = 1;
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                staffID = Convert.ToInt32(row.Cells["UserIDGV"].Value.ToString());
                NameTxt.Text = row.Cells["NameGV"].Value.ToString();
                FathersNameTxt.Text = row.Cells["FatherNameGV"].Value.ToString();
                EPFID_Txt.Text = row.Cells["EPFID_GV"].Value.ToString();
                DOB_Txt.Text = row.Cells["DOB_GV"].Value.ToString();
                DOJ_Txt.Text = row.Cells["DOJ_GV"].Value.ToString();
                EmailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                Phone1_Txt.Text = row.Cells["Phone1GV"].Value.ToString();
                Phone2Txt.Text = row.Cells["Phone2GV"].Value.ToString();
                PostTxt.Text = row.Cells["PostGV"].Value.ToString();
            }
        }
        private void searchData()
        {
            var abc = obj.r_searchStaff(SearchTxt.Text);
            UserIDGV.DataPropertyName = "ID";
            NameGV.DataPropertyName = "Name";
            FatherNameGV.DataPropertyName = "FatherName";
            EPFID_GV.DataPropertyName = "EPFID";
            DOB_GV.DataPropertyName = "DateOfBirth";
            DOB_GV.DataPropertyName = "DateOfJoin";
            EmailGV.DataPropertyName = "EmailAddress";
            Phone1GV.DataPropertyName = "Phone1";
            Phone2GV.DataPropertyName = "Phone2";
            PostGV.DataPropertyName = "Post";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
        }
        private void SearchTxt_TextChanged_1(object sender, EventArgs e)
        {
            searchData();
        }
    }
}
