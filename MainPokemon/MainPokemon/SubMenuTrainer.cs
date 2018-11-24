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
    public partial class SubMenuTrainer : Form
    {
        public SubMenuTrainer()
        {
            InitializeComponent();
        }
        private String StringConnection = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Paulo Vitor\OneDrive - Complexo de Ensino Superior do Brasil LTDA\Programação\PokemonGame\MainPokemon\MainPokemon\bin\Debug\DataBaseAccess.mdb";
        private string Identificador;
        private void BtVoltar_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
        }

        private void BtListTrainer_Click(object sender, EventArgs e)
        {
            DataGridViewPokemons.Visible = true;
            PictureBoxPokemon.Visible = true;
            TxtBxSearch.Visible = true;
            TxtBx.Visible = true;

            try
            {
                OleDbConnection Connection = new OleDbConnection(StringConnection);
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

        private void DataGridViewPokemons_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                Identificador = DataGridViewPokemons.SelectedCells[6].Value.ToString();
                if (Identificador != "")
                {
                    PictureBoxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
                    PictureBoxPokemon.Image = new Bitmap(@"" + Identificador);
                }
                else
                {
                    PictureBoxPokemon.Image = new Bitmap(@"C:/Users/Paulo Vitor/OneDrive - Complexo de Ensino Superior do Brasil LTDA/Programação/PokemonGame/MainPokemon/MainPokemon/Imagens/WithoutPicture.png");
                }
            }
            catch
            {

            }
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
        }

        private void TxtBxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();
                OleDbConnection Connection = new OleDbConnection(StringConnection);
                Connection.Open();
                String SQL;
                SQL = "SELECT * FROM Pokemon WHERE Name_Pokemon LIKE '%" + TxtBxSearch.Text + "%'";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, Connection);
                DataSet DS = new DataSet();
                adapter.Fill(dataTable);
                DataGridViewPokemons.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void evoluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Identificador = DataGridViewPokemons.SelectedCells[0].Value.ToString();
                PokemonEvolution pokemonEvolution = new PokemonEvolution(Identificador);
                pokemonEvolution.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
