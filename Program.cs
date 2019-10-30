using System;
using HauntedHouse.Models;

namespace HauntedHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("************WELCOME TO HAUNTED HOUSE************");
            Console.ResetColor();


            Hero player = ChooseHero();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You, {player.Name}, have been summoned to Dojo Manor by Count Brakula,\nwho is not a vampire, to exterminate the spooky entities that dwell inside.\nYou are supicious of Count Brakula, but accept the job anyway.\nPress Enter/Return to begin...");
            Console.ResetColor();


            ConsoleKey key  = Console.ReadKey(true).Key;
            while(key != ConsoleKey.Enter)
            {
                key  = Console.ReadKey(true).Key;
            }
            Console.WriteLine("BEGIN YOUR ADVENTURE HERE!!!");
            
        }
        public static Hero ChooseHero()
        {
            Console.WriteLine("Choose which type of hero you would like to be...");
            Console.WriteLine("1 : Attacker.");
            Console.WriteLine("2 : Shield.");
            Console.WriteLine("3 : Heal.");
            Console.WriteLine("Type the number of the corresponding hero...");
            string choice = Console.ReadLine();
            Console.WriteLine("What is your character's name?");
            string name = Console.ReadLine();

            // if( choice == "1")
            // {
                //CREATE ATTACK HERO
                Attacker hero = new Attacker(name);
                return hero;
            // }
            
            
            
        }
    }
}
