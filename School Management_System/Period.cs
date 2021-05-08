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
    public partial class Period : Form
    {
        
        public Period()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        private void Period_Load(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.disable_reset(panel1);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.enable_reset(panel1);
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.enable_reset(panel1);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txt_period.Text == "") { errorlabelperiodname.Visible = true; } else { errorlabelperiodname.Visible = false; }

            if (errorlabelperiodname.Visible)
            {

                Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");

            }
            else
            {

                if (edit == 0)
                {


                    Periods p = new Periods();
                    p.Periodname = txt_period.Text;
                   
                    //obj.roles.InsertOnSubmit(r);
                    obj.insertperiod(txt_period.Text);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_period.Text + "  added successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();

                }
                else if (edit == 1)
                {



                    
                    

                    obj.Updateperiod(txt_period.Text, PeriodID);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_period.Text + "  Updated successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel2);
                    loadData();


                }
            }
        }
        int PeriodID;
        private void Searchdata()
        {
            var abc = obj.getperiod();



            PeriodIDGV.DataPropertyName = "ID";
            PeriodGV.DataPropertyName = "Period";
            
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");

        }

        private void loadData()
        {
            var abc = obj.getperiod();



            PeriodIDGV.DataPropertyName = "ID";
            PeriodGV.DataPropertyName = "Period";
            
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txt_period.Text + "?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.DeletePeriod(PeriodID);

                    Mainclass.ShowMsg(txt_period.Text+ "  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();

                }
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_period_TextChanged(object sender, EventArgs e)
        {
            if (txt_period.Text == "") { errorlabelperiodname.Visible = true; } else { errorlabelperiodname.Visible = false; }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                PeriodID = Convert.ToInt32(row.Cells["PeriodIDGV"].Value.ToString()); 
                txt_period.Text = row.Cells["PeriodGV"].Value.ToString(); 
                

            }
        }
    }
}
