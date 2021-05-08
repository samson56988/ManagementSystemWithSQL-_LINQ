using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class Assignment : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-J3DHBNP\\SQLEXPRESS;Initial Catalog=Schoolmgtdt;Integrated Security=True");
        public Assignment()
        {
            InitializeComponent();
        }
          int edit = 0;
        myDBDataContext obj = new myDBDataContext();

       
        private void searchdata()
        {
            var abc = obj.searchassignment(textBox1.Text);

            AssignmentIDGV.DataPropertyName = "ID";
            DayGV.DataPropertyName = "Day";
         
            ClassIDGV.DataPropertyName = "ClassID";
            ClassGV.DataPropertyName = "Class";
            SubIDGV.DataPropertyName = "SubID";
            Subgv.DataPropertyName = "Subject";
            PeriodGV.DataPropertyName = "Period";
            PIDGV.DataPropertyName = "PeriodID";
            FalcultyGV.DataPropertyName = "Falculty";
            FIDGV.DataPropertyName = "FalcultyID";
            SectionIDGV.DataPropertyName = "SectionID";
            SectionGV.DataPropertyName = "Section";
            dataGridView.DataSource = abc;



            //Mainclass.sno(dataGridView1, "SNOGVG");

        }

       
        private void Falcultycb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Falcultycb.SelectedIndex != -1 && Falcultycb.SelectedIndex != 0)
            {
                txt_falculty.Text = Falcultycb.SelectedValue.ToString();
                errorlabelFalculty.Visible = false;

            }
            else
            {

                errorlabelFalculty.Visible = true;
            
            }
        }
        private void cc()
        {
            //comboBox2.Items.Clear();
            //con.Open();
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select Subname from Subject";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{

            //    comboBox2.Items.Add(dr["Subname"].ToString());
            //}


        
        }
        public void loadlist()
        {
            var li = (from s in obj.Staffs
                      join t in obj.roles on s.role equals t.rolesID
                      where t.rolename == "Falculty"
                      select new { s.staffID, s.name }).ToList();
            li.Insert(0, new { staffID = 0, name = "Select" });
            Falcultycb.DataSource = li;
            Falcultycb.DisplayMember = "name";
            Falcultycb.ValueMember = "staffID";

            

            var li4 = (from s in obj.Classes  select new { s.Class_id, s.Class_name }).ToList();
            li4.Insert(0, new { Class_id = 0, Class_name = "Select" });
            Classcb.DataSource = li4;
            Classcb.DisplayMember = "Class_name";
            Classcb.ValueMember = "Class_id";

            var li5 = (from s in obj.Subjects select new { s.SubID, s.Subname }).ToList();
            li5.Insert(0, new { SubID = 0, Subname = "Select" });
            comboBox2.DataSource = li5;
            comboBox2.DisplayMember = "Subname";
            comboBox2.ValueMember = "SubID";


            var li2 = (from s in obj.sections where s.sec_status == 1 select new { s.sec_id, s.sec_name }).ToList();
            li2.Insert(0, new { sec_id = 0, sec_name = "Select" });
            sectioncb.DataSource = li2;
            sectioncb.DisplayMember = "sec_name";
            sectioncb.ValueMember = "sec_id";

       }

        private void txt_falculty_TextChanged(object sender, EventArgs e)
        {

        }

        private void Classcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Classcb.SelectedIndex != -1  && Classcb.SelectedIndex !=0) 
            { 
                
                
                errorlabelclass.Visible = false; 
                int LevelID = 0;
                LevelID = (from x in obj.Levels join y in obj.Classes on x.LevelID equals y.cl_levelID where y.Class_id == Convert.ToInt32(Classcb.SelectedValue.ToString()) select x.LevelID).Single();


                var li3 = obj.getperiodWRTtiming(LevelID).ToList();

                periodcb.DataSource = li3;
                periodcb.DisplayMember = "Period";
                periodcb.ValueMember = "ID";
                periodcb.SelectedIndex = -1;

            } 
            
            
            
            
            else { errorlabelclass.Visible = true; }


        }

        

        private void Subjectcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == -1) { errorlabelsubject.Visible = true; } else { errorlabelsubject.Visible = false; }
        }

       

        private void addbtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.enable_reset(panel1);
            loadData();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.enable_reset(panel1);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (Falcultycb.SelectedIndex != -1 && Falcultycb.SelectedIndex != 0)
            {
                txt_falculty.Text = Falcultycb.SelectedValue.ToString();
                errorlabelFalculty.Visible = false;

            }
            else
            {

                errorlabelFalculty.Visible = true;

            }
            if (Classcb.SelectedIndex == -1) { errorlabelclass.Visible = true; } else { errorlabelclass.Visible = false; }
           
            if (comboBox2.SelectedIndex == -1) { errorlabelsubject.Visible = true; } else { errorlabelsubject.Visible = false; }
          
            if (errorlabelclass.Visible || errorlabelFalculty.Visible||errorlabelsubject.Visible)
            {

                Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");

            }
            else
            {

                if (edit == 0)
                {
                    if (sectioncb.SelectedIndex != -1 && sectioncb.SelectedIndex !=0)
                    {

                         obj.insertassignment(Convert.ToInt32(Classcb.SelectedValue.ToString()), Convert.ToInt32(periodcb.SelectedValue.ToString()), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToInt32(Falcultycb.SelectedValue.ToString()),Convert.ToInt32(sectioncb.SelectedValue.ToString()));
                        
                    }
                    else
                    {

                        obj.insertassignment(Convert.ToInt32(Classcb.SelectedValue.ToString()), Convert.ToInt32(periodcb.SelectedValue.ToString()), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToInt32(Falcultycb.SelectedValue.ToString()), null);

                    }

                    obj.SubmitChanges();
                    Mainclass.ShowMsg(Falcultycb.Text +" has been assigned to "+ Classcb.Text +  " added successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();
                   
                }
                else if (edit == 1)
                {


                    if (sectioncb.SelectedIndex != 1 && sectioncb.SelectedIndex != 0)
                    {

                        obj.Updatefalculty(Convert.ToInt32(Classcb.SelectedValue.ToString()), Convert.ToInt32(periodcb.SelectedValue.ToString()), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToInt32(Falcultycb.SelectedItem.ToString()), assignmentID, Convert.ToInt32(sectioncb.SelectedValue.ToString()));

                    }
                    else
                    {

                        obj.Updatefalculty(Convert.ToInt32(Classcb.SelectedValue.ToString()), Convert.ToInt32(periodcb.SelectedValue.ToString()), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToInt32(Falcultycb.SelectedValue.ToString()),assignmentID, null);

                    }


                   
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(Falcultycb.Text + "  Updated successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel2);
                    loadData();


                }
            
            
            }



        }
        int assignmentID;
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete "  
                    +Falcultycb.Text + "?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.deleteassignment(assignmentID); 
                    Mainclass.ShowMsg(Falcultycb.Text + "  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                assignmentID = Convert.ToInt32(row.Cells["AssignmentIDGV"].Value.ToString());
                Falcultycb.SelectedValue = row.Cells["FIDGV"].Value.ToString();
                Classcb.SelectedValue = row.Cells["ClassIDGV"].Value.ToString();
                periodcb.SelectedValue = row.Cells["TimingIDGV"].Value.ToString(); 
                comboBox2.SelectedValue = row.Cells["SubIDGV"].Value.ToString();
              

                if (row.Cells["SectionIDGV"].Value == null)
                {

                    sectioncb.SelectedIndex = 0;

                }

                else 
                {

                    sectioncb.SelectedValue = row.Cells["SectionIDGV"].Value;
                
                }

               }
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            edit = 0;
            Mainclass.disable_reset(panel1);
            loadlist();
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void periodcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (periodcb.SelectedIndex == -1) { errorlabelperiodcb.Visible = true; } else { errorlabelperiodcb.Visible = false; }
        }

        private void loadData()
        {
            var abc = obj.getASSignment();


            AssignmentIDGV.DataPropertyName = "ID";
            DayGV.DataPropertyName = "Day";

            ClassIDGV.DataPropertyName = "ClassID";
            ClassGV.DataPropertyName = "Class";
            SubIDGV.DataPropertyName = "SubID";
            Subgv.DataPropertyName = "Subject";
            PeriodGV.DataPropertyName = "PeriodName";
            PIDGV.DataPropertyName = "PeriodID";
            FalcultyGV.DataPropertyName = "Falculty";
            FIDGV.DataPropertyName = "FalcultyID";
            SectionIDGV.DataPropertyName = "SectionID";
            SectionGV.DataPropertyName = "Section";
            TimingIDGV.DataPropertyName = "TTID";
            dataGridView.DataSource = abc;


            //Mainclass.sno(dataGridView1, "SNOGVG");
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
