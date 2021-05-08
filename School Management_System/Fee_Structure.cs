using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Fee_Structure : Form
    {
        myDBDataContext obj = new myDBDataContext();
        int edit = 0;
        public Fee_Structure()
        {
            InitializeComponent();
        }

        private void Fee_Structure_Load(object sender, EventArgs e)
        {
            loadata();
            Mainclass.disable_reset(panel1);
            Loadlist();
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


            var li2 = (from s in obj.Classes select new { s.Class_id, s.Class_name }).ToList();
            li2.Insert(0, new { Class_id = 0, Class_name = "Select" });
            Classcb.DataSource = li2;
            Classcb.DisplayMember = "Class_name";
            Classcb.ValueMember = "Class_id";

           
     }
        int FeeID;
        private void btnsave_Click(object sender, EventArgs e)
        {

            
            if (edit == 0)
            {

                
                obj.insertfeestructure(Convert.ToInt32(Classcb.SelectedValue.ToString()), Convert.ToDecimal(txt_admissionfee.Text),Convert.ToDecimal(MonthlyFEE.Text),Convert.ToDecimal(txt_SecurityDeposit.Text),Convert.ToDecimal(txt_Coursefee.Text),Convert.ToDecimal(txt_SportFee.Text),Convert.ToDecimal(txt_others.Text));
                Mainclass.ShowMsg("Fee Addedd Successfully", "Success", "Success");
                loadata();



            }
            else if (edit == 1)
            {


                obj.UpdateFeeStructure(Convert.ToInt32(Classcb.SelectedValue.ToString()), Convert.ToDecimal(txt_admissionfee.Text), Convert.ToDecimal(MonthlyFEE.Text), Convert.ToDecimal(txt_SecurityDeposit.Text), Convert.ToDecimal(txt_Coursefee.Text), Convert.ToDecimal(txt_SportFee.Text), Convert.ToDecimal(txt_others.Text),FeeID);
                Mainclass.ShowMsg("Fee Updated Successfully", "Success", "Success");
                loadata();



            }

        }

        private void loadata()
        {
            
            var abc = obj.getfeestructure();
            ClassGV.DataPropertyName = "Class";
            ClassIDGV.DataPropertyName = "ClassID";
            AdmissionGV.DataPropertyName = "AdmissionFee";
            MonthlyFeeGV.DataPropertyName = "MonthlyFee";
            SecurityDeptGV.DataPropertyName = "SecurityFee";
            CourseGv.DataPropertyName = "CourseFee";
            SportGV.DataPropertyName = "SportFee";
            OtherGV.DataPropertyName = "Other";
            dataGridView2.DataSource = abc;

         }


        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
