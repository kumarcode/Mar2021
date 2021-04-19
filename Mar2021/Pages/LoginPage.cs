using Mar2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mar2021.Pages
{
    class LoginPage
    {
        public void loginSteps(IWebDriver driver)
        {

            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // maximize browser
            driver.Manage().Window.Maximize();

            try
            {
                Wait.ElementExists(driver, "Id", "UserName", 5);

                // identify and enter username
                IWebElement username = driver.FindElement(By.Id("UserName"));
                username.SendKeys("hari");

                // identify and enter password
                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("123123");

                // identify and click login button
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
            }
            catch(Exception msg)
            {
                Assert.Fail("Test failed at login page", msg.Message);
            }

            Wait.ElementExists(driver, "XPath", "//*[@id='logoutForm']/ul/li/a", 2);

            // validate if the user is logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed");
            }
            else
            {
                Console.WriteLine("Login failed, test failed");
            }

        }
    }
}
