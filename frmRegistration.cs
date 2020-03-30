using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;


namespace AdvancedLoginSystem
{
    public partial class frmRegistration : Form
    {

        // Declare Result variable as string
        public string result;
      

        public frmRegistration()
        {
            InitializeComponent();
        }


        private void BtnRegistration_Click(object sender, EventArgs e)
        {

            //Insert Registration details in database
            //Validating Input values
            Regex rEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!rEmail.IsMatch(txtEmail.Text.Trim()) ||
                txtUserName.Text.Trim() == "" ||
                txtPassword.Text.Trim() == "" ||
                cobRole.SelectedValue.ToString() == "" ||
                cobQuestion.Text.Trim() == "" ||
                txtAnswer.Text.Trim() == "" ||
                TextPinIn.Text.Trim() == ""  ||
                TxtFirstName.Text.Trim() == "" ||
                TxtLastName.Text.Trim() == "" )
            {
                MessageBox.Show("Fill all the information or Check Email address");
            }
           
                
                
            else
            {
                // accessing spRegister stored procedure and return result
                try
                {
                    using (DataClassesDataContext db = new DataClassesDataContext())
                    {
                        NewMethod(db);
                        db.SubmitChanges();
                    }
                    // Result shown in Meassage Box
                    MessageBox.Show(result, "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign);
                    Close();
                }
                catch (Exception ex)
                {
                    // Returns if any error 
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void NewMethod(DataClassesDataContext db)
        {
                
            db.spRegister1(txtUserName.Text, txtPassword.Text, txtEmail.Text, Convert.ToInt32(cobRole.SelectedValue.ToString()), cobQuestion.Text, txtAnswer.Text, TextPinIn.Text, TxtFirstName.Text, TxtLastName.Text, ref result);
            //db.spRegister(txtUserName.Text, txtPassword.Text, txtEmail.Text, Convert.ToInt32(cobRole.SelectedValue.ToString()), cobQuestion.Text, txtAnswer.Text, ref result);

        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //Load combobox from database using LINQ TO SQL CLASSES
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                cobRole.Items.Clear();
                cobRole.DataSource = db.Roles.ToList();
                cobRole.DisplayMember = "RoleName";
                cobRole.ValueMember = "RoleId";
                cobRole.SelectedValue = "";
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            //if (e.Keycode == Keys.CapsLock)
            //{
            //    MessageBox.Show("caps lock is down");
            //}
        }
    }
}
