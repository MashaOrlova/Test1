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

        public void SearchWeather()
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            mainpage.OpenPage();
            mainpage.SeeWeather();
        }

        public bool IsSeeWeather()
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            return mainpage.SeeCompleted();
        }

        public void SearchHoroscopLion()
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            mainpage.OpenPage();
            mainpage.SeeHoroscope();
        }

        public bool IsSearchHoroscope()
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            return mainpage.SeeCompletedHoroscop();
        }

        public void OpenMyMir(string username, string password)
        {
            Pages.MyMirPage mypage = new Pages.MyMirPage(driver);
            mypage.OpenPage();
            mypage.OpenMyMir(username, password);
        }

        public bool IsOpenMyMir()
        {
            Pages.MyMirPage mypage = new Pages.MyMirPage(driver);
            return mypage.OpenCompletedMyMir();
        }

        public void CloseMyMir(string username, string password)
        {
            Pages.MyMirPage mypage = new Pages.MyMirPage(driver);
            mypage.OpenPage();
            mypage.OpenMyMir(username, password);
            mypage.CloseMyMir();
        }

        public bool IsCloseMyMir()
        {
            Pages.MyMirPage mypage = new Pages.MyMirPage(driver);
            return mypage.CloseCompletedMyMir();
        }

        public void SortContact(string username, string password)
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            mainpage.OpenPage();
            mainpage.Login(username, password);
            mainpage.SortContact();
        }

        public bool IsContactSort()
        {
            Pages.MainPage mainpage = new Pages.MainPage(driver);
            return mainpage.SortCompletedContact();
        }
    }
}
