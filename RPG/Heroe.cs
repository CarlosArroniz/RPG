using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    
    class Heroe
    {        

        string[,] wiz_weapons = {{"1.- Wand","30"},{"2.- Magical Spear","40"},{"3.- Spells","60"},{"4.- Necromancy","80"}};
        string[,] elf_weapons = {{"1.- Bow","30"},{"2.- Shadows Dagger","40"},{"3.- Spear","60"},{"4.- Chaos Crossbow","80"}};
        string[,] war_weapons = {{"1.- Sword","30"},{"2.- Ogre Warmaul","40"},{"3.- War Hammer","60"},{"4.- Battle Axe","80"}};

        string wpn1 { get; set; }
        string wpn2 { get; set; }
        string attack { get; set; }
        string esp_attack { get; set; }

        public void CrearHeroe(string hero)
        {
            Console.WriteLine("It's danger to go alone, choose your " + hero + " weapons: ");
            Console.WriteLine();
            Console.WriteLine("Weapon - Damage");

            switch (hero)
            {
                case "Elf":
                    for (int i = 0; i <= elf_weapons.Length; i++)
                    {
                        Console.WriteLine(elf_weapons[]);
                    }
                    break;

                case "Wizard":
                    for (int i = 0; i < elf_weapons.Length; i++)
                    {
                        Console.WriteLine(wiz_weapons[i, i]);
                    }
                    break;

                case "Warrior":
                    for (int i = 0; i < elf_weapons.Length; i++)
                    {
                        Console.WriteLine(war_weapons[i, i]);
                    }
                    break;
            }
            Console.ReadKey();
        }

    }
}
