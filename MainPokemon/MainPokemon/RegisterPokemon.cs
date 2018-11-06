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

        Pokemon pokemon = new Pokemon();




        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegisterPokemon_Load(object sender, EventArgs e)
        {

            Random random = new Random();
            MskTxtBxEffect.Text = random.Next(1, 5).ToString();


            DirectoryInfo dirPokemon = new DirectoryInfo(@"C:\Users\Public\DataBase\Pokemons");
            if (dirPokemon.Exists)
            {
                return;
            }
            else
            {
                dirPokemon.Create();
            }

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
            pokemon.Force = int.Parse(MskTxtBxForce.Text);
            pokemon.
            pokemon

            /*
             Trainer trainer = new Trainer();
                trainer.Login = TxtBxLogin.Text;
                trainer.Password = TxtBxPassword.Text;
                if (System.IO.File.Exists(@"C:\Users\Public\DataBase\Users\" + trainer.Login + ".txt") == true)
                {
                    MessageBox.Show("Não foi possível cadastrar pois usuário já existe", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    StreamWriter streamWriterUser = new StreamWriter(@"C:\Users\Public\DataBase\Users\"
                                + trainer.Login + ".txt");
                    streamWriterUser.WriteLine(trainer.Password);
                    streamWriterUser.Close();
                    MessageBox.Show("Usuário cadastrado com Sucesso", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainMenu mainMenu = new MainMenu();
                    this.Hide();
                    mainMenu.Show();
                } 
             */



            MessageBox.Show("Pokemon Cadastrado com Sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MskTxtBxHeight_TextChanged(object sender, EventArgs e)
        {
            CalculateForce();
        }
        private void CalculateForce()
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
                pokemon.Force = Convert.ToSingle(Math.Sqrt(pokemon.Height * pokemon.Weight + pokemon.SpecialEffect));
                MskTxtBxForce.Text = pokemon.Force.ToString();
            }
        }
    }
}
