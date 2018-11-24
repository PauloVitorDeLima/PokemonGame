using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainPokemon
{
    class Pokemon
    {
        int iD;
        string name;
        double height;
        double weight;
        int specialEffect;
        int force;
        string pathImage;
        int iD_Trainer;
        
        


        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string PathImage { get => pathImage; set => pathImage = value; }
        public int SpecialEffect { get => specialEffect; set => specialEffect = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Force { get => force; set => force = value; }
        public int ID_Trainer { get => iD_Trainer; set => iD_Trainer = value; }
    }
}
