using BPCalculator;
using Xunit;

namespace bpUnitTestProject
{
    public class bpUnitTestProject
    {
        public BloodPressure BP;

        //Unit test to check Age Field
        [Theory]
        [InlineData(15)] //low range
        [InlineData(17)] //mid range
        [InlineData(19)] //high range
        public void TestMethodAgeRange1Variables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.AgeGroup1, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(14)] //low range
        [InlineData(20)] //mid range
        [InlineData(10)] //high range
        public void TestMethodAgeRange1Variables_False(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.NotEqual(AgeRange.AgeGroup1, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(20)] //low range
        [InlineData(23)] //mid range
        [InlineData(24)] //high range
        public void TestMethodAgeRange2Variables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.AgeGroup2, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(19)] //low range
        [InlineData(30)] //mid range
        [InlineData(25)] //high range
        public void TestMethodAgeRange2Variables_False(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.NotEqual(AgeRange.AgeGroup2, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(25)] //low range
        [InlineData(28)] //mid range
        [InlineData(29)] //high range
        public void TestMethodAgeRange3Variables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.AgeGroup3, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(24)] //low range
        [InlineData(23)] //mid range
        [InlineData(30)] //high range
        public void TestMethodAgeRange3Variables_False(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.NotEqual(AgeRange.AgeGroup3, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(30)] //low range
        [InlineData(31)] //mid range
        [InlineData(34)] //high range
        public void TestMethodAgeRange4Variables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.AgeGroup4, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(29)] //low range
        [InlineData(28)] //mid range
        [InlineData(35)] //high range
        public void TestMethodAgeRange4Variables_False(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.NotEqual(AgeRange.AgeGroup4, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(35)] //low range
        [InlineData(36)] //mid range
        [InlineData(39)] //high range
        public void TestMethodAgeRange5Variables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.AgeGroup5, BP.AgeGroup);

        }


        //Unit test to check Age Field
        [Theory]
        [InlineData(34)] //low range
        [InlineData(42)] //mid range
        [InlineData(40)] //high range
        public void TestMethodAgeRange5Variables_False(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.NotEqual(AgeRange.AgeGroup5, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(40)] //low range
        [InlineData(43)] //mid range
        [InlineData(44)] //high range
        public void TestMethodAgeRange6Variables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.AgeGroup6, BP.AgeGroup);

        }


        //Unit test to check Age Field
        [Theory]
        [InlineData(39)] //low range
        [InlineData(37)] //mid range
        [InlineData(45)] //high range
        public void TestMethodAgeRange6Variables_False(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.NotEqual(AgeRange.AgeGroup6, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(45)] //low range
        [InlineData(48)] //mid range
        [InlineData(49)] //high range
        public void TestMethodAgeRange7Variables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.AgeGroup7, BP.AgeGroup);

        }


        //Unit test to check Age Field
        [Theory]
        [InlineData(44)] //low range
        [InlineData(51)] //mid range
        [InlineData(50)] //high range
        public void TestMethodAgeRange7Variables_False(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.NotEqual(AgeRange.AgeGroup7, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(50)] //low range
        [InlineData(51)] //mid range
        [InlineData(54)] //high range
        public void TestMethodAgeRange8Variables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.AgeGroup8, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(49)] //low range
        [InlineData(46)] //mid range
        [InlineData(55)] //high range
        public void TestMethodAgeRange8Variables_False(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.NotEqual(AgeRange.AgeGroup8, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(55)] //low range
        [InlineData(57)] //mid range
        [InlineData(59)] //high range
        public void TestMethodAgeRange9Variables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.AgeGroup9, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(54)] //low range
        [InlineData(62)] //mid range
        [InlineData(60)] //high range
        public void TestMethodAgeRange9Variables_False(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.NotEqual(AgeRange.AgeGroup9, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(60)] //low range
        [InlineData(65)] //mid range
        [InlineData(70)] //high range
        public void TestMethodAgeRange10Variables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.AgeGroup10, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(59)] //low range
        [InlineData(10)] //mid range
        [InlineData(101)] //high range
        public void TestMethodAgeRange10Variables_False(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.NotEqual(AgeRange.AgeGroup10, BP.AgeGroup);

        }

        //Unit test to check Age Field
        [Theory]
        [InlineData(14)] //low range
        [InlineData(101)] //mid range
        [InlineData(10)] //high range
        public void TestMethodNoAgeRangeVariables(int ageValue)
        {

            BP = new BloodPressure() { Age = ageValue };
            Assert.Equal(AgeRange.NoAgeGroup, BP.AgeGroup);

        }

    }

}
