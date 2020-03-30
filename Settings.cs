using System;
using System.Windows.Forms;

namespace AdvancedLoginSystem
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        //show create pin form for admin
      
        //close the form
        private void CloseBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
