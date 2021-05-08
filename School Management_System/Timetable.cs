using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }
        int edit = 0;
        ReportDocument rd;
        myDBDataContext obj = new myDBDataContext();
        private void Timetable_Load(object sender, EventArgs e)
        {
            loadlist();
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

          
            var li4 = (from s in obj.Classes select new { s.Class_id, s.Class_name }).ToList();
            li4.Insert(0, new { Class_id = 0, Class_name = "Select" });
            Classcb.DataSource = li4;
            Classcb.DisplayMember = "Class_name";
            Classcb.ValueMember = "Class_id";

            

            var li2 = (from s in obj.sections where s.sec_status == 1 select new { s.sec_id, s.sec_name }).ToList();
            li2.Insert(0, new { sec_id = 0, sec_name = "Select" });
            sectioncb.DataSource = li2;
            sectioncb.DisplayMember = "sec_name";
            sectioncb.ValueMember = "sec_id";

        }

        public void showReport(int? ClassID,int? SecID,int? FacID)
        {
            try
            {
                rd = new ReportDocument();
                                    
                    var data = obj.getTimeTableReport(ClassID,FacID,SecID);
                    rd.Load(Application.StartupPath + "\\Reports\\ttreport.rpt");
                    rd.SetDataSource(data);
                    crystalReportViewer1.ReportSource = rd;
                    crystalReportViewer1.RefreshReport();
                 
            }
            catch( Exception ex)
            {
                Mainclass.ShowMsg(ex.Message, "Error", "Error");
            
            }
        
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Classcb.SelectedIndex != -1 && Classcb.SelectedIndex != 0 && 
                (Falcultycb.SelectedIndex == 0 || Falcultycb.SelectedIndex == -1) && 
                (sectioncb.SelectedIndex == 0 || sectioncb.SelectedIndex == -1))
            {

                showReport(Convert.ToInt32(Classcb.SelectedValue.ToString()), null, null);


            }

            else if (Classcb.SelectedIndex != -1 && Classcb.SelectedIndex != 0 && 
                (Falcultycb.SelectedIndex == 0 || Falcultycb.SelectedIndex == -1) && 
                (sectioncb.SelectedIndex != 0 && sectioncb.SelectedIndex != -1))
            {

                showReport(Convert.ToInt32(Classcb.SelectedValue.ToString()), Convert.ToInt32(sectioncb.SelectedValue.ToString()), null);

               
            }

            else if (Classcb.SelectedIndex == -1 || Classcb.SelectedIndex == 0 &&
               (Falcultycb.SelectedIndex == 0 && Falcultycb.SelectedIndex == -1) &&
               (sectioncb.SelectedIndex == 0 || sectioncb.SelectedIndex == -1))
            {

                showReport(null, null, Convert.ToInt32(Falcultycb.SelectedValue.ToString()));

            }



        }
    }
}
