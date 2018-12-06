using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Character
    {
        //Attribute
        private int id;
        private string firstname;
        private string lastname;
        private int age;
        private string race;
        private TypeOfSoldier typeOfSoldier;

        //Constructors
        public Character(int id, string firstname, string lastname, int age, string race, TypeOfSoldier typeOfSoldier)
        {
            this.Id = id;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
            this.Race = race;
            this.TypeOfSoldier = typeOfSoldier;
        }

        public Character(){
            this.Id = 0;
            this.Firstname = "";
            this.Lastname = "";
            this.Age = 0;
            this.Race = "";
            this.TypeOfSoldier = TypeOfSoldier.Other;
        }

        //Getter&Setter
        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public int Age { get => age; set => age = value; }
        public string Race { get => race; set => race = value; }
        public TypeOfSoldier TypeOfSoldier { get => typeOfSoldier; set => typeOfSoldier = value; }

        //ToString
        public override string ToString()
        {
            string tmp = "";
            tmp += "ID : " + this.Id + " / Firstname : " + this.Firstname + " / Lastname : " + this.Lastname + " / Age : " + this.Age + " / Race : " + this.Race + " / Type of soldier : " + this.TypeOfSoldier;
            return tmp;
        }

    }
}
