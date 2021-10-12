﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeaveManagementSystem1._1.Properties;

namespace LeaveManagementSystem1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showFrm(Form frm)
        { 
            frm.ShowDialog();
        }

        public void enabled_menu()
        {
            tsEmployee.Enabled = true;
            tsFind.Enabled = true;
            tsLeave.Enabled = true;
            tsMaintenance.Enabled = true;
            tsUser.Enabled = true;
            tsLogin.Text = "Logout";
            tsLogin.Image = Properties.Resources.logout;

        }
        public void disabled_menu()
        {
            tsEmployee.Enabled = false;
            tsFind.Enabled = false;
            tsLeave.Enabled = false;
            tsMaintenance.Enabled = false;
            tsUser.Enabled = false;
            tsLogin.Text = "Login";
            tsLogin.Image = Properties.Resources.login;

        }

<<<<<<< HEAD
        
=======
<<<<<<< HEAD
        
=======
       
>>>>>>> main
>>>>>>> main

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            disabled_menu();
        }

        private void tsEmployee_Click(object sender, EventArgs e)
        {
            showFrm(new frmEmployee("","Add New Employee"));
        }

        private void tsMaintenance_Click(object sender, EventArgs e)
        {
            showFrm(new frmMaintenance());
        }

        private void tsFind_Click(object sender, EventArgs e)
        {
            showFrm(new frmListofEmployee());
        }

        private void tsLeave_Click(object sender, EventArgs e)
        {
            showFrm(new frmApplyLeave());
        }

        private void tsUser_Click(object sender, EventArgs e)
        {
            showFrm(new frmUser());
        }

       

        private void tsLogin_Click(object sender, EventArgs e)
        {
            if (tsLogin.Text == "Login")
            {
                showFrm(new frmLogin(this));
            }
            else
            {
                disabled_menu();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
