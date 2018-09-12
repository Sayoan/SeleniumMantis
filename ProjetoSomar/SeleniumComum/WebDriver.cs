using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using ProjetoSomar.SeleniumComum;
using SeleniumMantis.SeleniumComum;
using SeleniumWebDriver.Basics.SeleniumUteis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Basics
{
    //Modificador de acesso public
    public class WebDriver
    {
             


        [SetUp]
        public void Setup()
        {
            DriverFactory.CreateInstance();
            DriverFactory.INSTANCE.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"].ToString());
        }
        
        
        [TearDown]
        public void TearDown()
        {
           DriverFactory.QuitInstace();
        }
    }

}