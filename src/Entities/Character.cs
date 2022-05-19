namespace rpg_dotnet_zeco.src.Entities
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP {get; set;}
        public int MP {get; set;}

        public Character(string name, int level, int hp, int mp)
        {
            this.Name = name;
            this.Level = level;
            this.HP = hp;
            this.MP = mp;
        }

        public virtual string Attack() {
            return this.Name + " atacou!";
        }  

        public string Damage(int val) {
            this.HP = this.HP - val;
            return this.Name + " tem apenas " + this.HP + " pontos de vida!";
        }

        public override string ToString()
        {
            string texto = $@"
            _______________________
            Name: {this.Name}
            Level: {this.Level}
            HP: {this.HP}
            MP: {this.MP} 
            ________________________";
            return texto;
        }        
    }
}