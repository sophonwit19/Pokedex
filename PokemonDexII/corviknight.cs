using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexII
{
    internal class corviknight : Pokemon
    {
        public corviknight()
        {
            this.Type = PokemonType.Flying;
            this.height = 2.2;
            this.weight = 75.0;
            this.HP = 98;
            this.attack = 87;
            this.defense = 105;
            this.SpeciaAttack = 53;
            this.SpecialDefense = 85;
            this.speed = 67;
            this.total = 495;
            this.name = "Corviknight";
            this.image = Resource1.ResourceManager.GetObject("corviknight") as byte[] ?? Array.Empty<byte>();
        }
    }
    
    }

