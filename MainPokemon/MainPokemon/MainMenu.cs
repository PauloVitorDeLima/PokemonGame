using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPokemon
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtPokemon_Click(object sender, EventArgs e)
        {
            //Esconde Menu Principal e abre o Menu do Pokemon
            HideMainMenu();
            SubMenuPokemon pokemon = new SubMenuPokemon();
            pokemon.ShowDialog();
        }

        private void BtTrainer_Click(object sender, EventArgs e)
        {
            //Esconde Menu Principal e abre o Menu do Treinador
            HideMainMenu();
            SubMenuTrainer trainer = new SubMenuTrainer();
            trainer.ShowDialog();
        }
        public void HideMainMenu()
        {
            this.Hide();
        }
    }
}
