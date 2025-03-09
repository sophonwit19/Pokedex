namespace PokemonDexII
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Pokemon> pokemonDict = new Dictionary<string, Pokemon>();
        public Form1()
        {
            InitializeComponent();
            LoadPokemonList();
        }


        private void LoadPokemonList()
        {
            pokemonDict["Pikachu"] = new Pikachu();
            pokemonDict["Snorlax"] = new Snorlax();
            pokemonDict["Bulbasaur"] = new Bulbasaur();
            pokemonDict["arbok"] = new arbok();
            pokemonDict["darumaka"] = new darumaka();
            pokemonDict["corviknight"] = new corviknight();

            displayPokemon(pokemonDict["Pikachu"]);
        }

        private void displayPokemon(Pokemon pokemon)
        {
            lbPokemon.Text = pokemon.getName();
            lbType.Text = pokemon.getType();
            lbHp.Text = pokemon.getHP().ToString();
            lbAtk.Text = pokemon.getAttack().ToString();
            lbDef.Text = pokemon.getDefense().ToString();
            lbAtk.Text = pokemon.getAttack().ToString();
            lbSplAtk.Text = pokemon.getSpecialAttack().ToString();
            lbSplDef.Text = pokemon.getSpecialDefense().ToString();
            lbSp.Text = pokemon.getSpeed().ToString();
            lbTotal.Text = pokemon.getTotal().ToString();
            lbH.Text = pokemon.getHeight().ToString() + " m";
            lbW.Text = pokemon.getWeight().ToString() + " kg";
            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }
        }





        private void btnPikachu_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Pikachu"]);

        private void btnSnorlax_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Snorlax"]);

        private void btnBulbasaur_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["Bulbasaur"]);

        private void btnarbok_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["arbok"]);

        private void btndarumaka_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["darumaka"]);

        private void btncorviknight_Click(object sender, EventArgs e) => displayPokemon(pokemonDict["corviknight"]);
  

        }
 }


