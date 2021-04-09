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
    public partial class UC_P2 : UserControl
    {
        public UC_P2()
        {
            InitializeComponent();
        }
        private void fill_boxes()
        {
            String nais_arr     =       Save_Class.Instance.SC_DATE_N_employer.Split('@').Last();
            String enga_arr     =       Save_Class.Instance.SC_ENGAGEMENT_employer.Split('@').Last();
            String du_arr       =       Save_Class.Instance.SC_DUREE_employer.Split('@').Last();
            String entr_arr     =       Save_Class.Instance.SC_ENTREE_employer.Split('@').Last();
            String sort_arr     =        Save_Class.Instance.SC_SORTIE_employer.Split('@').Last();
            String chantier_arr =       Save_Class.Instance.SC_CHANTIER_employer.Split('@').Last();
            String salaire_arr =        Save_Class.Instance.SC_SALAIRE_employer.Split('@').Last();

            bunifuTextBox1.Text =       Save_Class.Instance.SC_NOM_employer;
            bunifuTextBox2.Text =        Save_Class.Instance.SC_PNOM_employer;
            bunifuTextBox3.Text =       nais_arr.Split('/').First();
            bunifuTextBox4.Text =       nais_arr.Split('/')[1];
            bunifuTextBox5.Text =       nais_arr.Split('/').Last();
            //bunifuTextBox6.Text       
            bunifuTextBox6.Text =        Save_Class.Instance.SC_LIEU_N_employer;
            bunifuTextBox7.Text =        Save_Class.Instance.SC_DEMEURANT_employer;
            bunifuTextBox8.Text =        enga_arr;
            bunifuTextBox9.Text  =       du_arr;
            bunifuTextBox10.Text =       entr_arr.Split('/').First();
            bunifuTextBox11.Text =       entr_arr.Split('/')[1]; 
            bunifuTextBox12.Text =       entr_arr.Split('/').Last(); 
            bunifuTextBox13.Text =       sort_arr.Split('/').First();
            bunifuTextBox14.Text =       sort_arr.Split('/')[1];
            bunifuTextBox15.Text =       sort_arr.Split('/').Last();
            bunifuTextBox16.Text =       chantier_arr;
            bunifuTextBox17.Text =       salaire_arr;
            //bunifuTextBox16.Text    Save_Class.Instance.SC_NMR_ASSU_employer;
            bunifuTextBox18.Text =      Save_Class.Instance.SC_TELEPH_employer;//
            bunifuTextBox19.Text =      Save_Class.Instance.SC_EMAIL__employer;
            bunifuTextBox20.Text =       Save_Class.Instance.SC_GR_S_employer;//Save_Class.Instance.SC_NMR_ADH_employer;
            bunifuTextBox21.Text =      Save_Class.Instance.SC_NMR_ASSU_employer.Substring(0,10) ;
            bunifuTextBox25.Text =      Save_Class.Instance.SC_NMR_ASSU_employer.Substring(Save_Class.Instance.SC_NMR_ASSU_employer.Length - 2);
            bunifuTextBox27.Text =      Save_Class.Instance.SC_SITUATION_F_employer;
            bunifuTextBox28.Text =      Save_Class.Instance.SC_EMAIL__employer;
           // bunifuTextBox28.Text =   Save_Class.Instance.SC_SINF__employer;
            //bunifuTextBox28.Text =   Save_Class.Instance.SC_ETAT_CONTR_employer;
            bunifuTextBox28.Text =      Save_Class.Instance.SC_NBR_ENF_employer;//Save_Class.Instance.SC_CONTRAT_TYPE_employer;
        }
        private void UC_P2_Load(object sender, EventArgs e)
        {
            fill_boxes();
        }

        private void BunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
