using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimasArtes
{
    public partial class frmSPLASH : Form
    {
        public frmSPLASH()
        {
            InitializeComponent();
        }

        private void tmrPROGRESS_Tick(object sender, EventArgs e)
        {
            if (progressSPLASH.Value < 100)
            {
                progressSPLASH.Value += 2;
            }
            else
            {
                tmrPROGRESS.Enabled = false;
                Visible = false;
                frmLOGIN loginInterface = new frmLOGIN();
                loginInterface.Show();
            }
        }
    }
}
