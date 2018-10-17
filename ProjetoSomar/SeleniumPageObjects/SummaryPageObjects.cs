using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ProjetoSomar.SeleniumUteis;
using SeleniumMantis.SeleniumComum;
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
        PageFactory.InitElements(DriverFactory.INSTANCE, this);
    }

        [FindsBy(How = How.XPath, Using = "//table[3]/tbody/tr/td")]
        public IWebElement ltSummary { get; set; }


        public void AcessarAbaSummary()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
          

                Uteis.VerificarItem(ltSummary, "Summary", "");
           


        }

    }
}