using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyUnitTestTask
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("https://www.booking.com");
        }

        [TestMethod]
        public void Task()
        {
            QAPageObject page = new QAPageObject();

            page.Language();

            page.txtPlace.SendKeys("New York");

            page.CheckIn("05", "01", "2020");

            page.CheckOut("05", "30", "2020");

            page.btnSearch.Click();

            Context.GetHtmlAsync();

        }
    }
    
}
