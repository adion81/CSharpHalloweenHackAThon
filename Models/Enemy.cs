namespace HauntedHouse.Models
{
    public abstract class Enemy
    {
        public int AttackStrength;
        public int Health;

        public abstract void Attack(Hero target);
    }
}