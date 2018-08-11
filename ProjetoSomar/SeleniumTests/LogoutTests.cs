using NUnit.Framework;
using ProjetoSomar.SeleniumComum;
using ProjetoSomar.SeleniumPageObjects;
using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test;

namespace ProjetoSomar.SeleniumTests
{
    class LogoutTests : WebDriver
    {
        [Test]
        [Category("Revisados")]
        public void LostPassword_UserNameVazio_EmailPreenchidoValido()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            LogoutPageObjects logoutPageObjects = new LogoutPageObjects();
            loginPageObjects.AcessarLostPassword();
            logoutPageObjects.VerificarLostPassword();
            logoutPageObjects.InserirUserName_Email(Credentials.Email, "");
            logoutPageObjects.VerificarFeedbackErro2();


        }

        [Test]
        [Category("Revisados")]
        public void LostPassword_UserNameVazio_EmailPreenchidoInvalido()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            LogoutPageObjects logoutPageObjects = new LogoutPageObjects();
            loginPageObjects.AcessarLostPassword();
            logoutPageObjects.VerificarLostPassword();
            logoutPageObjects.InserirUserName_Email("","");
            logoutPageObjects.VerificarFeedbackErro1();


        }

        [Test]
        [Category("Revisados")]
        public void LostPassword_UserNameVazio_EmailVazio()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            LogoutPageObjects logoutPageObjects = new LogoutPageObjects();
            loginPageObjects.AcessarLostPassword();
            logoutPageObjects.VerificarLostPassword();
            logoutPageObjects.InserirUserName_Email("","");
            logoutPageObjects.VerificarFeedbackErro1();


        }

        [Test]
        [Category("Revisados")]
        public void LostPassword_UserNameValido_EmailVazio()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            LogoutPageObjects logoutPageObjects = new LogoutPageObjects();
            loginPageObjects.AcessarLostPassword();
            logoutPageObjects.VerificarLostPassword();
            logoutPageObjects.InserirUserName_Email("", Credentials.Username);
            logoutPageObjects.VerificarFeedbackErro1();


        }

        [Test]
        [Category("Revisados")]
        public void LostPassword_UserNameValido_EmailValido()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            LogoutPageObjects logoutPageObjects = new LogoutPageObjects();
            loginPageObjects.AcessarLostPassword();
            logoutPageObjects.VerificarLostPassword();
            logoutPageObjects.InserirUserName_Email(Credentials.Email, Credentials.Username);
            logoutPageObjects.VerificarEmailEnviado();


        }


        [Test]
        [Category("Revisados")]
        public void LostPassword_RetornarLogin()
        {
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            LogoutPageObjects logoutPageObjects = new LogoutPageObjects();
            loginPageObjects.AcessarLostPassword();
            logoutPageObjects.VerificarLostPassword();
            logoutPageObjects.VoltarLogin();
            loginPageObjects.VerificaAcessoLogin();



        }







    }
}
