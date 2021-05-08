using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    class Mainclass
    {
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\connect";
        myDBDataContext obj = new myDBDataContext();
        private static int StaffID;
        private static string staffName;
        private  static string staffRole;


        public static int STAFFID
        {

            get
            {
                return StaffID;
            }
            private set

            {
                StaffID = value;
            
            }
        
        
        }
        public static string STAFFNAME
        {

            get
            {
                return staffName;
            }
            private set
            {
                staffName = value;

            }


        }
        public static string STAFFROLE
        {

            get
            {
                return staffRole;
            }
            private set
            {
                staffRole= value;

            }


        }
        bool chk;
       
        public bool getStaffLogin(string un, string pass)
        {
           

            var abc = obj.getstaffLoginDetails(un, pass);

            foreach (var item in abc)
            {

                if (item.Name == null || item.Name == "")
                {
                    
                    chk = false;
                    break;

                }
                else
                {
                    chk = true;


                }
                STAFFID = item.ID;
                STAFFNAME = item.Name;
                STAFFROLE = item.Role;
            
            }
            
            return chk;
            
        
        
        }
        public static void showWindow(Form openWin, Form closewin, Form Mdi)
        {

            closewin.Close();
            openWin.WindowState = FormWindowState.Maximized;
            openWin.MdiParent = Mdi;
            openWin.Show();



        }

        public static void checkunchecked(DataGridView gv, CheckBox cb, string colname)
        {

            if (cb.Checked)
            {
                foreach (DataGridViewRow row in gv.Rows)
                {
                    row.Cells[colname].Value = 1;



                }
            }

            else
            {



                foreach (DataGridViewRow row in gv.Rows)
                {
                    row.Cells[colname].Value = 0;



                }

            } 
            
        
        
        
        }

        public static void sno(DataGridView gv, string colname)
        {

            int count = 0;
            foreach (DataGridViewRow row in gv.Rows)
            {

                count++;
                row.Cells[colname].Value = count;


            }
        }

        public static DialogResult ShowMsg(string msg, string heading, string type)
        {


            if (type == "Success")
            {

                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {

                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }


        public static void disable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {

                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";


                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;


                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;


                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                    cb.Checked = false;


                }

                if (c is DateTimePicker)
                {
                    DateTimePicker cb = (DateTimePicker)c;
                    cb.Enabled = false;
                    cb.Value = DateTime.Now;


                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }













            }



        }
        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {

                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;


                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;



                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;



                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;



                }

                if (c is DateTimePicker)
                {
                    DateTimePicker cb = (DateTimePicker)c;
                    cb.Enabled = false;



                }


                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }














            }



        }
        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {

                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";


                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;


                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;


                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;


                }

                if (c is DateTimePicker)
                {
                    DateTimePicker cb = (DateTimePicker)c;
                    cb.Enabled = true;
                    cb.Value = DateTime.Now;


                }
                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;

                }













            }



        }
        public static void enable_reset(GroupBox gb)
        {
            foreach (Control c in gb.Controls)
            {

                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";


                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;


                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;


                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;


                }

                if (c is DateTimePicker)
                {
                    DateTimePicker cb = (DateTimePicker)c;
                    cb.Enabled = true;
                    cb.Value = DateTime.Now;


                }













            }



        }

        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {

                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;


                }

                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;



                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;



                }

                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;



                }

                if (c is DateTimePicker)
                {
                    DateTimePicker cb = (DateTimePicker)c;
                    cb.Enabled = true;



                }

                if (c is Button)
                {
                    Button b = (Button)c;
                    b.Enabled = true;

                }
            }

        }


    }
}
