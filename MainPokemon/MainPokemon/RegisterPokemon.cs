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
                String.IsNullOrEmpty(MskTxtBxId.Text) ||
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
                CadastrarPokemon();
            }
        }
        public void CadastrarPokemon()
        {
            Pokemon pokemon = new Pokemon();
            pokemon.ID = int.Parse(MskTxtBxId.Text);
            pokemon.Name = TxtBxName.Text;
            pokemon.Height = double.Parse(MskTxtBxHeight.Text);
            pokemon.Weight = double.Parse(MskTxtBxWeight.Text);
            pokemon.SpecialEffect = int.Parse(MskTxtBxEffect.Text);
            pokemon.Force = int.Parse(MskTxtBxForce.Text);
            pokemon.PathImage = PathImage;


                StreamWriter streamWriterPokemon = new StreamWriter(@"C:\Users\Public\DataBase\Pokemons.txt", true);
            streamWriterPokemon.WriteLine(pokemon.ID+"/"+pokemon.Name + "/" +pokemon.Height+"/"+pokemon.Weight+"/"+pokemon.SpecialEffect+"/"+
                pokemon.Force+"/"+pokemon.PathImage);
                streamWriterPokemon.Close();
            MessageBox.Show("Pokemon cadastrado com Sucesso!!");

            this.Hide();
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
    }
}
