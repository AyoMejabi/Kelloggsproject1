using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Kelloggsproject1
{
    [Binding]
    public sealed class Searchspecdef
    {
        public IWebDriver driver;

        [Given(@"I navigate to Kelloggs website")]
        public void GivenINavigateToKelloggsWebsite()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.kelloggs.co.uk/en_GB/home.html");  
        }

        [Given(@"I hover over to the search text field")]
        public void GivenIHoverOverToTheSearchTextField()
        {
            
        }

        [When(@"I type in cornflakes")]
        public void WhenITypeInCornflakes()
        {
            
        }

        [When(@"I clcik the search button")]
        public void WhenIClcikTheSearchButton()
        {
            
        }

        [Then(@"the different flavours of cornflakes will be displayed on the screen")]
        public void ThenTheDifferentFlavoursOfCornflakesWillBeDisplayedOnTheScreen()
        {
            
        }

        [When(@"I type in cocopops")]
        public void WhenITypeInCocopops()
        {
            
        }

        [Then(@"the different flavours of cocopops will be displayed on the screen")]
        public void ThenTheDifferentFlavoursOfCocopopsWillBeDisplayedOnTheScreen()
        {
            
        }

        [When(@"I type in crunchy nuts")]
        public void WhenITypeInCrunchyNuts()
        {
            
        }

        [Then(@"the different flavours of crunchy nuts will be displayed on the screen")]
        public void ThenTheDifferentFlavoursOfCrunchyNutsWillBeDisplayedOnTheScreen()
        {
            
        }

    }
}
