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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        myDBDataContext obj = new myDBDataContext();

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        Mainclass mai = new Mainclass();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "") { errorlabelUsernme.Visible = true; } else { errorlabelUsernme.Visible = false; }
            if (txt_password.Text == "") { errorlabelpassword.Visible = true; } else { errorlabelpassword.Visible = false; }

            if (errorlabelpassword.Visible || errorlabelUsernme.Visible)
            {
                Mainclass.ShowMsg("Field with * are mandatory", "Error...", "Error..");

            }
            else
            {
              if(mai.getStaffLogin(txt_username.Text,txt_password.Text))
              {

                  if (Mainclass.STAFFROLE == "Falculty")
                  {

                      FalcultyDashboard hs = new FalcultyDashboard();
                      Mainclass.showWindow(hs, this, Mdi.ActiveForm);
                  
                  
                  }

                  if (Mainclass.STAFFROLE == "Admin")
                  {
                      Home hs = new Home();
                      Mainclass.showWindow(hs, this, Mdi.ActiveForm);
                  
                  }
                  if (Mainclass.STAFFROLE == "Teacher")
                  {


                  }
                  if (Mainclass.STAFFROLE == "Principal")
                  {


                  }




                  
              }

                else
                {
                    Mainclass.ShowMsg("Invalid Login Details", "Error...", "Error..");
                
                }
            
            
            }

            
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if (txt_username.Text == "") { errorlabelUsernme.Visible = true; } else { errorlabelUsernme.Visible= false; }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text == "") { errorlabelpassword.Visible = true; } else { errorlabelpassword.Visible = false; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
