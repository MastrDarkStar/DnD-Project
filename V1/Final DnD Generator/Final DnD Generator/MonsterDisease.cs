using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DnD_Generator
{
    class MonsterDisease
    {
        Random rnd = new Random();
        public string type;
        public int typePick;
        public string disease;
        public int diseasePick;
        public bool IsMonster;
        public bool IsDiseased;
        public string disease1 = "Amnesiac";
        public string disease2 = "Skullshivers";
        public string disease3 = "RockJoint";
        public string disease4 = "RustJaw";
        public string type1 = "Fey";
        public string type2 = "Fiend";
        public string type3 = "Celestial";
        public string type4 = "Construct";

        public void genIllness()
        {
            if(IsDiseased == true)
            {
                diseasePick = rnd.Next(1, 4);
                if(diseasePick == 1)
                {
                    disease = disease1;
                }
                if (diseasePick == 2)
                {
                    disease = disease2;
                }
                if (diseasePick == 3)
                {
                    disease = disease3;
                }
                if (diseasePick == 4)
                {
                    disease = disease4;
                }
            }
        }
        public void genType()
        {
            if (IsMonster == true)
            {
                typePick = rnd.Next(1, 4);
                if (typePick == 1)
                {
                    type = type1;
                }
                if (typePick == 2)
                {
                    type = type2;
                }
                if (typePick == 3)
                {
                    type = type3;
                }
                if (typePick == 4)
                {
                    type = type4;
                }
            }
        }
    }
}

