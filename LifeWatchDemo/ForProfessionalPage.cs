using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace LifeWatchDemo
{
   public  class ForProfessionalPage : PageObjectBase
    {
        public ForProfessionalPage(IWebDriver driver) : base(driver)
        {
           driver = this.driver;
        }
        public ForProfessionalPage VerifyTextContent()
        {
            return new ForProfessionalPage(driver);
        }
    }
}
