namespace JogoRPG.Entities
{
    public class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return "Nome: " + this.Name + ", " + "Level: " + this.Level + ", " + "Tipo de herói: " + this.HeroType + ".";
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada";
        }
    }
}