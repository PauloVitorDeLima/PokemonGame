using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPokemon
{
    public partial class LoginTrainer : Form
    {
        public LoginTrainer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void LoginTrainer_Load(object sender, EventArgs e)
        {
            DirectoryInfo dirUser = new DirectoryInfo(@"C:\Users\Public\DataBase\Users");
            if (dirUser.Exists)
            {
                return;
            }
            else
            {
                dirUser.Create();
            }
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //string com o caminho para verificar se o nome do arquivo já existe
                string[] BuscaLogin = File.ReadAllLines(@"C:\Users\Public\DataBase\Users\" + TxtBxLogin.Text + ".txt");
                //contador para a linha que será verificada
                int linha = 1;
                //senhas para conferir a digitada com a que já está cadastrada
                string password, password2;
                //senha recebe a primeira linha do arquivo
                password = BuscaLogin[linha - 1];
                //senha 2 recebe o conteúdo digitado na caixa de texto
                password2 = TxtBxPassword.Text;
                //compara a digitada com a senha escrita
                if (password == password2)
                {
                    //Abre menu principal se a senha e login coincidirem e esconde a tela de login
                    MainMenu mainMenu = new MainMenu();
                    this.Hide();
                    mainMenu.ShowDialog();
                }
                else
                {
                    //se a senha não coincidir chama o metodo
                    LoginError();
                }
            }
            catch
            {
                //se o nome do arquivo não coincidir chama o metodo 
                LoginError();
            }
        }
        public void LoginError()
        {
            //Mensagem apresentando que não foi possível seguir com o login
            MessageBox.Show("Login e senha não coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Limpa caixa de texto do login e senha
            TxtBxLogin.Clear();
            TxtBxPassword.Clear();
            //chama o foco para a caixa de texto do login
            TxtBxLogin.Focus();
        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            //Esconde a tela de Login e abre a tela de Cadastro
            this.Hide();
            RegisterTrainer registerTrainer = new RegisterTrainer();
            registerTrainer.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}