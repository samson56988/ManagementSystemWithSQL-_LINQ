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
    public partial class House : Form
    {
        public House()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        private void House_Load(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.disable_reset(panel1);
            loadData();
            


        }

        private void loadData()
        {
            var abc = obj.gethouse();



            HouseIDGV.DataPropertyName = "ID";
            HousenameGV.DataPropertyName = "House"; 
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");

        }

        private void searchdata()
        {
            var abc = obj.Searchhouse(textBox1.Text);



            HouseIDGV.DataPropertyName = "ID";
            HouseIDGV.DataPropertyName = "House";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");

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
            if (txt_house.Text == "") { errorlabelhousename.Visible = true; } else { errorlabelhousename.Visible = false; }
            if (Statuscb.SelectedIndex == -1) { errorlabelhousestatus.Visible = true; } else { errorlabelhousestatus.Visible = false; }
            if (errorlabelhousename.Visible || errorlabelhousestatus.Visible)
            {

                Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");

            }
            else
            {

                if (edit == 0)
                {


                    Housee h = new Housee();
                    h.Housename = txt_house.Text;
                    if (Statuscb.SelectedIndex == 0)
                    {

                        h.Housestatus = 1;

                    }
                    else
                    {

                        h.Housestatus = 0;

                    }
                    //obj.roles.InsertOnSubmit(r);
                    obj.inserthouse(txt_house.Text, h.Housestatus);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_house.Text + "  added successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();

                }
                else if (edit == 1)
                {



                    byte stat;
                    if (Statuscb.SelectedIndex == 0)
                    {

                        stat = 1;

                    }
                    else
                    {

                        stat = 0;

                    }

                    obj.UpdateRole(txt_house.Text, stat, HouseID);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_house.Text + "  Updated successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel2);
                    loadData();


                }
            }
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txt_house.Text+ "?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.Deletehouse(HouseID);

                    Mainclass.ShowMsg(txt_house.Text + "  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();
                }
            }
        }
       int HouseID;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchdata();

        }

        private void txt_house_TextChanged(object sender, EventArgs e)
        {
            if (txt_house.Text == "") { errorlabelhousename.Visible = true; } else { errorlabelhousename.Visible = false; }
        }

        private void Statuscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Statuscb.SelectedIndex == -1) { errorlabelhousestatus.Visible = true; } else { errorlabelhousestatus.Visible = false; }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
