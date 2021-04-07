using System;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class T2 : Form
    {
        static T2 _obj;
        public static T2 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new T2();
                }
                return _obj;
            }
        }

        public Panel PnlContainer_employee
        {
            get { return panelContainer_employee; }
            set { panelContainer_employee = value; }
        }
        /* public Panel pnlNOTIFICATOIN_employee
         {
             get { return pnlNOT_employee; }
             set { pnlNOT_employee = value; }
         }*/
        public T2()
        {
            InitializeComponent();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            var form_search_Employer = new frm_SEARCH();
            form_search_Employer.Closed += (s, args) => this.Close();
            this.Hide();
            form_search_Employer.Show();

        }

        private void T2_Load(object sender, EventArgs e)
        {
            _obj = this;
            PnlContainer_employee.Controls.Clear();
            UC_P1 un = new UC_P1();
            un.Dock = DockStyle.Fill;
            PnlContainer_employee.Controls.Add(un);
            timer100.Enabled = true;
        }

        private void Timer100_Tick(object sender, EventArgs e)
        {
            bunifuTransition100.Show(PnlContainer_employee);
            //bunifuTransition1.ShowSync(panel3);
            bunifuTransition100.WaitAllAnimations();

            timer100.Enabled = false;

        }
    }
}
