using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

using OpenQA.Selenium.Support.PageObjects;


namespace LifeWatchDemo
{
    public class PageObjectBase
    {
        
       
        protected IWebDriver driver;

        public PageObjectBase(IWebDriver driver)
        {
            this.driver = driver;
        }
       
    }
}
        
   

