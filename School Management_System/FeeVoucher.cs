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
    public partial class FeeVoucher : Form
    {
        public FeeVoucher()
        {
            InitializeComponent();
        }

        myDBDataContext obj = new myDBDataContext();
        int edit = 0;

        private void btnadd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.enable_reset(panel1);
            latefee.Enabled = false;
            Monthlyfee_txt.Enabled = false;
            //classcb.SelectedIndex = 0;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.enable(panel1);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            byte admissionFeestatus = Admisssioncheckbox.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
            byte sportFeeStatus = Sportcheckbox.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
            byte SecuirityFeeStatus = Securitycheckbox.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
            byte courseFeestatus = Coursefeecheck.Checked ? Convert.ToByte(1) : Convert.ToByte(0);
            byte otherfeestatus = otherscb.Checked ? Convert.ToByte(1) : Convert.ToByte(0);

            if (edit == 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {

                    string reason; float discount;
                    if (row.Cells["ReasonGV"].Value == null || row.Cells["ReasonGV"].Value.ToString() == "") { reason = ""; } else { reason = row.Cells["ReasonGV"].Value.ToString(); }
                    if (row.Cells["DiscountGV"].Value == null || row.Cells["DiscountGV"].Value.ToString() == "") { discount = 0; } else { discount = Convert.ToSingle(row.Cells["DiscountGV"].Value.ToString()); }
                    obj.insertintoFeeVoucher(Convert.ToByte(dateTimePicker1.Value.Month), Convert.ToByte(dateTimePicker1.Value.Year),
                        Convert.ToInt16(row.Cells["StudentIDGV"].Value.ToString()),
                        Convert.ToInt32(classcb.SelectedValue.ToString()),
                        dateTimePicker2.Value, discount, 0, Convert.ToByte(paymentcb.SelectedValue.ToString()), 0, reason, 
                        admissionFeestatus, sportFeeStatus, courseFeestatus, SecuirityFeeStatus, 
                        otherfeestatus);






                }
                Mainclass.ShowMsg(classcb.Text + " Voucher added successfully.", "Success...", "Success");
                Mainclass.disable_reset(panel1);
              









            }
            else
            {
                Mainclass.ShowMsg(classcb.Text + " Voucher Updated successfully.", "Success...", "Success");
                Mainclass.disable_reset(panel1);
              
            
            }

        }
        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void classcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classcb.SelectedIndex != -1 && classcb.SelectedIndex != 0)
            {

                Errorlabelclass.Visible = false;
                var studentlist = obj.getstudentWRTclass(Convert.ToInt32(classcb.SelectedValue.ToString()));
                StudentGV.DataPropertyName = "Name";
                StudentIDGV.DataPropertyName = "ID"; 
                dataGridView2.DataSource = studentlist;
                var fee = obj.getmonthlyfeeWRTclass(Convert.ToInt32(classcb.SelectedValue.ToString()));
                foreach (var item in fee)
                {

                    latefee.Text = Math.Truncate(Convert.ToDouble(item.LateFee)).ToString();
                    Monthlyfee_txt.Text = Math.Truncate(Convert.ToDouble(item.Monthly)).ToString();
                
                
                }
               // Mainclass.checkunchecked(dataGridView2 , "SelectGV");
            }
                else
                {
                
                
                  Errorlabelclass.Visible = true;


                }


            
            
            
        }


        public void loadlist()
        {
            var li4 = (from s in obj.Classes select new { s.Class_id, s.Class_name }).ToList();
            li4.Insert(0, new { Class_id = 0, Class_name = "Select" });
            classcb.DataSource = li4; 
            classcb.DisplayMember = "Class_name";
            classcb.ValueMember = "Class_id";


            var li5 = (from s in obj.FeeMethods select new { s.MethodID, s.Bank }).ToList();
            li5.Insert(0, new { MethodID = 0, Bank = "Select" });
            paymentcb.DataSource = li5;
            paymentcb.DisplayMember = "Bank";
            paymentcb.ValueMember = "MethodID";  




            
        
        
        }

        private void FeeVoucher_Load(object sender, EventArgs e)
        {
           // loadata();
            Mainclass.disable_reset(panel1);
            loadlist();
        }
    }

}
