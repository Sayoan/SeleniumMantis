using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using ProjetoSomar.SeleniumComum;
using ProjetoSomar.SeleniumPageObjects;
using ProjetoSomar.SeleniumUteis;
using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ProjetoSomar.SeleniumTests
{
    class HomePageTests : WebDriver
    {
        public String Projeto = "SayoanOliveira";
        public String ProjetoAll = "All Projects";

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
            homePageObjects.EscolherProjeto(ProjetoAll);


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



        }

        [Test]
        [Category("Revisados")]
        public void Home_EscolherProjetoSayoan()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();

            loginPageObjects.Login();

            homePageObjects.VerificarAcessaLogin();
            homePageObjects.EscolherProjeto(Projeto);
            homePageObjects.VerificaProjeto();


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
            homePageObjects.EscolherProjeto(Projeto);

            homePageObjects.AcessarAbaViewIssue();
            viewIssuesPageObjects.VerificaAcessoViewIssues();
            
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
            homePageObjects.EscolherProjeto(Credentials.Projeto);

            homePageObjects.AcessarAbaMyView();
            myViewPageObjects.VerificaAcessoMyView();

            

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
            homePageObjects.EscolherProjeto(Projeto);

            homePageObjects.AcessarAbaSummary();
            summaryPageObjects.AcessarAbaSummary();



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
            homePageObjects.EscolherProjeto(Projeto);

            homePageObjects.AcessarAbaManage();
            managePageObjects.VerificarAccessoAbaManage();



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
            homePageObjects.EscolherProjeto(Credentials.Projeto);

            homePageObjects.AcessarAbaMyAccount();
            myAccountPageObjects.VerificarAcessoAbaMyAccount();



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
            homePageObjects.EscolherProjeto(Projeto);
            homePageObjects.VerificaProjeto();

            homePageObjects.ProcurarIssue_Vazia();
            homePageObjects.Verifica_IssueVazia();




        }



    }
}
