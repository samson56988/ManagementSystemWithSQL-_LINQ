using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Configuration;
using System.Drawing.Imaging;
using System.Data.SqlClient;


namespace School_Management_System
{
    public partial class Stafff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-J3DHBNP\\SQLEXPRESS;Initial Catalog=Schoolmgtdt;Integrated Security=True");
        
        public Stafff()
        {
            InitializeComponent();
        }
        int edit = 0;
        myDBDataContext obj = new myDBDataContext();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadlist()
        {

            var li = (from s in obj.roles select new { s.rolesID, s.rolename }).ToList();
            li.Insert(0, new { rolesID = 0, rolename = "Select" });
            rolecb.DataSource = li;
            rolecb.DisplayMember = "rolename";
            rolecb.ValueMember = "rolesID";

        
        }


        public void cc()
        {
            rolecb.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select rolename from role";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                rolecb.Items.Add(dr["rolename"].ToString());
            
            }

            con.Close();

        }
        private void loadstaff()
        {
            var data = obj.getstaff();

            UserIDGV.DataPropertyName = "ID";
            NameGV.DataPropertyName = "Name";
           UsernameGV.DataPropertyName = "Username";
           PasswordGV.DataPropertyName = "Password";
            Phone1GV.DataPropertyName= "Phone1";
            Phone2GV.DataPropertyName = "Phone2";
            RoleGV.DataPropertyName= "Role";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = data;
            RoleIDGV.DataPropertyName = "RoleID";
            Mainclass.sno(dataGridView1, "snogv");
            


        
        
        }

        private void Staf_f_Load(object sender, EventArgs e)
        {

            loadstaff();
            Mainclass.disable_reset(panel1);
            edit = 0;
            loadlist();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Mainclass.enable_reset(panel1);
            Image.Enabled = false;
            edit = 0;
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            edit = 1;
            Mainclass.enable(panel1);
            Image.Enabled = false;

        }


      

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "") { errorlabelname.Visible = true; } else { errorlabelname.Visible = false; }
            if (txt_username.Text == "") { errorlabelusername.Visible = true; } else { errorlabelusername.Visible = false; }
            if (txt_password.Text == "") { errorlabelpassword.Visible = true; } else { errorlabelpassword.Visible = false; }
            if (txt_conpass.Text == "") { errorlabelconpass.Visible = true; } else { errorlabelconpass.Visible = false; }

            if (txt_phone.Text == "") { errorlabelphone.Visible = true; } else { errorlabelphone.Visible = false; }
            if (rolecb.SelectedIndex == -1) { erroelabelrole.Visible = true; } else { erroelabelrole.Visible = false; }
            if (rolestatus.SelectedIndex == -1) { errorlabelstatus.Visible = true;  } else { errorlabelstatus.Visible = false; }

            if (errorlabelname.Visible || errorlabelusername.Visible || errorlabelpassword.Visible || errorlabelconpass.Visible || errorlabelphone.Visible || erroelabelrole.Visible || errorlabelstatus.Visible)
            {

                Mainclass.ShowMsg("Fields with * are mandatory", "Stop.....", "Error");
            }
            if (txt_password.Text != txt_conpass.Text)
            {
                MessageBox.Show("Password mismatched");

            }
            else
            {
                if (edit == 0)
                {
                    if (Image.Text == "")
                    {
                        byte stat = rolestatus.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                        obj.InsertStaffwithoutimage(txt_name.Text, txt_username.Text, txt_password.Text, txt_phone.Text, txt_phone2.Text, Convert.ToInt32(rolecb.SelectedIndex.ToString()), stat);
                        Mainclass.ShowMsg(txt_name.Text + "  added successfully.", "Success", "Success");
                        Mainclass.disable_reset(panel1);
                        loadstaff();

                    }
                    else
                    {
                        byte stat = rolestatus.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                        MemoryStream ms = new MemoryStream();
                        i.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();
                        obj.InsertStaff(txt_name.Text, txt_username.Text, txt_password.Text, txt_phone.Text, txt_phone2.Text, Convert.ToInt32(rolecb.SelectedIndex.ToString()), stat, arr);
                        Mainclass.ShowMsg(txt_name.Text + "  added successfully.", "Success", "Success");
                        Mainclass.disable_reset(panel1);
                        loadstaff();
                    }

                }
                else if (edit == 1)
                {
                    byte stat = rolestatus.SelectedIndex == 0 ? Convert.ToByte(1) : Convert.ToByte(0);
                    if (i == null)
                    {
                        obj.Updatestaffwithoutimage(txt_name.Text, txt_username.Text, txt_password.Text, txt_phone.Text, txt_phone2.Text, Convert.ToInt32(rolecb.SelectedIndex.ToString()), stat, StaffID);
                        Mainclass.ShowMsg(txt_name.Text + "  Updated successfully.", "Success", "Success");
                        Mainclass.disable_reset(panel1);
                        loadstaff();

                    }
                    else
                    {

                        MemoryStream ms = new MemoryStream();
                        i.Save(ms, ImageFormat.Jpeg);
                        byte[] arr = ms.ToArray();
                        obj.UpdateStaff(txt_name.Text, txt_username.Text, txt_password.Text, txt_phone.Text, txt_phone2.Text, Convert.ToInt32(rolecb.SelectedIndex.ToString()), stat,arr, StaffID);
                        Mainclass.ShowMsg(txt_name.Text + "  Updated successfully.", "Success", "Success");
                        Mainclass.disable_reset(panel1);
                        loadstaff();
                        
                    
                    
                    }

                }

            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                obj.deletestaff(StaffID);
                Mainclass.ShowMsg(txt_name.Text + "  Deleted successfully.", "Success", "Success");
                Mainclass.disable_reset(panel1);
                loadstaff();
                
            
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        Image i;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                i = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = i;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                Image.Text = openFileDialog1.FileName;

            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_name.Text == "") { errorlabelname.Visible = true; } else { errorlabelname.Visible = false; }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (txt_username.Text == "") { errorlabelusername.Visible = true; } else { errorlabelusername.Visible = false; }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text == "") { errorlabelpassword.Visible = true; } else { errorlabelpassword.Visible = false; }
        }

        private void txt_conpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (txt_phone.Text == "") { errorlabelphone.Visible = true; } else { errorlabelphone.Visible = false; }
        }

        private void rolecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolecb.SelectedIndex == -1) { erroelabelrole.Visible = true; } else { erroelabelrole.Visible = false; }
        }

        private void rolestatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rolestatus.SelectedIndex == -1) { errorlabelstatus.Visible = true; } else { errorlabelstatus.Visible = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadstaff();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int StaffID;
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                StaffID = Convert.ToInt32(row.Cells["UserIDGV"].Value.ToString()); 
 
                txt_name.Text = row.Cells["NameGV"].Value.ToString();
                txt_username.Text = row.Cells["UsernameGV"].Value.ToString();
                txt_password.Text = row.Cells["PasswordGV"].Value.ToString();
                txt_conpass.Text = row.Cells["PasswordGV"].Value.ToString();
                txt_phone.Text = row.Cells["Phone1GV"].Value.ToString();
                txt_phone2.SelectedText = row.Cells["Phone2GV"].Value.ToString();
                rolecb.SelectedValue = row.Cells["RoleGV"].Value.ToString();  
                rolestatus.SelectedItem = row.Cells["StatusGV"].Value.ToString();

                var im = (from x in obj.Staffs where x.staffID == StaffID select x.image).First();
                if (im == null)
                {



                }
                else 
                {
                    byte[] arr = im.ToArray();
                    MemoryStream ms = new MemoryStream(arr);
                    i = System.Drawing.Image.FromStream(ms);
                    pictureBox1.Image = i;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                
                
                }

            }
        }

        private void searchdata()
        {
            var abc = obj.searchstaff(textBox1.Text);
            UserIDGV.DataPropertyName = "ID";
            NameGV.DataPropertyName = "Name";
            UsernameGV.DataPropertyName = "Username";
            PasswordGV.DataPropertyName = "Password";
            Phone1GV.DataPropertyName = "Phone1";
            Phone2GV.DataPropertyName = "Phone2";
            RoleGV.DataPropertyName = "Role";
            StatusGV.DataPropertyName = "Status";
            dataGridView1.DataSource = abc;
            RoleIDGV.DataPropertyName = "RoleID";
            Mainclass.sno(dataGridView1, "snogv");
            
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchdata();
        }
        }

       

       
    }

