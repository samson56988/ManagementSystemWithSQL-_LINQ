namespace School_Management_System
{
    partial class ClassTiming
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorlabelperiodname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.periodcb = new System.Windows.Forms.ComboBox();
            this.errorlabeltiminglevel = new System.Windows.Forms.Label();
            this.Timinglevelcb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Timingdaycb = new System.Windows.Forms.ComboBox();
            this.Endtimedp = new System.Windows.Forms.DateTimePicker();
            this.Starttimedp = new System.Windows.Forms.DateTimePicker();
            this.errorlabeltimingday = new System.Windows.Forms.Label();
            this.erroelabelshift = new System.Windows.Forms.Label();
            this.timeshiftcb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addbtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SNOGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelnameIDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StarttimeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndtimeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShiftnameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimedayGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.errorlabelperiodname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.periodcb);
            this.panel1.Controls.Add(this.errorlabeltiminglevel);
            this.panel1.Controls.Add(this.Timinglevelcb);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Timingdaycb);
            this.panel1.Controls.Add(this.Endtimedp);
            this.panel1.Controls.Add(this.Starttimedp);
            this.panel1.Controls.Add(this.errorlabeltimingday);
            this.panel1.Controls.Add(this.erroelabelshift);
            this.panel1.Controls.Add(this.timeshiftcb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 609);
            this.panel1.TabIndex = 1;
            // 
            // errorlabelperiodname
            // 
            this.errorlabelperiodname.AutoSize = true;
            this.errorlabelperiodname.Location = new System.Drawing.Point(185, 57);
            this.errorlabelperiodname.Name = "errorlabelperiodname";
            this.errorlabelperiodname.Size = new System.Drawing.Size(16, 16);
            this.errorlabelperiodname.TabIndex = 21;
            this.errorlabelperiodname.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Period Name";
            // 
            // periodcb
            // 
            this.periodcb.FormattingEnabled = true;
            this.periodcb.Location = new System.Drawing.Point(18, 79);
            this.periodcb.Name = "periodcb";
            this.periodcb.Size = new System.Drawing.Size(193, 24);
            this.periodcb.TabIndex = 19;
            this.periodcb.SelectedIndexChanged += new System.EventHandler(this.periodcb_SelectedIndexChanged);
            // 
            // errorlabeltiminglevel
            // 
            this.errorlabeltiminglevel.AutoSize = true;
            this.errorlabeltiminglevel.Location = new System.Drawing.Point(185, 163);
            this.errorlabeltiminglevel.Name = "errorlabeltiminglevel";
            this.errorlabeltiminglevel.Size = new System.Drawing.Size(16, 16);
            this.errorlabeltiminglevel.TabIndex = 18;
            this.errorlabeltiminglevel.Text = "*";
            // 
            // Timinglevelcb
            // 
            this.Timinglevelcb.FormattingEnabled = true;
            this.Timinglevelcb.Location = new System.Drawing.Point(15, 182);
            this.Timinglevelcb.Name = "Timinglevelcb";
            this.Timinglevelcb.Size = new System.Drawing.Size(197, 24);
            this.Timinglevelcb.TabIndex = 17;
            this.Timinglevelcb.SelectedIndexChanged += new System.EventHandler(this.Timinglevelcb_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Timing Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Timing Day";
            // 
            // Timingdaycb
            // 
            this.Timingdaycb.FormattingEnabled = true;
            this.Timingdaycb.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wdnesday",
            "Thursday",
            "Friday"});
            this.Timingdaycb.Location = new System.Drawing.Point(9, 348);
            this.Timingdaycb.Name = "Timingdaycb";
            this.Timingdaycb.Size = new System.Drawing.Size(200, 24);
            this.Timingdaycb.TabIndex = 11;
            this.Timingdaycb.SelectedIndexChanged += new System.EventHandler(this.Timingdaycb_SelectedIndexChanged);
            // 
            // Endtimedp
            // 
            this.Endtimedp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Endtimedp.Location = new System.Drawing.Point(9, 291);
            this.Endtimedp.Name = "Endtimedp";
            this.Endtimedp.Size = new System.Drawing.Size(200, 23);
            this.Endtimedp.TabIndex = 10;
            this.Endtimedp.ValueChanged += new System.EventHandler(this.Endtimedp_ValueChanged);
            // 
            // Starttimedp
            // 
            this.Starttimedp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Starttimedp.Location = new System.Drawing.Point(12, 234);
            this.Starttimedp.Name = "Starttimedp";
            this.Starttimedp.Size = new System.Drawing.Size(200, 23);
            this.Starttimedp.TabIndex = 10;
            this.Starttimedp.ValueChanged += new System.EventHandler(this.Starttimedp_ValueChanged);
            // 
            // errorlabeltimingday
            // 
            this.errorlabeltimingday.AutoSize = true;
            this.errorlabeltimingday.Location = new System.Drawing.Point(182, 329);
            this.errorlabeltimingday.Name = "errorlabeltimingday";
            this.errorlabeltimingday.Size = new System.Drawing.Size(16, 16);
            this.errorlabeltimingday.TabIndex = 9;
            this.errorlabeltimingday.Text = "*";
            // 
            // erroelabelshift
            // 
            this.erroelabelshift.AutoSize = true;
            this.erroelabelshift.Location = new System.Drawing.Point(185, 108);
            this.erroelabelshift.Name = "erroelabelshift";
            this.erroelabelshift.Size = new System.Drawing.Size(16, 16);
            this.erroelabelshift.TabIndex = 9;
            this.erroelabelshift.Text = "*";
            // 
            // timeshiftcb
            // 
            this.timeshiftcb.FormattingEnabled = true;
            this.timeshiftcb.Location = new System.Drawing.Point(15, 127);
            this.timeshiftcb.Name = "timeshiftcb";
            this.timeshiftcb.Size = new System.Drawing.Size(197, 24);
            this.timeshiftcb.TabIndex = 6;
            this.timeshiftcb.SelectedIndexChanged += new System.EventHandler(this.timeshiftcb_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "To Timing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "From Timing ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Timing Shift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(248, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 40);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(222, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 57);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.addbtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editbtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Savebtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.deletebtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(912, 57);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // addbtn
            // 
            this.addbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addbtn.FlatAppearance.BorderSize = 2;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(3, 3);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(176, 51);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editbtn.FlatAppearance.BorderSize = 2;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.Location = new System.Drawing.Point(185, 3);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(176, 51);
            this.editbtn.TabIndex = 0;
            this.editbtn.Text = "Edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Savebtn.FlatAppearance.BorderSize = 2;
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Savebtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(367, 3);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(176, 51);
            this.Savebtn.TabIndex = 0;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletebtn.FlatAppearance.BorderSize = 2;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(549, 3);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(176, 51);
            this.deletebtn.TabIndex = 0;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(731, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "search";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNOGV,
            this.PeriodIDGV,
            this.LevelDGV,
            this.LevelnameIDG,
            this.TimeIDGV,
            this.TimeNameGV,
            this.StarttimeGV,
            this.EndtimeGV,
            this.ShiftIDGV,
            this.ShiftnameGV,
            this.TimedayGV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(222, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(912, 552);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SNOGV
            // 
            this.SNOGV.HeaderText = "SNO";
            this.SNOGV.Name = "SNOGV";
            this.SNOGV.ReadOnly = true;
            // 
            // PeriodIDGV
            // 
            this.PeriodIDGV.HeaderText = "PeriodID";
            this.PeriodIDGV.Name = "PeriodIDGV";
            this.PeriodIDGV.ReadOnly = true;
            this.PeriodIDGV.Visible = false;
            // 
            // LevelDGV
            // 
            this.LevelDGV.HeaderText = "LevelD";
            this.LevelDGV.Name = "LevelDGV";
            this.LevelDGV.ReadOnly = true;
            this.LevelDGV.Visible = false;
            // 
            // LevelnameIDG
            // 
            this.LevelnameIDG.HeaderText = "Level Name";
            this.LevelnameIDG.Name = "LevelnameIDG";
            this.LevelnameIDG.ReadOnly = true;
            // 
            // TimeIDGV
            // 
            this.TimeIDGV.HeaderText = "TimeID";
            this.TimeIDGV.Name = "TimeIDGV";
            this.TimeIDGV.ReadOnly = true;
            this.TimeIDGV.Visible = false;
            // 
            // TimeNameGV
            // 
            this.TimeNameGV.HeaderText = "Time Name";
            this.TimeNameGV.Name = "TimeNameGV";
            this.TimeNameGV.ReadOnly = true;
            // 
            // StarttimeGV
            // 
            this.StarttimeGV.HeaderText = "Start Time";
            this.StarttimeGV.Name = "StarttimeGV";
            this.StarttimeGV.ReadOnly = true;
            // 
            // EndtimeGV
            // 
            this.EndtimeGV.HeaderText = "End Time";
            this.EndtimeGV.Name = "EndtimeGV";
            this.EndtimeGV.ReadOnly = true;
            // 
            // ShiftIDGV
            // 
            this.ShiftIDGV.HeaderText = "ShiftID";
            this.ShiftIDGV.Name = "ShiftIDGV";
            this.ShiftIDGV.ReadOnly = true;
            this.ShiftIDGV.Visible = false;
            // 
            // ShiftnameGV
            // 
            this.ShiftnameGV.HeaderText = "Shift";
            this.ShiftnameGV.Name = "ShiftnameGV";
            this.ShiftnameGV.ReadOnly = true;
            // 
            // TimedayGV
            // 
            this.TimedayGV.HeaderText = "Time Day";
            this.TimedayGV.Name = "TimedayGV";
            this.TimedayGV.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Back";
            // 
            // ClassTiming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1134, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ClassTiming";
            this.Text = "ClassTiming";
            this.Load += new System.EventHandler(this.ClassTiming_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label erroelabelshift;
        private System.Windows.Forms.ComboBox timeshiftcb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Timingdaycb;
        private System.Windows.Forms.DateTimePicker Endtimedp;
        private System.Windows.Forms.DateTimePicker Starttimedp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorlabeltimingday;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label errorlabeltiminglevel;
        private System.Windows.Forms.ComboBox Timinglevelcb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label errorlabelperiodname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox periodcb;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNOGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelnameIDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn StarttimeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndtimeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShiftnameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimedayGV;
        private System.Windows.Forms.Label label7;
    }
}