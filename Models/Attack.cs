namespace HauntedHouse.Models
{
    public class Attacker : Hero
    {
        public Attacker(string name ) : base(name)
        {
            Name = name;
            Sheild = 3;
            AttackStrength = 9;
            health = 5;
        }
        public override void Attack(Enemy target)
        {
            //Write Custom attack methods;
        }
    }
}