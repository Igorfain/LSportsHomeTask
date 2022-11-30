using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSportsHomeTask.covidIsraelisTest.pages
{
    internal class EilatSearchResultPage : BasePage
    {
        public EilatSearchResultPage(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public void SelectVeryGoodCheckBox(IWebDriver driver, WebDriverWait wait)
        {  
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,2700)");
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(".//h3[contains(text(),'Review score')")));
            IWebElement reviewScoreSection = driver.FindElement(By.XPath(".//h3[contains(text(),'Review score')]"));
            IWebElement veryGoodCheckBoxLocator = driver.FindElement(By.XPath(".//div[contains(text(),'Very good: 8+')]"));
            veryGoodCheckBoxLocator.Click();
        }
    }
}
