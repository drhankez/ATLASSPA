using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class UC1 : System.Windows.Forms.UserControl
    {
        public UC1()
        {
            InitializeComponent();
        }
        //private parentinstance;
        public static String[] nnam = { "ADEL", "YACINE", "AHMED", "OZAN", "FAYCEL", "SAMI", "ZOBIR", "AYMEN", "RAMI", "MORAT", "REDVAN", "BURAK", "REDHA", "KOLIBALI" };
        public static String[] ppnam = { "HASNAOUI", "CHAYBI", "ZARKAN", "AIT AOUDIA", "SAHRAOUI", "BENABDALLAG", "BOUALEGGE", "BOUGDIRI", "TALBI", "FARHATI", "SALEM", "SEBIA", "AYMEN", "MOZAKA" };
        public static String[] eengag = { "JOB1", "ARCHI", "CHAUFEAUR", "FEMME DE MENAGE", "FERRALLIEUR", "CHAUFFEUR", "MAçON", "MANOEUVRE", "CHEF DE PROJET", "INGINIEUR EN GENIE CIVIL" };
        public static String[] ddureee = { "QUANZE JOUR", "01 Mois", "09 Mois", "06 Mois", "02 Mois", "05 Mois", "07 Mois" };
        public static String[] situ_arr = { "Célibataire", "Mariée" };
        //public static String[] nnam = { "ADEL", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        public string var_type_contrat = "sc";
        public string var_employe_gendre = "M";
        public string var_employe_singel = "S";
        public string var_employe_image_path = "no_image";


        private void UC1_Load(object sender, EventArgs e)
        {
            //bunifuTransition1.ShowSync(label1);
            LoadCountries();
            Loadjobs();
            Loadchantier();
            Loadsalaire();
            Loadmois();
            Loadstuation();
            bunifuCustomLabel21.Text = "no_image";
            //Save_Class.Instance.SC_CONTRAT_TYPE_employer = "sc";




        }

        private void BunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked == true)
            {
                bunifuCheckBox2.Checked = false;
                bunifuPictureBox100.Visible = true;
                bunifuPictureBox101.Visible = false;
                var_employe_gendre = "M";
            }

        }

        private void BunifuCheckBox2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox2.Checked == true)
            {
                bunifuCheckBox1.Checked = false;
                bunifuPictureBox100.Visible = false;
                bunifuPictureBox101.Visible = true;
                var_employe_gendre = "F";

            }
        }





        private void BunifuTextBox3_TextChange(object sender, EventArgs e)
        {
            if (bunifuTextBox3.Text.Length == 2) { bunifuTextBox4.Focus(); }
        }

        private void BunifuTextBox4_TextChange(object sender, EventArgs e)
        {
            if (bunifuTextBox4.Text.Length == 2) { bunifuTextBox5.Focus(); }
        }

        private void BunifuTextBox5_TextChange(object sender, EventArgs e)
        {
            if (bunifuTextBox5.Text.Length == 4) { bunifuTextBox6.Focus(); }
        }

        private void BunifuTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox1.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox1.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox2.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox2.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuTextBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox6.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox6.BorderColorIdle = Color.Red;
                }

            }
        }
        private void BunifuTextBox7_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox7.Text.Length > 0)
                {
                    //this.SelectNextControl((Control)sender, true, true, true, true);
                    bunifuTextBox8.Focus();
                }
                else
                {
                    bunifuTextBox7.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuTextBox8_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox8.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox8.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuTextBox9_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox9.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox9.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuTextBox10_TextChange(object sender, EventArgs e)
        {
            {
                if (bunifuTextBox10.Text.Length == 2) { bunifuTextBox11.Focus(); }
            }
        }

        private void BunifuTextBox11_TextChange(object sender, EventArgs e)
        {
            {
                if (bunifuTextBox11.Text.Length == 2) { bunifuTextBox12.Focus(); }
            }
        }

        private void BunifuTextBox13_TextChange(object sender, EventArgs e)
        {
            {
                if (bunifuTextBox13.Text.Length == 2) { bunifuTextBox14.Focus(); }
            }
        }

        private void BunifuTextBox14_TextChange(object sender, EventArgs e)
        {
            {
                if (bunifuTextBox14.Text.Length == 2) { bunifuTextBox15.Focus(); }
            }
        }

        private void BunifuTextBox12_TextChange(object sender, EventArgs e)
        {
            {
                if (bunifuTextBox12.Text.Length == 4) { bunifuTextBox13.Focus(); }
            }
        }

        private void BunifuTextBox15_TextChange(object sender, EventArgs e)
        {
            {
                if (bunifuTextBox15.Text.Length == 4) { bunifuTextBox16.Focus(); }
            }
        }

        private void BunifuTextBox16_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox16.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox16.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    picimage1.Image = Image.FromFile(dialog.FileName);
                    bunifuCustomLabel21.Text = dialog.FileName;
                    var_employe_image_path = dialog.FileName;
                }
                dialog.Dispose();


            }
            catch (Exception)
            {


            }
        }

        private void BunifuTextBox17_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox17.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox17.BorderColorIdle = Color.Red;
                }

            }
        }



        private void BunifuTextBox20_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox20.Text.Length > 0)
                {
                    bunifuTextBox21.Focus();
                }
                else
                {
                    bunifuTextBox20.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuTextBox19_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox18.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox18.BorderColorIdle = Color.Red;
                }

            }
        }


        private void check_toggle()
        {
            if (bunifuToggleSwitch1.Value == true)
            {
                bunifuTransition10.Hide(bunifuCustomLabel12);
                bunifuTransition10.Show(bunifuCustomLabel22);
                bunifuTransition10.Show(bunifuTextBox180);
                bunifuTransition10.Show(bunifuCustomLabel13);
                bunifuTransition10.Show(bunifuTextBox190);
                bunifuTransition10.Show(bunifuTextBox200);
                bunifuTransition10.Show(bunifuTextBox210);
                bunifuTransition10.WaitAllAnimations();
                bunifuTextBox180.Select();
                bunifuTextBox180.Focus();
                var_type_contrat = "vc";
            }
            else
            {
                bunifuTransition10.Hide(bunifuCustomLabel22);
                bunifuTransition10.Show(bunifuCustomLabel12);
                bunifuCustomLabel13.Visible = false;
                bunifuTextBox180.Visible = false;
                bunifuTextBox190.Visible = false;
                bunifuTextBox200.Visible = false;
                bunifuTextBox210.Visible = false;
            }
        }

        private void BunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            check_toggle();

        }

        private void BunifuTextBox21_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox21.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox21.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuTextBox25_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox25.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox25.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuTextBox27_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox27.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox27.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuTextBox28_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                if (bunifuTextBox28.Text.Length > 0)
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
                else
                {
                    bunifuTextBox28.BorderColorIdle = Color.Red;
                }

            }
        }

        private void BunifuToggleSwitch1_Validated(object sender, EventArgs e)
        {

        }
        public void LoadCountries()
        //public void LoadCountries(string jname)
        {
            AutoCompleteStringCollection Countries = new AutoCompleteStringCollection();
            JArray ja = JArray.Parse(System.IO.File.ReadAllText("JSON_F\\" + "countries.json"));
            foreach (JObject Country in ja)
            {
                Countries.Add(Country["name"].ToString());
            }
            bunifuTextBox6.AutoCompleteCustomSource = Countries;
            bunifuTextBox7.AutoCompleteCustomSource = Countries;
            bunifuTextBox6.PlaceholderText = "Lieu De Naissence";
            //Demeurant  à 
            bunifuTextBox7.PlaceholderText = "Demeurant  à";
        }

        void Loadjobs()
        {
            AutoCompleteStringCollection les_mois = new AutoCompleteStringCollection();
            JArray ja = JArray.Parse(System.IO.File.ReadAllText("JSON_F\\" + "jobs.json"));
            foreach (JObject mois in ja)
            {
                les_mois.Add(mois["name"].ToString());
            }
            bunifuTextBox8.AutoCompleteCustomSource = les_mois;
            bunifuTextBox8.PlaceholderText = "Engagement ";

        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        void Loadchantier()
        {
            AutoCompleteStringCollection les_mois = new AutoCompleteStringCollection();
            JArray ja = JArray.Parse(System.IO.File.ReadAllText("JSON_F\\" + "chantier.json"));
            foreach (JObject mois in ja)
            {
                les_mois.Add(mois["name"].ToString());
            }
            bunifuTextBox16.AutoCompleteCustomSource = les_mois;
            bunifuTextBox16.PlaceholderText = "Chantier ";
        }
        //LOAD JSON SALAIRE salaire.JSON

        void Loadsalaire()
        {
            AutoCompleteStringCollection les_mois = new AutoCompleteStringCollection();
            JArray ja = JArray.Parse(System.IO.File.ReadAllText("JSON_F\\" + "salaire.json"));
            foreach (JObject mois in ja)
            {
                les_mois.Add(mois["name"].ToString());
            }
            bunifuTextBox17.AutoCompleteCustomSource = les_mois;
            bunifuTextBox17.PlaceholderText = "salaire ";
        }
        void Loadmois()
        {
            AutoCompleteStringCollection les_mois = new AutoCompleteStringCollection();
            JArray ja = JArray.Parse(System.IO.File.ReadAllText("JSON_F\\" + "mois.json"));
            foreach (JObject mois in ja)
            {
                les_mois.Add(mois["name"].ToString());
            }
            bunifuTextBox9.AutoCompleteCustomSource = les_mois;
            bunifuTextBox9.PlaceholderText = "Durée Du Contrat";
        }
        void Loadstuation()
        {
            AutoCompleteStringCollection les_mois = new AutoCompleteStringCollection();
            JArray ja = JArray.Parse(System.IO.File.ReadAllText("JSON_F\\" + "sfam.json"));
            foreach (JObject mois in ja)
            {
                les_mois.Add(mois["name"].ToString());
            }
            bunifuTextBox27.AutoCompleteCustomSource = les_mois;
            bunifuTextBox27.PlaceholderText = "Situation Familiale ";
        }
        public void fnc_random_fill()
        {
            Random RND = new Random();
            int RANBO = RND.Next(nnam.Length);
            int RANBO1 = RND.Next(ppnam.Length);
            int RANBO2 = RND.Next(eengag.Length);
            int RANBO3 = RND.Next(ddureee.Length);
            int RANBO4 = RND.Next(situ_arr.Length);

            bunifuTextBox1.Text = nnam[RANBO];
            bunifuTextBox2.Text = ppnam[RANBO];
            bunifuTextBox3.Text = RND.Next(1, 31).ToString();
            bunifuTextBox4.Text = RND.Next(1, 12).ToString();
            bunifuTextBox5.Text = RND.Next(1960, 1992).ToString();
            //bunifuTextBox6.Text = "1333";
            bunifuTextBox6.Text = "TEBESSA";
            bunifuTextBox7.Text = "TEBESSA";
            bunifuTextBox8.Text = eengag[RANBO2];
            bunifuTextBox9.Text = ddureee[RANBO3];
            bunifuTextBox10.Text = RND.Next(1, 31).ToString();
            bunifuTextBox11.Text = RND.Next(1, 12).ToString();
            bunifuTextBox12.Text = RND.Next(2020, 2021).ToString();
            bunifuTextBox13.Text = RND.Next(1, 31).ToString();
            bunifuTextBox14.Text = "12";
            bunifuTextBox15.Text = "2021";
            bunifuTextBox16.Text = "3240 LGTS AADL BOULHAF DYR ,Wilaya de TEBESSA";
            bunifuTextBox17.Text = "50000";
            //bunifuTextBox16.Text = "1999";
            bunifuTextBox18.Text = "05-59-66-10-32";
            bunifuTextBox19.Text = nnam[RANBO] + ppnam[RANBO] + "@GMAIL.COM";
            bunifuTextBox20.Text = "O-";
            bunifuTextBox21.Text = RND.Next(100000, 999999).ToString() + RND.Next(100000, 999999).ToString();
            bunifuTextBox25.Text = RND.Next(1, 99).ToString(); ;
            bunifuTextBox27.Text = situ_arr[RANBO4];// "Célibataire";
            bunifuTextBox28.Text = RND.Next(1, 12).ToString();
        }
        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            fnc_random_fill();
        }

        private void check_data_valid_raw()
        {

            bunifuCustomLabel23.Text = "Cheking ....";

        }
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        private void collectted_data_ui()
        {


            //bunifuCustomLabel23.Text = "collectted_data_ui";
            //Update_Class cur_emply_obj = new Update_Class();

            //cur_emply_obj.O_NOM_employer = bunifuTextBox1.Text.ToUpper() ;
            //bunifuCustomLabel23.Text = cur_emply_obj.O_NOM_employer;
            // Save_Class.Instance.SC_NOM_employer = bunifuTextBox1.Text.ToUpper();
            Save_Class.Instance.SC_NOM_employer         = bunifuTextBox1.Text.ToUpper();
            Save_Class.Instance.SC_PNOM_employer        = bunifuTextBox2.Text.ToUpper();
            Save_Class.Instance.SC_DATE_N_employer      = bunifuTextBox3.Text + "/" + bunifuTextBox4.Text + "/" + bunifuTextBox5.Text;
            Save_Class.Instance.SC_LIEU_N_employer      = bunifuTextBox6.Text.ToUpper();
            Save_Class.Instance.SC_DEMEURANT_employer   = bunifuTextBox7.Text.ToUpper();
            Save_Class.Instance.SC_ENGAGEMENT_employer  = bunifuTextBox8.Text.ToUpper();
            Save_Class.Instance.SC_DUREE_employer       = bunifuTextBox9.Text.ToUpper();
            Save_Class.Instance.SC_ENTREE_employer      = bunifuTextBox10.Text + "/" + bunifuTextBox11.Text + "/" + bunifuTextBox12.Text;

            Save_Class.Instance.SC_SORTIE_employer      = bunifuTextBox13.Text + "/" + bunifuTextBox14.Text + "/" + bunifuTextBox15.Text;
            Save_Class.Instance.SC_CHANTIER_employer    = bunifuTextBox16.Text.ToUpper();
            Save_Class.Instance.SC_SALAIRE_employer     = bunifuTextBox17.Text;
            Save_Class.Instance.SC_NMR_ASSU_employer     = bunifuTextBox21.Text.ToUpper();
            Save_Class.Instance.SC_SITUATION_F_employer  = Chek_single(bunifuTextBox27.Text);
            Save_Class.Instance.SC_NBR_ENF_employer       = bunifuTextBox28.Text.ToUpper();
            Save_Class.Instance.SC_NMR_ADH_employer          = "";// bunifuTextBox9.Text.ToUpper();
            Save_Class.Instance.SC_GR_S_employer           = bunifuTextBox20.Text;

            Save_Class.Instance.SC_TELEPH_employer              = bunifuTextBox18.Text;
            Save_Class.Instance.SC_EMAIL__employer           = bunifuTextBox19.Text.ToUpper();
            Save_Class.Instance.SC_SINF__employer              = bunifuTextBox17.Text;
            Save_Class.Instance.SC_ETAT_CONTR_employer       = bunifuTextBox21.Text.ToUpper();
            Save_Class.Instance.SC_CONTRAT_TYPE_employer     = var_type_contrat.ToUpper();
            Save_Class.Instance.SC_DATE_REAL_employer        = bunifuTextBox28.Text.ToUpper();
            Save_Class.Instance.SC_IMG_employer              = empty_image(var_employe_image_path);
            Save_Class.Instance.SC_GENDER_employer            = var_employe_gendre;
            









        }
        public void fnc_show_syn_panel()
        {
            bunifuTransition10.HideSync(Add_Employer.Instance.PnlContainer);

            if (!Add_Employer.Instance.PnlContainer.Controls.ContainsKey("UC2"))
            {

                UC2 un3 = new UC2();
                un3.Dock = DockStyle.Fill;
                Add_Employer.Instance.PnlContainer.Controls.Clear();
                // Add_Employer.Instance.PnlContainer.Visible = false;

                Add_Employer.Instance.PnlContainer.Controls.Add(un3);
                bunifuTransition387.HideSync(Add_Employer.Instance.pnlNOTIFICATOIN);
                bunifuTransition10.ShowSync(Add_Employer.Instance.PnlContainer);

            }
        }
        private void BunifuButton2_Click(object sender, EventArgs e)

        {
            // NOTIFICATI0N ntf = new NOTIFICATI0N();

            //ntf.showAlert("hi", NOTIFICATI0N.enmType.Success) ;


            //fnc_random_fill();
            Stopwatch sw;
            sw = Stopwatch.StartNew();
            check_data_valid_raw();
            bunifuCustomLabel23.Text = bunifuCustomLabel23.Text + " time = " + sw.ElapsedMilliseconds;


            sw = Stopwatch.StartNew();
            collectted_data_ui();
            Save_notification();
            //bunifuCustomLabel26.Text = var_employe_gendre;
            //NOTIFICATI0N ntf = new NOTIFICATI0N();
            //ntf.showAlert("hi", NOTIFICATI0N.enmType.Success);
            bunifuCustomLabel23.Text = bunifuCustomLabel23.Text + " time = " + sw.ElapsedMilliseconds;
            //fnc_show_syn_panel();





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
        static string empty_image(string image_path)
        {
            MemoryStream ms = new MemoryStream();
            string image_path_gen = "";
            if (image_path == "no_image")
            {
                Bitmap image_blanc = new Bitmap(45, 65);
                var tmp_path = Path.GetTempPath();
                image_blanc.Save(tmp_path + @"blanc_imge.jpg");
                //string i_path = new Uri(tmp_path + "blanc_imge.jpg").AbsoluteUri;
                image_path_gen = tmp_path + @"blanc_imge.jpg";
                

            }
            else
            {
                image_path_gen = image_path;
                //Image uploaded6 = Image.FromFile(image_path_gen);
                //uploaded6.Save(ms, uploaded6.RawFormat);


            }
            return image_path_gen;
        }

        private async void Save_notification()
        {
            //§§§§§§§pnlnot un4 = new pnlnot();
            //§§§§§§un4.Dock = DockStyle.Fill;
            //§§§§§§Add_Employer.Instance.pnlNOTIFICATOIN.Controls.Clear();
            //§§§§§§Add_Employer.Instance.pnlNOTIFICATOIN.Controls.Add(un4);
            //Add_Employer.
            CLS_MICROSOFT cls_micro = new CLS_MICROSOFT();
           // cls_micro.Access_save();
            cls_micro.Fakae_Access_save();
            //ààbunifuTransition387.ShowSync(Add_Employer.Instance.pnlNOTIFICATOIN);

        }
        private void BunifuButton4_Click(object sender, EventArgs e)
        {

            //CLS_MICROSOFT bi = new CLS_MICROSOFT();
            //CLS_MICROSOFT.
            CLS_MICROSOFT cls_micro = new CLS_MICROSOFT();
            cls_micro.Access_save();


        }
        public  void faker_gen()
        {
            Random RND = new Random();
            int RANBO = RND.Next(nnam.Length);
            int RANBO1 = RND.Next(ppnam.Length);
            int RANBO2 = RND.Next(eengag.Length);
            int RANBO3 = RND.Next(ddureee.Length);
            int RANBO4 = RND.Next(situ_arr.Length);
            bunifuTextBox1.Text = Faker.NameFaker.LastName();
            bunifuTextBox2.Text = Faker.NameFaker.FirstName();
            bunifuTextBox3.Text = RND.Next(1, 31).ToString();
            bunifuTextBox4.Text = RND.Next(1, 12).ToString();
            bunifuTextBox5.Text = RND.Next(1960, 1992).ToString();
            //bunifuTextBox6.Text = "1333";
            bunifuTextBox6.Text = "TEBESSA";
            bunifuTextBox7.Text = "TEBESSA";
            bunifuTextBox8.Text = eengag[RANBO2];
            bunifuTextBox9.Text = ddureee[RANBO3];
            bunifuTextBox10.Text = RND.Next(1, 31).ToString();
            bunifuTextBox11.Text = RND.Next(1, 12).ToString();
            bunifuTextBox12.Text = RND.Next(2020, 2021).ToString();
            bunifuTextBox13.Text = RND.Next(1, 31).ToString();
            bunifuTextBox14.Text = "12";
            bunifuTextBox15.Text = "2021";
            bunifuTextBox16.Text = "3240 LGTS AADL BOULHAF DYR ,Wilaya de TEBESSA";
            bunifuTextBox17.Text = RND.Next(1, 99).ToString()+"000";
            //bunifuTextBox16.Text = "1999";
            bunifuTextBox18.Text = Faker.PhoneFaker.Phone();
            bunifuTextBox19.Text = nnam[RANBO] + ppnam[RANBO] + "@GMAIL.COM";
            bunifuTextBox20.Text = "O-";
            bunifuTextBox21.Text = RND.Next(100000, 999999).ToString() + RND.Next(100000, 999999).ToString();
            bunifuTextBox25.Text = RND.Next(1, 99).ToString(); 
            bunifuTextBox27.Text = situ_arr[RANBO4];// "Célibataire";
            bunifuTextBox28.Text = RND.Next(1, 12).ToString();
            
        }
        private int cc()
        {
            int ii = 0;
            for (int i = 0; i < 100; i++)
            {
                //faker_gen();
                collectted_data_ui();
                Save_notification();
                ii = i;

            }
            return ii;
        }
        private int vv()
        {
            int ii = 0;
            for (int i = 0; i < 100; i++)
            {
                faker_gen();
                collectted_data_ui();
                Save_notification();
                ii = i;

            }
            return ii;
        }
        private async void BunifuButton5_Click(object sender, EventArgs e)
        {
            bunifuCustomLabel26.Text = "generating ........";

            Task<int> tsk1 = new Task<int>(cc);
            tsk1.Start();
            int g = await tsk1;
            //vv();
            bunifuCustomLabel26.Text = g.ToString();

        }
    }
}