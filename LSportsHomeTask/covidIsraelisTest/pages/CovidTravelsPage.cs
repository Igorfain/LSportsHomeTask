using LSportsHomeTask.covidIsraelisTest.Infra;
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

        public void FillPersonalData()
        {
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[contains(text(),'Restrictions and requirements')]")));
            Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("sherpa-widget-container")));


            IWebElement frame1 = Driver.FindElement(By.Id("sherpa-widget-container"));

            Driver.SwitchTo().Frame(frame1).SwitchTo().Frame(0);
            Utils.WaitAndClick(Wait, By.XPath("//div[@id='vaccinationFilter']//span[@class='mat-slide-toggle-thumb']"));

            Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//search-ui-passport-search//sherpa-apps-filter-chip//button"))).Click();
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//input[@placeholder='Choose your passport']"))).SendKeys("Israel");
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//span[contains(text(),' Israel (ISR)')]"))).Click();
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//sherpa-apps-filter-chip//button)[3]"))).Click();
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='Enter city, region or airport']"))).SendKeys("France");
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'France')]"))).Click();

        }

        public bool VerifyPopupInfoIsDisplayed(WebDriverWait wait, string message)
        {
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//sherpa-apps-map-segment-summary//h2")));

            return element.Text.Contains(message);
        }

        public void GetTextFromPopup()
        {
            IWebElement element = Driver.FindElement(By.XPath("//sherpa-apps-map-segment-summary//h2"));
            Console.WriteLine("First paragraph text : " + element.Text);
        }

    }
}
