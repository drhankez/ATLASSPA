﻿using MaterialSkin;
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
        public frm_SEARCH()
        {
            InitializeComponent();
            this.bunifuDataGridView1.ScrollBars = ScrollBars.None;
            this.bunifuDataGridView1.MouseWheel += new MouseEventHandler(mousewheel);

            //local_fii_data();

        }
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
        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            //test_Form1 popop = new test_Form1();
            //new PopupEffect.transparentBg(popop);
            //search_method();
            //sggg();
            asap();
        }
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
        /*public void stylelistview()
        {
            materialListView1.View = View.Details;
            materialListView1.FullRowSelect = true;
            //materialListView1.View = View.Details;
            //materialListView1.FullRowSelect = true;

            //ADD COLUMNS
            materialListView1.Columns.Add("ID", 45);
            materialListView1.Columns.Add("Nom", 120);
            materialListView1.Columns.Add("Pénom", 120);
            materialListView1.Columns.Add("Date De Naissance", 100);
            materialListView1.Columns.Add("Lieu De Naissance", 110);
            materialListView1.Columns.Add("DUMERANT DE", 100);
            materialListView1.Columns.Add("FONCTION", 130);
            materialListView1.Columns.Add("DURÉE", 50);
            materialListView1.Columns.Add("DATE D'EMBAUCHE", 140);
            materialListView1.Columns.Add("FIN DU CONTRAT", 140);
            materialListView1.Columns.Add("CHANTIER", 350);
            materialListView1.Columns.Add("SALAIRE", 60);
            materialListView1.Columns.Add("NUMERO ASSURANCE SOCIAL", 190);
            materialListView1.Columns.Add("SITUATION FAMILIALE", 140);
            materialListView1.Columns.Add("NOMBRE D'ENFANT", 120);
            materialListView1.Columns.Add("GROUPAGE", 80);
            materialListView1.Columns.Add("ETTE", 80);
            materialListView1.Columns.Add("TELEPHONE", 110);
            materialListView1.Columns.Add("EMAIL", 80);
            materialListView1.Columns.Add("img", 80);
            //listView1.AutoResizeColumn(8, ColumnHeaderAutoResizeStyle.HeaderSize);

            //listView1.AutoResizeColumn(9, ColumnHeaderAutoResizeStyle.ColumnContent);

            //listView1.AutoResizeColumn(8, Col.HeaderSize);
            /*  listView2.View = View.Details;
              listView2.FullRowSelect = true;

              //ADD COLUMNS
              listView2.Columns.Add("ID", 50);
              listView2.Columns.Add("Nom", 150);
              listView2.Columns.Add("Pénom", 150);
              listView2.Columns.Add("Date De Naissance", 150);
              listView2.Columns.Add("N De La Sécurité Sociale", 150);
              listView2.Columns.Add("FONCTION", 150);
              listView2.Columns.Add("SITUATION FAMILIALe", 150);
              listView2.Columns.Add("NUMBRE D'ENFANT", 150);
              listView2.Columns.Add("DATE D'EMBAUCHE", 150);
        }*/
        private void populate1(string I, string N, string P, string LN, string DM, string EG, string DRE, string EMB, string SRT, string CHNT, string SALR, string NASS, string SITF, string NMBRE, string NADH, string GPRH, string TELEPHONE, string EMAIL, string ETTE, string immg)
        {
            //ROW
            String[] row = { I, N, P, LN, DM, EG, DRE, EMB, SRT, CHNT, SALR, NASS, SITF, NMBRE, NADH, GPRH, TELEPHONE, EMAIL, ETTE, immg };
            //ListViewItem item = new ListViewItem(row);
            //materialListView1.Items.Add(item);
            bunifuDataGridView1.Rows.Add(row);
        }


        private void BunifuTextBox1_TextChange(object sender, EventArgs e)
        {

        }
        public void sggg()
        {
            con.Open();
            try
            {
                cmd = new OleDbCommand();
                dt = new DataTable();
                ds = new DataSet();

                cmd.Connection = con;
                cmd.CommandText = "Select * FROM T_1 WHERE NOM LIKE '%" + "" + "%'";//bunifuTextBox9.Text.ToString() + "%'";
                da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(datatbl);
                da.Fill(ds);
                bunifuDataGridView1.DataSource = ds.Tables[0];

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
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
                //da.Dispose();
                //dt.Dispose();
                /*foreach (DataRow row in dt.Rows)
{
    int column = 0;
    bunifuDataGridView1.Rows.Add();
    //int ya = row.ItemArray.Length;

    foreach (var dc in row.ItemArray)
    {
        //MessageBox.Show(ya.ToString());
        if (dc.ToString().IndexOf('@') != -1)
        {
            string coper = dc.ToString().Split('@').Last();
            bunifuDataGridView1.Rows[rowcount].Cells[column].Value = coper;
        }
        else
        {
            bunifuDataGridView1.Rows[rowcount].Cells[column].Value = dc;
        }


        column++;
    }
    rowcount++;
} 
}*/

                /*int rowcount = 0;
                foreach (DataRow row in dt.Rows)
                {
                    int column = 0;
                    bunifuDataGridView1.Rows.Add();
                    //int ya = row.ItemArray.Length;

                    foreach (var dc in row.ItemArray)
                    {
                        //MessageBox.Show(ya.ToString());
                       try
                        {
                            bunifuDataGridView1.Rows[rowcount].Cells[column].Value = dc.ToString().Split('@').Last();
                        }
                        catch
                        {
                            bunifuDataGridView1.Rows[rowcount].Cells[column].Value = dc;
                        }
                        

                        column++;
                    }
                    rowcount++;
                }*/
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
            //bunifuDataGridView1.DataSource = ds.Tables["T_1"];
            bunifuDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //bunifuDataGridView1.Columns[1].HeaderCell.Value = "الرقم";
            // this.bunifuDataGridView1.Columns.Add("hh", "jjj");

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
            this.bunifuDataGridView1.Columns.Add("GENDER", "5");
            //stylelistview();

        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {

            //BINDGRID();
            //ding();
            //search_method();
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
            bunifuDataGridView1.Rows.Clear();
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
                            // sda.Fill(this.dds."T_1");
                            int search_count = dds.Rows.Count;
                            label4.Text = search_count.ToString();
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
            //throw new NotImplementedException();

        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            Stopwatch sw;
            sw = Stopwatch.StartNew();

            bunifuDataGridView1.Rows.Clear();
            bunifuDataGridView1.Refresh();
            search_method();
            label3.Text = label3.Text + " time = " + sw.ElapsedMilliseconds;

        }

        private void BunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuDataGridView1.Rows.Clear();
                bunifuDataGridView1.Refresh();
                Stopwatch sw;
                sw = Stopwatch.StartNew();
                BINDGRID();
                materialLabel1.Text = materialLabel1.Text + " time = " + sw.ElapsedMilliseconds;
            }
        }



        private void HScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
            bunifuDataGridView1.FirstDisplayedScrollingRowIndex = e.Value;
        }
        private int scrollPosition = 0;

        private void BunifuDataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            // While scrolling, keep track of the scroll position
            /*if (e.ScrollOrientation == ScrollOrientation.HorizontalScroll)
            {
                this.scrollPosition = e.NewValue;
            }*/
            ///hScrollBar1.Value = e.NewValue;
            

        }

        private void BunifuDataGridView1_Resize(object sender, EventArgs e)
        {
            bunifuDataGridView1.HorizontalScrollingOffset = this.scrollPosition;
            //hScrollBar1.Maximum = bunifuDataGridView1.RowCount;

        }

        private void BunifuDataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
          
        }
    }
}