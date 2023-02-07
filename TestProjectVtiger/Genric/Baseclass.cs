using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestProjectVtiger.Genric
{
    public class Baseclass
    {
        public IWebDriver driver;

        //[OneTimeSetUp]



        [SetUp]
        public void OpenBrowser()
        {
            driver = new ChromeDriver();
           // driver.Navigate().GoToUrl("http://localhost:8888/");


        }
        [TearDown]
        public void closebrowser()
        {
           // driver.Close();
        }
        [OneTimeTearDown]
        public void OnetimeTear()
        {

        }
    }
}
