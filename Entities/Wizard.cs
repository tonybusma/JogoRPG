namespace JogoRPG.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name;
        public int Level;
        public string HeroType;
        public override string Attack()
        {
          return this.Name + " lançou Magia.";      
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou uma Magia forte com bônus de ataque de " + Bonus;
            }
            else
            {
                return this.Name + " lançou uma Magia fraca com bônus de ataque de " + Bonus;
            }
            
        }
    }
}