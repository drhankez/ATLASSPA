using MaterialSkin;
using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class frm_SEARCH : Form// MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager skinManager;
        static string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb";
        OleDbConnection con = new OleDbConnection(conString);
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataTable dt = new DataTable();
        DataTable dt00b;
        DataSet ds = new DataSet();
        public DataSet dataset = new DataSet();
        public DataTable datatbl = new DataTable();
        public DataTable dds = new DataTable();
        public int scrollPosition = 0;
        // bunif
        public frm_SEARCH()
        {
            InitializeComponent();
            //this.bunifuDataGridView1.ScrollBars = ScrollBars.None;
            this.bunifuDataGridView1.MouseWheel += new MouseEventHandler(mousewheel);
            //this.bunifuDataGridView1.VerticalScrollingOffset += new MouseEventHandler(mousewheejl);
            // bunifuVScrollBar1.ValueChanged += new EventHandler(vbar_OnValueChanged);

            //pictureBox2.Visible = false;
            //vScrollBar1.Minimum = 0;



            //local_fii_data();

        }

        //VScrollBar 
        /* private void vbar_OnValueChanged(object sender, EventArgs e)
         {
             pb.Location = new Point(pb.Left, (pnl.Size.Height - img.Size.Height) * vbar.Value / (vbar.Maximum - vbar.LargeChange + 1));
         }*/
        private void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0 && bunifuDataGridView1.FirstDisplayedScrollingRowIndex > 0)
            {
                bunifuDataGridView1.FirstDisplayedScrollingRowIndex--;
            }
            else if (e.Delta < 0)
            {
                bunifuDataGridView1.FirstDisplayedScrollingRowIndex++;
            }
        }
        public void local_fii_data()
        {
            {
                //pictureBox2.Visible = true;
                //bunifuDataGridView1.Rows.Clear();
                //da = new OleDbDataAdapter();
                //cmd = new OleDbCommand();
                //DataTable dt = new DataTable();
                //ds = new DataSet();
                //using ()
                using (OleDbConnection con = new OleDbConnection(conString))
                {
                    using (OleDbCommand cmd = new OleDbCommand("Select * FROM T_1 WHERE NOM LIKE '%" + "" + "%'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                        {
                            using (dds)
                            {
                                sda.Fill(dds);
                                sda.Fill(dataset);
                                int search_count = dds.Rows.Count;
                                label4.Text = search_count.ToString();
                                /*foreach (DataRow row in dds.Rows)
                                {
                                    //byte[] imgBytes = (byte[])row[23];
                                    //TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                                    //Bitmap MyBitmap = (Bitmap)tc.ConvertFrom(imgBytes);
                                    //string imgString = Convert.ToBase64String(imgBytes);
                                    //imgLogoCompany.Src = String.Format("data:image/Bmp;base64,{0}\"", imgString);
                                    populate1(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString().Split('@').Last(), row[7].ToString().Split('@').Last(), row[8].ToString().Split('@').Last(), row[9].ToString().Split('@').Last(), row[10].ToString().Split('@').Last(), row[11].ToString().Split('@').Last(), row[12].ToString(), row[13].ToString(), row[14].ToString(), row[15].ToString(), row[16].ToString(), row[17].ToString(), row[18].ToString(), row[18].ToString());
                                }*/

                            }
                        }

                    }
                }
                //throw new NotImplementedException();

            }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Home_Page();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
        //Popupeffect

        public void asap()
        {
            bunifuDataGridView1.Rows.Clear();
            //bunifuDataGridView1.DataSource = null;
            bunifuDataGridView1.Refresh();
            //DataRow[] filtreredrow = dds.Select("NOM LIKE '%" + "" + "%'");
            //bunifuDataGridView1.DataSource = dds.Select("NOM LIKE '%" + "y" + "%'");
            //bunifuDataGridView1.Rows.Add(dds.Select("NOM LIKE '%" + "" + "%'"));
            DataView dv = new DataView();
            //dv = new DataView(dds, "NOM", "NOM", DataViewRowState.CurrentRows);
            dv.Table = dataset.Tables[0];
            bunifuDataGridView1.DataSource = dv;
            bunifuDataGridView1.ClearSelection();

        }
        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            Form formbk = new Form();
            frm_SEARCH frmsh = new frm_SEARCH();
            try
            {
                using (test_Form1 uu = new test_Form1())
                {
                    formbk.StartPosition = FormStartPosition.Manual;
                    formbk.FormBorderStyle = FormBorderStyle.None;
                    formbk.Opacity = .50d;
                    formbk.BackColor = Color.Black;
                    formbk.Size = this.Size;
                    //formbk.WindowState = FormWindowState.Maximized;
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

        private void populate1(string I, string N, string P, string LN, string DM, string EG, string DRE, string EMB, string SRT, string CHNT, string SALR, string NASS, string SITF, string NMBRE, string NADH, string GPRH, string TELEPHONE, string EMAIL, string ETTE, string immg)
        {
            //ROW
            String[] row = { I, N, P, LN, DM, EG, DRE, EMB, SRT, CHNT, SALR, NASS, SITF, NMBRE, NADH, GPRH, TELEPHONE, EMAIL, ETTE, immg };
            //ListViewItem item = new ListViewItem(row);
            //materialListView1.Items.Add(item);
            bunifuDataGridView1.Rows.Add(row);
        }




        private void search_method()
        {
            bunifuDataGridView1.Rows.Clear();
            da = new OleDbDataAdapter();
            cmd = new OleDbCommand();
            DataTable dt = new DataTable();
            ds = new DataSet();

            //bunifuDataGridView1.Refresh();
            con.Open();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "Select * FROM T_1 WHERE NOM LIKE '%" + bunifuTextBox1.Text.Trim() + "%'";//bunifuTextBox9.Text.ToString() + "%'";
                da.SelectCommand = cmd;
                //DataView dataview1 = new DataView();
                //con.Open();
                //da.Fill(ds);
                da.Fill(dt);
                con.Close();

                //dataview1.Table = dt;
                //bunifuDataGridView1.
                //bunifuDataGridView1.DataSource = ds.Tables["T_1"];
                //ds.Tables["T_1"]
                //bunifuDataGridView1.DataSource = sbind;

                //dataview1.Sort = "[id],[NOM]";

                //bunifuDataGridView1.DataSource = null;
                //materialListView1.Items.Clear();
                //bunifuDataGridView1.Rows.Clear();
                bunifuDataGridView1.Refresh();
                bunifuDataGridView1.ClearSelection();

                int search_count = dt.Rows.Count;
                label4.Text = search_count.ToString();




                foreach (DataRow row in dt.Rows)
                {
                    //byte[] imgBytes = (byte[])row[23];
                    //TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
                    //Bitmap MyBitmap = (Bitmap)tc.ConvertFrom(imgBytes);
                    //string imgString = Convert.ToBase64String(imgBytes);
                    //imgLogoCompany.Src = String.Format("data:image/Bmp;base64,{0}\"", imgString);
                    populate1(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString().Split('@').Last(), row[7].ToString().Split('@').Last(), row[8].ToString().Split('@').Last(), row[9].ToString().Split('@').Last(), row[10].ToString().Split('@').Last(), row[11].ToString().Split('@').Last(), row[12].ToString(), row[13].ToString(), row[14].ToString(), row[15].ToString(), row[16].ToString(), row[17].ToString(), row[18].ToString(), row[18].ToString());
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //da.Dispose();



        }
        private void Frm_SEARCH_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.AutoGenerateColumns = true;
            bunifuDataGridView1.EnableHeadersVisualStyles = false;
            dtgv1.AutoGenerateColumns = true;
            dtgv1.EnableHeadersVisualStyles = false;
            //bunifuDataGridView1.DataSource = ds.Tables["T_1"];
            //dtgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //bunifuDataGridView1.Columns[1].HeaderCell.Value = "الرقم";
            // this.bunifuDataGridView1.Columns.Add("hh", "jjj");

            /*this.dtgv1.Columns.Add("id", "ID");
            this.dtgv1.Columns.Add("NOM", "Nom");
            this.dtgv1.Columns.Add("PNOM", "Pénom");
            this.dtgv1.Columns.Add("DATE_N", "Né Le");
            this.dtgv1.Columns.Add("LIEU_N", "Lieu De Naissance");
            this.dtgv1.Columns.Add("DEMEURANT", "DUMERANT DE");
            this.dtgv1.Columns.Add("ENGAGEMENT", "FONCTION");*/
            this.bunifuDataGridView1.Columns.Add("DUREE", "DURÉE");
            this.bunifuDataGridView1.Columns.Add("ENTREE", "DATE D'EMBAUCHE");
            this.bunifuDataGridView1.Columns.Add("SORTIE", "FIN DU CONTRAT");
            this.bunifuDataGridView1.Columns.Add("CHANTIER", "CHANTIER");
            this.bunifuDataGridView1.Columns.Add("SALAIRE", "SALAIRE");
            this.bunifuDataGridView1.Columns.Add("NMR_ASSU", "N ASSURANCE S");
            this.bunifuDataGridView1.Columns.Add("SITUATION_F", "S FAMILIALE");
            this.bunifuDataGridView1.Columns.Add("NBR_ENF", "N D'ENFANT");
            this.bunifuDataGridView1.Columns.Add("NMR_ADH", "GR");
            this.bunifuDataGridView1.Columns.Add("GR_S", "ETTE");
            this.bunifuDataGridView1.Columns.Add("TELEPH", "TELEPHONE");
            this.bunifuDataGridView1.Columns.Add("EMAIL_", "EMAIL");
            this.bunifuDataGridView1.Columns.Add("SINF_", "img");
            this.bunifuDataGridView1.Columns.Add("ETAT_CONTR", "1");
            this.bunifuDataGridView1.Columns.Add("CONTRAT_TYPE", "2");
            this.bunifuDataGridView1.Columns.Add("DATE_REAL", "3");
            this.bunifuDataGridView1.Columns.Add("IMG", "4");
            this.bunifuDataGridView1.Columns.Add("GENDER", "GENDERGENDER");
            bunifuDataGridView1.ClearSelection();

            //stylelistview();

        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {

            //BINDGRID();
            //ding();
            //search_method();
            bunifuDataGridView1.ClearSelection();

            bunifuDataGridView1.Rows.Clear();
            bunifuDataGridView1.Refresh();
            Stopwatch sw;
            sw = Stopwatch.StartNew();
            BINDGRID();
            materialLabel1.Text = materialLabel1.Text + " time = " + sw.ElapsedMilliseconds;

        }
        private void ding()
        {
            //MetroFramework.metroli
            con = new OleDbConnection("Provider =Microsoft.Jet.Oledb.4.0; Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb");
            da = new OleDbDataAdapter("SElect *from T_1 ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "T_1");
            //da.Fill(ds, "T_1");
            bunifuDataGridView1.AutoGenerateColumns = true;
            bunifuDataGridView1.EnableHeadersVisualStyles = false;
            bunifuDataGridView1.DataSource = ds.Tables["T_1"];
            bunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            con.Close();
        }
        private void BINDGRID()
        {
            //pictureBox2.Visible = true;

            try
            {

                bunifuDataGridView1.Rows.Clear();
                //bunifuVScrollBar1.Value = 0;
                da = new OleDbDataAdapter();
                //cmd = new OleDbCommand();
                DataTable dt = new DataTable();
                ds = new DataSet();
                //using ()
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
                                bunifuDataGridView1.ClearSelection();
                                // sda.Fill(this.dds."T_1");
                                int search_count = dds.Rows.Count;
                                label4.Text = search_count.ToString();

                                //bunifuVScrollBar1.Maximum = bunifuDataGridView1.RowCount;
                                /*if (search_count > 8)
                                {
                                    bunifuVScrollBar1.Maximum = search_count;
                                }
                                else
                                {
                                    bunifuVScrollBar1.Maximum = 8;
                                }*/
                                //bunifuVScrollBar1.Maximum = search_count;
                                //vScrollBar1.Maximum = search_count;
                                //vScrollBar1.Minimum = 0;
                                //metroScrollBMINar1.Maximum = search_count+1;
                                //bunifuDataGridView1.Update();
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
                    //pictureBox2.Visible = false;
                    //Thread.Sleep(5000);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {


        }

        private void BunifuTextBox1_KeyDownAsync(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //label1.Text = bunifuVScrollBar1.Maximum.ToString();
                //this.bunifuVScrollBar1.Maximum = 1;
                //label2.Text = bunifuVScrollBar1.Maximum.ToString();
                //bunifuVScrollBar1.Update();
                //label3.Text = bunifuVScrollBar1.Maximum.ToString();
                bunifuDataGridView1.Rows.Clear();
                //label4.Text = bunifuVScrollBar1.Maximum.ToString();
                //label5.Text = bunifuVScrollBar1.Maximum.ToString();
                //bunifuDataGridView1.Refresh();
                //e.KeyValue = 0;
                Stopwatch sw;
                sw = Stopwatch.StartNew();

                //await  BINDGRID();

                BINDGRID();
                materialLabel1.Text = materialLabel1.Text + " time = " + sw.ElapsedMilliseconds;

                //bunifuVScrollBar1.LargeChange = bunifuDataGridView1.DisplayedRowCount(true);
                //vScrollBar1.SmallChange = 1;
                try
                {
                    //bunifuVScrollBar1.PerformLayout();
                    //bunifuVScrollBar1.Maximum = bunifuDataGridView1.RowCount - 8;
                    //bunifuVScrollBar1.Minimum = 0;
                    //bunifuDataGridView1.FirstDisplayedScrollingRowIndex = scrollPosition;



                }
                catch (Exception ex)
                {
                    if (bunifuDataGridView1.RowCount != 0)
                    {
                        MessageBox.Show(ex.Message + "hi");
                        //bunifuVScrollBar1.PerformLayout();
                        //bunifuVScrollBar1.Value = 1;
                        //bunifuVScrollBar1.Maximum = 1;
                        //bunifuVScrollBar1.Minimum = 0;
                        bunifuDataGridView1.FirstDisplayedScrollingRowIndex = scrollPosition;
                    }


                }
            }
        }



        private void HScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            bunifuDataGridView1.FirstDisplayedScrollingRowIndex = e.Value;
        }


        private void BunifuDataGridView1_Scroll(object sender, ScrollEventArgs e)
        {

            // While scrolling, keep track of the scroll position
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                this.scrollPosition = e.NewValue;
            }
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {

                //vScrollBar1.Value = e.NewValue;
                //bunifuVScrollBar1.Value = vScrollBar1.Value;


            }


        }

        private void BunifuDataGridView1_Resize(object sender, EventArgs e)
        {


        }

        private void BunifuDataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void BunifuButton1_Click_1(object sender, EventArgs e)
        {
            //bunifuVScrollBar1.BindTo(bunifuDataGridView1);
        //    label7.Text = bunifuVScrollBar1.Maximum.ToString();
        }



        public void BunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            try
            {
                bunifuDataGridView1.FirstDisplayedScrollingRowIndex = e.Value;//
                label7.Text = e.Value.ToString();
                label6.Text = scrollPosition.ToString();

            }
            catch
            {

            }


            //bunifuDataGridView1.Rows[bunifuDataGridView1.FirstDisplayedScrollingRowIndex].Height = e.Value;
            // bunifuDataGridView1.VerticalScrollingOffset = e.Value;
            //bunifuDataGridView1.Rows[bunifuDataGridView1.FirstDisplayedScrollingRowIndex].Height = e.Value;


        }

        private void MetroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            bunifuDataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue;
            label5.Text = e.NewValue.ToString();

        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            bunifuDataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void BunifuButton5_Click(object sender, EventArgs e)
        {
            //OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            OleDbConnection con = new OleDbConnection(conString);
            OleDbCommand cmd = new OleDbCommand("Select id,NOM,PNOM,DATE_N,LIEU_N,ENGAGEMENT,DUREE FROM T_1", con);
            //OleDbCommand cmd = new OleDbCommand("Select * FROM T_1", con);
            try
            {
                OleDbDataAdapter sda = new OleDbDataAdapter();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                BindingSource bsr = new BindingSource();
                bsr.DataSource = dt;
                dtgv1.DataSource = bsr;
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //dtgv1.AutoResizeColumns();

            dtgv1.AutoGenerateColumns = true;
            //dtgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dtgv1.Columns[0].HeaderCell.Value = "ID";
            dtgv1.Columns[0].Width = 40;
            dtgv1.Columns[1].HeaderCell.Value = "Nom";
            dtgv1.Columns[1].Width = 120;
        }
    }
   
}
/*
             this.bunifuDataGridView1.Columns.Add("id", "ID");
            this.bunifuDataGridView1.Columns.Add("NOM", "Nom");
            this.bunifuDataGridView1.Columns.Add("PNOM", "Pénom");
            this.bunifuDataGridView1.Columns.Add("DATE_N", "Né Le");
            this.bunifuDataGridView1.Columns.Add("LIEU_N", "Lieu De Naissance");
            this.bunifuDataGridView1.Columns.Add("DEMEURANT", "DUMERANT DE");
            this.bunifuDataGridView1.Columns.Add("ENGAGEMENT", "FONCTION");
            this.bunifuDataGridView1.Columns.Add("DUREE", "DURÉE");
            this.bunifuDataGridView1.Columns.Add("ENTREE", "DATE D'EMBAUCHE");
            this.bunifuDataGridView1.Columns.Add("SORTIE", "FIN DU CONTRAT");
            this.bunifuDataGridView1.Columns.Add("CHANTIER", "CHANTIER");
 */
