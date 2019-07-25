namespace AmIAMutant
{
    public static class MutationAnalyser 
    {
        // hair colour is not blond, black or brown or gray
        // Can fly
        // can read minds 
        // is 120 years or older 

        public static bool IsMutant(PersonProperties person)
        {
            if (person.CanFly || person.CanReadMinds) return true;

            if (!System.Enum.IsDefined(typeof(PersonProperties.HairColours), person.HairColour.ToString())) return true;

            if (person.Age > 120) return true;

            return false;
        }

    }
}