using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDexII
{
    public enum PokemonType
    {
        Normal,
        Fire,
        Water,
        Electric,
        Grass,
        Ice,
        Fighting,
        Poison,
        Ground,
        Flying,
        Psychic,
        Bug,
        Rock,
        Ghost,
        Dragon,
        Dark,
        Steel,
        Fairy
    }

    public class Pokemon
    {
        protected string name;
        protected int HP;
        protected int attack;
        protected int defense;
        protected int SpeciaAttack;
        protected int SpecialDefense;
        protected int speed;
        protected int total;
        protected double height;
        protected double weight;
        protected string Species;
        protected PokemonType Type;
        protected byte[] image;

        public Pokemon() { }

        public string getName()
        {
            return this.name;
        }
        public byte[] getImage()
        {
            return this.image;
        }
        public string getType()
        {
            return this.Type.ToString();
        }
        public int getHP()
        {
            return this.HP;
        }
        public int getAttack()
        {
            return this.attack;
        }
        public int getDefense()
        {
            return this.defense;
        }
        public int getSpecialAttack()
        {
            return this.SpeciaAttack;
        }
        public int getSpecialDefense()
        {
            return this.SpecialDefense;
        }
        public int getSpeed()
        {
            return this.speed;
        }
        public int getTotal()
        {
            return this.total;
        }
        public double getHeight()
        {
            return this.height;
        }
        public double getWeight()
        {
            return this.weight;
        }




    }
}
