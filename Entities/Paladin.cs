namespace JogoRPG.Entities
{
    public class Paladin : Hero
    {
        public Paladin(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}