using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexII
{
    internal class arbok : Pokemon
    {

        public arbok()
        {
            this.Type = PokemonType.Poison;
            this.height = 3.5;
            this.weight = 65.0;
            this.HP = 60;
            this.attack = 85;
            this.defense = 69;
            this.SpeciaAttack = 65;
            this.SpecialDefense = 79;
            this.speed = 80;
            this.total = 438;
            this.name = "Arbok";
            this.image = Resource1.ResourceManager.GetObject("arbok") as byte[] ?? Array.Empty<byte>();
        }
    }
}
