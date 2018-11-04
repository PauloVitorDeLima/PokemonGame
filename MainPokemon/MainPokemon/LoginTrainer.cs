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

        private void BtTrainer_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            SubMenuTrainer trainer = new SubMenuTrainer();
            trainer.ShowDialog();
        }

        private void BtPokemon_Click(object sender, EventArgs e)
        {
            HideMainMenu();
            SubMenuPokemon pokemon = new SubMenuPokemon();
            pokemon.ShowDialog();
        }
        public void HideMainMenu()
        {
            this.Hide();
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
            string[] BuscaLogin = File.ReadAllLines(@"C:\Users\Public\DataBase\Users\"+TxtBxLogin.Text+".txt");
                int linha = 1;
                string password, password2;
                password = BuscaLogin[linha - 1];
                password2 = TxtBxPassword.Text;
            if (password == password2)
            {

                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.ShowDialog();
            }   
            else
            {
                LoginError();
            }
            }
            catch
            {
                LoginError();
            }
        }
        public void LoginError()
        {
            MessageBox.Show("Login e senha não coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TxtBxLogin.Clear();
            TxtBxPassword.Clear();
            TxtBxLogin.Focus();
        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
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
