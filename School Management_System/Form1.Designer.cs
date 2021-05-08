namespace School_Management_System
{
    partial class Setting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_datasource = new System.Windows.Forms.TextBox();
            this.txt_database = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ISCB = new System.Windows.Forms.CheckBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.errorlabledatasource = new System.Windows.Forms.Label();
            this.errorlabeldatabase = new System.Windows.Forms.Label();
            this.errorlabelpassword = new System.Windows.Forms.Label();
            this.errorlabelusername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.ISCB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.errorlabelusername);
            this.panel1.Controls.Add(this.errorlabelpassword);
            this.panel1.Controls.Add(this.errorlabeldatabase);
            this.panel1.Controls.Add(this.errorlabledatasource);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.txt_password);
            this.panel1.Controls.Add(this.txt_database);
            this.panel1.Controls.Add(this.txt_datasource);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 749);
            this.panel1.TabIndex = 0;
            // 
            // txt_datasource
            // 
            this.txt_datasource.Location = new System.Drawing.Point(12, 196);
            this.txt_datasource.Name = "txt_datasource";
            this.txt_datasource.Size = new System.Drawing.Size(212, 26);
            this.txt_datasource.TabIndex = 0;
            this.txt_datasource.TextChanged += new System.EventHandler(this.txt_datasource_TextChanged);
            // 
            // txt_database
            // 
            this.txt_database.Location = new System.Drawing.Point(12, 246);
            this.txt_database.Name = "txt_database";
            this.txt_database.Size = new System.Drawing.Size(212, 26);
            this.txt_database.TabIndex = 0;
            this.txt_database.TextChanged += new System.EventHandler(this.txt_database_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(12, 349);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(212, 26);
            this.txt_password.TabIndex = 0;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(12, 293);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(212, 26);
            this.txt_username.TabIndex = 0;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datasourse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password";
            // 
            // ISCB
            // 
            this.ISCB.AutoSize = true;
            this.ISCB.Location = new System.Drawing.Point(15, 382);
            this.ISCB.Name = "ISCB";
            this.ISCB.Size = new System.Drawing.Size(154, 22);
            this.ISCB.TabIndex = 2;
            this.ISCB.Text = "Integreted Secuirity";
            this.ISCB.UseVisualStyleBackColor = true;
            this.ISCB.CheckedChanged += new System.EventHandler(this.ISCB_CheckedChanged);
            // 
            // btnsave
            // 
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Location = new System.Drawing.Point(72, 419);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(97, 38);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorlabledatasource
            // 
            this.errorlabledatasource.AutoSize = true;
            this.errorlabledatasource.Location = new System.Drawing.Point(208, 175);
            this.errorlabledatasource.Name = "errorlabledatasource";
            this.errorlabledatasource.Size = new System.Drawing.Size(16, 18);
            this.errorlabledatasource.TabIndex = 1;
            this.errorlabledatasource.Text = "*";
            // 
            // errorlabeldatabase
            // 
            this.errorlabeldatabase.AutoSize = true;
            this.errorlabeldatabase.Location = new System.Drawing.Point(208, 225);
            this.errorlabeldatabase.Name = "errorlabeldatabase";
            this.errorlabeldatabase.Size = new System.Drawing.Size(16, 18);
            this.errorlabeldatabase.TabIndex = 1;
            this.errorlabeldatabase.Text = "*";
            // 
            // errorlabelpassword
            // 
            this.errorlabelpassword.AutoSize = true;
            this.errorlabelpassword.Location = new System.Drawing.Point(208, 328);
            this.errorlabelpassword.Name = "errorlabelpassword";
            this.errorlabelpassword.Size = new System.Drawing.Size(16, 18);
            this.errorlabelpassword.TabIndex = 1;
            this.errorlabelpassword.Text = "*";
            // 
            // errorlabelusername
            // 
            this.errorlabelusername.AutoSize = true;
            this.errorlabelusername.Location = new System.Drawing.Point(208, 275);
            this.errorlabelusername.Name = "errorlabelusername";
            this.errorlabelusername.Size = new System.Drawing.Size(16, 18);
            this.errorlabelusername.TabIndex = 1;
            this.errorlabelusername.Text = "*";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.CheckBox ISCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.TextBox txt_datasource;
        private System.Windows.Forms.Label errorlabelusername;
        private System.Windows.Forms.Label errorlabelpassword;
        private System.Windows.Forms.Label errorlabeldatabase;
        private System.Windows.Forms.Label errorlabledatasource;
    }
}

