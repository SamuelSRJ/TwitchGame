using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfa_Twitch
{
    public partial class frmResultadoFinal : Form
    {
        public frmResultadoFinal(int resFinalS, int resFinalC)
        {
            InitializeComponent();

            pcbStreamerGanhou.Visible = false;
            pcbChatGanhou.Visible = false;

            if (resFinalS > 9)
            {
                pcbStreamerGanhou.Visible = true;
            }
            else if (resFinalC > 9)
            {
                pcbChatGanhou.Visible = true;
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
