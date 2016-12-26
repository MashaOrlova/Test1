using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using Test.Steps;
namespace Test.Tests
{
    class Tests
    {
        private Steps.Steps step = new Steps.Steps();
        private const string username = "mmm-ooo-01@mail.ru";
        private const string password = "bob1234567890";
        private const string mail = "maria-orlova95@mail.ru";
        private const string text = "привет";
        private const string SearchString = "Selenium";

        [SetUp]
        public void Init()
        {
            step.Init();
        }

        [Test]
        public void LogInTest()
        {
            step.LogIn(username, password);
            Assert.True(step.IsLoggedIn(username));
        }

        [Test]
        public void LogOutTest()
        {
            step.LogOut(username, password);
            Assert.True(step.IsLoggedOut());
        }

        [Test]
        public void SendMessTest()
        {
            step.SendMes(mail, username, password);
            Assert.True(step.IsSendMes());
        }
        [Test]
        public void CreateDraftTest()
        {
            step.CreateDraft(text, username, password);
            Assert.True(step.IsCreateDraft());
        }
        [Test]
        public void OneCanUseSearch()
        {
            step.SearchWorking(SearchString);
            Assert.True(step.IsSearchWorking());
        }
    }
}
