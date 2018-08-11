using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSomar.SeleniumUteis
{
    class SeleniumMaps : WebDriver
    {

        public SeleniumMaps() 
        {

            PageFactory.InitElements(WebDriver._driver, this);

        }
        public void ClicarBotao(IWebElement iwebelement, String label)
        {
            try
            {
                WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
                espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));
                iwebelement.Click();
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }

        }

        public void ClicarBotao(IWebElement iwebelement)
        {
            try
            {
                WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
                espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));
                iwebelement.Click();
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }

        }

       

        public void PreencherCampo(IWebElement iwebelement, String label, String text)
        {
            try
            {
                WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
                espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));
                iwebelement.Clear();
                iwebelement.SendKeys(text);
                
            }
            catch(Exception e)
            {
                Assert.Fail(e.ToString());
            }


        }
        public void CBClick(IWebElement iwebelement, String label, String text)
        {
            try
            {
                WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
                espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));
               
               
                iwebelement.Click();
                new SelectElement(iwebelement).SelectByText(text);
                iwebelement.Click();
              


            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }


        }

        public void CBClick_ElementoAusente(IWebElement iwebelement, String label, String text)
        {
            try
            {
                WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
                espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));


                iwebelement.Click();
                new SelectElement(iwebelement).SelectByText(text);
                iwebelement.Click();

                Assert.Fail();



            }
            catch 
            {
                Assert.IsTrue(true);
            }


        }


        public void VerificarItem(IWebElement iwebelement, string text, string label)
        {
            try
            {
                WebDriverWait espera = new WebDriverWait(WebDriver._driver, TimeSpan.FromSeconds(5));
                espera.Until(ExpectedConditions.ElementToBeClickable(iwebelement));
                NUnit.Framework.Assert.AreEqual(text, iwebelement.Text);
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }

        public void PegarValor(IWebElement iwebelement, string label)
        {
            try
            {
                NUnit.Framework.Assert.AreEqual(label, iwebelement.Text);
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }

        public void LimparCampo(IWebElement iwebelement)
        {
            try
            {
                iwebelement.Clear();
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }


    }
}
