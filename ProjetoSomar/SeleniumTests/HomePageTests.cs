using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ProjetoSomar.SeleniumComum;
using ProjetoSomar.SeleniumPageObjects;
using ProjetoSomar.SeleniumUteis;
using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ProjetoSomar.SeleniumTests
{
    class HomePageTests : WebDriver
    {
  

        //[Test]
        public void Home_TestesHomePage()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.VerificaProjeto();

        
            

        }
        [Test]
        [Category("Revisados")]
        public void Home_EscolherProjetoTodos()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());
            NUnit.Framework.Assert.Pass();

        }
        [Test]
        [Category("Revisados")]
        public void Home_VerificaLogout()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.Logout();
            loginPageObjects.VerificaAcessoLogin();
            NUnit.Framework.Assert.Pass();


        }

        [Test]
        [Category("Revisados")]
        public void Home_EscolherProjetoSayoan()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());
            homePageObjects.VerificaProjeto();
            NUnit.Framework.Assert.Pass();

        }

        [Test]
        [Category("Revisados")]
        public void Home_VerificaAcessoViewIssues()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();
            

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaViewIssue();
            viewIssuesPageObjects.VerificaAcessoViewIssues();
            NUnit.Framework.Assert.Pass();
        }

        [Test]
        [Category("Revisados")]
        public void Home_VerificaAcessoMyView()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();
            MyViewPageObjects myViewPageObjects = new MyViewPageObjects();


            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyView();
            myViewPageObjects.VerificaAcessoMyView();
            NUnit.Framework.Assert.Pass();


        }

        [Test]
        [Category("Revisados")]
        public void Home_VerificaAcessoSummary()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            SummaryPageObjects summaryPageObjects = new SummaryPageObjects();
           


            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaSummary();
            summaryPageObjects.AcessarAbaSummary();
            NUnit.Framework.Assert.Pass();


        }

        [Test]
        [Category("Revisados")]
        public void Home_VerificaAcessoManage()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            ManagePageObjects managePageObjects = new ManagePageObjects();



            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaManage();
            managePageObjects.VerificarAccessoAbaManage();
            NUnit.Framework.Assert.Pass();


        }

        [Test]
        [Category("Revisados")]
        public void Home_VerificaAcessoMyAccount()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();



            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.VerificarAcessoAbaMyAccount();
            NUnit.Framework.Assert.Pass();


        }

        [Test]
        [Category("Revisados")]
        public void Home_Verificar_ID_Vazio()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();
            MyAccountPageObjects myAccountPageObjects = new MyAccountPageObjects();

            
            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(ConfigurationManager.AppSettings["Projeto"].ToString());
            homePageObjects.VerificaProjeto();

            homePageObjects.ProcurarIssue_Vazia();
            homePageObjects.Verifica_IssueVazia();
            NUnit.Framework.Assert.Pass();



        }



    }
}
