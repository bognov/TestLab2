using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Test
    {
        [Test]
        public void TestGit()
        {
            IWebDriver Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("http://www.github.com/");
            IWebElement ButtonSignIn = Driver.FindElement(By.XPath("//a[text()='Sign in']"));
            ButtonSignIn.Click();

            IWebElement InputUsername = Driver.FindElement(By.XPath("//input[@id='login_field']"));
            InputUsername.SendKeys("bognov");
            IWebElement InputPassword = Driver.FindElement(By.XPath("//input[@id='password']"));
            InputPassword.SendKeys("IWontTellUMyPass");
            IWebElement Button = Driver.FindElement(By.XPath("//input[@value='Sign in']"));
            ButtonSignIn.Click();
        }
    }
}

