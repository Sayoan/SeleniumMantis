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
    class ManagePageObjects : WebDriver
    {
        public ManagePageObjects()
        {
            PageFactory.InitElements(WebDriver._driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Manage")]
        public IWebElement ltManage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Manage Projects")]
        public IWebElement ltManageVerifica { get; set; }

       
        public void VerificarAccessoAbaManage()
        {
            SeleniumMaps Maps = new SeleniumMaps();
            WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.VerificarItem(ltManageVerifica,"Manage Projects","");

            }
            catch (Exception e)
            {
                NUnit.Framework.Assert.Fail(e.ToString());
            }


        }
    }
}

