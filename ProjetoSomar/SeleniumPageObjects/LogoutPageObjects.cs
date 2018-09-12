using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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
    class LogoutPageObjects
    {
        public LogoutPageObjects()
        {
            PageFactory.InitElements(DriverFactory.INSTANCE, this);
        }
        [FindsBy(How = How.ClassName, Using = "form-title")]
        public IWebElement txtLostPassword { get; set; }

        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement tfUsername { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement tfEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='E-mail'])[1]/following::input[2]")]
        public IWebElement btSubmit { get; set; }

        [FindsBy(How = How.LinkText, Using = "Login")]
        public IWebElement btLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='APPLICATION ERROR #1200'])[1]/following::p[1]")]
        public IWebElement txtFalha1 { get; set; }

         [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='APPLICATION ERROR #1903'])[1]/following::p[1]")]
        public IWebElement txtFalha2 { get; set; }

        [FindsBy(How = How.XPath, Using = "(.//*[normalize-space(text()) and normalize-space(.)='Proceed'])[1]/preceding::b[1]")]
        public IWebElement txtEmailEnviado { get; set; }

       
        
        public void VerificarLostPassword()
        {
            //implementar

            SeleniumMaps Maps = new SeleniumMaps();

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.VerificarItem(txtLostPassword, "Password Reset", "");


            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }

        public void InserirUserName_Email(String Email, String Username)
        {
            //implementar

            SeleniumMaps Maps = new SeleniumMaps();

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.PreencherCampo(tfUsername, "", Username);
                Maps.PreencherCampo(tfEmail, "", Email);
                Maps.ClicarBotao(btSubmit,"");


            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }

       

        public void VerificarFeedbackErro1()
        {
            //implementar

            SeleniumMaps Maps = new SeleniumMaps();

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.VerificarItem(txtFalha1, "Invalid e-mail address.","");


            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }


        public void VerificarFeedbackErro2()
        {
            //implementar

            SeleniumMaps Maps = new SeleniumMaps();

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.VerificarItem(txtFalha2, "The provided information does not match any registered account!", "");


            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }

        public void VerificarEmailEnviado()
        {
            //implementar

            SeleniumMaps Maps = new SeleniumMaps();

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.VerificarItem(txtEmailEnviado, "Password Message Sent", "");


            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }


        public void VoltarLogin()
        {
            //implementar

            SeleniumMaps Maps = new SeleniumMaps();

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.ClicarBotao(btLogin);



            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }


    }
}
