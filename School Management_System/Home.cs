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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FeeVoucher hs = new FeeVoucher();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Level hs = new Level();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Role hs = new Role();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sections hs = new Sections();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Subjects hs = new Subjects();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            House hs = new House();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Shift hs = new Shift();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes hs = new Classes();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Stafff hs = new Stafff();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            label2.Text = Mainclass.STAFFNAME;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Period hs = new Period();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Assignment hs = new Assignment();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Timetable hs = new Timetable();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Admission hs = new Admission();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Fee_Structure hs = new Fee_Structure();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            FeeMethod hs = new FeeMethod();
            Mainclass.showWindow(hs, this, Mdi.ActiveForm);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

