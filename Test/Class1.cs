using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Test
{  
    [TestFixture]
    public class Class1
    {       
            [TestCase]
            public void AddTest()
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(@"https://e.mail.ru/messages/inbox/");
                Assert.AreEqual(30, 31);
            }

            [TestCase]
            public void SubtractTest()
            {
                
                Assert.AreEqual(10, 10);
        }
    }
}
