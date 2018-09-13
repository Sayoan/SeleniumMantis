using NUnit.Framework;
using OpenQA.Selenium;
using ProjetoSomar.SeleniumPageObjects;
using SeleniumMantis.SeleniumComum;
using SeleniumWebDriver.Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ProjetoSomar.SeleniumTests
{
    class ViewIssuesTests : WebDriver
    {

        [Test]
        [Category("CT")]
        public void ViewIssues_FiltrarTarefaPriority()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();
            homePageObjects.VerificaProjeto();

            homePageObjects.AcessarAbaViewIssue();

            viewIssuesPageObjects.VerificaAcessoViewIssues();
            viewIssuesPageObjects.FiltrarIssue_Prioridade("urgent");
            viewIssuesPageObjects.ValidacaoFiltroTarefa_Priority("urgent");
            Assert.Pass();
            
        }

        [Test]
        [Category("CT")]
        public void ViewIssues_FiltrarTarefaSeverity()
        {
            HomePageObjects homePageObjects = new HomePageObjects();
            ViewIssuesPageObjects viewIssuesPageObjects = new ViewIssuesPageObjects();
            LoginPageObjects loginPageObjects = new LoginPageObjects();

            loginPageObjects.Login();
            homePageObjects.VerificarAcessaLogin();
            homePageObjects.VerificaProjeto();

            homePageObjects.AcessarAbaViewIssue();

            viewIssuesPageObjects.VerificaAcessoViewIssues();
            viewIssuesPageObjects.FiltrarIssue_Severity("minor");
            viewIssuesPageObjects.ValidarFiltroSeverity("minor"); 
            Assert.Pass();
        }



    }
}
