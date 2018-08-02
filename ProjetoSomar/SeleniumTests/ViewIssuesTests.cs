using NUnit.Framework;
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
        [Category("Bugado")]
        public void ViewIssues_FiltrarTarefa()
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
        }

        



    }
}
