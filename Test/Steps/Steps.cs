using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Test.Steps
{
    class Steps
    {
        IWebDriver driver;

        public void Init()
        {
            driver = DDriver.GetInstance();
        }    

        public void LogIn(string username, string password)
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            mainpage.OpenPage();
            mainpage.Login(username, password);
        }

        public bool IsLoggedIn(string username)
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            return (mainpage.GetLoggedInUserName().Trim().ToLower().Equals(username));
        }

        public void LogOut(string username, string password)
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            mainpage.OpenPage();
            mainpage.Login(username, password);
            mainpage.Logout();
        }

        public bool IsLoggedOut()
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            return mainpage.LoginButtonExist();
        }

        public void SendMes(string mail, string username, string password)
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            mainpage.OpenPage();
            mainpage.Login(username, password);
            mainpage.Send(mail);
        }

        public bool IsSendMes()
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            return mainpage.WriteButtonExist();
        }

        public void CreateDraft(string text, string username, string password)
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            mainpage.OpenPage();
            mainpage.Login(username, password);
            mainpage.CreateDraft(text);
        }

        public bool IsCreateDraft()
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            return mainpage.DraftButtonExit();
        }

        public void SearchWorking(string input)
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            mainpage.OpenPage();
            mainpage.Search(input);
        }

        public bool IsSearchWorking()
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            return mainpage.SearchCompleted();
        }

    }
}
