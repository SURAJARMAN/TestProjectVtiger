using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectVtiger.pom
{
    internal class loginpage
    {
        [FindsBy(How = How.Name, Using = "user_name")]
        private IWebElement usnm { get; set; }

        [FindsBy(How = How.Name, Using = "user_password")]
        private IWebElement pswd { get; set; }
        [FindsBy(How = How.Id, Using = "submitButton")]
        private IWebElement submit { get; set; }


        public void SetLoghin(String us, string pwd)
        {
            usnm.SendKeys(us);
            pswd.SendKeys(pwd);
            submit.Click();
        }
        public loginpage(IWebDriver driver)
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
