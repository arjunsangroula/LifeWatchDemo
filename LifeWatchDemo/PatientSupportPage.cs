using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeWatchDemo;
using OpenQA.Selenium;

namespace LifeWatchDemo
{
    class PatientSupportPage : PageObjectBase
    {
        public PatientSupportPage(IWebDriver driver) : base(driver)
        {
            driver = this.driver;
        }
        public PatientSupportPage TestPage()
        {
            driver.Navigate().GoToUrl("https://www.grloan.com");
            return new PatientSupportPage(driver);
        }
    }
}
