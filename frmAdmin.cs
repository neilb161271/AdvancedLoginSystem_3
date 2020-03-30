using System;
using System.Windows.Forms;

namespace AdvancedLoginSystem
{
    public partial class frmAdmin : Form
    {
        public string UserName;
        public string FirstName;

        public frmAdmin()
        {
            InitializeComponent();
            label1.Text = UserName;
            UserNameLbl.Text = FirstName;
        }

        public void AdminHome_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome : " + AdvancedLoginSystem.Properties.Settings.Default.UserLog;
            UserNameLbl.Text = "Welcome : " + AdvancedLoginSystem.Properties.Settings.Default.FirstName;

        }

        private void UserRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration reg = new frmRegistration();
            reg.Show();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword chgpas = new frmChangePassword();
            chgpas.Show();
        }

        private void UserManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageUsers mngusr = new frmManageUsers();
            mngusr.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin lgn = new frmLogin();
            this.Hide();
            lgn.Show();
        }

        //open up form to add a customer 
        //to the database
        private void AddCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCust add_Customer = new AddCust();
            add_Customer.Show();
        }

        //show admin settings page
        private void AdminSettBtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void Label1_Load(object sender, EventArgs e)
        {
           // label1.Text = "Welcome : " + AdvancedLoginSystem.Properties.Settings.Default.UserName;

        }

        private void UserNameLbl_Load(object sender, EventArgs e)
        {

        }
    }
}
