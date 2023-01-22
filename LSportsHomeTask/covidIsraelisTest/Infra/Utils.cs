using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace LSportsHomeTask.covidIsraelisTest.Infra
{
    public static class Utils
    {
        public static void WaitAndClick(WebDriverWait wait, By elementBy)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(elementBy)).Click();
        }
    }
}
