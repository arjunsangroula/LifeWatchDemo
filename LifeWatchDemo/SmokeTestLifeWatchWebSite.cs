using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.IE;
using NUnit.Framework;
using LifeWatchDemo;
using NUnit;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using OpenQA.Selenium.Interactions.Internal;
using System.Transactions;


namespace LifeWatchDemo
{
    [TestFixture]
    public class Backendtest1
    {

        IWebDriver driver;
        StringBuilder verificationErrors;
        string baseURL;
        string baseURL2;
        string User;
        string Email;
        bool acceptNextAlert = true;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            baseURL = "http://www.lifewatch.com";
           
            verificationErrors = new StringBuilder();
            User = "ColocMove";
            Email = "test@tester.org";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


        [Test]
        public void TestBadLogin() 
        {
            HomePage TestBadcase = new HomePage(driver);
            TestBadcase = TestBadcase.Launch();
            PatientSupportPage grloans = new PatientSupportPage(driver);
            grloans = grloans.TestPage();
            ContactUsPage testContact = new ContactUsPage(driver);
            testContact = testContact.EnterContactInfo();


            


            
        }




        [Test]
        public void testA1cgiregression()
        {


            string connectionString = "Data Source=appdev; Initial Catalog=grionline; Integrated Security=SSPI;";//window authentication

            // string connectionString = "server=CGI3DBPROD; database=CGIWeb; uid= testuser; pwd= ";
            SqlConnection mySqlConnection = new SqlConnection(connectionString);
            Console.WriteLine("Database Connection Successful");
            string selectString =
                "SELECT * " + "FROM borrower " + "WHERE email = 'rajeshx@yahoo.com'";
            SqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = selectString;
            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            DataSet myDataSet = new DataSet();

            mySqlConnection.Open();
            Console.WriteLine("Retreiving rows from the WebUser Table");
            string dataTableName = "grionline";

            mySqlDataAdapter.Fill(myDataSet, dataTableName);

            DataTable myDataTable = myDataSet.Tables[dataTableName];
            foreach (DataRow myDataRow in myDataTable.Rows)
            {


                Assert.AreEqual("Raj", myDataTable.Rows[0]["Firstname"]);
                Assert.AreEqual("rajeshx@yahoo.com", myDataTable.Rows[0]["Email"]);
               // Assert.AreEqual("Sangroula", myDataTable.Rows[0]["Lastname"]);
                Assert.AreEqual("rajeshx@yahoo.com", myDataTable.Rows[0]["Email"]);

            }
            mySqlConnection.Close();




        }
        [Test]
        public void SampleTest() { 

        driver.Navigate().GoToUrl("http://www.lifewatch.com");
        driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[@title='Pay Online']")).Click();
        driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
            driver.FindElement(By.Name("LastName")).Clear();
        driver.FindElement(By.Name("LastName")).SendKeys("Test");
        driver.FindElement(By.Name("FirstName")).Clear();
        driver.FindElement(By.Name("FirstName")).SendKeys("Tester");
        driver.FindElement(By.Name("AccountNumber")).Clear();
        driver.FindElement(By.Name("AccountNumber")).SendKeys("132654987");
        driver.FindElement(By.Name("Amount")).Clear();
        driver.FindElement(By.Name("Amount")).SendKeys("1.00");
        driver.FindElement(By.Name("DOSMM")).Clear();
        driver.FindElement(By.Name("DOSMM")).SendKeys("01");
        driver.FindElement(By.Name("DOSDD")).Clear();
        driver.FindElement(By.Name("DOSDD")).SendKeys("01");
        driver.FindElement(By.Name("DOSYYYY")).Clear();
        driver.FindElement(By.Name("DOSYYYY")).SendKeys("2015");
        driver.FindElement(By.Name("Submit")).Click();
        Assert.AreEqual("LifeWatch Corp. - Pay Online", driver.Title);
            Assert.AreEqual("Please verify lastname, FirstName and Accountnumber and try again", driver.FindElement(By.XPath("//table[@id='LWCabout']/tbody/tr[2]/td/div/table/tbody/tr/td[2]/form/table/tbody/tr[9]/td/b")).Text);
        }

}
}

    


