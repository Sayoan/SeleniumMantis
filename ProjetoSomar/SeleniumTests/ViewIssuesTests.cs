﻿using NUnit.Framework;
using OpenQA.Selenium;
using ProjetoSomar.SeleniumPageObjects;
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

            viewIssuesPageObjects.AcessoFiltrar();
            viewIssuesPageObjects.VerificarAcessoFiltrar();
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

            viewIssuesPageObjects.AcessoFiltrar();
            viewIssuesPageObjects.VerificarAcessoFiltrar();
            viewIssuesPageObjects.FiltrarIssue_Severity("trivial");
            viewIssuesPageObjects.ValidacaoFiltroTarefa_Severity("trivial");
            Assert.Pass();
        }



    }
}
