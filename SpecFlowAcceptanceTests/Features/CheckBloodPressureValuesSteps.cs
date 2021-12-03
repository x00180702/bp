using System;
using BPCalculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowAcceptanceTests.Features
{
    [Binding]
    public class CheckBloodPressureValuesSteps
    {
        private BloodPressure? bloodPressure;

        [Given(@"user enters (.*) in Systolic")]
        public void GivenUserEntersInSystolic(String value)
        {
            int sys = Int16.Parse(value);
            bloodPressure = new BloodPressure
            {
                Systolic = sys
            };
        }

        [Given(@"user enters (.*) in Diastolic")]
        public void GivenUserEntersInDiastolic(String value)
        {
            int dias = Int16.Parse(value);
            bloodPressure = new BloodPressure
            {
                Diastolic = dias
            };
        }

        [Given(@"user enters (.*) in Age")]
        public void GivenUserEntersInAge(string value)
        {
            int age = Int16.Parse(value);
            bloodPressure = new BloodPressure
            {
                Age = age
            };
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            Assert.AreEqual(result, bloodPressure.Category.ToString());
        }


        [Given(@"Age range should be AgeGroup(.*)")]
        public void GivenAgeRangeShouldBeAgeGroup(int result)
        {
            String results = "AgeGroup" + result;
            Assert.AreEqual(results, bloodPressure.AgeGroup.ToString());
        }





    }
}
