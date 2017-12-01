using System;
using TechTalk.SpecFlow;

namespace DotNetCoreSpecflow.Steps
{
    [Binding]
    public class AuthorizationSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::1231231");
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::1231231");
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            throw new Exception();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::1231231");
        }


    }
}
