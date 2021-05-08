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
    public partial class Shift : Form
    {
        public Shift()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();

        private void searchData()
        {
            var abc = obj.SearchShift(textBox1.Text);



            ShiftIDGV.DataPropertyName = "ID";
            ShiftGV.DataPropertyName = "Shift";
            ShiftNOGV.DataPropertyName = "ShiftNo";
            StarttimeGV.DataPropertyName = "StartTime";
            EndtimeGV.DataPropertyName = "EndTime";
            dataGridView1.DataSource = abc;
            //Mainclass.sno(dataGridView1, "SNOGVG");

        }
        private void loadData()
        {
            var abc = obj.getshift();

            ShiftIDGV.DataPropertyName = "ID";
            ShiftGV.DataPropertyName = "Shift";
            ShiftNOGV.DataPropertyName = "ShiftNo";
            StarttimeGV.DataPropertyName = "StartTime";
            EndtimeGV.DataPropertyName = "EndTime";
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
            if ( txt_shift.Text == "") { errorlabelshiftname.Visible = true; } else { errorlabelshiftname.Visible = false; }

           if (Shiftcb.SelectedIndex == -1) { Errorlabeelshiftnumber.Visible = true; } else { Errorlabeelshiftnumber.Visible = false; }
           if (errorlabelshiftname.Visible || Errorlabeelshiftnumber.Visible)
           {

               Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");

           }
           else
           {

               if (edit == 0)
               {


                   Shiftt s = new Shiftt();
                   TimeSpan startTime = new TimeSpan(Startpicker.Value.Hour,Startpicker.Value.Minute,Startpicker.Value.Second);
                   TimeSpan EndTime = new TimeSpan(Endpicker.Value.Hour,Endpicker.Value.Minute,Endpicker.Value.Second);
                   obj.insertshift(txt_shift.Text,Convert.ToByte(Shiftcb.SelectedItem.ToString()),startTime,EndTime);
                   obj.SubmitChanges();
                   Mainclass.ShowMsg(txt_shift.Text + "  added successfully.", "Success...", "Success");
                   Mainclass.disable_reset(panel1);
                   loadData();


               }
                   
               else if (edit == 1)
               {



                  
                   TimeSpan startTime = new TimeSpan(Startpicker.Value.Hour,Startpicker.Value.Minute,Startpicker.Value.Second);
                   TimeSpan EndTime = new TimeSpan(Endpicker.Value.Hour,Endpicker.Value.Minute,Endpicker.Value.Second);
                   obj.Updateshift(txt_shift.Text, Convert.ToByte(Shiftcb.SelectedItem.ToString()), startTime, EndTime,ShiftID);
                   obj.SubmitChanges();
                   Mainclass.ShowMsg(txt_shift.Text + "  Updated successfully.", "Success...", "Success");
                   Mainclass.disable_reset(panel2);
                   loadData();


               }
           }
        }
        int ShiftID;
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {


                DialogResult dr = MessageBox.Show("Are you sure you want to delete " + txt_shift.Text + "?", "Questions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    obj.deleterole(ShiftID);

                    Mainclass.ShowMsg(txt_shift.Text + "  deleted successfully.", "Success...", "Success");
                    Mainclass.disable_reset(panel1);
                    loadData();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if ( txt_shift.Text == "") { errorlabelshiftname.Visible = true; } else { errorlabelshiftname.Visible = false; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Shiftcb.SelectedIndex== -1) { Errorlabeelshiftnumber.Visible = true; } else { Errorlabeelshiftnumber.Visible= false; }
        }

        private void Shift_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ShiftID = Convert.ToInt32(row.Cells["ShiftIDGV"].Value.ToString());
                txt_shift.Text = row.Cells["ShiftGV"].Value.ToString();
                Startpicker.Value = Convert.ToDateTime(row.Cells["StarttimeGV"].Value.ToString());
                Endpicker.Value = Convert.ToDateTime(row.Cells["EndtimeGV"].Value.ToString());

            }
        }

        private void Startpicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
