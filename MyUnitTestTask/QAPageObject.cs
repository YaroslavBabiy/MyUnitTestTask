using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnitTestTask
{
    class QAPageObject
    {
        public QAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "uc_language")]
        public IWebElement btnLanguage { get; set; }
        [FindsBy(How = How.ClassName, Using = "slang-us")]
        public IWebElement btnUSA { get; set; }

        [FindsBy(How = How.Id, Using = "ss")]
        public IWebElement txtPlace { get; set; }

        [FindsBy(How = How.Name, Using = "checkin_month")]
        public IWebElement txtCheckin_month { get; set; }
        [FindsBy(How = How.Name, Using = "checkin_monthday")]
        public IWebElement txtCheckin_monthday { get; set; }
        [FindsBy(How = How.Name, Using = "checkin_year")]
        public IWebElement txtCheckin_year { get; set; }

        [FindsBy(How = How.Name, Using = "checkout_month")]
        public IWebElement txtCheckout_month { get; set; }
        [FindsBy(How = How.Name, Using = "checkout_monthday")]
        public IWebElement txtCheckout_monthday { get; set; }
        [FindsBy(How = How.Name, Using = "checkout_year")]
        public IWebElement txtCheckout_year { get; set; }

        [FindsBy(How = How.ClassName, Using = "sb-searchbox__button")]
        public IWebElement btnSearch { get; set; }

        public void Language()
        {
            btnLanguage.Click();
            btnUSA.Click();
        }

        public void CheckIn(string checkin_month, string checkin_monthday, string checkin_year)
        {
            txtCheckin_month.SendKeys(checkin_month);
            txtCheckin_monthday.SendKeys(checkin_monthday);
            txtCheckin_year.SendKeys(checkin_year);
        }

        public void CheckOut(string checkout_month, string checkout_monthday, string checkout_year)
        {
            txtCheckout_month.SendKeys(checkout_month);
            txtCheckout_monthday.SendKeys(checkout_monthday);
            txtCheckout_year.SendKeys(checkout_year);
        }
    }
}
