using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectVtiger.Genric;
using TestProjectVtiger.pom;

namespace TestProjectVtiger.Testscripts
{
    internal class Login:Baseclass
    {
        [Test]
        public void logintovt()
        {


            WebdriverUtility w=new WebdriverUtility();
            w.GoToUrl(driver, "http://localhost:8888/");

            // w.Elementbyname(driver, "user_name").SendKeys("admin");
            //   w.Elementbyname(driver, "user_password").SendKeys("admin");

            // IWebElement us = w.Elementbyname(driver, "user_name");
            // IWebElement pw = w.Elementbyname(driver, "user_password");
            // w.javascriptValue(driver,us,"admin");
            // w.javascriptValue(driver,pw,"admin");

            //   w.Elementbyname(driver, "user_password").SendKeys("admin");



            loginpage l = new loginpage(driver);
            l.SetLoghin("admin", "admin");
            Homepage h = new Homepage(driver);
            h.getHomePage().Click();


            // w.Elementbyxpath(driver, "//td[@class='small']//a[contains(text(),'Organizations')]").Click();
          /*  IWebElement ele = w.Elementbyxpath(driver, "//select[@id='bas_searchfield']");
            w.Handledropdown(ele);
            w.Elementbyxpath(driver, "//img[@title='Create Organization...']").Click();
            w.Elementbyxpath(driver, "//input[@name='accountname']").SendKeys("TESTYANTRA2");
            w.Elementbyxpath(driver, "//input[@name='email1']").SendKeys("abc@yahoo.com");
            w.Elementbyname(driver, "button").Click();
            Thread.Sleep(1000);
            h.setcontactPage();*/
        }
    }
}
