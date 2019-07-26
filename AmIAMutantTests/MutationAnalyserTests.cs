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
            var mutantPerson = new PersonProperties(PersonProperties.Colours.Brown, CantFly, CanReadMinds, 23);
            MutationAnalyser.IsMutant(mutantPerson).ShouldBe(true);
        }

        [Theory]
        [InlineData(PersonProperties.Colours.Blond, false, false, 121, true)]
        [InlineData(PersonProperties.Colours.Blond, false, false, 120, false)]
        [InlineData(PersonProperties.Colours.Blond, false, false, 119, false)]
        public void OlderThan120ShouldBeAMutant(PersonProperties.Colours hair, bool canFly, bool canReadMinds, int age, bool expected)
        {
            var mutantPerson = new PersonProperties(hair, canFly, canReadMinds, age);
            MutationAnalyser.IsMutant(mutantPerson).ShouldBe(expected);
        }


        [Fact]
        public void TestForMutantHairColours()
        {
            var mutantPerson = new PersonProperties(PersonProperties.Colours.Pink, CantFly, CantReadMinds, 23);
            MutationAnalyser.IsMutant(mutantPerson).ShouldBe(true);

            mutantPerson = new PersonProperties(PersonProperties.Colours.Gold, CantFly, CantReadMinds, 23);
            MutationAnalyser.IsMutant(mutantPerson).ShouldBe(true);

            mutantPerson = new PersonProperties(PersonProperties.Colours.Silver, CantFly, CantReadMinds, 23);
            MutationAnalyser.IsMutant(mutantPerson).ShouldBe(true);
        }

    }
}
