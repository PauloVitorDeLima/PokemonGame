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
        private int Minutes = 59;
        private int Seconds = 59;
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
            textBox2.Visible = true;
            TxtBxEvolution.Visible = true;
            LbTime.Visible = true;
            LbTime.Text = Minutes + ":" + Seconds;
            TimerEvolution.Enabled = true;
            string name = DataGridViewPokemons.SelectedCells[1].Value.ToString();
            TxtBxEvolution.Text = name.ToUpper();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void TimerEvolution_Tick(object sender, EventArgs e)
        {
            Seconds--;
            if (Minutes > 0)
            {
                if (Seconds < 0)
                {
                    Seconds = 59;
                    Minutes--;
                }
            }
            LbTime.Text = Minutes + ":" + Seconds;
            if (Minutes == 0 && Seconds == 0)
            {
                TimerEvolution.Enabled = false;
                PokemonDataBase();
                BtListTrainer_Click(sender, e);
                MessageBox.Show("EVOLUIU O POKEMON");
            }
        }

        private void LbTime_Click(object sender, EventArgs e)
        {

        }
        public void PokemonDataBase()
        {
            try
            {
                DataTable dataTable = new DataTable();
                OleDbConnection Connection = new OleDbConnection(StringConnection);
                Connection.Open();
                string NewForce = DataGridViewPokemons.SelectedCells[5].Value.ToString();
                int force = Convert.ToInt16(NewForce);
                force = force + 3;
                Identificador = DataGridViewPokemons.SelectedCells[0].Value.ToString();
                string SQL = "UPDATE Pokemon SET Force_Pokemon = '" + force.ToString() + "' WHERE ID_Pokemon =" + Identificador.ToString();
                OleDbCommand CMD = new OleDbCommand(SQL, Connection);
                CMD.ExecuteNonQuery();
                Connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
