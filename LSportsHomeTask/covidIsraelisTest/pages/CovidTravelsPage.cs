using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace LSportsHomeTask.covidIsraelisTest.pages
{
    internal class CovidTravelsPage : BasePage
    {
        public CovidTravelsPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public void FillPersonalData(IWebDriver driver, WebDriverWait wait)
        {

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h3[contains(text(),'Restrictions and requirements')]")));

            IWebElement frame1 = driver.FindElement(By.Id("sherpa-widget-container"));

            driver.SwitchTo().Frame(frame1).SwitchTo().Frame(0);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//search-ui-passport-search//sherpa-apps-filter-chip//button"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(".//input[@placeholder='Choose your passport']"))).SendKeys("Israel");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(".//span[contains(text(),' Israel (ISR)')]"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("(//sherpa-apps-filter-chip//button)[3]"))).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='Enter city, region or airport']"))).SendKeys("France");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(".//span[contains(text(),'France')]"))).Click();
            
        }

        public bool PopupInfoIsDisplayed(IWebDriver driver, WebDriverWait wait , string message)
        {
            IWebElement element =  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//sherpa-apps-map-segment-summary//h2")));
    
            return element.Text.Contains(message); 
            //driver.SwitchTo().DefaultContent();
        }
    }
}
