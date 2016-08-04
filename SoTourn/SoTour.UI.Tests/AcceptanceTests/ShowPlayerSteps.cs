using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;


namespace SoTour.UI.Tests.AcceptanceTests
{
    [Binding,TestFixture]
    public class ShowPlayerSteps
    {
        private IWebDriver driver;
        private string baseURL;

        [SetUp]
        public void SetUpTest()
        {
            driver = new FirefoxDriver();
            baseURL = "www.google.com.pe";
        }

        [Given(@"that I enter the name of a player"), Test]
        public void GivenThatIEnterTheNameOfAPlayer()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.FindElement(By.Id("lst-ib")).SendKeys("Jugador");
        }

        [Given(@"click to search that player"), Test]
        public void GivenClickToSearchThatPlayer()
        {
            driver.FindElement(By.Name("btnG")).Click();
        }

        [When(@"the grid is shown"), Test]
        public void WhenTheGridIsShown()
        {
            driver.Navigate().GoToUrl(baseURL + "/infoaboutplayers");
        }

        [Then(@"I should see that player with his information"), Test]
        public void ThenIShouldSeeThatPlayerWithHisInformation()
        {
            Assert.IsTrue(IsElementPresent(By.Id("rcnt")));
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

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}
