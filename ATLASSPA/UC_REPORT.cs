using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace ATLASSPA
{
    public partial class UC_REPORT : UserControl
    {
        public UC_REPORT()
        {
            InitializeComponent();
        }

        private void UC_REPORT_Load(object sender, EventArgs e)
        {
            bunifuTransition14.ShowSync(panel1);
            ReportParameter param = new ReportParameter();
            ReportParameterCollection rdlcpara = new ReportParameterCollection();
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            rdlcpara.Add(new ReportParameter("Nom", Save_Class.Instance.SC_NOM_employer));
            rdlcpara.Add(new ReportParameter("prenom", Save_Class.Instance.SC_PNOM_employer));
            //DATE DE NAISSENCE CHCK FORMAT AND VALID AND CONVERT
            rdlcpara.Add(new ReportParameter("date_de_naissance", Save_Class.Instance.SC_DATE_N_employer));
            rdlcpara.Add(new ReportParameter("lieu_de_naissance", Save_Class.Instance.SC_LIEU_N_employer));
            //Demeurant
            rdlcpara.Add(new ReportParameter("demeurant", Save_Class.Instance.SC_DEMEURANT_employer));
            //Engagement  
            rdlcpara.Add(new ReportParameter("Engagement", Save_Class.Instance.SC_ENGAGEMENT_employer));
            //contrat à durée 
            rdlcpara.Add(new ReportParameter("xx_mois", Save_Class.Instance.SC_DUREE_employer));
            //à partir du 
            rdlcpara.Add(new ReportParameter("entree__", Save_Class.Instance.SC_ENTREE_employer));
            //jusqu'a
            rdlcpara.Add(new ReportParameter("sortie___", Save_Class.Instance.SC_SORTIE_employer));
            //lieu__________de_travail
            rdlcpara.Add(new ReportParameter("lieu__________de_travail", Save_Class.Instance.SC_CHANTIER_employer));
            //
            //salaire
            rdlcpara.Add(new ReportParameter("salaire", Save_Class.Instance.SC_SALAIRE_employer));
            rdlcpara.Add(new ReportParameter("MMESSAI", "period_de_essai"));
            rdlcpara.Add(new ReportParameter("PDESSAI__", "date_de_essai"));
            rdlcpara.Add(new ReportParameter("appo", "apoostroph"));
            rdlcpara.Add(new ReportParameter("ele", "ele"));
            rdlcpara.Add(new ReportParameter("pp", "pp"));
            rdlcpara.Add(new ReportParameter("situationn", Save_Class.Instance.SC_SITUATION_F_employer));
            //reportViewer1.LocalReport.EnableExternalImages = true;
            string imagePath = new Uri(Save_Class.Instance.SC_IMG_employer).AbsoluteUri;
            rdlcpara.Add(new ReportParameter("ImagePath", imagePath));
            //this.reportViewer1.ZoomMode = ZoomMode.Percent;
            //this.reportViewer1.ZoomPercent = 68;
            //        var setup = reportViewer1.GetPageSettings();
            //          setup.Margins = new System.Drawing.Printing.Margins(40, 40, 40, 40);
            //this.reportViewer1.SetPageSettings(setup);
            this.reportViewer1.LocalReport.SetParameters(rdlcpara);
            this.reportViewer1.ZoomMode = ZoomMode.PageWidth;
            this.reportViewer1.RefreshReport();
            

        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
