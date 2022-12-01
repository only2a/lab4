using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TenLab.PageObject;

namespace TenLab
{
    public class Tests
    {
        private IWebDriver GetChromeDriver()
        {
            return new ChromeDriver(_driverPath, new ChromeOptions());
        }
        private IWebDriver _webDriver { get; set; } = null!;
        private string _driverPath { get; set; } = @"C:\Users\Helen\Desktop\driver";
    
        [SetUp]
        public void SetUp()
        {
            _webDriver = GetChromeDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl("https://wikkeo.com/");
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }

        [Test]
        public void ReservedTableCheck()
        {
            var mainPage = new MainMenuPageObject(_webDriver);
            mainPage.GotoRestaurantePage().GoToСertainRestaurant().ReserveTable();
        }

        [Test]
        public void ChooseHotelCheck()
        {
            var mainPage = new MainMenuPageObject(_webDriver);
            mainPage.GotoHotelsPage().SetParametersandChoose();
        }

    }
}