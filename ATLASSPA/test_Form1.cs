using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class test_Form1 : Form
    {
        public test_Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var form_search_Employer = new frm_SEARCH();
            form_search_Employer.Closed += (s, args) => this.Close();
            this.Hide();
            form_search_Employer.Show();
            //ooooo
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Test_Form1_Load(object sender, EventArgs e)
        {
            bunifuLabel1.Text = Save_Class.Instance.SC_id_employer.ToString();
        }

        private void MaterialToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void AToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EDITToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
