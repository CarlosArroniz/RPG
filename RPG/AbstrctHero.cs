using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class AbstrctHero : Heroe
    {
        abstract class Hero
        {
            public abstract string weapon1 { get; set; }
            public abstract string weapon2 { get; set; }
            public abstract string hero { get; set; }
            public abstract int damage_wpn1 { get; set; }
            public abstract int damage_wpn2 { get; set; }
        }//Hero

        abstract class HeroFactory{

            public abstract getHero();
        
        }/

    }
}
