using BerlinClock.Classes;
using BoDi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.BDD
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private string _theTime;

        private readonly IObjectContainer objectContainer;

        public TheBerlinClockSteps(IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            var timeConverter = new TimeConverter();
            objectContainer.RegisterInstanceAs<ITimeConverter>(timeConverter);
        }

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            _theTime = time;
        }

        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            ITimeConverter berlinClock = objectContainer.Resolve<ITimeConverter>();

            string convertedTime = berlinClock.ConvertTime(_theTime);

            Assert.AreEqual(theExpectedBerlinClockOutput, convertedTime);
        }
    }
}