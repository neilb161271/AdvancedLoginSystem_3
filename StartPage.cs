using System;
using System.Windows.Forms;

namespace AdvancedLoginSystem
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }


        private void StartBtn_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void Main_Timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh:mm");
            lbl_sec.Text = DateTime.Now.ToString("ss");
            lbl_day.Text = DateTime.Now.ToString("dddd");
            lbl_date.Text = DateTime.Now.ToString("MMM dd yyyy");
        }


    }
}
