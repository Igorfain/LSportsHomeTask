using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LSportsHomeTask.covidIsraelisTest.pages
{
    public class DealsPage : BasePage
    {
        public DealsPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public void SearchEilatHotels(IWebDriver driver, WebDriverWait wait)
        {
            IWebElement element = driver.FindElement(By.Name("ss"));
            element.SendKeys("Eilat");
            IWebElement element1 = driver.FindElement(By.XPath(".//button[@type='submit']"));
            element1.Click();
        }
    }
}
