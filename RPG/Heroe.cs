using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Heroe
    {

        string[] wiz_weapons = { "1.- Wand", "2.- Magical Spear" };
        string[] elf_weapons = { "1.-Bow", "2.-Shadow Dagger" };
        string[] war_weapons = { "1.-Sword", "2.- Ogre Warmaul" };

        string wpn1 { get; set; }
        string wpn2 { get; set; }
        string attack { get; set; }
        string esp_attack { get; set; }



        public void CrearHeroe(string hero)
        {
            Console.WriteLine("It's danger to go alone, choose your " + hero + " weapons: ");
            Console.WriteLine();

            switch (hero)
            {
                case "Elf":
                    for (int i = 0; i < elf_weapons.Length; i++)
                    {
                        Console.WriteLine(elf_weapons[i]);
                    }
                    break;

                case "Wizard":
                    for (int i = 0; i < elf_weapons.Length; i++)
                    {
                        Console.WriteLine(wiz_weapons[i]);
                    }
                    break;

                case "Warrior":
                    for (int i = 0; i < elf_weapons.Length; i++)
                    {
                        Console.WriteLine(war_weapons[i]);
                    }
                    break;
            }
            Console.ReadKey();
        }

    }
}
