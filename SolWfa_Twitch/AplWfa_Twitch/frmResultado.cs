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
    public partial class frmResultado : Form
    {
        public frmResultado()
        {
            InitializeComponent();
        }

        public frmResultado(int streamerEsc, int aleatorio, int pontoS, int pontoC)
        {
            InitializeComponent();
            tmrRes.Enabled = true;

            //         ************* Streamer escolhe Pedra *************
            if (streamerEsc == 1 && aleatorio == 1)
            {
                pcbStreamerEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPedraDraw;
                pcbChatEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPedraDraw;
            }
            else if (streamerEsc == 1 && aleatorio == 2)
            {
                pcbStreamerEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPedraLose;
                pcbChatEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPapelWin;
            }
            else if (streamerEsc == 1 && aleatorio == 3)
            {
                pcbStreamerEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPedraWin;
                pcbChatEsc.Image = AplWfa_Twitch.Properties.Resources.pcbTesouraLose;
            }

            //         ************* Streamer escolhe Papel *************
            if (streamerEsc == 2 && aleatorio == 1)
            {
                pcbStreamerEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPapelWin;
                pcbChatEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPedraLose;
            }
            else if (streamerEsc == 2 && aleatorio == 2)
            {
                pcbStreamerEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPapelDraw;
                pcbChatEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPapelDraw;
            }
            else if (streamerEsc == 2 && aleatorio == 3)
            {
                pcbStreamerEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPapelLose;
                pcbChatEsc.Image = AplWfa_Twitch.Properties.Resources.pcbTesouraWin;
            }

            //         ************* Streamer escolhe Tesoura *************
            if (streamerEsc == 3 && aleatorio == 1)
            {
                pcbStreamerEsc.Image = AplWfa_Twitch.Properties.Resources.pcbTesouraLose;
                pcbChatEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPedraWin;
            }
            else if (streamerEsc == 3 && aleatorio == 2)
            {
                pcbStreamerEsc.Image = AplWfa_Twitch.Properties.Resources.pcbTesouraWin;
                pcbChatEsc.Image = AplWfa_Twitch.Properties.Resources.pcbPapelLose;
            }
            else if (streamerEsc == 3 && aleatorio == 3)
            {
                pcbStreamerEsc.Image = AplWfa_Twitch.Properties.Resources.pcbTesouraDraw;
                pcbChatEsc.Image = AplWfa_Twitch.Properties.Resources.pcbTesouraDraw;
            }

            //=====================================================================================

            //        *************** PONTOS DO STREAMER ***************
            if (pontoS == 1)
            {
                pcbPontosS.Image = AplWfa_Twitch.Properties.Resources.lblContVS1;
            }
            else if (pontoS == 2)
            {
                pcbPontosS.Image = AplWfa_Twitch.Properties.Resources.lblContVS2;
            }
            else if (pontoS == 3)
            {
                pcbPontosS.Image = AplWfa_Twitch.Properties.Resources.lblContVS3;
            }
            else if (pontoS == 4)
            {
                pcbPontosS.Image = AplWfa_Twitch.Properties.Resources.lblContVS4;
            }
            else if (pontoS == 5)
            {
                pcbPontosS.Image = AplWfa_Twitch.Properties.Resources.lblContVS5;
            }
            else if (pontoS == 6)
            {
                pcbPontosS.Image = AplWfa_Twitch.Properties.Resources.lblContVS6;
            }
            else if (pontoS == 7)
            {
                pcbPontosS.Image = AplWfa_Twitch.Properties.Resources.lblContVS7;
            }
            else if (pontoS == 8)
            {
                pcbPontosS.Image = AplWfa_Twitch.Properties.Resources.lblContVS8;
            }
            else if (pontoS == 9)
            {
                pcbPontosS.Image = AplWfa_Twitch.Properties.Resources.lblContVS9;
            }
            else if (pontoS > 9)
            {
                frmResultadoFinal FormResultadoFinal = new frmResultadoFinal(pontoS, pontoC);
                FormResultadoFinal.ShowDialog();
            }

            //        *************** PONTOS DO CHAT ***************

            if (pontoC == 1)
            {
                pcbPontosC.Image = AplWfa_Twitch.Properties.Resources.lblContVC1;
            }
            else if (pontoC == 2)
            {
                pcbPontosC.Image = AplWfa_Twitch.Properties.Resources.lblContVC2;
            }
            else if (pontoC == 3)
            {
                pcbPontosC.Image = AplWfa_Twitch.Properties.Resources.lblContVC3;
            }
            else if (pontoC == 4)
            {
                pcbPontosC.Image = AplWfa_Twitch.Properties.Resources.lblContVC4;
            }
            else if (pontoC == 5)
            {
                pcbPontosC.Image = AplWfa_Twitch.Properties.Resources.lblContVC5;
            }
            else if (pontoC == 6)
            {
                pcbPontosC.Image = AplWfa_Twitch.Properties.Resources.lblContVC6;
            }
            else if (pontoC == 7)
            {
                pcbPontosC.Image = AplWfa_Twitch.Properties.Resources.lblContVC7;
            }
            else if (pontoC == 8)
            {
                pcbPontosC.Image = AplWfa_Twitch.Properties.Resources.lblContVC8;
            }
            else if (pontoC == 9)
            {
                pcbPontosC.Image = AplWfa_Twitch.Properties.Resources.lblContVC9;
            }
            else if(pontoC > 9)
            {
                frmResultadoFinal FormResultadoFinal = new frmResultadoFinal(pontoS, pontoC);
                FormResultadoFinal.ShowDialog();
            }
        }

        int timer = 0;
        private void tmrRes_Tick(object sender, EventArgs e)
        {
            timer++;

            if (timer == 3)
            {
                this.Hide();
            }
        }
    }
}
