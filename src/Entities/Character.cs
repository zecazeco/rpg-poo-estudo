namespace rpg_dotnet_zeco.src.Entities
{
    public class Character
    {
        public Character(string name, int level, int hp, int mp)
        {
            Name = name;
            Level = level;
            HP = hp;
            MP = mp;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public int HP {get; set;}
        public int MP {get; set;}

        public override string ToString()
        {
            string texto = $@"
            _______________________
            Name: {this.Name}
            Level: {this.Level}
            HP: {this.HP}
            MP:{this.MP} 
            ________________________";
            return texto;
        }        
    }
}