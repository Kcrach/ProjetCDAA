using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Planet
    {
        //Attributes
        private int id;
        private string name;
        private string localization;
        private int population;
        private string language;
        private string climate;
        private Characters charactersFrom;

        //Constructor
        public Planet(int id, string name, string localization, int population, string language, string climate, Characters charactersFrom)
        {
            this.Id = id;
            this.Name = name;
            this.Localization = localization;
            this.Population = population;
            this.Language = language;
            this.Climate = climate;
            this.CharactersFrom = charactersFrom;
        }

        public Planet(){
            this.charactersFrom = new Characters();
        }

        //Getter&Setter
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Localization { get => localization; set => localization = value; }
        public int Population { get => population; set => population = value; }
        public string Language { get => language; set => language = value; }
        public string Climate { get => climate; set => climate = value; }
        internal Characters CharactersFrom { get => charactersFrom; set => charactersFrom = value; }

        //Overrides
        //ToString
        public override string ToString()
        {
            string tmp = "";
            tmp += "ID : " + this.Id + " / Name : " + this.Name + " / Localization : " + this.Localization + " / Population : " + this.Population + " / Language : " + this.Language + " / Climate : " + this.Climate + "\n";
            tmp += "Characters from this planet : \n";
            for(int i = 0; i < this.CharactersFrom.ListCharacter.Count; i++)
            {
                tmp += "  - " + this.CharactersFrom.ListCharacter[i].ToString()+"\n";   
            }
            return tmp;
        }

        //Methods
        public void addCharacter(Character cToAdd)
        {
            this.CharactersFrom.addCharacter(cToAdd);
        }


    }
}
