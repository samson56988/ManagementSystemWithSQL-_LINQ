using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Mdi : Form
    {
        public Mdi()
        {
            InitializeComponent();
        }
        
        
        Mainclass main = new Mainclass();

        private void Mdi_Load(object sender, EventArgs e)
        {
            if (File.Exists(main.path + "\\connect"))
            {
                Login obj = new Login();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();

            }

            else
            {

                Setting obj = new Setting();
                obj.MdiParent = this;
                obj.WindowState = FormWindowState.Maximized;
                obj.Show();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login hs = new Login();
            hs.MdiParent = this;
            hs.Show();
        }
    }
}
