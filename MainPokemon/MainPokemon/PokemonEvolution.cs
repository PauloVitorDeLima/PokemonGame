using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MainPokemon
{
    public partial class PokemonEvolution : Form
    {
        public PokemonEvolution(string Identificador)
        {
            InitializeComponent();
            string IdPokemon = Identificador;
            MessageBox.Show(Identificador);
        }
        int minuto = 59;
        int segundo = 59;
        private void PokemonEvolution_Load(object sender, EventArgs e)
        {
            LbTime.Text = minuto + ":" + segundo;
            TimerEvolution.Enabled = true;
        }

        private void TimerEvolution_Tick(object sender, EventArgs e)
        {
            segundo--;
            if (minuto > 0)
            {
                if (segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }
            LbTime.Text = minuto + ":" + segundo;
            if (minuto == 0 && segundo == 0)
            {
                TimerEvolution.Enabled = false;
                MessageBox.Show("EVOLUIU O POKEMON");
            }
        }
    }
}
