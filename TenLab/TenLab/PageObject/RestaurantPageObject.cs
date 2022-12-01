using OpenQA.Selenium;


namespace TenLab.PageObject
{
    public class RestaurantPageObject
    {

        private IWebDriver _webDriver;

        private readonly By _whiteRabbitItem = By.XPath("/html/body/div[5]/div[3]/div/a[1]");

        public RestaurantPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public CertainRestaurantPageObject GoToСertainRestaurant()
        {
            _webDriver.FindElement(_whiteRabbitItem).Click();
            return new CertainRestaurantPageObject(_webDriver);
        }   
    }
}
