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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtTrainer_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            SubMenuTrainer trainer = new SubMenuTrainer();
            trainer.ShowDialog();
        }

        private void BtPokemon_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            SubMenuPokemon pokemon = new SubMenuPokemon();
            pokemon.ShowDialog();
        }
        public void HideMainMenu()
        {
            this.Hide();
        }
    }
    
}
