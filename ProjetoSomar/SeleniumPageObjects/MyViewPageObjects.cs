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

namespace ProjetoSomar.SeleniumPageObjects
{
    class MyViewPageObjects : WebDriver
    {
        public MyViewPageObjects()
        {
            PageFactory.InitElements(WebDriver._driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Assigned to Me (Unresolved)")]
        public IWebElement ltUnsolved { get; set; }

         public void VerificaAcessoMyView()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
            //espera.Until(ExpectedConditions.ElementToBeClickable(ltCategory));
            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                //Assert.AreEqual("Assigned to Me (Unresolved)", _driver.FindElement(By.LinkText("Assigned to Me (Unresolved)")).Text);
                Maps.VerificarItem(ltUnsolved, "Assigned to Me (Unresolved)", "");
               
            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }
        }
    }
}
