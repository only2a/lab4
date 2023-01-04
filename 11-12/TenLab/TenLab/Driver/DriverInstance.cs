
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace TenLab.Driver
{
    public class DriverInstance
    {
        private static IWebDriver GetChromeDriver()
        {
            return new ChromeDriver(_driverPath, new ChromeOptions());
        }
        private static IWebDriver _webDriver { get; set; } = null!;

        private static string _driverPath { get; set; } = @"D:\3SEM\SWR\chromedriver_win32\chromedriver_win32";

        public static IWebDriver GetInstance()
        {
            if (_webDriver == null)
            {
                _webDriver = GetChromeDriver();
                _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                _webDriver.Manage().Window.Maximize();
                _webDriver.Navigate().GoToUrl("https://www.wikeo.com/");
            }
            return _webDriver;
        }

        public static void TearDown()
        {
            _webDriver.Quit();
            _webDriver = null;
        }

    }
}
