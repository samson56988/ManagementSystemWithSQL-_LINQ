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
    public partial class Level : Form
    {
        public Level()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        int LevelID;
        private void searchData()
        {
            var abc = obj.Searchlevel(textBox1.Text);
            LevelIDGV.DataPropertyName = "ID";
            LevelGV.DataPropertyName = "Level";
            dataGridView1.DataSource = abc;
            



            
            //Mainclass.sno(dataGridView1, "SNOGVG");

        }
        private void loadData()
        {
            var abc = obj.getLevels();
            LevelIDGV.DataPropertyName = "ID";
            LevelGV.DataPropertyName = "Level";
            dataGridView1.DataSource = abc;
            
            


            //Mainclass.sno(dataGridView1, "SNOGVG");

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.enable_reset(panel1);
        }

        private void Level_Load(object sender, EventArgs e)
        {
            Mainclass.disable_reset(panel1);
            edit = 0;
            loadData();
           
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.enable_reset(panel1);
        }

        private void Savebtn_Click(object sender, EventArgs e)
          {if (txt_Levelname.Text == "") { errorlabelname.Visible = true; } else { errorlabelname.Visible = false; }
          if(errorlabelname.Visible || errorlabelname.Visible )
             
           {

               Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");

           }
           else
           {

               if (edit == 0)
               {


                   Levels s = new Levels();
                   obj.insertlevel(txt_Levelname.Text);
                   obj.SubmitChanges();
                   Mainclass.ShowMsg(txt_Levelname.Text + "  added successfully.", "Success...", "Success");
                   Mainclass.disable_reset(panel1);
                   loadData();


               }

               else if (edit == 1)
               {





                   obj.Updatelevel(txt_Levelname.Text, LevelID);
                   obj.SubmitChanges();
                   Mainclass.ShowMsg(txt_Levelname.Text + "  Updated successfully.", "Success...", "Success");
                   Mainclass.disable_reset(panel2);
                   loadData();


               }
           }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txt_Levelname.Text + "?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.deleterole(LevelID);

                    Mainclass.ShowMsg(txt_Levelname.Text + "  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void txt_Levelname_TextChanged(object sender, EventArgs e)
        {
            if (txt_Levelname.Text == "") { errorlabelname.Visible = true; } else { errorlabelname.Visible = false; }
        }
    }
}
