using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Text.RegularExpressions;

namespace AutoTesting
{
    public class Tests
    {
        private IWebDriver driver;

        //private readonly By button = By.LinkText("Добавить в корзину");
        //private readonly By button2 = By.ClassName("mr-md-5");
        //private readonly By count = By.ClassName("cart-count");

        //private readonly By searchBar = By.Name("_nkw");
        //private readonly By searchButton = By.Id("gh-btn");

        private readonly By searchBar = By.Name("story");
        private readonly By searchButton = By.ClassName("fbutton2");
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://kinogo.la/");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void Test1()
        {

            //Thread.Sleep(15000);
            //driver.FindElement(button2).Click();

            //Assert.That(driver.FindElement(count).Text, Is.EqualTo("1"));

            String searchText = "Дом Дракона";

            driver.FindElement(searchBar).Clear();
            driver.FindElement(searchBar).SendKeys(searchText);
            driver.FindElement(searchButton).Click();

            Assert.That(driver.Title, Is.EqualTo("Поиск по сайту » KinoGo.la"));
        }
    }
}