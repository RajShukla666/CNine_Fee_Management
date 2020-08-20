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
    public partial class Class_LKG : Sample2
    {
        public Class_LKG()
        {
            InitializeComponent();
        }
        int edit;
        MyDB_SDDataContext obj = new MyDB_SDDataContext();
        private void Class_LKG_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(panel2);

        }
        public override void AddBtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            MainClass.enable_reset(panel2);
        }

        public override void EditBtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(panel2);
        }
        public override void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "") { NameErrorLable.Visible = true; } else { NameErrorLable.Visible = false; }
            if (FatherNameTxt.Text == "") { FatherNameErrorLable.Visible = true; } else { FatherNameErrorLable.Visible = false; }
            if (MotherNameTxt.Text == "") { MotherNameErtrorLable.Visible = true; } else { MotherNameErtrorLable.Visible = false; }
            if (SrNO_Txt.Text == "") { SrNo_ErrorLable.Visible = true; } else { SrNo_ErrorLable.Visible = false; }
            if (DOB_TXT.Text == "") { DOB_ErrorLable.Visible = true; } else { DOB_ErrorLable.Visible = false; }
            if (DOA_TXT.Text == "") { DOA_ErrorLable.Visible = true; } else { DOA_ErrorLable.Visible = false; }
            if (ClassTxt.Text == "") { ClassErrorLable.Visible = true; } else { ClassErrorLable.Visible = false; }
            if (SectionTxt.Text == "") { SectionErrorLable.Visible = true; } else { SectionErrorLable.Visible = false; }
            if (ContactNoTxt.Text == "") { ContactErrorLable.Visible = true; } else { ContactErrorLable.Visible = false; }
            if (AddressTxt.Text == "") { AddressErrorLable.Visible = true; } else { AddressErrorLable.Visible = false; }
            if (AdharNoTxt.Text == "") { AdharErrorLable.Visible = true; } else { AdharErrorLable.Visible = false; }
            if (CastTxt.Text == "") { CastErrorLable.Visible = true; } else { CastErrorLable.Visible = false; }
            if (ReligionTxt.Text == "") { ReligionErrorLable.Visible = true; } else { ReligionErrorLable.Visible = false; }
            if (PreSchoolTxt.Text == "") { PreSchoolErrorLable.Visible = true; } else { PreSchoolErrorLable.Visible = false; }
            if(NameErrorLable.Visible||FatherNameErrorLable.Visible||MotherNameErtrorLable.Visible||SrNo_ErrorLable.Visible||DOB_ErrorLable.Visible||DOA_ErrorLable.Visible||ClassErrorLable.Visible ||SectionErrorLable.Visible || ContactErrorLable.Visible || AddressErrorLable.Visible || AdharErrorLable.Visible || CastErrorLable.Visible || ReligionErrorLable.Visible || PreSchoolErrorLable.Visible)
            {
                MainClass.ShowMSG("Feilds With * Are Mendatory", "Error...", "Error");
            }
            else
            {
                if(edit == 0)
                {
                    LKG l = new LKG();
                    l.lk_name = NameTxt.Text;
                    l.lk_motherNmae = MotherNameTxt.Text;
                    l.lk_fatherName = FatherNameTxt.Text;
                    l.lk_SrNo = SrNO_Txt.Text;
                    l.lk_DOB = DOB_TXT.Text;
                    l.lk_DOA = DOA_TXT.Text;
                    l.lk_class = ClassTxt.Text;
                    l.lk_section = SectionTxt.Text;
                    l.lk_contactNo = ContactNoTxt.Text;
                    l.lk_address = AddressTxt.Text;
                    l.lk_adharNo = AdharNoTxt.Text;
                    l.lk_cast = CastTxt.Text;
                    l.lk_religion = ReligionTxt.Text;
                    l.lk_preSchool = PreSchoolTxt.Text;
                    obj.LKGs.InsertOnSubmit(l);
                    obj.SubmitChanges();
                    MainClass.ShowMSG(NameTxt.Text + " Added Successfully", "Success...", "Success");
                    MainClass.disable_reset(panel2);
                    loadData();
                }                            
                if(edit == 1)
                {
                    var data = obj.LKGs.Single(x => x.lk_id == LKG_ID);
                    data.lk_name = NameTxt.Text;
                    data.lk_motherNmae = MotherNameTxt.Text;
                    data.lk_fatherName = FatherNameTxt.Text;
                    data.lk_SrNo = SrNO_Txt.Text;
                    data.lk_DOB = DOB_TXT.Text;
                    data.lk_DOA = DOA_TXT.Text;
                    data.lk_class = ClassTxt.Text;
                    data.lk_section = SectionTxt.Text;
                    data.lk_contactNo = ContactNoTxt.Text;
                    data.lk_address = AddressTxt.Text;
                    data.lk_adharNo = AdharNoTxt.Text;
                    data.lk_cast = CastTxt.Text;
                    data.lk_religion = ReligionTxt.Text;
                    data.lk_preSchool = PreSchoolTxt.Text;
                    obj.SubmitChanges();
                    MainClass.ShowMSG(NameTxt.Text + " Updated Successfully", "Success...", "Success");
                    MainClass.disable_reset(panel2);
                    loadData();
                }
            }
        }
        int LKG_ID;
        public override void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure ?", "Qustion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.lk_deleteLKG(LKG_ID);
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

        private void SearchTxt_TextChanged_1(object sender, EventArgs e)
        {
            searchData();
        }
        private void NameTxt_TextChanged(object sender, EventArgs e)
        {
            if(NameTxt.Text == "") { NameErrorLable.Visible = true; } else { NameErrorLable.Visible = false; }
        }

        private void FatherNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (FatherNameTxt.Text == "") { FatherNameErrorLable.Visible = true; } else { FatherNameErrorLable.Visible = false; }
        }

        private void MotherNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (MotherNameTxt.Text == "") { MotherNameErtrorLable.Visible = true; } else { MotherNameErtrorLable.Visible = false; }
        }

        private void SrNO_Txt_TextChanged(object sender, EventArgs e)
        {
            if (SrNO_Txt.Text == "") { SrNo_ErrorLable.Visible = true; } else { SrNo_ErrorLable.Visible = false; }
        }

        private void DOB_TXT_TextChanged(object sender, EventArgs e)
        {
            if (DOB_TXT.Text == "") { DOB_ErrorLable.Visible = true; } else { DOB_ErrorLable.Visible = false; }
        }

        private void DOA_TXT_TextChanged(object sender, EventArgs e)
        {
            if (DOA_TXT.Text == "") { DOA_ErrorLable.Visible = true; } else { DOA_ErrorLable.Visible = false; }
        }

        private void ClassTxt_TextChanged(object sender, EventArgs e)
        {
            if (ClassTxt.Text == "") { ClassErrorLable.Visible = true; } else { ClassErrorLable.Visible = false; }
        }

        private void SectionTxt_TextChanged(object sender, EventArgs e)
        {
            if (SectionTxt.Text == "") { SectionErrorLable.Visible = true; } else { SectionErrorLable.Visible = false; }
        }

        private void ContactNoTxt_TextChanged(object sender, EventArgs e)
        {
            if (ContactNoTxt.Text == "") { ContactErrorLable.Visible = true; } else { ContactErrorLable.Visible = false; }
        }

        private void AddressTxt_TextChanged(object sender, EventArgs e)
        {
            if (AddressTxt.Text == "") { AddressErrorLable.Visible = true; } else { AddressErrorLable.Visible = false; }
        }

        private void AdharNoTxt_TextChanged(object sender, EventArgs e)
        {
            if (AdharNoTxt.Text == "") { AdharErrorLable.Visible = true; } else { AdharErrorLable.Visible = false; }
        }

        private void CastTxt_TextChanged(object sender, EventArgs e)
        {
            if (CastTxt.Text == "") { CastErrorLable.Visible = true; } else { CastErrorLable.Visible = false; }
        }

        private void ReligionTxt_TextChanged(object sender, EventArgs e)
        {
            if (ReligionTxt.Text == "") { ReligionErrorLable.Visible = true; } else { ReligionErrorLable.Visible = false; }
        }

        private void PreSchoolTxt_TextChanged(object sender, EventArgs e)
        {
            if (PreSchoolTxt.Text == "") { PreSchoolErrorLable.Visible = true; } else { PreSchoolErrorLable.Visible = false; }
        }
        private void loadData()
        {
            var abc = obj.lk_getLKG();
            StudentIDGV.DataPropertyName = "ID";
            NameGV.DataPropertyName = "Name";
            FatherNameGV.DataPropertyName = "FatherName";
            MotherNameGV.DataPropertyName = "MotherName";
            SrNoGV.DataPropertyName = "SrNo";
            DOB_GV.DataPropertyName = "DateOfBirth";
            DOA_GV.DataPropertyName = "DateOfAdmission";
            ClassGV.DataPropertyName = "Class";
            SectionGV.DataPropertyName = "Section";
            ContactNoGV.DataPropertyName = "ContactNo";
            AddressGV.DataPropertyName = "Address";
            AdharGV.DataPropertyName = "AdharNo";
            CastGV.DataPropertyName = "Cast";
            ReligionGV.DataPropertyName = "Religion";
            PreSchoolGV.DataPropertyName = "PreSchool";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edit = 1;
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                LKG_ID = Convert.ToInt32(row.Cells["StudentIDGV"].Value.ToString());
                NameTxt.Text = row.Cells["NameGV"].Value.ToString();
                FatherNameTxt.Text = row.Cells["FatherNameGV"].Value.ToString();
                MotherNameTxt.Text = row.Cells["MotherNameGV"].Value.ToString();
                SrNO_Txt.Text = row.Cells["SrNoGV"].Value.ToString();
                DOB_TXT.Text = row.Cells["DOB_GV"].Value.ToString();
                DOA_TXT.Text = row.Cells["DOA_GV"].Value.ToString();
                ClassTxt.Text = row.Cells["ClassGV"].Value.ToString();
                SectionTxt.Text = row.Cells["SectionGV"].Value.ToString();
                ContactNoTxt.Text = row.Cells["ContactNoGV"].Value.ToString();
                AddressTxt.Text = row.Cells["AddressGV"].Value.ToString();
                AdharNoTxt.Text = row.Cells["AdharGV"].Value.ToString();
                CastTxt.Text = row.Cells["CastGV"].Value.ToString();
                ReligionTxt.Text = row.Cells["ReligionGV"].Value.ToString();
                PreSchoolTxt.Text = row.Cells["PreSchoolGV"].Value.ToString();
            }
        }
        private void searchData()
        {
            var abc = obj.lk_searchLKG(SearchTxt.Text);
            StudentIDGV.DataPropertyName = "ID";
            NameGV.DataPropertyName = "Name";
            FatherNameGV.DataPropertyName = "FatherName";
            MotherNameGV.DataPropertyName = "MotherName";
            SrNoGV.DataPropertyName = "SrNo";
            DOB_GV.DataPropertyName = "DateOfBirth";
            DOA_GV.DataPropertyName = "DateOfAdmission";
            ClassGV.DataPropertyName = "Class";
            SectionGV.DataPropertyName = "Section";
            ContactNoGV.DataPropertyName = "ContactNo";
            AddressGV.DataPropertyName = "Address";
            AdharGV.DataPropertyName = "AdharNo";
            CastGV.DataPropertyName = "Cast";
            ReligionGV.DataPropertyName = "Religion";
            PreSchoolGV.DataPropertyName = "PreSchool";
            dataGridView1.DataSource = abc;
            MainClass.sno(dataGridView1, "snoGV");
        }
    }
}
