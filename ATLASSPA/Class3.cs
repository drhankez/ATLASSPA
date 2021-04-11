using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATLASSPA
{
    public class Class3
    {
        public void save_modification()
        {
            int uid;
            /*uid = int.Parse(bunifuCustomLabel1.Text);
            Bitmap bm = new Bitmap(picImage.Image);
            //picImage.Image = bm;
            Bitmap bitmapImage = new Bitmap(picImage.Image);
            byte[] image_bytes = ImageToBytes(bm, ImageFormat.Bmp);
            */
            //            string update = "Update T_1 Set NOM = ? , PNOM = ? , DATE_N = ? , LIEU_N = ?, DEMEURANT = ?, ENGAGEMENT = ? , DUREE = ? , ENTREE = ? , SORTIE = ? , CHANTIER = ? , SALAIRE = ?  ,  IMG = ? Where id = ? ";

            string update = "Update T_1 Set NOM = ? , PNOM = ? , DATE_N = ? , LIEU_N = ?, DEMEURANT = ?, ENGAGEMENT = ? , DUREE = ? , ENTREE = ? , SORTIE = ? , CHANTIER = ? , SALAIRE = ?, NMR_ASSU = ? ,SITUATION_F = ? ,NBR_ENF = ? ,NMR_ADH = ?  ,GR_S = ? ,TELEPH = ? ,EMAIL_ = ?   Where id = ? ";
            //, DATE_N = ? , LIEU_N = ? , IMG = ?
            string cnnString = "Provider =Microsoft.Jet.Oledb.4.0; Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb;";
            using (var cnn = new OleDbConnection(cnnString))
            {
                cnn.Open();

                using (var cmd = new OleDbCommand(update, cnn))
                {
                    // Add the parameters

                    //int.Parse(2147483649)
                    //string date_de_naissance = bunifuTextBox3.Text + "/" + bunifuTextBox4.Text + "/" + bunifuTextBox5.Text;
                    /*string date_d_entree = bunifuTextBox13.Text + "/" + bunifuTextBox14.Text + "/" + bunifuTextBox15.Text;
                    string date_de_sortie = bunifuTextBox16.Text + "/" + bunifuTextBox17.Text + "/" + bunifuTextBox18.Text;*/


                    /*cmd.Parameters.AddWithValue("NOM", bunifuTextBox1.Text);
                    cmd.Parameters.AddWithValue("PNOM", bunifuTextBox2.Text);
                    cmd.Parameters.AddWithValue("DATE_N", date_de_naissance);
                    cmd.Parameters.AddWithValue("LIEU_N", bunifuTextBox6.Text);
                    cmd.Parameters.AddWithValue("DEMEURANT", bunifuTextBox7.Text);
                    cmd.Parameters.AddWithValue("ENGAGEMENT", "@" + bunifuTextBox8.Text);
                    cmd.Parameters.AddWithValue("DUREE", "@" + bunifuTextBox9.Text);
                    cmd.Parameters.AddWithValue("ENTREE", date_d_entree);
                    cmd.Parameters.AddWithValue("SORTIE", date_de_sortie);
                    cmd.Parameters.AddWithValue("CHANTIER", bunifuTextBox19.Text);
                    cmd.Parameters.AddWithValue("SALAIRE", "@" + bunifuTextBox20.Text);*/
                    //cmd.CommandType = CommandType.Text;
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
                    /*cmd.Parameters.AddWithValue("DEMEURANT", bunifuTextBox9.Text);
                    cmd.Parameters.AddWithValue("DUREE", bunifuTextBox10.Text);
                    */
                    //cmd.Parameters.AddWithValue("IMG", "");//SavePhoto());
                    cmd.Parameters.AddWithValue("id", Save_Class.Instance.SC_id_employer);
                    /*   
                    cmd.Parameters.AddWithValue("LIEU_N", bunifuTextBox1.Text);*/


                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
