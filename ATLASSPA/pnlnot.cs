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
    public partial class pnlnot : UserControl
    {
        public pnlnot()
        {
            InitializeComponent();
        }

        public double Opacity { get; private set; }

        private void Pnlnot_Load(object sender, EventArgs e)
        {
            timer987.Interval = 1;
            this.Opacity -= 0.1;
        }
    }
}
