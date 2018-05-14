using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AcmeCareers.Tests
{
    [TestClass]
    public class SeleniumUnitTest
    {
        ChromeDriver driver = new ChromeDriver();
        string URL = "http://localhost:50026";

        [TestMethod]
        public void OpenInLocalHost()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(URL);
            driver.Close();
        }

        [TestMethod]
        public void LoadJobApplicationButton()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(URL);
            if (driver.FindElementById("applyNowBtn").Displayed)
            {
                Console.Write("true");
            }
            driver.Close();
        }

        [TestMethod]
        public void LoadJobInfoData()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(URL);
            System.Threading.Thread.Sleep(2000);
            if (driver.FindElementById("LoadJobInfoData").Displayed)
            {
                Console.Write("true");
            }
;           driver.Close();
        }
    }
}
