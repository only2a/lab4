using OpenQA.Selenium;


namespace TenLab.PageObject
{
    public class CertainRestaurantPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _reserveButton = By.XPath("/html/body/div[5]/div[3]/div[3]/a");

        public CertainRestaurantPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void ReserveTable()
        {
            _webDriver.FindElement(_reserveButton).Click();
        }
    }
}
