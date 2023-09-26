using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static int health;
        static int lives;

        static void Main(string[] args)
        {
            Console.WriteLine("Conditional");
            Console.WriteLine("-----------");
            Console.WriteLine("Text based HUD");

            //initiallizations
            health = 100;
            lives = 1;

            //sample gameplay
            ShowHUD();
            TakeDamage(8);
            ShowHUD();
            TakeDamage(24);
            ShowHUD();
            TakeDamage(57);
            ShowHUD();
            TakeDamage(1000);
            ShowHUD();
            TakeDamage(50);

            Console.WriteLine("");
            Console.WriteLine("Press any key");
            Console.ReadKey(true);

        }

        static void ShowHUD()
        {
            Console.WriteLine(" Health: " + health);
            Console.WriteLine(" Lives " + lives);
            Console.ReadKey(true);
            if (lives <= -1)
            {
                health = 0;
                lives = 0;
                Console.WriteLine(" GameOver ");
            }
        }

        static void TakeDamage(int damage) 
        {
            //apply damage
            Console.WriteLine(" Player takes " + damage + " damage ");
            health = health - damage;

            //range check health 0...100
            if (health <= 0)
            {
                //Player died on console
                Console.WriteLine("Player died.");

                //take away live
                lives = lives - 1;

                //set health to be 0
                health = 50;

                if (lives <= -1)
                {
                    health = 0;
                    lives = 0;
                    Console.WriteLine("Game Over");
                }
                    

            }
        }
    }
}
