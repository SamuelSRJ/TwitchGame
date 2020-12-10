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
    public partial class frmJogo : Form
    {
        // Projeto adicionado ao GitHub
        // *******************  V A R I A V E I S *******************
        int escolhaStreamer = 0;
        int scoreS = 0;
        int scoreC = 0;
        int escolhaChat = 0;

        public frmJogo()
        {
            InitializeComponent();
        }


        private void btnPedra_Click(object sender, EventArgs e)
        {
            btnPedra.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnPedraSelected;
            btnPapel.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnPapel;
            btnTesoura.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnTesoura;
            escolhaStreamer = 1;
            cont = 0;
            pcblblChatNao.Visible = false;
            pcblblChatSim.Visible = false;
            btnContinuar.Visible = false;
            if(tmrJogo.Enabled == false)
            {
                tmrJogo.Enabled = true;
            }
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            btnPedra.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnPedra;
            btnPapel.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnPapelSelected;
            btnTesoura.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnTesoura;
            escolhaStreamer = 2;
            cont = 0;
            pcblblChatNao.Visible = false;
            pcblblChatSim.Visible = false;
            btnContinuar.Visible = false;
            if (tmrJogo.Enabled == false)
            {
                tmrJogo.Enabled = true;
            }
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            btnPedra.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnPedra;
            btnPapel.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnPapel;
            btnTesoura.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnTesouraSelected;
            escolhaStreamer = 3;
            cont = 0;
            pcblblChatNao.Visible = false;
            pcblblChatSim.Visible = false;
            btnContinuar.Visible = false;
            if (tmrJogo.Enabled == false)
            {
                tmrJogo.Enabled = true;
            }
        }

        int cont;
        private void tmrJogo_Tick(object sender, EventArgs e)
        {
            cont++;
            if(cont == 1)
            {
                pcblblChatNao.Visible = true;
            }
            if(cont == 3)
            {
                pcblblChatNao.Visible = false;
                pcblblChatSim.Visible = true;
            }
            if(cont == 4)
            {
                pcblblChatSim.Visible = false;
                btnContinuar.Visible = true;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            Random numRandom = new Random();
            escolhaChat = numRandom.Next(1, 4);

            // ==================================================================================================

            //         ************* Streamer escolhe Pedra *************
            if (escolhaStreamer == 1 && escolhaChat == 1)
            {

            }
            else if (escolhaStreamer == 1 && escolhaChat == 2)
            {

                if (scoreC < 10)
                {
                    scoreC++;
                }
            }
            else if (escolhaStreamer == 1 && escolhaChat == 3)
            {

                if (scoreS < 10)
                {
                    scoreS++;
                }
            }

            //         ************* Streamer escolhe Papel *************
            if (escolhaStreamer == 2 && escolhaChat == 1)
            {

                if (scoreS < 10)
                {
                    scoreS++;
                }
            }
            else if (escolhaStreamer == 2 && escolhaChat == 2)
            {

            }
            else if (escolhaStreamer == 2 && escolhaChat == 3)
            {

                if (scoreC < 10)
                {
                    scoreC++;
                }
            }

            //         ************* Streamer escolhe Tesoura *************
            if (escolhaStreamer == 3 && escolhaChat == 1)
            {

                if (scoreC < 10)
                {
                    scoreC++;
                }
            }
            else if (escolhaStreamer == 3 && escolhaChat == 2)
            {

                if (scoreS < 10)
                {
                    scoreS++;
                }
            }
            else if (escolhaStreamer == 3 && escolhaChat == 3)
            {

            }

            // ==================================================================================================================
            btnPedra.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnPedra;
            btnPapel.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnPapel;
            btnTesoura.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnTesoura;
            btnContinuar.Visible = false;

            this.Visible = false;

            frmResultado FormdoResultado = new frmResultado(escolhaStreamer, escolhaChat, scoreS, scoreC);
            FormdoResultado.ShowDialog();

            this.Visible = true;
        }
    }
}
