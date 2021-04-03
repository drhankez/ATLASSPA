using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class frm_SEARCH : Form
    {
        public frm_SEARCH()
        {
            InitializeComponent();
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
            test_Form1 popop = new test_Form1();
            new PopupEffect.transparentBg(popop);

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
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formbk.Dispose();
            }
        }
    }
}
