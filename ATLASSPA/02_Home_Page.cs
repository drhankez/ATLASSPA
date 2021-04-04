using System;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class Home_Page : Form
    {

        public Home_Page()
        {
            InitializeComponent();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                //filePath;
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            var form_Add_Employer = new Add_Employer();
            form_Add_Employer.Closed += (s, args) => this.Close();
            this.Hide();
            form_Add_Employer.Show();

        }

        private void Home_Page_Load(object sender, EventArgs e)
        {
            bunifuButton1.Select();
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            var form_search_Employer = new frm_SEARCH();
            form_search_Employer.Closed += (s, args) => this.Close();
            this.Hide();
            form_search_Employer.Show();
        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            var form_search_Employer = new Form1();
            form_search_Employer.Closed += (s, args) => this.Close();
            this.Hide();
            form_search_Employer.Show();
        }
    }
}
