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
        //String de conexão com o Banco de Dados
        private String StringConnection = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Paulo Vitor\OneDrive - Complexo de Ensino Superior do Brasil LTDA\Programação\PokemonGame\MainPokemon\MainPokemon\bin\Debug\DataBaseAccess.mdb";
        /*
         * 
         * 
         * 
        ALTERAR O CAMINHO QUANDO MUDAR DE COMPUTADOR APERTE NO SERVER EXPLORER > DATA CONNECTIONS >
        ADD CONNECTIONS > MICROSOFT ACCESS DATABASE FILE > CONTINUE > BROWSE (AQUI ENCONTRA O ARQUIVO QUE ESTÁ NA PASTA
        DO PROJETO EM BIN E DEBUG, SELECIONA E POR FIM CLIQUE EM ADVANCED > ENTÃO COPIE O CAMINHO E SUBSTITUIA
         *
         *
         *
         */

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
            //Deixa invisível
            DataGridViewPokemons.Visible = false;
            PictureBoxPokemon.Visible = false;
            TxtBx.Visible = false;
            TxtBxSearch.Visible = false;

            //abre a tela de Cadastro de Pokemon em cima do menu do Pokemon
            RegisterPokemon registerPokemon = new RegisterPokemon();
            registerPokemon.ShowDialog();
        }

        private void BtReturn_Click(object sender, EventArgs e)
        {
            //Retorna ao menu principal e esconde a tela de menu do Pokemon
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
        }

        private void BtListPokemon_Click(object sender, EventArgs e)
        {
            //Deixa os seguintes itens visíveis
            DataGridViewPokemons.Visible = true;
            PictureBoxPokemon.Visible = true;
            TxtBxSearch.Visible = true;
            TxtBx.Visible = true;

            try
            {
                //cria a conexão por meio do caminho do arquivo
                OleDbConnection Connection = new OleDbConnection(StringConnection);
                //Abre Conexão
                Connection.Open();
                //String SQL (Linguagem do Banco de Dados)
                String SQL;
                //Seleciona tudo da tabela Pokemon
                SQL = "SELECT * FROM Pokemon";
                
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, Connection);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "Pokemon");
                //Apresenta no DataGrid tudo contido na tabela Pokemon
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
                //cria a conexão por meio do caminho do arquivo
                OleDbConnection Connection = new OleDbConnection(StringConnection);
                //Abre conexão
                Connection.Open();
                //Identifica a linha selecionada
                string Identificador = DataGridViewPokemons.SelectedCells[0].Value.ToString();
                //Mensagem de confirmação para exclusão do dado selecionado
                DialogResult dialogResult = MessageBox.Show("Realmente deseja apagar esse dado?", "Deletar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (dialogResult == DialogResult.Yes)
                {
                    //Se a resposta for sim cria variável
                    string SQL;
                    //Comando SQL onde deleta da tabela Pokemon quando o ID for igual ao marcado
                    SQL = "DELETE FROM Pokemon WHERE ID_Pokemon =" + Identificador;

                    OleDbCommand CMD = new OleDbCommand(SQL, Connection);
                    CMD.ExecuteNonQuery();
                    //Mensagem de sucesso
                    MessageBox.Show("Dados apagados com Sucesso");
                    //Chama método BtList para que os dados sejam atualizados
                    BtListPokemon_Click(sender, e);
                }
                else if (dialogResult == DialogResult.No)
                {

                }
                Connection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {

        }

        private void DataGridViewPokemons_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //Identifica a coluna 6 selecionada, no caso o caminho da imagem 
                string Identificador = DataGridViewPokemons.SelectedCells[6].Value.ToString();
                //Verifica se o caminho da imagem não está vazio
                if (Identificador != "")
                {
                    //Deixa a imagem centralizada
                    PictureBoxPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
                    //Coloca o caminho da imagem no PictureBox 
                    PictureBoxPokemon.Image = new Bitmap(@"" + Identificador);
                }
                else
                {
                    /*
                     * 
                     * ALTERA O CAMINHO DA IMAGEM PARA O CAMINHO QUE SE ENCONTRA NA PASTA IMAGENS NO PROJETO
                     * 
                     * 
                     */ 
                    
                    //Caso não tenha nenhuma imagem cadastrada apresenta uma imagem
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
                //Cria Conexão
                OleDbConnection Connection = new OleDbConnection(StringConnection);
                //abre conexão
                Connection.Open();
                //SQL, linguagem do banco de dados
                String SQL;
                //Seleciona tudo da tabela Pokemon quando a coluna Nome_Pokemon for como o que for digitado
                // os % % faz pesquisar mesmo se oq for pesquisado esteja no meio de outras palavras
                SQL = "SELECT * FROM Pokemon WHERE Name_Pokemon LIKE '%" + TxtBxSearch.Text + "%'";
                
                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, Connection);
                DataSet DS = new DataSet();
                adapter.Fill(dataTable);
                //Mostra no DataGrid o que foi selecionado
                DataGridViewPokemons.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}