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

            SeleniumUteis Uteis = new SeleniumUteis();
           



            //método try catch para validar se foi possível acessar a tela inicial
           
            
                Uteis.PreencherCampo(tfUsername, "username", username);
                Uteis.PreencherCampo(tfPassword, "password", password);
                Uteis.ClicarBotao(btSubmit, "//input[@value='Login']");
                
           
        }

        /// <summary>
        /// Método para verificar o acesso á Página Inicial
        /// </summary>


    

        public void WrongLogin()
        {
            //implementar

            SeleniumUteis Uteis = new SeleniumUteis();
            String username = "sayoan.oliveira";
            String password = "";



            //método try catch para validar se foi possível acessar a tela inicial
           
                Uteis.PreencherCampo(tfUsername, "username", username);
                Uteis.PreencherCampo(tfPassword, "password", password);
                Uteis.ClicarBotao(btSubmit, "//input[@value='Login']");
                Uteis.VerificarItem(txtWrongLogin, "Your account may be disabled or blocked or the username/password you entered is incorrect.", "");
               

        }

        public void LoginVazio()
        {
            //implementar

            SeleniumUteis Uteis = new SeleniumUteis();
            String username = "";
            String password = "";



            //método try catch para validar se foi possível acessar a tela inicial
          
                Uteis.PreencherCampo(tfUsername, "username", username);
                Uteis.PreencherCampo(tfPassword, "password", password);
                Uteis.ClicarBotao(btSubmit, "//input[@value='Login']");
                Uteis.VerificarItem(txtWrongLogin, "Your account may be disabled or blocked or the username/password you entered is incorrect.", "");


            
        }



        public void AcessarLostPassword()
    {
        //implementar

        SeleniumUteis Uteis = new SeleniumUteis();
        
        //método try catch para validar se foi possível acessar a tela inicial
        
                Uteis.ClicarBotao(ltLostPassword, "Lost your password ?");
             

       
    }

       

        public void VerificaAcessoLogin()
        {
            //implementar

            SeleniumUteis Uteis = new SeleniumUteis();

            //método try catch para validar se foi possível acessar a tela inicial
                           
                Uteis.VerificarItem(txtUsername, "Username", "");
                Uteis.VerificarItem(txtPassword, "Password", "");

        }

    }

}

