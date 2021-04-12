using Mar2021.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Mar2021
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // launch turnup portal 
            IWebDriver driver = new ChromeDriver(@"S:\Mar2021\");

            // page objects for login
            LoginPage loginObj = new LoginPage();
            loginObj.loginSteps(driver);

            // home page object
            HomePage homeObj = new HomePage();
            homeObj.navigateToTM(driver);

            // tm page object
            TMPage tmObj = new TMPage();
            tmObj.createTM(driver);
            tmObj.editTM(driver);
            tmObj.deleteTM(driver);

        }
        
    }
}
