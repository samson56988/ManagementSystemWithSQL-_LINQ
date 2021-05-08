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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
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
            if (txt_subject.Text == "") { Errorlabelsubject.Visible = true; } else { Errorlabelsubject.Visible = false; }
            if (Errorlabelsubject.Visible)
            {

                Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");

            }
            else
            {

                if (edit == 0)
                {

                    try
                    {

                        Subject c = new Subject();
                        c.Subname = txt_subject.Text;


                        //obj.roles.InsertOnSubmit(r);
                        obj.insertsubject(txt_subject.Text);
                        obj.SubmitChanges();
                        Mainclass.ShowMsg(txt_subject.Text + "  added successfully.", "Success...", "Success");
                        Mainclass.disable_reset(panel1);
                        loadData();
                    
                    }
                    catch (Exception ex)
                       
                      {
                          Mainclass.ShowMsg("Are trying to insert same lines", "Error", "Error");
                      
                      }

                   

                }
                else if (edit == 1)
                {



                    
                    

                    obj.updatesubject(txt_subject.Text,SubjectID);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_subject.Text + "  Updated successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel2);
                    loadData();


                }
            }
        }
        int SubjectID;
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txt_subject.Text + "?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.deletesubject(SubjectID);

                    Mainclass.ShowMsg(txt_subject.Text + "  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();
                }
            }
        }

        private void txt_subject_TextChanged(object sender, EventArgs e)
        {
            if (txt_subject.Text == "") { Errorlabelsubject.Visible = true; } else { Errorlabelsubject.Visible = false; }
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.disable_reset(panel1);
            loadData();
            
        }

        private void loadData()
        {
            var abc = obj.getsubject();



            SubjectIDgv.DataPropertyName = "ID";
            Subjectgv.DataPropertyName= "Subject";
            dataGridView1.DataSource = abc;
           
            //Mainclass.sno(dataGridView1, "SNOGVG");

        }

        private void SearchData()
        {
            var abc = obj.searchsubject(textBox1.Text);



            SubjectIDgv.DataPropertyName = "ID";
            Subjectgv.DataPropertyName = "Subject";
           
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                SubjectID = Convert.ToInt32(row.Cells["SubjectIDgv"].Value.ToString());
                txt_subject.Text = row.Cells["Subjectgv"].Value.ToString();
                

            }
        }

       

       
    }
}
