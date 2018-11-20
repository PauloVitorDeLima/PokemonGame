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




        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegisterPokemon_Load(object sender, EventArgs e)
        {

            Random random = new Random();
            MskTxtBxEffect.Text = random.Next(1, 5).ToString();

        }

        private void MskTxtBxWeight_TextChanged(object sender, EventArgs e)
        {
            CalculateForce();
        }
        private void BtRegisterPokemon_Click(object sender, EventArgs e)
        {
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

                CadastrarNoBanco();
            }
        }
        private void MskTxtBxHeight_TextChanged(object sender, EventArgs e)
        {
            CalculateForce();
        }
        private void CalculateForce()
        {
            try
            {

                if (String.IsNullOrEmpty(MskTxtBxEffect.Text) ||
                    String.IsNullOrEmpty(MskTxtBxHeight.Text) ||
                    String.IsNullOrEmpty(MskTxtBxWeight.Text))
                {
                    return;
                }
                else
                {
                    pokemon.SpecialEffect = int.Parse(MskTxtBxEffect.Text);
                    pokemon.Height = double.Parse(MskTxtBxHeight.Text);
                    pokemon.Weight = double.Parse(MskTxtBxWeight.Text);
                    pokemon.Force = Convert.ToInt32(Math.Sqrt(pokemon.Height * pokemon.Weight + pokemon.SpecialEffect));
                    MskTxtBxForce.Text = pokemon.Force.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Insira valores válidos");
                MskTxtBxHeight.Clear();
                MskTxtBxWeight.Clear();
            }
        }

        private void BtImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.FileName = "";
            openFile.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.gif, *.png) | *.jpg; *.jpeg; *.jpe; *.gif; *.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PictureBxImage.Image = new Bitmap(openFile.FileName);
                PathImage = openFile.FileName;
            }
        }
        public void CadastrarNoBanco()
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Name = TxtBxName.Text;
            pokemon.Height = double.Parse(MskTxtBxHeight.Text);
            pokemon.Weight = double.Parse(MskTxtBxWeight.Text);
            pokemon.SpecialEffect = int.Parse(MskTxtBxEffect.Text);
            pokemon.Force = int.Parse(MskTxtBxForce.Text);
            pokemon.PathImage = PathImage;
            try
            {
                //Mudar o caminho do Connection quando testar em outro computador
                string StringConnection = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Paulo Vitor\OneDrive - Complexo de Ensino Superior do Brasil LTDA\Programação\PokemonGame\MainPokemon\MainPokemon\bin\Debug\DataBaseAccess.mdb";
                OleDbConnection Connection = new OleDbConnection(StringConnection);
                //Abre Conexão
                Connection.Open();
                String SQL;
                SQL = "INSERT INTO Pokemon(Name_Pokemon, Height_Pokemon, Weight_Pokemon, SpecialEffect_Pokemon," +
                    " Force_Pokemon, PathImage_Pokemon, Evolution_Pokemon) VALUES ";
                SQL += "('"+pokemon.Name+ "', '"+pokemon.Height+ "', '" + pokemon.Weight+ "','" + pokemon.SpecialEffect+ "', '" 
                    + pokemon.Force + "','" + pokemon.PathImage+ "','" + pokemon.Evolution + "')";
                OleDbCommand CMD = new OleDbCommand(SQL, Connection);
                CMD.ExecuteNonQuery();
                Connection.Close();

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
