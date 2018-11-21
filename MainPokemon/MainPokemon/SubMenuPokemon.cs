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
    public partial class SubMenuPokemon : Form
    {
        public SubMenuPokemon()
        {
            InitializeComponent();
        }
        public String StringConnection = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Paulo Vitor\OneDrive - Complexo de Ensino Superior do Brasil LTDA\Programação\PokemonGame\MainPokemon\MainPokemon\bin\Debug\DataBaseAccess.mdb";


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
            DataGridViewPokemons.Visible = false;
            PictureBoxPokemon.Visible = false;

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
            try
            {
                //String StringConnection = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Paulo Vitor\OneDrive - Complexo de Ensino Superior do Brasil LTDA\Programação\PokemonGame\MainPokemon\MainPokemon\bin\Debug\DataBaseAccess.mdb";
                OleDbConnection Connection = new OleDbConnection(StringConnection);
                //Abre Conexão
                Connection.Open();
                String SQL;
                SQL = "SELECT * FROM Pokemon";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, Connection);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "Pokemon");
                DataGridViewPokemons.DataSource = DS.Tables["Pokemon"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                //String StringConnection = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Paulo Vitor\OneDrive - Complexo de Ensino Superior do Brasil LTDA\Programação\PokemonGame\MainPokemon\MainPokemon\bin\Debug\DataBaseAccess.mdb";
                OleDbConnection Connection = new OleDbConnection(StringConnection);
                Connection.Open();
                string Identificador = DataGridViewPokemons.SelectedCells[0].Value.ToString();
                string SQL = "DELETE FROM Pokemon WHERE ID_Pokemon ="+Identificador;

                OleDbCommand CMD = new OleDbCommand(SQL, Connection);
                CMD.ExecuteNonQuery();
                MessageBox.Show("Dados apagados com Sucesso");
                BtListPokemon_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
