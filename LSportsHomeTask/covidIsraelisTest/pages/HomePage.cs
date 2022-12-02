using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LSportsHomeTask.covidIsraelisTest.pages
{
    internal class HomePage : BasePage
    {
        public HomePage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public HomePage OpenHomePage(IWebDriver driver, WebDriverWait wait, String pageURL)
        {
            driver.Navigate().GoToUrl(pageURL);

            return this;
        }

        public HomePage ClickAttractionsLink(IWebDriver driver, WebDriverWait wait)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//span[contains(text(),'Attractions')]"))).Click();
            return this;
        }

        public void ClickExploreDealsLink(IWebDriver driver, WebDriverWait wait)
        {
            IWebElement element = driver.FindElement(By.XPath(".//span[contains(text(),'Explore deals')]"));
            element.Click();
        }

    }
}
