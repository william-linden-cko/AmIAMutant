using System;

namespace AmIAMutant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mutant ");
        }
    }

    public class PersonProperties
    {
        public PersonProperties(Colours hairColour, bool canFly, bool canReadMinds, int age)
        {
            HairColour = hairColour;
            CanFly = canFly;
            CanReadMinds = canReadMinds;
            Age = age;
        }

        public enum Colours
        {
            Blond, 
            Black,
            Brown,
            Grey, 
            Pink,
            Silver,
            Gold
        }

        public enum HairColours
        {
            Blond,
            Black,
            Brown,
            Grey
        }

        public Colours HairColour { get; set; }
        public bool CanFly { get; set; }
        public bool CanReadMinds { get; set; }
        public int Age { get; set; }

    }
}
