namespace AmIAMutant
{
    public static class MutationAnalyser 
    {
        // Definition of a Mutant 
        // ----------------------
        // * Hair colour is not blond, black or brown or gray
        // * Can fly
        // * Can read minds 
        // * Is older than 120 years 

        public static bool IsMutant(PersonProperties person)
        {
            if (person.CanFly || person.CanReadMinds) return true;

            if (!System.Enum.IsDefined(typeof(PersonProperties.HairColours), person.HairColour.ToString())) return true;

            if (person.Age > 120) return true;

            return false;
        }

    }
}