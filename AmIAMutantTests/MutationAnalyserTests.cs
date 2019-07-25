using System;
using AmIAMutant;
using Xunit;
using Xunit.Sdk;
using Shouldly;

namespace AmIAMutantTests
{
    public class MutationAnalyserTests
    {
        public const  bool CanFly = true;
        public const  bool CantFly = false;

        public const bool CanReadMinds = true;
        public const bool CantReadMinds = false;


        [Fact]
        public void TestForNonMutant()
        {
            // A normal person has no Mutant properties
            var nonMutantPerson = new PersonProperties(PersonProperties.Colours.Black, CantFly, CantReadMinds, 23);
            MutationAnalyser.IsMutant(nonMutantPerson).ShouldBe(false);
        }

        
        [Fact]
        public void TestForMutant()
        {
            // A Mind reader is a Mutant
            var nonMutantPerson = new PersonProperties(PersonProperties.Colours.Black, CantFly, CanReadMinds, 23);
            MutationAnalyser.IsMutant(nonMutantPerson).ShouldBe(true);
        }


        [Fact]
        public void OlderThan120ShouldBeAMutant()
        {
            var nonMutantPerson = new PersonProperties(PersonProperties.Colours.Black, CantFly, CantReadMinds, 121);
            MutationAnalyser.IsMutant(nonMutantPerson).ShouldBe(true);
        }
    }
}
