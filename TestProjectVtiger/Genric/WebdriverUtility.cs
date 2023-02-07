using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectVtiger.Genric
{
    public class WebdriverUtility
    {
        public void GoToUrl(IWebDriver driver, string url)
        {

            driver.Navigate().GoToUrl(url);
        }

        public IWebElement Elementbyid(IWebDriver driver, string id)
        {
            return driver.FindElement(By.Id(id));
        }
        public IWebElement Elementbyname(IWebDriver driver, string name)
        {
            return driver.FindElement(By.Name(name));
        }
        public IWebElement Elementbyxpath(IWebDriver driver, string xpath)
        {
            return driver.FindElement(By.XPath(xpath));
        }
        public void ImplicityWait(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public void explicityWait(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void alert(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }
        public void alertDismis(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Dismiss();

        }
        public void frame(IWebDriver driver, int index)
        {
            driver.SwitchTo().Frame(index);
        }

        public void frameElement(IWebDriver driver, IWebElement element)
        {
            driver.SwitchTo().Frame(element);
        }
        public void Handledropdown(IWebElement element)
        {
            SelectElement s = new SelectElement(element);
            s.SelectByValue("website");

        }
        public void HandleMouseAction(IWebDriver driver, IWebElement elemenmt)
        {
            Actions a = new Actions(driver);
            a.MoveToElement(elemenmt).Perform();

        }
        public void HandleMouseRightclick(IWebDriver driver, IWebElement elemenmt)
        {

            Actions a = new Actions(driver);
            a.ContextClick(elemenmt).Perform();

        }
        public void javascriptValue(IWebDriver driver, IWebElement element, string value)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("argument[0].value='" + value + "'", element);

        }

        /*public void JavascriptToClick(IWebDriver driver, IWebElement element)
        {

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("argumemnt[0].click()", element);

        }*/
    }

}
