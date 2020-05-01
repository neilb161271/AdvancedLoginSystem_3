using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace AdvancedLoginSystem
{
    public partial class CustomerCarDetails : Form
    {
        public object comboBox1SelectedItem { get; set; }

        public CustomerCarDetails()
        {
            InitializeComponent();
        }
        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code, 
            // you can retrieve it from a configuration file.
            return "Data Source=DESKTOP-KC4KLEJ;Initial Catalog=DBLoginSystem;Integrated Security = Tru" +
            "e";
        }

        private void CustomerCarDetails_Load(object sender, EventArgs e)
        {
            //Load combobox from database using LINQ TO SQL CLASSES

        }

        private void CustomerCarDetails_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBLoginSystemDataSet3.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dBLoginSystemDataSet3.customers);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //save button to save the customers car details
        private void SaveCuCarBtn_Click(object sender, EventArgs e)
        {
            string message = "Name: " + comboBox1.Text;
            message += Environment.NewLine;
            message += "CustomerId: " + comboBox1.SelectedValue;
            MessageBox.Show(message);
            ///////////////////////////////////////
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SpAddCustCarPro", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@vehicle_reg ", CustRegTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_vin_no", CustVinNoTxt.Text);
                    cmd.Parameters.AddWithValue("@vehicle_make", CustCarMakeTxt);
                    cmd.Parameters.AddWithValue("@year_of_make", CustYearTxt);
                    cmd.Parameters.AddWithValue("@vehicle_colour", CustColourTxt);
                    cmd.Parameters.AddWithValue("@colour_code", CustCarColourCodeTxt);
                    cmd.Parameters.AddWithValue("@cust_veh_notes", CustCarRichTex);
                    cmd.Parameters.AddWithValue("@cust_mot_date_due", CustCarMotTxt);

                    //connection.Open();
                    int i = cmd.ExecuteNonQuery();
                    connection.Close();

                    if (i != 0)
                    {
                        MessageBox.Show(i + "Data Saved");
                    }
                }
                catch (Exception ex)
                {
                    // Returns if any error 
                    MessageBox.Show(ex.Message);
                }
            }


        }
    

 

    


        //delete all the infomation from the form
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult myResult;
            myResult = MessageBox.Show("Do you really want to delete all the text?", "Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                // confirm delete
                CustRegTxt.Clear();
                CustVinNoTxt.Clear();
                CustCarMakeTxt.Clear();
                CustModelTxt.Clear();
                CustYearTxt.Clear();
                CustColourTxt.Clear();
                CustCarColourCodeTxt.Clear();
                CustCarMotTxt.Clear();
                CustCarRichTex.Clear();
            }
            else
            {
                //No delete
            }
        }


           
        
        //close the form and return 
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult CloseResult;
            CloseResult = MessageBox.Show("Do you really want to close the form?", "Close Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (CloseResult == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
               
            }
        }


        private void SaveToFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveCusCarFileDialog = new SaveFileDialog();
            SaveCusCarFileDialog.InitialDirectory = @"C:\";
            SaveCusCarFileDialog.Title = "Save text Files";
            SaveCusCarFileDialog.CheckFileExists = true;
            SaveCusCarFileDialog.CheckPathExists = true;
            SaveCusCarFileDialog.DefaultExt = "txt";
            SaveCusCarFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveCusCarFileDialog.FilterIndex = 2;
            SaveCusCarFileDialog.RestoreDirectory = true;
            if (SaveCusCarFileDialog.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = saveFileDialog1.FileName;
            }


        }
    }
}

