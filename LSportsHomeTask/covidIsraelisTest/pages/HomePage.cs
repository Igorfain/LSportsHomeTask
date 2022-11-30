using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace LSportsHomeTask.covidIsraelisTest.pages
{
    internal class HomePage :BasePage
    {
        public HomePage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
       
        public HomePage OpenHomePage(IWebDriver driver,WebDriverWait wait,String pageURL)
        {
            driver.Navigate().GoToUrl(pageURL);
            
           return this;
        }

        public HomePage ClickAttractionsLink(IWebDriver driver,WebDriverWait wait) 
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(".//span[contains(text(),'Attractions')]"))).Click();
            return this;
        }
        
    }
}
