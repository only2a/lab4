using OpenQA.Selenium;


namespace TenLab.PageObject
{
    public class MainMenuPageObject
    {

        private IWebDriver _webDriver;

        private readonly By _restaurantMenuItem = By.XPath("/html/body/div[3]/div/div/div[2]/a[3]");
        private readonly By _hotelMenuItem = By.XPath("/html/body/div[3]/div/div/div[2]/a[4]");

        public MainMenuPageObject(IWebDriver webDriver) 
        {
            _webDriver = webDriver;
        }

        public RestaurantPageObject GotoRestaurantePage() 
        {
            _webDriver.FindElement(_restaurantMenuItem).Click();
            return new RestaurantPageObject(_webDriver);
        }

        public HotelsPageObject GotoHotelsPage()
        {
            _webDriver.FindElement(_hotelMenuItem).Click();
            return new HotelsPageObject(_webDriver);
        }

    }
}
