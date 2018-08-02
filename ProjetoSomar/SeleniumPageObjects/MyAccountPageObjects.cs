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
    class MyAccountPageObjects : WebDriver
{
        public MyAccountPageObjects()
        {
            PageFactory.InitElements(WebDriver._driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "My Account")]
        public IWebElement ltAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//form/table/tbody/tr/td")]
        public IWebElement editAccount { get; set; }




        //Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
        


        public void VerificarAcessoAbaMyAccount()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                // Assert.AreEqual("Edit Account", _driver.FindElement(By.XPath("//form/table/tbody/tr/td")).Text);
                Maps.VerificarItem(editAccount, "Edit Account", "");

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }

    }
}