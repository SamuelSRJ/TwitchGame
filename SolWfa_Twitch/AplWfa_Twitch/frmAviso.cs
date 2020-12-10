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
    public partial class frmAviso : Form
    {
        public frmAviso()
        {
            InitializeComponent();
        }

        private void mouseINsim(object sender, EventArgs e)
        {
            btnSim.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSimHover;
        }

        private void mouseOUTsim(object sender, EventArgs e)
        {
            btnSim.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSim;
        }

        private void mouseINnao(object sender, EventArgs e)
        {
            btnNao.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnNaoHover;
        }

        private void mouseOUTnao(object sender, EventArgs e)
        {
            btnNao.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnNao;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
