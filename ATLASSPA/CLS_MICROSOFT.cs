using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;

namespace ATLASSPA
{
    public class CLS_MICROSOFT
    {
        public byte[] SavePhoto(string img_path)
        {
            MemoryStream ms = new MemoryStream();
            Image uploaded6 = Image.FromFile(img_path);
            uploaded6.Save(ms, uploaded6.RawFormat);
            return ms.GetBuffer();
        }
        public void Access_save()
        {

            string ConnString = "Provider =Microsoft.Jet.Oledb.4.0; Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb";

            string SqlString = "Insert Into T_1 (NOM,PNOM,DATE_N,LIEU_N,DEMEURANT,ENGAGEMENT,DUREE,ENTREE,SORTIE,CHANTIER,SALAIRE,NMR_ASSU,SITUATION_F,NBR_ENF,NMR_ADH,GR_S,TELEPH,EMAIL_,SINF_ ,ETAT_CONTR,CONTRAT_TYPE,DATE_REAL,IMG,GENDER)  Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
            Save_Class.Instance.SC_IMG_employer_byteArray = SavePhoto(Save_Class.Instance.SC_IMG_employer);
            using (OleDbConnection conn = new OleDbConnection(ConnString))

            {
                using (OleDbCommand cmd = new OleDbCommand(SqlString, conn))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("NOM", Save_Class.Instance.SC_NOM_employer);
                    cmd.Parameters.AddWithValue("PNOM", Save_Class.Instance.SC_PNOM_employer);
                    cmd.Parameters.AddWithValue("DATE_N", Save_Class.Instance.SC_DATE_N_employer);
                    cmd.Parameters.AddWithValue("LIEU_N", Save_Class.Instance.SC_LIEU_N_employer);
                    cmd.Parameters.AddWithValue("DEMEURANT", Save_Class.Instance.SC_DEMEURANT_employer);
                    cmd.Parameters.AddWithValue("ENGAGEMENT", "@" + Save_Class.Instance.SC_ENGAGEMENT_employer);
                    cmd.Parameters.AddWithValue("DUREE", "@" + Save_Class.Instance.SC_DUREE_employer);
                    cmd.Parameters.AddWithValue("ENTREE", "@" + Save_Class.Instance.SC_ENTREE_employer);
                    cmd.Parameters.AddWithValue("SORTIE", "@" + Save_Class.Instance.SC_SORTIE_employer);
                    cmd.Parameters.AddWithValue("CHANTIER", "@" + Save_Class.Instance.SC_CHANTIER_employer);
                    cmd.Parameters.AddWithValue("SALAIRE", "@" + Save_Class.Instance.SC_SALAIRE_employer);
                    cmd.Parameters.AddWithValue("NMR_ASSU", Save_Class.Instance.SC_NMR_ASSU_employer);

                    cmd.Parameters.AddWithValue("SITUATION_F", Save_Class.Instance.SC_SITUATION_F_employer);
                    cmd.Parameters.AddWithValue("NBR_ENF", Save_Class.Instance.SC_NBR_ENF_employer);
                    cmd.Parameters.AddWithValue("NMR_ADH", Save_Class.Instance.SC_NMR_ADH_employer);
                    cmd.Parameters.AddWithValue("GR_S", Save_Class.Instance.SC_GR_S_employer);
                    cmd.Parameters.AddWithValue("TELEPH", Save_Class.Instance.SC_TELEPH_employer);
                    cmd.Parameters.AddWithValue("EMAIL_", Save_Class.Instance.SC_EMAIL__employer);

                    cmd.Parameters.AddWithValue("SINF_", "bunifuTextBox700.Text");
                    cmd.Parameters.AddWithValue("ETAT_CONTR", "ACTIVE");
                    cmd.Parameters.AddWithValue("CONTRAT_TYPE", "NEW OR RENOUV");
                    cmd.Parameters.AddWithValue("DATE_REAL", "ACTIVE_DATE_REAL");


                    //cmd.Parameters.AddWithValue("SINF_", bunifuTextBox19.Text);
                    // cmd.Parameters.AddWithValue("LATIN_NOM", bunifuTextBox20.Text);

                    cmd.Parameters.AddWithValue("IMG", Save_Class.Instance.SC_IMG_employer_byteArray);
                    cmd.Parameters.AddWithValue("GENDER", Save_Class.Instance.SC_GENDER_employer);

                    //  cmd.Parameters.AddWithValue("GR_S", bunifuTextBox1.Text);
                    //cmd.Parameters.AddWithValue("EMAIL_", bunifuTextBox1.Text);

                    conn.Open();

                    cmd.ExecuteNonQuery();

                }

            }





            //NOTIFICATI0N ntf = new NOTIFICATI0N();
            //ntf.showAlert("hi", NOTIFICATI0N.enmType.Success);
            //Save_notification();
        }


        public static String[] nnam = { "ADEL", "YACINE", "AHMED", "OZAN", "FAYCEL", "SAMI", "ZOBIR", "AYMEN", "RAMI", "MORAT", "REDVAN", "BURAK", "REDHA", "KOLIBALI" };
        public static String[] ppnam = { "HASNAOUI", "CHAYBI", "ZARKAN", "AIT AOUDIA", "SAHRAOUI", "BENABDALLAG", "BOUALEGGE", "BOUGDIRI", "TALBI", "FARHATI", "SALEM", "SEBIA", "AYMEN", "MOZAKA" };
        public static String[] eengag = { "JOB1", "ARCHI", "CHAUFEAUR", "FEMME DE MENAGE", "FERRALLIEUR", "CHAUFFEUR", "MAçON", "MANOEUVRE", "CHEF DE PROJET", "INGINIEUR EN GENIE CIVIL" };
        public static String[] ddureee = { "QUANZE JOUR", "01 Mois", "09 Mois", "06 Mois", "02 Mois", "05 Mois", "07 Mois" };
        public static String[] situ_arr = { "Célibataire", "Mariée" };
        public static String[] gndr_arr = { "F", "M", "M", "M", "F "};
        public void Fakae_Access_save()
        {


            Random RND = new Random();
            int RANBO = RND.Next(nnam.Length);
            int RANBO1 = RND.Next(ppnam.Length);
            int RANBO2 = RND.Next(eengag.Length);
            int RANBO3 = RND.Next(ddureee.Length);
            int RANBO4 = RND.Next(situ_arr.Length);

            string ConnString = "Provider =Microsoft.Jet.Oledb.4.0; Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb";

            string SqlString = "Insert Into T_1 (NOM,PNOM,DATE_N,LIEU_N,DEMEURANT,ENGAGEMENT,DUREE,ENTREE,SORTIE,CHANTIER,SALAIRE,NMR_ASSU,SITUATION_F,NBR_ENF,NMR_ADH,GR_S,TELEPH,EMAIL_,SINF_ ,ETAT_CONTR,CONTRAT_TYPE,DATE_REAL,IMG,GENDER)  Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
            Save_Class.Instance.SC_IMG_employer_byteArray = SavePhoto(Save_Class.Instance.SC_IMG_employer);
            using (OleDbConnection conn = new OleDbConnection(ConnString))

            {
                using (OleDbCommand cmd = new OleDbCommand(SqlString, conn))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("NOM", Faker.NameFaker.LastName());
                    cmd.Parameters.AddWithValue("PNOM", Faker.NameFaker.FirstName());
                    cmd.Parameters.AddWithValue("DATE_N", RND.Next(1, 31).ToString() + "/" + RND.Next(1, 12).ToString() + "/" + RND.Next(1960, 1992).ToString());
                    cmd.Parameters.AddWithValue("LIEU_N", "TEBESSA");
                    cmd.Parameters.AddWithValue("DEMEURANT", "TEBESSA");
                    cmd.Parameters.AddWithValue("ENGAGEMENT", "@" + eengag[RANBO2]);
                    cmd.Parameters.AddWithValue("DUREE", "@" + ddureee[RANBO3]);
                    cmd.Parameters.AddWithValue("ENTREE", "@" +string.Format("{0:00}", RND.Next(10, 31).ToString()) +"/"+ string.Format("{0:00}", RND.Next(10, 12).ToString()) + "/" + RND.Next(2020, 2021).ToString());
                    cmd.Parameters.AddWithValue("SORTIE", "@" + RND.Next(10, 31).ToString() + "/" + RND.Next(10, 12).ToString() + "/" + RND.Next(2020, 2021).ToString());
                    cmd.Parameters.AddWithValue("CHANTIER", "@" + "3240 LGTS AADL BOULHAF DYR ,Wilaya de TEBESSA");
                    cmd.Parameters.AddWithValue("SALAIRE", "@" + RND.Next(1, 99).ToString() + "000");
                    cmd.Parameters.AddWithValue("NMR_ASSU", RND.Next(100000, 999999).ToString() + RND.Next(100000, 999999).ToString());

                    cmd.Parameters.AddWithValue("SITUATION_F", situ_arr[RANBO4]);
                    cmd.Parameters.AddWithValue("NBR_ENF", RND.Next(1, 12).ToString());
                    cmd.Parameters.AddWithValue("NMR_ADH", RND.Next(100000, 999999).ToString() + RND.Next(100000, 999999).ToString());
                    cmd.Parameters.AddWithValue("GR_S", "A+");
                    cmd.Parameters.AddWithValue("TELEPH", Faker.PhoneFaker.Phone());
                    cmd.Parameters.AddWithValue("EMAIL_", nnam[RANBO] + ppnam[RANBO] + "@GMAIL.COM");

                    cmd.Parameters.AddWithValue("SINF_", "bunifuTextBox700.Text");
                    cmd.Parameters.AddWithValue("ETAT_CONTR", "ACTIVE");
                    cmd.Parameters.AddWithValue("CONTRAT_TYPE", "NEW OR RENOUV");
                    cmd.Parameters.AddWithValue("DATE_REAL", "ACTIVE_DATE_REAL");


                    //cmd.Parameters.AddWithValue("SINF_", bunifuTextBox19.Text);
                    // cmd.Parameters.AddWithValue("LATIN_NOM", bunifuTextBox20.Text);

                    cmd.Parameters.AddWithValue("IMG", Save_Class.Instance.SC_IMG_employer_byteArray);
                    cmd.Parameters.AddWithValue("GENDER", gndr_arr[RND.Next(0, 4)]);

                    //  cmd.Parameters.AddWithValue("GR_S", bunifuTextBox1.Text);
                    //cmd.Parameters.AddWithValue("EMAIL_", bunifuTextBox1.Text);

                    conn.Open();

                    cmd.ExecuteNonQuery();

                }

            }





            //NOTIFICATI0N ntf = new NOTIFICATI0N();
            //ntf.showAlert("hi", NOTIFICATI0N.enmType.Success);
            //Save_notification();
        }
    }
}
