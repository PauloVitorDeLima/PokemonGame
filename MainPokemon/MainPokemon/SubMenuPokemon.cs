﻿using System;
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
                int i = 1;
            try
            {
                StreamReader streamReaderPokemons = new StreamReader(@"C:\Users\Public\DataBase\Pokemons\" + i + ".txt");
                string Line;
                while ((Line = streamReaderPokemons.ReadLine()) != null)
                {
                    MessageBox.Show("texto: " + Line);
                }
                streamReaderPokemons.Close();
                i++;
            }
            catch
            {

            }
        }
    }
}
