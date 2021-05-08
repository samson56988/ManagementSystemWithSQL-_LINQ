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
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        int roleID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void loadData()
        {
            var abc = obj.getroles();



            roledgv.DataPropertyName = "ID";
            Rolegv.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");

        }

        private void Role_Load(object sender, EventArgs e)
        {
            edit = 0;
            Mainclass.disable_reset(panel1);
            loadData();

        }

        private void txt_role_TextChanged(object sender, EventArgs e)
        {
            if (txt_role.Text == "") { erreorlabelrole.Visible = true; } else { erreorlabelrole.Visible = false; }
        }

        private void rolestatuscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolestatuscb.SelectedIndex == -1) { errorlabelrolestatus.Visible = true; } else { errorlabelrolestatus.Visible = false; }
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
            if (txt_role.Text == "") { erreorlabelrole.Visible = true; } else { erreorlabelrole.Visible = false; }
            if (rolestatuscb.SelectedIndex == -1) { errorlabelrolestatus.Visible = true; } else { errorlabelrolestatus.Visible = false; }
            if (erreorlabelrole.Visible || errorlabelrolestatus.Visible)
            {

                Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");

            }
            else
            {

                if (edit == 0)
                {


                    role r = new role();
                    r.rolename = txt_role.Text;
                    if (rolestatuscb.SelectedIndex == 0)
                    {

                        r.rolestatus = 1;

                    }
                    else
                    {

                        r.rolestatus = 0;

                    }
                    //obj.roles.InsertOnSubmit(r);
                    obj.InsertRole(txt_role.Text, r.rolestatus);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_role.Text + "  added successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();

                }
                else if (edit == 1)
                {



                    byte stat;
                    if (rolestatuscb.SelectedIndex == 0)
                    {

                        stat = 1;

                    }
                    else
                    {

                        stat = 0;

                    }

                    obj.UpdateRole(txt_role.Text, stat, roleID);
                    obj.SubmitChanges();
                    Mainclass.ShowMsg(txt_role.Text + "  Updated successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel2);
                    loadData();




                    //var data = obj.roles.Single(x => x.rolesID == roleID);

                    //data.rolename = txt_role.Text;
                    //if (rolestatuscb.SelectedIndex== 0)
                    //{

                    //    data.rolestatus = 1;

                    //}
                    //else
                    //{

                    //    data.rolestatus = 0;

                    //}
                    ////obj.roles.InsertOnSubmit(r);

                    //obj.SubmitChanges();
                    //Mainclass.ShowMsg(txt_role.Text + "  Updated successfully.", "Success...", "Success");
                    //Mainclass.disable_reset(panel1);
                    //loadData();

                }


            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txt_role.Text + "?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.deleterole(roleID);

                    Mainclass.ShowMsg(txt_role.Text + "  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                roleID = Convert.ToInt32(row.Cells["roledgv"].Value.ToString());
                txt_role.Text = row.Cells["Rolegv"].Value.ToString();
                rolestatuscb.SelectedItem = row.Cells["StatusGV"].Value.ToString();

            }
        }

        private void searchdata()
        {

            var abc = obj.searchrole(searchtxt.Text);
            roledgv.DataPropertyName = "ID";
            Rolegv.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");


        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            searchdata();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}