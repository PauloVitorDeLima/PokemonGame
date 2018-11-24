using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPokemon
{
    class Trainer
    {
        string login;
        string password;
        int ID_Trainer;
        int ID_Pokemon;
        
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public int ID_Trainer1 { get => ID_Trainer; set => ID_Trainer = value; }
        public int ID_Pokemon1 { get => ID_Pokemon; set => ID_Pokemon = value; }
    }
}
