﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

namespace ProjetoSomar.SeleniumPageObjects
{
    class MyViewPageObjects : WebDriver
    {
        public MyViewPageObjects()
        {
            PageFactory.InitElements(DriverFactory.INSTANCE, this);
        }

        [FindsBy(How = How.LinkText, Using = "Unassigned")]
        public IWebElement ltUnsolved { get; set; }

        

         public void VerificaAcessoMyView()
        {
            SeleniumUteis.SeleniumUteis Uteis = new SeleniumUteis.SeleniumUteis();
            WebDriverWait espera = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(5));
            //espera.Until(ExpectedConditions.ElementToBeClickable(ltCategory));
            //método try catch para validar se foi possível acessar a tela inicial
            //Assert.AreEqual("Assigned to Me (Unresolved)", _driver.FindElement(By.LinkText("Assigned to Me (Unresolved)")).Text);
                Uteis.VerificarItem(ltUnsolved, "Unassigned", "");
               
            
        }
    }
}
