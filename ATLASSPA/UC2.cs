using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class UC2 : UserControl
    {
        public UC2()
        {
            InitializeComponent();
            //
        }

        

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            bunifuTransition11.HideSync(Add_Employer.Instance.PnlContainer);

            if (!Add_Employer.Instance.PnlContainer.Controls.ContainsKey("UC1"))
            {

                UC1 un1 = new UC1();
                un1.Dock = DockStyle.Fill;
                Add_Employer.Instance.PnlContainer.Controls.Clear();
                // Add_Employer.Instance.PnlContainer.Visible = false;

                Add_Employer.Instance.PnlContainer.Controls.Add(un1);
                bunifuTransition11.ShowSync(Add_Employer.Instance.PnlContainer);
            }
        }

        private void UC2_Load(object sender, EventArgs e)
        {
            //webBrowser1.DocumentText = "<HTML>HELLOW <script>alert('hi');</script></HTML>";
            //webBrowser1.Document.Write("<HTML>HELLOW <script>alert('hi');</script></HTML>");
            //bunifuLabel1.Text = Save_Class.Instance.SC_NOM_employer;
            //bunifuLabel2.Text = Save_Class.Instance.SC_PNOM_employer;
            //bunifuLabel3.Text = Save_Class.Instance.SC_DATE_N_employer;
            //bunifuLabel1.Text = Save_Class.Instance.SC_NOM_employer;
            //bunifuLabel1.Text = Save_Class.Instance.SC_NOM_employer;
            //Update_Class cur_emply_obj = new Update_Class();
            //bunifuLabel1.Text = Update_Class. ;
            bunifuLabel1.Text = Save_Class.Instance.SC_NOM_employer;
            bunifuLabel2.Text = Save_Class.Instance.SC_PNOM_employer;
            bunifuLabel3.Text = Save_Class.Instance.SC_DATE_N_employer;
            bunifuLabel4.Text = Save_Class.Instance.SC_LIEU_N_employer;
            bunifuLabel5.Text = Save_Class.Instance.SC_DEMEURANT_employer;
            bunifuLabel6.Text = Save_Class.Instance.SC_ENGAGEMENT_employer;
            bunifuLabel7.Text = Save_Class.Instance.SC_DUREE_employer;
            bunifuLabel8.Text = Save_Class.Instance.SC_ENTREE_employer;

            bunifuLabel9.Text = Save_Class.Instance.SC_SORTIE_employer;
            bunifuLabel10.Text = Save_Class.Instance.SC_CHANTIER_employer;
            bunifuLabel11.Text = Save_Class.Instance.SC_SALAIRE_employer;
            bunifuLabel12.Text = Save_Class.Instance.SC_NMR_ASSU_employer;
            bunifuLabel13.Text = Save_Class.Instance.SC_SITUATION_F_employer;
            bunifuLabel14.Text = Save_Class.Instance.SC_NBR_ENF_employer;
            bunifuLabel15.Text = Save_Class.Instance.SC_NMR_ADH_employer;
            bunifuLabel16.Text = Save_Class.Instance.SC_GR_S_employer;


            bunifuLabel17.Text = Save_Class.Instance.SC_TELEPH_employer;
            bunifuLabel18.Text = Save_Class.Instance.SC_EMAIL__employer;
            bunifuLabel19.Text = Save_Class.Instance.SC_SINF__employer;
            bunifuLabel20.Text = Save_Class.Instance.SC_ETAT_CONTR_employer;
            bunifuLabel21.Text = Save_Class.Instance.SC_CONTRAT_TYPE_employer;
            bunifuLabel22.Text = Save_Class.Instance.SC_DATE_REAL_employer;
            bunifuLabel23.Text = Save_Class.Instance.SC_IMG_employer;
            bunifuLabel24.Text = Save_Class.Instance.SC_GENDER_employer;
            //bunifuLabel3.Text =
            timer1.Enabled = true;




        }

        /*
         *       Pnlrptvw.Visible = true;
            UC_REPORT uc_reportviewer = new UC_REPORT();
            Pnlrptvw.Controls.Clear();
            uc_reportviewer.Dock = DockStyle.Fill;
            Pnlrptvw.Controls.Add(uc_reportviewer);
            //bunifuTransition13.Show(Pnlrptvw);
         */
        private void BunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            UC_REPORT uc_reportviewer = new UC_REPORT();
            timer1.Enabled = false;
            Pnlrptvw.Controls.Clear();
            Pnlrptvw.Visible = true;
            uc_reportviewer.Dock = DockStyle.Fill;
            Pnlrptvw.Controls.Add(uc_reportviewer);
            
        }
    }
}
