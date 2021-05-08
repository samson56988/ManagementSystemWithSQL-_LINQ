using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
   
    public partial class Admission : Form
    {
        public Admission()
        {
            InitializeComponent();
        }
         myDBDataContext obj = new myDBDataContext();
        int edit = 0;
        private void label3_Click(object sender, EventArgs e)
        {
            Home hs = new Home();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.enable_reset(panel1);
         

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.enable(panel1);
             
        }


        public void Loadlist()
        {
        
        
            var li2 = (from s in obj.Classes select new {s.Class_id,s.Class_name}).ToList();
            li2.Insert(0,new {Class_id = 0 , Class_name = "Select"});
            Classs.DataSource = li2;
            Classs.DisplayMember = "Class_name";
            Classs.ValueMember = "Class_id";

            var li3 = (from s in obj.sections where s.sec_status == 1 select new {s.sec_id,s.sec_name}).ToList();
            li3.Insert(0,new {sec_id = 0 , sec_name = "Select"});
            Classs.DataSource = li3;
            Classs.DisplayMember = "sec_name";
            Classs.ValueMember = "sec_id";
        
        
        
        
        
        }

        private void loadata()
        {
            var abc = obj.getAdmission();
            AdmissionIDGV.DataPropertyName = "ID";
            StudentGV.DataPropertyName = "Student";
            GenderGV.DataPropertyName = "Gender";
            FatherGV.DataPropertyName = "FatherName";
            MotherdayGV.DataPropertyName = "Mother";
            FatherprofessionGV.DataPropertyName = "FatherProfession";
            MotherdayGV.DataPropertyName = "MotherProfession";
            Dobgv.DataPropertyName = "DOB";
            NationalityGv.DataPropertyName = "Nationality";
            ReligionGV.DataPropertyName = "Religion";
            ClassIDGV.DataPropertyName= "ClassID";
            ClassGV.DataPropertyName = "Class";
            SectionGV.DataPropertyName = "Section";
            SectionIDGV.DataPropertyName = "SectionID";
            EmailGV.DataPropertyName = "Email";
            AddressGV.DataPropertyName = "Address";
            PhoneGV.DataPropertyName = "Phone";
            Phone2GV.DataPropertyName = "Phone2";
            PlaceOFbirthGv.DataPropertyName = "Bithpace";
            StatusGV.DataPropertyName = "Status";
            dataGridView2.DataSource = abc;











        }



        int AID;

        private void btnsave_Click(object sender, EventArgs e)
        {
            byte gender;
            int? secID;
            if (edit == 0)
            {

                if (sectioncb.SelectedIndex > 0) { secID = Convert.ToInt32(sectioncb.SelectedValue.ToString()); } else { secID = null; }
                if (Gendercb.SelectedIndex == 0) { gender = 1; } else { gender = 0; }
                  obj.insertAdmission(Student_txt.Text,gender,txt_Fathername.Text,txt_mothername.Text,Fathersjob.Text,Mothersjob.Text,
                    Dob.Value,Nationality.Text,placeofbirth.Text,
                    Convert.ToByte(Religioncb.SelectedIndex),Convert.ToInt32(Classs.SelectedValue.ToString()),
                    secID,Address.Text,Phone.Text,phone2.Text,txt_email.Text,Convert.ToByte(statuscb.SelectedIndex));
                    Mainclass.ShowMsg("Student Admission Submitted Successfully", "Success", "Success");
                    loadata();

           
            
            }
            else if (edit == 1)
            {

                if (sectioncb.SelectedIndex > 0) { secID = Convert.ToInt32(sectioncb.SelectedValue.ToString()); } else { secID = null; }
                if (Gendercb.SelectedIndex == 0) { gender = 1; } else { gender = 0; }
                obj.UpdateAdmission(Student_txt.Text, gender, txt_Fathername.Text, txt_mothername.Text, Fathersjob.Text, Mothersjob.Text,
                   Dob.Value, Nationality.Text, placeofbirth.Text,
                   Convert.ToByte(Religioncb.SelectedIndex), Convert.ToInt32(Classs.SelectedValue.ToString()),
                   secID, Address.Text, Phone.Text, phone2.Text, txt_email.Text, Convert.ToByte(statuscb.SelectedIndex),AID);
                   Mainclass.ShowMsg("Admission Application Updated Successfully", "Success", "Success");
                   loadata();

           
             
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + Student_txt.Text +   "  Admission Application ?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.deleteadmission(AID);

                    Mainclass.ShowMsg(Student_txt.Text + " Application  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadata();

                }
            }
        }

        

        private void Admission_Load(object sender, EventArgs e)
        {
            Loadlist();
            loadata();
            dataGridView2.AutoGenerateColumns = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                Student_txt.Text = row.Cells["StudentGV"].Value.ToString(); 
               

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.AutoGenerateColumns = false;
        }
    }
}
