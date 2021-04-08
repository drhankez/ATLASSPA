using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATLASSPA
{
    public class INDEX_SEARCH_FILL
    {


        public void SRCH_INDEX(int search_index)
        {
            string ConnString = "Provider =Microsoft.Jet.Oledb.4.0; Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb";
            string SqlString = "select * from T_1 Where id =" + search_index + "";

            //string SqlString = "Insert Into T_1 (NOM,PNOM,DATE_N,LIEU_N,DEMEURANT,ENGAGEMENT,DUREE,ENTREE,SORTIE,CHANTIER,SALAIRE,NMR_ASSU,SITUATION_F,NBR_ENF,NMR_ADH,GR_S,TELEPH,EMAIL_,SINF_ ,ETAT_CONTR,CONTRAT_TYPE,DATE_REAL,IMG,GENDER)  Values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";

            using (OleDbConnection conn = new OleDbConnection(ConnString))

            {
                using (OleDbCommand cmd = new OleDbCommand(SqlString, conn))
                    

                {
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    

                    if (reader.Read())
                    {
                        Save_Class.Instance.SC_NOM_employer         = reader["NOM"].ToString();
                        Save_Class.Instance.SC_PNOM_employer        = reader["PNOM"].ToString();
                        Save_Class.Instance.SC_DATE_N_employer      = reader["DATE_N"].ToString();
                        Save_Class.Instance.SC_LIEU_N_employer      = reader["LIEU_N"].ToString();
                        Save_Class.Instance.SC_DEMEURANT_employer   = reader["DEMEURANT"].ToString();
                        Save_Class.Instance.SC_ENGAGEMENT_employer  = reader["ENGAGEMENT"].ToString();
                        Save_Class.Instance.SC_DUREE_employer       = reader["DUREE"].ToString();
                        Save_Class.Instance.SC_ENTREE_employer      = reader["ENTREE"].ToString();
                        Save_Class.Instance.SC_SORTIE_employer      = reader["SORTIE"].ToString();
                        Save_Class.Instance.SC_CHANTIER_employer    = reader["CHANTIER"].ToString();
                        Save_Class.Instance.SC_SALAIRE_employer     = reader["SALAIRE"].ToString();
                        Save_Class.Instance.SC_NMR_ASSU_employer    = reader["NMR_ASSU"].ToString();
                        Save_Class.Instance.SC_SITUATION_F_employer = reader["SITUATION_F"].ToString();
                        Save_Class.Instance.SC_NBR_ENF_employer     = reader["NBR_ENF"].ToString();
                        Save_Class.Instance.SC_NMR_ADH_employer     = reader["NMR_ADH"].ToString();
                        Save_Class.Instance.SC_GR_S_employer        = reader["GR_S"].ToString();
                        Save_Class.Instance.SC_TELEPH_employer      = reader["TELEPH"].ToString();
                        Save_Class.Instance.SC_EMAIL__employer      = reader["EMAIL_"].ToString();
                        Save_Class.Instance.SC_SINF__employer       = reader["SINF_"].ToString();
                        Save_Class.Instance.SC_ETAT_CONTR_employer  = reader["ETAT_CONTR"].ToString();
                        Save_Class.Instance.SC_CONTRAT_TYPE_employer= reader["CONTRAT_TYPE"].ToString();
                        Save_Class.Instance.SC_DATE_REAL_employer   = reader["DATE_REAL"].ToString();
                        Save_Class.Instance.SC_IMG_employer         = reader["IMG"].ToString();
                        Save_Class.Instance.SC_IMG_employer_byteArray = (byte[])reader["IMG"];
                        Save_Class.Instance.SC_GENDER_employer      = reader["PNOM"].ToString();
                        //= reader["PNOM"].ToString();
                        //= reader["PNOM"].ToString();
                    }

                    reader.Close();
                    /*cmd.CommandType = CommandType.Text;
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
                    cmd.Parameters.AddWithValue("IMG", "SavePhoto()");
                    cmd.Parameters.AddWithValue("GENDRE", Save_Class.Instance.SC_GENDER_employer);
                    //  cmd.Parameters.AddWithValue("GR_S", bunifuTextBox1.Text);
                    //cmd.Parameters.AddWithValue("EMAIL_", bunifuTextBox1.Text);

                    conn.Open();

                    cmd.ExecuteNonQuery();*/

                }

            }





            //NOTIFICATI0N ntf = new NOTIFICATI0N();
            //ntf.showAlert("hi", NOTIFICATI0N.enmType.Success);
            //Save_notification();
        }

    }
}
