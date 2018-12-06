using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class DeadCharacter : Character
    {
        //Attribute
        private int yearOfTheDeath;

        //Constructors
        public DeadCharacter(int id, string firstname, string lastname, int age, string race, TypeOfSoldier typeOfSoldier, int yearOfTheDeath) : base(id,firstname,lastname,age,race,typeOfSoldier)
        {
            this.YearOfTheDeath = yearOfTheDeath;
        }

        public DeadCharacter() : base()
        {
            this.YearOfTheDeath = 0;
        }

        //Get&Set
        public int YearOfTheDeath { get => yearOfTheDeath; set => yearOfTheDeath = value; }

        //Overrides
        //ToString
        public override string ToString()
        {
            string tmp = "";
            tmp = base.ToString();
            tmp += " / Year of death : " + this.YearOfTheDeath;
            return tmp;
        }
    }
}
