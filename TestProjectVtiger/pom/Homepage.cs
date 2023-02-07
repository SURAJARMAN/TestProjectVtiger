using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectVtiger.pom
{
    internal class Homepage
    {
        [FindsBy(How = How.XPath, Using = "//img[@style='width:16px;height:16px;']")]
        private IWebElement hmbtn;

        [FindsBy(How = How.XPath, Using = "//td[@class='small']//a[contains(text(),'Leads')]")]
        private IWebElement leadbtn;

        [FindsBy(How = How.XPath, Using = "//td[@class='small']//a[contains(text(),'Organizations')]")]
        private IWebElement orgbtn;

        [FindsBy(How = How.XPath, Using = "//td[@class='small']//a[contains(text(),'Contacts')]")]
        private IWebElement cntbtn;

        public IWebElement getHomePage()
        {
            return this.orgbtn;
        }
        public void setcontactPage()
        {
            cntbtn.Click();
        }
        public Homepage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
