using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

//using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Support.UI;      //for the WebDriverWait
//using SeleniumExtras.WaitHelpers;      //for ExpectedConditions




namespace Selenium_Essential_LinkedIn.Pages
{
    public class FormPage
    {
        IWebDriver driver;


        By datePicker = By.Id("datepicker");

        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    
        public void submitForm()
        {
            IWebElement firstNameField = driver.FindElement(By.Id("first-name"));
            firstNameField.SendKeys("John");

            IWebElement lastNameField = driver.FindElement(By.Id("last-name"));
            lastNameField.SendKeys("Doe");

            IWebElement JobTitleField = driver.FindElement(By.Id("job-title"));
            JobTitleField.SendKeys("QA Engineer");

            IWebElement eduLevelField = driver.FindElement(By.Id("radio-button-3"));
            eduLevelField.Click();

            IWebElement sexField = driver.FindElement(By.Id("checkbox-2"));
            sexField.Click();

            IWebElement ddlItem = driver.FindElement(By.CssSelector("option[value='3']"));
            ddlItem.Click();

            IWebElement dateField = driver.FindElement(datePicker);
            dateField.SendKeys(String.Format("{0}/{1}/{2}", DateTime.Now.Month, DateTime.Now.Day + 1, DateTime.Now.Year));
            dateField.SendKeys(Keys.Enter); //close the calender popup 

            IWebElement submitBtn = driver.FindElement(By.CssSelector(".btn.btn-lg.btn-primary"));
            submitBtn.Click();
        }
    }
}
