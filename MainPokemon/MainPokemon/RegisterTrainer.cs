
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
            this.Hide();
            LoginTrainer loginTrainer = new LoginTrainer();
            loginTrainer.ShowDialog();

        }

        private void BtRegister_Click(object sender, EventArgs e)
        {
            if (TxtBxLogin.Text == string.Empty ||
                TxtBxPassword.Text == string.Empty)
            {
                MessageBox.Show("Por favor insira valores no Login e Senha", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
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
                    mainMenu.ShowDialog();
                }
            }
        }
    }
}