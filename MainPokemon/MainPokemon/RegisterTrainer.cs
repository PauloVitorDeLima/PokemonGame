
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
    public partial class RegisterTrainer : Form
    {
        public RegisterTrainer()
        {
            InitializeComponent();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            //Abre a tela de Login e esconde a tela de Cadastro
            this.Hide();
            LoginTrainer loginTrainer = new LoginTrainer();
            loginTrainer.ShowDialog();

        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            //verifica se os campos estão preenchidos 
            if (TxtBxLogin.Text == string.Empty ||
                TxtBxPassword.Text == string.Empty)
            {
                //mensagem para que seja inserido o login e senha
                MessageBox.Show("Por favor insira valores no Login e Senha", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Inicializa o objeto da classe Treinador
                Trainer trainer = new Trainer();
                trainer.Login = TxtBxLogin.Text;
                trainer.Password = TxtBxPassword.Text;
                //verifica se o Login já existe
                if (System.IO.File.Exists(@"C:\Users\Public\DataBase\Users\" + trainer.Login + ".txt") == true)
                {
                    //mensagem de erro pois usuário já existe
                    MessageBox.Show("Não foi possível cadastrar pois usuário já existe", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //cria o arquivo com o nome do Treinador
                    StreamWriter streamWriterUser = new StreamWriter(@"C:\Users\Public\DataBase\Users\"
                                + trainer.Login + ".txt");
                    //escreve na primeira linha a senha do treinador
                    streamWriterUser.WriteLine(trainer.Password);
                    streamWriterUser.Close();
                    //Mensagem de sucesso no cadastro
                    MessageBox.Show("Usuário cadastrado com Sucesso", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Abre menu principal sem a necessidade de digitar novamente o login
                    MainMenu mainMenu = new MainMenu();
                    //esconde o a tela de Cadastro
                    this.Hide();
                    mainMenu.ShowDialog();
                }
            }
        }
    }
}