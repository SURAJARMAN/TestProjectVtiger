using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectVtiger.pom
{
    internal class organisationpage
    {
        [FindsBy(How = How.XPath, Using = "//img[@title='Create Organization...']")]
        private IWebElement createneworg;
        [FindsBy(How = How.XPath, Using = "//input[@name='accountname']")]
        private IWebElement enteraccountname;
        [FindsBy(How = How.XPath, Using = "//input[@name='email1']")]
        private IWebElement enterEmail;
        [FindsBy(How = How.XPath, Using = "//select[@id='bas_searchfield']")]
        private IWebElement dwwebsite;

        public IWebElement getnewaccount()
        {
            return this.createneworg;
        }
        public IWebElement getaccountname()
        {
            return this.enteraccountname;
        }
        public IWebElement getemail()
        {
            return this.enterEmail;
        }
        public organisationpage(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);
        }
        public void setwebsite()
        {
            SelectElement s = new SelectElement(dwwebsite);
            s.SelectByValue("phone");
        }
    }
}
