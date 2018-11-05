using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainPokemon
{
    public partial class RegisterPokemon : Form
    {
        public RegisterPokemon()
        {
            InitializeComponent();
        }

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
            //MskTxtBxForce.Text = "15";
            //efeito especial, força, altura e peso
            if ((MskTxtBxEffect != null &&
                MskTxtBxHeight != null) &&
                MskTxtBxWeight != null)
            {
                //feito = Convert.ToInt32(MskTxtBxEffect);
                //forca = raiz (Altura * Peso + Efeito).
                int Forca;
                double Altura, peso, efeito;
                Altura = double.Parse(MskTxtBxHeight.Text);
                MessageBox.Show(""+Altura);
            }
        }
    }
}
