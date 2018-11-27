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
using System.Data.OleDb;

namespace MainPokemon
{
    public partial class RegisterPokemon : Form
    {
        public RegisterPokemon()
        {
            InitializeComponent();
        }
        string PathImage = "";
        Pokemon pokemon = new Pokemon();
        //Mudar o caminho do Connection quando testar em outro computador
        private string StringConnection = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Paulo Vitor\OneDrive - Complexo de Ensino Superior do Brasil LTDA\Programação\PokemonGame\MainPokemon\MainPokemon\bin\Debug\DataBaseAccess.mdb";
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
        private void BtCancel_Click(object sender, EventArgs e)
        {
            //Esconde a tela de Cadastro Pokemon
            this.Hide();
        }

        private void RegisterPokemon_Load(object sender, EventArgs e)
        {
            //Quando carrega a tela de Cdastro Pokemon adiciona o efeito aleatório ao pokemon entre 1 a 5
            Random random = new Random();
            MskTxtBxEffect.Text = random.Next(1, 5).ToString();
        }

        private void MskTxtBxWeight_TextChanged(object sender, EventArgs e)
        {
            //Quando o Peso for alterado chama o método de calcular a força
            CalculateForce();
        }
        private void BtRegisterPokemon_Click(object sender, EventArgs e)
        {
            //Verifica se todos os campos estão preenchidos
            if (String.IsNullOrEmpty(MskTxtBxWeight.Text) ||
                String.IsNullOrEmpty(MskTxtBxHeight.Text) ||
                String.IsNullOrEmpty(MskTxtBxForce.Text) ||
                String.IsNullOrEmpty(MskTxtBxEffect.Text) ||
                String.IsNullOrEmpty(TxtBxName.Text))
            {
                MessageBox.Show("Campos Vazios, por favor, insira todos os valores", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //chama metodo de cadastro no Banco de Dados
                RegisterPokemonDataBase();
            }
        }
        private void MskTxtBxHeight_TextChanged(object sender, EventArgs e)
        {
            //Quando a altura for alterada chama o método de calcular a força
            CalculateForce();
        }
        private void CalculateForce()
        {
            try
            {
                //verifica se está nulo ou vazio
                if (String.IsNullOrEmpty(MskTxtBxEffect.Text) ||
                    String.IsNullOrEmpty(MskTxtBxHeight.Text) ||
                    String.IsNullOrEmpty(MskTxtBxWeight.Text))
                {
                    return;
                }
                else
                {
                    //Adiciona no objeto Pokemon os dados
                    pokemon.SpecialEffect = int.Parse(MskTxtBxEffect.Text);
                    pokemon.Height = double.Parse(MskTxtBxHeight.Text);
                    pokemon.Weight = double.Parse(MskTxtBxWeight.Text);
                    //calculo da força
                    pokemon.Force = Convert.ToInt32(Math.Sqrt(pokemon.Height * pokemon.Weight + pokemon.SpecialEffect));
                    MskTxtBxForce.Text = pokemon.Force.ToString();
                }
            }
            catch
            {
                //caso os valores inseridos sejam caracteres inválidos
                MessageBox.Show("Insira valores válidos");
                //limpa peso e altura
                MskTxtBxHeight.Clear();
                MskTxtBxWeight.Clear();
            }
        }

        private void BtImage_Click(object sender, EventArgs e)
        {
            //abre arquivo para escolher imagem
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.FileName = "";
            //filtros de qual tipo de imagem aceita
            openFile.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.gif, *.png) | *.jpg; *.jpeg; *.jpe; *.gif; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //adiciona a caixa de Imagem a imagem centralizada
                PictureBxImage.Image = new Bitmap(openFile.FileName);
                PictureBxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                //adiciona ao caminho da imagem o nome do caminho
                PathImage = openFile.FileName;
            }
        }
        public void RegisterPokemonDataBase()
        {
            //Inicializa o objeto Pokemon
            Pokemon pokemon = new Pokemon();
            pokemon.Name = TxtBxName.Text;
            pokemon.Height = double.Parse(MskTxtBxHeight.Text);
            pokemon.Weight = double.Parse(MskTxtBxWeight.Text);
            pokemon.SpecialEffect = int.Parse(MskTxtBxEffect.Text);
            pokemon.Force = int.Parse(MskTxtBxForce.Text);
            pokemon.PathImage = PathImage;
            try
            {
                //Cria conexão
                OleDbConnection Connection = new OleDbConnection(StringConnection);
                //Abre Conexão
                Connection.Open();
                //SQL linguagem do Banco de dados 
                String SQL;
                /*
                 Insere na tabela Pokemon na coluna nome, peso, altura, efeito especial, forca, caminho da imagem
                os valores que estiverem no objeto Pokemon
                 */
                SQL = "INSERT INTO Pokemon(Name_Pokemon, Height_Pokemon, Weight_Pokemon, SpecialEffect_Pokemon," +
                    " Force_Pokemon, PathImage_Pokemon) VALUES ";
                SQL += "('" + pokemon.Name + "', '"+ pokemon.Height + "', '" + pokemon.Weight + "','" + pokemon.SpecialEffect + "', '" 
                    + pokemon.Force + "','" + pokemon.PathImage + "')";
                OleDbCommand CMD = new OleDbCommand(SQL, Connection);
                CMD.ExecuteNonQuery();
                Connection.Close();
                //Mensagem de sucesso
                MessageBox.Show("Pokemon Cadastrado com Sucesso","OKAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
