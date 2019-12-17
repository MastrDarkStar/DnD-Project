using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DnD_Generator
{
    class LevelAgeStats
    {
        Random rnd = new Random();
        public int Level;
        public int Age;
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;
        public int BaseStrength;
        public int BaseDexterity;
        public int BaseConstitution;
        public int BaseIntelligence;
        public int BaseWisdom;
        public int BaseCharisma;
        public int NewAge;
        public int RoughAge;
        public LevelAgeStats()
        {
            
        }

        public void genStrength()
        {
            BaseStrength = rnd.Next(6, 12);
            Strength = BaseStrength + Level;
        }
        public void genDexterity()
        {
            BaseDexterity = rnd.Next(6, 12);
            Dexterity = BaseDexterity + Level;
        }
        public void genConstitution()
        {
            BaseConstitution = rnd.Next(6, 12);
            Constitution = BaseConstitution + Level;
        }
        public void genIntelligence()
        {
            BaseIntelligence = rnd.Next(6, 12);
            Intelligence = BaseIntelligence + Level;
        }
        public void genWisdom()
        {
            BaseWisdom = rnd.Next(6, 12);
            Wisdom = BaseWisdom + Level;
        }
        public void genCharisma()
        {
            BaseCharisma = rnd.Next(6, 12);
            Charisma = BaseCharisma + Level;
        }
        public void genAge()
        {
            RoughAge = rnd.Next(0, 10);
            NewAge = Age + RoughAge -  5; 
        }
    }
}
