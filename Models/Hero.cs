namespace HauntedHouse.Models
{
    public abstract class Hero
    {
        public string Name;

        public int AttackStrength;

        public int Sheild;

        protected int health;

        public Hero(string name)
        {
            Name = name;
            AttackStrength = 3;
            Sheild = 3;
            health = 3;
        }

        public abstract void Attack(Enemy target);

    }
}