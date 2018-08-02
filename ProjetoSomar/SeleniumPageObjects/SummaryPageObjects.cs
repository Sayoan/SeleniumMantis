using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoSomar.SeleniumUteis;
using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSomar.SeleniumPageObjects{
    class SummaryPageObjects : WebDriver { 
        public SummaryPageObjects()
    {
        PageFactory.InitElements(WebDriver._driver, this);
    }

        [FindsBy(How = How.XPath, Using = "//table[3]/tbody/tr/td")]
        public IWebElement ltSummary { get; set; }


        public void AcessarAbaSummary()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {

                Maps.VerificarItem(ltSummary, "Summary", "");
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

    }
}