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
    public partial class SubMenuTrainer : Form
    {
        public SubMenuTrainer()
        {
            InitializeComponent();
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
        }
    }
}
