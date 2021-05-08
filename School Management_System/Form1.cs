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
namespace School_Management_System
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        Mainclass main = new Mainclass();
        private void button1_Click(object sender, EventArgs e)
        {
             StringBuilder sb = new StringBuilder();
            if (ISCB.Checked)
            {
                if (txt_datasource.Text == "")
                {
                    errorlabledatasource.Visible = true;
                }

                else
                {

                    errorlabledatasource.Visible = false;

                }

                if (txt_database.Text == "")
                {
                    errorlabeldatabase.Visible = true;
                }

                else
                {

                    errorlabeldatabase.Visible = false;

                }

                if (!errorlabeldatabase.Visible && !errorlabeldatabase.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }

                else
                {

                    sb.Append("Data Source="+txt_datasource.Text+";Initial Catalog="+txt_database.Text+";Integrated Security=true;MultipleActiveResultSets=true");
                    File.WriteAllText(main.path+"\\connect",sb.ToString());    
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information );
                    if(dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        Mainclass.showWindow(log, this,Mdi.ActiveForm);

                    
                    }
                }
            }

            else

                if (txt_datasource.Text == "")
                {
                    errorlabledatasource.Visible = true;
                }

                else
                {

                    errorlabledatasource.Visible = false;

                }

            if (txt_database.Text == "")
            {
                errorlabeldatabase.Visible = true;
            }

            else
            {

                errorlabeldatabase.Visible = false;

            }

            if (txt_username.Text == "")
            {
                errorlabelusername.Visible = true;
            }

            else
            {

                errorlabelusername.Visible = false;

            }

            if (txt_password.Text == "")
            {
                errorlabelpassword.Visible = true;
            }

            else
            {

                errorlabelpassword.Visible = false;

            }

                if (errorlabeldatabase.Visible || errorlabledatasource.Visible|| errorlabelusername.Visible || errorlabelpassword.Visible)
                {
                    MessageBox.Show("Fields with * are mandatory");
                }

                else
                {

                    sb.Append("Data Source="+txt_datasource.Text+";Initial Catalog="+txt_database.Text+";User ID="+txt_username.Text+";Password="+txt_password.Text+";MultipleActiveResultSets=true");
                    File.WriteAllText(main.path+"\\connect",sb.ToString());    
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information );
                    if(dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        Mainclass.showWindow(log, this,Mdi.ActiveForm);

                    
                    }

                }


            
        }

        private void txt_datasource_TextChanged(object sender, EventArgs e)
        {
            if (txt_datasource.Text == "")
            {
                errorlabledatasource.Visible = true;
            }

            else
            {

                errorlabledatasource.Visible = false;

            }
        }

        private void txt_database_TextChanged(object sender, EventArgs e)
        {
            if (txt_database.Text == "")
            {
                errorlabeldatabase.Visible= true;
            }

            else
            {

                errorlabeldatabase.Visible = false;

            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                errorlabelusername.Visible = true;
            }

            else
            {

                errorlabelusername.Visible = false;

            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                errorlabelpassword.Visible = true;
            }

            else
            {

                errorlabelpassword.Visible = false;

            }
        }

        private void ISCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ISCB.Checked)
            {
               txt_username.Text = "";
               txt_username.Enabled = false;

                txt_password.Text = "";
                txt_password.Enabled= false;

                errorlabelusername.Visible = false;
                errorlabelpassword.Visible = false;
            }

            else
            {
                txt_username.Enabled = true;
                txt_password.Enabled = true;
               

            }
        }
    }
}
