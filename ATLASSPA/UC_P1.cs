using System.Windows.Forms;

namespace ATLASSPA
{
    public partial class UC_P1 : UserControl
    {
        public UC_P1()
        {
            InitializeComponent();
            bunifuLabel1.Text = Save_Class.Instance.SC_id_employer.ToString();
        }
    }
}
