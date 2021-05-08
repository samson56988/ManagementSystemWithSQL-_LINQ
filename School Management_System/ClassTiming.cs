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
    public partial class ClassTiming : Form
    {
        public ClassTiming()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        private void ClassTiming_Load(object sender, EventArgs e)
        {
            loadlist();
            edit = 0;
            Mainclass.disable_reset(panel1);
            loadData();
        }
        public void loadlist()
        {

            var li = (from s in obj.Shiftts select new { s.ShiftID, s.Shiftname }).ToList();
            li.Insert(0, new { ShiftID = 0, Shiftname = "Select" });
            timeshiftcb.DataSource= li;
            timeshiftcb.DisplayMember= "Shiftname";
            timeshiftcb.ValueMember = "ShiftID";

            var li2 = (from s in obj.Levels select new { s.LevelID, s.Levelname }).ToList();
            li2.Insert(0, new { LevelID = 0, Levelname = "Select" });
            Timinglevelcb.DataSource = li2;
            Timingdaycb.DisplayMember = "Levelname";
            Timinglevelcb.ValueMember = "LevelID";

            var li3 = (from s in obj.Periods select new { s.PeriodID, s.Periodname }).ToList();
            li3.Insert(0, new { PeriodID = 0, Periodname = "Select" });
            periodcb.DataSource = li3;
            periodcb.DisplayMember = "Periodname";
            periodcb.ValueMember = "PeriodID";



        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.enable_reset(panel1);
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.enable_reset(panel1);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (periodcb.SelectedIndex == -1) { errorlabelperiodname.Visible = true; } else { errorlabelperiodname.Visible = false;}
            if (timeshiftcb.SelectedIndex == -1) { erroelabelshift.Visible = true; } else { erroelabelshift.Visible = false;}
            if (Timingdaycb.SelectedIndex == -1) { errorlabeltimingday.Visible = true; } else { errorlabeltimingday.Visible = false;}
            if (Timinglevelcb.SelectedIndex == -1) { errorlabeltiminglevel.Visible = true; } else { errorlabeltiminglevel.Visible = false; }
            if (errorlabelperiodname.Visible || erroelabelshift.Visible || errorlabeltimingday.Visible)
            {


                Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");


            }
            else 
            
            {
                if (edit == 0)
                {
                    TimeSpan startTime = new TimeSpan(Starttimedp.Value.Hour, Starttimedp.Value.Minute, Starttimedp.Value.Second);
                    TimeSpan EndTime = new TimeSpan(Endtimedp.Value.Hour, Endtimedp.Value.Minute, Endtimedp.Value.Second);
                    
                   
                        timing t = new timing();
                        obj.insertTiming(Convert.ToInt32(periodcb.SelectedValue.ToString()), Convert.ToInt32(timeshiftcb.SelectedValue.ToString()), startTime, EndTime, Timingdaycb.SelectedItem.ToString(), Convert.ToInt32(Timinglevelcb.SelectedValue.ToString()));
                        obj.SubmitChanges();
                        Mainclass.ShowMsg(periodcb.Text + "  added successfully.", "Success...", "Success");
                        Mainclass.disable_reset(panel1);
                        loadData();
                    
                    

                }

                else
                {
                    TimeSpan startTime = new TimeSpan(Starttimedp.Value.Hour, Starttimedp.Value.Minute, Starttimedp.Value.Second);
                    TimeSpan EndTime = new TimeSpan(Endtimedp.Value.Hour, Endtimedp.Value.Minute, Endtimedp.Value.Second);
                    obj.updatetimings(Convert.ToInt32(periodcb.SelectedValue.ToString()), Convert.ToInt32(timeshiftcb.SelectedValue.ToString()), startTime, EndTime, Timingdaycb.SelectedItem.ToString(), Convert.ToInt32(Timinglevelcb.SelectedValue.ToString()), TimeID);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(periodcb.Text + "  Updated successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel2);
                    loadData();
                
                }
                
                
                

            
            }
        }
        int TimeID;
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + periodcb.Text+ "?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.deleterole(TimeID);

                    Mainclass.ShowMsg(periodcb.Text + "  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var abc = obj.searchtiming(textBox1.Text);
            TimeIDGV.DataPropertyName = "ID";
            TimeNameGV.DataPropertyName = "Period";
            PeriodIDGV.DataPropertyName = "PeriodID";
            StarttimeGV.DataPropertyName = "From";
            EndtimeGV.DataPropertyName = "To";
            ShiftIDGV.DataPropertyName = "ShiftID";
            TimedayGV.DataPropertyName = "Day";
            LevelDGV.DataPropertyName = "LevelID";
            LevelnameIDG.DataPropertyName = "Level";
            ShiftnameGV.DataPropertyName = "ShiftName";
            dataGridView1.DataSource = abc;


            
        }

       

        private void timeshiftcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeshiftcb.SelectedIndex == -1) { erroelabelshift.Visible = true; } else { erroelabelshift.Visible = false; }
        }

        private void Starttimedp_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Timingdaycb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Timingdaycb.SelectedIndex == -1) { errorlabeltimingday.Visible = true; } else { errorlabeltimingday.Visible = false; }
        }

        private void Endtimedp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            var abc = obj.gettimings();

            TimeIDGV.DataPropertyName = "ID";
            TimeNameGV.DataPropertyName = "Period";
            PeriodIDGV.DataPropertyName = "PeriodID";
            StarttimeGV.DataPropertyName = "From";
            EndtimeGV.DataPropertyName = "To";
            ShiftIDGV.DataPropertyName = "ShiftID";
            TimedayGV.DataPropertyName = "Day";
            LevelDGV.DataPropertyName = "LevelID";
            LevelnameIDG.DataPropertyName = "Level";
            ShiftnameGV.DataPropertyName = "ShiftName";
            dataGridView1.DataSource = abc;


            //Mainclass.sno(dataGridView1, "SNOGVG");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                TimeID = Convert.ToInt32(row.Cells["TimeIDGV"].Value.ToString());
                periodcb.SelectedValue = row.Cells["TimeNameGV"].Value.ToString();
                Starttimedp.Value = Convert.ToDateTime(row.Cells["StarttimeGV"].Value.ToString());
                Endtimedp.Value= Convert.ToDateTime(row.Cells["EndtimeGV"].Value.ToString());
                Timingdaycb.SelectedItem = row.Cells["TimedayGV"].Value.ToString();
                timeshiftcb.SelectedValue = row.Cells["ShiftIDGV"].Value.ToString();
                Timinglevelcb.SelectedValue = row.Cells["LevelDGV"].Value.ToString(); 
  

            }
        }

        private void Timinglevelcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Timinglevelcb.SelectedIndex == -1) { errorlabeltiminglevel.Visible = true;} else{ errorlabeltiminglevel.Visible = false;}
        }

        private void periodcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(periodcb.SelectedIndex == -1) { errorlabelperiodname.Visible = true; } else{errorlabelperiodname.Visible = false;}
        }
    }
}
