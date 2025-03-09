using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexII
{
    internal class darumaka : Pokemon
    {
        public darumaka()
        {
            this.Type = PokemonType.Fire;
            this.height = 0.6;
            this.weight = 37.5;
            this.HP = 70;
            this.attack = 90;
            this.defense = 45;
            this.SpeciaAttack = 15;
            this.SpecialDefense = 45;
            this.speed = 50;
            this.total = 315;
            this.name = "Darumaka";
            this.image = Resource1.ResourceManager.GetObject("darumaka") as byte[] ?? Array.Empty<byte>();
        }
    }
 }
