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
                    cmd.Parameters.AddWithValue("GENDRE", Save_Class.Instance.SC_GENDER_employer);
                    
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
