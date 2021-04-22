using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class A07_SEARCHcs : Form
    {
        static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb";
        public DataTable dtbl1=new DataTable();

        public DataRow DataRow { get; private set; }

        public A07_SEARCHcs()
        {
            InitializeComponent();
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            // dgv1.AutoGenerateColumns = true;
            //dgv1_set_columns();
            /*dtbl1.Columns.Add("Nom");
            dtbl1.Columns.Add("1Nom");
            dtbl1.Columns.Add("2Nom");
            dtbl1.Columns.Add("3Nom");
            dtbl1.Columns.Add("4Nom");
            dtbl1.Columns.Add("5Nom");
            dtbl1.Columns.Add("6Nom");
            dtbl1.Columns.Add("7Nom");
            dtbl1.Columns.Add("8Nom");
            dtbl1.Columns.Add("9Nom");
            dtbl1.Columns.Add("10Nom");
            dtbl1.Columns.Add("11Nom");
            dtbl1.Columns.Add("12Nom");
            dtbl1.Columns.Add("13Nom");
            dtbl1.Columns.Add("14Nom");
            dtbl1.Columns.Add("15Nom");
            dtbl1.Columns.Add("16Nom");
            dtbl1.Columns.Add("17Nom");
            dtbl1.Columns.Add("18Nom");
            dtbl1.Columns.Add("19Nom");*/

        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Home_Page();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Home_Page();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_type_r.Text = guna2ComboBox1.Text;
        }

        private void SRCH_BTN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                //MessageBox.Show("F1 pressed");

                SRCH_BTN.SelectAll();
            }
            if (e.KeyCode == Keys.Enter)
            {
                getdata_BEST();
            }
        }
        private void populate(string I, string N, string P, string LN, string DM, string EG, string DRE, string EMB, string SRT, string CHNT, string SALR, string NASS, string SITF, string NMBRE, string NADH, string GPRH, string TELEPHONE, string EMAIL, string ETTE, string immg)
        {
            //ROW
            String[] row = { I, N, P, LN, DM, EG, DRE, EMB, SRT, CHNT, SALR, NASS, SITF, NMBRE, NADH, GPRH, TELEPHONE, EMAIL, ETTE, immg };
            DataRow rrow = dtbl1.NewRow();
            rrow[0] = I;
            rrow[1] = N;
            rrow[2] = P;
            rrow[3] = N;
            rrow[4] = N;
            rrow[5] = N;
            rrow[6] = N;
            rrow[7] = N;
            rrow[8] = N;
            rrow[9] = N;
            rrow[10] = N;
            rrow[11] = N;
            rrow[12] = N;
            rrow[13] = N;
            rrow[14] = N;
            rrow[15] = N;
            rrow[16] = N;
            rrow[17] = N;
            rrow[18] = N;
            rrow[19] = N;
            try
            {
                dtbl1.Rows.Add(rrow);
            }
            catch
            {

            }
            
            //dgv1.Rows.Add(row);
        }

        private void dgv1_set_columns() {
            dgv1.AutoGenerateColumns = false;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //
            //
            //
            dgv1.Columns[0].HeaderCell.Value = "ID";
            dgv1.Columns[0].Width = 45;
            dgv1.Columns[1].HeaderCell.Value = "Nom";
            dgv1.Columns[1].Width = 120;
            //dgv1.Columns[1].Width = 120
            //            OleDbCommand cmd = new OleDbCommand("Select id,NOM,PNOM,DATE_N,ENGAGEMENT,CHANTIER,DUREE,ENTREE,SORTIE FROM T_1", con);
            dgv1.Columns[2].HeaderCell.Value = "Prénom";
            dgv1.Columns[2].Width = 120;
            dgv1.Columns[3].HeaderCell.Value = "Né Le";
            dgv1.Columns[3].Width = 90;



            dgv1.Columns[4].HeaderCell.Value = "ENGAGEMENT";
            dgv1.Columns[4].Width = 190;
            dgv1.Columns[5].HeaderCell.Value = "CHANTIER";
            dgv1.Columns[5].Width = 340;

            dgv1.Columns[6].HeaderCell.Value = "DUREE";
            dgv1.Columns[6].Width = 100;
           //dgv1.Columns[3].Width = 90;
            dgv1.Columns[7].Width = 90;
            dgv1.Columns[8].Width = 90;
            //dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            /*dgv1.Columns[1].HeaderCell.Value = "Nom";
            dgv1.Columns[1].Width = 120;
            dgv1.Columns[1].HeaderCell.Value = "Prénom";
            dgv1.Columns[1].Width = 120;*/
            //dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells ;
        }
        private void getdata()
        {
            dgv1.Rows.Clear();
            dgv1.ClearSelection();
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                using (OleDbConnection con = new OleDbConnection(conString))
                {
                    using (OleDbCommand cmd = new OleDbCommand("Select * FROM T_1 WHERE NOM LIKE '%" + SRCH_BTN.Text.Trim() + "%'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                        {
                            using (DataTable dds = new DataTable())
                            {
                                sda.Fill(dds);
                                //sda.Fill(dtbl1);
                                int search_count = dds.Rows.Count;
                                
                                foreach (DataRow row in dds.Rows)
                                {
                                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString().Split('@').Last(), row[7].ToString().Split('@').Last(), row[8].ToString().Split('@').Last(), row[9].ToString().Split('@').Last(), row[10].ToString().Split('@').Last(), row[11].ToString().Split('@').Last(), row[12].ToString(), row[13].ToString(), row[14].ToString(), row[15].ToString(), row[16].ToString(), row[17].ToString(), row[18].ToString(), row[18].ToString());
                                }

                                lbl_count.Text = search_count.ToString();
                                DataTable dds2 = new DataTable();
                                dds2 = dtbl1.Copy();

                                BindingSource bsr = new BindingSource();

                                bsr.DataSource = dds2;
                                dgv1.DataSource = bsr;
                                sda.Update(dds2);

                                dds.Dispose();

                            }
                            sda.Dispose();

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getdata_BEST()
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            OleDbConnection con = new OleDbConnection(conString);
            OleDbCommand cmd = new OleDbCommand("Select id,NOM,PNOM,DATE_N,ENGAGEMENT,CHANTIER,DUREE,ENTREE,SORTIE FROM T_1", con);
            //OleDbCommand cmd = new OleDbCommand("Select * FROM T_1", con);
            try
            {
                OleDbDataAdapter sda = new OleDbDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                DataTable dds2 = new DataTable();

                foreach (DataRow row in dt.Rows)
                {
                    row[4] = row[4].ToString().Split('@').Last();
                    row[5] = row[5].ToString().Split('@').Last();
                    row[6] = row[6].ToString().Split('@').Last();
                    row[7] = row[7].ToString().Split('@').Last();
                    row[8] = row[8].ToString().Split('@').Last();
                }
                dds2 = dt.Copy();
                BindingSource bsr = new BindingSource();
                bsr.DataSource = dds2;
                dgv1.DataSource = bsr;
                //dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv1_set_columns();
                //sda.Update(dds2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MetroButton1_Click(object sender, EventArgs e)
        {

            //OleDbDataAdapter da = new OleDbDataAdapter();
            getdata_BEST();
            SRCH_BTN.Focus();
            SRCH_BTN.SelectAll();
            //dtgv1.AutoResizeColumns();
            //dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;




        }


           
    }
}
