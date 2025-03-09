using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexII
{
    public class Snorlax : Pokemon
    {
        public Snorlax()
        {
            this.Type = PokemonType.Normal;
            this.height = 2.1;
            this.weight = 460.0;
            this.HP = 160;
            this.attack = 110;
            this.defense = 65;
            this.SpeciaAttack = 65;
            this.SpecialDefense = 110;
            this.speed = 30;
            this.total = 540;
            this.name = "Snorlax";
            this.image = Resource1.ResourceManager.GetObject("snorlax") as byte[] ?? Array.Empty<byte>();
        }
    }
}
