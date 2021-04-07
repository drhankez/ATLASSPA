using System;
using System.Data.OleDb;

namespace ATLASSPA
{
    public class Update_Class
    {
        private string test6;
        public string Getfirst()
        {
            return O_NOM_employer;
        }
        public void setfirt(string provider)
        {
            test6 = provider;
        }
        public string cnnString = "Provider =Microsoft.Jet.Oledb.4.0; Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb;";
        //VARIABLE
        public int O_id_employer;
        public string O_NOM_employer;
        public string O_PNOM_employer;
        public string O_DATE_N_employer;
        public string O_LIEU_N_employer;
        public string O_DEMEURANT_employer;
        public string O_ENGAGEMENT_employer;
        public string O_DUREE_employer;
        public string O_ENTREE_employer;
        public string O_SORTIE_employer;
        public string O_CHANTIER_employer;
        public string O_SALAIRE_employer;
        public string O_NMR_ASSU_employer;
        public string O_SITUATION_F_employer;
        public string O_NBR_ENF_employer;
        public string O_NMR_ADH_employer;
        public string O_GR_S_employer;
        public string O_TELEPH_employer;
        public string O_EMAIL__employer;
        public string O_SINF__employer;
        public string O_ETAT_CONTR_employer;
        public string O_CONTRAT_TYPE_employer;
        public string O_DATE_REAL_employer;
        public string O_IMG_employer;
        public string O_GENDER_employer;
        //public string O_employer;


        public string O_employer;
        /*public void Alert(string msg, NOTIFICATI0N.enmType type)
        {
            NOTIFICATI0N frm = new NOTIFICATI0N();
            frm.showAlert(msg, type);
        }*/

        public void connect_update_O()
        {
            //            string update = "Update T_1 Set NOM = ? ,PNOM = ? ,DATE_N = ?
            //,LIEU_N = ? ,DEMEURANT = ? ,ENGAGEMENT = ? ,DUREE = ? ,ENTREE = ? ,SORTIE = ? ,CHANTIER = ? ,
            //SALAIRE = ? ,NMR_ASSU = ? ,SITUATION_F = ? ,NBR_ENF = ? ,NMR_ADH = ? ,GR_S = ? ,TELEPH = ? ,EMAIL_ = ?
            //,SINF_  = ? ,ETAT_CONTR = ? ,CONTRAT_TYPE = ? ,DATE_REAL = ? ,IMG = ? ,GENDER = ? Where id = ? ";

            string update = "Update T_1 Set NOM = ? ,PNOM = ?  Where id = ? ";
            using (var cnn = new OleDbConnection(cnnString))
            {
                cnn.Open();

                using (var cmd = new OleDbCommand(update, cnn))
                {
                    cmd.Parameters.AddWithValue("NOM", O_NOM_employer);
                    cmd.Parameters.AddWithValue("PNOM", O_PNOM_employer);
                    cmd.Parameters.AddWithValue("id", O_id_employer);
                    cmd.ExecuteNonQuery();
                }
                cnn.Close();
            }
            //this.Alert("saved succeceded !!!!", NOTIFICATI0N.enmType.Info);


        }
    }
}