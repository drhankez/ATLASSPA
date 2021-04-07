using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class _05_SEARCH : Form
    {

        static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb";

        public _05_SEARCH()
        {
            InitializeComponent();
            style_of_dgv1();
            this.b2unifuDataGridView1.MouseWheel += new MouseEventHandler(mousewheel);
        }
        private void mousewheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta > 0 && b2unifuDataGridView1.FirstDisplayedScrollingRowIndex > 0)
                {
                    b2unifuDataGridView1.FirstDisplayedScrollingRowIndex--;
                }
                else if (e.Delta < 0)
                {
                    b2unifuDataGridView1.FirstDisplayedScrollingRowIndex++;
                }
            }
            catch
            {

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Home_Page();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        }

        private void BunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                //MessageBox.Show("F1 pressed");
                bunifuTextBox1.SelectAll();
            }
            if (e.KeyCode == Keys.Enter)
            {

                Stopwatch sw;
                sw = Stopwatch.StartNew();
                SEARCH_IN_DB();

            }
        }
        private void style_of_dgv1()
        {
            b2unifuDataGridView1.AutoGenerateColumns = true;
            b2unifuDataGridView1.EnableHeadersVisualStyles = false;
            b2unifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.b2unifuDataGridView1.Columns.Add("id", "ID");
            this.b2unifuDataGridView1.Columns.Add("NOM", "Nom");
            this.b2unifuDataGridView1.Columns.Add("PNOM", "Pénom");
            this.b2unifuDataGridView1.Columns.Add("DATE_N", "Né Le");
            this.b2unifuDataGridView1.Columns.Add("LIEU_N", "Lieu De Naissance");
            this.b2unifuDataGridView1.Columns.Add("DEMEURANT", "DUMERANT DE");
            this.b2unifuDataGridView1.Columns.Add("ENGAGEMENT", "FONCTION");
            this.b2unifuDataGridView1.Columns.Add("DUREE", "DURÉE");
            this.b2unifuDataGridView1.Columns.Add("ENTREE", "DATE D'EMBAUCHE");
            this.b2unifuDataGridView1.Columns.Add("SORTIE", "FIN DU CONTRAT");
            this.b2unifuDataGridView1.Columns.Add("CHANTIER", "CHANTIER");
            this.b2unifuDataGridView1.Columns.Add("SALAIRE", "SALAIRE");
            this.b2unifuDataGridView1.Columns.Add("NMR_ASSU", "N ASSURANCE S");
            this.b2unifuDataGridView1.Columns.Add("SITUATION_F", "S FAMILIALE");
            this.b2unifuDataGridView1.Columns.Add("NBR_ENF", "N D'ENFANT");
            this.b2unifuDataGridView1.Columns.Add("NMR_ADH", "GR");
            this.b2unifuDataGridView1.Columns.Add("GR_S", "ETTE");
            this.b2unifuDataGridView1.Columns.Add("TELEPH", "TELEPHONE");
            this.b2unifuDataGridView1.Columns.Add("EMAIL_", "EMAIL");
            this.b2unifuDataGridView1.Columns.Add("SINF_", "img");
            this.b2unifuDataGridView1.Columns.Add("ETAT_CONTR", "1");
            this.b2unifuDataGridView1.Columns.Add("CONTRAT_TYPE", "2");
            this.b2unifuDataGridView1.Columns.Add("DATE_REAL", "3");
            this.b2unifuDataGridView1.Columns.Add("IMG", "4");
            this.b2unifuDataGridView1.Columns.Add("GENDER", "5");
            b2unifuDataGridView1.ClearSelection();

        }
        private void populate1(string I, string N, string P, string LN, string DM, string EG, string DRE, string EMB, string SRT, string CHNT, string SALR, string NASS, string SITF, string NMBRE, string NADH, string GPRH, string TELEPHONE, string EMAIL, string ETTE, string immg)
        {
            //ROW
            String[] row = { I, N, P, LN, DM, EG, DRE, EMB, SRT, CHNT, SALR, NASS, SITF, NMBRE, NADH, GPRH, TELEPHONE, EMAIL, ETTE, immg };
            b2unifuDataGridView1.Rows.Add(row);
        }

        private void SEARCH_IN_DB()
        {
            try
            {
                b2unifuDataGridView1.Rows.Clear();
                OleDbDataAdapter da = new OleDbDataAdapter();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                using (OleDbConnection con = new OleDbConnection(conString))
                {
                    using (OleDbCommand cmd = new OleDbCommand("Select * FROM T_1 WHERE NOM LIKE '%" + bunifuTextBox1.Text.Trim() + "%'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                        {
                            using (DataTable dds = new DataTable())
                            {
                                sda.Fill(dds);
                                b2unifuDataGridView1.ClearSelection();
                                //int search_count = dds.Rows.Count;

                                foreach (DataRow row in dds.Rows)
                                {
                                    //byte[] imgBytes = (byte[])row[23];
                                    //TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                                    //Bitmap MyBitmap = (Bitmap)tc.ConvertFrom(imgBytes);
                                    //string imgString = Convert.ToBase64String(imgBytes);
                                    //imgLogoCompany.Src = String.Format("data:image/Bmp;base64,{0}\"", imgString);
                                    populate1(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString().Split('@').Last(), row[7].ToString().Split('@').Last(), row[8].ToString().Split('@').Last(), row[9].ToString().Split('@').Last(), row[10].ToString().Split('@').Last(), row[11].ToString().Split('@').Last(), row[12].ToString(), row[13].ToString(), row[14].ToString(), row[15].ToString(), row[16].ToString(), row[17].ToString(), row[18].ToString(), row[18].ToString());
                                }
                                dds.Dispose();
                                sda.Dispose();
                            }
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                REFRESH_SCROLLBAR();
            }

            catch (Exception ex)
            {
                MessageBox.Show("REFRESH_SCROLLBAR" + ex.Message);
            }

        }

        public void REFRESH_SCROLLBAR()
        {

            bunifuLabel6.Text = b2unifuDataGridView1.RowCount.ToString();
            vS1.Value = 0;
            vS1.Update();
            vS1.Maximum = b2unifuDataGridView1.Rows.Count;
            vS1.Update();
            bunifuLabel1.Text = b2unifuDataGridView1.Rows.Count.ToString();
        }

        private void _05_SEARCH_Load(object sender, EventArgs e)
        {

        }







        private void B2unifuDataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                vS1.Value = e.NewValue;
            }
        }


        private void VScrollBar2_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (e.NewValue > -1 && e.NewValue < b2unifuDataGridView1.Rows.Count)
            {
                b2unifuDataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue;
            }
        }

        private void B2unifuDataGridView1_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
            }
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                vS1.Value = e.NewValue;
            }
        }

        private void B2unifuDataGridView1_Scroll_2(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {

                vS1.Value = e.NewValue;


            }
        }




        public void open_frm_popup(EventArgs e)
        {

            Form formbk = new Form();
            frm_SEARCH frmsh = new frm_SEARCH();
            try
            {
                using (T2 uu = new T2())
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

        private void B2unifuDataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            open_frm_popup(e);
        }

        private void B2unifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in b2unifuDataGridView1.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                bunifuLabel6.Text = value1;
                Save_Class.Instance.SC_id_employer = int.Parse (row.Cells[0].Value.ToString());
                //...
            }
        }

        private void _05_SEARCH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("F1 pressed");
            }
        }
    }
}
