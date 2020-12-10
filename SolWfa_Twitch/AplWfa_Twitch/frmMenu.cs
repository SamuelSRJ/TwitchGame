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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        //************************************************************************************
        //******************************** EVENTOS *******************************************
        //************************************************************************************

        private void mouseINjogar(object sender, EventArgs e)
        {
            btnJogar.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnJogarHover;
        }

        private void mouseOUTjogar(object sender, EventArgs e)
        {
            btnJogar.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnJogar;
        }

        private void mouseINopcoes(object sender, EventArgs e)
        {
            btnOpcoes.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSettingsHover;
        }

        private void mouseOUTopcoes(object sender, EventArgs e)
        {
            btnOpcoes.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSettings;
        }

        private void mouseINsair(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSairHover;
        }

        private void mouseOUTsair(object sender, EventArgs e)
        {
            btnSair.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSair;
        }

        //*************************************************************************************
        //******************************** COMANDOS *******************************************
        //*************************************************************************************

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmAviso FormdeAviso = new frmAviso();
            FormdeAviso.ShowDialog();
        }

        private void btnOpcoes_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            frmOpcoes FormdeConf = new frmOpcoes();
            FormdeConf.ShowDialog();

            this.Visible = true;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            frmJogo FormdoJogo = new frmJogo();
            FormdoJogo.ShowDialog();

            this.Visible = true;
        }
    }
}
