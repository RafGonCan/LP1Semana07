using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace MyRoguelike
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Hero player = new Hero("Dragonborn");

            Console.WriteLine($"Name: {player.Name}");      // Name: Hero
            Console.WriteLine($"Level: {player.Level}");    // Level: 1
            Console.WriteLine($"XP: {player.XP}");          // XP: 0
            Console.WriteLine($"Health: {player.Health}/{player.MaxHealth}"); // Health: 100/100

            player.XP = 2500; // Aumenta XP para 2500
            Console.WriteLine($"Level: {player.Level}");    // Level: 3
            Console.WriteLine($"XP: {player.XP}");          // XP: 2500
            Console.WriteLine($"MaxHealth: {player.MaxHealth}"); // MaxHealth: 140

            player.TakeDamage(45);
            Console.WriteLine($"Health: {player.Health}/{player.MaxHealth}"); // Health: 55/140
            Console.WriteLine($"XP: {player.XP}");          // XP: 2502
            Console.WriteLine($"Level: {player.Level}");    // Level: 3

            player.Health = -10;  // Tentativa de colocar health negativa
            Console.WriteLine($"Health: {player.Health}");  // Health: 0

            player.Health = 5000; // Tentativa de ultrapassar maxHealth
            Console.WriteLine($"Health: {player.Health}/{player.MaxHealth}"); // Health: 140/140

            // Output esperado:
            //
            // Name: Dragonborn
            // Level: 1
            // XP: 0
            // Health: 100/100
            // Level: 3
            // XP: 2500
            // MaxHealth: 140
            // Health: 55/140
            // XP: 2502
            // Level: 3
            // Health: 0
            // Health: 140/140
        }
        
        public class Hero
        {
            public string Name {get;}
            private int xp;
            private float health;
            readonly int level;
            readonly float maxHealth;

            private int XP
            {
                get => xp;
                set
                {
                    xp ++;
                }
            }
             private float Health
            {
                get => health;
                set
                {
                    if (health < 0)
                    {
                        health = 0;
                    }
                }
            }
        }
    }
}
