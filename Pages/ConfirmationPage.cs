using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;      //for the WebDriverWait
using SeleniumExtras.WaitHelpers;      //for ExpectedConditions



namespace Selenium_Essential_LinkedIn.Pages
{
    public class ConfirmationPage
    {
        IWebDriver driver;

        public ConfirmationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By alertCtrl = By.ClassName("alert");




        public void waitForAlertMsgOnPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(alertCtrl));
        }

        public string getAlertBannerText(IWebDriver driver)
        {
            return driver.FindElement(alertCtrl).Text;
        }

    }
}
