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
    public partial class Sections : Form
    {
        public Sections()
        {
            InitializeComponent();
        }

        int edit = 0;
        myDBDataContext obj = new myDBDataContext();

        private void label3_Click(object sender, EventArgs e)
        {
            Home hs = new Home();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void searchData()
        {
            var abc = obj.searchsection(searchtxt.Text);



            SectID.DataPropertyName = "ID";
            Sectiondgv.DataPropertyName = "Section";
            Statusgv.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");

        }


        private void loadData()
        {
            var abc = obj.getsection();



           SectID.DataPropertyName = "ID";
           Sectiondgv.DataPropertyName = "Section";
           Statusgv.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");

        }
        //private void loadData()
        //{
        //    var abc = obj.gettimings();

        //    TimeIDGV.DataPropertyName = "ID";
        //    TimeNameGV.DataPropertyName = "Period";
        //    PeriodIDGV.DataPropertyName = "PeriodID";
        //    StarttimeGV.DataPropertyName = "From";
        //    EndtimeGV.DataPropertyName = "To";
        //    ShiftIDGV.DataPropertyName = "ShiftID";
        //    TimedayGV.DataPropertyName = "Day";
        //    LevelDGV.DataPropertyName = "LevelID";
        //    LevelnameIDG.DataPropertyName = "Level";
        //    ShiftnameGV.DataPropertyName = "ShiftName";
        //    dataGridView1.DataSource = abc;


        //    //Mainclass.sno(dataGridView1, "SNOGVG");

        //}
        private void txt_sectionname_TextChanged(object sender, EventArgs e)
        {
            if (txt_sectionname.Text == "") { errorlabelsectionname.Visible = true; } else { errorlabelsectionname.Visible= false; }
        }

        private void statuscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statuscb.SelectedIndex == -1) { errolabelstatus.Visible = true; } else { errolabelstatus.Visible = false; }
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
            if (txt_sectionname.Text == "") { errorlabelsectionname.Visible = true; } else { errorlabelsectionname.Visible = false; }
            if (statuscb.SelectedIndex == -1) { errolabelstatus.Visible = true; } else { errolabelstatus.Visible = false; }
            if (errorlabelsectionname.Visible || errolabelstatus.Visible)
            {

                Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");

            }
            else
            {

                if (edit == 0)
                {


                    section s = new section();
                    s.sec_name = txt_sectionname.Text;
                    if (statuscb.SelectedIndex == 0)
                    {

                        s.sec_status = 1;

                    }
                    else
                    {

                        s.sec_status = 0;

                    }

                    obj.insertsections(txt_sectionname.Text, s.sec_status);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_sectionname.Text + "  added successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();


                }
                else if (edit == 1)
                {



                    byte stat;
                    if (statuscb.SelectedIndex == 0)
                    {

                        stat = 1;

                    }
                    else
                    {

                        stat = 0;

                    }

                    obj.UpdateSection(txt_sectionname.Text, stat, StatID);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_sectionname.Text + "  Updated successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel2);
                    loadData();


                }
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txt_sectionname.Text + "?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.deleterole(StatID);

                    Mainclass.ShowMsg(txt_sectionname.Text + "  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();
                }
            }
        }

        private void Sections_Load(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.disable_reset(panel1);
            loadData();
        }
        int StatID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                StatID = Convert.ToInt32(row.Cells["SectID"].Value.ToString());
                txt_sectionname.Text = row.Cells["Sectiondgv"].Value.ToString();
                statuscb.SelectedValue = row.Cells["Statusgv"].Value.ToString();

            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
