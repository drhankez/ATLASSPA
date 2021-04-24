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
    public partial class UC_P3 : UserControl
    {

        public int search_index = Save_Class.Instance.SC_id_employer;
        public UC_P3()
        {
            InitializeComponent();
        }
        private void init_start()
        {
            //INDEX_SEARCH_FILL index_search_fill = new INDEX_SEARCH_FILL();
            //index_search_fill.SRCH_INDEX(search_index);
            label1.Text =           Save_Class.Instance.SC_NOM_employer;
            label2.Text =           Save_Class.Instance.SC_PNOM_employer;
            label3.Text =           Save_Class.Instance.SC_DATE_N_employer;
            label4.Text =           Save_Class.Instance.SC_LIEU_N_employer;
            label5.Text =           Save_Class.Instance.SC_DEMEURANT_employer;
            bunifuTextBox8.Text =   Save_Class.Instance.SC_ENGAGEMENT_employer.Split('@').Last();
            bunifuTextBox16.Text=   Save_Class.Instance.SC_CHANTIER_employer.Split('@').Last();
            bunifuTextBox17.Text = Save_Class.Instance.SC_SALAIRE_employer.Split('@').Last() + " DA";
        }
        private void populate1(string NN, string EG, string DRE, string EMB, string SRT, string CHNT, string SALR)
        {
            //ROW
            String[] row = { NN, EG, CHNT, EMB,SRT, DRE, SALR };
            bunifuDataGridView1.Rows.Add(row);
        }
        private void fill_cotract()
        {

            string[] d0dr0contrat0arr = Save_Class.Instance.SC_DUREE_employer.Split('@');
            string[] engagement0arr = Save_Class.Instance.SC_ENGAGEMENT_employer.Split('@');
            string[] ENTREEt0arr = Save_Class.Instance.SC_ENTREE_employer.Split('@');
            string[] SORTIE0arr = Save_Class.Instance.SC_SORTIE_employer.Split('@');
            string[] CHANTIERE0arr = Save_Class.Instance.SC_CHANTIER_employer.Split('@');
            string[] SALAIRE0arr = Save_Class.Instance.SC_SALAIRE_employer.Split('@');

            int lenf = engagement0arr.Length;

            for (int i = 1; i < lenf; i++)
            {
                //MessageBox.Show(i.ToString());
                populate1(i.ToString(), engagement0arr[i].ToString(), d0dr0contrat0arr[i].ToString(), ENTREEt0arr[i].ToString(), SORTIE0arr[i].ToString(), CHANTIERE0arr[i].ToString(), SALAIRE0arr[i].ToString() + " DA");
            }
            //bunifuDataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // 
            //bunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bunifuDataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            bunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bunifuDataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuDataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuDataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuDataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuDataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuDataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuDataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //bunifuDataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            /*
            bunifuDataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuDataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bunifuDataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //bunifuDataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;*/



        }
        private void UC_P3_Load(object sender, EventArgs e)
        {
            init_start();
            fill_cotract();
        }
    }
}
