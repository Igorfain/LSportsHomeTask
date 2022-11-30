﻿using NUnit.Framework;
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
            //driver.SwitchTo().Window(driver.WindowHandles.First()).Close();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h3[contains(text(),'Restrictions and requirements')]")));
          //  wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(".//iframe[@title='sherpa° Map']")));

           // driver.SwitchTo().Frame("sherpa° Map");
           // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(".//button[@class='mat-focus-indicator mat-flat-button mat-button-base filter'][1]")));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(".//input[@placeholder='Choose your passport']"))).SendKeys("Israel");
           // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(".//span[contains(text(),' Israel (ISR)')]"))).Click();

        }

        public bool PopupInfoIsDisplayed(IWebDriver driver,WebDriverWait wait) 
        {
          
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//sherpa-apps-map-segment//h2[@class='mat-subheading-1']")));
            IWebElement popupContainerLocator = driver.FindElement(By.XPath("//sherpa-apps-map-segment//h2[@class='mat-subheading-1']"));
            return driver.Equals(popupContainerLocator);
        }
    }
}
