using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace Test.Pages
{
    class MyMirPage
    {
        private IWebDriver driver;
        private const string BASE_URL = "https://mail.ru/";

        [FindsBy(How = How.XPath, Using = "//input[@class='l-loginform_row_label_input']")]
        private IWebElement usernameTextBox2;

        [FindsBy(How = How.XPath, Using = "//input[@tabindex='2']")]
        private IWebElement passwordTextBox2;

        [FindsBy(How = How.XPath, Using = "//input[@class='ui-button-main']")]
        private IWebElement buttonSubmit2;

        [FindsBy(How = How.XPath, Using = "//span[text()='Мой Мир']")]
        private IWebElement buttonOpenMyMir;

        [FindsBy(How = How.XPath, Using = "//a[@class='b-welcome-game__logo']")]
        private IWebElement searchResultMarker3;

        [FindsBy(How = How.XPath, Using = "//i[@class='x-ph__menu__button__text x-ph__menu__button__text_auth']")]
        private IWebElement buttonCloseMyMir;

        [FindsBy(How = How.XPath, Using = "//span[@class='x-ph__button__fake']")]
        private IWebElement buttonExitMyMir;

        [FindsBy(How = How.XPath, Using = "//a[text()='Зарегистрируйтесь сейчас']")]
        private IWebElement searchResultMarker4;

         public MyMirPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        public void OpenMyMir(string username, string password)
        {
            buttonOpenMyMir.Click();
            usernameTextBox2.SendKeys(username);
            passwordTextBox2.SendKeys(password);
            buttonSubmit2.Click();
        }

        public bool OpenCompletedMyMir()
        {
            return searchResultMarker3.Displayed;
        }

        public void CloseMyMir()
        {
            buttonCloseMyMir.Click();
            buttonExitMyMir.Click();
        }

        public bool CloseCompletedMyMir() 
        {
            return searchResultMarker4.Displayed;
        }

    }
}
