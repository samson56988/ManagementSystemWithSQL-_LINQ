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
    public partial class FeeMethod : Form
    {
        public FeeMethod()
        {
            InitializeComponent();
        }
        myDBDataContext obj = new myDBDataContext();
        int edit = 0;
        private void btnadd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.enable_reset(panel1);
        }

        private void FeeMethod_Load(object sender, EventArgs e)
        {
            loadata();
            Mainclass.disable_reset(panel1);

        }

        private void loadata()
        {   
            var abc = obj.getMonthlyFee();
            MethodIDGv.DataPropertyName= "ID";
            BankGV.DataPropertyName = "Bank";
            BranchGV.DataPropertyName= "Branch";
            AddressGV.DataPropertyName= "Address";
            AccountGV.DataPropertyName= "Account";
            dataGridView2.DataSource = abc;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.enable(panel1);
        }
        int MethodID;
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (edit == 0)
            {


                obj.insertfeemethod(txt_bank.Text,txt_branch.Text,txt_Addrress.Text,txt_account.Text);
                Mainclass.ShowMsg("Fee Addedd Successfully", "Success", "Success");
                loadata();



            }
            else if (edit == 1)
            {

                obj.updatefeeMethod(txt_bank.Text, txt_branch.Text, txt_Addrress.Text, txt_account.Text,MethodID);
                Mainclass.ShowMsg("Fee Updated Successfully", "Success", "Success");
                loadata();


            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
