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
            string gender_employer = Save_Class.Instance.SC_GENDER_employer;
            bunifuCustomLabel23.Text = gender_employer;
            if (gender_employer == "M")
            {
                bunifuCheckBox1.Checked = true;
                bunifuCheckBox2.Checked = false;
            }
            if (gender_employer == "F")
            {
                bunifuCheckBox2.Checked = true;
                bunifuCheckBox1.Checked = false;
            }
            fill_boxes();
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
            bunifuCustomLabel26.Text =  Save_Class.Instance.SC_id_employer.ToString();
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
            bunifuTextBox27.Text =      situation_fmailial();
            bunifuTextBox28.Text =      Save_Class.Instance.SC_NBR_ENF_employer;
           // bunifuTextBox28.Text =   Save_Class.Instance.SC_SINF__employer;
            //bunifuTextBox28.Text =   Save_Class.Instance.SC_ETAT_CONTR_employer;
            //bunifuTextBox28.Text =      Save_Class.Instance.SC_NBR_ENF_employer;//Save_Class.Instance.SC_CONTRAT_TYPE_employer;
            bunifuCustomLabel27.Text = situation_fmailial();
            bunifuCustomLabel28.Text = Save_Class.Instance.SC_SITUATION_F_employer;

        }
        public string  situation_fmailial ()
        {
            string gndr_empl = Save_Class.Instance.SC_GENDER_employer; 
            string gndr_emp_sitl= "";
            string sitt = Save_Class.Instance.SC_SITUATION_F_employer;
            if (sitt.StartsWith("C"))
            {
                if (gndr_empl == "M")
                {
                    gndr_emp_sitl = "Célibataire";
                }
                if (gndr_empl == "F")
                {
                    gndr_emp_sitl = "Célibatairice";
                }
            }
            if (sitt.StartsWith("M"))
            {
                if (gndr_empl == "M")
                {
                    gndr_emp_sitl = "Marié";
                }
                if (gndr_empl == "F")
                {
                    gndr_emp_sitl = "Mariée";
                }
            }
            return gndr_emp_sitl;

        }
        private void UC_P2_Load(object sender, EventArgs e)
        {
            
        }


        private void BunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked == true)
            {
                bunifuCheckBox2.Checked = false;
                bunifuPictureBox100.Visible = true;
                bunifuPictureBox101.Visible = false;
                //var_employe_gendre = "M";
            }
        }

        private void BunifuCheckBox2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox2.Checked == true)
            {
                bunifuCheckBox1.Checked = false;
                bunifuPictureBox100.Visible = false;
                bunifuPictureBox101.Visible = true;
                //var_employe_gendre = "F";

            }
        }
        private void collectted_data_uc_p2()
        {
            Save_Class.Instance.SC_id_employer = Int32.Parse(bunifuCustomLabel26.Text);
            Save_Class.Instance.SC_NOM_employer = bunifuTextBox1.Text.ToUpper();
            Save_Class.Instance.SC_PNOM_employer = bunifuTextBox2.Text.ToUpper();
            Save_Class.Instance.SC_DATE_N_employer = bunifuTextBox3.Text + "/" + bunifuTextBox4.Text + "/" + bunifuTextBox5.Text;
            Save_Class.Instance.SC_LIEU_N_employer = bunifuTextBox6.Text.ToUpper();
            Save_Class.Instance.SC_DEMEURANT_employer = bunifuTextBox7.Text.ToUpper();
            Save_Class.Instance.SC_ENGAGEMENT_employer = bunifuTextBox8.Text.ToUpper();
            Save_Class.Instance.SC_DUREE_employer = bunifuTextBox9.Text.ToUpper();
            Save_Class.Instance.SC_ENTREE_employer = bunifuTextBox10.Text + "/" + bunifuTextBox11.Text + "/" + bunifuTextBox12.Text;

            Save_Class.Instance.SC_SORTIE_employer = bunifuTextBox13.Text + "/" + bunifuTextBox14.Text + "/" + bunifuTextBox15.Text;
            Save_Class.Instance.SC_CHANTIER_employer = bunifuTextBox16.Text.ToUpper();
            Save_Class.Instance.SC_SALAIRE_employer = bunifuTextBox17.Text;
            Save_Class.Instance.SC_NMR_ASSU_employer = bunifuTextBox21.Text.ToUpper()+ bunifuTextBox25.Text;
            Save_Class.Instance.SC_SITUATION_F_employer = bunifuTextBox27.Text;// Chek_single(bunifuTextBox27.Text);
            Save_Class.Instance.SC_NBR_ENF_employer = bunifuTextBox28.Text.ToUpper();
            Save_Class.Instance.SC_NMR_ADH_employer = "";// bunifuTextBox9.Text.ToUpper();
            Save_Class.Instance.SC_GR_S_employer = bunifuTextBox20.Text;

            Save_Class.Instance.SC_TELEPH_employer = bunifuTextBox18.Text;
            Save_Class.Instance.SC_EMAIL__employer = bunifuTextBox19.Text.ToUpper();
            Save_Class.Instance.SC_SINF__employer = bunifuTextBox17.Text;
            Save_Class.Instance.SC_ETAT_CONTR_employer = bunifuTextBox21.Text.ToUpper();
            Save_Class.Instance.SC_CONTRAT_TYPE_employer = "";//var_type_contrat.ToUpper();
            Save_Class.Instance.SC_DATE_REAL_employer = bunifuTextBox28.Text.ToUpper();
            Save_Class.Instance.SC_IMG_employer = "";// empty_image(var_employe_image_path);
            Save_Class.Instance.SC_GENDER_employer = bunifuCustomLabel27.Text ;//var_employe_gendre;
        }
        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            collectted_data_uc_p2();
            Class3 cls_micro2 = new Class3();
            cls_micro2.save_modification();
            bunifuCustomLabel23.Text = "saved";
        }
        static string Chek_single(string situationf)
        {
            string st = null;
            string fucccc = situationf.ToUpper();
            if (fucccc.StartsWith("M"))
            {
                st = "M";
            }
            else
            {
                st = "S";
            }

            return st;
        }

    }
}
