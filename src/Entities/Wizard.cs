namespace rpg_dotnet_zeco.src.Entities
{
    public class Wizard : Character {
        public Wizard(string name, int level, int hp, int mp): base(name, level, hp, mp) {
        }
        public override string Attack() {
           return this.Name + " atacou com magia";
        }    
    }
}