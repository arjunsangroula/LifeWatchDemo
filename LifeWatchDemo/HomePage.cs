using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using LifeWatchDemo;

namespace LifeWatchDemo
{
    class HomePage : PageObjectBase
    {
        public HomePage (IWebDriver driver) : base(driver)
        {
            driver = this.driver;   
        }

        public HomePage Launch()
        {
            driver.Navigate().GoToUrl("https://guaranteedrate.com");

            return new HomePage(driver);
        }
    }

}
