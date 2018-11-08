using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainPokemon
{
    public partial class SubMenuPokemon : Form
    {
        public SubMenuPokemon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void BtRegisterPokemon_Click(object sender, EventArgs e)
        {
            RegisterPokemon registerPokemon = new RegisterPokemon();
            registerPokemon.ShowDialog();
        }

        private void BtReturn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
        }

        private void BtListPokemon_Click(object sender, EventArgs e)
        {
            
            DataGridViewPokemons.Visible = true;
            PictureBoxPokemon.Visible = true;

            DirectoryInfo dirPokemon = new DirectoryInfo(@"C:\Users\Public\DataBase\Pokemons\");
            FileInfo[] fileInfo = dirPokemon.GetFiles("*", SearchOption.AllDirectories);
            StreamReader streamReaderPokemons;

            List <Pokemon> pokemons = new List<Pokemon>();


            /*
             Conta c1 = new ContaCorrente();
Conta c2 = new ContaPoupanca();
Conta c3 = new ContaCorrente();

// c1 fica na posição 0
lista.Add(c1);
// c2 na 1
lista.Add(c2);
// e c3 na 2
lista.Add(c3); 
             */
            try
            {

            
            foreach (FileInfo file in fileInfo)
            {
                streamReaderPokemons = new StreamReader(file.FullName);

                string Line;
                int CountLine = 1;
                while ((Line = streamReaderPokemons.ReadLine()) != null)
                {
                    this.DataGridViewPokemons.DataSource = pokemons;
                    CountLine++;
                }
                streamReaderPokemons.Close();
            }
            }
            catch
            {

            }
        }
    }
}
