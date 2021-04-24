using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class A07_SEARCHcs : Form
    {
        static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb";
        static string cmd_string_type_search  = "";
        public DataTable dtbl1 = new DataTable();

        public DataRow DataRow { get; private set; }


        public A07_SEARCHcs()
        {
            InitializeComponent();
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgv1.MouseWheel += new MouseEventHandler(Mousewheel);
            getdata_BEST();
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
        private void Mousewheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta > 0 && dgv1.FirstDisplayedScrollingRowIndex > 0)
                {
                    dgv1.FirstDisplayedScrollingRowIndex--;
                }
                else if (e.Delta < 0)
                {
                    dgv1.FirstDisplayedScrollingRowIndex++;
                }
            }
            catch
            {

            }
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

        private void dgv1_set_columns()
        {
            dgv1.AutoGenerateColumns = false;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //
            //
            //
            dgv1.Columns[0].HeaderCell.Value = "ID";
            dgv1.Columns[0].Width = 45;
            dgv1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            dgv1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[5].HeaderCell.Value = "CHANTIER";
            dgv1.Columns[5].Width = 360;

            dgv1.Columns[6].HeaderCell.Value = "DUREE";
            dgv1.Columns[6].Width = 100;
            dgv1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv1.Columns[3].Width = 90;
            dgv1.Columns[7].Width = 90;
            dgv1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv1.Columns[8].Width = 90;
            dgv1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                    using (OleDbCommand cmd = new OleDbCommand("Select * FROM T_1 WHERE ENTREE LIKE '%" + SRCH_BTN.Text.Trim() + "%'", con))
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

                                lbl_counttt.Text = search_count.ToString();
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
            type_search();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            OleDbConnection con = new OleDbConnection(conString);
            OleDbCommand cmd = new OleDbCommand(type_search(), con);
            //OleDbCommand cmd = new OleDbCommand("Select * FROM T_1", con);
            //OleDbCommand cmd = new OleDbCommand("Select id,NOM,PNOM,DATE_N,ENGAGEMENT,CHANTIER,DUREE,ENTREE,SORTIE FROM T_1", con);

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
                int search_count = dds2.Rows.Count;
                lbl_counttt.Text = search_count.ToString();
                BindingSource bsr = new BindingSource();
                bsr.DataSource = dds2;
                dgv1.DataSource = bsr;
                //dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgv1_set_columns();
                REFRESH_SCROLLBAR();
                //sda.Update(dds2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string type_search()
        {
            string type_of_search = guna2ComboBox1.Text;

            switch (type_of_search)
            {
                case "Nom":
                    cmd_string_type_search = "Select id,NOM,PNOM,DATE_N,ENGAGEMENT,CHANTIER,DUREE,ENTREE,SORTIE FROM T_1  WHERE NOM LIKE '%" + SRCH_BTN.Text.Trim() + "%'";
                    break;
                case "Prénom":
                    cmd_string_type_search = "Select id,NOM,PNOM,DATE_N,ENGAGEMENT,CHANTIER,DUREE,ENTREE,SORTIE FROM T_1  WHERE PNOM LIKE '%" + SRCH_BTN.Text.Trim() + "%'";
                    break;
                case "Engagement":
                    cmd_string_type_search = "Select id,NOM,PNOM,DATE_N,ENGAGEMENT,CHANTIER,DUREE,ENTREE,SORTIE FROM T_1  WHERE ENGAGEMENT LIKE '%" + SRCH_BTN.Text.Trim() + "%'";
                    break;
                case "Chantier":
                    cmd_string_type_search = "Select id,NOM,PNOM,DATE_N,ENGAGEMENT,CHANTIER,DUREE,ENTREE,SORTIE FROM T_1  WHERE CHANTIER LIKE '%" + SRCH_BTN.Text.Trim() + "%'";
                    break;

            }
            return cmd_string_type_search;
        }
        private void MetroButton1_Click(object sender, EventArgs e)
        {





        }
        public void open_frm_popup(EventArgs    e)
        {
            Form formbk = new Form();
            frm_SEARCH frmsh = new frm_SEARCH();
            try
            {
                using (AT2 uu = new AT2())
                {
                    formbk.StartPosition = FormStartPosition.Manual;
                    formbk.FormBorderStyle = FormBorderStyle.None;
                    formbk.Opacity = .50d;
                    formbk.BackColor = Color.Black;
                    formbk.Size = this.Size;
                    formbk.TopMost = true;
                    formbk.Location = this.Location;
                    formbk.ShowInTaskbar = false;
                    formbk.Show();
                    uu.Owner = formbk;
                    uu.ShowDialog();
                    formbk.Dispose();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formbk.Dispose();
            }
        }

        private void Dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            open_frm_popup(e);
        }

        private void Dgv1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {

                vS1.Value = e.NewValue;


            }
        }

        private void Dgv1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                label3.Text = value1;
                Save_Class.Instance.SC_id_employer = int.Parse(row.Cells[0].Value.ToString());
                //...
            }
        }

        private void VS1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue > -1 && e.NewValue < dgv1.Rows.Count)
            {
                dgv1.FirstDisplayedScrollingRowIndex = e.NewValue;
            }
        }
        public void REFRESH_SCROLLBAR()
        {

            //bunifuLabel6.Text = b2unifuDataGridView1.RowCount.ToString();
            vS1.Value = 0;
            vS1.Update();
            vS1.Maximum = dgv1.Rows.Count;
            vS1.Update();
            //bunifuLabel1.Text = b2unifuDataGridView1.Rows.Count.ToString();
        }

        private void Guna2CircleButton1_Click(object sender, EventArgs e)
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
