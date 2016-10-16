using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeWatchDemo;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using NUnit;
using NUnit.Framework;

namespace LifeWatchDemo
{
    class AboutUsPage : PageObjectBase
    {
        public AboutUsPage (IWebDriver driver) : base(driver)
        {
            driver = this.driver;
        }


    }


}