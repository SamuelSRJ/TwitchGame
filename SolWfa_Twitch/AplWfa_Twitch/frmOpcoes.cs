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
    public partial class frmOpcoes : Form
    {
        int idioma = 1;
        public frmOpcoes()
        {
            InitializeComponent();
            idiomaSelecionado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        //=================== BRAZIL FLAG SELECTED =====================================
        private void mouseSelecBrazil(object sender, EventArgs e)
        {
            btnBrazil.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnBrazilON;
            btnUsa.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnUsaOFF;
            btnSpain.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSpainOFF;
            idioma = 1;
        }

        //=================== USA FLAG SELECTED =====================================
        private void mouseSelecUsa(object sender, EventArgs e)
        {
            btnBrazil.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnBrazilOFF;
            btnUsa.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnUsaON;
            btnSpain.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSpainOFF;
            idioma = 2;
        }

        //=================== SPAIN FLAG SELECTED =====================================
        private void mouseSelecSpain(object sender, EventArgs e)
        {
            btnBrazil.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnBrazilOFF;
            btnUsa.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnUsaOFF;
            btnSpain.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSpainON;
            idioma = 3;
        }

        //=========================== EVENTOS DE HOVER ======================================
        private void mouseINrestaurar(object sender, EventArgs e)
        {
            btnRestaurar.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnRestaurarHover;
        }

        private void mouseOUTrestaurar(object sender, EventArgs e)
        {
            btnRestaurar.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnRestaurar;
        }

        private void mouseINaplicar(object sender, EventArgs e)
        {
            btnAplicar.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnAplicarHover;
        }

        private void mouseOUTaplicar(object sender, EventArgs e)
        {
            btnAplicar.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnAplicar;
        }

        private void mouseINvoltar(object sender, EventArgs e)
        {
            btnVoltar.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnVoltarHover;
        }

        private void mouseOUTvoltar(object sender, EventArgs e)
        {
            btnVoltar.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnVoltar;
        }
        //===================================================================================

        private void idiomaSelecionado()
        {
            if(idioma == 1)
            {
                btnBrazil.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnBrazilON;
                btnUsa.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnUsaOFF;
                btnSpain.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSpainOFF;
            }
            else if(idioma == 2)
            {
                btnBrazil.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnBrazilOFF;
                btnUsa.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnUsaON;
                btnSpain.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSpainOFF;
            }
            else if(idioma == 3)
            {
                btnBrazil.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnBrazilOFF;
                btnUsa.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnUsaOFF;
                btnSpain.BackgroundImage = AplWfa_Twitch.Properties.Resources.btnSpainON;
            }
        }

        //============================ LIMPEZA DO FORMULARIO =================================
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtTwitchid.Clear();
            txtTwitchid.Focus();
            trkVolume.Value = 100;
            idiomaSelecionado();
        }

        //========================= APLICACAO DOS IDIOMAS ==================================
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if(idioma == 1)
            {
                MessageBox.Show("Idioma alterado para Portugues Brasileiro", "Idioma alterado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(idioma == 2)
            {
                MessageBox.Show("Language changed to English", "Language changed successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(idioma == 3)
            {
                MessageBox.Show("Idioma cambiado a Español", "Idioma cambiado con éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
