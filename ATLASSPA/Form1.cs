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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {

            string connStr = "Provider = Microsoft.Jet.Oledb.4.0; Data Source = " + AppDomain.CurrentDomain.BaseDirectory + "\\ATLAS_DB.mdb";
            string query = "Select * FROM T_1 WHERE NOM LIKE '%" + "" + "%'";
            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    bunifuDataGridView1.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
