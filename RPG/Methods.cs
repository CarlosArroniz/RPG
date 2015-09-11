using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Methods
    {
        Heroe myHero = new Heroe();
       string opc;
        public void Menu()
        {
            string[] hero = { "1.- Elf", "2.- Wizzar", "3.- Warrior" };

            Console.WriteLine("Bienvenido al DOTA del getto xD");
            Console.WriteLine();
            Console.WriteLine("Choose your hero!!");
            Console.WriteLine();

            for (int i = 0; i < hero.Length; i++)
            {
                Console.WriteLine(hero[i]);
            }
            opc = Console.ReadLine();
            switch (opc)
            {
                case "1":
                    Console.WriteLine("You have chosen to be an Elf.");
                    myHero.CrearHeroe("Elf");
                    break;
                case "2":
                    Console.WriteLine("You have chosen to be a Wizard.");
                    myHero.CrearHeroe("Wizard");
                    break;
                case "3":
                    Console.WriteLine("You have chosen to be a Warrior.");
                    myHero.CrearHeroe("Warrior");
                    break;
            }
            Console.ReadKey();
        }
    }
}
