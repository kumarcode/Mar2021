using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mar2021.Pages
{
    class TMPage
    {
        public void createTM(IWebDriver driver)
        {
            // *****Create new TM test



            // expect delay
            Thread.Sleep(500);

            // click create new button
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            // expect delay
            Thread.Sleep(500);

            // select time from drop down
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();


            // input code
            driver.FindElement(By.Id("Code")).SendKeys("Mar2021");

            // input description 
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("Mar2021");

            // input price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.XPath("//*[@id='Price']")).SendKeys("765");

            // upload file - to-do
            // click save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            // expect delay
            Thread.Sleep(2500);

            // verify create

            // go to last page
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
            Thread.Sleep(500);


            // verify if the last row contains the record created
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));

            if (actualDescription.Text == "Mar2021")
            {
                Console.WriteLine("TM created, test passed");
            }
            else
            {
                Console.WriteLine("TM test failed");
            }
        }

        public void editTM(IWebDriver driver)
        {
            // **** Edit test script
        }

        public void deleteTM(IWebDriver driver)
        {
            // **** Delete test script

        }
    }
}
