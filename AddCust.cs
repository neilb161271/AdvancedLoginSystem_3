using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdvancedLoginSystem
{

    public partial class AddCust : Form
    {
        public string result;

        public AddCust()
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

        private void ClrBtn_Click(object sender, EventArgs e)
        {
            CstFNameTxt.Clear();
            CstLNameTxt.Clear();
            BuisTxt.Clear();
            CstLLineTxt.Clear();
            CstMobTxt.Clear();
            FLineTxt.Clear();
            SecLineTxt.Clear();
            CityTxt.Clear();
            CountyTxt.Clear();
            PoCdTxt.Clear();
            CstEmailTxt.Clear();
            CusInvTxt.Clear();
        }

        private void SearchU_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddCust_Load(object sender, EventArgs e)
        {    //Load combobox from database using LINQ TO SQL CLASSES
            using (DataClassesDataContext db = new DataClassesDataContext())
            {
                SearchU_Name.Items.Clear();
                SearchU_Name.DataSource = db.Users.ToList();
                SearchU_Name.DisplayMember = "UserName";
                SearchU_Name.ValueMember = "UserName";
                SearchU_Name.SelectedValue = "";
            }

        }
      

        private void CstAddBtn_Click(object sender, EventArgs e)
        {

            //Insert Customer Registration details into customer database
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection())
            {
                try
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("spAddCust", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@cust_firstname", CstFNameTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_lastname", CstLNameTxt.Text);
                    cmd.Parameters.AddWithValue("@buiss_name", BuisTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_landline", CstLLineTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_mobile", CstMobTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_fir_line_add", FLineTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_sec_line_add", SecLineTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_city", CityTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_county", CountyTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_postcode", PoCdTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_email", CstEmailTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_invoice_id", CusInvTxt.Text);
                    cmd.Parameters.AddWithValue("@cust_add_notes", CstNtsRichTxt.Text);
                   


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

        private void ClrNtsBtn_Click(object sender, EventArgs e)
        {
            CstNtsRichTxt.Clear();
        }
    }
}
