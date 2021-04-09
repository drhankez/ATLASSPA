using System;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class UC_P1 : UserControl
    {
        public int search_index = Save_Class.Instance.SC_id_employer;
        public UC_P1()
        {
            InitializeComponent();





        }

        private void UC_P1_Load(object sender, System.EventArgs e)
        {
            bunifuDataGridView1.AutoGenerateColumns = true;
            bunifuDataGridView1.EnableHeadersVisualStyles = false;
            bunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            INDEX_SEARCH_FILL index_search_fill = new INDEX_SEARCH_FILL();
            //bunifuLabel1.Text = Save_Class.Instance.SC_id_employer.ToString();
            index_search_fill.SRCH_INDEX(search_index);
            guna2CircleButton1.Text = Save_Class.Instance.SC_id_employer.ToString();

            //label1.Text = Save_Class.Instance.SC_NOM_employer.ToString();
            label1.Text = Save_Class.Instance.SC_NOM_employer;
            label2.Text = Save_Class.Instance.SC_PNOM_employer;
            label3.Text = Save_Class.Instance.SC_DATE_N_employer;
            label4.Text = Save_Class.Instance.SC_LIEU_N_employer;
            label5.Text = Save_Class.Instance.SC_DEMEURANT_employer;
            label6.Text = Save_Class.Instance.SC_ENGAGEMENT_employer;
            label7.Text = Save_Class.Instance.SC_DUREE_employer;
            label8.Text = Save_Class.Instance.SC_ENTREE_employer;
            //label9.Text =;
            label10.Text = Save_Class.Instance.SC_SORTIE_employer;
            label11.Text = Save_Class.Instance.SC_CHANTIER_employer;
            label12.Text = Save_Class.Instance.SC_SALAIRE_employer;
            label13.Text = Save_Class.Instance.SC_NMR_ASSU_employer;
            label14.Text = Save_Class.Instance.SC_SITUATION_F_employer;
            label15.Text = Save_Class.Instance.SC_NBR_ENF_employer;
            label16.Text = Save_Class.Instance.SC_NMR_ADH_employer;
            label17.Text = Save_Class.Instance.SC_GR_S_employer;
            // label18.Text =
            label19.Text = Save_Class.Instance.SC_TELEPH_employer;
            label20.Text = Save_Class.Instance.SC_EMAIL__employer;
            label21.Text = Save_Class.Instance.SC_SINF__employer;
            label22.Text = Save_Class.Instance.SC_ETAT_CONTR_employer;
            label23.Text = Save_Class.Instance.SC_CONTRAT_TYPE_employer;
            //label24.Text = Save_Class.Instance.SC_DATE_REAL_employer;
            //label24.Text = Save_Class.Instance.SC_IMG_employer;
            //label26.Text = Save_Class.Instance.SC_GENDER_employer;
            string[] d0dr0contrat0arr = Save_Class.Instance.SC_DUREE_employer.Split('@');
            string[] engagement0arr = Save_Class.Instance.SC_ENGAGEMENT_employer.Split('@');
            string[] ENTREEt0arr = Save_Class.Instance.SC_ENTREE_employer.Split('@');
            string[] SORTIE0arr = Save_Class.Instance.SC_SORTIE_employer.Split('@');
            string[] CHANTIERE0arr = Save_Class.Instance.SC_CHANTIER_employer.Split('@');
            string[] SALAIRE0arr = Save_Class.Instance.SC_SALAIRE_employer.Split('@');
            //Save_Class.Instance.SC_DUREE_employer;
            label25.Text = engagement0arr.Length.ToString();
            int lenf = engagement0arr.Length;
            for (int i = 1; i < lenf ; i ++)
            {
                //MessageBox.Show(i.ToString());
                populate1(i.ToString(), engagement0arr[i].ToString(), d0dr0contrat0arr[i].ToString(), ENTREEt0arr[i].ToString(), SORTIE0arr[i].ToString(), CHANTIERE0arr[i].ToString(), SALAIRE0arr[i].ToString()+" DA");
            }
            //bunifuDataGridView1.Columns[0].Width = 55;
         //   bunifuDataGridView1.Columns[1].AutoSizeMode =DataGridViewAutoSizeColumnMode.Fill;
          //  bunifuDataGridView1.Columns[2].FillWeight = 30;
            bunifuDataGridView1.Columns["Chantier"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
          //  bunifuDataGridView1.Columns[4].FillWeight = 20;

            //bunifuDataGridView1.Columns[0].Width = 180;
            //bunifuDataGridView1.Columns.Item("N").Width = 160;
        }
        private void populate1(string NN, string EG, string DRE, string EMB, string SRT, string CHNT, string SALR)
        {
            //ROW
            String[] row = {NN,EG, DRE, EMB, SRT, CHNT, SALR };
            bunifuDataGridView1.Rows.Add(row);
            /*foreach (DataRow row in dds.Rows)
            {populate1(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString().Split('@').Last(), row[7].ToString().Split('@').Last(), row[8].ToString().Split('@').Last(), row[9].ToString().Split('@').Last(), row[10].ToString().Split('@').Last(), row[11].ToString().Split('@').Last(), row[12].ToString(), row[13].ToString(), row[14].ToString(), row[15].ToString(), row[16].ToString(), row[17].ToString(), row[18].ToString(), row[18].ToString());
                //byte[] imgBytes = (byte[])row[23];
                //TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                //Bitmap MyBitmap = (Bitmap)tc.ConvertFrom(imgBytes);
                //string imgString = Convert.ToBase64String(imgBytes);
                //imgLogoCompany.Src = String.Format("data:image/Bmp;base64,{0}\"", imgString);
                populate1(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString().Split('@').Last(), row[7].ToString().Split('@').Last(), row[8].ToString().Split('@').Last(), row[9].ToString().Split('@').Last(), row[10].ToString().Split('@').Last(), row[11].ToString().Split('@').Last(), row[12].ToString(), row[13].ToString(), row[14].ToString(), row[15].ToString(), row[16].ToString(), row[17].ToString(), row[18].ToString(), row[18].ToString());
            }*/
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            if(contract_panel.Visible == true)
            {
                contract_panel.Visible = false;
            }
            else
            {
                contract_panel.Visible = true;
            }
            
        }


    }
}
