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
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
       
        private void Classes_Load(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.disable_reset(panel1);
            loadData();
            loadlist();
        }
        private void loadData()
        {
            var abc = obj.getclass();



          ClassIDgv.DataPropertyName= "ID";
            Classgv.DataPropertyName = "Class";
            StatusGV.DataPropertyName = "Status";
            LevelIDGV.DataPropertyName = "LevelID";
            Levelgv.DataPropertyName = "Level";
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");

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
            if (txt_class.Text == "") { errorlabelclassname.Visible = true; } else { errorlabelclassname.Visible = false; }
            if (selection_cb.SelectedIndex == -1) { errorlabelsecctionname.Visible = true; }{ errorlabelsecctionname.Visible = false; }
            if (Levelcb.SelectedIndex == -1) { errorlablelevel.Visible = true; } else { errorlablelevel.Visible = false; }
            if (errorlabelclassname.Visible || errorlabelsecctionname.Visible||errorlablelevel.Visible)
            {

                Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");

            }
            else
            {

                if (edit == 0)
                {


                    Class c = new Class();
                    c.Class_name = txt_class.Text;
                    if (selection_cb.SelectedIndex == 0)
                    {

                        c.class_stat = 1;

                    }
                    else
                    {

                        c.class_stat = 0;

                    }
                    //obj.roles.InsertOnSubmit(r);
                    obj.insertclass(txt_class.Text, c.class_stat, Convert.ToInt32(Levelcb.SelectedValue.ToString()));
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_class.Text + "  added successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();

                }
                else if (edit == 1)
                {



                    byte stat;
                    if (selection_cb.SelectedIndex == 0)
                    {

                        stat = 1;

                    }
                    else
                    {

                        stat = 0;

                    }

                    obj.updateclass(txt_class.Text, stat, Convert.ToInt32(Levelcb.SelectedValue.ToString()), ClassID);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_class.Text + "  Updated successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel2);
                    loadData();


                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txt_class.Text + "?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.deleterole(ClassID);

                    Mainclass.ShowMsg(txt_class.Text + "  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();
                }
            }
        }
        int ClassID;

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            searchdata();
        }

        private void txt_class_TextChanged(object sender, EventArgs e)
        {

            if (txt_class.Text == "") { errorlabelclassname.Visible = true; } else { errorlabelclassname.Visible = false; }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void selection_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selection_cb.SelectedIndex == -1) { errorlabelsecctionname.Visible = true; }{errorlabelsecctionname.Visible = false;}

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ClassID = Convert.ToInt32(row.Cells["ClassIDgv"].Value.ToString());
                txt_class.Text = row.Cells["Classgv"].Value.ToString();
                selection_cb.SelectedValue = row.Cells["StatusGV"].Value.ToString();
                Levelcb.SelectedValue = row.Cells["LevelIDGV"].Value.ToString();

            }
        }

        public void loadlist()
        {

            var li = (from s in obj.Levels select new { s.LevelID, s.Levelname }).ToList();
            li.Insert(0, new { LevelID = 0, Levelname = "Select" });
            Levelcb.DataSource = li;
            Levelcb.DisplayMember = "Levelname";
            Levelcb.ValueMember = "LevelID";
        }


        private void searchdata()
        {

            var abc = obj.searchclass(searchtxt.Text);
            ClassIDgv.DataPropertyName = "ID";
            Classgv.DataPropertyName = "Class";
            StatusGV.DataPropertyName = "Status";
            LevelIDGV.DataPropertyName = "LevelID";
            Levelgv.DataPropertyName = "Level";
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");


        }

        private void Levelcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Levelcb.SelectedIndex == -1) { errorlablelevel.Visible = true; } else { errorlablelevel.Visible = false; }
        }
    }
}
