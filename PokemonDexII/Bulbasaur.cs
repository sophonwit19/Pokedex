using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexII
{
    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur()
        {
            this.Type = PokemonType.Grass;
            this.height = 0.7;
            this.weight = 6.9;
            this.HP = 45;
            this.attack = 49;
            this.defense = 49;
            this.SpeciaAttack = 65;
            this.SpecialDefense = 65;
            this.speed = 45;
            this.total = 318;
            this.name = "Bulbasaur";
            this.image = Resource1.ResourceManager.GetObject("bulbasaur") as byte[] ?? Array.Empty<byte>();
        }
    }
 }
