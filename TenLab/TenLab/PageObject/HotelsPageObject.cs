using OpenQA.Selenium;
using System.Threading;

namespace TenLab.PageObject
{
    public class HotelsPageObject
    {

        private IWebDriver _webDriver;

        private readonly By _lowCost = By.XPath("/html/body/div[3]/div[3]/div/div/div[2]/div[2]/div/div[1]/span");

        private readonly By _tverskayaStreet = By.XPath("/html/body/div[3]/div[3]/div/div/div[4]/div[2]/div[2]/span[1]");
        private readonly By _certainHotel = By.XPath("/html/body/div[5]/div[5]/div/a[6]");


        public HotelsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void SetParametersandChoose() 
        {
          
            _webDriver.FindElement(_lowCost).Click();
            _webDriver.FindElement(_tverskayaStreet).Click();
            Thread.Sleep(3000);
            _webDriver.FindElement(_certainHotel).Click();

        }
   
    }
}
