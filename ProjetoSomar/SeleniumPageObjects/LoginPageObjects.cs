using NUnit.Framework;
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

namespace Test
{
    public class LoginPageObjects : WebDriver
    {
        public LoginPageObjects()
        {
            PageFactory.InitElements(DriverFactory.INSTANCE, this);
        }


        [FindsBy(How = How.Name, Using = "username")]
        public IWebElement tfUsername { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement tfPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Login']")]
        public IWebElement btSubmit { get; set; }

        [FindsBy(How = How.XPath, Using = "//font")]
        public IWebElement txtWrongLogin { get; set; }

        [FindsBy(How = How.LinkText, Using = "Lost your password?")]
        public IWebElement ltLostPassword { get; set; }

        [FindsBy(How = How.ClassName, Using = "form-title")]
        public IWebElement txtLostPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[2]/td")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[3]/td")]
        public IWebElement txtPassword { get; set; }


        public static String username = "sayoan.oliveira";
        public static String password = "automacaobase2";



        public void Login()
        {
            //implementar

            SeleniumMaps Maps = new SeleniumMaps();
           



            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
            
                Maps.PreencherCampo(tfUsername, "username", username);
                Maps.PreencherCampo(tfPassword, "password", password);
                Maps.ClicarBotao(btSubmit, "//input[@value='Login']");
                
            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }

        /// <summary>
        /// Método para verificar o acesso á Página Inicial
        /// </summary>


    

        public void WrongLogin()
        {
            //implementar

            SeleniumMaps Maps = new SeleniumMaps();
            String username = "sayoan.oliveira";
            String password = "";



            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.PreencherCampo(tfUsername, "username", username);
                Maps.PreencherCampo(tfPassword, "password", password);
                Maps.ClicarBotao(btSubmit, "//input[@value='Login']");
                Maps.VerificarItem(txtWrongLogin, "Your account may be disabled or blocked or the username/password you entered is incorrect.", "");
               

            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }

        public void LoginVazio()
        {
            //implementar

            SeleniumMaps Maps = new SeleniumMaps();
            String username = "";
            String password = "";



            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                Maps.PreencherCampo(tfUsername, "username", username);
                Maps.PreencherCampo(tfPassword, "password", password);
                Maps.ClicarBotao(btSubmit, "//input[@value='Login']");
                Maps.VerificarItem(txtWrongLogin, "Your account may be disabled or blocked or the username/password you entered is incorrect.", "");


            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }



        public void AcessarLostPassword()
    {
        //implementar

        SeleniumMaps Maps = new SeleniumMaps();
        
        //método try catch para validar se foi possível acessar a tela inicial
        try
        {
                Maps.ClicarBotao(ltLostPassword, "Lost your password ?");
             

        }
        catch (Exception e)
        {
            Assert.Fail(e.ToString());
        }
    }

       

        public void VerificaAcessoLogin()
        {
            //implementar

            SeleniumMaps Maps = new SeleniumMaps();

            //método try catch para validar se foi possível acessar a tela inicial
            try
            {
                
                Maps.VerificarItem(txtUsername, "Username", "");
                Maps.VerificarItem(txtPassword, "Password", "");


            }
            catch (Exception e)
            {
                Assert.Fail(e.ToString());
            }
        }

    }

}

