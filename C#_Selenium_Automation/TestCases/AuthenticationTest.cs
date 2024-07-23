
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace C__Selenium_Automation.TestCases
{
    internal class AuthenticationTest
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.demoblaze.com/index.html";

 
            // Clicking login link
            driver.FindElement(By.Id("login2")).Click();

            //Populating required fields
            driver.FindElement(By.Id("loginusername")).SendKeys("automation_testuser");
            driver.FindElement(By.Id("loginpassword")).SendKeys("password123");

            // Clicking login button
            driver.FindElement(By.XPath("//button[contains(text(),'Log in')]")).Click();

            // Close the driver
            driver.Quit();

        }
    }
}
