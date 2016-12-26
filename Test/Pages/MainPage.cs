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
    class MainPage
    {
        private IWebDriver driver;
        private const string BASE_URL = "https://mail.ru/";

        [FindsBy(How = How.XPath, Using = "//input[@name='Login']")]
        private IWebElement usernameTextBox;

        [FindsBy(How = How.XPath, Using = "//input[@name='Password']")]
        private IWebElement passwordTextBox;

        [FindsBy(How = How.XPath, Using = "//input[@id='mailbox__auth__button']")]
        private IWebElement buttonSubmit;

        [FindsBy(How = How.XPath, Using = "//span[text()='Написать письмо']")]
        private IWebElement buttonNewmail;

        [FindsBy(How = How.XPath, Using = "//textarea[@class='js-input compose__labels__input']")]
        private IWebElement textFor;

        [FindsBy(How = How.Id, Using = "PH_logoutLink")]
        private IWebElement buttonExit;

        [FindsBy(How = How.XPath, Using = "//span[text()='Отправить']")]
        private IWebElement buttonSend;

        [FindsBy(How = How.XPath, Using = "//body[@class='mceContentBody increase-font compose2']")]
        private IWebElement buttonText;

        [FindsBy(How = How.Id, Using = "PH_user-email")]
        private IWebElement linkLoggedInUser;

        [FindsBy(How = How.Id, Using = "PH_authMenu_button")]
        private IWebElement userManagementDropDown;

        [FindsBy(How = How.XPath, Using = "//span[text()='Сохранить черновик']")]
        private IWebElement buttonCreateDraft;

        [FindsBy(How = How.Id, Using = "q")]
        private IWebElement searchInput;

        [FindsBy(How = How.Id, Using = "search__button__wrapper__field")]
        private IWebElement searchInputButton;

        [FindsBy(How = How.XPath, Using = "//ul[@class='result']")]
        private IWebElement searchResultMarker;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        public void Login(string username, string password)
        {
            usernameTextBox.SendKeys(username);
            passwordTextBox.SendKeys(password);
            buttonSubmit.Click();
        }

        public void Logout()
        {
            userManagementDropDown.Click();
            buttonExit.Click();
        }
        public void Send(string mail)
        {
            buttonNewmail.Click();
            textFor.SendKeys(mail);
            buttonText.SendKeys(mail);
            buttonSend.Click();           
        }
        public string GetLoggedInUserName()
        {
            return linkLoggedInUser.Text;
        }
        public bool LoginButtonExist()
        {
            return buttonSubmit.Displayed;
        }

        public bool WriteButtonExist()
        {
            return buttonNewmail.Displayed;
        }

        public void CreateDraft(string text)
        {
            buttonNewmail.Click();
            buttonCreateDraft.Click();
        }

        public bool DraftButtonExit()
        {
            return buttonCreateDraft.Displayed;
        }

        public void Search(string input)
        {
            searchInput.SendKeys(input);
            searchInputButton.Click();
        }

        public bool SearchCompleted()
        {
            return searchResultMarker.Displayed;
        }
    }
}
