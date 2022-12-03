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
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[contains(text(),'Restrictions and requirements')]")));

            IWebElement frame1 = driver.FindElement(By.Id("sherpa-widget-container"));

            driver.SwitchTo().Frame(frame1).SwitchTo().Frame(0);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//search-ui-passport-search//sherpa-apps-filter-chip//button"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//input[@placeholder='Choose your passport']"))).SendKeys("Israel");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//span[contains(text(),' Israel (ISR)')]"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//sherpa-apps-filter-chip//button)[3]"))).Click();
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Enter city, region or airport']"))).SendKeys("France");
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//span[contains(text(),'France')]"))).Click();

        }

        public bool VerifyPopupInfoIsDisplayed(IWebDriver driver, WebDriverWait wait, string message)
        {
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//sherpa-apps-map-segment-summary//h2")));

            return element.Text.Contains(message);
        }

        public void GetTextFromPopup(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//sherpa-apps-map-segment-summary//h2"));
            Console.WriteLine("First paragraph text : " + element.Text);
        }

    }
}
