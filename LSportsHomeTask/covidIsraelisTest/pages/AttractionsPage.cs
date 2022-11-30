using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace LSportsHomeTask.covidIsraelisTest.pages
{
    public class AttractionsPage : BasePage
    {
        public AttractionsPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public void ClickReadMoreLink(IWebDriver driver, WebDriverWait wait)
        { 
           wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText("Read more"))).Click();
           
        }
    }
}
