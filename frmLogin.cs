﻿using System;
using System.Windows.Forms;

namespace AdvancedLoginSystem
{
    public partial class frmLogin : Form
    {
        // Declare Global Variable Value
        public string result;
        public string role;
        public string userName;



        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Establish connection with Database using LINQ to SQL Classes.
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                // spAuthentication() is stored procedure.
                // ref --- returns output values from stored procedure.
                db.spAuthentication(txtEmail.Text, txtPassword.Text, ref result, ref role, ref userName);
                db.SubmitChanges();
                //Popup Message Box
                MessageBox.Show(result.ToString());
                // If User Sucessfully Loged continues.
                if (result == "Logged Successfully!")
                {
                    //Hide current form
                    Hide();
                    //Store User Name temporary
                    AdvancedLoginSystem.Properties.Settings.Default.UserLog = userName;
                    AdvancedLoginSystem.Properties.Settings.Default.Save();
                    //Store Email Id temporary
                    AdvancedLoginSystem.Properties.Settings.Default.Email = txtEmail.Text;
                    AdvancedLoginSystem.Properties.Settings.Default.Save();
                    if (role == "Admin")
                    {
                        //If role is admin popup Administrator Home Form
                        frmAdmin AdminHome = new frmAdmin();
                        AdminHome.Show();
                    }
                    else if (role == "Employee")
                    {
                        //StartPage.Close();
                        //if role is Employee popup Employee Home form
                        this.Close();
                        FrmEmployee empHome = new FrmEmployee();
                        empHome.Show();
                        
                    }
                }
            }
        }

        private void BtnForgotPassword_Click(object sender, EventArgs e)
        {
            frmRecoverPassword recpass = new frmRecoverPassword();
            recpass.Show();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }




    }
}
