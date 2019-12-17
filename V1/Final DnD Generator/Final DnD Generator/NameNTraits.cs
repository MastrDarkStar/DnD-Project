using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DnD_Generator
{
    class NameNTraits
    {
        Random rnd = new Random();
        public string Ideal;
        public string Flaw;
        public string Bond;
        public string Trait;
        public string Quirk;
        public int TraitPick;
        public int FlawPick;
        public int IdealPick;
        public int BondPick;
        public int QuirkPick;
        public string Trait1 = "Caring";
        public string Trait2 = "Shifty";
        public string Trait3 = "Evil";
        public string Trait4 = "Honorable";
        public string Flaw1 = "Greedy";
        public string Flaw2 = "Forgetful";
        public string Flaw3 = "Prideful";
        public string Flaw4 = "Hot-Headed";
        public string Bond1 = "Family First";
        public string Bond2 = "Church First";
        public string Bond3 = "Money First";
        public string Bond4 = "Partners First";
        public string Ideal1 = "I am Strong but Fair";
        public string Ideal2 = "Win by Any Means";
        public string Ideal3 = "Care for Others";
        public string Ideal4 = "Weakness should be crushed";
        public string Quirk1 = "Scars";
        public string Quirk2 = "Eyepatch";
        public string Quirk3 = "Weird Speech";
        public string Quirk4 = "None";
        public void MakingTraits()
        {
            TraitPick = rnd.Next(1, 5);
            FlawPick = rnd.Next(1, 5);
            BondPick = rnd.Next(1, 5);
            IdealPick = rnd.Next(1, 5);
            QuirkPick = rnd.Next(1, 5);

            if (TraitPick == 1)
            {
                Trait = Trait1;
            }
            if (TraitPick == 2)
            {
                Trait = Trait2;
            }
            if (TraitPick == 3)
            {
                Trait = Trait3;
            }
            if (TraitPick == 4)
            {
                Trait = Trait4;
            }
            if (IdealPick == 1)
            {
                Ideal = Ideal1;
            }
            if (IdealPick == 2)
            {
                Ideal = Ideal2;
            }
            if (IdealPick == 3)
            {
                Ideal = Ideal3;
            }
            if (IdealPick == 4)
            {
                Ideal = Ideal4;
            }
            if (FlawPick == 1)
            {
                Flaw = Flaw1;
            }
            if (FlawPick == 2)
            {
                Flaw = Flaw2;
            }
            if (FlawPick == 3)
            {
                Flaw = Flaw3;
            }
            if (FlawPick == 4)
            {
                Flaw = Flaw4;
            }
            if (QuirkPick == 1)
            {
                Quirk = Quirk1;
            }
            if (QuirkPick == 2)
            {
                Quirk = Quirk2;
            }
            if (QuirkPick == 3)
            {
                Quirk = Quirk3;
            }
            if (QuirkPick == 4)
            {
                Quirk = Quirk4;
            }
            if (BondPick == 1)
            {
                Bond = Bond1;
            }
            if (BondPick == 2)
            {
                Bond = Bond2;
            }
            if (BondPick == 3)
            {
                Bond = Bond3;
            }
            if (BondPick == 4)
            {
                Bond = Bond4;
            }
        }
       
    }
}
