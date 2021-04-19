using Mar2021.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mar2021.Utilities
{
    class CommonDriver
    {
        // init driver
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginTM()
        {
            Console.WriteLine("Hello World!");

            // launch turnup portal 
            driver = new ChromeDriver(@"S:\Mar2021\");

            // page objects for login
            LoginPage loginObj = new LoginPage();
            loginObj.loginSteps(driver);
        }


        [OneTimeTearDown]
        public void FinalSteps()
        {
            // close driver
            driver.Close();
        }
    }
}
