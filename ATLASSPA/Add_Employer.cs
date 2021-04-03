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
    public partial class Add_Employer : Form
    {
        static Add_Employer _obj;
        public static Add_Employer Instance
        {
            get
            {
                if (_obj==null)
                {
                    _obj = new Add_Employer();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }
        public Panel pnlNOTIFICATOIN
        {
            get { return pnlNOT; }
            set { pnlNOT = value; }
        }

        public Add_Employer()
        {
            InitializeComponent();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //bunifuTransition1.HideSync(uC11);
            //panel3.Controls.Clear();
            this.Hide();
            var form1 = new Home_Page();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }


        /*public void  showpanel(Control control)
        {
            //Content.Controls.clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            //conttent.Controls.add(control)
        }*/

        /*private void BunifuButton1_Click(object sender, EventArgs e)
        {
            //UC1 UN = new UC1();
            UC1 un = new UC1();
            un.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(un);
            bunifuTransition1.Show(PnlContainer);
        }*/

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            UC1 un = new UC1();
            un.Dock = DockStyle.Fill;
            //Add_Employer.Ins


            /*
           
            UN.Visible = true;
            UN.BringToFront();*/

            PnlContainer.Controls.Add(un);
            bunifuTransition1.HideSync(PnlContainer);
        }


        private void Add_Employer_Load(object sender, EventArgs e)
        {
            //uC11.Visible = false;
            _obj = this;
            PnlContainer.Controls.Clear();
            UC1 un = new UC1();
            un.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(un);
            timer1.Enabled = true;
           

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            bunifuTransition1.Show(PnlContainer);
            //bunifuTransition1.ShowSync(panel3);
            bunifuTransition1.WaitAllAnimations();

            timer1.Enabled = false;

        }


    }
}
