using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using LifeWatchDemo;
using OpenQA.Selenium.Support.PageObjects;

namespace LifeWatchDemo
{
    public class ContactUsPage : PageObjectBase
    {

       public  ContactUsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
            
        }
       public ContactUsPage EnterContactInfo()
        {
            driver.FindElement(By.Id("Enter Contact Info")).Click();

            return new ContactUsPage(driver);
        }
    }
}
    