using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexII
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            this.Type = PokemonType.Electric;
            this.height = 0.4;
            this.weight = 6.0;
            this.HP = 35;
            this.attack = 55;
            this.defense = 40;
            this.SpeciaAttack = 50;
            this.SpecialDefense = 50;
            this.speed = 90;
            this.total = 320;
            this.name = "Pikachu";
            this.image = Resource1.ResourceManager.GetObject("pikachu") as byte[] ?? Array.Empty<byte>();

        }

    }
}
