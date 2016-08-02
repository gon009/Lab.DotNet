using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace SoTour.UI.Tests.AcceptanceTests
{
    [Binding, TestFixture]
    public class ShowNewsSteps
    {
        private IWebDriver driver;
        private string baseURL;

        [SetUp]
        public void SetUpTest()
        {
            driver = new ChromeDriver();
            baseURL = "www.google.com.pe";
        }

        [Given(@"that I enter to the option that shows the news"), Test]
        public void GivenThatIEnterToTheOptionThatShowsTheNews()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        
        [When(@"the view is shown"), Test]
        public void WhenTheViewIsShown()
        {
            driver.Navigate().GoToUrl(baseURL + "/generalnews");
        }
        
        [Then(@"I should see a list of news"), Test]
        public void ThenIShouldSeeAListOfNews()
        {
            Assert.IsTrue(IsElementPresent(By.Id("news_page")));
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
